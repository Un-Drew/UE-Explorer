﻿using System;
using System.Net;
using System.Web;
using System.Windows.Forms;
using Eliot.Utilities.Net;

namespace UEExplorer.UI.Dialogs
{
	public partial class ExceptionDialog : Form
	{
		public ExceptionDialog()
		{
			InitializeComponent();
		}

		public static void Show( string error, Exception exception )
		{
			ExceptionDialog exceptionDialog = new ExceptionDialog();
			exceptionDialog.ExceptionStack.Text = "Thrown by:" + exception.TargetSite.Name + "\r\n" + exception.StackTrace + exception.InnerException ?? exception.InnerException.StackTrace;
			exceptionDialog.ExceptionStack.Text = exceptionDialog.ExceptionStack.Text.Replace( @"C:\Users\Eliot\Documents\Visual Studio 2010\Projects\", "" );
			exceptionDialog.ExceptionMessage.Text = exception.Message.Replace( @"C:\Users\Eliot\Documents\Visual Studio 2010\Projects\", "" );
			exceptionDialog.ExceptionError.Text = error;
			if( exceptionDialog.ShowDialog() == DialogResult.OK )
			{
				exceptionDialog.SendReport();
			}
		}

		protected void SendReport()
		{
			SendDialog sendDialog = new SendDialog();
			if( sendDialog.ShowDialog() == DialogResult.OK )
			{
				var logData = " exception:\r\n<code>" 
					+ ExceptionMessage.Text + "</code>\r\n\r\nStack:\r\n<code>" 
					+ ExceptionStack.Text;
 
				var postData = "data[reports][log]=" + HttpUtility.UrlEncode(logData)
					+ "&data[reports][title]=" + HttpUtility.UrlEncode(ExceptionError.Text)
					+ "&data[reports][description]=" + HttpUtility.UrlEncode(sendDialog.InfoText.Text)
					+ "&data[reports][reporter_email]=" + HttpUtility.UrlEncode(sendDialog.Email.Text);
				
				try
				{
					WebRequest.Create( Program.WEBSITE_URL + "report/send/" ).Post( postData );  
					MessageBox.Show( "Thanks for reporting this exception occurrance!", 
						"Successful", MessageBoxButtons.OK, MessageBoxIcon.Information 
					);
				}
				catch
				{
					MessageBox.Show( "Failed to send this report. Please try again later!", 
						"Error", MessageBoxButtons.OK, MessageBoxIcon.Error 
					);
				}
			}
		}
	}
}
