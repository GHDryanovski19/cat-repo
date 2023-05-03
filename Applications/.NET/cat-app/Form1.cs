using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;

namespace cat_app
{
	public partial class Form1 : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);

		private const string API_KEY = "live_mEaYqB3AJwDn9ZHGwRjxga6ls3hSfDxuuBtmR1kAHYrZdYWhRt2MOPPGK3PHMFXo";
		private const string API_URL = "https://api.thecatapi.com/v1/images/search";

		public Form1()
		{
			InitializeComponent();
			LoadImage();
			this.FormBorderStyle = FormBorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
		}

		private async Task LoadImage()
		{
			try
			{
				using (HttpClient client = new HttpClient())
				{
					// Add the API key to the request headers
					client.DefaultRequestHeaders.Add("x-api-key", API_KEY);

					// Send a request to the API and get the response
					HttpResponseMessage response = await client.GetAsync(API_URL);
					response.EnsureSuccessStatusCode();

					// Read the response content as a JSON string
					string responseJson = await response.Content.ReadAsStringAsync();

					// Parse the JSON data to get the image URL
					JArray responseArray = JArray.Parse(responseJson);
					string imageUrl = responseArray[0]["url"].ToString();

					// Download the image data and load it into the PictureBox
					using (MemoryStream stream = new MemoryStream())
					{
						byte[] imageData = await client.GetByteArrayAsync(imageUrl);
						stream.Write(imageData, 0, imageData.Length);
						stream.Seek(0, SeekOrigin.Begin);
						pictureBox1.Image = Image.FromStream(stream);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading image: " + ex.Message);
			}
		}

		// Dragging the form
		bool dragging;
		Point offset;

		private void xBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void minimizeBtn_Click(object sender, EventArgs e)
		{
			if (Form1.ActiveForm.WindowState == FormWindowState.Minimized)
				Form1.ActiveForm.WindowState = FormWindowState.Normal;
			else if (Form1.ActiveForm.WindowState == FormWindowState.Normal)
				Form1.ActiveForm.WindowState = FormWindowState.Minimized;
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			// Enable dragging and getting mouse position
			dragging = true;
			offset.X = e.X;
			offset.Y = e.Y;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			// Check if we can move
			if (dragging)
			{
				Point currentScreenPosition = PointToScreen(new Point(e.X, e.Y));
				Location = new Point(currentScreenPosition.X - offset.X, currentScreenPosition.Y - offset.Y);
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			// Disable dragging
			dragging = false;
		}

		private void refreshImageBtn_Click(object sender, EventArgs e)
		{
			LoadImage();
		}
	}
}