﻿using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using UEExplorer.Properties;
using UELib;
using UELib.Core;

namespace UEExplorer.UI.Main
{
    public partial class ProgramConsole : Form
    {
        private ConsoleWriter _ConsoleWriter;

        public ProgramConsole()
        {
            InitializeComponent();

            _ConsoleWriter = new ConsoleWriter(ConsoleOutput);
            Console.SetOut(_ConsoleWriter);
        }

        private void Console_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_ConsoleWriter != null)
            {
                _ConsoleWriter.Close();
                _ConsoleWriter = null;
            }

            Application.Exit();
        }

        private void ProgramConsole_Shown(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            string filePath = args[1];
            if (!File.Exists(filePath))
            {
                Console.WriteLine(Resources.THING_DOESNT_EXIST, filePath);
                return;
            }

            var options = Program.ParseArguments(args);
            foreach (string option in options)
            {
                string primary = option;
                var secondary = string.Empty;
                if (option.Contains("="))
                {
                    string[] doubleOption = option.Split('=');
                    primary = doubleOption[0];
                    secondary = doubleOption[1];
                }

                var closeWhenDone = false;
                switch (primary)
                {
                    case "silent":
                        closeWhenDone = true;
                        Hide();
                        break;

                    case "console":
                        break;

                    case "export":
                    {
                        var shouldExportScripts = false;
                        switch (secondary)
                        {
                            case "classes":
                                break;

                            case "scripts":
                                shouldExportScripts = true;
                                break;

                            default:
                                Console.WriteLine(Resources.UNRECOGNIZED_EXPORT_TYPE, secondary);
                                return;
                        }

                        try
                        {
                            Console.WriteLine(Resources.EXPORTING_PACKAGE, filePath);
                            using (var package = UnrealLoader.LoadFullPackage(filePath))
                            {
                                string exportPath = shouldExportScripts
                                    ? package.ExportPackageObjects<UTextBuffer>()
                                    : package.ExportPackageObjects<UClass>();
                                Console.WriteLine(Resources.PACKAGE_EXPORTED_TO, exportPath);
                            }
                        }
                        catch (Exception exc)
                        {
                            Console.WriteLine(Resources.EXCEPTION_OCCURRED_WHILE_EXPORTING, filePath, exc);
                        }

                        break;
                    }

                    default:
                        Console.WriteLine(Resources.UNRECOGNIZED_COMMANDLINE_OPTION, primary);
                        break;
                }

                if (closeWhenDone) Close();
            }
        }
    }

    public class ConsoleWriter : TextWriter
    {
        private readonly RichTextBox _Output;
        private readonly Encoding _Encoding = Encoding.ASCII;
        private string _LastWrite = string.Empty;
        public override Encoding Encoding => _Encoding;

        public ConsoleWriter(RichTextBox output)
        {
            _Output = output;
        }

        public override void Write(string value)
        {
            string trimmedValue = value.Trim();
            if (trimmedValue == NewLine && _LastWrite == NewLine)
                return;

            base.Write(value);
            _Output.Text += value;
            _LastWrite = trimmedValue;
        }

        public override void WriteLine(string value)
        {
            string trimmedValue = value.Trim();
            if (trimmedValue == NewLine && _LastWrite == NewLine)
                return;

            base.WriteLine(value);
            _Output.Text += NewLine + value;
            _LastWrite = trimmedValue;
        }
    }
}