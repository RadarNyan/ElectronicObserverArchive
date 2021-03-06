﻿namespace ElectronicObserver.Window
{
	partial class FormLog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ContextMenuLog = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ContextMenuLog_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.LogTextBox = new System.Windows.Forms.RichTextBox();
			this.ContextMenuLog_WrapText = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuLog_CompactMode = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuLog_Inverted = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// ContextMenuLog
			// 
			this.ContextMenuLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuLog_Clear,
            this.ContextMenuLog_WrapText,
            this.ContextMenuLog_CompactMode,
            this.ContextMenuLog_Inverted});
			this.ContextMenuLog.Name = "ContextMenuLog";
			this.ContextMenuLog.Size = new System.Drawing.Size(153, 114);
			// 
			// ContextMenuLog_Clear
			// 
			this.ContextMenuLog_Clear.Name = "ContextMenuLog_Clear";
			this.ContextMenuLog_Clear.Size = new System.Drawing.Size(152, 22);
			this.ContextMenuLog_Clear.Text = "清空(&C)";
			this.ContextMenuLog_Clear.Click += new System.EventHandler(this.ContextMenuLog_Clear_Click);
			// 
			// LogTextBox
			// 
			this.LogTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LogTextBox.ContextMenuStrip = this.ContextMenuLog;
			this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LogTextBox.Location = new System.Drawing.Point(0, 0);
			this.LogTextBox.Name = "LogTextBox";
			this.LogTextBox.ReadOnly = true;
			this.LogTextBox.Size = new System.Drawing.Size(300, 200);
			this.LogTextBox.TabIndex = 1;
			this.LogTextBox.Text = "";
			this.LogTextBox.WordWrap = false;
			this.LogTextBox.GotFocus += new System.EventHandler(this.HideCaret);
			this.LogTextBox.MouseLeave += new System.EventHandler(this.HideCaret);
			// 
			// ContextMenuLog_WrapText
			// 
			this.ContextMenuLog_WrapText.CheckOnClick = true;
			this.ContextMenuLog_WrapText.Name = "ContextMenuLog_WrapText";
			this.ContextMenuLog_WrapText.Size = new System.Drawing.Size(152, 22);
			this.ContextMenuLog_WrapText.Text = "自动换行(&W)";
			this.ContextMenuLog_WrapText.CheckedChanged += new System.EventHandler(this.ContextMenuLog_WrapText_CheckedChanged);
			// 
			// ContextMenuLog_CompactMode
			// 
			this.ContextMenuLog_CompactMode.CheckOnClick = true;
			this.ContextMenuLog_CompactMode.Name = "ContextMenuLog_CompactMode";
			this.ContextMenuLog_CompactMode.Size = new System.Drawing.Size(152, 22);
			this.ContextMenuLog_CompactMode.Text = "精简模式(&C)";
			this.ContextMenuLog_CompactMode.CheckedChanged += new System.EventHandler(this.ContextMenuLog_CompactMode_CheckedChanged);
 			// 
			// ContextMenuLog_Inverted
			// 
			this.ContextMenuLog_Inverted.CheckOnClick = true;
			this.ContextMenuLog_Inverted.Name = "ContextMenuLog_Inverted";
			this.ContextMenuLog_Inverted.Size = new System.Drawing.Size(152, 22);
			this.ContextMenuLog_Inverted.Text = "反向滚动(&I)";
			this.ContextMenuLog_Inverted.CheckedChanged += new System.EventHandler(this.ContextMenuLog_Inverted_CheckedChanged);
			// 
			// FormLog
			// 
			this.AutoHidePortion = 150D;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(300, 200);
			this.Controls.Add(this.LogTextBox);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.HideOnClose = true;
			this.Name = "FormLog";
			this.Text = "日志";
			this.Load += new System.EventHandler(this.FormLog_Load);
			this.ContextMenuLog.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip ContextMenuLog;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuLog_Clear;
		private System.Windows.Forms.RichTextBox LogTextBox;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuLog_WrapText;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuLog_CompactMode;
		private System.Windows.Forms.ToolStripMenuItem ContextMenuLog_Inverted;
	}
}