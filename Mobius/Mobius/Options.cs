/*
 * Created by SharpDevelop.
 * User: alex2308
 * Date: 20.03.2005
 * Time: 09:14
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Mobius
{
	/// <summary>
	/// Description of Options.
	/// </summary>
	public class Options : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox boxFallDamage;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox boxHerbs;
		private System.Windows.Forms.TextBox txtProcess;
		private System.Windows.Forms.CheckBox boxFollowNPC;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox boxMountainClimb;
		private System.Windows.Forms.CheckBox boxMinerals;
		private System.Windows.Forms.CheckBox boxElementals;
		private System.Windows.Forms.CheckBox boxWoWTeleport;
		private System.Windows.Forms.CheckBox boxDragonkin;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox boxLockSwim;
		private System.Windows.Forms.CheckBox boxTreasure;
		private System.Windows.Forms.Label lblProcessExe;
		private System.Windows.Forms.CheckBox boxCritters;
		private System.Windows.Forms.CheckBox boxUndead;
		private System.Windows.Forms.CheckBox boxEnableHotkeys;
		private System.Windows.Forms.CheckBox boxGiants;
		private System.Windows.Forms.CheckBox boxHumanoids;
		private System.Windows.Forms.CheckBox boxBeasts;
		private System.Windows.Forms.CheckBox boxDemons;
		
		public static bool[] hacks = {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};
		public static string processName;
		
		public Options()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			getSettings();
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
			this.boxDemons = new System.Windows.Forms.CheckBox();
			this.boxBeasts = new System.Windows.Forms.CheckBox();
			this.boxHumanoids = new System.Windows.Forms.CheckBox();
			this.boxGiants = new System.Windows.Forms.CheckBox();
			this.boxEnableHotkeys = new System.Windows.Forms.CheckBox();
			this.boxUndead = new System.Windows.Forms.CheckBox();
			this.boxCritters = new System.Windows.Forms.CheckBox();
			this.lblProcessExe = new System.Windows.Forms.Label();
			this.boxTreasure = new System.Windows.Forms.CheckBox();
			this.boxLockSwim = new System.Windows.Forms.CheckBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.boxDragonkin = new System.Windows.Forms.CheckBox();
			this.boxWoWTeleport = new System.Windows.Forms.CheckBox();
			this.boxElementals = new System.Windows.Forms.CheckBox();
			this.boxMinerals = new System.Windows.Forms.CheckBox();
			this.boxMountainClimb = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.boxFollowNPC = new System.Windows.Forms.CheckBox();
			this.txtProcess = new System.Windows.Forms.TextBox();
			this.boxHerbs = new System.Windows.Forms.CheckBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.boxFallDamage = new System.Windows.Forms.CheckBox();
			this.groupBox5.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.SuspendLayout();
			// 
			// boxDemons
			// 
			this.boxDemons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxDemons.Location = new System.Drawing.Point(8, 49);
			this.boxDemons.Name = "boxDemons";
			this.boxDemons.Size = new System.Drawing.Size(104, 15);
			this.boxDemons.TabIndex = 2;
			this.boxDemons.Text = "Demons";
			this.boxDemons.Checked=hacks[7];
			this.boxDemons.CheckedChanged += new System.EventHandler(this.BoxDemonsCheckedChanged);
			// 
			// boxBeasts
			// 
			this.boxBeasts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxBeasts.Location = new System.Drawing.Point(8, 17);
			this.boxBeasts.Name = "boxBeasts";
			this.boxBeasts.Size = new System.Drawing.Size(104, 15);
			this.boxBeasts.TabIndex = 0;
			this.boxBeasts.Text = "Beasts";
			this.boxBeasts.Checked=hacks[5];
			this.boxBeasts.CheckedChanged += new System.EventHandler(this.BoxBeastsCheckedChanged);
			// 
			// boxHumanoids
			// 
			this.boxHumanoids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxHumanoids.Location = new System.Drawing.Point(80, 49);
			this.boxHumanoids.Name = "boxHumanoids";
			this.boxHumanoids.Size = new System.Drawing.Size(80, 15);
			this.boxHumanoids.TabIndex = 6;
			this.boxHumanoids.Text = "Humanoids";
			this.boxHumanoids.Checked=hacks[11];
			this.boxHumanoids.CheckedChanged += new System.EventHandler(this.BoxHumanoidsCheckedChanged);
			// 
			// boxGiants
			// 
			this.boxGiants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxGiants.Location = new System.Drawing.Point(80, 17);
			this.boxGiants.Name = "boxGiants";
			this.boxGiants.Size = new System.Drawing.Size(56, 15);
			this.boxGiants.TabIndex = 4;
			this.boxGiants.Text = "Giants";
			this.boxGiants.CheckedChanged += new System.EventHandler(this.BoxGiantsCheckedChanged);
			// 
			// boxEnableHotkeys
			// 
			this.boxEnableHotkeys.Location = new System.Drawing.Point(8, 16);
			this.boxEnableHotkeys.Name = "boxEnableHotkeys";
			this.boxEnableHotkeys.Size = new System.Drawing.Size(104, 16);
			this.boxEnableHotkeys.TabIndex = 1;
			this.boxEnableHotkeys.Text = "Enable Hotkeys";
			this.boxEnableHotkeys.Checked=hacks[16];
			this.boxEnableHotkeys.CheckedChanged += new System.EventHandler(this.BoxEnableHotkeysCheckedChanged);			
			// 
			// boxUndead
			// 
			this.boxUndead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxUndead.Location = new System.Drawing.Point(80, 33);
			this.boxUndead.Name = "boxUndead";
			this.boxUndead.Size = new System.Drawing.Size(64, 15);
			this.boxUndead.TabIndex = 5;
			this.boxUndead.Text = "Undead";
			this.boxUndead.Checked=hacks[10];
			this.boxUndead.CheckedChanged += new System.EventHandler(this.BoxUndeadCheckedChanged);
			// 
			// boxCritters
			// 
			this.boxCritters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxCritters.Location = new System.Drawing.Point(80, 65);
			this.boxCritters.Name = "boxCritters";
			this.boxCritters.Size = new System.Drawing.Size(64, 15);
			this.boxCritters.TabIndex = 7;
			this.boxCritters.Text = "Critters";
			this.boxCritters.Checked=hacks[12];	
			this.boxCritters.CheckedChanged += new System.EventHandler(this.BoxCrittersCheckedChanged);
			// 
			// lblProcessExe
			// 
			this.lblProcessExe.Location = new System.Drawing.Point(104, 20);
			this.lblProcessExe.Name = "lblProcessExe";
			this.lblProcessExe.Size = new System.Drawing.Size(26, 16);
			this.lblProcessExe.TabIndex = 1;
			this.lblProcessExe.Text = ".exe";
			// 
			// boxTreasure
			// 
			this.boxTreasure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxTreasure.Checked = hacks[15];
			this.boxTreasure.CheckState = System.Windows.Forms.CheckState.Checked;
			this.boxTreasure.Location = new System.Drawing.Point(8, 97);
			this.boxTreasure.Name = "boxTreasure";
			this.boxTreasure.Size = new System.Drawing.Size(72, 15);
			this.boxTreasure.TabIndex = 10;
			this.boxTreasure.Text = "Treasure";
			this.boxTreasure.CheckedChanged += new System.EventHandler(this.BoxTreasureCheckedChanged);
			// 
			// boxLockSwim
			// 
			this.boxLockSwim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left)));
			this.boxLockSwim.Location = new System.Drawing.Point(8, 49);
			this.boxLockSwim.Name = "boxLockSwim";
			this.boxLockSwim.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.boxLockSwim.Size = new System.Drawing.Size(120, 15);
			this.boxLockSwim.TabIndex = 2;
			this.boxLockSwim.Checked=hacks[2];
			this.boxLockSwim.Text = "Lock Swim Speed";
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(96, 160);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 24);
			this.btnExit.TabIndex = 36;
			this.btnExit.Text = "Exit";
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// boxDragonkin
			// 
			this.boxDragonkin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxDragonkin.Location = new System.Drawing.Point(8, 33);
			this.boxDragonkin.Name = "boxDragonkin";
			this.boxDragonkin.Size = new System.Drawing.Size(104, 15);
			this.boxDragonkin.TabIndex = 1;
			this.boxDragonkin.Text = "Dragonkin";
			this.boxDragonkin.Checked=hacks[6];
			this.boxDragonkin.CheckedChanged += new System.EventHandler(this.BoxDragonkinCheckedChanged);
			// 
			// boxWoWTeleport
			// 
			this.boxWoWTeleport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left)));
			this.boxWoWTeleport.Location = new System.Drawing.Point(8, 81);
			this.boxWoWTeleport.Name = "boxWoWTeleport";
			this.boxWoWTeleport.Size = new System.Drawing.Size(112, 14);
			this.boxWoWTeleport.TabIndex = 2;
			this.boxWoWTeleport.Checked=hacks[4];
			this.boxWoWTeleport.Text = "Teleport to Plane";
			// 
			// boxElementals
			// 
			this.boxElementals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxElementals.Location = new System.Drawing.Point(8, 65);
			this.boxElementals.Name = "boxElementals";
			this.boxElementals.Size = new System.Drawing.Size(104, 15);
			this.boxElementals.TabIndex = 3;
			this.boxElementals.Text = "Elementals";
			this.boxElementals.Checked=hacks[8];
			this.boxElementals.CheckedChanged += new System.EventHandler(this.BoxElementalsCheckedChanged);
			// 
			// boxMinerals
			// 
			this.boxMinerals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxMinerals.Location = new System.Drawing.Point(80, 81);
			this.boxMinerals.Name = "boxMinerals";
			this.boxMinerals.Size = new System.Drawing.Size(64, 15);
			this.boxMinerals.TabIndex = 9;
			this.boxMinerals.Text = "Minerals";
			this.boxMinerals.Checked=hacks[14];
			this.boxMinerals.CheckedChanged += new System.EventHandler(this.BoxMineralsCheckedChanged);
			// 
			// boxMountainClimb
			// 
			this.boxMountainClimb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left)));
			this.boxMountainClimb.Location = new System.Drawing.Point(8, 17);
			this.boxMountainClimb.Name = "boxMountainClimb";
			this.boxMountainClimb.Size = new System.Drawing.Size(120, 15);
			this.boxMountainClimb.TabIndex = 0;
			this.boxMountainClimb.Checked=hacks[0];
			this.boxMountainClimb.Text = "Mountain Climb";
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(0, 160);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 24);
			this.btnSave.TabIndex = 35;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lblProcessExe);
			this.groupBox5.Controls.Add(this.txtProcess);
			this.groupBox5.Location = new System.Drawing.Point(176, 104);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(136, 40);
			this.groupBox5.TabIndex = 34;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Processname to hook on";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.boxFollowNPC);
			this.groupBox7.Controls.Add(this.boxWoWTeleport);
			this.groupBox7.Controls.Add(this.boxMountainClimb);
			this.groupBox7.Controls.Add(this.boxFallDamage);
			this.groupBox7.Controls.Add(this.boxLockSwim);
			this.groupBox7.Location = new System.Drawing.Point(176, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(136, 104);
			this.groupBox7.TabIndex = 33;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Hacks";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.boxEnableHotkeys);
			this.groupBox1.Location = new System.Drawing.Point(0, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 40);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hotkeys";
			// 
			// boxFollowNPC
			// 
			this.boxFollowNPC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left)));
			this.boxFollowNPC.Location = new System.Drawing.Point(8, 63);
			this.boxFollowNPC.Name = "boxFollowNPC";
			this.boxFollowNPC.Size = new System.Drawing.Size(80, 17);
			this.boxFollowNPC.TabIndex = 2;
			this.boxFollowNPC.Checked=hacks[3];
			this.boxFollowNPC.Text = "Follow NPC";
			// 
			// txtProcess
			// 
			this.txtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtProcess.Location = new System.Drawing.Point(8, 16);
			this.txtProcess.Name = "txtProcess";
			this.txtProcess.Size = new System.Drawing.Size(96, 20);
			this.txtProcess.TabIndex = 0;
			this.txtProcess.Text = processName;
			this.txtProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtProcess.TextChanged += new System.EventHandler(this.TxtProcessTextChanged);
			// 
			// boxHerbs
			// 
			this.boxHerbs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left) 
						| System.Windows.Forms.AnchorStyles.Right)));
			this.boxHerbs.Location = new System.Drawing.Point(8, 81);
			this.boxHerbs.Name = "boxHerbs";
			this.boxHerbs.Size = new System.Drawing.Size(104, 15);
			this.boxHerbs.TabIndex = 8;
			this.boxHerbs.Text = "Herbs";
			this.boxHerbs.Checked=hacks[13];
			this.boxHerbs.CheckedChanged += new System.EventHandler(this.BoxHerbsCheckedChanged);
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.boxTreasure);
			this.groupBox8.Controls.Add(this.boxMinerals);
			this.groupBox8.Controls.Add(this.boxHerbs);
			this.groupBox8.Controls.Add(this.boxCritters);
			this.groupBox8.Controls.Add(this.boxHumanoids);
			this.groupBox8.Controls.Add(this.boxUndead);
			this.groupBox8.Controls.Add(this.boxGiants);
			this.groupBox8.Controls.Add(this.boxElementals);
			this.groupBox8.Controls.Add(this.boxDemons);
			this.groupBox8.Controls.Add(this.boxDragonkin);
			this.groupBox8.Controls.Add(this.boxBeasts);
			this.groupBox8.Location = new System.Drawing.Point(0, 0);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(176, 120);
			this.groupBox8.TabIndex = 32;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "MiniMap Hack";
			// 
			// boxFallDamage
			// 
			this.boxFallDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
						| System.Windows.Forms.AnchorStyles.Left)));
			this.boxFallDamage.Location = new System.Drawing.Point(8, 33);
			this.boxFallDamage.Name = "boxFallDamage";
			this.boxFallDamage.Size = new System.Drawing.Size(120, 15);
			this.boxFallDamage.TabIndex = 1;
			this.boxFallDamage.Checked=hacks[1];
			this.boxFallDamage.Text = "No Fall Damage";
			// 
			// Options
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(314, 183);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Options";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mobius Options by alex2308";
			this.groupBox5.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		
		public static bool[] getHacks() {
			return(hacks);
		}
		public static string getProcessName() {
			return(processName);
		}
		private void getSettings() {
			try
			{
				int i=0;
				FileStream fs = new FileStream("settings.ini", FileMode.Open);
				StreamReader sr = new StreamReader(fs);
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					if (line.StartsWith("#") == true) {}
					else {
						if (line=="1") {
							hacks[i]=true;
							i++;
						}
						if (line=="0") {
							hacks[i]=false;
							i++;
						}
						if (line!="0" & line!="1") processName=line;
					}
				}
				//for (int j=0; j<=i; j++) MessageBox.Show(hacks[j].ToString(),"bool"+j , MessageBoxButtons.OK, MessageBoxIcon.Error);
				//MessageBox.Show(processName,"processname" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				fs.Close();
			}
			catch (Exception e) {MessageBox.Show(e.ToString(),"Exception" , MessageBoxButtons.OK, MessageBoxIcon.Error);}
		}
		
		void BtnExitClick(object sender, System.EventArgs e)
		{
			this.Hide();
		}
		
		void BtnSaveClick(object sender, System.EventArgs e)
		{
			//SaveSettings();
		}
		
		private void boxMountainClimbCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[0]=!hacks[0];
		}
		
		private void boxFallDamageCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[1]=!hacks[1];
		}
		
		private void BoxLockSwimCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[2]=!hacks[2];
		}
		
		private void boxFollowNPCCheckedChanged(object sender, System.EventArgs e)
		{
			
			hacks[3]=!hacks[3];
		}
		
		private void boxWoWTeleportCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[4]=!hacks[4];
		}
		
		
		void BoxBeastsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[5]=!hacks[5];
		}
		
		void BoxDragonkinCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[6]=!hacks[6];
		}
		
		void BoxDemonsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[7]=!hacks[7];
		}
		
		void BoxElementalsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[8]=!hacks[8];
		}
		
		void BoxGiantsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[9]=!hacks[9];
		}
		
		void BoxUndeadCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[10]=!hacks[10];
		}
		
		void BoxHumanoidsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[11]=!hacks[11];
		}
		
		void BoxCrittersCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[12]=!hacks[12];
		}
		
		void BoxHerbsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[13]=!hacks[13];
		}
		
		void BoxMineralsCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[14]=!hacks[14];
		}
		
		void BoxTreasureCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[15]=!hacks[15];
		}
		
		void BoxEnableHotkeysCheckedChanged(object sender, System.EventArgs e)
		{
			hacks[16]=!hacks[16];
		}
		
		void TxtProcessTextChanged(object sender, System.EventArgs e)
		{
			processName=this.txtProcess.Text;
		}
		
	}
}
