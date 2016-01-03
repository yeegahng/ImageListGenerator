/*
 * Created by SharpDevelop.
 * User: 송이네
 * Date: 2016-01-01
 * Time: 오후 11:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageListGenerator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton_LoadFileList = new System.Windows.Forms.ToolStripDropDownButton();
			this.listFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listFromFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label_prefix = new System.Windows.Forms.Label();
			this.label_Suffix = new System.Windows.Forms.Label();
			this.textBox_Prefix = new System.Windows.Forms.TextBox();
			this.textBox_Suffix = new System.Windows.Forms.TextBox();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripDropDownButton_LoadFileList});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(526, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton_LoadFileList
			// 
			this.toolStripDropDownButton_LoadFileList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton_LoadFileList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.listFromFolderToolStripMenuItem,
									this.listFromFilesToolStripMenuItem});
			this.toolStripDropDownButton_LoadFileList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton_LoadFileList.Image")));
			this.toolStripDropDownButton_LoadFileList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton_LoadFileList.Name = "toolStripDropDownButton_LoadFileList";
			this.toolStripDropDownButton_LoadFileList.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton_LoadFileList.Text = "toolStripDropDownButton1";
			// 
			// listFromFolderToolStripMenuItem
			// 
			this.listFromFolderToolStripMenuItem.Name = "listFromFolderToolStripMenuItem";
			this.listFromFolderToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.listFromFolderToolStripMenuItem.Text = "List from Folder";
			this.listFromFolderToolStripMenuItem.Click += new System.EventHandler(this.ListFromFolderToolStripMenuItemClick);
			// 
			// listFromFilesToolStripMenuItem
			// 
			this.listFromFilesToolStripMenuItem.Name = "listFromFilesToolStripMenuItem";
			this.listFromFilesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.listFromFilesToolStripMenuItem.Text = "List from Files";
			// 
			// label_prefix
			// 
			this.label_prefix.Location = new System.Drawing.Point(12, 26);
			this.label_prefix.Name = "label_prefix";
			this.label_prefix.Size = new System.Drawing.Size(51, 20);
			this.label_prefix.TabIndex = 1;
			this.label_prefix.Text = "Prefix:";
			this.label_prefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_Suffix
			// 
			this.label_Suffix.Location = new System.Drawing.Point(12, 53);
			this.label_Suffix.Name = "label_Suffix";
			this.label_Suffix.Size = new System.Drawing.Size(51, 20);
			this.label_Suffix.TabIndex = 1;
			this.label_Suffix.Text = "Suffix:";
			this.label_Suffix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_Prefix
			// 
			this.textBox_Prefix.Location = new System.Drawing.Point(57, 25);
			this.textBox_Prefix.Name = "textBox_Prefix";
			this.textBox_Prefix.Size = new System.Drawing.Size(457, 21);
			this.textBox_Prefix.TabIndex = 2;
			// 
			// textBox_Suffix
			// 
			this.textBox_Suffix.Location = new System.Drawing.Point(57, 52);
			this.textBox_Suffix.Name = "textBox_Suffix";
			this.textBox_Suffix.Size = new System.Drawing.Size(457, 21);
			this.textBox_Suffix.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 246);
			this.Controls.Add(this.textBox_Suffix);
			this.Controls.Add(this.textBox_Prefix);
			this.Controls.Add(this.label_Suffix);
			this.Controls.Add(this.label_prefix);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "ImageListGenerator";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox_Suffix;
		private System.Windows.Forms.TextBox textBox_Prefix;
		private System.Windows.Forms.Label label_Suffix;
		private System.Windows.Forms.Label label_prefix;
		private System.Windows.Forms.ToolStripMenuItem listFromFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listFromFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_LoadFileList;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
