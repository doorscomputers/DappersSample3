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


//Imports KellermanSoftware.NetDataAccessLayer
namespace DoorsPOS.WinApp
{
	public class frmAbout : System.Windows.Forms.Form
	{
		
		
#region  Windows Form Designer generated code
		
		public frmAbout()
		{
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			//Add any initialization after the InitializeComponent() call
			
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
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal DevExpress.XtraEditors.CalcEdit CalcEdit1;
		internal DevExpress.XtraEditors.LookUpEdit LookUpEdit1;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.Label lblLogin;
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(frmAbout_Load);
			this.lblLogin = new System.Windows.Forms.Label();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.CalcEdit1 = new DevExpress.XtraEditors.CalcEdit();
			this.LookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.CalcEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.LookUpEdit1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Your Login:";
			//
			//lblLogin
			//
			this.lblLogin.Location = new System.Drawing.Point(112, 8);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(328, 23);
			this.lblLogin.TabIndex = 1;
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(126, 78);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(235, 66);
			this.DataGridView1.TabIndex = 2;
			//
			//CalcEdit1
			//
			this.CalcEdit1.Location = new System.Drawing.Point(439, 66);
			this.CalcEdit1.Name = "CalcEdit1";
			this.CalcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.CalcEdit1.Size = new System.Drawing.Size(115, 20);
			this.CalcEdit1.TabIndex = 3;
			//
			//LookUpEdit1
			//
			this.LookUpEdit1.Location = new System.Drawing.Point(553, 117);
			this.LookUpEdit1.Name = "LookUpEdit1";
			this.LookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.LookUpEdit1.Size = new System.Drawing.Size(191, 20);
			this.LookUpEdit1.TabIndex = 4;
			//
			//GridControl1
			//
			this.GridControl1.Location = new System.Drawing.Point(580, 22);
			this.GridControl1.MainView = this.GridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(250, 81);
			this.GridControl1.TabIndex = 5;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			//
			//GridView1
			//
			this.GridView1.GridControl = this.GridControl1;
			this.GridView1.Name = "GridView1";
			//
			//frmAbout
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(901, 404);
			this.Controls.Add(this.GridControl1);
			this.Controls.Add(this.LookUpEdit1);
			this.Controls.Add(this.CalcEdit1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.Label1);
			this.Name = "frmAbout";
			this.Text = "About...";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.CalcEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.LookUpEdit1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			this.ResumeLayout(false);
			
		}
		
#endregion
		
		private void frmAbout_Load(System.Object sender, System.EventArgs e)
		{
			
			
			
		}
	}
	
}
