using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Mobius
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class frmLocEdit : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtZ;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		

		private string eX = "null";
		private string eY = "null";
		private string eZ = "null";
		private string eName = "null";
		

		MainForm frmMain = new MainForm();
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public frmLocEdit()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtZ = new System.Windows.Forms.TextBox();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtZ);
			this.groupBox1.Controls.Add(this.txtY);
			this.groupBox1.Controls.Add(this.txtX);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 136);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Location";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(128, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(216, 20);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 24);
			this.label4.Name = "label4";
			this.label4.TabIndex = 6;
			this.label4.Text = "Location :";
			// 
			// txtZ
			// 
			this.txtZ.Location = new System.Drawing.Point(128, 96);
			this.txtZ.Name = "txtZ";
			this.txtZ.TabIndex = 5;
			this.txtZ.Text = "";
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(128, 72);
			this.txtY.Name = "txtY";
			this.txtY.TabIndex = 4;
			this.txtY.Text = "";
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(128, 48);
			this.txtX.Name = "txtX";
			this.txtX.TabIndex = 3;
			this.txtX.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Z Loc :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "Y Loc :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "X Loc :";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(144, 144);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmLocEdit
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 173);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmLocEdit";
			this.Text = "Loc Edit";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frmLocEdit_Closeing);
			this.Load += new System.EventHandler(this.frmLocEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public string editName
		{
			get { return this.eName; }
			set { this.eName = value; }
		}

		public string editX
		{
			get { return this.eX; }
			set { this.eX = value; }
		}

		public string editY
		{
			get { return this.eY; }
			set { this.eY = value; }
		}

		public string editZ
		{
			get { return this.eZ; }
			set { this.eZ = value; }
		}
		
		private void frmLocEdit_Load(object sender, System.EventArgs e)
		{

			this.txtName.Text = this.editName;
			this.txtX.Text = this.editX;
			this.txtY.Text = this.editY;
			this.txtZ.Text = this.editZ;
		}

		private void frmLocEdit_Closeing(object sender, System.ComponentModel.CancelEventArgs e)
		{

		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			SavedLoc.EditMember("saved.xml",this.editName ,this.txtName.Text,this.txtX.Text,this.txtY.Text,this.txtZ.Text);
			this.Close();
		
		}
	}
}
