using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Drawing;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;
using Telerik.WinControls.UI;

namespace reactQb
{
    partial class RadForm1
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
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			radDropDownList1 = new RadDropDownList();
			radLabel1 = new RadLabel();
			radNavigationView1 = new RadNavigationView();
			radPageViewPage1 = new RadPageViewPage();
			radThemeManager1 = new RadThemeManager();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			((System.ComponentModel.ISupportInitialize)radDropDownList1).BeginInit();
			((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
			((System.ComponentModel.ISupportInitialize)radNavigationView1).BeginInit();
			radNavigationView1.SuspendLayout();
			radPageViewPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			SuspendLayout();
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(0, 185);
			webView21.Name = "webView21";
			webView21.Size = new Size(1581, 798);
			webView21.Source = new System.Uri("C:\\Users\\coden\\my-react-ts-app\\build\\index.html", System.UriKind.Absolute);
			webView21.TabIndex = 0;
			webView21.ZoomFactor = 1D;
			webView21.WebMessageReceived += webView21_WebMessageReceived;
			// 
			// radDropDownList1
			// 
			radDropDownList1.BackColor = Color.White;
			radDropDownList1.DropDownAnimationEnabled = true;
			radDropDownList1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			radDropDownList1.Location = new Point(221, 39);
			radDropDownList1.Name = "radDropDownList1";
			radDropDownList1.NullText = "select";
			radDropDownList1.Size = new Size(172, 33);
			radDropDownList1.TabIndex = 1;
			radDropDownList1.Text = "radDropDownList1";
			radDropDownList1.SelectedIndexChanged += radDropDownList1_SelectedIndexChanged;
			((RadDropDownListElement)radDropDownList1.GetChildAt(0)).BorderHighlightColor = Color.FromArgb(24, 144, 255);
			((RadDropDownListElement)radDropDownList1.GetChildAt(0)).ForeColor = Color.Black;
			((RadDropDownListElement)radDropDownList1.GetChildAt(0)).BackColor = Color.Gray;
			((RadDropDownListElement)radDropDownList1.GetChildAt(0)).Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
			((RadDropDownListElement)radDropDownList1.GetChildAt(0)).Padding = new System.Windows.Forms.Padding(4);
			// 
			// radLabel1
			// 
			radLabel1.Location = new Point(76, 47);
			radLabel1.Name = "radLabel1";
			radLabel1.Size = new Size(123, 18);
			radLabel1.TabIndex = 2;
			radLabel1.Text = "File Format Manager ID";
			radLabel1.Click += radLabel1_Click;
			// 
			// radNavigationView1
			// 
			radNavigationView1.Controls.Add(radPageViewPage1);
			radNavigationView1.Dock = System.Windows.Forms.DockStyle.Fill;
			radNavigationView1.HeaderHeight = 36;
			radNavigationView1.Location = new Point(0, 0);
			radNavigationView1.Name = "radNavigationView1";
			radNavigationView1.SelectedPage = radPageViewPage1;
			radNavigationView1.Size = new Size(1863, 1054);
			radNavigationView1.TabIndex = 3;
			// 
			// radPageViewPage1
			// 
			radPageViewPage1.Controls.Add(radLabel1);
			radPageViewPage1.Controls.Add(webView21);
			radPageViewPage1.Controls.Add(radDropDownList1);
			radPageViewPage1.ItemSize = new SizeF(102F, 33F);
			radPageViewPage1.Location = new Point(281, 37);
			radPageViewPage1.Name = "radPageViewPage1";
			radPageViewPage1.Size = new Size(1581, 1016);
			radPageViewPage1.Text = "Mapping Rules";
			// 
			// RadForm1
			// 
			AutoScaleBaseSize = new Size(7, 15);
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new Size(1863, 1054);
			Controls.Add(radNavigationView1);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "RadForm1";
			Text = "RadForm1";
			ThemeName = "Fluent";
			Load += RadForm1_Load;
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			((System.ComponentModel.ISupportInitialize)radDropDownList1).EndInit();
			((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
			((System.ComponentModel.ISupportInitialize)radNavigationView1).EndInit();
			radNavigationView1.ResumeLayout(false);
			radPageViewPage1.ResumeLayout(false);
			radPageViewPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this).EndInit();
			ResumeLayout(false);
		}

		private void RadDropDownList1_VisualListItemFormatting(object sender, VisualItemFormattingEventArgs args)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private Telerik.WinControls.UI.RadDropDownList radDropDownList1;
		private Telerik.WinControls.UI.RadLabel radLabel1;
		private RadNavigationView radNavigationView1;
		private RadPageViewPage radPageViewPage1;
		private RadThemeManager radThemeManager1;
	}
}