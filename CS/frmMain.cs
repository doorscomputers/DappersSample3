// VBConversions Note: VB project level imports
using System.Data;
using System.Collections.Generic;
using PDSA.Data;
using PDSA.WinForms.Forms;
using PDSA.Security;
using System.Diagnostics;
using PDSA.Common;
using PDSA.WinForms;
using PDSA.WinForms.Security;
using PDSA.PDSACryptography;
using DoorsPOS.Utility;
using Microsoft.VisualBasic;
using System.Collections;
using System;
using DoorsPOS.BusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using DoorsPOS.DataLayer;
// End of VB project level imports

//using System.Windows.Forms.Form;
using System.ComponentModel;
using System.Text;
using DevExpress.XtraBars;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using PDSA.DataLayer.DataClasses;
using PDSA.Validation;
using KellermanSoftware.NetDataAccessLayer;

//Imports DevExpress.XtraBars.Ribbon
//Imports DevExpress.XtraBars.Helpers

namespace DoorsPOS.WinApp
{
	public class frmMain : PDSAFormBase
	{
		
#region Default Instance
		
		private static frmMain defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
public static frmMain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmMain();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		
#region  Windows Form Designer generated code
		
		public frmMain()
		{
			
			// Track User Flag must be set here or it won't be set in time
			// MyBase.UserTrack = False
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
			
			// This is done for apparent speed
			Control ctlSelected;
			ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
			
			//Add any initialization after the InitializeComponent() call
			
			//*** NEED TO TURN THIS OFF FOR THE MAIN FORM ***
			//*** WE NEED TO WAIT UNTIL WE LOGIN FIRST ***
			base.CheckSecurityOnControls = false;
		}
		
		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (!(components == null))
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		internal System.Windows.Forms.MainMenu mnuMain;
		internal System.Windows.Forms.MenuItem mnuFile;
		internal System.Windows.Forms.MenuItem mnuFExit;
		internal System.Windows.Forms.MenuItem mnuWindow;
		internal System.Windows.Forms.MenuItem mnuHelp;
		internal System.Windows.Forms.MenuItem mnuHFramework;
		internal System.Windows.Forms.MenuItem mnuHAbout;
		internal System.Windows.Forms.MenuItem mnuWCloseAll;
		internal System.Windows.Forms.MenuItem mnuFSignOut;
		internal System.Windows.Forms.MenuItem mnuSecurity;
		internal System.Windows.Forms.MenuItem mnuSPermission;
		internal System.Windows.Forms.MenuItem mnuSRoles;
		internal System.Windows.Forms.MenuItem mnuSUsers;
		internal System.Windows.Forms.MenuItem mnuLookups;
		internal System.Windows.Forms.MenuItem mnuLException;
		internal System.Windows.Forms.MenuItem mnuLUserTrack;
		internal System.Windows.Forms.MenuItem mnuSUsersToRoles;
		internal System.Windows.Forms.MenuItem mnuSRolesToPermissions;
		internal System.Windows.Forms.MenuItem mnuEdit;
		internal System.Windows.Forms.MenuItem mnuECopy;
		internal System.Windows.Forms.MenuItem mnuECut;
		internal System.Windows.Forms.MenuItem mnuEPaste;
		internal System.Windows.Forms.MenuItem mnuSSecControls;
		internal System.Windows.Forms.MenuItem mnuLUserLogin;
		internal System.Windows.Forms.MenuItem mnuSPwdChange;
		internal System.Windows.Forms.MenuItem mnuSSep1;
		internal System.Windows.Forms.MenuItem MenuItem1;
		internal System.Windows.Forms.MenuItem mnuMWinFormMaint;
		internal System.Windows.Forms.MenuItem mnuSUserCategory;
		internal System.Windows.Forms.MenuItem mnuPOS;
		internal System.Windows.Forms.MenuItem mnuManualInv;
		internal System.Windows.Forms.MenuItem mnuNewItems;
		internal System.Windows.Forms.MenuItem mnuItemGrid;
		internal System.Windows.Forms.MenuItem MenuItem10;
		internal System.Windows.Forms.MenuItem MenuItem14;
		internal System.Windows.Forms.MenuItem MenuItem23;
		internal System.Windows.Forms.MenuItem MenuItem16;
		internal System.Windows.Forms.MenuItem mnuAmPm;
		internal System.Windows.Forms.MenuItem MenuItem18;
		internal System.Windows.Forms.MenuItem mnuBelowMin;
		internal System.Windows.Forms.MenuItem mnuAboveMax;
		internal System.Windows.Forms.MenuItem MenuItem21;
		internal System.Windows.Forms.MenuItem MenuItem2;
		internal System.Windows.Forms.MenuItem MenuItem7;
		internal System.Windows.Forms.MenuItem MenuItem4;
		internal System.Windows.Forms.MenuItem MenuItem5;
		internal System.Windows.Forms.MenuItem MenuItem8;
		internal System.Windows.Forms.MenuItem MenuItem19;
		internal System.Windows.Forms.MenuItem MenuItem20;
		internal System.Windows.Forms.MenuItem MenuItem24;
		internal System.Windows.Forms.MenuItem MenuItem25;
		internal System.Windows.Forms.MenuItem MenuItem26;
		internal System.Windows.Forms.MenuItem MenuItem27;
		internal System.Windows.Forms.MenuItem MenuItem28;
		internal System.Windows.Forms.MenuItem MenuItem22;
		internal System.Windows.Forms.MenuItem MenuItem29;
		internal System.Windows.Forms.MenuItem MenuItem30;
		internal System.Windows.Forms.MenuItem MenuItem31;
		internal System.Windows.Forms.MenuItem MenuItem11;
		internal System.Windows.Forms.MenuItem MenuItem13;
		internal System.Windows.Forms.MenuItem MenuItem47;
		internal System.Windows.Forms.MenuItem MenuItem48;
		internal System.Windows.Forms.MenuItem MenuItem33;
		internal System.Windows.Forms.MenuItem MenuItem34;
		internal System.Windows.Forms.MenuItem MenuItem35;
		internal System.Windows.Forms.MenuItem MenuItem36;
		internal System.Windows.Forms.MenuItem MenuItem37;
		internal System.Windows.Forms.MenuItem MenuItem46;
		internal System.Windows.Forms.MenuItem MenuItem39;
		internal System.Windows.Forms.MenuItem MenuItem40;
		internal System.Windows.Forms.MenuItem MenuItem41;
		internal System.Windows.Forms.MenuItem MenuItem42;
		internal System.Windows.Forms.MenuItem MenuItem49;
		internal System.Windows.Forms.MenuItem MenuItem50;
		internal System.Windows.Forms.MenuItem MenuItem51;
		internal System.Windows.Forms.MenuItem MenuItem52;
		internal System.Windows.Forms.MenuItem MenuItem53;
		internal System.Windows.Forms.MenuItem MenuItem54;
		internal System.Windows.Forms.MenuItem MenuItem56;
		internal System.Windows.Forms.MenuItem MenuItem55;
		internal System.Windows.Forms.MenuItem MenuItem57;
		internal System.Windows.Forms.MenuItem MenuItem59;
		internal System.Windows.Forms.MenuItem MenuItem60;
		internal System.Windows.Forms.MenuItem MenuItem15;
		internal System.Windows.Forms.MenuItem MenuItem32;
		internal System.Windows.Forms.MenuItem MenuItem61;
		internal System.Windows.Forms.MenuItem MenuItem62;
		internal System.Windows.Forms.MenuItem MenuItem38;
		internal System.Windows.Forms.MenuItem MenuItem44;
		internal System.Windows.Forms.MenuItem MenuItem43;
		internal System.Windows.Forms.MenuItem MenuItem45;
		internal System.Windows.Forms.MenuItem MenuItem63;
		internal System.Windows.Forms.MenuItem MenuItem64;
		internal System.Windows.Forms.MenuItem MenuItem65;
		internal System.Windows.Forms.MenuItem MenuItem66;
		internal System.Windows.Forms.MenuItem MenuItem67;
		internal System.Windows.Forms.MenuItem MenuItem6;
		internal System.Windows.Forms.MenuItem MenuItem9;
		internal System.Windows.Forms.MenuItem MenuItem69;
		internal System.Windows.Forms.MenuItem MenuItem68;
		internal System.Windows.Forms.MenuItem MenuItem70;
		internal System.Windows.Forms.MenuItem MenuItem71;
		internal System.Windows.Forms.MenuItem MenuItem72;
		internal System.Windows.Forms.MenuItem MenuItem73;
		internal System.Windows.Forms.MenuItem MenuItem74;
		internal System.Windows.Forms.MenuItem MenuItem75;
		internal System.Windows.Forms.MenuItem MenuItem76;
		internal System.Windows.Forms.MenuItem MenuItem78;
		internal System.Windows.Forms.MenuItem MenuItem79;
		internal System.Windows.Forms.MenuItem MenuItem80;
		internal System.Windows.Forms.MenuItem MenuItem81;
		internal System.Windows.Forms.MenuItem MenuItem82;
		internal System.Windows.Forms.MenuItem MenuItem84;
		internal System.Windows.Forms.MenuItem MenuItem85;
		internal System.Windows.Forms.MenuItem MenuItem86;
		internal System.Windows.Forms.MenuItem MenuItem87;
		internal System.Windows.Forms.MenuItem MenuItem83;
		internal System.Windows.Forms.MenuItem MenuItem88;
		internal System.Windows.Forms.MenuItem MenuItem89;
		internal System.Windows.Forms.MenuItem MenuItem90;
		internal System.Windows.Forms.MenuItem MenuItem91;
		internal System.Windows.Forms.MenuItem MenuItem92;
		internal System.Windows.Forms.MenuItem MenuItem94;
		internal System.Windows.Forms.MenuItem MenuItem93;
		internal System.Windows.Forms.MenuItem MenuItem95;
		internal System.Windows.Forms.MenuItem MenuItem96;
		internal System.Windows.Forms.MenuItem MenuItem97;
		internal System.Windows.Forms.MenuItem MenuItem98;
		internal System.Windows.Forms.MenuItem MenuItem99;
		internal System.Windows.Forms.MenuItem MenuItem100;
		internal System.Windows.Forms.MenuItem MenuItem101;
		internal System.Windows.Forms.MenuItem MenuItem102;
		internal System.Windows.Forms.MenuItem MenuItem77;
		internal System.Windows.Forms.MenuItem MenuItem103;
		internal System.Windows.Forms.MenuItem MenuItem104;
		internal System.Windows.Forms.MenuItem MenuItem58;
		internal System.Windows.Forms.MenuItem MenuItem106;
		internal System.Windows.Forms.MenuItem MenuItem105;
		internal System.Windows.Forms.MenuItem MenuItem12;
		internal System.Windows.Forms.MenuItem MenuItem3;
		internal System.Windows.Forms.MenuItem MenuItem107;
		internal System.Windows.Forms.MenuItem MenuItem108;
		internal System.Windows.Forms.MenuItem MenuItem109;
		internal System.Windows.Forms.MenuItem MenuItem110;
		internal System.Windows.Forms.MenuItem MenuItem111;
		internal System.Windows.Forms.MenuItem MenuItem112;
		internal System.Windows.Forms.MenuItem MenuItem17;
		internal System.Windows.Forms.MenuItem MenuItem116;
		internal System.Windows.Forms.MenuItem MenuItem117;
		internal System.Windows.Forms.MenuItem MenuItem118;
		internal System.Windows.Forms.MenuItem MenuItem115;
		internal System.Windows.Forms.MenuItem MenuItem114;
		internal System.Windows.Forms.MenuItem MenuItem113;
		internal System.Windows.Forms.MenuItem MenuItem119;
		internal System.Windows.Forms.MenuItem MenuItem120;
		internal System.Windows.Forms.MenuItem MenuItem121;
		internal System.Windows.Forms.MenuItem MenuItem122;
		internal System.Windows.Forms.MenuItem MenuItem124;
		internal System.Windows.Forms.MenuItem MenuItem123;
		internal System.Windows.Forms.MenuItem MenuItem125;
		internal System.Windows.Forms.MenuItem MenuItem126;
		internal System.Windows.Forms.MenuItem MenuItem127;
		internal System.Windows.Forms.MenuItem MenuItem128;
		internal System.Windows.Forms.MenuItem MenuItem129;
		internal System.Windows.Forms.MenuItem MenuItem130;
		internal System.Windows.Forms.MenuItem MenuItem131;
		internal System.Windows.Forms.MenuItem MenuItem132;
		internal System.Windows.Forms.MenuItem MenuItem133;
		internal System.Windows.Forms.MenuItem MenuItem135;
		internal System.Windows.Forms.MenuItem MenuItem134;
		internal System.Windows.Forms.MenuItem MenuItem137;
		internal System.Windows.Forms.MenuItem MenuItem136;
		internal System.Windows.Forms.MenuItem MenuItem139;
		internal System.Windows.Forms.MenuItem MenuItem138;
		internal System.Windows.Forms.MenuItem MenuItem140;
		internal System.Windows.Forms.MenuItem MenuItem141;
		internal System.Windows.Forms.MenuItem MenuItem142;
		internal System.Windows.Forms.MenuItem MenuItem144;
		internal System.Windows.Forms.MenuItem MenuItem143;
		internal System.Windows.Forms.MenuItem MenuItem145;
		internal System.Windows.Forms.MenuItem MenuItem146;
		internal System.Windows.Forms.MenuItem MenuItem147;
		internal System.Windows.Forms.MenuItem MenuItem148;
		internal System.Windows.Forms.MenuItem MenuItem149;
		internal System.Windows.Forms.MenuItem MenuItem150;
		internal System.Windows.Forms.MenuItem MenuItem151;
		internal System.Windows.Forms.MenuItem MenuItem152;
		internal System.Windows.Forms.MenuItem MenuItem153;
		internal System.Windows.Forms.MenuItem MenuItem154;
		internal System.Windows.Forms.MenuItem MenuItem155;
		internal System.Windows.Forms.MenuItem MenuItem156;
		internal System.Windows.Forms.MenuItem MenuItem157;
		internal System.Windows.Forms.MenuItem MenuItem158;
		internal System.Windows.Forms.MenuItem MenuItem159;
		internal System.Windows.Forms.MenuItem MenuItem160;
		internal System.Windows.Forms.MenuItem MenuItem161;
		internal System.Windows.Forms.MenuItem MenuItem162;
		internal System.Windows.Forms.MenuItem MenuItem163;
		internal System.Windows.Forms.MenuItem MenuItem164;
		internal System.Windows.Forms.MenuItem MenuItem165;
		internal System.Windows.Forms.MenuItem MenuItem166;
		internal System.Windows.Forms.MenuItem MenuItem167;
		internal System.Windows.Forms.MenuItem MenuItem168;
		internal System.Windows.Forms.MenuItem MenuItem169;
		internal System.Windows.Forms.MenuItem MenuItem170;
		internal System.Windows.Forms.MenuItem MenuItem171;
		internal System.Windows.Forms.MenuItem mnuSSep2;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(PDSAFormBase_KeyDown);
			base.Load += new System.EventHandler(frmMain_Load);
			this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuNewItems = new System.Windows.Forms.MenuItem();
			this.mnuNewItems.Click += new System.EventHandler(this.MenuItem8_Click);
			this.mnuItemGrid = new System.Windows.Forms.MenuItem();
			this.mnuItemGrid.Click += new System.EventHandler(this.MenuItem9_Click);
			this.MenuItem166 = new System.Windows.Forms.MenuItem();
			this.MenuItem166.Click += new System.EventHandler(this.mnuNewBarcode);
			this.MenuItem167 = new System.Windows.Forms.MenuItem();
			this.MenuItem167.Click += new System.EventHandler(this.MenuItem167_Click);
			this.MenuItem10 = new System.Windows.Forms.MenuItem();
			this.mnuPOS = new System.Windows.Forms.MenuItem();
			this.mnuPOS.Click += new System.EventHandler(this.MenuItem2_Click);
			this.MenuItem151 = new System.Windows.Forms.MenuItem();
			this.MenuItem151.Click += new System.EventHandler(this.MenuItem151_Click);
			this.MenuItem152 = new System.Windows.Forms.MenuItem();
			this.MenuItem152.Click += new System.EventHandler(this.MenuItem152_Click);
			this.MenuItem14 = new System.Windows.Forms.MenuItem();
			this.mnuManualInv = new System.Windows.Forms.MenuItem();
			this.mnuManualInv.Click += new System.EventHandler(this.MenuItem7_Click);
			this.MenuItem23 = new System.Windows.Forms.MenuItem();
			this.MenuItem19 = new System.Windows.Forms.MenuItem();
			this.MenuItem19.Click += new System.EventHandler(this.MenuItem19_Click);
			this.MenuItem20 = new System.Windows.Forms.MenuItem();
			this.MenuItem95 = new System.Windows.Forms.MenuItem();
			this.MenuItem155 = new System.Windows.Forms.MenuItem();
			this.MenuItem155.Click += new System.EventHandler(this.MenuItem155_Click);
			this.MenuItem156 = new System.Windows.Forms.MenuItem();
			this.MenuItem96 = new System.Windows.Forms.MenuItem();
			this.MenuItem96.Click += new System.EventHandler(this.MenuItem96_Click);
			this.MenuItem97 = new System.Windows.Forms.MenuItem();
			this.MenuItem97.Click += new System.EventHandler(this.MenuItem97_Click);
			this.MenuItem98 = new System.Windows.Forms.MenuItem();
			this.MenuItem98.Click += new System.EventHandler(this.MenuItem98_Click);
			this.MenuItem99 = new System.Windows.Forms.MenuItem();
			this.MenuItem99.Click += new System.EventHandler(this.MenuItem99_Click);
			this.MenuItem100 = new System.Windows.Forms.MenuItem();
			this.MenuItem158 = new System.Windows.Forms.MenuItem();
			this.MenuItem158.Click += new System.EventHandler(this.MenuItem158_Click);
			this.MenuItem159 = new System.Windows.Forms.MenuItem();
			this.MenuItem145 = new System.Windows.Forms.MenuItem();
			this.MenuItem145.Click += new System.EventHandler(this.MenuItem145_Click);
			this.MenuItem160 = new System.Windows.Forms.MenuItem();
			this.MenuItem161 = new System.Windows.Forms.MenuItem();
			this.MenuItem161.Click += new System.EventHandler(this.MenuItem161_Click);
			this.MenuItem162 = new System.Windows.Forms.MenuItem();
			this.MenuItem162.Click += new System.EventHandler(this.MenuItem162_Click);
			this.MenuItem163 = new System.Windows.Forms.MenuItem();
			this.mnuFSignOut = new System.Windows.Forms.MenuItem();
			this.mnuFSignOut.Click += new System.EventHandler(this.mnuFSignOut_Click);
			this.mnuFExit = new System.Windows.Forms.MenuItem();
			this.mnuFExit.Click += new System.EventHandler(this.mnuFExit_Click);
			this.MenuItem24 = new System.Windows.Forms.MenuItem();
			this.MenuItem25 = new System.Windows.Forms.MenuItem();
			this.MenuItem25.Click += new System.EventHandler(this.MenuItem25_Click);
			this.MenuItem26 = new System.Windows.Forms.MenuItem();
			this.MenuItem27 = new System.Windows.Forms.MenuItem();
			this.MenuItem27.Click += new System.EventHandler(this.MenuItem27_Click);
			this.MenuItem28 = new System.Windows.Forms.MenuItem();
			this.MenuItem22 = new System.Windows.Forms.MenuItem();
			this.MenuItem22.Click += new System.EventHandler(this.MenuItem22_Click);
			this.MenuItem11 = new System.Windows.Forms.MenuItem();
			this.MenuItem29 = new System.Windows.Forms.MenuItem();
			this.MenuItem29.Click += new System.EventHandler(this.MenuItem29_Click);
			this.MenuItem30 = new System.Windows.Forms.MenuItem();
			this.MenuItem64 = new System.Windows.Forms.MenuItem();
			this.MenuItem64.Click += new System.EventHandler(this.MenuItem64_Click);
			this.MenuItem58 = new System.Windows.Forms.MenuItem();
			this.MenuItem31 = new System.Windows.Forms.MenuItem();
			this.MenuItem31.Click += new System.EventHandler(this.MenuItem31_Click);
			this.MenuItem116 = new System.Windows.Forms.MenuItem();
			this.MenuItem117 = new System.Windows.Forms.MenuItem();
			this.MenuItem117.Click += new System.EventHandler(this.MenuItem117_Click);
			this.MenuItem118 = new System.Windows.Forms.MenuItem();
			this.MenuItem115 = new System.Windows.Forms.MenuItem();
			this.MenuItem115.Click += new System.EventHandler(this.MenuItem115_Click);
			this.MenuItem149 = new System.Windows.Forms.MenuItem();
			this.MenuItem150 = new System.Windows.Forms.MenuItem();
			this.MenuItem150.Click += new System.EventHandler(this.MenuItem150_Click);
			this.MenuItem16 = new System.Windows.Forms.MenuItem();
			this.MenuItem168 = new System.Windows.Forms.MenuItem();
			this.MenuItem168.Click += new System.EventHandler(this.MenuItem168_Click);
			this.mnuAmPm = new System.Windows.Forms.MenuItem();
			this.mnuAmPm.Click += new System.EventHandler(this.mnuAmPm_Click);
			this.MenuItem18 = new System.Windows.Forms.MenuItem();
			this.MenuItem92 = new System.Windows.Forms.MenuItem();
			this.MenuItem92.Click += new System.EventHandler(this.MenuItem92_Click);
			this.MenuItem38 = new System.Windows.Forms.MenuItem();
			this.MenuItem38.Click += new System.EventHandler(this.MenuItem38_Click);
			this.mnuBelowMin = new System.Windows.Forms.MenuItem();
			this.mnuBelowMin.Click += new System.EventHandler(this.mnuBelowMin_Click);
			this.mnuAboveMax = new System.Windows.Forms.MenuItem();
			this.mnuAboveMax.Click += new System.EventHandler(this.mnuAboveMax_Click);
			this.MenuItem48 = new System.Windows.Forms.MenuItem();
			this.MenuItem48.Click += new System.EventHandler(this.MenuItem48_Click);
			this.MenuItem21 = new System.Windows.Forms.MenuItem();
			this.MenuItem111 = new System.Windows.Forms.MenuItem();
			this.MenuItem111.Click += new System.EventHandler(this.MenuItem111_Click);
			this.MenuItem2 = new System.Windows.Forms.MenuItem();
			this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click_1);
			this.MenuItem165 = new System.Windows.Forms.MenuItem();
			this.MenuItem165.Click += new System.EventHandler(this.MenuItem165_Click);
			this.MenuItem7 = new System.Windows.Forms.MenuItem();
			this.MenuItem73 = new System.Windows.Forms.MenuItem();
			this.MenuItem73.Click += new System.EventHandler(this.MenuItem73_Click);
			this.MenuItem5 = new System.Windows.Forms.MenuItem();
			this.MenuItem4 = new System.Windows.Forms.MenuItem();
			this.MenuItem72 = new System.Windows.Forms.MenuItem();
			this.MenuItem8 = new System.Windows.Forms.MenuItem();
			this.MenuItem8.Click += new System.EventHandler(this.MenuItem8_Click_1);
			this.MenuItem12 = new System.Windows.Forms.MenuItem();
			this.MenuItem3 = new System.Windows.Forms.MenuItem();
			this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
			this.MenuItem47 = new System.Windows.Forms.MenuItem();
			this.MenuItem57 = new System.Windows.Forms.MenuItem();
			this.MenuItem57.Click += new System.EventHandler(this.MenuItem57_Click);
			this.MenuItem60 = new System.Windows.Forms.MenuItem();
			this.MenuItem60.Click += new System.EventHandler(this.MenuItem60_Click);
			this.MenuItem133 = new System.Windows.Forms.MenuItem();
			this.MenuItem133.Click += new System.EventHandler(this.MenuItem133_Click);
			this.MenuItem62 = new System.Windows.Forms.MenuItem();
			this.MenuItem62.Click += new System.EventHandler(this.MenuItem62_Click);
			this.MenuItem67 = new System.Windows.Forms.MenuItem();
			this.MenuItem67.Click += new System.EventHandler(this.MenuItem67_Click);
			this.MenuItem94 = new System.Windows.Forms.MenuItem();
			this.MenuItem93 = new System.Windows.Forms.MenuItem();
			this.MenuItem93.Click += new System.EventHandler(this.MenuItem93_Click);
			this.MenuItem101 = new System.Windows.Forms.MenuItem();
			this.MenuItem102 = new System.Windows.Forms.MenuItem();
			this.MenuItem102.Click += new System.EventHandler(this.MenuItem102_Click);
			this.MenuItem135 = new System.Windows.Forms.MenuItem();
			this.MenuItem134 = new System.Windows.Forms.MenuItem();
			this.MenuItem134.Click += new System.EventHandler(this.MenuItem134_Click);
			this.MenuItem33 = new System.Windows.Forms.MenuItem();
			this.MenuItem169 = new System.Windows.Forms.MenuItem();
			this.MenuItem169.Click += new System.EventHandler(this.MenuItem169_Click);
			this.MenuItem144 = new System.Windows.Forms.MenuItem();
			this.MenuItem144.Click += new System.EventHandler(this.MenuItem144_Click);
			this.MenuItem170 = new System.Windows.Forms.MenuItem();
			this.MenuItem170.Click += new System.EventHandler(this.MenuItem170_Click);
			this.MenuItem132 = new System.Windows.Forms.MenuItem();
			this.MenuItem132.Click += new System.EventHandler(this.MenuItem132_Click);
			this.MenuItem51 = new System.Windows.Forms.MenuItem();
			this.MenuItem51.Click += new System.EventHandler(this.MenuItem51_Click);
			this.MenuItem34 = new System.Windows.Forms.MenuItem();
			this.MenuItem34.Click += new System.EventHandler(this.MenuItem34_Click);
			this.MenuItem9 = new System.Windows.Forms.MenuItem();
			this.MenuItem9.Click += new System.EventHandler(this.MenuItem9_Click_1);
			this.MenuItem53 = new System.Windows.Forms.MenuItem();
			this.MenuItem53.Click += new System.EventHandler(this.MenuItem53_Click);
			this.MenuItem69 = new System.Windows.Forms.MenuItem();
			this.MenuItem143 = new System.Windows.Forms.MenuItem();
			this.MenuItem143.Click += new System.EventHandler(this.MenuItem143_Click);
			this.MenuItem112 = new System.Windows.Forms.MenuItem();
			this.MenuItem112.Click += new System.EventHandler(this.MenuItem112_Click);
			this.MenuItem17 = new System.Windows.Forms.MenuItem();
			this.MenuItem68 = new System.Windows.Forms.MenuItem();
			this.MenuItem68.Click += new System.EventHandler(this.MenuItem68_Click);
			this.MenuItem52 = new System.Windows.Forms.MenuItem();
			this.MenuItem36 = new System.Windows.Forms.MenuItem();
			this.MenuItem36.Click += new System.EventHandler(this.MenuItem36_Click);
			this.MenuItem110 = new System.Windows.Forms.MenuItem();
			this.MenuItem110.Click += new System.EventHandler(this.MenuItem110_Click);
			this.MenuItem104 = new System.Windows.Forms.MenuItem();
			this.MenuItem104.Click += new System.EventHandler(this.MenuItem104_Click);
			this.MenuItem141 = new System.Windows.Forms.MenuItem();
			this.MenuItem141.Click += new System.EventHandler(this.MenuItem141_Click);
			this.MenuItem142 = new System.Windows.Forms.MenuItem();
			this.MenuItem142.Click += new System.EventHandler(this.MenuItem142_Click);
			this.MenuItem153 = new System.Windows.Forms.MenuItem();
			this.MenuItem153.Click += new System.EventHandler(this.MenuItem153_Click);
			this.MenuItem139 = new System.Windows.Forms.MenuItem();
			this.MenuItem138 = new System.Windows.Forms.MenuItem();
			this.MenuItem138.Click += new System.EventHandler(this.MenuItem138_Click);
			this.MenuItem35 = new System.Windows.Forms.MenuItem();
			this.MenuItem109 = new System.Windows.Forms.MenuItem();
			this.MenuItem109.Click += new System.EventHandler(this.MenuItem109_Click);
			this.MenuItem45 = new System.Windows.Forms.MenuItem();
			this.MenuItem45.Click += new System.EventHandler(this.MenuItem45_Click);
			this.MenuItem37 = new System.Windows.Forms.MenuItem();
			this.MenuItem46 = new System.Windows.Forms.MenuItem();
			this.MenuItem46.Click += new System.EventHandler(this.MenuItem46_Click);
			this.MenuItem6 = new System.Windows.Forms.MenuItem();
			this.MenuItem6.Click += new System.EventHandler(this.MenuItem6_Click);
			this.MenuItem61 = new System.Windows.Forms.MenuItem();
			this.MenuItem44 = new System.Windows.Forms.MenuItem();
			this.MenuItem44.Click += new System.EventHandler(this.MenuItem44_Click);
			this.MenuItem43 = new System.Windows.Forms.MenuItem();
			this.MenuItem43.Click += new System.EventHandler(this.MenuItem43_Click);
			this.MenuItem65 = new System.Windows.Forms.MenuItem();
			this.MenuItem66 = new System.Windows.Forms.MenuItem();
			this.MenuItem66.Click += new System.EventHandler(this.MenuItem66_Click);
			this.MenuItem77 = new System.Windows.Forms.MenuItem();
			this.MenuItem103 = new System.Windows.Forms.MenuItem();
			this.MenuItem103.Click += new System.EventHandler(this.MenuItem103_Click);
			this.MenuItem108 = new System.Windows.Forms.MenuItem();
			this.MenuItem108.Click += new System.EventHandler(this.MenuItem108_Click);
			this.MenuItem106 = new System.Windows.Forms.MenuItem();
			this.MenuItem105 = new System.Windows.Forms.MenuItem();
			this.MenuItem105.Click += new System.EventHandler(this.MenuItem105_Click);
			this.MenuItem107 = new System.Windows.Forms.MenuItem();
			this.MenuItem107.Click += new System.EventHandler(this.MenuItem107_Click);
			this.MenuItem119 = new System.Windows.Forms.MenuItem();
			this.MenuItem120 = new System.Windows.Forms.MenuItem();
			this.MenuItem120.Click += new System.EventHandler(this.MenuItem120_Click);
			this.MenuItem121 = new System.Windows.Forms.MenuItem();
			this.MenuItem122 = new System.Windows.Forms.MenuItem();
			this.MenuItem122.Click += new System.EventHandler(this.MenuItem122_Click);
			this.MenuItem147 = new System.Windows.Forms.MenuItem();
			this.MenuItem147.Click += new System.EventHandler(this.MenuItem147_Click);
			this.MenuItem124 = new System.Windows.Forms.MenuItem();
			this.MenuItem129 = new System.Windows.Forms.MenuItem();
			this.MenuItem123 = new System.Windows.Forms.MenuItem();
			this.MenuItem123.Click += new System.EventHandler(this.MenuItem123_Click);
			this.MenuItem125 = new System.Windows.Forms.MenuItem();
			this.MenuItem125.Click += new System.EventHandler(this.MenuItem125_Click);
			this.MenuItem126 = new System.Windows.Forms.MenuItem();
			this.MenuItem126.Click += new System.EventHandler(this.MenuItem126_Click);
			this.MenuItem128 = new System.Windows.Forms.MenuItem();
			this.MenuItem128.Click += new System.EventHandler(this.MenuItem128_Click);
			this.MenuItem130 = new System.Windows.Forms.MenuItem();
			this.MenuItem130.Click += new System.EventHandler(this.MenuItem130_Click);
			this.MenuItem131 = new System.Windows.Forms.MenuItem();
			this.MenuItem131.Click += new System.EventHandler(this.MenuItem131_Click);
			this.MenuItem127 = new System.Windows.Forms.MenuItem();
			this.MenuItem127.Click += new System.EventHandler(this.MenuItem127_Click);
			this.MenuItem148 = new System.Windows.Forms.MenuItem();
			this.MenuItem148.Click += new System.EventHandler(this.MenuItem148_Click);
			this.MenuItem137 = new System.Windows.Forms.MenuItem();
			this.MenuItem136 = new System.Windows.Forms.MenuItem();
			this.MenuItem136.Click += new System.EventHandler(this.MenuItem136_Click);
			this.MenuItem157 = new System.Windows.Forms.MenuItem();
			this.MenuItem157.Click += new System.EventHandler(this.MenuItem157_Click);
			this.MenuItem13 = new System.Windows.Forms.MenuItem();
			this.MenuItem146 = new System.Windows.Forms.MenuItem();
			this.MenuItem146.Click += new System.EventHandler(this.MenuItem146_Click);
			this.MenuItem87 = new System.Windows.Forms.MenuItem();
			this.MenuItem87.Click += new System.EventHandler(this.MenuItem87_Click);
			this.MenuItem84 = new System.Windows.Forms.MenuItem();
			this.MenuItem84.Click += new System.EventHandler(this.MenuItem84_Click);
			this.MenuItem74 = new System.Windows.Forms.MenuItem();
			this.MenuItem74.Click += new System.EventHandler(this.MenuItem74_Click);
			this.MenuItem85 = new System.Windows.Forms.MenuItem();
			this.MenuItem85.Click += new System.EventHandler(this.MenuItem85_Click);
			this.MenuItem86 = new System.Windows.Forms.MenuItem();
			this.MenuItem86.Click += new System.EventHandler(this.MenuItem86_Click);
			this.MenuItem75 = new System.Windows.Forms.MenuItem();
			this.MenuItem32 = new System.Windows.Forms.MenuItem();
			this.MenuItem32.Click += new System.EventHandler(this.MenuItem32_Click);
			this.MenuItem59 = new System.Windows.Forms.MenuItem();
			this.MenuItem59.Click += new System.EventHandler(this.MenuItem59_Click);
			this.MenuItem15 = new System.Windows.Forms.MenuItem();
			this.MenuItem15.Click += new System.EventHandler(this.MenuItem15_Click);
			this.MenuItem114 = new System.Windows.Forms.MenuItem();
			this.MenuItem49 = new System.Windows.Forms.MenuItem();
			this.MenuItem49.Click += new System.EventHandler(this.MenuItem49_Click);
			this.MenuItem113 = new System.Windows.Forms.MenuItem();
			this.MenuItem50 = new System.Windows.Forms.MenuItem();
			this.MenuItem50.Click += new System.EventHandler(this.MenuItem50_Click);
			this.MenuItem83 = new System.Windows.Forms.MenuItem();
			this.MenuItem88 = new System.Windows.Forms.MenuItem();
			this.MenuItem88.Click += new System.EventHandler(this.MenuItem88_Click);
			this.MenuItem89 = new System.Windows.Forms.MenuItem();
			this.MenuItem89.Click += new System.EventHandler(this.MenuItem89_Click);
			this.MenuItem54 = new System.Windows.Forms.MenuItem();
			this.MenuItem54.Click += new System.EventHandler(this.MenuItem54_Click);
			this.MenuItem90 = new System.Windows.Forms.MenuItem();
			this.MenuItem91 = new System.Windows.Forms.MenuItem();
			this.MenuItem91.Click += new System.EventHandler(this.MenuItem91_Click);
			this.MenuItem56 = new System.Windows.Forms.MenuItem();
			this.MenuItem78 = new System.Windows.Forms.MenuItem();
			this.MenuItem78.Click += new System.EventHandler(this.MenuItem78_Click);
			this.MenuItem55 = new System.Windows.Forms.MenuItem();
			this.MenuItem55.Click += new System.EventHandler(this.MenuItem55_Click);
			this.MenuItem39 = new System.Windows.Forms.MenuItem();
			this.MenuItem76 = new System.Windows.Forms.MenuItem();
			this.MenuItem76.Click += new System.EventHandler(this.MenuItem76_Click);
			this.MenuItem40 = new System.Windows.Forms.MenuItem();
			this.MenuItem40.Click += new System.EventHandler(this.MenuItem40_Click);
			this.MenuItem41 = new System.Windows.Forms.MenuItem();
			this.MenuItem41.Click += new System.EventHandler(this.MenuItem41_Click);
			this.MenuItem140 = new System.Windows.Forms.MenuItem();
			this.MenuItem140.Click += new System.EventHandler(this.MenuItem140_Click);
			this.MenuItem42 = new System.Windows.Forms.MenuItem();
			this.MenuItem63 = new System.Windows.Forms.MenuItem();
			this.MenuItem63.Click += new System.EventHandler(this.MenuItem63_Click);
			this.MenuItem70 = new System.Windows.Forms.MenuItem();
			this.MenuItem71 = new System.Windows.Forms.MenuItem();
			this.MenuItem71.Click += new System.EventHandler(this.MenuItem71_Click);
			this.mnuEdit = new System.Windows.Forms.MenuItem();
			this.mnuEdit.Select += new System.EventHandler(this.mnuEdit_Select);
			this.mnuECut = new System.Windows.Forms.MenuItem();
			this.mnuECut.Click += new System.EventHandler(this.mnuECut_Click);
			this.mnuECopy = new System.Windows.Forms.MenuItem();
			this.mnuECopy.Click += new System.EventHandler(this.mnuECopy_Click);
			this.mnuEPaste = new System.Windows.Forms.MenuItem();
			this.mnuEPaste.Click += new System.EventHandler(this.mnuEPaste_Click);
			this.mnuSecurity = new System.Windows.Forms.MenuItem();
			this.mnuSPermission = new System.Windows.Forms.MenuItem();
			this.mnuSPermission.Click += new System.EventHandler(this.mnuSPermission_Click);
			this.mnuSRoles = new System.Windows.Forms.MenuItem();
			this.mnuSRoles.Click += new System.EventHandler(this.mnuSRoles_Click);
			this.mnuSUserCategory = new System.Windows.Forms.MenuItem();
			this.mnuSUserCategory.Click += new System.EventHandler(this.mnuSUserCategory_Click);
			this.mnuSUsers = new System.Windows.Forms.MenuItem();
			this.mnuSUsers.Click += new System.EventHandler(this.mnuSUsers_Click);
			this.mnuSSep1 = new System.Windows.Forms.MenuItem();
			this.mnuSUsersToRoles = new System.Windows.Forms.MenuItem();
			this.mnuSUsersToRoles.Click += new System.EventHandler(this.mnuSUsersToRoles_Click);
			this.mnuSRolesToPermissions = new System.Windows.Forms.MenuItem();
			this.mnuSRolesToPermissions.Click += new System.EventHandler(this.mnuSRolesToPermissions_Click);
			this.mnuSSep2 = new System.Windows.Forms.MenuItem();
			this.mnuSSecControls = new System.Windows.Forms.MenuItem();
			this.mnuSSecControls.Click += new System.EventHandler(this.mnuSSecControls_Click);
			this.mnuSPwdChange = new System.Windows.Forms.MenuItem();
			this.mnuSPwdChange.Click += new System.EventHandler(this.mnuSPwdChange_Click);
			this.MenuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuMWinFormMaint = new System.Windows.Forms.MenuItem();
			this.mnuMWinFormMaint.Click += new System.EventHandler(this.mnuMWinFormMaint_Click);
			this.mnuLookups = new System.Windows.Forms.MenuItem();
			this.mnuLException = new System.Windows.Forms.MenuItem();
			this.mnuLException.Click += new System.EventHandler(this.mnuLException_Click);
			this.mnuLUserTrack = new System.Windows.Forms.MenuItem();
			this.mnuLUserTrack.Click += new System.EventHandler(this.mnuLUserTrack_Click);
			this.mnuLUserLogin = new System.Windows.Forms.MenuItem();
			this.mnuLUserLogin.Click += new System.EventHandler(this.mnuLUserLogin_Click);
			this.mnuWindow = new System.Windows.Forms.MenuItem();
			this.MenuItem82 = new System.Windows.Forms.MenuItem();
			this.MenuItem82.Click += new System.EventHandler(this.MenuItem82_Click);
			this.MenuItem81 = new System.Windows.Forms.MenuItem();
			this.MenuItem81.Click += new System.EventHandler(this.MenuItem81_Click);
			this.MenuItem79 = new System.Windows.Forms.MenuItem();
			this.MenuItem79.Click += new System.EventHandler(this.MenuItem79_Click);
			this.MenuItem80 = new System.Windows.Forms.MenuItem();
			this.mnuWCloseAll = new System.Windows.Forms.MenuItem();
			this.mnuWCloseAll.Click += new System.EventHandler(this.mnuWCloseAll_Click);
			this.MenuItem154 = new System.Windows.Forms.MenuItem();
			this.MenuItem154.Click += new System.EventHandler(this.MenuItem154_Click);
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.mnuHFramework = new System.Windows.Forms.MenuItem();
			this.mnuHFramework.Click += new System.EventHandler(this.mnuHFramework_Click);
			this.mnuHAbout = new System.Windows.Forms.MenuItem();
			this.mnuHAbout.Click += new System.EventHandler(this.mnuHAbout_Click);
			this.MenuItem164 = new System.Windows.Forms.MenuItem();
			this.MenuItem171 = new System.Windows.Forms.MenuItem();
			this.MenuItem171.Click += new System.EventHandler(this.MenuItem171_Click);
			this.SuspendLayout();
			//
			//mnuMain
			//
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuFile, this.MenuItem24, this.MenuItem16, this.MenuItem33, this.MenuItem13, this.mnuEdit, this.mnuSecurity, this.MenuItem1, this.mnuLookups, this.MenuItem171, this.mnuWindow, this.mnuHelp});
			//
			//mnuFile
			//
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuNewItems, this.mnuItemGrid, this.MenuItem166, this.MenuItem167, this.MenuItem10, this.mnuPOS, this.MenuItem151, this.MenuItem152, this.MenuItem14, this.mnuManualInv, this.MenuItem23, this.MenuItem19, this.MenuItem20, this.MenuItem95, this.MenuItem100, this.MenuItem158, this.MenuItem159, this.MenuItem145, this.MenuItem160, this.MenuItem161, this.MenuItem162, this.MenuItem163, this.mnuFSignOut, this.mnuFExit});
			this.mnuFile.Text = "&File";
			//
			//mnuNewItems
			//
			this.mnuNewItems.Index = 0;
			this.mnuNewItems.Text = "New Items Entry Form";
			//
			//mnuItemGrid
			//
			this.mnuItemGrid.Index = 1;
			this.mnuItemGrid.Text = "Items Grid View";
			//
			//MenuItem166
			//
			this.MenuItem166.Index = 2;
			this.MenuItem166.Text = "New Item Barcode Form";
			//
			//MenuItem167
			//
			this.MenuItem167.Index = 3;
			this.MenuItem167.Text = "Item Barcode Grid View";
			//
			//MenuItem10
			//
			this.MenuItem10.Index = 4;
			this.MenuItem10.Text = "-";
			//
			//mnuPOS
			//
			this.mnuPOS.Index = 5;
			this.mnuPOS.Text = "POS";
			//
			//MenuItem151
			//
			this.MenuItem151.Index = 6;
			this.MenuItem151.Text = "Cashier Reading Ref. Nos.";
			//
			//MenuItem152
			//
			this.MenuItem152.Index = 7;
			this.MenuItem152.Text = "Print Cashier Reading";
			//
			//MenuItem14
			//
			this.MenuItem14.Index = 8;
			this.MenuItem14.Text = "-";
			//
			//mnuManualInv
			//
			this.mnuManualInv.Index = 9;
			this.mnuManualInv.Text = "Manual Inventory Entry Form";
			//
			//MenuItem23
			//
			this.MenuItem23.Index = 10;
			this.MenuItem23.Text = "-";
			//
			//MenuItem19
			//
			this.MenuItem19.Index = 11;
			this.MenuItem19.Text = "Return Items Form";
			//
			//MenuItem20
			//
			this.MenuItem20.Index = 12;
			this.MenuItem20.Text = "-";
			//
			//MenuItem95
			//
			this.MenuItem95.Index = 13;
			this.MenuItem95.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem155, this.MenuItem156, this.MenuItem96, this.MenuItem97, this.MenuItem98, this.MenuItem99});
			this.MenuItem95.Text = "Employees";
			//
			//MenuItem155
			//
			this.MenuItem155.Index = 0;
			this.MenuItem155.Text = "Employee Add/Edit/Delete";
			//
			//MenuItem156
			//
			this.MenuItem156.Index = 1;
			this.MenuItem156.Text = "-";
			//
			//MenuItem96
			//
			this.MenuItem96.Index = 2;
			this.MenuItem96.Text = "Time In";
			//
			//MenuItem97
			//
			this.MenuItem97.Index = 3;
			this.MenuItem97.Text = "Break";
			//
			//MenuItem98
			//
			this.MenuItem98.Index = 4;
			this.MenuItem98.Text = "Time In after Break";
			//
			//MenuItem99
			//
			this.MenuItem99.Index = 5;
			this.MenuItem99.Text = "Time Out";
			//
			//MenuItem100
			//
			this.MenuItem100.Index = 14;
			this.MenuItem100.Text = "-";
			//
			//MenuItem158
			//
			this.MenuItem158.Index = 15;
			this.MenuItem158.Text = "Supplier";
			//
			//MenuItem159
			//
			this.MenuItem159.Index = 16;
			this.MenuItem159.Text = "-";
			//
			//MenuItem145
			//
			this.MenuItem145.Index = 17;
			this.MenuItem145.Text = "Next &Counter";
			//
			//MenuItem160
			//
			this.MenuItem160.Index = 18;
			this.MenuItem160.Text = "-";
			//
			//MenuItem161
			//
			this.MenuItem161.Index = 19;
			this.MenuItem161.Text = "&Backup";
			//
			//MenuItem162
			//
			this.MenuItem162.Index = 20;
			this.MenuItem162.Text = "&Restore";
			//
			//MenuItem163
			//
			this.MenuItem163.Index = 21;
			this.MenuItem163.Text = "-";
			//
			//mnuFSignOut
			//
			this.mnuFSignOut.Index = 22;
			this.mnuFSignOut.Text = "Sign &Out";
			//
			//mnuFExit
			//
			this.mnuFExit.Index = 23;
			this.mnuFExit.Text = "E&xit";
			//
			//MenuItem24
			//
			this.MenuItem24.Index = 1;
			this.MenuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem25, this.MenuItem26, this.MenuItem27, this.MenuItem28, this.MenuItem22, this.MenuItem11, this.MenuItem29, this.MenuItem30, this.MenuItem64, this.MenuItem58, this.MenuItem31, this.MenuItem116, this.MenuItem117, this.MenuItem118, this.MenuItem115, this.MenuItem149, this.MenuItem150});
			this.MenuItem24.Text = "Transaction Forms";
			//
			//MenuItem25
			//
			this.MenuItem25.Index = 0;
			this.MenuItem25.Text = "Delivery Entry Form";
			//
			//MenuItem26
			//
			this.MenuItem26.Index = 1;
			this.MenuItem26.Text = "-";
			//
			//MenuItem27
			//
			this.MenuItem27.Index = 2;
			this.MenuItem27.Text = "Invoice Payment Form";
			//
			//MenuItem28
			//
			this.MenuItem28.Index = 3;
			this.MenuItem28.Text = "-";
			//
			//MenuItem22
			//
			this.MenuItem22.Index = 4;
			this.MenuItem22.Text = "Purchase Order Form";
			//
			//MenuItem11
			//
			this.MenuItem11.Index = 5;
			this.MenuItem11.Text = "-";
			//
			//MenuItem29
			//
			this.MenuItem29.Index = 6;
			this.MenuItem29.Text = "Transfer Stocks Form";
			//
			//MenuItem30
			//
			this.MenuItem30.Index = 7;
			this.MenuItem30.Text = "-";
			//
			//MenuItem64
			//
			this.MenuItem64.Index = 8;
			this.MenuItem64.Text = "Receive Stocks Form";
			//
			//MenuItem58
			//
			this.MenuItem58.Index = 9;
			this.MenuItem58.Text = "-";
			//
			//MenuItem31
			//
			this.MenuItem31.Index = 10;
			this.MenuItem31.Text = "BO Form";
			//
			//MenuItem116
			//
			this.MenuItem116.Index = 11;
			this.MenuItem116.Text = "-";
			//
			//MenuItem117
			//
			this.MenuItem117.Index = 12;
			this.MenuItem117.Text = "Convert Items to Pcs";
			this.MenuItem117.Visible = false;
			//
			//MenuItem118
			//
			this.MenuItem118.Index = 13;
			this.MenuItem118.Text = "-";
			//
			//MenuItem115
			//
			this.MenuItem115.Index = 14;
			this.MenuItem115.Text = "Expenses";
			//
			//MenuItem149
			//
			this.MenuItem149.Index = 15;
			this.MenuItem149.Text = "-";
			//
			//MenuItem150
			//
			this.MenuItem150.Index = 16;
			this.MenuItem150.Text = "Re-Print Cashier Reading";
			//
			//MenuItem16
			//
			this.MenuItem16.Index = 2;
			this.MenuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem168, this.mnuAmPm, this.MenuItem18, this.MenuItem92, this.MenuItem38, this.mnuBelowMin, this.mnuAboveMax, this.MenuItem48, this.MenuItem21, this.MenuItem111, this.MenuItem2, this.MenuItem165, this.MenuItem7, this.MenuItem73, this.MenuItem5, this.MenuItem4, this.MenuItem72, this.MenuItem8, this.MenuItem12, this.MenuItem3, this.MenuItem47, this.MenuItem57, this.MenuItem60, this.MenuItem133, this.MenuItem62, this.MenuItem67, this.MenuItem94, this.MenuItem93, this.MenuItem101, this.MenuItem102, this.MenuItem135, this.MenuItem134});
			this.MenuItem16.Text = "&Reports";
			//
			//MenuItem168
			//
			this.MenuItem168.Index = 0;
			this.MenuItem168.Text = "Summary Report";
			//
			//mnuAmPm
			//
			this.mnuAmPm.Index = 1;
			this.mnuAmPm.Text = "Sales Today(AM-PM)";
			//
			//MenuItem18
			//
			this.MenuItem18.Index = 2;
			this.MenuItem18.Text = "-";
			//
			//MenuItem92
			//
			this.MenuItem92.Index = 3;
			this.MenuItem92.Text = "Items on Stock";
			//
			//MenuItem38
			//
			this.MenuItem38.Index = 4;
			this.MenuItem38.Text = "Out of Stock Items";
			//
			//mnuBelowMin
			//
			this.mnuBelowMin.Index = 5;
			this.mnuBelowMin.Text = "Stocks Below Minimum";
			//
			//mnuAboveMax
			//
			this.mnuAboveMax.Index = 6;
			this.mnuAboveMax.Text = "Stocks Above Maximum";
			//
			//MenuItem48
			//
			this.MenuItem48.Index = 7;
			this.MenuItem48.Text = "Item Ledger";
			//
			//MenuItem21
			//
			this.MenuItem21.Index = 8;
			this.MenuItem21.Text = "-";
			//
			//MenuItem111
			//
			this.MenuItem111.Index = 9;
			this.MenuItem111.Text = "Deliveries per Item";
			//
			//MenuItem2
			//
			this.MenuItem2.Index = 10;
			this.MenuItem2.Text = "Deliveries per Supplier";
			//
			//MenuItem165
			//
			this.MenuItem165.Index = 11;
			this.MenuItem165.Text = "Expiration Dates";
			//
			//MenuItem7
			//
			this.MenuItem7.Index = 12;
			this.MenuItem7.Text = "-";
			//
			//MenuItem73
			//
			this.MenuItem73.Index = 13;
			this.MenuItem73.Text = "Balance to Suppliers";
			//
			//MenuItem5
			//
			this.MenuItem5.Index = 14;
			this.MenuItem5.Text = "-";
			//
			//MenuItem4
			//
			this.MenuItem4.Index = 15;
			this.MenuItem4.Text = "Payments to Suppliers";
			//
			//MenuItem72
			//
			this.MenuItem72.Index = 16;
			this.MenuItem72.Text = "-";
			//
			//MenuItem8
			//
			this.MenuItem8.Index = 17;
			this.MenuItem8.Text = "Transferred Stocks";
			//
			//MenuItem12
			//
			this.MenuItem12.Index = 18;
			this.MenuItem12.Text = "-";
			//
			//MenuItem3
			//
			this.MenuItem3.Index = 19;
			this.MenuItem3.Text = "Items Returned to Suppliers";
			//
			//MenuItem47
			//
			this.MenuItem47.Index = 20;
			this.MenuItem47.Text = "-";
			//
			//MenuItem57
			//
			this.MenuItem57.Index = 21;
			this.MenuItem57.Text = "Customers with Balance";
			//
			//MenuItem60
			//
			this.MenuItem60.Index = 22;
			this.MenuItem60.Text = "Credits Grouped by Customer(View1)";
			this.MenuItem60.Visible = false;
			//
			//MenuItem133
			//
			this.MenuItem133.Index = 23;
			this.MenuItem133.Text = "Credits Grouped by Customer(View2)";
			this.MenuItem133.Visible = false;
			//
			//MenuItem62
			//
			this.MenuItem62.Index = 24;
			this.MenuItem62.Text = "Customer Payments(Grid)";
			//
			//MenuItem67
			//
			this.MenuItem67.Index = 25;
			this.MenuItem67.Text = "Customer Payments(Print)";
			//
			//MenuItem94
			//
			this.MenuItem94.Index = 26;
			this.MenuItem94.Text = "-";
			//
			//MenuItem93
			//
			this.MenuItem93.Index = 27;
			this.MenuItem93.Text = "Manual Inventory Difference Report";
			//
			//MenuItem101
			//
			this.MenuItem101.Index = 28;
			this.MenuItem101.Text = "-";
			//
			//MenuItem102
			//
			this.MenuItem102.Index = 29;
			this.MenuItem102.Text = "Employee Time In and Time Out";
			//
			//MenuItem135
			//
			this.MenuItem135.Index = 30;
			this.MenuItem135.Text = "-";
			//
			//MenuItem134
			//
			this.MenuItem134.Index = 31;
			this.MenuItem134.Text = "Cashier Reading Re-Print";
			//
			//MenuItem33
			//
			this.MenuItem33.Index = 3;
			this.MenuItem33.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem169, this.MenuItem144, this.MenuItem170, this.MenuItem132, this.MenuItem51, this.MenuItem34, this.MenuItem9, this.MenuItem53, this.MenuItem69, this.MenuItem143, this.MenuItem112, this.MenuItem17, this.MenuItem68, this.MenuItem52, this.MenuItem36, this.MenuItem110, this.MenuItem104, this.MenuItem141, this.MenuItem142, this.MenuItem153, this.MenuItem139, this.MenuItem138, this.MenuItem35, this.MenuItem109, this.MenuItem45, this.MenuItem37, this.MenuItem46, this.MenuItem6, this.MenuItem61, this.MenuItem44, this.MenuItem43, this.MenuItem65, this.MenuItem66, this.MenuItem77, this.MenuItem103, this.MenuItem108, this.MenuItem106, this.MenuItem105, this.MenuItem107, this.MenuItem119, this.MenuItem120, this.MenuItem121, this.MenuItem122, this.MenuItem147, this.MenuItem124, this.MenuItem129, this.MenuItem137, this.MenuItem136, this.MenuItem157});
			this.MenuItem33.Text = "Grid Reports";
			//
			//MenuItem169
			//
			this.MenuItem169.Index = 0;
			this.MenuItem169.Text = "Summary Grid View";
			//
			//MenuItem144
			//
			this.MenuItem144.Index = 1;
			this.MenuItem144.Text = "Past Sales per Reference No.";
			//
			//MenuItem170
			//
			this.MenuItem170.Index = 2;
			this.MenuItem170.Text = "Sales with Date Parameters";
			//
			//MenuItem132
			//
			this.MenuItem132.Index = 3;
			this.MenuItem132.Text = "Sales History";
			//
			//MenuItem51
			//
			this.MenuItem51.Index = 4;
			this.MenuItem51.Text = "Items Sold Grouped by Item";
			//
			//MenuItem34
			//
			this.MenuItem34.Index = 5;
			this.MenuItem34.Text = "Items Sold Grouped by Date";
			//
			//MenuItem9
			//
			this.MenuItem9.Index = 6;
			this.MenuItem9.Text = "Sales With Profit Figure View1";
			this.MenuItem9.Visible = false;
			//
			//MenuItem53
			//
			this.MenuItem53.Index = 7;
			this.MenuItem53.Text = "Sales With Profit Figure View2";
			this.MenuItem53.Visible = false;
			//
			//MenuItem69
			//
			this.MenuItem69.Index = 8;
			this.MenuItem69.Text = "-";
			//
			//MenuItem143
			//
			this.MenuItem143.Index = 9;
			this.MenuItem143.Text = "Sales Today per Reference No.";
			//
			//MenuItem112
			//
			this.MenuItem112.Index = 10;
			this.MenuItem112.Text = "Sales Today";
			//
			//MenuItem17
			//
			this.MenuItem17.Index = 11;
			this.MenuItem17.Text = "-";
			//
			//MenuItem68
			//
			this.MenuItem68.Index = 12;
			this.MenuItem68.Text = "Sales Today by Cashier";
			//
			//MenuItem52
			//
			this.MenuItem52.Index = 13;
			this.MenuItem52.Text = "-";
			//
			//MenuItem36
			//
			this.MenuItem36.Index = 14;
			this.MenuItem36.Text = "Deliveries per Supplier";
			//
			//MenuItem110
			//
			this.MenuItem110.Index = 15;
			this.MenuItem110.Text = "Deliveries per Item";
			//
			//MenuItem104
			//
			this.MenuItem104.Index = 16;
			this.MenuItem104.Text = "Items Buying Price History";
			this.MenuItem104.Visible = false;
			//
			//MenuItem141
			//
			this.MenuItem141.Index = 17;
			this.MenuItem141.Text = "Payments to Suppliers View1";
			//
			//MenuItem142
			//
			this.MenuItem142.Index = 18;
			this.MenuItem142.Text = "Payments to Suppliers View2";
			//
			//MenuItem153
			//
			this.MenuItem153.Index = 19;
			this.MenuItem153.Text = "Not Cleared PDC";
			//
			//MenuItem139
			//
			this.MenuItem139.Index = 20;
			this.MenuItem139.Text = "-";
			//
			//MenuItem138
			//
			this.MenuItem138.Index = 21;
			this.MenuItem138.Text = "Balance to Suppliers";
			//
			//MenuItem35
			//
			this.MenuItem35.Index = 22;
			this.MenuItem35.Text = "-";
			//
			//MenuItem109
			//
			this.MenuItem109.Index = 23;
			this.MenuItem109.Text = "Transferred Stocks View1";
			//
			//MenuItem45
			//
			this.MenuItem45.Index = 24;
			this.MenuItem45.Text = "Transferred Stocks View2";
			//
			//MenuItem37
			//
			this.MenuItem37.Index = 25;
			this.MenuItem37.Text = "-";
			this.MenuItem37.Visible = false;
			//
			//MenuItem46
			//
			this.MenuItem46.Index = 26;
			this.MenuItem46.Text = "Items Transactions Summary View1";
			this.MenuItem46.Visible = false;
			//
			//MenuItem6
			//
			this.MenuItem6.Index = 27;
			this.MenuItem6.Text = "Items Transactions Summary View2";
			this.MenuItem6.Visible = false;
			//
			//MenuItem61
			//
			this.MenuItem61.Index = 28;
			this.MenuItem61.Text = "-";
			//
			//MenuItem44
			//
			this.MenuItem44.Index = 29;
			this.MenuItem44.Text = "Inventory w/ Cost/Retail Amount";
			//
			//MenuItem43
			//
			this.MenuItem43.Index = 30;
			this.MenuItem43.Text = "Inventory w/ Cost/Retail Total";
			//
			//MenuItem65
			//
			this.MenuItem65.Index = 31;
			this.MenuItem65.Text = "-";
			//
			//MenuItem66
			//
			this.MenuItem66.Index = 32;
			this.MenuItem66.Text = "Manual Inventory";
			//
			//MenuItem77
			//
			this.MenuItem77.Index = 33;
			this.MenuItem77.Text = "-";
			//
			//MenuItem103
			//
			this.MenuItem103.Index = 34;
			this.MenuItem103.Text = "Received Stocks View1";
			//
			//MenuItem108
			//
			this.MenuItem108.Index = 35;
			this.MenuItem108.Text = "Received Stocks View2";
			//
			//MenuItem106
			//
			this.MenuItem106.Index = 36;
			this.MenuItem106.Text = "-";
			//
			//MenuItem105
			//
			this.MenuItem105.Index = 37;
			this.MenuItem105.Text = "Back Orders View1";
			//
			//MenuItem107
			//
			this.MenuItem107.Index = 38;
			this.MenuItem107.Text = "Back Orders View2";
			//
			//MenuItem119
			//
			this.MenuItem119.Index = 39;
			this.MenuItem119.Text = "-";
			//
			//MenuItem120
			//
			this.MenuItem120.Index = 40;
			this.MenuItem120.Text = "Items Converted to Pcs";
			this.MenuItem120.Visible = false;
			//
			//MenuItem121
			//
			this.MenuItem121.Index = 41;
			this.MenuItem121.Text = "-";
			//
			//MenuItem122
			//
			this.MenuItem122.Index = 42;
			this.MenuItem122.Text = "Expenses View1";
			//
			//MenuItem147
			//
			this.MenuItem147.Index = 43;
			this.MenuItem147.Text = "Expenses View2";
			//
			//MenuItem124
			//
			this.MenuItem124.Index = 44;
			this.MenuItem124.Text = "-";
			//
			//MenuItem129
			//
			this.MenuItem129.Index = 45;
			this.MenuItem129.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem123, this.MenuItem125, this.MenuItem126, this.MenuItem128, this.MenuItem130, this.MenuItem131, this.MenuItem127, this.MenuItem148});
			this.MenuItem129.Text = "Other Grid Views";
			//
			//MenuItem123
			//
			this.MenuItem123.Index = 0;
			this.MenuItem123.Text = "Cash Taken from Cashiers";
			//
			//MenuItem125
			//
			this.MenuItem125.Index = 1;
			this.MenuItem125.Text = "Additonal Cash Received by Cashiers";
			//
			//MenuItem126
			//
			this.MenuItem126.Index = 2;
			this.MenuItem126.Text = "Discounts";
			//
			//MenuItem128
			//
			this.MenuItem128.Index = 3;
			this.MenuItem128.Text = "Void Items";
			//
			//MenuItem130
			//
			this.MenuItem130.Index = 4;
			this.MenuItem130.Text = "Refunds";
			//
			//MenuItem131
			//
			this.MenuItem131.Index = 5;
			this.MenuItem131.Text = "Changed Price";
			//
			//MenuItem127
			//
			this.MenuItem127.Index = 6;
			this.MenuItem127.Text = "Cheque Payments";
			//
			//MenuItem148
			//
			this.MenuItem148.Index = 7;
			this.MenuItem148.Text = "Cheque Payment Sales";
			//
			//MenuItem137
			//
			this.MenuItem137.Index = 46;
			this.MenuItem137.Text = "-";
			//
			//MenuItem136
			//
			this.MenuItem136.Index = 47;
			this.MenuItem136.Text = "Cashier Reading View";
			//
			//MenuItem157
			//
			this.MenuItem157.Index = 48;
			this.MenuItem157.Text = "Incentives Report";
			//
			//MenuItem13
			//
			this.MenuItem13.Index = 4;
			this.MenuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem146, this.MenuItem87, this.MenuItem84, this.MenuItem74, this.MenuItem85, this.MenuItem86, this.MenuItem75, this.MenuItem32, this.MenuItem59, this.MenuItem15, this.MenuItem114, this.MenuItem49, this.MenuItem113, this.MenuItem50, this.MenuItem83, this.MenuItem88, this.MenuItem89, this.MenuItem54, this.MenuItem90, this.MenuItem91, this.MenuItem56, this.MenuItem78, this.MenuItem55, this.MenuItem39, this.MenuItem76, this.MenuItem40, this.MenuItem41, this.MenuItem140, this.MenuItem42, this.MenuItem63, this.MenuItem70, this.MenuItem71});
			this.MenuItem13.Text = "Dashboard";
			//
			//MenuItem146
			//
			this.MenuItem146.Index = 0;
			this.MenuItem146.Text = "Overview of Business Activity";
			this.MenuItem146.Visible = false;
			//
			//MenuItem87
			//
			this.MenuItem87.Index = 1;
			this.MenuItem87.Text = "Items Sold Daily (Highest to Lowest)";
			this.MenuItem87.Visible = false;
			//
			//MenuItem84
			//
			this.MenuItem84.Index = 2;
			this.MenuItem84.Text = "Items Sold Weekly (Highest to Lowest)";
			//
			//MenuItem74
			//
			this.MenuItem74.Index = 3;
			this.MenuItem74.Text = "Items Sold Monthly (Highest to Lowest)";
			//
			//MenuItem85
			//
			this.MenuItem85.Index = 4;
			this.MenuItem85.Text = "Items Sold Quarterly (Highest to Lowest)";
			//
			//MenuItem86
			//
			this.MenuItem86.Index = 5;
			this.MenuItem86.Text = "Items Sold Yearly (Highest to Lowest)";
			//
			//MenuItem75
			//
			this.MenuItem75.Index = 6;
			this.MenuItem75.Text = "-";
			//
			//MenuItem32
			//
			this.MenuItem32.Index = 7;
			this.MenuItem32.Text = "Sales by Date (Items Sold per Category)";
			this.MenuItem32.Visible = false;
			//
			//MenuItem59
			//
			this.MenuItem59.Index = 8;
			this.MenuItem59.Text = "Sales by Date (Amount Summary)";
			//
			//MenuItem15
			//
			this.MenuItem15.Index = 9;
			this.MenuItem15.Text = "Sales by Employee";
			//
			//MenuItem114
			//
			this.MenuItem114.Index = 10;
			this.MenuItem114.Text = "-";
			//
			//MenuItem49
			//
			this.MenuItem49.Index = 11;
			this.MenuItem49.Text = "Sales Today per Hour";
			this.MenuItem49.Visible = false;
			//
			//MenuItem113
			//
			this.MenuItem113.Index = 12;
			this.MenuItem113.Text = "-";
			//
			//MenuItem50
			//
			this.MenuItem50.Index = 13;
			this.MenuItem50.Text = "Past Sales Per Hour";
			this.MenuItem50.Visible = false;
			//
			//MenuItem83
			//
			this.MenuItem83.Index = 14;
			this.MenuItem83.Text = "-";
			//
			//MenuItem88
			//
			this.MenuItem88.Index = 15;
			this.MenuItem88.Text = "Sales Profit Daily";
			this.MenuItem88.Visible = false;
			//
			//MenuItem89
			//
			this.MenuItem89.Index = 16;
			this.MenuItem89.Text = "Sales Profit Weekly";
			this.MenuItem89.Visible = false;
			//
			//MenuItem54
			//
			this.MenuItem54.Index = 17;
			this.MenuItem54.Text = "Sales Profit Monthly";
			this.MenuItem54.Visible = false;
			//
			//MenuItem90
			//
			this.MenuItem90.Index = 18;
			this.MenuItem90.Text = "Sales Profit Quarterly";
			this.MenuItem90.Visible = false;
			//
			//MenuItem91
			//
			this.MenuItem91.Index = 19;
			this.MenuItem91.Text = "Sales Profit Annually";
			this.MenuItem91.Visible = false;
			//
			//MenuItem56
			//
			this.MenuItem56.Index = 20;
			this.MenuItem56.Text = "-";
			//
			//MenuItem78
			//
			this.MenuItem78.Index = 21;
			this.MenuItem78.Text = "Payments by Customers";
			//
			//MenuItem55
			//
			this.MenuItem55.Index = 22;
			this.MenuItem55.Text = "Credits by Customers";
			//
			//MenuItem39
			//
			this.MenuItem39.Index = 23;
			this.MenuItem39.Text = "-";
			//
			//MenuItem76
			//
			this.MenuItem76.Index = 24;
			this.MenuItem76.Text = "Highest-Lowest and Lowest-Highest Dlvrd Items";
			this.MenuItem76.Visible = false;
			//
			//MenuItem40
			//
			this.MenuItem40.Index = 25;
			this.MenuItem40.Text = "Delivery by Date(Amount Summary per Supplier)";
			//
			//MenuItem41
			//
			this.MenuItem41.Index = 26;
			this.MenuItem41.Text = "Delivery by Item(Items Delivered Summary)";
			//
			//MenuItem140
			//
			this.MenuItem140.Index = 27;
			this.MenuItem140.Text = "Payments to Suppliers";
			//
			//MenuItem42
			//
			this.MenuItem42.Index = 28;
			this.MenuItem42.Text = "-";
			//
			//MenuItem63
			//
			this.MenuItem63.Index = 29;
			this.MenuItem63.Text = "Transferred Items Summary";
			//
			//MenuItem70
			//
			this.MenuItem70.Index = 30;
			this.MenuItem70.Text = "-";
			//
			//MenuItem71
			//
			this.MenuItem71.Index = 31;
			this.MenuItem71.Text = "Best Customers";
			this.MenuItem71.Visible = false;
			//
			//mnuEdit
			//
			this.mnuEdit.Index = 5;
			this.mnuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuECut, this.mnuECopy, this.mnuEPaste});
			this.mnuEdit.Text = "&Edit";
			//
			//mnuECut
			//
			this.mnuECut.Index = 0;
			this.mnuECut.Text = "Cu&t";
			//
			//mnuECopy
			//
			this.mnuECopy.Index = 1;
			this.mnuECopy.Text = "&Copy";
			//
			//mnuEPaste
			//
			this.mnuEPaste.Index = 2;
			this.mnuEPaste.Text = "&Paste";
			//
			//mnuSecurity
			//
			this.mnuSecurity.Index = 6;
			this.mnuSecurity.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuSPermission, this.mnuSRoles, this.mnuSUserCategory, this.mnuSUsers, this.mnuSSep1, this.mnuSUsersToRoles, this.mnuSRolesToPermissions, this.mnuSSep2, this.mnuSSecControls, this.mnuSPwdChange});
			this.mnuSecurity.Text = "Security";
			//
			//mnuSPermission
			//
			this.mnuSPermission.Index = 0;
			this.mnuSPermission.Text = "Permission";
			//
			//mnuSRoles
			//
			this.mnuSRoles.Index = 1;
			this.mnuSRoles.Text = "Roles";
			//
			//mnuSUserCategory
			//
			this.mnuSUserCategory.Index = 2;
			this.mnuSUserCategory.Text = "User Category";
			//
			//mnuSUsers
			//
			this.mnuSUsers.Index = 3;
			this.mnuSUsers.Text = "Users";
			//
			//mnuSSep1
			//
			this.mnuSSep1.Index = 4;
			this.mnuSSep1.Text = "-";
			//
			//mnuSUsersToRoles
			//
			this.mnuSUsersToRoles.Index = 5;
			this.mnuSUsersToRoles.Text = "Map Users To Roles";
			//
			//mnuSRolesToPermissions
			//
			this.mnuSRolesToPermissions.Index = 6;
			this.mnuSRolesToPermissions.Text = "Map Roles To Permissions";
			//
			//mnuSSep2
			//
			this.mnuSSep2.Index = 7;
			this.mnuSSep2.Text = "-";
			//
			//mnuSSecControls
			//
			this.mnuSSecControls.Index = 8;
			this.mnuSSecControls.Text = "Security Controls";
			//
			//mnuSPwdChange
			//
			this.mnuSPwdChange.Index = 9;
			this.mnuSPwdChange.Text = "Change Password";
			//
			//MenuItem1
			//
			this.MenuItem1.Index = 7;
			this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuMWinFormMaint});
			this.MenuItem1.Text = "Maintenance";
			//
			//mnuMWinFormMaint
			//
			this.mnuMWinFormMaint.Index = 0;
			this.mnuMWinFormMaint.Text = "Win Form Creator Maint";
			//
			//mnuLookups
			//
			this.mnuLookups.Index = 8;
			this.mnuLookups.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuLException, this.mnuLUserTrack, this.mnuLUserLogin});
			this.mnuLookups.Text = "Lookups";
			//
			//mnuLException
			//
			this.mnuLException.Index = 0;
			this.mnuLException.Text = "Exceptions";
			//
			//mnuLUserTrack
			//
			this.mnuLUserTrack.Index = 1;
			this.mnuLUserTrack.Text = "User Tracking";
			//
			//mnuLUserLogin
			//
			this.mnuLUserLogin.Index = 2;
			this.mnuLUserLogin.Text = "User Logins";
			//
			//mnuWindow
			//
			this.mnuWindow.Index = 10;
			this.mnuWindow.MdiList = true;
			this.mnuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.MenuItem82, this.MenuItem81, this.MenuItem79, this.MenuItem80, this.mnuWCloseAll, this.MenuItem154});
			this.mnuWindow.Text = "&Window";
			//
			//MenuItem82
			//
			this.MenuItem82.Index = 0;
			this.MenuItem82.Text = "Tile Vertical";
			//
			//MenuItem81
			//
			this.MenuItem81.Index = 1;
			this.MenuItem81.Text = "Tile Horizontal";
			//
			//MenuItem79
			//
			this.MenuItem79.Index = 2;
			this.MenuItem79.Text = "Cascade Open Windows";
			//
			//MenuItem80
			//
			this.MenuItem80.Index = 3;
			this.MenuItem80.Text = "-";
			//
			//mnuWCloseAll
			//
			this.mnuWCloseAll.Index = 4;
			this.mnuWCloseAll.Text = "&Close All";
			//
			//MenuItem154
			//
			this.MenuItem154.Index = 5;
			this.MenuItem154.Text = "TestKellerman";
			this.MenuItem154.Visible = false;
			//
			//mnuHelp
			//
			this.mnuHelp.Index = 10;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {this.mnuHFramework, this.mnuHAbout, this.MenuItem164});
			this.mnuHelp.Text = "&Help";
			//
			//mnuHFramework
			//
			this.mnuHFramework.Index = 0;
			this.mnuHFramework.Text = "DOORS98 COMPUTERS PRODUCTS";
			//
			//mnuHAbout
			//
			this.mnuHAbout.Index = 1;
			this.mnuHAbout.Text = "&About...";
			//
			//MenuItem164
			//
			this.MenuItem164.Index = 2;
			this.MenuItem164.Text = "kellerman";
			//
			//MenuItem171
			//
			this.MenuItem171.Index = 9;
			this.MenuItem171.Text = "E&xit";
			//
			//frmMain
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(952, 434);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.IsMdiContainer = true;
			this.Menu = this.mnuMain;
			this.Name = "frmMain";
			this.Text = "Doors Computer Solutions-Sales and Inventory Monitoring System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
			
		}
		
#endregion
		
		// PDSA Forms Tracker tracks MDI Child Forms
		// so they can only be opened one time
		private PDSAFormsTracker mFormsTracker;
		
		private void PDSAFormBase_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				
			}
			
		}
		
		
		private void frmMain_Load(System.Object sender, System.EventArgs e)
		{
			
			bool boolPerform = false;
			
			
			//SkinHelper.InitSkinGallery(PopupMenu1)
			//SkinHelper.InitSkinPopupMenu(PopupMenu1)
			
			try
			{
				//* UnComment the following lines if you have:
				//*   - Moved all config settings to registry
				//*   - Are not using Encryption
				//PDSAAppConfig.OverrideAllConfigSettings = True
				//PDSAAppConfig.UseRegistry = True
				//PDSAAppConfig.RegistryConfigKey = "Software\ATest4"
				
				//* UnComment the following lines if you have:
				//*   - Moved all config settings to XML file
				//*   - Removed all settings from within the <PDSAAppConfig> element
				//*   - Are not using Encryption
				//PDSAAppConfig.OverrideAllConfigSettings = True
				//PDSAAppConfig.UseXMLFile = True
				//PDSAAppConfig.XMLConfigFile = "<Put Full Path Here>"
				
				//* Add the following line if you have encrypted all values
				//PDSAAppConfig.AllEncrypted = True
				
				//* If you are using encryption (Either all or just Connect Strings)
				//* Fill in the encryption type you have used:
				//*    - PDSA0, PDSA1, etc.
				//PDSAAppConfig.ConnectStringsEncryptionType = ""
				
				//* Add the following line if you stored your Encryption Keys in the Registry
				//PDSAAppConfig.EncKeyRegKey = "Software\ATest4Keys"
				
				//* Add the following line if you stored your Encryption Keys in an XML File.
				//* NOTE: You must use a real path, not a URL path here.
				//PDSAAppConfig.EncKeyXMLFile = ""
				
				// Load the settings into the PDSAAppConfig Class
				PDSAAppConfig.Init();
				PDSADataLayer.DBDateFormat = PDSAAppConfigBase.DBDateFormat;
				PDSADataLayer.DBLanguage = PDSAAppConfigBase.DBLanguage;
				
				// Reset Database Driver Type and Assembly Info
				PDSA.Common.PDSAAppConfigBase.ResetDatabaseDriver(System.Convert.ToString(PDSAAppConfig.ConnectString));
				
				boolPerform = true;
				
			}
			catch (Exception ex)
			{
				boolPerform = false;
				MessageBox.Show(ex.Message, "Error in PDSAAppConfig");
				
			}
			
			if (boolPerform)
			{
				try
				{
					//*********************************************************
					//* Load all Your Custom Values from WinAppConfig Section *
					//*********************************************************
					WinAppConfig.Init();
					
					boolPerform = true;
					
				}
				catch (Exception ex)
				{
					boolPerform = false;
					MessageBox.Show(ex.Message, "Error in PDSAAppConfig");
					
				}
			}
			
			if (!PDSAAppConfig.ConfigFound)
			{
				ApplicationException ex = default(ApplicationException);
				
				ex = new ApplicationException("WARNING! Configuration not found for AppName: " + PDSAAppConfig.AppName + ". Using Default Settings.");
				PDSAException.Publish(ex);
				
				MessageBox.Show("WARNING! Configuration not found for AppName: " + PDSAAppConfig.AppName + ". Using Default Settings.", "Config Not Found");
			}
			
			if (boolPerform)
			{
				// Create New Instance of Forms Tracker
				mFormsTracker = new PDSAFormsTracker();
				PDSAFormsTracker.FormsTracker = mFormsTracker;
				
				if (PDSASecurityLogin.LoginToApp())
				{
					// Initialize this Form's security
					SecurityInit();
					
					if (!PDSABaseSecurity.UserIsInRole("User"))
					{
						mnuECopy.Enabled = false;
					}
					
					// Check to see if controls need to be turned off on this form
					base.SecurityCheck();
					
				}
				else
				{
					this.Close();
				}
			}
			
			//The Code below is to check if the user logged in is Admin then continue the code
			//This is to check the stock levels of the Company
			try
			{
				vwLowStocksManager mgrlo = default(vwLowStocksManager);
				vwLowStocksCollection colsLoStock;
				mgrlo = new vwLowStocksManager();
				mgrlo.DataObject.WhereFilter = vwLowStocksData.WhereFilters.LoStock;
				colsLoStock = mgrlo.BuildCollection();
				if (mgrlo.DataObject.RowsAffected > 0)
				{
					MessageBox.Show("Warning! There are some stocks that are below or equal to Minimum Re-Order Level. Please print the report on Stocks Below Minimum");
				}
				
				vwHiStocksManager mgrhi = default(vwHiStocksManager);
				vwHiStocksCollection colsHiStock;
				mgrhi = new vwHiStocksManager();
				mgrhi.DataObject.WhereFilter = vwHiStocksData.WhereFilters.HiStock;
				colsHiStock = mgrhi.BuildCollection();
				if (mgrhi.DataObject.RowsAffected > 0)
				{
					MessageBox.Show("Warning! There are some stocks that are Above or equal to Maximum Re-Order Level. Please print the report on Stocks Above or Equal to Maximum Level");
				}
				
			}
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}
		
		private void SecurityInit()
		{
			// This method is for any custom security things you wish to do
			
			if (PDSAAppConfig.UseNTAuthentication == false && PDSAAppConfig.UsePDSASecurity)
			{
				// PDSA Security Only
				
			}
			else if (PDSAAppConfig.UseNTAuthentication && PDSAAppConfig.UsePDSASecurity)
			{
				// Windows Authentication / PDSA Security
				
				this.mnuSPwdChange.Visible = false;
				this.mnuFSignOut.Visible = false;
				
			}
			else if (PDSAAppConfig.UseNTAuthentication && PDSAAppConfig.UsePDSASecurity == false)
			{
				// Windows Authentication / NO PDSA Security
				
				// Turn off PDSA Security Menus
				this.mnuSecurity.Visible = false;
				this.mnuFSignOut.Visible = false;
				
			}
			else if (PDSAAppConfig.UseNTAuthentication == false && PDSAAppConfig.UsePDSASecurity == false)
			{
				// No Authentication
				
				this.mnuSecurity.Visible = false;
				this.mnuFSignOut.Visible = false;
				
			}
		}
		
#region Menus to call Forms
		private void mnuFExit_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void mnuWCloseAll_Click(System.Object sender, System.EventArgs e)
		{
			mFormsTracker.CloseAll();
		}
		
		private void mnuFSignOut_Click(System.Object sender, System.EventArgs e)
		{
			mFormsTracker.CloseAll();
			if (PDSAAppConfig.UsePDSASecurity)
			{
				if (!PDSASecurityLogin.LoginToApp())
				{
					this.Close();
				}
				else
				{
					base.SecurityCheck();
				}
			}
			else
			{
				this.Close();
			}
		}
		
		private void mnuMWinFormMaint_Click(System.Object sender, System.EventArgs e)
		{
			PDSAWinFormMaint frm = default(PDSAWinFormMaint);
			
			if (mFormsTracker.IsLoaded("PDSAWinFormMaint"))
			{
				mFormsTracker.ActivateForm("PDSAWinFormMaint");
			}
			else
			{
				frm = new PDSAWinFormMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSPermission_Click(System.Object sender, System.EventArgs e)
		{
			PDSAPermissionsMaint frm = default(PDSAPermissionsMaint);
			
			if (mFormsTracker.IsLoaded("PDSAPermissionsMaint"))
			{
				mFormsTracker.ActivateForm("PDSAPermissionsMaint");
			}
			else
			{
				frm = new PDSAPermissionsMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSRoles_Click(System.Object sender, System.EventArgs e)
		{
			PDSARolesMaint frm = default(PDSARolesMaint);
			
			if (mFormsTracker.IsLoaded("PDSARolesMaint"))
			{
				mFormsTracker.ActivateForm("PDSARolesMaint");
			}
			else
			{
				frm = new PDSARolesMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSPwdChange_Click(System.Object sender, System.EventArgs e)
		{
			PDSAChangePwd frm = default(PDSAChangePwd);
			
			if (mFormsTracker.IsLoaded("PDSAChangePwd"))
			{
				mFormsTracker.ActivateForm("PDSAChangePwd");
			}
			else
			{
				frm = new PDSAChangePwd();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		private void mnuSUserCategory_Click(object sender, System.EventArgs e)
		{
			PDSAUsersCategoryMaint frm = default(PDSAUsersCategoryMaint);
			
			if (mFormsTracker.IsLoaded("PDSAUsersCategoryMaint"))
			{
				mFormsTracker.ActivateForm("PDSAUsersCategoryMaint");
			}
			else
			{
				frm = new PDSAUsersCategoryMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSUsers_Click(System.Object sender, System.EventArgs e)
		{
			PDSAUsersMaint frm = default(PDSAUsersMaint);
			
			if (mFormsTracker.IsLoaded("PDSAUsersMaint"))
			{
				mFormsTracker.ActivateForm("PDSAUsersMaint");
			}
			else
			{
				frm = new PDSAUsersMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSUsersToRoles_Click(System.Object sender, System.EventArgs e)
		{
			PDSAUsersRolesMaint frm = default(PDSAUsersRolesMaint);
			
			if (mFormsTracker.IsLoaded("PDSAUsersRolesMaint"))
			{
				mFormsTracker.ActivateForm("PDSAUsersRolesMaint");
			}
			else
			{
				frm = new PDSAUsersRolesMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSRolesToPermissions_Click(System.Object sender, System.EventArgs e)
		{
			PDSARolesPermissionsMaint frm = default(PDSARolesPermissionsMaint);
			
			if (mFormsTracker.IsLoaded("PDSARolesPermissionsMaint"))
			{
				mFormsTracker.ActivateForm("PDSARolesPermissionsMaint");
			}
			else
			{
				frm = new PDSARolesPermissionsMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuLException_Click(System.Object sender, System.EventArgs e)
		{
			PDSAExceptionLookup frm = default(PDSAExceptionLookup);
			
			if (mFormsTracker.IsLoaded("PDSAExceptionLookup"))
			{
				mFormsTracker.ActivateForm("PDSAExceptionLookup");
			}
			else
			{
				frm = new PDSAExceptionLookup();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuLUserTrack_Click(System.Object sender, System.EventArgs e)
		{
			PDSAUserTrackLookup frm = default(PDSAUserTrackLookup);
			
			if (mFormsTracker.IsLoaded("PDSAUserTrackLookup"))
			{
				mFormsTracker.ActivateForm("PDSAUserTrackLookup");
			}
			else
			{
				frm = new PDSAUserTrackLookup();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuWFCreator_Click(System.Object sender, System.EventArgs e)
		{
			PDSAWinFormMaint frm = default(PDSAWinFormMaint);
			
			if (mFormsTracker.IsLoaded("PDSAWinFormMaint"))
			{
				mFormsTracker.ActivateForm("PDSAWinFormMaint");
			}
			else
			{
				frm = new PDSAWinFormMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuWFWinFormControls_Click(System.Object sender, System.EventArgs e)
		{
			PDSAWinFormControlsMaint frm = default(PDSAWinFormControlsMaint);
			
			if (mFormsTracker.IsLoaded("PDSAWinFormControlsMaint"))
			{
				mFormsTracker.ActivateForm("PDSAWinFormControlsMaint");
			}
			else
			{
				frm = new PDSAWinFormControlsMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuSSecControls_Click(System.Object sender, System.EventArgs e)
		{
			PDSASecurityControlsMaint frm = default(PDSASecurityControlsMaint);
			
			if (mFormsTracker.IsLoaded("PDSASecurityControlsMaint"))
			{
				mFormsTracker.ActivateForm("PDSASecurityControlsMaint");
			}
			else
			{
				frm = new PDSASecurityControlsMaint();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
		
		private void mnuLUserLogin_Click(System.Object sender, System.EventArgs e)
		{
			PDSAUserLoginLookup frm = default(PDSAUserLoginLookup);
			
			if (mFormsTracker.IsLoaded("PDSAUserLoginLookup"))
			{
				mFormsTracker.ActivateForm("PDSAUserLoginLookup");
			}
			else
			{
				frm = new PDSAUserLoginLookup();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				
				frm.Show();
			}
		}
#endregion
		
#region Cut/Copy/Paste Code
		private void mnuECut_Click(System.Object sender, System.EventArgs e)
		{
			Control ctlSelected = default(Control);
			
			try
			{
				ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
				if (!(ctlSelected == null))
				{
					PDSAForms.CutSelection(ref ctlSelected);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text + ".mnuECut_Click");
				
			}
		}
		
		private void mnuECopy_Click(System.Object sender, System.EventArgs e)
		{
			Control ctlSelected = default(Control);
			
			ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
			if (!(ctlSelected == null))
			{
				PDSAForms.CopySelection(ref ctlSelected);
			}
		}
		
		private void mnuEPaste_Click(System.Object sender, System.EventArgs e)
		{
			Control ctlSelected = default(Control);
			
			try
			{
				ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
				if (!(ctlSelected == null))
				{
					PDSAForms.PasteSelection(ref ctlSelected);
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text + ".mnuEPaste_Click");
				
			}
		}
		
		private void mnuEdit_Select(object sender, System.EventArgs e)
		{
			if (PDSAForms.GetActiveMDIChildControl(this) == null)
			{
				mnuECopy.Enabled = ControlSetEnabledProperty("mnuECopy", false);
				mnuECut.Enabled = ControlSetEnabledProperty("mnuECut", false);
				mnuEPaste.Enabled = ControlSetEnabledProperty("mnuEPaste", false);
			}
			else
			{
				mnuECopy.Enabled = ControlSetEnabledProperty("mnuECopy", true);
				mnuECut.Enabled = ControlSetEnabledProperty("mnuECut", true);
				mnuEPaste.Enabled = ControlSetEnabledProperty("mnuEPaste", true);
			}
		}
#endregion
		
		private void mnuHFramework_Click(System.Object sender, System.EventArgs e)
		{
			//Dim prc As New Process
			
			//prc.StartInfo.FileName = "http://www.doors98.com"
			//prc.Start()
		}
		
		private void mnuHAbout_Click(System.Object sender, System.EventArgs e)
		{
			//Dim frm As New frmAbout
			//frm.ShowDialog()
		}
		
		
		private void MenuItem2_Click(System.Object sender, System.EventArgs e)
		{
			if (PDSAAppConfig.CurrentLoginID != "Admin")
			{
				tblreadingManager mgr = default(tblreadingManager);
				tblreadingCollection col = new tblreadingCollection();
				
				try
				{
					mgr = new tblreadingManager();
					mgr.DataObject.WhereFilter = tblreadingData.WhereFilters.CashierStatus;
					mgr.Entity.cashier = System.Convert.ToString(PDSAAppConfig.CurrentLoginID);
					col = mgr.BuildCollection();
					if (mgr.DataObject.RowsAffected > 0)
					{
						
						frmPOS posform = new frmPOS();
						posform.ShowDialog();
						posform = null;
						
					}
					else
					{
						//Dim begcash As New frmBegCash
						
						//begcash.ShowDialog()
						//begcash = Nothing
						frmBegCash frm = default(frmBegCash);
						if (mFormsTracker.IsLoaded("frmBegCash"))
						{
							mFormsTracker.Close("frmBegCash");
							mFormsTracker.Remove("frmBegCash");
							frm = new frmBegCash();
							frm.FormClosed += frm.frmBegCash_FormClosed;
							frm.Load += frm.frmBegCash_Load;
							mFormsTracker.Add(frm, System.Convert.ToString(this));
							frm.MdiParent = this;
							frm.WindowState = FormWindowState.Maximized;
							frm.Show();
							frm = null;
						}
						else
						{
							frm = new frmBegCash();
							frm.FormClosed += frm.frmBegCash_FormClosed;
							frm.Load += frm.frmBegCash_Load;
							mFormsTracker.Add(frm, System.Convert.ToString(this));
							frm.MdiParent = this;
							frm.WindowState = FormWindowState.Maximized;
							frm.Show();
							frm = null;
						}
					}
				}
			
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			
		}
		
		//Private Sub MenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem3.Click
		//    'Dim frm As New Form2
		
		//    'frm.ShowDialog()
		//    'frm.Dispose()
		//    'frm = Nothing
		//End Sub
		
		private void MenuItem7_Click(object sender, EventArgs e)
		{
			//Dim frmMI As New frmManualInv
			//frmMI.ShowDialog()
			frmManualInv frm = default(frmManualInv);
			
			if (mFormsTracker.IsLoaded("frmManualInv"))
			{
				mFormsTracker.Close("frmManualInv");
				mFormsTracker.Remove("frmManualInv");
				frm = new frmManualInv();
				frm.FormClosed += frm.frmManualInv_FormClosed;
				frm.FormClosing += frm.frmManualInv_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmManualInv();
				frm.FormClosed += frm.frmManualInv_FormClosed;
				frm.FormClosing += frm.frmManualInv_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem8_Click(object sender, EventArgs e)
		{
			//Dim frmNI As New frmNewItems
			//frmNI.ShowDialog()
			frmNewItems frm = default(frmNewItems);
			if (mFormsTracker.IsLoaded("frmNewItems"))
			{
				mFormsTracker.Close("frmNewItems");
				mFormsTracker.Remove("frmNewItems");
				frm = new frmNewItems();
				frm.FormClosed += frm.frmNewItems_FormClosed;
				frm.FormClosing += frm.frmNewItems_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmNewItems();
				frm.FormClosed += frm.frmNewItems_FormClosed;
				frm.FormClosing += frm.frmNewItems_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem9_Click(object sender, EventArgs e)
		{
			//Dim formItems As New frmItemList
			//formItems.ShowDialog()
			frmItemlist2 frm = default(frmItemlist2);
			if (mFormsTracker.IsLoaded("frmItemlist2"))
			{
				mFormsTracker.Close("frmItemlist2");
				mFormsTracker.Remove("frmItemlist2");
				frm = new frmItemlist2();
				frm.FormClosed += frm.frmItemlist2_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmItemlist2();
				frm.FormClosed += frm.frmItemlist2_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem19_Click(object sender, EventArgs e)
		{
			//Dim retform As New frmReturns
			//retform.ShowDialog()
			frmReturns frm = default(frmReturns);
			if (mFormsTracker.IsLoaded("frmReturns"))
			{
				mFormsTracker.Close("frmReturns");
				mFormsTracker.Remove("frmReturns");
				frm = new frmReturns();
				frm.FormClosed += frm.frmReturns_FormClosed;
				frm.FormClosing += frm.frmReturns_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmReturns();
				frm.FormClosed += frm.frmReturns_FormClosed;
				frm.FormClosing += frm.frmReturns_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.WindowState = FormWindowState.Maximized;
				frm.MdiParent = this;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem22_Click(object sender, EventArgs e)
		{
			//Dim pofrm As New frmPO
			//pofrm.ShowDialog()
			frmPO frm = default(frmPO);
			if (mFormsTracker.IsLoaded("frmPO"))
			{
				mFormsTracker.Close("frmPO");
				mFormsTracker.Remove("frmPO");
				frm = new frmPO();
				frm.FormClosed += frm.frmPO_FormClosed;
				frm.FormClosing += frm.frmPO_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPO();
				frm.FormClosed += frm.frmPO_FormClosed;
				frm.FormClosing += frm.frmPO_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		//Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click
		//    'Dim maindboard As New frmDashboard
		//    'maindboard.ShowDialog()
		//    Dim frm As frmDashboard
		//    If mFormsTracker.IsLoaded("frmDashboard") Then
		//        mFormsTracker.Close("frmDashboard")
		//        mFormsTracker.Remove("frmDashboard")
		//        frm = New frmDashboard
		
		//        mFormsTracker.Add(frm, Me)
		//        frm.MdiParent = Me
		//        frm.WindowState = FormWindowState.Maximized
		//        frm.Show()
		//    Else
		//        frm = New frmDashboard
		//        mFormsTracker.Add(frm, Me)
		//        frm.MdiParent = Me
		//        frm.WindowState = FormWindowState.Maximized
		//        frm.Show()
		//    End If
		
		//End Sub
		
		private void MenuItem49_Click(object sender, EventArgs e)
		{
			// Dim frmdbsaleshr As New frmSalesTodayHr
			//frmdbsaleshr.Show()
			frmSalesTodayHr frm = default(frmSalesTodayHr);
			if (mFormsTracker.IsLoaded("frmSalesTodayHr"))
			{
				mFormsTracker.Close("frmSalesTodayHr");
				mFormsTracker.Remove("frmSalesTodayHr");
				frm = new frmSalesTodayHr();
				frm.FormClosed += frm.frmSalesTodayHr_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesTodayHr();
				frm.FormClosed += frm.frmSalesTodayHr_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem50_Click(object sender, EventArgs e)
		{
			//Dim frmPasthr As New frmPastSalesHr
			//frmPasthr.Show()
			frmPastSalesHr frm = default(frmPastSalesHr);
			if (mFormsTracker.IsLoaded("frmPastSalesHr"))
			{
				mFormsTracker.Close("frmPastSalesHr");
				mFormsTracker.Remove("frmPastSalesHr");
				frm = new frmPastSalesHr();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPastSalesHr();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem51_Click(object sender, EventArgs e)
		{
			//Dim frmitemssold As New frmpvtSales
			//frmitemssold.Show()
			frmpvtSales frm = default(frmpvtSales);
			if (mFormsTracker.IsLoaded("frmpvtSales"))
			{
				mFormsTracker.Close("frmpvtSales");
				mFormsTracker.Remove("frmpvtSales");
				frm = new frmpvtSales();
				frm.FormClosed += frm.frmpvtSales_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmpvtSales();
				frm.FormClosed += frm.frmpvtSales_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem34_Click(object sender, EventArgs e)
		{
			//Dim frmsaledet As New frmSalesDetails
			//frmsaledet.Show()
			frmSalesDetails frm = default(frmSalesDetails);
			if (mFormsTracker.IsLoaded("frmSalesDetails"))
			{
				mFormsTracker.Close("frmSalesDetails");
				mFormsTracker.Remove("frmSalesDetails");
				frm = new frmSalesDetails();
				frm.FormClosed += frm.frmSalesDetails_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesDetails();
				frm.FormClosed += frm.frmSalesDetails_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem53_Click(object sender, EventArgs e)
		{
			//Dim frmsalesprofit As New frmSalesWithNet
			//frmsalesprofit.Show()
			frmSalesWithNet frm = default(frmSalesWithNet);
			if (mFormsTracker.IsLoaded("frmSalesWithNet"))
			{
				mFormsTracker.Close("frmSalesWithNet");
				mFormsTracker.Remove("frmSalesWithNet");
				frm = new frmSalesWithNet();
				frm.FormClosed += frm.frmSalesWithNet_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesWithNet();
				frm.FormClosed += frm.frmSalesWithNet_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem55_Click(object sender, EventArgs e)
		{
			//Dim frmcdb As New frmCreditDB
			//frmcdb.Show()
			
			frmCreditDB frm = default(frmCreditDB);
			
			if (mFormsTracker.IsLoaded("frmCreditDB"))
			{
				mFormsTracker.Close("frmCreditDB");
				mFormsTracker.Remove("frmCreditDB");
				frm = new frmCreditDB();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCreditDB();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem57_Click(object sender, EventArgs e)
		{
			CustBal rep = new CustBal();
			//rep.ParamCashier.Value = PDSAAppConfig.CurrentLoginID
			//rep.RequestParameters = False
			rep.PrintingSystem.ShowMarginsWarning = false;
			rep.ShowPreview();
		}
		private void MenuItem59_Click(object sender, EventArgs e)
		{
			//Dim frmSalesDB As New frmSalesDashboard
			//frmSalesDB.Show()
			frmSalesDashboard frm = default(frmSalesDashboard);
			if (mFormsTracker.IsLoaded("frmSalesDashboard"))
			{
				mFormsTracker.Close("frmSalesDashboard");
				mFormsTracker.Remove("frmSalesDashboard");
				frm = new frmSalesDashboard();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesDashboard();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem54_Click(object sender, EventArgs e)
		{
			//Dim frmprofit As New frmProfitDB
			//frmprofit.Show()
			
			frmProfitDB frm = default(frmProfitDB);
			if (mFormsTracker.IsLoaded("frmProfitDB"))
			{
				mFormsTracker.Close("frmProfitDB");
				mFormsTracker.Remove("frmProfitDB");
				frm = new frmProfitDB();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmProfitDB();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem15_Click(object sender, EventArgs e)
		{
			//Dim frmdbsales As New frmDashboardSalesDate
			//frmdbsales.Show()
			
			frmDashboardSalesDate frm = default(frmDashboardSalesDate);
			if (mFormsTracker.IsLoaded("frmDashboardSalesDate"))
			{
				mFormsTracker.Close("frmDashboardSalesDate");
				mFormsTracker.Remove("frmDashboardSalesDate");
				frm = new frmDashboardSalesDate();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDashboardSalesDate();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem32_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmItemsSoldSummry
			//frm.Show()
			
			frmItemsSoldSummry frm = default(frmItemsSoldSummry);
			if (mFormsTracker.IsLoaded("frmItemsSoldSummry"))
			{
				mFormsTracker.Close("frmItemsSoldSummry");
				mFormsTracker.Remove("frmItemsSoldSummry");
				frm = new frmItemsSoldSummry();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmItemsSoldSummry();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem60_Click(object sender, EventArgs e)
		{
			// Dim frm As New frmCreditGrid
			// frm.Show()
			
			frmCreditGrid frm = default(frmCreditGrid);
			if (mFormsTracker.IsLoaded("frmCreditGrid"))
			{
				mFormsTracker.Close("frmCreditGrid");
				mFormsTracker.Remove("frmCreditGrid");
				frm = new frmCreditGrid();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCreditGrid();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem62_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmCustPayGrid
			//frm.Show()
			
			frmCustPayGrid frm = default(frmCustPayGrid);
			if (mFormsTracker.IsLoaded("frmCustPayGrid"))
			{
				mFormsTracker.Close("frmCustPayGrid");
				mFormsTracker.Remove("frmCustPayGrid");
				frm = new frmCustPayGrid();
				frm.FormClosed += frm.frmCustPayGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCustPayGrid();
				frm.FormClosed += frm.frmCustPayGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem25_Click(object sender, EventArgs e)
		{
			//Dim frmDlvry As New frmDelivery
			//frmDlvry.Show()
			frmDelivery frm = default(frmDelivery);
			if (mFormsTracker.IsLoaded("frmDelivery"))
			{
				mFormsTracker.Close("frmDelivery");
				mFormsTracker.Remove("frmDelivery");
				frm = new frmDelivery();
				frm.FormClosed += frm.frmDelivery_FormClosed;
				frm.FormClosing += frm.frmDelivery_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDelivery();
				frm.FormClosed += frm.frmDelivery_FormClosed;
				frm.FormClosing += frm.frmDelivery_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem27_Click(object sender, EventArgs e)
		{
			//Dim frmpi As New frmDrPayment
			//frmpi.ShowDialog()
			
			frmDrPayment frm = default(frmDrPayment);
			if (mFormsTracker.IsLoaded("frmDrPayment"))
			{
				mFormsTracker.Close("frmDrPayment");
				mFormsTracker.Remove("frmDrPayment");
				frm = new frmDrPayment();
				frm.FormClosed += frm.frmDrPayment_FormClosed;
				frm.FormClosing += frm.frmDrPayment_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDrPayment();
				frm.FormClosed += frm.frmDrPayment_FormClosed;
				frm.FormClosing += frm.frmDrPayment_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem31_Click(object sender, EventArgs e)
		{
			//Dim frmBo As New frmBackorder
			//frmBo.ShowDialog()
			
			frmBackorder frm = default(frmBackorder);
			if (mFormsTracker.IsLoaded("frmBackorder"))
			{
				mFormsTracker.Close("frmBackorder");
				mFormsTracker.Remove("frmBackorder");
				frm = new frmBackorder();
				frm.FormClosed += frm.frmBackorder_FormClosed;
				frm.FormClosing += frm.frmBackorder_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBackorder();
				frm.FormClosed += frm.frmBackorder_FormClosed;
				frm.FormClosing += frm.frmBackorder_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem29_Click(object sender, EventArgs e)
		{
			//Dim formTransfer As New frmTransferStock
			//formTransfer.ShowDialog()
			frmTransferStock frm = default(frmTransferStock);
			if (mFormsTracker.IsLoaded("frmTransferStock"))
			{
				mFormsTracker.Close("frmTransferStock");
				mFormsTracker.Remove("frmTransferStock");
				frm = new frmTransferStock();
				frm.FormClosed += frm.frmTransferStock_FormClosed;
				frm.FormClosing += frm.frmTransferStock_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTransferStock();
				frm.FormClosed += frm.frmTransferStock_FormClosed;
				frm.FormClosing += frm.frmTransferStock_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem40_Click(object sender, EventArgs e)
		{
			//Dim frm As New DBDlvry
			//frm.Show()
			DBDlvry frm = default(DBDlvry);
			if (mFormsTracker.IsLoaded("DBDlvry"))
			{
				mFormsTracker.Close("DBDlvry");
				mFormsTracker.Remove("DBDlvry");
				frm = new DBDlvry();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new DBDlvry();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem41_Click(object sender, EventArgs e)
		{
			//Dim frm As New DBDlvryItem
			//frm.Show()
			
			DBDlvryItem frm = default(DBDlvryItem);
			if (mFormsTracker.IsLoaded("DBDlvryItem"))
			{
				mFormsTracker.Close("DBDlvryItem");
				mFormsTracker.Remove("DBDlvryItem");
				frm = new DBDlvryItem();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new DBDlvryItem();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem36_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmDeliveryGrid
			//frm.Show()
			
			
			frmDeliveryGrid frm = default(frmDeliveryGrid);
			if (mFormsTracker.IsLoaded("frmDeliveryGrid"))
			{
				mFormsTracker.Close("frmDeliveryGrid");
				mFormsTracker.Remove("frmDeliveryGrid");
				frm = new frmDeliveryGrid();
				frm.FormClosed += frm.frmDeliveryGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDeliveryGrid();
				frm.FormClosed += frm.frmDeliveryGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem46_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmItemLedgerGrd1
			//frm.Show()
			
			frmItemLedgerGrd1 frm = default(frmItemLedgerGrd1);
			if (mFormsTracker.IsLoaded("frmItemLedgerGrd1"))
			{
				mFormsTracker.Close("frmItemLedgerGrd1");
				mFormsTracker.Remove("frmItemLedgerGrd1");
				frm = new frmItemLedgerGrd1();
				frm.FormClosed += frm.frmItemLedgerGrd1_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmItemLedgerGrd1();
				frm.FormClosed += frm.frmItemLedgerGrd1_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void mnuBelowMin_Click(object sender, EventArgs e)
		{
			XrItemsBelowMinim belowmin = new XrItemsBelowMinim();
			belowmin.PrintingSystem.ShowMarginsWarning = false;
			belowmin.ShowPreview();
		}
		
		private void mnuAboveMax_Click(object sender, EventArgs e)
		{
			XRItemsAboveMaxim abovemax = new XRItemsAboveMaxim();
			abovemax.PrintingSystem.ShowMarginsWarning = false;
			abovemax.ShowPreview();
		}
		
		private void MenuItem38_Click(object sender, EventArgs e)
		{
			XrOutofStak outofstak = new XrOutofStak();
			outofstak.PrintingSystem.ShowMarginsWarning = false;
			outofstak.ShowPreview();
		}
		
		private void MenuItem44_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmInvCostGrid
			//frm.Show()
			
			frmInvCostGrid frm = default(frmInvCostGrid);
			if (mFormsTracker.IsLoaded("frmInvCostGrid"))
			{
				mFormsTracker.Close("frmInvCostGrid");
				mFormsTracker.Remove("frmInvCostGrid");
				frm = new frmInvCostGrid();
				frm.FormClosed += frm.frmInvCostGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmInvCostGrid();
				frm.FormClosed += frm.frmInvCostGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem43_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmInvCostPivt
			//frm.Show()
			
			frmInvCostPivt frm = default(frmInvCostPivt);
			if (mFormsTracker.IsLoaded("frmInvCostPivt"))
			{
				mFormsTracker.Close("frmInvCostPivt");
				mFormsTracker.Remove("frmInvCostPivt");
				frm = new frmInvCostPivt();
				frm.FormClosed += frm.frmInvCostPivt_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmInvCostPivt();
				frm.FormClosed += frm.frmInvCostPivt_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem45_Click(object sender, EventArgs e)
		{
			// Dim frm As New frmTransferGrd
			// frm.Show()
			
			frmTransferGrd frm = default(frmTransferGrd);
			if (mFormsTracker.IsLoaded("frmTransferGrd"))
			{
				mFormsTracker.Close("frmTransferGrd");
				mFormsTracker.Remove("frmTransferGrd");
				frm = new frmTransferGrd();
				frm.FormClosed += frm.frmTransferGrd_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTransferGrd();
				frm.FormClosed += frm.frmTransferGrd_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem63_Click(object sender, EventArgs e)
		{
			// Dim frm As New frmTransferedDB
			// frm.Show()
			
			frmTransferedDB frm = default(frmTransferedDB);
			if (mFormsTracker.IsLoaded("frmTransferedDB"))
			{
				mFormsTracker.Close("frmTransferedDB");
				mFormsTracker.Remove("frmTransferedDB");
				frm = new frmTransferedDB();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTransferedDB();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem64_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmReceiveStokcs
			//frm.Show()
			
			frmReceiveStokcs frm = default(frmReceiveStokcs);
			if (mFormsTracker.IsLoaded("frmReceiveStokcs"))
			{
				mFormsTracker.Close("frmReceiveStokcs");
				mFormsTracker.Remove("frmReceiveStokcs");
				frm = new frmReceiveStokcs();
				frm.FormClosed += frm.frmReceiveStokcs_FormClosed;
				frm.FormClosing += frm.frmReceiveStokcs_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmReceiveStokcs();
				frm.FormClosed += frm.frmReceiveStokcs_FormClosed;
				frm.FormClosing += frm.frmReceiveStokcs_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem66_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmManualInvGrid
			//frm.Show()
			
			frmManualInvGrid frm = default(frmManualInvGrid);
			if (mFormsTracker.IsLoaded("frmManualInvGrid"))
			{
				mFormsTracker.Close("frmManualInvGrid");
				mFormsTracker.Remove("frmManualInvGrid");
				frm = new frmManualInvGrid();
				frm.FormClosed += frm.frmManualInvGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmManualInvGrid();
				frm.FormClosed += frm.frmManualInvGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem48_Click(object sender, EventArgs e)
		{
			xrItmLedgers posrep = new xrItmLedgers();
			//posrep.Parameter1.Value = mOrderId
			//posrep.RequestParameters = False
			//ceRefno.Value = mOrderId
			posrep.PrintingSystem.ShowMarginsWarning = false;
			posrep.ShowPreview();
		}
		
		private void MenuItem67_Click(object sender, EventArgs e)
		{
			xrCustPay posrep = new xrCustPay();
			posrep.PrintingSystem.ShowMarginsWarning = false;
			posrep.ShowPreview();
		}
		
		private void MenuItem8_Click_1(object sender, EventArgs e)
		{
			xrTransfers rep = new xrTransfers();
			rep.PrintingSystem.ShowMarginsWarning = false;
			rep.ShowPreview();
		}
		
		private void MenuItem6_Click(object sender, EventArgs e)
		{
			// Dim frm As New frmItemLedgerPvt
			// frm.Show()
			
			
			frmItemLedgerPvt frm = default(frmItemLedgerPvt);
			if (mFormsTracker.IsLoaded("frmItemLedgerPvt"))
			{
				mFormsTracker.Close("frmItemLedgerPvt");
				mFormsTracker.Remove("frmItemLedgerPvt");
				frm = new frmItemLedgerPvt();
				frm.FormClosed += frm.frmItemLedgerPvt_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmItemLedgerPvt();
				frm.FormClosed += frm.frmItemLedgerPvt_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem9_Click_1(object sender, EventArgs e)
		{
			// Dim frm As New frmSalesWithNetPvt
			// frm.Show()
			
			frmSalesWithNetPvt frm = default(frmSalesWithNetPvt);
			if (mFormsTracker.IsLoaded("frmSalesWithNetPvt"))
			{
				mFormsTracker.Close("frmSalesWithNetPvt");
				mFormsTracker.Remove("frmSalesWithNetPvt");
				frm = new frmSalesWithNetPvt();
				frm.FormClosed += frm.frmSalesWithNetPvt_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
				frm = null;
			}
			else
			{
				frm = new frmSalesWithNetPvt();
				frm.FormClosed += frm.frmSalesWithNetPvt_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.Show();
				frm.WindowState = FormWindowState.Maximized;
				frm = null;
			}
		}
		
		private void MenuItem71_Click(object sender, EventArgs e)
		{
			//Dim frmbc As New frmBestCustomer
			//frmbc.Show()
			
			frmBestCustomer frm = default(frmBestCustomer);
			if (mFormsTracker.IsLoaded("frmBestCustomer"))
			{
				mFormsTracker.Close("frmBestCustomer");
				mFormsTracker.Remove("frmBestCustomer");
				frm = new frmBestCustomer();
				frm.FormClosed += frm.frmBestCustomer_FormClosed;
				frm.KeyDown += frm.frmBestCustomer_KeyDown;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBestCustomer();
				frm.FormClosed += frm.frmBestCustomer_FormClosed;
				frm.KeyDown += frm.frmBestCustomer_KeyDown;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem68_Click(object sender, EventArgs e)
		{
			// Dim stdwc As New frmSales2DayCashr
			// stdwc.ShowDialog()
			
			frmSales2DayCashr frm = default(frmSales2DayCashr);
			if (mFormsTracker.IsLoaded("frmSales2DayCashr"))
			{
				mFormsTracker.Close("frmSales2DayCashr");
				mFormsTracker.Remove("frmSales2DayCashr");
				frm = new frmSales2DayCashr();
				frm.FormClosed += frm.frmSales2DayCashr_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSales2DayCashr();
				frm.FormClosed += frm.frmSales2DayCashr_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem73_Click(object sender, EventArgs e)
		{
			xrSupplierBal repsupbal = new xrSupplierBal();
			repsupbal.PrintingSystem.ShowMarginsWarning = false;
			repsupbal.ShowPreview();
		}
		
		private void MenuItem74_Click(object sender, EventArgs e)
		{
			//Dim frmhilo As New frmHiLoSellingItems
			//frmhilo.ShowDialog()
			
			
			frmHiLoSellingItems frm = default(frmHiLoSellingItems);
			if (mFormsTracker.IsLoaded("frmHiLoSellingItems"))
			{
				mFormsTracker.Close("frmHiLoSellingItems");
				mFormsTracker.Remove("frmHiLoSellingItems");
				frm = new frmHiLoSellingItems();
				frm.FormClosed += frm.frmHiLoSellingItems_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmHiLoSellingItems();
				frm.FormClosed += frm.frmHiLoSellingItems_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem76_Click(object sender, EventArgs e)
		{
			//Dim hilodlvry As New frmHiLoDlvryItems
			//hilodlvry.ShowDialog()
			
			frmHiLoDlvryItems frm = default(frmHiLoDlvryItems);
			if (mFormsTracker.IsLoaded("frmHiLoDlvryItems"))
			{
				mFormsTracker.Close("frmHiLoDlvryItems");
				mFormsTracker.Remove("frmHiLoDlvryItems");
				frm = new frmHiLoDlvryItems();
				frm.FormClosed += frm.frmHiLoDlvryItems_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmHiLoDlvryItems();
				frm.FormClosed += frm.frmHiLoDlvryItems_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem78_Click(object sender, EventArgs e)
		{
			//Dim custpay As New frmCustPayDB
			//custpay.ShowDialog()
			
			frmCustPayDB frm = default(frmCustPayDB);
			
			if (mFormsTracker.IsLoaded("frmCustPayDB"))
			{
				mFormsTracker.Close("frmCustPayDB");
				mFormsTracker.Remove("frmCustPayDB");
				frm = new frmCustPayDB();
				frm.FormClosed += frm.frmCustPayDB_FormClosed;
				frm.Load += frm.frmCustPayDB_Load;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCustPayDB();
				frm.FormClosed += frm.frmCustPayDB_FormClosed;
				frm.Load += frm.frmCustPayDB_Load;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.WindowState = FormWindowState.Maximized;
				frm.MdiParent = this;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem79_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
		}
		
		private void MenuItem81_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
		}
		
		private void MenuItem82_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
		}
		private void MenuItem84_Click(object sender, EventArgs e)
		{
			frmHiLoWeekly frm = default(frmHiLoWeekly);
			
			if (mFormsTracker.IsLoaded("frmHiLoWeekly"))
			{
				mFormsTracker.Close("frmHiLoWeekly");
				mFormsTracker.Remove("frmHiLoWeekly");
				frm = new frmHiLoWeekly();
				frm.FormClosed += frm.frmHiLoWeekly_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmHiLoWeekly();
				frm.FormClosed += frm.frmHiLoWeekly_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem85_Click(object sender, EventArgs e)
		{
			frmSoldQtrly frm = default(frmSoldQtrly);
			
			if (mFormsTracker.IsLoaded("frmSoldQtrly"))
			{
				mFormsTracker.Close("frmSoldQtrly");
				mFormsTracker.Remove("frmSoldQtrly");
				frm = new frmSoldQtrly();
				frm.FormClosed += frm.frmSoldQtrly_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSoldQtrly();
				frm.FormClosed += frm.frmSoldQtrly_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem86_Click(object sender, EventArgs e)
		{
			frmSoldYrly frm = default(frmSoldYrly);
			
			if (mFormsTracker.IsLoaded("frmSoldYrly"))
			{
				mFormsTracker.Close("frmSoldYrly");
				mFormsTracker.Remove("frmSoldYrly");
				frm = new frmSoldYrly();
				frm.FormClosed += frm.frmSoldYrly_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSoldYrly();
				frm.FormClosed += frm.frmSoldYrly_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem87_Click(object sender, EventArgs e)
		{
			frmItemSoldDaily frm = default(frmItemSoldDaily);
			
			if (mFormsTracker.IsLoaded("frmItemSoldDaily"))
			{
				mFormsTracker.Close("frmItemSoldDaily");
				mFormsTracker.Remove("frmItemSoldDaily");
				frm = new frmItemSoldDaily();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmItemSoldDaily();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem88_Click(object sender, EventArgs e)
		{
			frmDailProfitDB frm = default(frmDailProfitDB);
			
			if (mFormsTracker.IsLoaded("frmDailProfitDB"))
			{
				mFormsTracker.Close("frmDailProfitDB");
				mFormsTracker.Remove("frmDailProfitDB");
				frm = new frmDailProfitDB();
				frm.FormClosed += frm.frmDailProfitDB_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDailProfitDB();
				frm.FormClosed += frm.frmDailProfitDB_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem89_Click(object sender, EventArgs e)
		{
			frmWeeklyProfitDB frm = default(frmWeeklyProfitDB);
			
			if (mFormsTracker.IsLoaded("frmWeeklyProfitDB"))
			{
				mFormsTracker.Close("frmWeeklyProfitDB");
				mFormsTracker.Remove("frmWeeklyProfitDB");
				frm = new frmWeeklyProfitDB();
				frm.FormClosed += frm.frmWeeklyProfitDB_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmWeeklyProfitDB();
				frm.FormClosed += frm.frmWeeklyProfitDB_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem91_Click(object sender, EventArgs e)
		{
			frmAnnualProfitDB frm = default(frmAnnualProfitDB);
			
			if (mFormsTracker.IsLoaded("frmAnnualProfitDB"))
			{
				mFormsTracker.Close("frmAnnualProfitDB");
				mFormsTracker.Remove("frmAnnualProfitDB");
				frm = new frmAnnualProfitDB();
				frm.FormClosed += frm.frmAnnualProfitDB_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmAnnualProfitDB();
				frm.FormClosed += frm.frmAnnualProfitDB_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem92_Click(object sender, EventArgs e)
		{
			xrAvlblItems outofstak = new xrAvlblItems();
			outofstak.PrintingSystem.ShowMarginsWarning = false;
			outofstak.ShowPreview();
		}
		
		private void MenuItem93_Click(object sender, EventArgs e)
		{
			xrInvDiffRep invdif = new xrInvDiffRep();
			invdif.ShowPreview();
		}
		
		private void MenuItem96_Click(object sender, EventArgs e)
		{
			frmLoginEmp frm = default(frmLoginEmp);
			
			if (mFormsTracker.IsLoaded("frmLoginEmp"))
			{
				mFormsTracker.Close("frmLoginEmp");
				mFormsTracker.Remove("frmLoginEmp");
				frm = new frmLoginEmp();
				frm.FormClosed += frm.frmLoginEmp_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				// frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmLoginEmp();
				frm.FormClosed += frm.frmLoginEmp_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				//frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem97_Click(object sender, EventArgs e)
		{
			frmBreakOut frm = default(frmBreakOut);
			
			if (mFormsTracker.IsLoaded("frmBreakOut"))
			{
				mFormsTracker.Close("frmBreakOut");
				mFormsTracker.Remove("frmBreakOut");
				frm = new frmBreakOut();
				frm.FormClosed += frm.frmBreakOut_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				// frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBreakOut();
				frm.FormClosed += frm.frmBreakOut_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				//frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem98_Click(object sender, EventArgs e)
		{
			frmTimeInafterBrk frm = default(frmTimeInafterBrk);
			
			if (mFormsTracker.IsLoaded("frmTimeInafterBrk"))
			{
				mFormsTracker.Close("frmTimeInafterBrk");
				mFormsTracker.Remove("frmTimeInafterBrk");
				frm = new frmTimeInafterBrk();
				frm.FormClosed += frm.frmTimeInafterBrk_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				// frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTimeInafterBrk();
				frm.FormClosed += frm.frmTimeInafterBrk_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				//frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem99_Click(object sender, EventArgs e)
		{
			frmTimeOut frm = default(frmTimeOut);
			
			if (mFormsTracker.IsLoaded("frmTimeOut"))
			{
				mFormsTracker.Close("frmTimeOut");
				mFormsTracker.Remove("frmTimeOut");
				frm = new frmTimeOut();
				frm.FormClosed += frm.frmTimeOut_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				// frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTimeOut();
				frm.FormClosed += frm.frmTimeOut_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				//frm.WindowState = FormWindowState.Maximized
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem102_Click(object sender, EventArgs e)
		{
			xrEmpTime xrtime = new xrEmpTime();
			xrtime.ShowPreview();
		}
		
		private void MenuItem103_Click(object sender, EventArgs e)
		{
			frmReceivedStcksGrd frm = default(frmReceivedStcksGrd);
			
			if (mFormsTracker.IsLoaded("frmReceivedStcksGrd"))
			{
				mFormsTracker.Close("frmReceivedStcksGrd");
				mFormsTracker.Remove("frmReceivedStcksGrd");
				frm = new frmReceivedStcksGrd();
				frm.FormClosed += frm.frmReceivedStcksGrd_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmReceivedStcksGrd();
				frm.FormClosed += frm.frmReceivedStcksGrd_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem104_Click(object sender, EventArgs e)
		{
			frmBuyPrcHistory frm = default(frmBuyPrcHistory);
			
			if (mFormsTracker.IsLoaded("frmBuyPrcHistory"))
			{
				mFormsTracker.Close("frmBuyPrcHistory");
				mFormsTracker.Remove("frmBuyPrcHistory");
				frm = new frmBuyPrcHistory();
				frm.FormClosed += frm.frmBuyPrcHistory_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBuyPrcHistory();
				frm.FormClosed += frm.frmBuyPrcHistory_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem105_Click(object sender, EventArgs e)
		{
			frmBOGrid frm = default(frmBOGrid);
			
			if (mFormsTracker.IsLoaded("frmBOGrid"))
			{
				mFormsTracker.Close("frmBOGrid");
				mFormsTracker.Remove("frmBOGrid");
				frm = new frmBOGrid();
				frm.FormClosed += frm.frmBOGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBOGrid();
				frm.FormClosed += frm.frmBOGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem3_Click(object sender, EventArgs e)
		{
			xrBo xrborep = new xrBo();
			xrborep.ShowPreview();
		}
		
		private void MenuItem107_Click(object sender, EventArgs e)
		{
			frmBoGrd2 frm = default(frmBoGrd2);
			
			if (mFormsTracker.IsLoaded("frmBoGrd2"))
			{
				mFormsTracker.Close("frmBoGrd2");
				mFormsTracker.Remove("frmBoGrd2");
				frm = new frmBoGrd2();
				frm.FormClosed += frm.frmBoGrd2_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBoGrd2();
				frm.FormClosed += frm.frmBoGrd2_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem108_Click(object sender, EventArgs e)
		{
			frmRcivdStcksGrd2 frm = default(frmRcivdStcksGrd2);
			
			if (mFormsTracker.IsLoaded("frmRcivdStcksGrd2"))
			{
				mFormsTracker.Close("frmRcivdStcksGrd2");
				mFormsTracker.Remove("frmRcivdStcksGrd2");
				frm = new frmRcivdStcksGrd2();
				frm.FormClosed += frm.frmRcivdStcksGrd2_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmRcivdStcksGrd2();
				frm.FormClosed += frm.frmRcivdStcksGrd2_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem109_Click(object sender, EventArgs e)
		{
			frmTransfrdGrd1 frm = default(frmTransfrdGrd1);
			if (mFormsTracker.IsLoaded("frmTransfrdGrd1"))
			{
				mFormsTracker.Close("frmTransfrdGrd1");
				mFormsTracker.Remove("frmTransfrdGrd1");
				frm = new frmTransfrdGrd1();
				frm.FormClosed += frm.frmTransfrdGrd1_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmTransfrdGrd1();
				frm.FormClosed += frm.frmTransfrdGrd1_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem110_Click(object sender, EventArgs e)
		{
			frmDlvryGrid2 frm = default(frmDlvryGrid2);
			if (mFormsTracker.IsLoaded("frmDlvryGrid2"))
			{
				mFormsTracker.Close("frmDlvryGrid2");
				mFormsTracker.Remove("frmDlvryGrid2");
				frm = new frmDlvryGrid2();
				frm.FormClosed += frm.frmDlvryGrid2_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDlvryGrid2();
				frm.FormClosed += frm.frmDlvryGrid2_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem111_Click(object sender, EventArgs e)
		{
			xrDlvry dritem = new xrDlvry();
			dritem.ShowPreview();
		}
		
		private void MenuItem2_Click_1(object sender, EventArgs e)
		{
			xrDlvrySupplier drrsupplier = new xrDlvrySupplier();
			drrsupplier.ShowPreview();
		}
		
		private void MenuItem112_Click(object sender, EventArgs e)
		{
			// Dim stdwc As New frmSales2DayCashr
			// stdwc.ShowDialog()
			
			frmSalestoday frm = default(frmSalestoday);
			if (mFormsTracker.IsLoaded("frmSalestoday"))
			{
				mFormsTracker.Close("frmSalestoday");
				mFormsTracker.Remove("frmSalestoday");
				frm = new frmSalestoday();
				frm.FormClosed += frm.frmSalestoday_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalestoday();
				frm.FormClosed += frm.frmSalestoday_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void mnuAmPm_Click(object sender, EventArgs e)
		{
			xrAMPM AmpPM = new xrAMPM();
			AmpPM.ShowPreview();
		}
		
		private void MenuItem117_Click(object sender, EventArgs e)
		{
			frmConvertStocks frm = default(frmConvertStocks);
			if (mFormsTracker.IsLoaded("frmConvertStocks"))
			{
				mFormsTracker.Close("frmConvertStocks");
				mFormsTracker.Remove("frmConvertStocks");
				frm = new frmConvertStocks();
				frm.FormClosed += frm.frmConvertStocks_FormClosed;
				frm.FormClosing += frm.frmConvertStocks_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmConvertStocks();
				frm.FormClosed += frm.frmConvertStocks_FormClosed;
				frm.FormClosing += frm.frmConvertStocks_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem120_Click(object sender, EventArgs e)
		{
			frmConvertGrid frm = default(frmConvertGrid);
			if (mFormsTracker.IsLoaded("frmConvertGrid"))
			{
				mFormsTracker.Close("frmConvertGrid");
				mFormsTracker.Remove("frmConvertGrid");
				frm = new frmConvertGrid();
				frm.FormClosed += frm.frmConvertGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmConvertGrid();
				frm.FormClosed += frm.frmConvertGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem115_Click(object sender, EventArgs e)
		{
			frmExpenses frm = default(frmExpenses);
			if (mFormsTracker.IsLoaded("frmExpenses"))
			{
				mFormsTracker.Close("frmExpenses");
				mFormsTracker.Remove("frmExpenses");
				frm = new frmExpenses();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmExpenses();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem122_Click(object sender, EventArgs e)
		{
			frmExpenseGrid frm = default(frmExpenseGrid);
			if (mFormsTracker.IsLoaded("frmExpenseGrid"))
			{
				mFormsTracker.Close("frmExpenseGrid");
				mFormsTracker.Remove("frmExpenseGrid");
				frm = new frmExpenseGrid();
				frm.FormClosed += frm.frmExpenseGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmExpenseGrid();
				frm.FormClosed += frm.frmExpenseGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem123_Click(object sender, EventArgs e)
		{
			frmPtyCashGrid frm = default(frmPtyCashGrid);
			if (mFormsTracker.IsLoaded("frmPtyCashGrid"))
			{
				mFormsTracker.Close("frmPtyCashGrid");
				mFormsTracker.Remove("frmPtyCashGrid");
				frm = new frmPtyCashGrid();
				frm.FormClosed += frm.frmPtyCashGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPtyCashGrid();
				frm.FormClosed += frm.frmPtyCashGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem125_Click(object sender, EventArgs e)
		{
			frmAddCashGrid frm = default(frmAddCashGrid);
			if (mFormsTracker.IsLoaded("frmAddCashGrid"))
			{
				mFormsTracker.Close("frmAddCashGrid");
				mFormsTracker.Remove("frmAddCashGrid");
				frm = new frmAddCashGrid();
				frm.FormClosed += frm.frmAddCashGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmAddCashGrid();
				frm.FormClosed += frm.frmAddCashGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem126_Click(object sender, EventArgs e)
		{
			frmDiscountGrid frm = default(frmDiscountGrid);
			if (mFormsTracker.IsLoaded("frmDiscountGrid"))
			{
				mFormsTracker.Close("frmDiscountGrid");
				mFormsTracker.Remove("frmDiscountGrid");
				frm = new frmDiscountGrid();
				frm.FormClosed += frm.frmDiscountGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmDiscountGrid();
				frm.FormClosed += frm.frmDiscountGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem127_Click(object sender, EventArgs e)
		{
			frmChkPaymntGrid frm = default(frmChkPaymntGrid);
			if (mFormsTracker.IsLoaded("frmChkPaymntGrid"))
			{
				mFormsTracker.Close("frmChkPaymntGrid");
				mFormsTracker.Remove("frmChkPaymntGrid");
				frm = new frmChkPaymntGrid();
				frm.FormClosed += frm.frmChkPaymntGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmChkPaymntGrid();
				frm.FormClosed += frm.frmChkPaymntGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem128_Click(object sender, EventArgs e)
		{
			frmVoidGrid frm = default(frmVoidGrid);
			if (mFormsTracker.IsLoaded("frmVoidGrid"))
			{
				mFormsTracker.Close("frmVoidGrid");
				mFormsTracker.Remove("frmVoidGrid");
				frm = new frmVoidGrid();
				frm.FormClosed += frm.frmVoidGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmVoidGrid();
				frm.FormClosed += frm.frmVoidGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem130_Click(object sender, EventArgs e)
		{
			frmRefundsGrid frm = default(frmRefundsGrid);
			if (mFormsTracker.IsLoaded("frmRefundsGrid"))
			{
				mFormsTracker.Close("frmRefundsGrid");
				mFormsTracker.Remove("frmRefundsGrid");
				frm = new frmRefundsGrid();
				frm.FormClosed += frm.frmRefundsGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmRefundsGrid();
				frm.FormClosed += frm.frmRefundsGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem131_Click(object sender, EventArgs e)
		{
			frmChangePrceGrid frm = default(frmChangePrceGrid);
			if (mFormsTracker.IsLoaded("frmChangePrceGrid"))
			{
				mFormsTracker.Close("frmChangePrceGrid");
				mFormsTracker.Remove("frmChangePrceGrid");
				frm = new frmChangePrceGrid();
				frm.FormClosed += frm.frmChangePrceGrid_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmChangePrceGrid();
				frm.FormClosed += frm.frmChangePrceGrid_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem132_Click(object sender, EventArgs e)
		{
			frmSalesHistory frm = default(frmSalesHistory);
			if (mFormsTracker.IsLoaded("frmSalesHistory"))
			{
				mFormsTracker.Close("frmSalesHistory");
				mFormsTracker.Remove("frmSalesHistory");
				frm = new frmSalesHistory();
				frm.FormClosed += frm.frmSalesHistory_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesHistory();
				frm.FormClosed += frm.frmSalesHistory_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem133_Click(object sender, EventArgs e)
		{
			// Dim frm As New frmCreditGrid
			// frm.Show()
			
			frmCreditGrid2 frm = default(frmCreditGrid2);
			if (mFormsTracker.IsLoaded("frmCreditGrid2"))
			{
				mFormsTracker.Close("frmCreditGrid2");
				mFormsTracker.Remove("frmCreditGrid2");
				frm = new frmCreditGrid2();
				frm.FormClosed += frm.frmCreditGrid2_FormClosed;
				frm.Load += frm.frmCreditGrid2_Load;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCreditGrid2();
				frm.FormClosed += frm.frmCreditGrid2_FormClosed;
				frm.Load += frm.frmCreditGrid2_Load;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem134_Click(object sender, EventArgs e)
		{
			ZoutReprint posrep2 = new ZoutReprint();
			//posrep.DataSource = sqlDT
			//posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
			posrep2.RequestParameters = true;
			posrep2.PrintingSystem.ShowMarginsWarning = false;
			posrep2.ShowPreview();
			
		}
		
		private void MenuItem136_Click(object sender, EventArgs e)
		{
			frmCashierReadng frm = default(frmCashierReadng);
			if (mFormsTracker.IsLoaded("frmCashierReadng"))
			{
				mFormsTracker.Close("frmCashierReadng");
				mFormsTracker.Remove("frmCashierReadng");
				frm = new frmCashierReadng();
				frm.FormClosed += frm.frmCashierReadng_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCashierReadng();
				frm.FormClosed += frm.frmCashierReadng_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem138_Click(object sender, EventArgs e)
		{
			frmBaltoSuplier frm = default(frmBaltoSuplier);
			if (mFormsTracker.IsLoaded("frmBaltoSuplier"))
			{
				mFormsTracker.Close("frmBaltoSuplier");
				mFormsTracker.Remove("frmBaltoSuplier");
				frm = new frmBaltoSuplier();
				frm.FormClosed += frm.frmBaltoSuplier_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBaltoSuplier();
				frm.FormClosed += frm.frmBaltoSuplier_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem140_Click(object sender, EventArgs e)
		{
			frmPdToSupplier frm = default(frmPdToSupplier);
			
			if (mFormsTracker.IsLoaded("frmPdToSupplier"))
			{
				mFormsTracker.Close("frmPdToSupplier");
				mFormsTracker.Remove("frmPdToSupplier");
				frm = new frmPdToSupplier();
				frm.FormClosed += frm.frmPdToSupplier_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPdToSupplier();
				frm.FormClosed += frm.frmPdToSupplier_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem141_Click(object sender, EventArgs e)
		{
			frmPaySup frm = default(frmPaySup);
			
			if (mFormsTracker.IsLoaded("frmPaySup"))
			{
				mFormsTracker.Close("frmPaySup");
				mFormsTracker.Remove("frmPaySup");
				frm = new frmPaySup();
				frm.FormClosed += frm.frmPaySup_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPaySup();
				frm.FormClosed += frm.frmPaySup_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem142_Click(object sender, EventArgs e)
		{
			frmPdtoSuppliers frm = default(frmPdtoSuppliers);
			
			if (mFormsTracker.IsLoaded("frmPdtoSuppliers"))
			{
				mFormsTracker.Close("frmPdtoSuppliers");
				mFormsTracker.Remove("frmPdtoSuppliers");
				frm = new frmPdtoSuppliers();
				frm.FormClosed += frm.frmPdtoSuppliers_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmPdtoSuppliers();
				frm.FormClosed += frm.frmPdtoSuppliers_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem143_Click(object sender, EventArgs e)
		{
			frmSalesperRef frm = default(frmSalesperRef);
			
			if (mFormsTracker.IsLoaded("frmSalesperRef"))
			{
				mFormsTracker.Close("frmSalesperRef");
				mFormsTracker.Remove("frmSalesperRef");
				frm = new frmSalesperRef();
				frm.FormClosed += frm.frmSalesperRef_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesperRef();
				frm.FormClosed += frm.frmSalesperRef_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem144_Click(object sender, EventArgs e)
		{
			frmSalesPerRef2 frm = default(frmSalesPerRef2);
			
			if (mFormsTracker.IsLoaded("frmSalesPerRef2"))
			{
				mFormsTracker.Close("frmSalesPerRef2");
				mFormsTracker.Remove("frmSalesPerRef2");
				frm = new frmSalesPerRef2();
				frm.FormClosed += frm.frmSalesPerRef2_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesPerRef2();
				frm.FormClosed += frm.frmSalesPerRef2_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem145_Click(object sender, EventArgs e)
		{
			//~~~ Calling it and passing the name of the form to be displayed
			abcLockScreen myObj = new abcLockScreen();
			myObj.LockSystemAndShow(Form2.Default);
		}
		
		private void MenuItem146_Click(object sender, EventArgs e)
		{
			frmOverview frm = default(frmOverview);
			
			if (mFormsTracker.IsLoaded("frmOverview"))
			{
				mFormsTracker.Close("frmOverview");
				mFormsTracker.Remove("frmOverview");
				frm = new frmOverview();
				frm.FormClosed += frm.frmOverview_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmOverview();
				frm.FormClosed += frm.frmOverview_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem147_Click(object sender, EventArgs e)
		{
			frmExpensesPvt frm = default(frmExpensesPvt);
			
			if (mFormsTracker.IsLoaded("frmExpensesPvt"))
			{
				mFormsTracker.Close("frmExpensesPvt");
				mFormsTracker.Remove("frmExpensesPvt");
				frm = new frmExpensesPvt();
				frm.FormClosed += frm.frmExpensesPvt_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmExpensesPvt();
				frm.FormClosed += frm.frmExpensesPvt_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem148_Click(object sender, EventArgs e)
		{
			frmCheqSales frm = default(frmCheqSales);
			
			if (mFormsTracker.IsLoaded("frmCheqSales"))
			{
				mFormsTracker.Close("frmCheqSales");
				mFormsTracker.Remove("frmCheqSales");
				frm = new frmCheqSales();
				frm.FormClosed += frm.frmCashSales_FormClosed;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmCheqSales();
				frm.FormClosed += frm.frmCashSales_FormClosed;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem150_Click(object sender, EventArgs e)
		{
			//Dim posrep2 As New ZoutReprint()
			//'posrep.DataSource = sqlDT
			//'posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
			//posrep2.RequestParameters = True
			//posrep2.PrintingSystem.ShowMarginsWarning = False
			//posrep2.ShowPreview()
			CashRdngPrint();
		}
		
		private void CashRdngPrint()
		{
			ZoutReprint posrep2 = new ZoutReprint();
			//posrep.DataSource = sqlDT
			//posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
			posrep2.RequestParameters = true;
			posrep2.PrintingSystem.ShowMarginsWarning = false;
			posrep2.ShowPreview();
		}
		
		private void MenuItem151_Click(object sender, EventArgs e)
		{
			//Dim posrep2 As New xrReadingID()
			//'posrep.DataSource = sqlDT
			//'posrep2.cashier.Value = PDSAAppConfig.CurrentLoginID
			//posrep2.RequestParameters = False
			//posrep2.PrintingSystem.ShowMarginsWarning = False
			//posrep2.Print()
			frmRdID frm = default(frmRdID);
			
			if (mFormsTracker.IsLoaded("frmRdID"))
			{
				mFormsTracker.Close("frmRdID");
				mFormsTracker.Remove("frmRdID");
				frm = new frmRdID();
				frm.FontChanged += frm.frmRdID_FontChanged;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmRdID();
				frm.FontChanged += frm.frmRdID_FontChanged;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem152_Click(object sender, EventArgs e)
		{
			CashRdngPrint();
		}
		
		
		private void MenuItem153_Click(object sender, EventArgs e)
		{
			frmUncleared frm = default(frmUncleared);
			
			if (mFormsTracker.IsLoaded("frmUncleared"))
			{
				mFormsTracker.Close("frmUncleared");
				mFormsTracker.Remove("frmUncleared");
				frm = new frmUncleared();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmUncleared();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem154_Click(object sender, EventArgs e)
		{
			//Dim frm As New frmKellerman
			//frm.ShowDialog()
			
			frmSearchItemsforRefunds frm = new frmSearchItemsforRefunds();
			frm.Show();
			
			//Dim db As IDataHelper = DataHelper.SessionFactory()
			//db.UserName = "doorscomputers"
			//db.LicenseKey = "GN84+L7G4lvSdOQWmPv5Mmz9904PcWYC5g6EnjTPkoI="
			
			//Dim table As Table = db.Mapper.GetObjectMap(GetType(bank))
			//table.Fields.ban()
			//Dim frm As frmTouchPOS
			//If mFormsTracker.IsLoaded("frmTouchPOS") Then
			//mFormsTracker.Close("frmTouchPOS")
			//mFormsTracker.Remove("frmTouchPOS")
			//frm = New frmTouchPOS
			//mFormsTracker.Add(frm, Me)
			//frm.MdiParent = Me
			//frm.WindowState = FormWindowState.Maximized
			//frm.ShowDialog()
			//frm = Nothing
			//Else
			//frm = New frmTouchPOS
			//mFormsTracker.Add(frm, Me)
			//frm.MdiParent = Me
			//frm.WindowState = FormWindowState.Maximized
			//frm.Show()
			//frm = Nothing
			//End If
			
		}
		
		private void MenuItem155_Click(object sender, EventArgs e)
		{
			frmEmployee frm = default(frmEmployee);
			if (mFormsTracker.IsLoaded("frmEmployee"))
			{
				mFormsTracker.Close("frmEmployee");
				mFormsTracker.Remove("frmEmployee");
				frm = new frmEmployee();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmEmployee();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem157_Click(object sender, EventArgs e)
		{
			frmIncentiveGrid frm = default(frmIncentiveGrid);
			if (mFormsTracker.IsLoaded("frmIncentiveGrid"))
			{
				mFormsTracker.Close("frmIncentiveGrid");
				mFormsTracker.Remove("frmIncentiveGrid");
				frm = new frmIncentiveGrid();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmIncentiveGrid();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem158_Click(object sender, EventArgs e)
		{
			frmSuppliers frm = default(frmSuppliers);
			if (mFormsTracker.IsLoaded("frmSuppliers"))
			{
				mFormsTracker.Close("frmSuppliers");
				mFormsTracker.Remove("frmSuppliers");
				frm = new frmSuppliers();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSuppliers();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem161_Click(object sender, EventArgs e)
		{
			//Dim backUpRestoreObj As BackupRestore = New BackupRestore
			//backUpRestoreObj.TakeBackUp()
			
			
			try
			{
				if (MessageBox.Show("Do you want to take back up?", "OpenMiracle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					//If (sqlcon.State = ConnectionState.Closed) Then
					//    sqlcon.Open()
					//End If
					//Dim strPath As String = (Application.StartupPath + ("\\Data\\" _
					//           + (PublicVariables._decCurrentCompanyId + "\\DBOpenMiracle.mdf")))
					
                    //string strPath = "C:\\Sqldata3\\TodaRaba\\doorspos.mdf";
					SaveFileDialog saveBackupDialog = new SaveFileDialog();
					string strDestinationPath = string.Empty;
					string strFname = "doorspos" + DateTime.Now.ToString("ddMMyyyhhmmss");
					saveBackupDialog.FileName = strFname;
					if (saveBackupDialog.ShowDialog() == DialogResult.OK)
					{
						strDestinationPath = saveBackupDialog.FileName;
						strDestinationPath = "\'" + (strDestinationPath 
							+ ".bak\'");
						//Dim sccmd As SqlCommand = New SqlCommand("CompanyBackUpDb", sqlcon)
						//sccmd.CommandType = CommandType.StoredProcedure
						//sccmd.Parameters.Add("@path", SqlDbType.VarChar).Value = strPath
						//sccmd.Parameters.Add("@name", SqlDbType.VarChar).Value = strDestinationPath
						//Dim decEffect As Decimal = Convert.ToDecimal(sccmd.ExecuteNonQuery.ToString)
						
						string sqlSTR = string.Empty;
						sqlSTR = "exec BackupDatabase @filename=" + strDestinationPath;
						
						// MessageBox.Show(sqlSTR)
						//sqlSTRR = "SELECT pos_hdrtmp.postmp_hdrid, pos_hdrtmp.pos_date, pos_hdrtmp.custid, pos_hdrtmp.pos_amnt, pos_hdrtmp.tendered, pos_hdrtmp.Cheyns,pos_hdrtmp.Sc, pos_hdrtmp.totsales, pos_hdrtmp.less_vat, pos_hdrtmp.nov, pos_hdrtmp.less_sc, pos_hdrtmp.vatable, pos_hdrtmp.exempt, pos_hdrtmp.vatamnt, pos_hdrtmp.tid, pos_hdrtmp.wtid, pos_dettmp.stckid, pos_dettmp.cost, pos_dettmp.price, pos_dettmp.qty, stocks.barcode, stocks.item_desc, tbls.tdesc, waiters.waiter FROM pos_hdrtmp INNER JOIN pos_dettmp ON pos_hdrtmp.postmp_hdrid = pos_dettmp.postmp_hdrid INNER JOIN stocks ON pos_dettmp.stckid = stocks.stckid INNER JOIN tbls ON pos_hdrtmp.tid = tbls.tid INNER JOIN waiters ON pos_hdrtmp.wtid = waiters.wtid"
						ModCon.ExecuteSQLQuery(sqlSTR);
						MessageBox.Show("The backup of database  completed successfully", "DoorsPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("BR 1 : " + ex.Message, "DOORSPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		private void MenuItem162_Click(object sender, EventArgs e)
		{
			RestoreDatabases backUpRestoreObj = new RestoreDatabases();
			backUpRestoreObj.ResToreDatabases();
		}
		
		private void MenuItem165_Click(object sender, EventArgs e)
		{
			frmExpired frm = default(frmExpired);
			if (mFormsTracker.IsLoaded("frmExpired"))
			{
				mFormsTracker.Close("frmExpired");
				mFormsTracker.Remove("frmExpired");
				frm = new frmExpired();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmExpired();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void mnuNewBarcode(object sender, EventArgs e)
		{
			frmBarcodes frm = default(frmBarcodes);
			
			if (mFormsTracker.IsLoaded("frmBarcodes"))
			{
				mFormsTracker.Close("frmBarcodes");
				mFormsTracker.Remove("frmBarcodes");
				frm = new frmBarcodes();
				frm.FormClosed += frm.frmManualInv_FormClosed;
				frm.FormClosing += frm.frmManualInv_FormClosing;
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmBarcodes();
				frm.FormClosed += frm.frmManualInv_FormClosed;
				frm.FormClosing += frm.frmManualInv_FormClosing;
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem167_Click(object sender, EventArgs e)
		{
			//Dim frm As frmBarcodeGrd
			
			//If mFormsTracker.IsLoaded("frmBarcodeGrd") Then
			//    mFormsTracker.Close("frmBarcodeGrd")
			//    mFormsTracker.Remove("frmBarcodeGrd")
			//    frm = New frmBarcodeGrd
			
			//    mFormsTracker.Add(frm, Me)
			//    frm.MdiParent = Me
			//    frm.WindowState = FormWindowState.Maximized
			//    frm.Show()
			//    frm = Nothing
			//Else
			//    frm = New frmBarcodeGrd
			//    mFormsTracker.Add(frm, Me)
			//    frm.MdiParent = Me
			//    frm.WindowState = FormWindowState.Maximized
			//    frm.Show()
			//    frm = Nothing
			//End If
			frmAddBarcode frm = default(frmAddBarcode);
			
			if (mFormsTracker.IsLoaded("frmAddBarcode"))
			{
				mFormsTracker.Close("frmAddBarcode");
				mFormsTracker.Remove("frmAddBarcode");
				frm = new frmAddBarcode();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmAddBarcode();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem168_Click(object sender, EventArgs e)
		{
			BIRSalesReportPrint();
		}
		private void BIRSalesReportPrint()
		{
			xrBIRSalesReport posrep2 = new xrBIRSalesReport();
			posrep2.RequestParameters = true;
			posrep2.PrintingSystem.ShowMarginsWarning = false;
			posrep2.ShowPreview();
		}
		
		private void MenuItem169_Click(object sender, EventArgs e)
		{
			frmSummary frm = default(frmSummary);
			
			if (mFormsTracker.IsLoaded("frmSummary"))
			{
				mFormsTracker.Close("frmSummary");
				mFormsTracker.Remove("frmSummary");
				frm = new frmSummary();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSummary();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
		}
		
		private void MenuItem170_Click(object sender, EventArgs e)
		{
			frmSalesParam frm = default(frmSalesParam);
			if (mFormsTracker.IsLoaded("frmSalesParam"))
			{
				mFormsTracker.Close("frmSalesParam");
				mFormsTracker.Remove("frmSalesParam");
				frm = new frmSalesParam();
				
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			else
			{
				frm = new frmSalesParam();
				mFormsTracker.Add(frm, System.Convert.ToString(this));
				frm.MdiParent = this;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				frm = null;
			}
			
		}
		
		private void MenuItem171_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
