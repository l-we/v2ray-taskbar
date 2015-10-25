/*
 * 由SharpDevelop创建。
 * 用户： Le
 * 日期: 2015/10/20
 * 时间: 09:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace v2ray_taskbar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.NotifyIcon notifyIconV2ray;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
		private System.Windows.Forms.ToolStripMenuItem 重载ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
		private System.Windows.Forms.TextBox textBoxTaskbar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTextBox;
		private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.notifyIconV2ray = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.重载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.textBoxTaskbar = new System.Windows.Forms.TextBox();
			this.contextMenuStripTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripIcon.SuspendLayout();
			this.contextMenuStripTextBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIconV2ray
			// 
			this.notifyIconV2ray.ContextMenuStrip = this.contextMenuStripIcon;
			this.notifyIconV2ray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconV2ray.Icon")));
			this.notifyIconV2ray.Text = "v2ray";
			this.notifyIconV2ray.Visible = true;
			this.notifyIconV2ray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconV2ray_MouseClick);
			// 
			// contextMenuStripIcon
			// 
			this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.重载ToolStripMenuItem,
			this.退出ToolStripMenuItem});
			this.contextMenuStripIcon.Name = "contextMenuStripV2ray";
			this.contextMenuStripIcon.Size = new System.Drawing.Size(101, 48);
			// 
			// 重载ToolStripMenuItem
			// 
			this.重载ToolStripMenuItem.Name = "重载ToolStripMenuItem";
			this.重载ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.重载ToolStripMenuItem.Text = "重载";
			this.重载ToolStripMenuItem.Click += new System.EventHandler(this.V2ray_Click);
			// 
			// 退出ToolStripMenuItem
			// 
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.退出ToolStripMenuItem.Text = "退出";
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
			// 
			// textBoxTaskbar
			// 
			this.textBoxTaskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
			this.textBoxTaskbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTaskbar.ContextMenuStrip = this.contextMenuStripTextBox;
			this.textBoxTaskbar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTaskbar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTaskbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(226)))), ((int)(((byte)(228)))));
			this.textBoxTaskbar.Location = new System.Drawing.Point(0, 0);
			this.textBoxTaskbar.MaxLength = 0;
			this.textBoxTaskbar.Multiline = true;
			this.textBoxTaskbar.Name = "textBoxTaskbar";
			this.textBoxTaskbar.ReadOnly = true;
			this.textBoxTaskbar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxTaskbar.Size = new System.Drawing.Size(784, 411);
			this.textBoxTaskbar.TabIndex = 1;
			// 
			// contextMenuStripTextBox
			// 
			this.contextMenuStripTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.复制ToolStripMenuItem,
			this.清空ToolStripMenuItem});
			this.contextMenuStripTextBox.Name = "contextMenuStripTextBox";
			this.contextMenuStripTextBox.Size = new System.Drawing.Size(101, 48);
			// 
			// 复制ToolStripMenuItem
			// 
			this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
			this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.复制ToolStripMenuItem.Text = "复制";
			this.复制ToolStripMenuItem.Click += new System.EventHandler(this.TextBoxCopy);
			// 
			// 清空ToolStripMenuItem
			// 
			this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
			this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.清空ToolStripMenuItem.Text = "清空";
			this.清空ToolStripMenuItem.Click += new System.EventHandler(this.TextBoxClear);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.textBoxTaskbar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "v2ray-taskbar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exit_Click);
			this.Shown += new System.EventHandler(this.V2ray_Shown);
			this.SizeChanged += new System.EventHandler(this.V2ray_SizeChanged);
			this.contextMenuStripIcon.ResumeLayout(false);
			this.contextMenuStripTextBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
