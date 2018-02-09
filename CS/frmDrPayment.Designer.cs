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
	partial class frmDrPayment : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgPayment = new System.Windows.Forms.DataGridView();
			base.Load += new System.EventHandler(frmDrPayment_Load);
			this.dgPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPayment_CellClick);
			this.drid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.drinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.drbal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.ledrs = new DevExpress.XtraEditors.LookUpEdit();
			this.ledrs.GotFocus += new System.EventHandler(this.ledrs_GotFocus);
			this.ledrs.LostFocus += new System.EventHandler(this.ledrs_LostFocus);
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.ceAmount = new DevExpress.XtraEditors.CalcEdit();
			this.ceAmount.Leave += new System.EventHandler(this.ceAmount_Leave);
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtTotInv = new DevExpress.XtraEditors.TextEdit();
			this.txtTotInv.GotFocus += new System.EventHandler(this.txtTotInv_GotFocus);
			this.txtTotInv.LostFocus += new System.EventHandler(this.txtTotInv_LostFocus);
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.txtChkNo = new DevExpress.XtraEditors.TextEdit();
			this.txtChkNo.LostFocus += new System.EventHandler(this.txtChkNo_LostFocus);
			this.txtremarks = new DevExpress.XtraEditors.TextEdit();
			this.txtremarks.LostFocus += new System.EventHandler(this.txtremarks_LostFocus);
			this.txtSupcode = new DevExpress.XtraEditors.TextEdit();
			this.txtbankid = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.deDatePaid = new DevExpress.XtraEditors.DateEdit();
			this.deChkDate = new DevExpress.XtraEditors.DateEdit();
			this.ceAmntPd = new DevExpress.XtraEditors.CalcEdit();
			this.leBank = new DevExpress.XtraEditors.LookUpEdit();
			this.leBank.LostFocus += new System.EventHandler(this.leBank_LostFocus);
			this.leSupplier = new DevExpress.XtraEditors.LookUpEdit();
			this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
			((System.ComponentModel.ISupportInitialize) this.dgPayment).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ledrs.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceAmount.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtTotInv.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtChkNo.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtremarks.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupcode.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtbankid.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deDatePaid.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deDatePaid.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deChkDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deChkDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceAmntPd.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leBank.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl2).BeginInit();
			this.GroupControl2.SuspendLayout();
			this.SuspendLayout();
			//
			//dgPayment
			//
			this.dgPayment.AllowUserToAddRows = false;
			this.dgPayment.AllowUserToDeleteRows = false;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.drid, this.drinv, this.drbal});
			this.dgPayment.Location = new System.Drawing.Point(0, 279);
			this.dgPayment.MultiSelect = false;
			this.dgPayment.Name = "dgPayment";
			this.dgPayment.ReadOnly = true;
			DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgPayment.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
			this.dgPayment.Size = new System.Drawing.Size(761, 182);
			this.dgPayment.TabIndex = 5;
			//
			//drid
			//
			this.drid.HeaderText = "drid";
			this.drid.Name = "drid";
			this.drid.ReadOnly = true;
			this.drid.Visible = false;
			//
			//drinv
			//
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.drinv.DefaultCellStyle = DataGridViewCellStyle2;
			this.drinv.HeaderText = "Invoice #";
			this.drinv.Name = "drinv";
			this.drinv.ReadOnly = true;
			this.drinv.Width = 150;
			//
			//drbal
			//
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.Format = "N2";
			DataGridViewCellStyle3.NullValue = "0";
			this.drbal.DefaultCellStyle = DataGridViewCellStyle3;
			this.drbal.HeaderText = "Balance";
			this.drbal.Name = "drbal";
			this.drbal.ReadOnly = true;
			this.drbal.Width = 150;
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl8.Location = new System.Drawing.Point(8, 40);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(81, 19);
			this.LabelControl8.TabIndex = 31;
			this.LabelControl8.Text = "Invoice No.";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.ledrs);
			this.GroupControl1.Controls.Add(this.btnAdd);
			this.GroupControl1.Controls.Add(this.ceAmount);
			this.GroupControl1.Controls.Add(this.LabelControl9);
			this.GroupControl1.Controls.Add(this.LabelControl8);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(0, 197);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(760, 76);
			this.GroupControl1.TabIndex = 7;
			this.GroupControl1.Text = "Payment Invoices and Amount";
			//
			//ledrs
			//
			this.ledrs.EnterMoveNextControl = true;
			this.ledrs.Location = new System.Drawing.Point(93, 33);
			this.ledrs.Name = "ledrs";
			this.ledrs.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ledrs.Properties.Appearance.Options.UseFont = true;
			this.ledrs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ledrs.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("drinv", "Invoice#"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("drdate", "Inv. Date"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("drdue", "Due Date"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("drbal", "Balance")});
			this.ledrs.Size = new System.Drawing.Size(339, 26);
			this.ledrs.TabIndex = 0;
			this.ledrs.ToolTip = "Select the Invoice # to be paid here.";
			//
			//btnAdd
			//
			this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnAdd.Appearance.Options.UseFont = true;
			this.btnAdd.Location = new System.Drawing.Point(676, 33);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(70, 26);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "&Add";
			this.btnAdd.ToolTip = "Click Add to Add the Invoice and Paid AMount on the List";
			//
			//ceAmount
			//
			this.ceAmount.EnterMoveNextControl = true;
			this.ceAmount.Location = new System.Drawing.Point(536, 33);
			this.ceAmount.Name = "ceAmount";
			this.ceAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceAmount.Properties.Appearance.Options.UseFont = true;
			this.ceAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceAmount.Properties.EditFormat.FormatString = "N2";
			this.ceAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceAmount.Properties.Mask.BeepOnError = true;
			this.ceAmount.Properties.Mask.EditMask = "n2";
			this.ceAmount.Size = new System.Drawing.Size(132, 26);
			this.ceAmount.TabIndex = 1;
			this.ceAmount.ToolTip = "Type Amount Paid for the Invoice at the Left";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl9.Location = new System.Drawing.Point(438, 40);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(92, 19);
			this.LabelControl9.TabIndex = 30;
			this.LabelControl9.Text = "Amount Paid";
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl10.Location = new System.Drawing.Point(478, 479);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(92, 19);
			this.LabelControl10.TabIndex = 1;
			this.LabelControl10.Text = "Total Invoice";
			//
			//txtTotInv
			//
			this.txtTotInv.Location = new System.Drawing.Point(586, 472);
			this.txtTotInv.Name = "txtTotInv";
			this.txtTotInv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtTotInv.Properties.Appearance.Options.UseFont = true;
			this.txtTotInv.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtTotInv.Properties.AppearanceDisabled.Options.UseFont = true;
			this.txtTotInv.Properties.AppearanceDisabled.Options.UseTextOptions = true;
			this.txtTotInv.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.txtTotInv.Size = new System.Drawing.Size(160, 26);
			this.txtTotInv.TabIndex = 8;
			//
			//btnNew
			//
			this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.Location = new System.Drawing.Point(4, 467);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(92, 31);
			this.btnNew.TabIndex = 9;
			this.btnNew.Text = "&New";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(109, 467);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(92, 31);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "&Save";
			//
			//btnCancel
			//
			this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(214, 467);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(92, 31);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "&Cancel";
			//
			//txtChkNo
			//
			this.txtChkNo.EnterMoveNextControl = true;
			this.txtChkNo.Location = new System.Drawing.Point(98, 72);
			this.txtChkNo.Name = "txtChkNo";
			this.txtChkNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtChkNo.Properties.Appearance.Options.UseFont = true;
			this.txtChkNo.Size = new System.Drawing.Size(187, 26);
			this.txtChkNo.TabIndex = 3;
			//
			//txtremarks
			//
			this.txtremarks.Enabled = false;
			this.txtremarks.EnterMoveNextControl = true;
			this.txtremarks.Location = new System.Drawing.Point(144, 154);
			this.txtremarks.Name = "txtremarks";
			this.txtremarks.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtremarks.Properties.Appearance.Options.UseFont = true;
			this.txtremarks.Properties.MaxLength = 50;
			this.txtremarks.Size = new System.Drawing.Size(608, 26);
			this.txtremarks.TabIndex = 60;
			//
			//txtSupcode
			//
			this.txtSupcode.EnterMoveNextControl = true;
			this.txtSupcode.Location = new System.Drawing.Point(171, 65);
			this.txtSupcode.Name = "txtSupcode";
			this.txtSupcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtSupcode.Properties.Appearance.Options.UseFont = true;
			this.txtSupcode.Properties.MaxLength = 50;
			this.txtSupcode.Size = new System.Drawing.Size(185, 26);
			this.txtSupcode.TabIndex = 0;
			this.txtSupcode.Visible = false;
			//
			//txtbankid
			//
			this.txtbankid.EnterMoveNextControl = true;
			this.txtbankid.Location = new System.Drawing.Point(541, 65);
			this.txtbankid.Name = "txtbankid";
			this.txtbankid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtbankid.Properties.Appearance.Options.UseFont = true;
			this.txtbankid.Properties.MaxLength = 50;
			this.txtbankid.Size = new System.Drawing.Size(185, 26);
			this.txtbankid.TabIndex = 0;
			this.txtbankid.Visible = false;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(23, 40);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(67, 19);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Date Paid";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(541, 40);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(90, 19);
			this.LabelControl3.TabIndex = 1;
			this.LabelControl3.Text = "Cheque Date";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl4.Location = new System.Drawing.Point(7, 79);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(83, 19);
			this.LabelControl4.TabIndex = 1;
			this.LabelControl4.Text = "Cheque No.";
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(331, 79);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(34, 19);
			this.LabelControl7.TabIndex = 1;
			this.LabelControl7.Text = "Bank";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(32, 118);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(58, 19);
			this.LabelControl6.TabIndex = 1;
			this.LabelControl6.Text = "Supplier";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(233, 40);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(133, 19);
			this.LabelControl2.TabIndex = 1;
			this.LabelControl2.Text = "Total Amount Paid";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(13, 157);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(125, 19);
			this.LabelControl5.TabIndex = 1;
			this.LabelControl5.Text = "Amount in Words";
			//
			//deDatePaid
			//
			this.deDatePaid.EditValue = null;
			this.deDatePaid.EnterMoveNextControl = true;
			this.deDatePaid.Location = new System.Drawing.Point(98, 33);
			this.deDatePaid.Name = "deDatePaid";
			this.deDatePaid.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.deDatePaid.Properties.Appearance.Options.UseFont = true;
			this.deDatePaid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deDatePaid.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deDatePaid.Size = new System.Drawing.Size(119, 26);
			this.deDatePaid.TabIndex = 0;
			//
			//deChkDate
			//
			this.deChkDate.EditValue = null;
			this.deChkDate.EnterMoveNextControl = true;
			this.deChkDate.Location = new System.Drawing.Point(637, 33);
			this.deChkDate.Name = "deChkDate";
			this.deChkDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.deChkDate.Properties.Appearance.Options.UseFont = true;
			this.deChkDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deChkDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deChkDate.Size = new System.Drawing.Size(119, 26);
			this.deChkDate.TabIndex = 2;
			//
			//ceAmntPd
			//
			this.ceAmntPd.EnterMoveNextControl = true;
			this.ceAmntPd.Location = new System.Drawing.Point(372, 33);
			this.ceAmntPd.Name = "ceAmntPd";
			this.ceAmntPd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceAmntPd.Properties.Appearance.Options.UseFont = true;
			this.ceAmntPd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceAmntPd.Properties.DisplayFormat.FormatString = "N2";
			this.ceAmntPd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceAmntPd.Properties.Mask.BeepOnError = true;
			this.ceAmntPd.Properties.Mask.EditMask = "n2";
			this.ceAmntPd.Size = new System.Drawing.Size(149, 26);
			this.ceAmntPd.TabIndex = 1;
			//
			//leBank
			//
			this.leBank.EnterMoveNextControl = true;
			this.leBank.Location = new System.Drawing.Point(372, 72);
			this.leBank.Name = "leBank";
			this.leBank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leBank.Properties.Appearance.Options.UseFont = true;
			this.leBank.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leBank.Properties.AppearanceDropDown.Options.UseFont = true;
			this.leBank.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leBank.Properties.AppearanceDropDownHeader.Options.UseFont = true;
			this.leBank.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leBank.Properties.AppearanceFocused.Options.UseFont = true;
			this.leBank.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
			this.leBank.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leBank.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bankid", "bankid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("bank", "Bank"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("accountno", "Account No.")});
			this.leBank.Properties.DropDownRows = 8;
			this.leBank.Properties.NullText = "";
			this.leBank.Size = new System.Drawing.Size(384, 26);
			this.leBank.TabIndex = 4;
			this.leBank.ToolTip = "Select the Bank name by lclicking the dropdown arrow or by typing some characters" + 
				"";
			//
			//leSupplier
			//
			this.leSupplier.EnterMoveNextControl = true;
			this.leSupplier.Location = new System.Drawing.Point(98, 111);
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
			this.leSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "supplier")});
			this.leSupplier.Properties.DropDownRows = 15;
			this.leSupplier.Properties.NullText = "";
			this.leSupplier.Size = new System.Drawing.Size(654, 26);
			this.leSupplier.TabIndex = 5;
			this.leSupplier.ToolTip = "Click the dropdown arrow to display suppliers list or type a few characters";
			//
			//GroupControl2
			//
			this.GroupControl2.Controls.Add(this.deDatePaid);
			this.GroupControl2.Controls.Add(this.txtChkNo);
			this.GroupControl2.Controls.Add(this.txtremarks);
			this.GroupControl2.Controls.Add(this.txtSupcode);
			this.GroupControl2.Controls.Add(this.txtbankid);
			this.GroupControl2.Controls.Add(this.LabelControl1);
			this.GroupControl2.Controls.Add(this.leSupplier);
			this.GroupControl2.Controls.Add(this.LabelControl3);
			this.GroupControl2.Controls.Add(this.leBank);
			this.GroupControl2.Controls.Add(this.LabelControl4);
			this.GroupControl2.Controls.Add(this.LabelControl7);
			this.GroupControl2.Controls.Add(this.ceAmntPd);
			this.GroupControl2.Controls.Add(this.LabelControl6);
			this.GroupControl2.Controls.Add(this.deChkDate);
			this.GroupControl2.Controls.Add(this.LabelControl2);
			this.GroupControl2.Controls.Add(this.LabelControl5);
			this.GroupControl2.Location = new System.Drawing.Point(-1, 2);
			this.GroupControl2.Name = "GroupControl2";
			this.GroupControl2.Size = new System.Drawing.Size(761, 191);
			this.GroupControl2.TabIndex = 10;
			this.GroupControl2.Text = "Payment Header";
			//
			//frmDrPayment
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 507);
			this.Controls.Add(this.GroupControl2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtTotInv);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.dgPayment);
			this.Controls.Add(this.LabelControl10);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDrPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Payment";
			((System.ComponentModel.ISupportInitialize) this.dgPayment).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ledrs.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceAmount.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtTotInv.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtChkNo.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtremarks.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupcode.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtbankid.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deDatePaid.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deDatePaid.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deChkDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deChkDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceAmntPd.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leBank.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl2).EndInit();
			this.GroupControl2.ResumeLayout(false);
			this.GroupControl2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.DataGridView dgPayment;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton btnAdd;
		internal DevExpress.XtraEditors.CalcEdit ceAmount;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.TextEdit txtTotInv;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.LookUpEdit ledrs;
		internal DevExpress.XtraEditors.TextEdit txtChkNo;
		internal DevExpress.XtraEditors.TextEdit txtremarks;
		internal DevExpress.XtraEditors.TextEdit txtSupcode;
		internal DevExpress.XtraEditors.TextEdit txtbankid;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.DateEdit deDatePaid;
		internal DevExpress.XtraEditors.DateEdit deChkDate;
		internal DevExpress.XtraEditors.CalcEdit ceAmntPd;
		internal DevExpress.XtraEditors.LookUpEdit leBank;
		internal DevExpress.XtraEditors.LookUpEdit leSupplier;
		internal DevExpress.XtraEditors.GroupControl GroupControl2;
		internal System.Windows.Forms.DataGridViewTextBoxColumn drid;
		internal System.Windows.Forms.DataGridViewTextBoxColumn drinv;
		internal System.Windows.Forms.DataGridViewTextBoxColumn drbal;
	}
	
}
