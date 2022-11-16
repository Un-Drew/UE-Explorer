﻿using System.Windows.Forms;

namespace UEExplorer.UI.ActionPanels
{
    partial class PackageExplorerPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageExplorerPanel));
            this.TreeViewPackages = new System.Windows.Forms.TreeView();
            this.objectContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.VSIcons = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findInDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findInClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportClassesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderByToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.objectContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TreeViewPackages
            // 
            this.TreeViewPackages.AllowDrop = true;
            this.TreeViewPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TreeViewPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TreeViewPackages.ContextMenuStrip = this.objectContextMenu;
            this.TreeViewPackages.FullRowSelect = true;
            this.TreeViewPackages.HideSelection = false;
            this.TreeViewPackages.HotTracking = true;
            this.TreeViewPackages.ImageIndex = 0;
            this.TreeViewPackages.ImageList = this.VSIcons;
            this.TreeViewPackages.Indent = 14;
            this.TreeViewPackages.Location = new System.Drawing.Point(0, 26);
            this.TreeViewPackages.Name = "TreeViewPackages";
            this.TreeViewPackages.SelectedImageIndex = 0;
            this.TreeViewPackages.ShowNodeToolTips = true;
            this.TreeViewPackages.Size = new System.Drawing.Size(502, 436);
            this.TreeViewPackages.TabIndex = 21;
            this.TreeViewPackages.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeViewPackages_BeforeExpand);
            this.TreeViewPackages.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.TreeViewPackages_NodeMouseHover);
            this.TreeViewPackages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeViewPackages_AfterSelect);
            this.TreeViewPackages.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeViewPackages_NodeMouseClick);
            this.TreeViewPackages.DragDrop += new System.Windows.Forms.DragEventHandler(this.TreeViewPackages_DragDrop);
            this.TreeViewPackages.DragOver += new System.Windows.Forms.DragEventHandler(this.TreeViewPackages_DragOver);
            // 
            // objectContextMenu
            // 
            this.objectContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReload});
            this.objectContextMenu.Name = "objectContextMenu";
            this.objectContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.objectContextMenu.Size = new System.Drawing.Size(111, 26);
            this.objectContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.objectContextMenu_Opening);
            this.objectContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.objectContextMenu_ItemClicked);
            // 
            // toolStripMenuItemReload
            // 
            this.toolStripMenuItemReload.Image = global::UEExplorer.Properties.Resources.Refresh;
            this.toolStripMenuItemReload.Name = "toolStripMenuItemReload";
            this.toolStripMenuItemReload.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItemReload.Text = "Reload";
            this.toolStripMenuItemReload.Visible = false;
            this.toolStripMenuItemReload.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenuItemReload_DropDownItemClicked);
            // 
            // VSIcons
            // 
            this.VSIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("VSIcons.ImageStream")));
            this.VSIcons.TransparentColor = System.Drawing.Color.Fuchsia;
            this.VSIcons.Images.SetKeyName(0, "UConst");
            this.VSIcons.Images.SetKeyName(1, "UObject");
            this.VSIcons.Images.SetKeyName(2, "UState");
            this.VSIcons.Images.SetKeyName(3, "Interface");
            this.VSIcons.Images.SetKeyName(4, "Operator");
            this.VSIcons.Images.SetKeyName(5, "Operater-Protected");
            this.VSIcons.Images.SetKeyName(6, "Operator-Private");
            this.VSIcons.Images.SetKeyName(7, "TreeView");
            this.VSIcons.Images.SetKeyName(8, "OutParameter");
            this.VSIcons.Images.SetKeyName(9, "Map");
            this.VSIcons.Images.SetKeyName(10, "UPackage");
            this.VSIcons.Images.SetKeyName(11, "ReturnValue");
            this.VSIcons.Images.SetKeyName(12, "Extend");
            this.VSIcons.Images.SetKeyName(13, "UFunction");
            this.VSIcons.Images.SetKeyName(14, "UFunction-Protected");
            this.VSIcons.Images.SetKeyName(15, "UFunction-Private");
            this.VSIcons.Images.SetKeyName(16, "Content");
            this.VSIcons.Images.SetKeyName(17, "UProperty");
            this.VSIcons.Images.SetKeyName(18, "UProperty-Protected");
            this.VSIcons.Images.SetKeyName(19, "UProperty-Private");
            this.VSIcons.Images.SetKeyName(20, "Diagram");
            this.VSIcons.Images.SetKeyName(21, "Chunks");
            this.VSIcons.Images.SetKeyName(22, "UDefaultProperty");
            this.VSIcons.Images.SetKeyName(23, "UEnum");
            this.VSIcons.Images.SetKeyName(24, "UEnum-Protected");
            this.VSIcons.Images.SetKeyName(25, "UEnum-Private");
            this.VSIcons.Images.SetKeyName(26, "Delegate");
            this.VSIcons.Images.SetKeyName(27, "Delegate-Protected");
            this.VSIcons.Images.SetKeyName(28, "Delegate-Private");
            this.VSIcons.Images.SetKeyName(29, "Event");
            this.VSIcons.Images.SetKeyName(30, "Event-Protected");
            this.VSIcons.Images.SetKeyName(31, "Event-Private");
            this.VSIcons.Images.SetKeyName(32, "UStruct");
            this.VSIcons.Images.SetKeyName(33, "UStruct-Protected");
            this.VSIcons.Images.SetKeyName(34, "UStruct-Private");
            this.VSIcons.Images.SetKeyName(35, "UClass");
            this.VSIcons.Images.SetKeyName(36, "UClass-Abstract");
            this.VSIcons.Images.SetKeyName(37, "UClass-Within");
            this.VSIcons.Images.SetKeyName(38, "USound");
            this.VSIcons.Images.SetKeyName(39, "UTexture");
            this.VSIcons.Images.SetKeyName(40, "USoundGroup");
            this.VSIcons.Images.SetKeyName(41, "UFont");
            this.VSIcons.Images.SetKeyName(42, "UPalette");
            this.VSIcons.Images.SetKeyName(43, "AActor");
            this.VSIcons.Images.SetKeyName(44, "UTextBuffer");
            this.VSIcons.Images.SetKeyName(45, "UnrealPackageFile");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripTextBoxFilter,
            this.toolStripMenuItem1,
            this.orderByToolStripComboBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(502, 27);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemOpen.Enabled = false;
            this.toolStripMenuItemOpen.Image = global::UEExplorer.Properties.Resources.OpenfileDialog;
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(28, 23);
            // 
            // toolStripTextBoxFilter
            // 
            this.toolStripTextBoxFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxFilter.Name = "toolStripTextBoxFilter";
            this.toolStripTextBoxFilter.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxFilter.TextChanged += new System.EventHandler(this.toolStripTextBoxFilter_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findInDocumentToolStripMenuItem,
            this.findInClassesToolStripMenuItem,
            this.exportClassesToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::UEExplorer.Properties.Resources.Code;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 23);
            this.toolStripMenuItem1.Text = "Package";
            this.toolStripMenuItem1.DropDownOpening += new System.EventHandler(this.toolStripMenuItem1_DropDownOpening);
            // 
            // findInDocumentToolStripMenuItem
            // 
            this.findInDocumentToolStripMenuItem.Image = global::UEExplorer.Properties.Resources.FindDown;
            this.findInDocumentToolStripMenuItem.Name = "findInDocumentToolStripMenuItem";
            this.findInDocumentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findInDocumentToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findInDocumentToolStripMenuItem.Text = "Find in Document";
            this.findInDocumentToolStripMenuItem.Click += new System.EventHandler(this.findInDocumentToolStripMenuItem_Click);
            // 
            // findInClassesToolStripMenuItem
            // 
            this.findInClassesToolStripMenuItem.Image = global::UEExplorer.Properties.Resources.FindInFile;
            this.findInClassesToolStripMenuItem.Name = "findInClassesToolStripMenuItem";
            this.findInClassesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.findInClassesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.findInClassesToolStripMenuItem.Text = "Find in Classes";
            this.findInClassesToolStripMenuItem.Click += new System.EventHandler(this.findInClassesToolStripMenuItem_Click);
            // 
            // exportClassesToolStripMenuItem
            // 
            this.exportClassesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportClassesToolStripMenuItem1,
            this.exportScriptsToolStripMenuItem});
            this.exportClassesToolStripMenuItem.Image = global::UEExplorer.Properties.Resources.ExportData;
            this.exportClassesToolStripMenuItem.Name = "exportClassesToolStripMenuItem";
            this.exportClassesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.exportClassesToolStripMenuItem.Text = "Export";
            // 
            // exportClassesToolStripMenuItem1
            // 
            this.exportClassesToolStripMenuItem1.Image = global::UEExplorer.Properties.Resources.ExportScript;
            this.exportClassesToolStripMenuItem1.Name = "exportClassesToolStripMenuItem1";
            this.exportClassesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.exportClassesToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.exportClassesToolStripMenuItem1.Text = "Export Decompiled Classes";
            this.exportClassesToolStripMenuItem1.Click += new System.EventHandler(this.exportClassesToolStripMenuItem1_Click);
            // 
            // exportScriptsToolStripMenuItem
            // 
            this.exportScriptsToolStripMenuItem.Image = global::UEExplorer.Properties.Resources.ExportScript;
            this.exportScriptsToolStripMenuItem.Name = "exportScriptsToolStripMenuItem";
            this.exportScriptsToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.exportScriptsToolStripMenuItem.Text = "Export Decompiled ScriptTexts";
            this.exportScriptsToolStripMenuItem.Click += new System.EventHandler(this.exportScriptsToolStripMenuItem_Click);
            // 
            // orderByToolStripComboBox
            // 
            this.orderByToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByToolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.orderByToolStripComboBox.Items.AddRange(new object[] {
            "SerialOffset",
            "ObjectName"});
            this.orderByToolStripComboBox.Name = "orderByToolStripComboBox";
            this.orderByToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.orderByToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.orderByToolStripComboBox_SelectedIndexChanged);
            // 
            // PackageExplorerPanel
            // 
            this.AllowDrop = true;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TreeViewPackages);
            this.Name = "PackageExplorerPanel";
            this.Size = new System.Drawing.Size(502, 462);
            this.Load += new System.EventHandler(this.PackageExplorerPanel_Load);
            this.objectContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView TreeViewPackages;
        private System.Windows.Forms.ImageList VSIcons;
        private ContextMenuStrip objectContextMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFilter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private ToolStripMenuItem toolStripMenuItemReload;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem findInClassesToolStripMenuItem;
        private ToolStripMenuItem exportClassesToolStripMenuItem;
        private ToolStripMenuItem exportClassesToolStripMenuItem1;
        private ToolStripMenuItem exportScriptsToolStripMenuItem;
        private ToolStripMenuItem findInDocumentToolStripMenuItem;
        private ToolStripComboBox orderByToolStripComboBox;
    }
}
