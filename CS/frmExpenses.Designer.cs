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
	partial class frmExpenses : System.Windows.Forms.Form
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
			this.ceAmount = new DevExpress.XtraEditors.CalcEdit();
			base.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmExpenses_FormClosed);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmExpenses_FormClosing);
			base.Load += new System.EventHandler(frmExpenses_Load);
			this.ceAmount.EditValueChanged += new System.EventHandler(this.ceAmount_EditValueChanged);
			this.leexpenses = new DevExpress.XtraEditors.LookUpEdit();
			this.deexpDate = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.txtRemarks = new DevExpress.XtraEditors.TextEdit();
			this.txtRemarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarks_KeyPress);
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			((System.ComponentModel.ISupportInitialize) this.ceAmount.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leexpenses.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deexpDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deexpDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.txtRemarks.Properties).BeginInit();
			this.SuspendLayout();
			//
			//ceAmount
			//
			this.ceAmount.EnterMoveNextControl = true;
			this.ceAmount.Location = new System.Drawing.Point(121, 107);
			this.ceAmount.Name = "ceAmount";
			this.ceAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceAmount.Properties.Appearance.Options.UseFont = true;
			this.ceAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceAmount.Properties.DisplayFormat.FormatString = "N2";
			this.ceAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceAmount.Properties.EditFormat.FormatString = "N2";
			this.ceAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceAmount.Size = new System.Drawing.Size(113, 26);
			this.ceAmount.TabIndex = 2;
			//
			//leexpenses
			//
			this.leexpenses.EnterMoveNextControl = true;
			this.leexpenses.Location = new System.Drawing.Point(121, 66);
			this.leexpenses.Name = "leexpenses";
			this.leexpenses.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leexpenses.Properties.Appearance.Options.UseFont = true;
			this.leexpenses.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leexpenses.Properties.AppearanceDropDown.Options.UseFont = true;
			this.leexpenses.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leexpenses.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.leexpenses.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leexpenses.Properties.AppearanceFocused.Options.UseFont = true;
			this.leexpenses.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.leexpenses.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leexpenses.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("expenseid", "expenseid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("expdesc", "Kind")});
			this.leexpenses.Properties.DropDownRows = 15;
			this.leexpenses.Properties.NullText = "";
			this.leexpenses.Size = new System.Drawing.Size(318, 26);
			this.leexpenses.TabIndex = 1;
			this.leexpenses.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters";
			//
			//deexpDate
			//
			this.deexpDate.EditValue = null;
			this.deexpDate.EnterMoveNextControl = true;
			this.deexpDate.Location = new System.Drawing.Point(121, 25);
			this.deexpDate.Name = "deexpDate";
			this.deexpDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.deexpDate.Properties.Appearance.Options.UseFont = true;
			this.deexpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deexpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deexpDate.Size = new System.Drawing.Size(113, 26);
			this.deexpDate.TabIndex = 0;
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(52, 114);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(63, 19);
			this.LabelControl6.TabIndex = 9;
			this.LabelControl6.Text = "Amount:";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(11, 73);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(104, 19);
			this.LabelControl2.TabIndex = 12;
			this.LabelControl2.Text = "Expense Type:";
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(77, 32);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(38, 19);
			this.LabelControl1.TabIndex = 13;
			this.LabelControl1.Text = "Date:";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.txtRemarks);
			this.GroupControl1.Controls.Add(this.LabelControl3);
			this.GroupControl1.Controls.Add(this.ceAmount);
			this.GroupControl1.Controls.Add(this.leexpenses);
			this.GroupControl1.Controls.Add(this.deexpDate);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl2);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(12, 12);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(547, 197);
			this.GroupControl1.TabIndex = 15;
			//
			//txtRemarks
			//
			this.txtRemarks.Location = new System.Drawing.Point(121, 148);
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtRemarks.Properties.Appearance.Options.UseFont = true;
			this.txtRemarks.Size = new System.Drawing.Size(407, 26);
			this.txtRemarks.TabIndex = 3;
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(52, 155);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(60, 19);
			this.LabelControl3.TabIndex = 14;
			this.LabelControl3.Text = "Remark:";
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(464, 224);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 29);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "C&lose";
			//
			//btnCancel
			//
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(237, 224);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(95, 29);
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "&Cancel";
			//
			//btnSave
			//
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(126, 224);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(95, 29);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "&Save";
			//
			//btnNew
			//
			this.btnNew.Location = new System.Drawing.Point(13, 224);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(95, 29);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "&New";
			//
			//frmExpenses
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 270);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Name = "frmExpenses";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Expenses Entry Form";
			((System.ComponentModel.ISupportInitialize) this.ceAmount.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leexpenses.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deexpDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deexpDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.txtRemarks.Properties).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraEditors.CalcEdit ceAmount;
		internal DevExpress.XtraEditors.LookUpEdit leexpenses;
		internal DevExpress.XtraEditors.DateEdit deexpDate;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraEditors.TextEdit txtRemarks;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
	}
	
}
