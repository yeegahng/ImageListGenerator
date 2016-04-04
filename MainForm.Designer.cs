using System;
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
			this.label_Prefix = new System.Windows.Forms.Label();
			this.label_Suffix = new System.Windows.Forms.Label();
			this.textBox_Prefix = new System.Windows.Forms.TextBox();
			this.textBox_Suffix = new System.Windows.Forms.TextBox();
			this.label_TargetPath = new System.Windows.Forms.Label();
			this.textBox_TargetPath = new System.Windows.Forms.TextBox();
			this.groupBox_Decorator = new System.Windows.Forms.GroupBox();
			this.label_Example = new System.Windows.Forms.Label();
			this.button_GenerateListFile = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			this.groupBox_Decorator.SuspendLayout();
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
			this.listFromFilesToolStripMenuItem.Click += new System.EventHandler(this.ListFromFilesToolStripMenuItemClick);
			// 
			// label_Prefix
			// 
			this.label_Prefix.Location = new System.Drawing.Point(5, 24);
			this.label_Prefix.Name = "label_Prefix";
			this.label_Prefix.Size = new System.Drawing.Size(51, 20);
			this.label_Prefix.TabIndex = 0;
			this.label_Prefix.Text = "Prefix:";
			this.label_Prefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label_Suffix
			// 
			this.label_Suffix.Location = new System.Drawing.Point(5, 51);
			this.label_Suffix.Name = "label_Suffix";
			this.label_Suffix.Size = new System.Drawing.Size(51, 20);
			this.label_Suffix.TabIndex = 0;
			this.label_Suffix.Text = "Suffix:";
			this.label_Suffix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_Prefix
			// 
			this.textBox_Prefix.Location = new System.Drawing.Point(50, 23);
			this.textBox_Prefix.Name = "textBox_Prefix";
			this.textBox_Prefix.Size = new System.Drawing.Size(446, 21);
			this.textBox_Prefix.TabIndex = 2;
			this.textBox_Prefix.TextChanged += new EventHandler(TextBox_PrefixSuffixChanged);
			// 
			// textBox_Suffix
			// 
			this.textBox_Suffix.Location = new System.Drawing.Point(50, 50);
			this.textBox_Suffix.Name = "textBox_Suffix";
			this.textBox_Suffix.Size = new System.Drawing.Size(446, 21);
			this.textBox_Suffix.TabIndex = 3;
			this.textBox_Suffix.TextChanged += new EventHandler(TextBox_PrefixSuffixChanged);
			
			// 
			// label_TargetPath
			// 
			this.label_TargetPath.Location = new System.Drawing.Point(12, 25);
			this.label_TargetPath.Name = "label_TargetPath";
			this.label_TargetPath.Size = new System.Drawing.Size(76, 23);
			this.label_TargetPath.TabIndex = 0;
			this.label_TargetPath.Text = "TargetPath:";
			this.label_TargetPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox_TargetPath
			// 
			this.textBox_TargetPath.Location = new System.Drawing.Point(85, 26);
			this.textBox_TargetPath.Name = "textBox_TargetPath";
			this.textBox_TargetPath.Size = new System.Drawing.Size(429, 21);
			this.textBox_TargetPath.TabIndex = 1;
			// 
			// groupBox_Decorator
			// 
			this.groupBox_Decorator.Controls.Add(this.label_Example);
			this.groupBox_Decorator.Controls.Add(this.textBox_Suffix);
			this.groupBox_Decorator.Controls.Add(this.textBox_Prefix);
			this.groupBox_Decorator.Controls.Add(this.label_Prefix);
			this.groupBox_Decorator.Controls.Add(this.label_Suffix);
			this.groupBox_Decorator.Location = new System.Drawing.Point(12, 67);
			this.groupBox_Decorator.Name = "groupBox_Decorator";
			this.groupBox_Decorator.Size = new System.Drawing.Size(502, 114);
			this.groupBox_Decorator.TabIndex = 0;
			this.groupBox_Decorator.TabStop = false;
			this.groupBox_Decorator.Text = "Filename Decoration";
			// 
			// label_Example
			// 
			this.label_Example.Location = new System.Drawing.Point(23, 85);
			this.label_Example.Name = "label_Example";
			this.label_Example.Size = new System.Drawing.Size(461, 23);
			this.label_Example.TabIndex = 0;
			this.label_Example.Text = "Example)";
			this.label_Example.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_GenerateListFile
			// 
			this.button_GenerateListFile.Location = new System.Drawing.Point(17, 200);
			this.button_GenerateListFile.Name = "button_GenerateListFile";
			this.button_GenerateListFile.Size = new System.Drawing.Size(75, 23);
			this.button_GenerateListFile.TabIndex = 4;
			this.button_GenerateListFile.Text = "Generate List File";
			this.button_GenerateListFile.UseVisualStyleBackColor = true;
			this.button_GenerateListFile.Click += new System.EventHandler(this.Button_GenerateListFileClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 246);
			this.Controls.Add(this.button_GenerateListFile);
			this.Controls.Add(this.groupBox_Decorator);
			this.Controls.Add(this.textBox_TargetPath);
			this.Controls.Add(this.label_TargetPath);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "ImageListGenerator";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox_Decorator.ResumeLayout(false);
			this.groupBox_Decorator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button_GenerateListFile;
		private System.Windows.Forms.Label label_Example;
		private System.Windows.Forms.GroupBox groupBox_Decorator;
		private System.Windows.Forms.TextBox textBox_TargetPath;
		private System.Windows.Forms.Label label_TargetPath;
		private System.Windows.Forms.TextBox textBox_Suffix;
		private System.Windows.Forms.TextBox textBox_Prefix;
		private System.Windows.Forms.Label label_Suffix;
		private System.Windows.Forms.Label label_Prefix;
		private System.Windows.Forms.ToolStripMenuItem listFromFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listFromFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_LoadFileList;
		private System.Windows.Forms.ToolStrip toolStrip1;

	}
}
