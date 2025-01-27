using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace reactQb
{
	public partial class RadForm1 : Telerik.WinControls.UI.RadForm
	{

		public RadForm1()
		{
			InitializeComponent();

			InitWebView();
			//webView21.Visible = false;
			InitializeDropdown();


		}

		List<FileFormatManager> fileFormatManagers = new List<FileFormatManager>
{
	new FileFormatManager
	{
		FFMId = 1,
		Fields = new List<Field>
		{
	new Field { Label = "ProductCode" },
	new Field { Label = "ReferenceID" },
	new Field { Label = "CinNumber" },
	new Field { Label = "AidCode" },
	new Field { Label = "AidCategory" },
	new Field { Label = "MedicalCaseID" },
	new Field { Label = "ProjectCode" },
	new Field { Label = "MedicareStatA" },
	new Field { Label = "MedicareStatB" },
	new Field { Label = "MedicareStatD" },
	new Field { Label = "SPDDualFlag" },
	new Field { Label = "CCSFlag" }
	  }
	},
	new FileFormatManager
	{
		FFMId=2,
		Fields = new List<Field>
		{
			new Field { Label = "FirstNM" },
			new Field { Label = "LastNM" },
			new Field { Label = "Benefit" },
			new Field { Label = "AidCode" },
			new Field { Label = "Region" }
		}
	},

};

		private void InitializeDropdown()
		{
			radDropDownList1.DataSource = fileFormatManagers.Select(m => m.FFMId).ToList();
			//radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
		}







		async void InitWebView()
		{
			await webView21.EnsureCoreWebView2Async();
			webView21.Enabled = false;
			//webView21.CoreWebView2.Navigate("http://localhost:3000/");
		}


		private void webView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
		{
			//string message = e.TryGetWebMessageAsString();

			var data = JsonConvert.DeserializeObject<dynamic>(e.TryGetWebMessageAsString());

			// Process received message from React
			MessageBox.Show(e.TryGetWebMessageAsString());


		}

		private async void radButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sent");
			await webView21.CoreWebView2.ExecuteScriptAsync("window.receiveMessageFromWinForms('Hello from WinForms!')");


		}

		private void radLabel1_Click(object sender, EventArgs e)
		{

		}

		private async void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
		{
			if (webView21.CoreWebView2 != null)  // Ensure CoreWebView2 is initialized
			{
				webView21.Enabled = true;
				string selectedManagerId = radDropDownList1.SelectedItem.Text;
				FileFormatManager selectedManager = fileFormatManagers.FirstOrDefault(m => m.FFMId == Convert.ToInt32(selectedManagerId));

				// Send the selected fields to React
				await webView21.CoreWebView2.ExecuteScriptAsync($"window.receiveMessageFromWinForms({Newtonsoft.Json.JsonConvert.SerializeObject(selectedManager.Fields)})");
			}
			else
			{

				radDropDownList1.SelectedIndex = -1;
				radDropDownList1.SelectedText = string.Empty;
				radDropDownList1.DropDownStyle = RadDropDownStyle.DropDownList;

			}
		}


		private void RadDropDownList1_VisualItemFormatting(object sender, Telerik.WinControls.UI.VisualItemFormattingEventArgs e)
		{
			if (e.VisualItem.Data.Selected) // Check if the item is selected
			{
				e.VisualItem.ForeColor = Color.Black; // Set the text color for the selected item
				e.VisualItem.BackColor = Color.LightGray; // Optional: Set background color
			}
			else
			{
				e.VisualItem.ResetValue(LightVisualElement.ForeColorProperty, Telerik.WinControls.ValueResetFlags.Local);
				e.VisualItem.ResetValue(LightVisualElement.BackColorProperty, Telerik.WinControls.ValueResetFlags.Local);
			}
		}

		private void RadForm1_Load(object sender, EventArgs e)
		{

		}
	}
}
