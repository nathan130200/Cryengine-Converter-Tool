namespace CryEngineConverterTool
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnSelectCgfExecutablePath = new System.Windows.Forms.Button();
			this.lbxFilesToProcess = new System.Windows.Forms.ListBox();
			this.lbFilesToProcessDesc = new System.Windows.Forms.Label();
			this.gbxOptions = new System.Windows.Forms.GroupBox();
			this.cbFlagsAllowConflict = new System.Windows.Forms.CheckBox();
			this.cbFlagsNoConflict = new System.Windows.Forms.CheckBox();
			this.cbFlagsGroupMeshes = new System.Windows.Forms.CheckBox();
			this.cbFlagSmoothFaces = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbExportFormat = new System.Windows.Forms.Label();
			this.rbExportFormatFbx = new System.Windows.Forms.RadioButton();
			this.rbExportFormatBlender = new System.Windows.Forms.RadioButton();
			this.rbExportFormatCollada = new System.Windows.Forms.RadioButton();
			this.btnSelectObjectsPath = new System.Windows.Forms.Button();
			this.horizontalPanel = new System.Windows.Forms.Panel();
			this.txtObjectsPath = new System.Windows.Forms.TextBox();
			this.txtCgfExecutablePath = new System.Windows.Forms.TextBox();
			this.txtOutputConsole = new System.Windows.Forms.RichTextBox();
			this.btnProcessFiles = new System.Windows.Forms.Button();
			this.btnMoveItemUp = new System.Windows.Forms.Button();
			this.btnAddItem = new System.Windows.Forms.Button();
			this.btnRemoveItem = new System.Windows.Forms.Button();
			this.btnMoveItemDown = new System.Windows.Forms.Button();
			this.linkCreatorGUI = new System.Windows.Forms.LinkLabel();
			this.linkCryEngineConverterTool = new System.Windows.Forms.LinkLabel();
			this.tips = new System.Windows.Forms.ToolTip(this.components);
			this.gbxOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectCgfExecutablePath
			// 
			this.btnSelectCgfExecutablePath.Location = new System.Drawing.Point(356, 8);
			this.btnSelectCgfExecutablePath.Name = "btnSelectCgfExecutablePath";
			this.btnSelectCgfExecutablePath.Size = new System.Drawing.Size(28, 24);
			this.btnSelectCgfExecutablePath.TabIndex = 1;
			this.btnSelectCgfExecutablePath.Text = "...";
			this.btnSelectCgfExecutablePath.UseVisualStyleBackColor = true;
			this.btnSelectCgfExecutablePath.Click += new System.EventHandler(this.btnSelectCgfExecutablePath_Click);
			// 
			// lbxFilesToProcess
			// 
			this.lbxFilesToProcess.AllowDrop = true;
			this.lbxFilesToProcess.FormattingEnabled = true;
			this.lbxFilesToProcess.Location = new System.Drawing.Point(9, 53);
			this.lbxFilesToProcess.Name = "lbxFilesToProcess";
			this.lbxFilesToProcess.Size = new System.Drawing.Size(343, 121);
			this.lbxFilesToProcess.TabIndex = 2;
			this.lbxFilesToProcess.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbxFilesToProcess_DragDrop);
			this.lbxFilesToProcess.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbxFilesToProcess_DragEnter);
			// 
			// lbFilesToProcessDesc
			// 
			this.lbFilesToProcessDesc.AutoSize = true;
			this.lbFilesToProcessDesc.Location = new System.Drawing.Point(20, 36);
			this.lbFilesToProcessDesc.Name = "lbFilesToProcessDesc";
			this.lbFilesToProcessDesc.Size = new System.Drawing.Size(89, 13);
			this.lbFilesToProcessDesc.TabIndex = 3;
			this.lbFilesToProcessDesc.Text = "File(s) to process:";
			// 
			// gbxOptions
			// 
			this.gbxOptions.Controls.Add(this.cbFlagsAllowConflict);
			this.gbxOptions.Controls.Add(this.cbFlagsNoConflict);
			this.gbxOptions.Controls.Add(this.cbFlagsGroupMeshes);
			this.gbxOptions.Controls.Add(this.cbFlagSmoothFaces);
			this.gbxOptions.Controls.Add(this.label1);
			this.gbxOptions.Controls.Add(this.lbExportFormat);
			this.gbxOptions.Controls.Add(this.rbExportFormatFbx);
			this.gbxOptions.Controls.Add(this.rbExportFormatBlender);
			this.gbxOptions.Controls.Add(this.rbExportFormatCollada);
			this.gbxOptions.Location = new System.Drawing.Point(8, 180);
			this.gbxOptions.Name = "gbxOptions";
			this.gbxOptions.Size = new System.Drawing.Size(380, 256);
			this.gbxOptions.TabIndex = 4;
			this.gbxOptions.TabStop = false;
			this.gbxOptions.Text = "Options";
			// 
			// cbFlagsAllowConflict
			// 
			this.cbFlagsAllowConflict.AutoSize = true;
			this.cbFlagsAllowConflict.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bFlagsAllowConflict;
			this.cbFlagsAllowConflict.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bFlagsAllowConflict", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbFlagsAllowConflict.Location = new System.Drawing.Point(24, 232);
			this.cbFlagsAllowConflict.Name = "cbFlagsAllowConflict";
			this.cbFlagsAllowConflict.Size = new System.Drawing.Size(173, 17);
			this.cbFlagsAllowConflict.TabIndex = 8;
			this.cbFlagsAllowConflict.Text = "Allows conflicts in .mtl file name";
			this.cbFlagsAllowConflict.UseVisualStyleBackColor = true;
			this.cbFlagsAllowConflict.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// cbFlagsNoConflict
			// 
			this.cbFlagsNoConflict.AutoSize = true;
			this.cbFlagsNoConflict.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bFlagsNoConflict;
			this.cbFlagsNoConflict.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bFlagsNoConflict", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbFlagsNoConflict.Location = new System.Drawing.Point(24, 208);
			this.cbFlagsNoConflict.Name = "cbFlagsNoConflict";
			this.cbFlagsNoConflict.Size = new System.Drawing.Size(287, 17);
			this.cbFlagsNoConflict.TabIndex = 7;
			this.cbFlagsNoConflict.Text = "Use non-conflicting naming scheme (<cgf File>_out.obj)";
			this.cbFlagsNoConflict.UseVisualStyleBackColor = true;
			this.cbFlagsNoConflict.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// cbFlagsGroupMeshes
			// 
			this.cbFlagsGroupMeshes.AutoSize = true;
			this.cbFlagsGroupMeshes.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bFlagsGroupMeshes;
			this.cbFlagsGroupMeshes.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bFlagsGroupMeshes", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbFlagsGroupMeshes.Location = new System.Drawing.Point(24, 184);
			this.cbFlagsGroupMeshes.Name = "cbFlagsGroupMeshes";
			this.cbFlagsGroupMeshes.Size = new System.Drawing.Size(180, 17);
			this.cbFlagsGroupMeshes.TabIndex = 6;
			this.cbFlagsGroupMeshes.Text = "Group Meshes Into Single Model";
			this.cbFlagsGroupMeshes.UseVisualStyleBackColor = true;
			this.cbFlagsGroupMeshes.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// cbFlagSmoothFaces
			// 
			this.cbFlagSmoothFaces.AutoSize = true;
			this.cbFlagSmoothFaces.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bFlagSmoothFaces;
			this.cbFlagSmoothFaces.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bFlagSmoothFaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbFlagSmoothFaces.Location = new System.Drawing.Point(24, 160);
			this.cbFlagSmoothFaces.Name = "cbFlagSmoothFaces";
			this.cbFlagSmoothFaces.Size = new System.Drawing.Size(94, 17);
			this.cbFlagSmoothFaces.TabIndex = 5;
			this.cbFlagSmoothFaces.Text = "Smooth Faces";
			this.cbFlagSmoothFaces.UseVisualStyleBackColor = true;
			this.cbFlagSmoothFaces.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Flags:";
			// 
			// lbExportFormat
			// 
			this.lbExportFormat.AutoSize = true;
			this.lbExportFormat.Location = new System.Drawing.Point(12, 28);
			this.lbExportFormat.Name = "lbExportFormat";
			this.lbExportFormat.Size = new System.Drawing.Size(75, 13);
			this.lbExportFormat.TabIndex = 3;
			this.lbExportFormat.Text = "Export Format:";
			// 
			// rbExportFormatFbx
			// 
			this.rbExportFormatFbx.AutoSize = true;
			this.rbExportFormatFbx.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bExportFbx;
			this.rbExportFormatFbx.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bExportFbx", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.rbExportFormatFbx.Location = new System.Drawing.Point(28, 100);
			this.rbExportFormatFbx.Name = "rbExportFormatFbx";
			this.rbExportFormatFbx.Size = new System.Drawing.Size(220, 17);
			this.rbExportFormatFbx.TabIndex = 2;
			this.rbExportFormatFbx.TabStop = true;
			this.rbExportFormatFbx.Text = "Export FBX format files (Not Implemented)";
			this.rbExportFormatFbx.UseVisualStyleBackColor = true;
			this.rbExportFormatFbx.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// rbExportFormatBlender
			// 
			this.rbExportFormatBlender.AutoSize = true;
			this.rbExportFormatBlender.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bExportBlend;
			this.rbExportFormatBlender.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bExportBlend", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.rbExportFormatBlender.Location = new System.Drawing.Point(28, 76);
			this.rbExportFormatBlender.Name = "rbExportFormatBlender";
			this.rbExportFormatBlender.Size = new System.Drawing.Size(236, 17);
			this.rbExportFormatBlender.TabIndex = 1;
			this.rbExportFormatBlender.TabStop = true;
			this.rbExportFormatBlender.Text = "Export Blender format files (Not Implemented)";
			this.rbExportFormatBlender.UseVisualStyleBackColor = true;
			this.rbExportFormatBlender.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// rbExportFormatCollada
			// 
			this.rbExportFormatCollada.AutoSize = true;
			this.rbExportFormatCollada.Checked = global::CryEngineConverterTool.Properties.Settings.Default.bExportCollada;
			this.rbExportFormatCollada.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CryEngineConverterTool.Properties.Settings.Default, "bExportCollada", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.rbExportFormatCollada.Location = new System.Drawing.Point(28, 52);
			this.rbExportFormatCollada.Name = "rbExportFormatCollada";
			this.rbExportFormatCollada.Size = new System.Drawing.Size(149, 17);
			this.rbExportFormatCollada.TabIndex = 0;
			this.rbExportFormatCollada.TabStop = true;
			this.rbExportFormatCollada.Text = "Export Collada format files.";
			this.rbExportFormatCollada.UseVisualStyleBackColor = true;
			this.rbExportFormatCollada.CheckedChanged += new System.EventHandler(this.SaveOptionsSettings);
			// 
			// btnSelectObjectsPath
			// 
			this.btnSelectObjectsPath.Location = new System.Drawing.Point(760, 8);
			this.btnSelectObjectsPath.Name = "btnSelectObjectsPath";
			this.btnSelectObjectsPath.Size = new System.Drawing.Size(28, 23);
			this.btnSelectObjectsPath.TabIndex = 6;
			this.btnSelectObjectsPath.Text = "...";
			this.btnSelectObjectsPath.UseVisualStyleBackColor = true;
			this.btnSelectObjectsPath.Click += new System.EventHandler(this.btnSelectObjectsPath_Click);
			// 
			// horizontalPanel
			// 
			this.horizontalPanel.BackColor = System.Drawing.SystemColors.ControlDark;
			this.horizontalPanel.Enabled = false;
			this.horizontalPanel.Location = new System.Drawing.Point(396, 4);
			this.horizontalPanel.MaximumSize = new System.Drawing.Size(1, 99999);
			this.horizontalPanel.MinimumSize = new System.Drawing.Size(1, 100);
			this.horizontalPanel.Name = "horizontalPanel";
			this.horizontalPanel.Size = new System.Drawing.Size(1, 432);
			this.horizontalPanel.TabIndex = 7;
			// 
			// txtObjectsPath
			// 
			this.txtObjectsPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CryEngineConverterTool.Properties.Settings.Default, "ObjectsPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtObjectsPath.Location = new System.Drawing.Point(408, 8);
			this.txtObjectsPath.Name = "txtObjectsPath";
			this.txtObjectsPath.Size = new System.Drawing.Size(348, 20);
			this.txtObjectsPath.TabIndex = 5;
			this.txtObjectsPath.Text = global::CryEngineConverterTool.Properties.Settings.Default.ObjectsPath;
			// 
			// txtCgfExecutablePath
			// 
			this.txtCgfExecutablePath.AllowDrop = true;
			this.txtCgfExecutablePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::CryEngineConverterTool.Properties.Settings.Default, "CgfConverterExecutablePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtCgfExecutablePath.Location = new System.Drawing.Point(9, 9);
			this.txtCgfExecutablePath.Name = "txtCgfExecutablePath";
			this.txtCgfExecutablePath.Size = new System.Drawing.Size(344, 20);
			this.txtCgfExecutablePath.TabIndex = 0;
			this.txtCgfExecutablePath.Text = global::CryEngineConverterTool.Properties.Settings.Default.CgfConverterExecutablePath;
			// 
			// txtOutputConsole
			// 
			this.txtOutputConsole.BackColor = System.Drawing.SystemColors.Control;
			this.txtOutputConsole.DetectUrls = false;
			this.txtOutputConsole.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutputConsole.Location = new System.Drawing.Point(408, 36);
			this.txtOutputConsole.Name = "txtOutputConsole";
			this.txtOutputConsole.ReadOnly = true;
			this.txtOutputConsole.Size = new System.Drawing.Size(436, 368);
			this.txtOutputConsole.TabIndex = 8;
			this.txtOutputConsole.Text = "";
			this.txtOutputConsole.WordWrap = false;
			// 
			// btnProcessFiles
			// 
			this.btnProcessFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProcessFiles.Location = new System.Drawing.Point(740, 408);
			this.btnProcessFiles.Name = "btnProcessFiles";
			this.btnProcessFiles.Size = new System.Drawing.Size(104, 28);
			this.btnProcessFiles.TabIndex = 9;
			this.btnProcessFiles.Text = "CONVERT";
			this.btnProcessFiles.UseVisualStyleBackColor = true;
			// 
			// btnMoveItemUp
			// 
			this.btnMoveItemUp.Location = new System.Drawing.Point(356, 64);
			this.btnMoveItemUp.Name = "btnMoveItemUp";
			this.btnMoveItemUp.Size = new System.Drawing.Size(28, 23);
			this.btnMoveItemUp.TabIndex = 10;
			this.btnMoveItemUp.Text = "/\\";
			this.btnMoveItemUp.UseVisualStyleBackColor = true;
			this.btnMoveItemUp.Click += new System.EventHandler(this.btnMoveItemUp_Click);
			// 
			// btnAddItem
			// 
			this.btnAddItem.Location = new System.Drawing.Point(356, 88);
			this.btnAddItem.Name = "btnAddItem";
			this.btnAddItem.Size = new System.Drawing.Size(28, 23);
			this.btnAddItem.TabIndex = 11;
			this.btnAddItem.Text = "+";
			this.btnAddItem.UseVisualStyleBackColor = true;
			this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
			// 
			// btnRemoveItem
			// 
			this.btnRemoveItem.Location = new System.Drawing.Point(356, 112);
			this.btnRemoveItem.Name = "btnRemoveItem";
			this.btnRemoveItem.Size = new System.Drawing.Size(28, 23);
			this.btnRemoveItem.TabIndex = 12;
			this.btnRemoveItem.Text = "-";
			this.btnRemoveItem.UseVisualStyleBackColor = true;
			this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
			// 
			// btnMoveItemDown
			// 
			this.btnMoveItemDown.Location = new System.Drawing.Point(356, 136);
			this.btnMoveItemDown.Name = "btnMoveItemDown";
			this.btnMoveItemDown.Size = new System.Drawing.Size(28, 23);
			this.btnMoveItemDown.TabIndex = 13;
			this.btnMoveItemDown.Text = "\\/";
			this.btnMoveItemDown.UseVisualStyleBackColor = true;
			this.btnMoveItemDown.Click += new System.EventHandler(this.btnMoveItemDown_Click);
			// 
			// linkCreatorGUI
			// 
			this.linkCreatorGUI.AutoSize = true;
			this.linkCreatorGUI.Location = new System.Drawing.Point(408, 408);
			this.linkCreatorGUI.Name = "linkCreatorGUI";
			this.linkCreatorGUI.Size = new System.Drawing.Size(240, 13);
			this.linkCreatorGUI.TabIndex = 14;
			this.linkCreatorGUI.TabStop = true;
			this.linkCreatorGUI.Text = "GitHub: nathan130200/Cryengine-Converter-Tool";
			this.tips.SetToolTip(this.linkCreatorGUI, "Developer for this GUI Tool.");
			this.linkCreatorGUI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnRequestUrlLink);
			// 
			// linkCryEngineConverterTool
			// 
			this.linkCryEngineConverterTool.AutoSize = true;
			this.linkCryEngineConverterTool.Location = new System.Drawing.Point(408, 424);
			this.linkCryEngineConverterTool.Name = "linkCryEngineConverterTool";
			this.linkCryEngineConverterTool.Size = new System.Drawing.Size(191, 13);
			this.linkCryEngineConverterTool.TabIndex = 15;
			this.linkCryEngineConverterTool.TabStop = true;
			this.linkCryEngineConverterTool.Text = "GitHub: Markemp/Cryengine-Converter";
			this.tips.SetToolTip(this.linkCryEngineConverterTool, "Developer for CryEngine Converter Tool");
			this.linkCryEngineConverterTool.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnRequestUrlLink);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(854, 444);
			this.Controls.Add(this.linkCryEngineConverterTool);
			this.Controls.Add(this.linkCreatorGUI);
			this.Controls.Add(this.btnMoveItemDown);
			this.Controls.Add(this.btnRemoveItem);
			this.Controls.Add(this.btnAddItem);
			this.Controls.Add(this.btnMoveItemUp);
			this.Controls.Add(this.btnProcessFiles);
			this.Controls.Add(this.txtOutputConsole);
			this.Controls.Add(this.horizontalPanel);
			this.Controls.Add(this.btnSelectObjectsPath);
			this.Controls.Add(this.txtObjectsPath);
			this.Controls.Add(this.gbxOptions);
			this.Controls.Add(this.lbFilesToProcessDesc);
			this.Controls.Add(this.lbxFilesToProcess);
			this.Controls.Add(this.btnSelectCgfExecutablePath);
			this.Controls.Add(this.txtCgfExecutablePath);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cry Engine Converter: GUI Tool";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbxOptions.ResumeLayout(false);
			this.gbxOptions.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCgfExecutablePath;
		private System.Windows.Forms.Button btnSelectCgfExecutablePath;
		private System.Windows.Forms.ListBox lbxFilesToProcess;
		private System.Windows.Forms.Label lbFilesToProcessDesc;
		private System.Windows.Forms.GroupBox gbxOptions;
		private System.Windows.Forms.RadioButton rbExportFormatCollada;
		private System.Windows.Forms.RadioButton rbExportFormatFbx;
		private System.Windows.Forms.RadioButton rbExportFormatBlender;
		private System.Windows.Forms.Label lbExportFormat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbFlagsGroupMeshes;
		private System.Windows.Forms.CheckBox cbFlagSmoothFaces;
		private System.Windows.Forms.CheckBox cbFlagsNoConflict;
		private System.Windows.Forms.CheckBox cbFlagsAllowConflict;
		private System.Windows.Forms.TextBox txtObjectsPath;
		private System.Windows.Forms.Button btnSelectObjectsPath;
		private System.Windows.Forms.Panel horizontalPanel;
		private System.Windows.Forms.RichTextBox txtOutputConsole;
		private System.Windows.Forms.Button btnProcessFiles;
		private System.Windows.Forms.Button btnMoveItemUp;
		private System.Windows.Forms.Button btnAddItem;
		private System.Windows.Forms.Button btnRemoveItem;
		private System.Windows.Forms.Button btnMoveItemDown;
		private System.Windows.Forms.LinkLabel linkCreatorGUI;
		private System.Windows.Forms.LinkLabel linkCryEngineConverterTool;
		private System.Windows.Forms.ToolTip tips;
	}
}

