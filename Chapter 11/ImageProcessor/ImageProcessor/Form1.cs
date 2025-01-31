using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
	public partial class ImgProcessorForm : Form
	{
		public ImgProcessorForm()
		{
			InitializeComponent();
		}

		private void ImgProcessorForm_Load(object sender, EventArgs e)
		{
			totalImages = new PerformanceCounter();
			totalImages.CategoryName = "ImageProcessor";
			totalImages.CounterName = "Images Processed";
			totalImages.MachineName = ".";
			totalImages.ReadOnly = false;

			imagesPerSecond = new PerformanceCounter();
			imagesPerSecond.CategoryName = "ImageProcessor";
			imagesPerSecond.CounterName = "Images Per Second";
			imagesPerSecond.MachineName = ".";
			imagesPerSecond.ReadOnly = false;
		}

		private void ProcessImageFile(String sFileName)
		{
			totalImages.Increment();
			imagesPerSecond.Increment();

			txtTickCount.Text = String.Format("{0}", ++m_TickCount);
		}

		private void OnTimer1Tick(object sender, EventArgs e)
		{
			ProcessImageFile("Testing");
		}

		private void OnEnableDisableTimer(object sender, EventArgs e)
		{
			m_bTimerEnabled = !m_bTimerEnabled;
			timerTest.Enabled = m_bTimerEnabled;
			btnTimer.Text = m_bTimerEnabled ? "Disable &Timer" : "Enable Timer";
		}

		private PerformanceCounter totalImages, imagesPerSecond;
		private bool m_bTimerEnabled = false;
		private Int32 m_TickCount = 0;
	}
}
