using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;


namespace Mobius
{
	
	public class MainForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtZ;
		private System.Windows.Forms.Label lblCurZ;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label lblCurX;
		private System.Windows.Forms.Timer timRefreshCoords;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblAuthors;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClearStatus;
		private System.Windows.Forms.Label lblCurSpeed;
		private System.Windows.Forms.TextBox txtKey;
		private System.Windows.Forms.Label lblCurY;
		private System.Windows.Forms.TextBox txtLocationName;
		private System.Windows.Forms.Label lblHotkey;
		private System.Windows.Forms.Button btnSaveLoc;
		private System.Windows.Forms.TextBox txtSpeed;
		private System.Windows.Forms.TreeView lstSavedLocs;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Timer update;
		private System.Windows.Forms.Button btnClearHotkey;
		
		
		// Quickload/Quicksave variables by alex2308
		float quicklocx = 0;
		float quicklocy = 0;
		float quicklocz = 0;
		bool quicksaved = false;
		
		bool addedLocations = false;
		Options optionsForm = new Options();
		#region Declarations
		
		
		private MemoryLoc mX;
		private MemoryLoc mY;
		private MemoryLoc mZ;
		private MemoryLoc mSpeed;
		public MemoryLoc mSwimSpeed;
		public MemoryLoc mMountainClimb;
		public MemoryLoc mFallDamage;
		public MemoryLoc mFollowNPC;
		public MemoryLoc mWoWTeleport;
		private MemoryLoc mMapHack;

		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private MemoryLoc mMapHackResources; //Herbs Minerals and Chests
		#endregion
		
		#region Auto-Code
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.btnClearHotkey = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Timer(this.components);
			this.btnOptions = new System.Windows.Forms.Button();
			this.lstSavedLocs = new System.Windows.Forms.TreeView();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.txtSpeed = new System.Windows.Forms.TextBox();
			this.btnSaveLoc = new System.Windows.Forms.Button();
			this.lblHotkey = new System.Windows.Forms.Label();
			this.txtLocationName = new System.Windows.Forms.TextBox();
			this.lblCurY = new System.Windows.Forms.Label();
			this.txtKey = new System.Windows.Forms.TextBox();
			this.lblCurSpeed = new System.Windows.Forms.Label();
			this.btnClearStatus = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblAuthors = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.lblCurZ = new System.Windows.Forms.Label();
			this.lblCurX = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtZ = new System.Windows.Forms.TextBox();
			this.timRefreshCoords = new System.Windows.Forms.Timer(this.components);
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox3.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClearHotkey
			// 
			this.btnClearHotkey.Location = new System.Drawing.Point(152, 41);
			this.btnClearHotkey.Name = "btnClearHotkey";
			this.btnClearHotkey.Size = new System.Drawing.Size(16, 20);
			this.btnClearHotkey.TabIndex = 23;
			this.btnClearHotkey.Text = "C";
			this.btnClearHotkey.Click += new System.EventHandler(this.BtnClearHotkeyClick);
			// 
			// update
			// 
			this.update.Interval = 1000;
			this.update.Tick += new System.EventHandler(this.UpdateTick);
			// 
			// btnOptions
			// 
			this.btnOptions.Location = new System.Drawing.Point(0, 512);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(176, 24);
			this.btnOptions.TabIndex = 33;
			this.btnOptions.Text = "OPTIONS";
			this.btnOptions.Click += new System.EventHandler(this.BtnOptionsClick);
			// 
			// lstSavedLocs
			// 
			this.lstSavedLocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lstSavedLocs.ContextMenu = this.contextMenu1;
			this.lstSavedLocs.ImageIndex = -1;
			this.lstSavedLocs.Location = new System.Drawing.Point(8, 16);
			this.lstSavedLocs.Name = "lstSavedLocs";
			this.lstSavedLocs.SelectedImageIndex = -1;
			this.lstSavedLocs.Size = new System.Drawing.Size(160, 170);
			this.lstSavedLocs.TabIndex = 13;
			this.lstSavedLocs.DoubleClick += new System.EventHandler(this.lstSavedLocs_DoubleClick);
			this.lstSavedLocs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LstSavedLocsAfterSelect);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "edit";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.Text = "delete";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// txtSpeed
			// 
			this.txtSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSpeed.Location = new System.Drawing.Point(96, 88);
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.Size = new System.Drawing.Size(72, 20);
			this.txtSpeed.TabIndex = 35;
			this.txtSpeed.Text = "";
			this.txtSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
			// 
			// btnSaveLoc
			// 
			this.btnSaveLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveLoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSaveLoc.Location = new System.Drawing.Point(136, 17);
			this.btnSaveLoc.Name = "btnSaveLoc";
			this.btnSaveLoc.Size = new System.Drawing.Size(32, 23);
			this.btnSaveLoc.TabIndex = 18;
			this.btnSaveLoc.Text = "Add";
			this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
			// 
			// lblHotkey
			// 
			this.lblHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblHotkey.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.lblHotkey.Location = new System.Drawing.Point(8, 40);
			this.lblHotkey.Name = "lblHotkey";
			this.lblHotkey.Size = new System.Drawing.Size(24, 16);
			this.lblHotkey.TabIndex = 19;
			this.lblHotkey.Text = "Key";
			// 
			// txtLocationName
			// 
			this.txtLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtLocationName.Location = new System.Drawing.Point(56, 17);
			this.txtLocationName.MaxLength = 100;
			this.txtLocationName.Name = "txtLocationName";
			this.txtLocationName.Size = new System.Drawing.Size(80, 20);
			this.txtLocationName.TabIndex = 17;
			this.txtLocationName.Text = "";
			// 
			// lblCurY
			// 
			this.lblCurY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurY.Location = new System.Drawing.Point(8, 48);
			this.lblCurY.Name = "lblCurY";
			this.lblCurY.Size = new System.Drawing.Size(80, 16);
			this.lblCurY.TabIndex = 19;
			this.lblCurY.Text = "Y placehold";
			// 
			// txtKey
			// 
			this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtKey.Location = new System.Drawing.Point(56, 40);
			this.txtKey.Name = "txtKey";
			this.txtKey.ReadOnly = true;
			this.txtKey.Size = new System.Drawing.Size(96, 20);
			this.txtKey.TabIndex = 20;
			this.txtKey.Text = "";
			// 
			// lblCurSpeed
			// 
			this.lblCurSpeed.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurSpeed.Location = new System.Drawing.Point(8, 96);
			this.lblCurSpeed.Name = "lblCurSpeed";
			this.lblCurSpeed.Size = new System.Drawing.Size(88, 16);
			this.lblCurSpeed.TabIndex = 23;
			this.lblCurSpeed.Text = "Speed";
			// 
			// btnClearStatus
			// 
			this.btnClearStatus.Location = new System.Drawing.Point(94, 4);
			this.btnClearStatus.Name = "btnClearStatus";
			this.btnClearStatus.Size = new System.Drawing.Size(8, 8);
			this.btnClearStatus.TabIndex = 1;
			this.btnClearStatus.Click += new System.EventHandler(this.BtnClearStatusClick);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSave.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(8, 186);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save Locations";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblAuthors
			// 
			this.lblAuthors.Location = new System.Drawing.Point(0, 0);
			this.lblAuthors.Name = "lblAuthors";
			this.lblAuthors.Size = new System.Drawing.Size(176, 24);
			this.lblAuthors.TabIndex = 34;
			this.lblAuthors.Text = "mods by alex2308, Devil323";
			this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblAuthors.Click += new System.EventHandler(this.lblAuthors_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtX);
			this.groupBox3.Controls.Add(this.lblCurSpeed);
			this.groupBox3.Controls.Add(this.lblCurZ);
			this.groupBox3.Controls.Add(this.lblCurY);
			this.groupBox3.Controls.Add(this.lblCurX);
			this.groupBox3.Controls.Add(this.txtY);
			this.groupBox3.Controls.Add(this.txtZ);
			this.groupBox3.Controls.Add(this.txtSpeed);
			this.groupBox3.Location = new System.Drawing.Point(0, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(176, 120);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Position Control";
			// 
			// txtX
			// 
			this.txtX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtX.Location = new System.Drawing.Point(96, 16);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(72, 20);
			this.txtX.TabIndex = 29;
			this.txtX.Text = "";
			this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
			// 
			// lblCurZ
			// 
			this.lblCurZ.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurZ.Location = new System.Drawing.Point(8, 72);
			this.lblCurZ.Name = "lblCurZ";
			this.lblCurZ.Size = new System.Drawing.Size(80, 16);
			this.lblCurZ.TabIndex = 20;
			this.lblCurZ.Text = "Z placehold";
			// 
			// lblCurX
			// 
			this.lblCurX.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCurX.Location = new System.Drawing.Point(8, 24);
			this.lblCurX.Name = "lblCurX";
			this.lblCurX.Size = new System.Drawing.Size(80, 16);
			this.lblCurX.TabIndex = 18;
			this.lblCurX.Text = "X placehold";
			// 
			// txtY
			// 
			this.txtY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtY.Location = new System.Drawing.Point(96, 40);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(72, 20);
			this.txtY.TabIndex = 33;
			this.txtY.Text = "";
			this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
			// 
			// txtZ
			// 
			this.txtZ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtZ.Location = new System.Drawing.Point(96, 64);
			this.txtZ.Name = "txtZ";
			this.txtZ.Size = new System.Drawing.Size(72, 20);
			this.txtZ.TabIndex = 34;
			this.txtZ.Text = "";
			this.txtZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZ_KeyPress);
			// 
			// timRefreshCoords
			// 
			this.timRefreshCoords.Interval = 1000;
			this.timRefreshCoords.Tick += new System.EventHandler(this.timRefreshCoords_Tick);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnClearStatus);
			this.groupBox6.Controls.Add(this.txtStatus);
			this.groupBox6.Location = new System.Drawing.Point(0, 208);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(176, 88);
			this.groupBox6.TabIndex = 29;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Status Messages";
			// 
			// txtStatus
			// 
			this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.txtStatus.Location = new System.Drawing.Point(8, 16);
			this.txtStatus.Multiline = true;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtStatus.Size = new System.Drawing.Size(160, 64);
			this.txtStatus.TabIndex = 0;
			this.txtStatus.Text = "Idle...\r\n";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnLoad);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.lstSavedLocs);
			this.groupBox2.Location = new System.Drawing.Point(0, 296);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(176, 216);
			this.groupBox2.TabIndex = 25;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Location List";
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoad.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(88, 186);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(80, 23);
			this.btnLoad.TabIndex = 21;
			this.btnLoad.Text = "Load Locations";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lblLocationName
			// 
			this.lblLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblLocationName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.lblLocationName.Location = new System.Drawing.Point(8, 16);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.Size = new System.Drawing.Size(48, 16);
			this.lblLocationName.TabIndex = 1;
			this.lblLocationName.Text = "Name:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnClearHotkey);
			this.groupBox4.Controls.Add(this.txtKey);
			this.groupBox4.Controls.Add(this.lblHotkey);
			this.groupBox4.Controls.Add(this.btnSaveLoc);
			this.groupBox4.Controls.Add(this.txtLocationName);
			this.groupBox4.Controls.Add(this.lblLocationName);
			this.groupBox4.Location = new System.Drawing.Point(0, 144);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(176, 64);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Save new position";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(178, 538);
			this.Controls.Add(this.lblAuthors);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1200, 1000);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mobius v1.5";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		//[STAThread]
		static void Main()
		{
			Application.Run(new MainForm());
		}
		#endregion
		
		#region Constructors
		public MainForm()
		{
			//About aboutForm = new Mobius.About();.
			//aboutForm.ShowDialog();
			InitializeComponent();
		}
		#endregion
		
		#region Methods
		private void AddNewLocation(SavedLoc loc)
		{
			ExpandedTreeNode node = new ExpandedTreeNode(loc.Name);
			node.AssociatedObject = loc;
			node.Nodes.Add(String.Format("X: {0}", loc.X));
			node.Nodes.Add(String.Format("Y: {0}", loc.Y));
			node.Nodes.Add(String.Format("Z: {0}", loc.Z));
			node.Nodes.Add(String.Format("Key: {0}",loc.Key));
			this.lstSavedLocs.Nodes.Add(node);
		}
		
		
		private bool RefreshPointers()
		{
			System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(Mobius.Options.getProcessName());
			//MessageBox.Show(Mobius.Options.getProcessName(),"processname2" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			bool found = false;
			
			if (processes.Length > 0)
			{
				System.Diagnostics.Process wowProc = processes[0];
				
				int i = 0;
				int[] basePtrs = new int[] {
					0x12C3EC,
					0x12C3CC,
					0x12C3B4,
					0x12C3F0,
					0x12E188,
					0x13C3B4
				};
				
				while (!found & i < basePtrs.Length)
				{
					
					MemoryLoc stat = new MemoryLoc(wowProc, (int)basePtrs[i]);
					
					if (stat.GetInt32().ToString("x").EndsWith("008"))
					{
						//txtStatus.Text = String.Format("Base pointer found at: {0}", stat.GetInt32().ToString("x"));
						this.mX = new MemoryLoc(wowProc, stat.GetInt32() + 0x92C);
						this.mY = new MemoryLoc(wowProc, stat.GetInt32() + 0x928);
						this.mZ = new MemoryLoc(wowProc, stat.GetInt32() + 0x930);
						this.mSpeed = new MemoryLoc(wowProc, stat.GetInt32() + 0x9A4);
						this.mSwimSpeed = new MemoryLoc(wowProc, stat.GetInt32() + 0x9AC);
						this.mMountainClimb = new MemoryLoc(wowProc, 0x632344);
						this.mFallDamage = new MemoryLoc(wowProc, 0x486AAE);
						this.mFollowNPC = new MemoryLoc(wowProc, 0x49643d);
						this.mWoWTeleport = new MemoryLoc(wowProc, 0x4851E5);
						this.mMapHack = new MemoryLoc(wowProc, stat.GetInt32() + 0x28A0);
						this.mMapHackResources = new MemoryLoc(wowProc, stat.GetInt32() + 0x28A4);
						
						
						
						found = true;
					}
					i++;
				}
			}
			return found;
		}
		
		private void SaveLocationsToFile()
		{
			if (this.lstSavedLocs.Nodes.Count > 0)
			{
				SavedLoc[] locs = new SavedLoc[this.lstSavedLocs.Nodes.Count];
				
				int i = 0;
				foreach (ExpandedTreeNode node in this.lstSavedLocs.Nodes)
				{
					locs[i] = (SavedLoc)node.AssociatedObject;
					i++;
				}
				
				SavedLoc.SaveLocations("saved.xml", locs);
			}
		}
		public void LoadLocationsFromFile()
		{
			this.lstSavedLocs.Nodes.Clear();
			SavedLoc[] locs = SavedLoc.LoadLocations("saved.xml");
			foreach(SavedLoc loc in locs)
			{
				this.AddNewLocation(loc);
			}
		}
		
		private void RefreshGUIValues()
		{
			if (this.mX != null & this.mY != null & this.mZ != null)
			{
				float x = this.mX.GetFloat();
				float y = this.mY.GetFloat();
				float z = this.mZ.GetFloat();
				float s = this.mSpeed.GetFloat();
				this.DoMapHack();
				this.lblCurX.Text = String.Format("X: {0}", x.ToString());
				this.lblCurY.Text = String.Format("Y: {0}", y.ToString());
				this.lblCurZ.Text = String.Format("Z: {0}", z.ToString());
				this.lblCurSpeed.Text = String.Format("Speed: {0}", s.ToString());
				
			} else {
				RefreshPointers();
			}
		}
		private int FlipNum(int num, int min, int max)
		{
			int diff;
			diff = max - num;
			return min + diff;
		}
		
		public void DoMapHack()
		{
			byte bitmask = 0;
			byte bitmaskresources = 0;
			
			if (Mobius.Options.getHacks()[0] == true)
			{
				this.mMountainClimb.SetValueInt16(0x9090);
			} else {
				this.mMountainClimb.SetValueInt16(0x5576);
			}
			
			
			
			if (Mobius.Options.getHacks()[1] == true)
			{
				this.mFallDamage.SetValueInt16(0x45EB);
			} else {
				this.mFallDamage.SetValueInt16(0x4574);
			}
			
			
			if (Mobius.Options.getHacks()[2] == false){
				this.mSwimSpeed.SetValue((float)4.72);
			}
			
			
			
			
			if (Mobius.Options.getHacks()[3] == true)
			{
				this.mFollowNPC.SetValueInt16(0x9090);
			} else {
				this.mFollowNPC.SetValueInt16(0x3374);
			}
			
			
			if (Mobius.Options.getHacks()[4] == true)
			{
				this.mWoWTeleport.SetValueInt32(0x89909090);
			} else {
				this.mWoWTeleport.SetValueInt32(0x8908498b);
			}
			
			if (Mobius.Options.getHacks()[5] == true) {
				bitmask +=1;
			}
			if (Mobius.Options.getHacks()[6] == true) {
				bitmask +=2;
			}
			if (Mobius.Options.getHacks()[7] == true) {
				bitmask +=4;
			}
			if (Mobius.Options.getHacks()[8] == true) {
				bitmask +=8;
			}
			if (Mobius.Options.getHacks()[9] == true) {
				bitmask +=16;
			}
			if (Mobius.Options.getHacks()[10] == true) {
				bitmask +=32;
			}
			if (Mobius.Options.getHacks()[11] == true) {
				bitmask +=64;
			}
			if (Mobius.Options.getHacks()[12] == true) {
				bitmask +=128;
			}
			if (Mobius.Options.getHacks()[13] == true) {
				bitmaskresources +=2;
			}
			if (Mobius.Options.getHacks()[14] == true) {
				bitmaskresources +=4;
			}
			if (Mobius.Options.getHacks()[15] == true) {
				bitmaskresources +=32;
			}
			
			this.mMapHack.SetValueInt8(bitmask);
			this.mMapHackResources.SetValueInt8(bitmaskresources);
		}
		
		
		#endregion
		
		#region Event Handlers
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			actHook= new UserActivityHook();
			actHook.KeyDown+=new KeyEventHandler(MyKeyUp);
			actHook.KeyDown+=new KeyEventHandler(MyKeyDown);
			
			if (!this.RefreshPointers()) {
				//string msg = "Can't find WoW. Please run WoW and login to your character before using Mobius.";
				//string caption = "Error! Can't find WoW";
				//MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				//Application.Exit();
			}
			this.LoadLocationsFromFile();
			this.RefreshGUIValues();
			this.timRefreshCoords.Enabled = true;
			this.update.Enabled = true;
		}
		UserActivityHook actHook;
		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (addedLocations) {
				DialogResult result = MessageBox.Show("Would you like to save your locations?", "Save Now?", MessageBoxButtons.YesNoCancel);
				if (result == DialogResult.Yes)
				{
					this.SaveLocationsToFile();
				}
				else if (result == DialogResult.No)
				{
					e.Cancel = false;
				}
				else
				{
					e.Cancel = true;
				}
			}
		}
		
		public void MyKeyDown(object sender, KeyEventArgs e)
		{
			if(this.txtKey.Focused) this.txtKey.Text = e.KeyData.ToString();
		}
		private void quickload()
		{
			if (quicksaved) {
				this.mX.SetValue(quicklocx);
				this.mY.SetValue(quicklocy);
				this.mZ.SetValue(quicklocz);
				this.txtStatus.Text = this.txtStatus.Text + "Quickloaded Location\r\n";
			}
			else this.txtStatus.Text = this.txtStatus.Text + "No Quicksaved Location found!\r\n";
		}
		private void quicksave() {
			SavedLoc loc = new SavedLoc(this.txtLocationName.Text, this.mX.GetFloat(), this.mY.GetFloat(), this.mZ.GetFloat(),this.txtKey.Text);
			this.quicklocx = loc.X;
			this.quicklocy = loc.Y;
			this.quicklocz = loc.Z;
			this.txtStatus.Text = this.txtStatus.Text + "Quicksaved Location:\r\n" + "X: " + this.quicklocx + "\r\n" + "Y: " + this.quicklocy + "\r\n" + "Z: " + this.quicklocz + "\r\n";
			quicksaved = true;
		}
		public void MyKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyData.ToString() == "Insert") quicksave();
			if (e.KeyData.ToString() == "Delete") quickload();
			
			if (Mobius.Options.getHacks()[16]==true) {
				SavedLoc[] locs = SavedLoc.LoadLocations("saved.xml");
				
				foreach(SavedLoc loc in locs)
				{
					if(e.KeyData.ToString() == loc.Key.ToString())
					{
						this.mX.SetValue(loc.X);
						this.mY.SetValue(loc.Y);
						this.mZ.SetValue(loc.Z);
					}
				}
			}
		}
		
		private void txtX_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((byte)e.KeyChar == 13)
			{
				try
				{
					float x = float.Parse(this.txtX.Text);
					this.mX.SetValue(x);
				}
				catch
				{
					MessageBox.Show("I dont think WoW will like that 'number'.");
				}
			}
		}
		
		private void txtY_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((byte)e.KeyChar == 13)
			{
				try
				{
					float y = float.Parse(this.txtY.Text);
					this.mY.SetValue(y);
				}
				catch
				{
					MessageBox.Show("I dont think WoW will like that 'number'.");
				}
			}
		}
		
		private void txtZ_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((byte)e.KeyChar == 13)
			{
				try
				{
					float z = float.Parse(this.txtZ.Text);
					this.mZ.SetValue(z);
				}
				catch
				{
					MessageBox.Show("I dont think WoW will like that 'number'.");
				}
			}
		}
		
		private void txtSpeed_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((byte)e.KeyChar == 13)
			{
				try
				{
					float s = float.Parse(this.txtSpeed.Text);
					this.mSpeed.SetValue(s);
				}
				catch
				{
					MessageBox.Show("I dont think WoW will like that 'number'.");
				}
			}
		}
		
		private void lstSavedLocs_DoubleClick(object sender, System.EventArgs e)
		{
			if (this.lstSavedLocs.SelectedNode is ExpandedTreeNode)
			{
				ExpandedTreeNode node = (ExpandedTreeNode)this.lstSavedLocs.SelectedNode;
				
				if (this.mX != null & this.mY != null & this.mZ != null & node.AssociatedObject is SavedLoc)
				{
					SavedLoc loc = (SavedLoc)node.AssociatedObject;
					this.mX.SetValue(loc.X);
					this.mY.SetValue(loc.Y);
					this.mZ.SetValue(loc.Z);
				}
			}
		}
		
		
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			this.SaveLocationsToFile();
			addedLocations=false;
		}
		
		private void btnLoad_Click(object sender, System.EventArgs e)
		{
			this.LoadLocationsFromFile();
		}
		
		private void btnSaveLoc_Click(object sender, System.EventArgs e)
		{
			if (this.mX != null & this.mY != null & this.mZ != null)
			{
				addedLocations=true;
				SavedLoc loc = new SavedLoc(this.txtLocationName.Text, this.mX.GetFloat(), this.mY.GetFloat(), this.mZ.GetFloat(),this.txtKey.Text);
				this.AddNewLocation(loc);
				this.txtLocationName.Text = "";
			}
		}
		
		
		private void timRefreshCoords_Tick(object sender, System.EventArgs e)
		{
			this.RefreshGUIValues();
		}
		
		private void btnRefreshPointers_Click(object sender, System.EventArgs e)
		{
			if (!this.RefreshPointers())
			{
				MessageBox.Show("Reload Failed!");
			}
		}
	
		#endregion
		void UpdateTick(object sender, System.EventArgs e)
		{
			
			if (!this.RefreshPointers())
			{
				if (this.mY!=null) this.txtStatus.Text = this.txtStatus.Text + "Reload failed !\r\n";
			}
			
		}
		
		void LstSavedLocsAfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			
		}
		void BtnOptionsClick(object sender, System.EventArgs e)
		{
			optionsForm.Show();
		}
		void BtnClearStatusClick(object sender, System.EventArgs e)
		{
			this.txtStatus.Text = "";
		}				
		void BtnClearHotkeyClick(object sender, System.EventArgs e)
		{
			txtKey.Clear();
		}

		private void lblAuthors_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			SavedLoc.RemoveLoc("saved.xml" , this.lstSavedLocs.SelectedNode.Text);
			this.lstSavedLocs.SelectedNode.Remove();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			if (this.lstSavedLocs.SelectedNode is ExpandedTreeNode)
			{
				frmLocEdit editForm = new frmLocEdit();
				ExpandedTreeNode node = (ExpandedTreeNode)this.lstSavedLocs.SelectedNode;

				SavedLoc loc = (SavedLoc)node.AssociatedObject;
				
				editForm.editName = loc.Name;
				editForm.editX = loc.X.ToString();
				editForm.editY = loc.Y.ToString();
				editForm.editZ = loc.Z.ToString();
				editForm.ShowDialog();
			}
				
					LoadLocationsFromFile();

		}
		
	}
}
