/*
 * Created by SharpDevelop.
 * User: alex2308
 * Date: 20.03.2005
 * Time: 18:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobius
{
	/// <summary>
	/// Description of About.
	/// </summary>
	public class About : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblTxt;
		private System.Windows.Forms.Label lblAuthors;
		private System.Windows.Forms.Label lblTitle;
		public About()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		#region Windows Forms Designer generated code
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblAuthors = new System.Windows.Forms.Label();
			this.lblTxt = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(160, 40);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(108, 24);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Mobius 1.4";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAuthors
			// 
			this.lblAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblAuthors.Location = new System.Drawing.Point(108, 76);
			this.lblAuthors.Name = "lblAuthors";
			this.lblAuthors.Size = new System.Drawing.Size(204, 12);
			this.lblAuthors.TabIndex = 3;
			this.lblAuthors.Text = "by Devil323 and alex2308";
			this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTxt
			// 
			this.lblTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblTxt.Location = new System.Drawing.Point(12, 108);
			this.lblTxt.Name = "lblTxt";
			this.lblTxt.Size = new System.Drawing.Size(408, 72);
			this.lblTxt.TabIndex = 2;
			this.lblTxt.Text = "bla bla bla bla bla bla bla";
			this.lblTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(116, 240);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(216, 20);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Yeah, its OK, leave me alone!";
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// About
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(432, 265);
			this.ControlBox = false;
			this.Controls.Add(this.lblAuthors);
			this.Controls.Add(this.lblTxt);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
		}
		#endregion
		void BtnOKClick(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
