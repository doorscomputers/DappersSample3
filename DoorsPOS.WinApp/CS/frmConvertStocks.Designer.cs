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
	partial class frmConvertStocks : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmConvertStocks_Load);
			this.btnItemSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
			this.txtItem = new System.Windows.Forms.TextBox();
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceQty_KeyPress);
			this.ceQty.LostFocus += new System.EventHandler(this.ceQty_LostFocus);
			this.deBoDate = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.cePcs = new DevExpress.XtraEditors.CalcEdit();
			this.ceInner = new DevExpress.XtraEditors.CalcEdit();
			this.txtstckid2 = new System.Windows.Forms.TextBox();
			this.btnItemsearch2 = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemsearch2.Click += new System.EventHandler(this.btnItemsearch2_Click);
			this.txtitem2 = new System.Windows.Forms.TextBox();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			this.LayoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter();
			this.ceAvlbl = new DevExpress.XtraEditors.CalcEdit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.cePcs.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceInner.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceAvlbl.Properties).BeginInit();
			this.SuspendLayout();
			//
			//txtStckId
			//
			this.txtStckId.Location = new System.Drawing.Point(538, 73);
			this.txtStckId.Name = "txtStckId";
			this.txtStckId.Size = new System.Drawing.Size(100, 20);
			this.txtStckId.TabIndex = 21;
			this.txtStckId.Visible = false;
			//
			//btnItemSearch
			//
			this.btnItemSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemSearch.Appearance.Options.UseFont = true;
			this.btnItemSearch.Location = new System.Drawing.Point(487, 72);
			this.btnItemSearch.Name = "btnItemSearch";
			this.btnItemSearch.Size = new System.Drawing.Size(27, 25);
			this.btnItemSearch.TabIndex = 3;
			this.btnItemSearch.Text = "&I...";
			this.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I";
			//
			//txtItem
			//
			this.txtItem.Enabled = false;
			this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtItem.Location = new System.Drawing.Point(94, 73);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(389, 26);
			this.txtItem.TabIndex = 19;
			this.txtItem.TabStop = false;
			//
			//ceQty
			//
			this.ceQty.EnterMoveNextControl = true;
			this.ceQty.Location = new System.Drawing.Point(94, 196);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Size = new System.Drawing.Size(113, 26);
			this.ceQty.TabIndex = 4;
			//
			//deBoDate
			//
			this.deBoDate.EditValue = null;
			this.deBoDate.EnterMoveNextControl = true;
			this.deBoDate.Location = new System.Drawing.Point(92, 25);
			this.deBoDate.Name = "deBoDate";
			this.deBoDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.deBoDate.Properties.Appearance.Options.UseFont = true;
			this.deBoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Size = new System.Drawing.Size(152, 26);
			this.deBoDate.TabIndex = 1;
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(214, 203);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(204, 19);
			this.LabelControl7.TabIndex = 8;
			this.LabelControl7.Text = "* Qty to be Converted to Pcs";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(26, 203);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(66, 19);
			this.LabelControl6.TabIndex = 9;
			this.LabelControl6.Text = "Quantity:";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(24, 78);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(68, 19);
			this.LabelControl5.TabIndex = 11;
			this.LabelControl5.Text = "I t e m 1:";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl4.Location = new System.Drawing.Point(48, 32);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(38, 19);
			this.LabelControl4.TabIndex = 13;
			this.LabelControl4.Text = "Date:";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.ceAvlbl);
			this.GroupControl1.Controls.Add(this.LabelControl2);
			this.GroupControl1.Controls.Add(this.cePcs);
			this.GroupControl1.Controls.Add(this.ceInner);
			this.GroupControl1.Controls.Add(this.txtstckid2);
			this.GroupControl1.Controls.Add(this.btnItemsearch2);
			this.GroupControl1.Controls.Add(this.txtitem2);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Controls.Add(this.txtStckId);
			this.GroupControl1.Controls.Add(this.btnItemSearch);
			this.GroupControl1.Controls.Add(this.txtItem);
			this.GroupControl1.Controls.Add(this.ceQty);
			this.GroupControl1.Controls.Add(this.deBoDate);
			this.GroupControl1.Controls.Add(this.LabelControl7);
			this.GroupControl1.Controls.Add(this.LabelControl3);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl5);
			this.GroupControl1.Controls.Add(this.LabelControl4);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(12, 4);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(650, 284);
			this.GroupControl1.TabIndex = 15;
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(18, 161);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(74, 19);
			this.LabelControl2.TabIndex = 28;
			this.LabelControl2.Text = "Inner Qty:";
			//
			//cePcs
			//
			this.cePcs.Enabled = false;
			this.cePcs.Location = new System.Drawing.Point(94, 239);
			this.cePcs.Name = "cePcs";
			this.cePcs.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cePcs.Properties.Appearance.Options.UseFont = true;
			this.cePcs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cePcs.Size = new System.Drawing.Size(113, 26);
			this.cePcs.TabIndex = 27;
			this.cePcs.TabStop = false;
			//
			//ceInner
			//
			this.ceInner.Enabled = false;
			this.ceInner.Location = new System.Drawing.Point(94, 154);
			this.ceInner.Name = "ceInner";
			this.ceInner.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceInner.Properties.Appearance.Options.UseFont = true;
			this.ceInner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceInner.Size = new System.Drawing.Size(113, 26);
			this.ceInner.TabIndex = 26;
			this.ceInner.TabStop = false;
			//
			//txtstckid2
			//
			this.txtstckid2.Location = new System.Drawing.Point(538, 121);
			this.txtstckid2.Name = "txtstckid2";
			this.txtstckid2.Size = new System.Drawing.Size(100, 20);
			this.txtstckid2.TabIndex = 25;
			this.txtstckid2.Visible = false;
			//
			//btnItemsearch2
			//
			this.btnItemsearch2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemsearch2.Appearance.Options.UseFont = true;
			this.btnItemsearch2.Location = new System.Drawing.Point(487, 113);
			this.btnItemsearch2.Name = "btnItemsearch2";
			this.btnItemsearch2.Size = new System.Drawing.Size(27, 25);
			this.btnItemsearch2.TabIndex = 24;
			this.btnItemsearch2.Text = "&I...";
			this.btnItemsearch2.ToolTip = "Click this bvutton to search for items OR Press Alt+I";
			//
			//txtitem2
			//
			this.txtitem2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtitem2.Location = new System.Drawing.Point(94, 112);
			this.txtitem2.Name = "txtitem2";
			this.txtitem2.Size = new System.Drawing.Size(389, 26);
			this.txtitem2.TabIndex = 23;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(24, 119);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(68, 19);
			this.LabelControl1.TabIndex = 22;
			this.LabelControl1.Text = "I t e m 2:";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(45, 246);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(49, 19);
			this.LabelControl3.TabIndex = 9;
			this.LabelControl3.Text = "Pieces:";
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(562, 305);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 29);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "C&lose";
			//
			//btnCancel
			//
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(244, 305);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 29);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "&Cancel";
			//
			//btnSave
			//
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(133, 305);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 29);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "&Save";
			//
			//btnNew
			//
			this.btnNew.Location = new System.Drawing.Point(20, 305);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(95, 29);
			this.btnNew.TabIndex = 11;
			this.btnNew.Text = "&New";
			//
			//ceAvlbl
			//
			this.ceAvlbl.Location = new System.Drawing.Point(538, 163);
			this.ceAvlbl.Name = "ceAvlbl";
			this.ceAvlbl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceAvlbl.Size = new System.Drawing.Size(100, 20);
			this.ceAvlbl.TabIndex = 29;
			this.ceAvlbl.Visible = false;
			//
			//frmConvertStocks
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 348);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmConvertStocks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Convert Stocks to Pieces Entry Form";
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.cePcs.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceInner.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceAvlbl.Properties).EndInit();
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
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraLayout.Converter.LayoutConverter LayoutConverter1;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal System.Windows.Forms.TextBox txtstckid2;
		internal DevExpress.XtraEditors.SimpleButton btnItemsearch2;
		internal System.Windows.Forms.TextBox txtitem2;
		internal DevExpress.XtraEditors.CalcEdit cePcs;
		internal DevExpress.XtraEditors.CalcEdit ceInner;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.CalcEdit ceAvlbl;
	}
	
}
