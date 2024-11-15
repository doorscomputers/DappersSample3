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


namespace DoorsPOS.WinApp
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmManualInv : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.txtStckId = new System.Windows.Forms.TextBox();
			this.btnItemSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
			this.txtItem = new System.Windows.Forms.TextBox();
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceQty_KeyPress);
			this.deBoDate = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			this.SuspendLayout();
			//
			//txtStckId
			//
			this.txtStckId.Location = new System.Drawing.Point(538, 77);
			this.txtStckId.Name = "txtStckId";
			this.txtStckId.Size = new System.Drawing.Size(100, 20);
			this.txtStckId.TabIndex = 21;
			this.txtStckId.TabStop = false;
			this.txtStckId.Visible = false;
			//
			//btnItemSearch
			//
			this.btnItemSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemSearch.Appearance.Options.UseFont = true;
			this.btnItemSearch.Location = new System.Drawing.Point(487, 76);
			this.btnItemSearch.Name = "btnItemSearch";
			this.btnItemSearch.Size = new System.Drawing.Size(27, 25);
			this.btnItemSearch.TabIndex = 2;
			this.btnItemSearch.Text = "&I...";
			this.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I";
			//
			//txtItem
			//
			this.txtItem.Enabled = false;
			this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtItem.Location = new System.Drawing.Point(83, 77);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(398, 26);
			this.txtItem.TabIndex = 19;
			this.txtItem.TabStop = false;
			//
			//ceQty
			//
			this.ceQty.EnterMoveNextControl = true;
			this.ceQty.Location = new System.Drawing.Point(154, 121);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Size = new System.Drawing.Size(113, 26);
			this.ceQty.TabIndex = 3;
			//
			//deBoDate
			//
			this.deBoDate.EditValue = null;
			this.deBoDate.EnterMoveNextControl = true;
			this.deBoDate.Location = new System.Drawing.Point(83, 25);
			this.deBoDate.Name = "deBoDate";
			this.deBoDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.deBoDate.Properties.Appearance.Options.UseFont = true;
			this.deBoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Size = new System.Drawing.Size(113, 26);
			this.deBoDate.TabIndex = 1;
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(273, 128);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(284, 19);
			this.LabelControl7.TabIndex = 8;
			this.LabelControl7.Text = "*Manually counted Qty from the shelves";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(18, 128);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(130, 19);
			this.LabelControl6.TabIndex = 9;
			this.LabelControl6.Text = "Qunatity Counted:";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(18, 82);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(59, 19);
			this.LabelControl5.TabIndex = 11;
			this.LabelControl5.Text = "I t e m :";
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(39, 32);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(38, 19);
			this.LabelControl1.TabIndex = 13;
			this.LabelControl1.Text = "Date:";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.txtStckId);
			this.GroupControl1.Controls.Add(this.btnItemSearch);
			this.GroupControl1.Controls.Add(this.txtItem);
			this.GroupControl1.Controls.Add(this.ceQty);
			this.GroupControl1.Controls.Add(this.deBoDate);
			this.GroupControl1.Controls.Add(this.LabelControl7);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl5);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(11, 12);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(650, 219);
			this.GroupControl1.TabIndex = 0;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(566, 237);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 29);
			this.btnClose.TabIndex = 13;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "C&lose";
			//
			//btnCancel
			//
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(248, 237);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 29);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "&Cancel";
			//
			//btnSave
			//
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(137, 237);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 29);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "&Save";
			//
			//btnNew
			//
			this.btnNew.Location = new System.Drawing.Point(24, 237);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(95, 29);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "&New";
			//
			//frmManualInv
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 274);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSave);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmManualInv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manual Inventory Entry Form";
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TextBox txtStckId;
		internal DevExpress.XtraEditors.SimpleButton btnItemSearch;
		internal System.Windows.Forms.TextBox txtItem;
		internal DevExpress.XtraEditors.CalcEdit ceQty;
		internal DevExpress.XtraEditors.DateEdit deBoDate;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
	}
	
}
