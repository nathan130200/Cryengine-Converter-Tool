using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryEngineConverterTool.Properties;

namespace CryEngineConverterTool
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnSelectCgfExecutablePath_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				ofd.FileName = "*.exe";
				ofd.Filter = "Windows Executable (*.exe)|*.exe";

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					txtCgfExecutablePath.Text = ofd.FileName;
					Settings.Default.CgfConverterExecutablePath = ofd.FileName;
					Settings.Default.Save();
				}
			}
		}

		private void btnSelectObjectsPath_Click(object sender, EventArgs e)
		{
			using (var fd = new FolderBrowserDialog())
			{
				fd.RootFolder = Environment.SpecialFolder.MyComputer;
				fd.ShowNewFolderButton = true;

				if (fd.ShowDialog() == DialogResult.OK)
				{
					txtObjectsPath.Text = fd.SelectedPath;
					Settings.Default.ObjectsPath = fd.SelectedPath;
					Settings.Default.Save();
				}
			}
		}

		private void SaveOptionsSettings(object sender, EventArgs e)
			=> Settings.Default.Save();

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			Settings.Default.Save();
			base.OnFormClosing(e);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
		}

		private void btnMoveItemUp_Click(object sender, EventArgs e)
		{
			MoveItemIndex(true);
		}

		void btnMoveItemDown_Click(object sender, EventArgs e)
		{
			MoveItemIndex(false);
		}

		#region Swap listbox items

		void MoveItemIndex(bool reversed)
		{
			if (lbxFilesToProcess.Items.Count < 2) // two or more items
				return;

			if (lbxFilesToProcess.SelectedItem == null) // no item selected
				return;

			var index = lbxFilesToProcess.SelectedIndex;

			// start element or end element check
			if ((reversed && index == 0) || (!reversed && index == lbxFilesToProcess.Items.Count - 1))
				return;

			var currentItem = lbxFilesToProcess.Items[index];
			lbxFilesToProcess.Items.RemoveAt(index);
			lbxFilesToProcess.Items.Insert(index + (reversed ? -1 : 1), currentItem);
			lbxFilesToProcess.SelectedIndex = index + (reversed ? -1 : 1);
		}

		#endregion

		bool BuildCommandLine(int currentIndex, out ProcessStartInfo psi)
		{
			psi = default;

			var item = lbxFilesToProcess.Items[currentIndex] as ConverterFileInfo;

			if (item == null || item.Processed)
				return false;

			var args = new List<string>();
			args.Add(item.FileName);

			if (cbFlagsNoConflict.Checked)
				args.Add("-noconflict");

			if (cbFlagsAllowConflict.Checked)
				args.Add("-allowconflict");

			args.Add($@"-objectdir ""{txtObjectsPath.Text}""");

			if (rbExportFormatCollada.Checked)
				args.Add("-dae");
			else if (rbExportFormatBlender.Checked)
				args.Add("-blend");
			else if (rbExportFormatFbx.Checked)
				args.Add("-fbx");

			if (cbFlagSmoothFaces.Checked)
				args.Add("-smooth");

			if (cbFlagsGroupMeshes.Checked)
				args.Add("-group");

			psi = new ProcessStartInfo();
			psi.FileName = txtCgfExecutablePath.Text;
			psi.Arguments = string.Join(" ", args);
			psi.WorkingDirectory = Environment.CurrentDirectory;

			return true;
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			this.Enabled = false;

			using (var ofd = new OpenFileDialog())
			{
				ofd.Filter = "CryEngine Converter Supported Files (*.cgf;*.cga;*.skin)|*.cgf;*.cga;*.skin|All Files (*.*)|*.*";
				ofd.Title = "Import files to convert.";
				ofd.Multiselect = true;

				if (ofd.ShowDialog() == DialogResult.OK && ofd.FileNames?.Count() > 0)
				{
					var items = ofd.FileNames.Select(x => new ConverterFileInfo
					{
						FileName = x,
						Processed = false
					});

					foreach (var item in items)
						lbxFilesToProcess.Items.Add(item);
				}
			}

			this.Enabled = true;
		}

		private void btnRemoveItem_Click(object sender, EventArgs e)
		{
			if (lbxFilesToProcess.Items.Count == 0)
				return;

			if (lbxFilesToProcess.SelectedItem == null)
				return;

			var index = lbxFilesToProcess.SelectedIndex;
			lbxFilesToProcess.Items.RemoveAt(index);

			if (lbxFilesToProcess.Items.Count > 0)
				lbxFilesToProcess.SelectedIndex = index > 0 ? index - 1 : 0;
		}

		private void lbxFilesToProcess_DragDrop(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.None;
				return;
			}

			e.Effect = DragDropEffects.Link;
			var items = e.Data.GetData(DataFormats.FileDrop) as string[];

			if (items != null)
			{
				foreach (var item in items)
				{
					if (File.Exists(item))
						lbxFilesToProcess.Items.Add(new ConverterFileInfo { FileName = item, Processed = false });
				}
			}
		}

		private void lbxFilesToProcess_DragEnter(object sender, DragEventArgs e)
		{
			if (!e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.None;
				return;
			}

			e.Effect = DragDropEffects.Link;
		}

		private void OnRequestUrlLink(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(sender == linkCreatorGUI)
				Process.Start("https://github.com/nathan130200/Cryengine-Converter-Tool");
			else if(sender == linkCryEngineConverterTool)
				Process.Start("https://github.com/Markemp/Cryengine-Converter");
		}
	}

	public class ConverterFileInfo
	{
		public string FileName;
		public bool Processed;

		public override string ToString()
		{
			return this.FileName;
		}
	}
}
