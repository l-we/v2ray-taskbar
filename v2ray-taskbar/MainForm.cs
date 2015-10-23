/*
 * 由SharpDevelop创建。
 * 用户： Le
 * 日期: 2015/10/20
 * 时间: 09:17
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;


namespace v2ray_taskbar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Process[] processcollection = Process.GetProcessesByName("v2ray-taskbar");
			if (processcollection.Length >= 2)
			{
				MessageBox.Show("应用程序已经在运行中。。");
				this.notifyIconV2ray.Visible = false;
				Environment.Exit(1);
			}
			else
			{
				this.V2ray_Process();
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		// 运行代理程序
		void V2ray_Process()
		{
			try
			{
				Process p = new Process();
				p.StartInfo.FileName = "v2ray.exe";
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.CreateNoWindow = true;
				p.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
					{
						if (!String.IsNullOrEmpty(e.Data))
						{
							this.AppendText(e.Data + Environment.NewLine);
						}
					});
				p.Start();
				p.BeginOutputReadLine();
			}
			catch (Exception)
			{
				MessageBox.Show("请检查当前目录下是否有 v2ray.exe 程序。。");
				this.notifyIconV2ray.Visible = false;
				Environment.Exit(0);
			}
		}
		
		delegate void AppendTextDelegate(string text);
		void AppendText(string text)
		{
			if (this.textBoxV2ray.InvokeRequired)
			{
				Invoke(new AppendTextDelegate(AppendText), new object[] { text });
			}
			else
			{
				this.textBoxV2ray.AppendText(text);
			}
		}
		// 最小化隐藏
		void V2ray_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				this.Visible = false;
			}
		}
		// 窗体显示
		void notifyIconV2ray_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.Visible == false && e.Button == MouseButtons.Left)
			{
				this.Visible = true;
				this.WindowState = FormWindowState.Normal;
				this.Activate();
			}
			else if (e.Button == MouseButtons.Left)
			{
				this.Hide();
				this.Visible = false;
			}
		}
		// 退出
		void Exit_Click(object sender, EventArgs e)
		{
			this.notifyIconV2ray.Visible = false;
			try
			{
				Process[] killp = Process.GetProcessesByName("v2ray");
				foreach (System.Diagnostics.Process p in killp)
				{
					p.Kill();
				}
				Environment.Exit(0);
			}
			catch (Exception)
			{
				Environment.Exit(0);
			}
		}
		// 重载后台程序
		void V2ray_Click(object sender, EventArgs e)
		{
			// 重载
			this.textBoxV2ray.Clear();
			if (this.Visible == false)
			{
				this.Visible = true;
				this.WindowState = FormWindowState.Normal;
				this.Activate();
			}
			try
			{
				Process[] killp = Process.GetProcessesByName("v2ray");
				foreach (System.Diagnostics.Process p in killp)
				{
					p.Kill();
				}
			}
			finally
			{
				this.V2ray_Process();
			}
		}
		// 清空 textBoxV2ray 内容
		void TextBoxClear(object sender, EventArgs e)
		{
			this.textBoxV2ray.Clear();
		}
		// 复制 textBoxV2ray 内容
		void TextBoxCopy(object sender, EventArgs e)
		{
			if (this.textBoxV2ray.SelectedText != "")
			{
				Clipboard.SetDataObject(this.textBoxV2ray.SelectedText);
			}
		}
		// 默认隐藏
		void V2ray_Shown(object sender, EventArgs e)
		{
			this.Hide();
			this.Visible = false;
		}
	}
}
