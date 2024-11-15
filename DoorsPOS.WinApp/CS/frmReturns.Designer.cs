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
	partial class frmReturns : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmReturns_Load);
			this.txtStckId = new System.Windows.Forms.TextBox();
			this.btnItemSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
			this.txtItem = new System.Windows.Forms.TextBox();
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.LostFocus += new System.EventHandler(this.ceQty_LostFocus);
			this.txtPrice = new DevExpress.XtraEditors.TextEdit();
			this.leSupplier = new DevExpress.XtraEditors.LookUpEdit();
			this.deBoDate = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
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
			this.LayoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtPrice.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deBoDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
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
			this.btnItemSearch.TabIndex = 2;
			this.btnItemSearch.Text = "&I...";
			this.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I";
			//
			//txtItem
			//
			this.txtItem.Enabled = false;
			this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtItem.Location = new System.Drawing.Point(83, 73);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(398, 26);
			this.txtItem.TabIndex = 19;
			this.txtItem.TabStop = false;
			//
			//ceQty
			//
			this.ceQty.EnterMoveNextControl = true;
			this.ceQty.Location = new System.Drawing.Point(83, 169);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Size = new System.Drawing.Size(113, 26);
			this.ceQty.TabIndex = 4;
			//
			//txtPrice
			//
			this.txtPrice.EnterMoveNextControl = true;
			this.txtPrice.Location = new System.Drawing.Point(83, 121);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtPrice.Properties.Appearance.Options.UseFont = true;
			this.txtPrice.Size = new System.Drawing.Size(113, 26);
			this.txtPrice.TabIndex = 3;
			//
			//leSupplier
			//
			this.leSupplier.EnterMoveNextControl = true;
			this.leSupplier.Location = new System.Drawing.Point(282, 25);
			this.leSupplier.Name = "leSupplier";
			this.leSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leSupplier.Properties.Appearance.Options.UseFont = true;
			this.leSupplier.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leSupplier.Properties.AppearanceDropDown.Options.UseFont = true;
			this.leSupplier.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leSupplier.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.leSupplier.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leSupplier.Properties.AppearanceFocused.Options.UseFont = true;
			this.leSupplier.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.leSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustID", "CustID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lastname", "lastname"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("middlename", "middlename"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("firstname", "firstname")});
			this.leSupplier.Properties.DropDownRows = 15;
			this.leSupplier.Properties.NullText = "";
			this.leSupplier.Size = new System.Drawing.Size(358, 26);
			this.leSupplier.TabIndex = 1;
			this.leSupplier.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters";
			//
			//deBoDate
			//
			this.deBoDate.EditValue = null;
			this.deBoDate.EnterMoveNextControl = true;
			this.deBoDate.Location = new System.Drawing.Point(83, 31);
			this.deBoDate.Name = "deBoDate";
			this.deBoDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.deBoDate.Properties.Appearance.Options.UseFont = true;
			this.deBoDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deBoDate.Size = new System.Drawing.Size(113, 26);
			this.deBoDate.TabIndex = 0;
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(212, 176);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(231, 19);
			this.LabelControl7.TabIndex = 8;
			this.LabelControl7.Text = "* Qty returned by the Customer.";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(11, 176);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(66, 19);
			this.LabelControl6.TabIndex = 9;
			this.LabelControl6.Text = "Qunatity:";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(37, 128);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(40, 19);
			this.LabelControl3.TabIndex = 10;
			this.LabelControl3.Text = "Price:";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(18, 78);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(59, 19);
			this.LabelControl5.TabIndex = 11;
			this.LabelControl5.Text = "I t e m :";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(202, 32);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(74, 19);
			this.LabelControl2.TabIndex = 12;
			this.LabelControl2.Text = "Customer:";
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
			this.GroupControl1.Controls.Add(this.txtPrice);
			this.GroupControl1.Controls.Add(this.leSupplier);
			this.GroupControl1.Controls.Add(this.deBoDate);
			this.GroupControl1.Controls.Add(this.LabelControl7);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl3);
			this.GroupControl1.Controls.Add(this.LabelControl5);
			this.GroupControl1.Controls.Add(this.LabelControl2);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(12, 12);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(650, 219);
			this.GroupControl1.TabIndex = 15;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(555, 237);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 29);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "C&lose";
			//
			//btnCancel
			//
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(237, 237);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 29);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "&Cancel";
			//
			//btnSave
			//
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(126, 237);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 29);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "&Save";
			//
			//btnNew
			//
			this.btnNew.Location = new System.Drawing.Point(13, 237);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(95, 29);
			this.btnNew.TabIndex = 1;
			this.btnNew.Text = "&New";
			//
			//frmReturns
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 272);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmReturns";
			this.Text = "Return Items Form";
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtPrice.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).EndInit();
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
		internal DevExpress.XtraEditors.TextEdit txtPrice;
		internal DevExpress.XtraEditors.LookUpEdit leSupplier;
		internal DevExpress.XtraEditors.DateEdit deBoDate;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraLayout.Converter.LayoutConverter LayoutConverter1;
	}
	
}
