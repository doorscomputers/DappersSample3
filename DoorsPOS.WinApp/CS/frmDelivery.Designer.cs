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
	partial class frmDelivery : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			base.Load += new System.EventHandler(frmDelivery_Load);
			this.LabelControl1.Click += new System.EventHandler(this.LabelControl1_Click);
			this.dedlvrydate = new DevExpress.XtraEditors.DateEdit();
			this.dedlvrydate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dedlvrydate_KeyPress);
			this.ceDays = new DevExpress.XtraEditors.CalcEdit();
			this.ceDays.LostFocus += new System.EventHandler(this.ceDays_LostFocus);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2.Click += new System.EventHandler(this.LabelControl2_Click);
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3.Click += new System.EventHandler(this.LabelControl3_Click);
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4.Click += new System.EventHandler(this.LabelControl4_Click);
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5.Click += new System.EventHandler(this.LabelControl5_Click);
			this.cmbType = new DevExpress.XtraEditors.ComboBoxEdit();
			this.deDue = new DevExpress.XtraEditors.DateEdit();
			this.drgrid = new System.Windows.Forms.DataGridView();
			this.drgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellClick);
			this.drgrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellEndEdit);
			this.drgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellContentClick);
			this.stckid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Free = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dscamnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8.Click += new System.EventHandler(this.LabelControl8_Click);
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.LostFocus += new System.EventHandler(this.ceQty_LostFocus);
			this.ceFree = new DevExpress.XtraEditors.CalcEdit();
			this.ceFree.LostFocus += new System.EventHandler(this.ceFree_LostFocus);
			this.ceCost = new DevExpress.XtraEditors.CalcEdit();
			this.ceCost.DoubleClick += new System.EventHandler(this.ceCost_DoubleClick);
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9.Click += new System.EventHandler(this.LabelControl9_Click);
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.btnAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdd_KeyDown);
			this.btnPost = new DevExpress.XtraEditors.SimpleButton();
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnRetrieve = new DevExpress.XtraEditors.SimpleButton();
			this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
			this.txtsum = new System.Windows.Forms.TextBox();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.btnItemSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
			this.txtStckid = new System.Windows.Forms.TextBox();
			this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
			this.btnSupSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnSupSearch.Click += new System.EventHandler(this.btnSupSearch_Click);
			this.txtSupcode = new System.Windows.Forms.TextBox();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.cediscamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cediscamnt.EditValueChanged += new System.EventHandler(this.cediscamnt_EditValueChanged);
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.txtGrand = new System.Windows.Forms.TextBox();
			this.DGRetrieve = new System.Windows.Forms.DataGridView();
			this.DGRetrieve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGRetrieve_KeyDown);
			this.DGRetrieve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRetrieve_CellContentClick);
			this.txtInv = new DevExpress.XtraEditors.TextEdit();
			this.txtInv.LostFocus += new System.EventHandler(this.txtInv_LostFocus);
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.ceAmountDisc = new DevExpress.XtraEditors.CalcEdit();
			this.ceAmountDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceAmountDisc_KeyDown);
			this.cePrcentDisc = new DevExpress.XtraEditors.CalcEdit();
			this.cePrcentDisc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cePrcentDisc_KeyDown);
			this.cePrcentDisc.EditValueChanged += new System.EventHandler(this.cePrcentDisc_EditValueChanged);
			this.deExpDate = new DevExpress.XtraEditors.DateEdit();
			this.deExpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.deExpDate_KeyDown);
			this.txtLotNo = new DevExpress.XtraEditors.TextEdit();
			this.leSupplier = new DevExpress.XtraEditors.LookUpEdit();
			this.leSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leSupplier_KeyPress);
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl16.Click += new System.EventHandler(this.LabelControl16_Click);
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl15.Click += new System.EventHandler(this.LabelControl15_Click);
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl14.Click += new System.EventHandler(this.LabelControl14_Click);
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl13.Click += new System.EventHandler(this.LabelControl13_Click);
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceDays.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmbType.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deDue.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deDue.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.drgrid).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceFree.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupplier.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cediscamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DGRetrieve).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtInv.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.ceAmountDisc.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cePrcentDisc.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deExpDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.deExpDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtLotNo.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).BeginInit();
			this.SuspendLayout();
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(12, 31);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(103, 19);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "&Date Delivered";
			//
			//dedlvrydate
			//
			this.dedlvrydate.EditValue = null;
			this.dedlvrydate.EnterMoveNextControl = true;
			this.dedlvrydate.Location = new System.Drawing.Point(121, 24);
			this.dedlvrydate.Name = "dedlvrydate";
			this.dedlvrydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.dedlvrydate.Properties.Appearance.Options.UseFont = true;
			this.dedlvrydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Size = new System.Drawing.Size(107, 26);
			this.dedlvrydate.TabIndex = 1;
			this.dedlvrydate.ToolTip = "Date of Delivery";
			//
			//ceDays
			//
			this.ceDays.EnterMoveNextControl = true;
			this.ceDays.Location = new System.Drawing.Point(837, 28);
			this.ceDays.Name = "ceDays";
			this.ceDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceDays.Properties.Appearance.Options.UseFont = true;
			this.ceDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceDays.Size = new System.Drawing.Size(45, 26);
			this.ceDays.TabIndex = 5;
			this.ceDays.ToolTip = "No of days the Supplier granted till due date";
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(232, 31);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(58, 19);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Supp&lier" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10));
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(554, 31);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(74, 19);
			this.LabelControl3.TabIndex = 0;
			this.LabelControl3.Text = "In&voice #:";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl4.Location = new System.Drawing.Point(885, 31);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(65, 19);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Text = "Du&e Date";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(748, 31);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(83, 19);
			this.LabelControl5.TabIndex = 0;
			this.LabelControl5.Text = "N&o. of Days";
			//
			//cmbType
			//
			this.cmbType.EditValue = "";
			this.cmbType.EnterMoveNextControl = true;
			this.cmbType.Location = new System.Drawing.Point(122, 56);
			this.cmbType.Name = "cmbType";
			this.cmbType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cmbType.Properties.Appearance.Options.UseFont = true;
			this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbType.Properties.Items.AddRange(new object[] {"COD", "I.S.", "Consignment"});
			this.cmbType.Size = new System.Drawing.Size(106, 26);
			this.cmbType.TabIndex = 25;
			this.cmbType.TabStop = false;
			this.cmbType.ToolTip = "COD,IS or Consignment";
			this.cmbType.Visible = false;
			//
			//deDue
			//
			this.deDue.EditValue = null;
			this.deDue.EnterMoveNextControl = true;
			this.deDue.Location = new System.Drawing.Point(955, 28);
			this.deDue.Name = "deDue";
			this.deDue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.deDue.Properties.Appearance.Options.UseFont = true;
			this.deDue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deDue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deDue.Size = new System.Drawing.Size(108, 26);
			this.deDue.TabIndex = 6;
			this.deDue.ToolTip = "Due date of the invoice the supplier gave";
			//
			//drgrid
			//
			this.drgrid.AllowUserToAddRows = false;
			this.drgrid.AllowUserToDeleteRows = false;
			this.drgrid.AllowUserToResizeRows = false;
			DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21;
			this.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.drgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.stckid, this.Item, this.Qty, this.Free, this.Price, this.Amount, this.ExpiryDate, this.LotNo, this.disc, this.dscamnt});
			DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.drgrid.DefaultCellStyle = DataGridViewCellStyle28;
			this.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.drgrid.Location = new System.Drawing.Point(7, 155);
			this.drgrid.MultiSelect = false;
			this.drgrid.Name = "drgrid";
			DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle29;
			DataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle30;
			this.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.drgrid.Size = new System.Drawing.Size(1067, 422);
			this.drgrid.TabIndex = 8;
			//
			//stckid
			//
			DataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.stckid.DefaultCellStyle = DataGridViewCellStyle22;
			this.stckid.HeaderText = "StockID";
			this.stckid.Name = "stckid";
			this.stckid.Visible = false;
			this.stckid.Width = 5;
			//
			//Item
			//
			DataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Item.DefaultCellStyle = DataGridViewCellStyle23;
			this.Item.HeaderText = "Item Description";
			this.Item.Name = "Item";
			this.Item.Width = 400;
			//
			//Qty
			//
			DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle24.Format = "N0";
			DataGridViewCellStyle24.NullValue = "0";
			this.Qty.DefaultCellStyle = DataGridViewCellStyle24;
			this.Qty.HeaderText = "Qty";
			this.Qty.Name = "Qty";
			//
			//Free
			//
			DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle25.Format = "N0";
			DataGridViewCellStyle25.NullValue = "0";
			this.Free.DefaultCellStyle = DataGridViewCellStyle25;
			this.Free.HeaderText = "Free";
			this.Free.Name = "Free";
			//
			//Price
			//
			DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle26.Format = "N2";
			DataGridViewCellStyle26.NullValue = "0";
			this.Price.DefaultCellStyle = DataGridViewCellStyle26;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Width = 200;
			//
			//Amount
			//
			DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle27.Format = "N2";
			DataGridViewCellStyle27.NullValue = "0";
			this.Amount.DefaultCellStyle = DataGridViewCellStyle27;
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			this.Amount.Width = 200;
			//
			//ExpiryDate
			//
			this.ExpiryDate.HeaderText = "Expiry Date";
			this.ExpiryDate.Name = "ExpiryDate";
			this.ExpiryDate.Visible = false;
			//
			//LotNo
			//
			this.LotNo.HeaderText = "Lot No";
			this.LotNo.Name = "LotNo";
			this.LotNo.Visible = false;
			//
			//disc
			//
			this.disc.HeaderText = "disc";
			this.disc.Name = "disc";
			this.disc.Visible = false;
			//
			//dscamnt
			//
			this.dscamnt.HeaderText = "dscamnt";
			this.dscamnt.Name = "dscamnt";
			this.dscamnt.Visible = false;
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(82, 77);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(33, 19);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "Item";
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(801, 70);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(30, 19);
			this.LabelControl7.TabIndex = 0;
			this.LabelControl7.Text = "&Free";
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl8.Location = new System.Drawing.Point(607, 74);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(25, 19);
			this.LabelControl8.TabIndex = 0;
			this.LabelControl8.Text = "&Qty";
			//
			//ceQty
			//
			this.ceQty.EnterMoveNextControl = true;
			this.ceQty.Location = new System.Drawing.Point(638, 67);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Size = new System.Drawing.Size(104, 26);
			this.ceQty.TabIndex = 9;
			this.ceQty.ToolTip = "Qty Delivered by the supplier ";
			//
			//ceFree
			//
			this.ceFree.EnterMoveNextControl = true;
			this.ceFree.Location = new System.Drawing.Point(837, 67);
			this.ceFree.Name = "ceFree";
			this.ceFree.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceFree.Properties.Appearance.Options.UseFont = true;
			this.ceFree.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceFree.Size = new System.Drawing.Size(46, 26);
			this.ceFree.TabIndex = 10;
			this.ceFree.ToolTip = "Number of free items the supplier gave as a promo or discount";
			//
			//ceCost
			//
			this.ceCost.EnterMoveNextControl = true;
			this.ceCost.Location = new System.Drawing.Point(955, 67);
			this.ceCost.Name = "ceCost";
			this.ceCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceCost.Properties.Appearance.Options.UseFont = true;
			this.ceCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceCost.Properties.Mask.BeepOnError = true;
			this.ceCost.Properties.Mask.EditMask = "n2";
			this.ceCost.Size = new System.Drawing.Size(110, 26);
			this.ceCost.TabIndex = 18;
			this.ceCost.TabStop = false;
			this.ceCost.ToolTip = "Cost of the item delivered";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl9.Location = new System.Drawing.Point(915, 70);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(34, 19);
			this.LabelControl9.TabIndex = 0;
			this.LabelControl9.Text = "Pri&ce";
			//
			//btnAdd
			//
			this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnAdd.Appearance.Options.UseFont = true;
			this.btnAdd.Location = new System.Drawing.Point(956, 109);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(107, 23);
			this.btnAdd.TabIndex = 15;
			this.btnAdd.Text = "&Add to List";
			this.btnAdd.ToolTip = "Add the item to the list of Deliveries Below.";
			//
			//btnPost
			//
			this.btnPost.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnPost.Appearance.Options.UseFont = true;
			this.btnPost.Enabled = false;
			this.btnPost.Location = new System.Drawing.Point(9, 580);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(102, 32);
			this.btnPost.TabIndex = 16;
			this.btnPost.Text = "&Post";
			this.btnPost.ToolTip = "Click this button to update the inventory and the Balance to be paid per supplier" + 
				"";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(362, 580);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 32);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "&Save";
			this.btnSave.ToolTip = "Save the List for later modification";
			//
			//btnRetrieve
			//
			this.btnRetrieve.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnRetrieve.Appearance.Options.UseFont = true;
			this.btnRetrieve.Enabled = false;
			this.btnRetrieve.Location = new System.Drawing.Point(487, 580);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(102, 32);
			this.btnRetrieve.TabIndex = 17;
			this.btnRetrieve.Text = "&Retrieve";
			this.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry";
			//
			//txtsum
			//
			this.txtsum.Enabled = false;
			this.txtsum.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F));
			this.txtsum.Location = new System.Drawing.Point(864, 583);
			this.txtsum.Name = "txtsum";
			this.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtsum.Size = new System.Drawing.Size(189, 29);
			this.txtsum.TabIndex = 20;
			this.txtsum.TabStop = false;
			this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl10.Location = new System.Drawing.Point(762, 593);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(86, 19);
			this.LabelControl10.TabIndex = 0;
			this.LabelControl10.Text = "SUB-TOTAL";
			//
			//txtItem
			//
			this.txtItem.Enabled = false;
			this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtItem.Location = new System.Drawing.Point(121, 70);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(426, 26);
			this.txtItem.TabIndex = 12;
			this.txtItem.TabStop = false;
			//
			//btnItemSearch
			//
			this.btnItemSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemSearch.Appearance.Options.UseFont = true;
			this.btnItemSearch.Location = new System.Drawing.Point(554, 68);
			this.btnItemSearch.Name = "btnItemSearch";
			this.btnItemSearch.Size = new System.Drawing.Size(27, 25);
			this.btnItemSearch.TabIndex = 7;
			this.btnItemSearch.Text = "&I...";
			this.btnItemSearch.ToolTip = "Click this bvutton to search for items OR Press Alt+I";
			//
			//txtStckid
			//
			this.txtStckid.Location = new System.Drawing.Point(461, 45);
			this.txtStckid.Name = "txtStckid";
			this.txtStckid.Size = new System.Drawing.Size(105, 20);
			this.txtStckid.TabIndex = 21;
			this.txtStckid.TabStop = false;
			this.txtStckid.Visible = false;
			//
			//txtSupplier
			//
			this.txtSupplier.EditValue = "";
			this.txtSupplier.Enabled = false;
			this.txtSupplier.Location = new System.Drawing.Point(294, 24);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtSupplier.Properties.Appearance.Options.UseFont = true;
			this.txtSupplier.Size = new System.Drawing.Size(222, 26);
			this.txtSupplier.TabIndex = 1;
			this.txtSupplier.TabStop = false;
			this.txtSupplier.ToolTip = "Supplier who delivered the goods";
			//
			//btnSupSearch
			//
			this.btnSupSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnSupSearch.Appearance.Options.UseFont = true;
			this.btnSupSearch.Location = new System.Drawing.Point(537, 24);
			this.btnSupSearch.Name = "btnSupSearch";
			this.btnSupSearch.Size = new System.Drawing.Size(10, 26);
			this.btnSupSearch.TabIndex = 3;
			this.btnSupSearch.TabStop = false;
			this.btnSupSearch.Text = "&U...";
			this.btnSupSearch.ToolTip = "Click this button to search for suppliers name. Or Press Alt+R";
			//
			//txtSupcode
			//
			this.txtSupcode.Location = new System.Drawing.Point(350, 44);
			this.txtSupcode.Name = "txtSupcode";
			this.txtSupcode.Size = new System.Drawing.Size(105, 20);
			this.txtSupcode.TabIndex = 22;
			this.txtSupcode.Visible = false;
			//
			//LabelControl11
			//
			this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl11.Location = new System.Drawing.Point(787, 628);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(61, 19);
			this.LabelControl11.TabIndex = 0;
			this.LabelControl11.Text = "Discount";
			//
			//cediscamnt
			//
			this.cediscamnt.Location = new System.Drawing.Point(864, 621);
			this.cediscamnt.Name = "cediscamnt";
			this.cediscamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cediscamnt.Properties.Appearance.Options.UseFont = true;
			this.cediscamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cediscamnt.Size = new System.Drawing.Size(189, 26);
			this.cediscamnt.TabIndex = 23;
			this.cediscamnt.ToolTip = "Discount Amount given by the supplier";
			//
			//LabelControl12
			//
			this.LabelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl12.Location = new System.Drawing.Point(738, 665);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(110, 19);
			this.LabelControl12.TabIndex = 0;
			this.LabelControl12.Text = "GRAND TOTAL";
			//
			//txtGrand
			//
			this.txtGrand.Enabled = false;
			this.txtGrand.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F));
			this.txtGrand.Location = new System.Drawing.Point(864, 655);
			this.txtGrand.Name = "txtGrand";
			this.txtGrand.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtGrand.Size = new System.Drawing.Size(189, 29);
			this.txtGrand.TabIndex = 19;
			this.txtGrand.TabStop = false;
			this.txtGrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//DGRetrieve
			//
			this.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGRetrieve.Location = new System.Drawing.Point(127, 155);
			this.DGRetrieve.Name = "DGRetrieve";
			this.DGRetrieve.ReadOnly = true;
			this.DGRetrieve.Size = new System.Drawing.Size(426, 165);
			this.DGRetrieve.TabIndex = 24;
			this.DGRetrieve.Visible = false;
			//
			//txtInv
			//
			this.txtInv.EditValue = "";
			this.txtInv.EnterMoveNextControl = true;
			this.txtInv.Location = new System.Drawing.Point(635, 24);
			this.txtInv.Name = "txtInv";
			this.txtInv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtInv.Properties.Appearance.Options.UseFont = true;
			this.txtInv.Size = new System.Drawing.Size(107, 26);
			this.txtInv.TabIndex = 4;
			this.txtInv.ToolTip = "Invoice number based on the Delivery Receipt";
			//
			//btnNew
			//
			this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.Location = new System.Drawing.Point(237, 580);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(102, 32);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "&New";
			this.btnNew.ToolTip = "Click this to enter a new delivery.";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.ceAmountDisc);
			this.GroupControl1.Controls.Add(this.cePrcentDisc);
			this.GroupControl1.Controls.Add(this.deExpDate);
			this.GroupControl1.Controls.Add(this.txtLotNo);
			this.GroupControl1.Controls.Add(this.leSupplier);
			this.GroupControl1.Controls.Add(this.txtInv);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Controls.Add(this.LabelControl16);
			this.GroupControl1.Controls.Add(this.LabelControl15);
			this.GroupControl1.Controls.Add(this.LabelControl14);
			this.GroupControl1.Controls.Add(this.LabelControl13);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl7);
			this.GroupControl1.Controls.Add(this.txtSupplier);
			this.GroupControl1.Controls.Add(this.LabelControl9);
			this.GroupControl1.Controls.Add(this.txtSupcode);
			this.GroupControl1.Controls.Add(this.LabelControl8);
			this.GroupControl1.Controls.Add(this.txtStckid);
			this.GroupControl1.Controls.Add(this.LabelControl2);
			this.GroupControl1.Controls.Add(this.btnSupSearch);
			this.GroupControl1.Controls.Add(this.LabelControl3);
			this.GroupControl1.Controls.Add(this.btnItemSearch);
			this.GroupControl1.Controls.Add(this.LabelControl5);
			this.GroupControl1.Controls.Add(this.txtItem);
			this.GroupControl1.Controls.Add(this.LabelControl4);
			this.GroupControl1.Controls.Add(this.dedlvrydate);
			this.GroupControl1.Controls.Add(this.deDue);
			this.GroupControl1.Controls.Add(this.ceDays);
			this.GroupControl1.Controls.Add(this.cmbType);
			this.GroupControl1.Controls.Add(this.ceQty);
			this.GroupControl1.Controls.Add(this.ceFree);
			this.GroupControl1.Controls.Add(this.btnAdd);
			this.GroupControl1.Controls.Add(this.ceCost);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(6, 0);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(1068, 149);
			this.GroupControl1.TabIndex = 33;
			this.GroupControl1.Text = "Deliver&y Header";
			//
			//ceAmountDisc
			//
			this.ceAmountDisc.EnterMoveNextControl = true;
			this.ceAmountDisc.Location = new System.Drawing.Point(837, 106);
			this.ceAmountDisc.Name = "ceAmountDisc";
			this.ceAmountDisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.ceAmountDisc.Properties.Appearance.Options.UseFont = true;
			this.ceAmountDisc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceAmountDisc.Size = new System.Drawing.Size(113, 26);
			this.ceAmountDisc.TabIndex = 14;
			this.ceAmountDisc.ToolTip = "Amount to be deducted per Item Delivered";
			//
			//cePrcentDisc
			//
			this.cePrcentDisc.EnterMoveNextControl = true;
			this.cePrcentDisc.Location = new System.Drawing.Point(598, 106);
			this.cePrcentDisc.Name = "cePrcentDisc";
			this.cePrcentDisc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.cePrcentDisc.Properties.Appearance.Options.UseFont = true;
			this.cePrcentDisc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cePrcentDisc.Size = new System.Drawing.Size(100, 26);
			this.cePrcentDisc.TabIndex = 13;
			this.cePrcentDisc.ToolTip = "Percent to be deducted per Item delivered";
			//
			//deExpDate
			//
			this.deExpDate.EditValue = null;
			this.deExpDate.EnterMoveNextControl = true;
			this.deExpDate.Location = new System.Drawing.Point(361, 106);
			this.deExpDate.Name = "deExpDate";
			this.deExpDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.deExpDate.Properties.Appearance.Options.UseFont = true;
			this.deExpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deExpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.deExpDate.Size = new System.Drawing.Size(128, 26);
			this.deExpDate.TabIndex = 12;
			this.deExpDate.ToolTip = "Expiration date of Item delivered";
			//
			//txtLotNo
			//
			this.txtLotNo.EditValue = "";
			this.txtLotNo.EnterMoveNextControl = true;
			this.txtLotNo.Location = new System.Drawing.Point(121, 106);
			this.txtLotNo.Name = "txtLotNo";
			this.txtLotNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.txtLotNo.Properties.Appearance.Options.UseFont = true;
			this.txtLotNo.Size = new System.Drawing.Size(100, 26);
			this.txtLotNo.TabIndex = 11;
			this.txtLotNo.ToolTip = "Lot No. of Item of Item delivered";
			//
			//leSupplier
			//
			this.leSupplier.Location = new System.Drawing.Point(294, 24);
			this.leSupplier.Name = "leSupplier";
			this.leSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.leSupplier.Properties.Appearance.Options.UseFont = true;
			this.leSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "supplier")});
			this.leSupplier.Properties.DropDownRows = 15;
			this.leSupplier.Size = new System.Drawing.Size(253, 26);
			this.leSupplier.TabIndex = 2;
			this.leSupplier.ToolTip = "Click the Down Arrow to See a list of Suppliers";
			//
			//LabelControl16
			//
			this.LabelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl16.Location = new System.Drawing.Point(708, 113);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(123, 19);
			this.LabelControl16.TabIndex = 0;
			this.LabelControl16.Text = "A&mount Discount";
			//
			//LabelControl15
			//
			this.LabelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl15.Location = new System.Drawing.Point(510, 113);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(82, 19);
			this.LabelControl15.TabIndex = 0;
			this.LabelControl15.Text = "% Disco&unt";
			//
			//LabelControl14
			//
			this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl14.Location = new System.Drawing.Point(243, 113);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(108, 19);
			this.LabelControl14.TabIndex = 0;
			this.LabelControl14.Text = "E&xpiration Date";
			//
			//LabelControl13
			//
			this.LabelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl13.Location = new System.Drawing.Point(68, 113);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(47, 19);
			this.LabelControl13.TabIndex = 0;
			this.LabelControl13.Text = "Lo&t No";
			//
			//frmDelivery
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 691);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.DGRetrieve);
			this.Controls.Add(this.cediscamnt);
			this.Controls.Add(this.txtGrand);
			this.Controls.Add(this.txtsum);
			this.Controls.Add(this.btnRetrieve);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.drgrid);
			this.Controls.Add(this.LabelControl12);
			this.Controls.Add(this.LabelControl11);
			this.Controls.Add(this.LabelControl10);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDelivery";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Delivery Entry Form";
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceDays.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmbType.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deDue.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deDue.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.drgrid).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceFree.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupplier.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cediscamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DGRetrieve).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtInv.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.ceAmountDisc.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cePrcentDisc.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deExpDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.deExpDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtLotNo.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leSupplier.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.DateEdit dedlvrydate;
		internal DevExpress.XtraEditors.CalcEdit ceDays;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.ComboBoxEdit cmbType;
		internal DevExpress.XtraEditors.DateEdit deDue;
		internal System.Windows.Forms.DataGridView drgrid;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.CalcEdit ceQty;
		internal DevExpress.XtraEditors.CalcEdit ceFree;
		internal DevExpress.XtraEditors.CalcEdit ceCost;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.SimpleButton btnAdd;
		internal DevExpress.XtraEditors.SimpleButton btnPost;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnRetrieve;
		internal System.Windows.Forms.TextBox txtsum;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal System.Windows.Forms.TextBox txtItem;
		internal DevExpress.XtraEditors.SimpleButton btnItemSearch;
		internal System.Windows.Forms.TextBox txtStckid;
		internal DevExpress.XtraEditors.TextEdit txtSupplier;
		internal DevExpress.XtraEditors.SimpleButton btnSupSearch;
		internal System.Windows.Forms.TextBox txtSupcode;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.CalcEdit cediscamnt;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal System.Windows.Forms.TextBox txtGrand;
		internal System.Windows.Forms.DataGridViewTextBoxColumn stckid;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Item;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Free;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Price;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		internal System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
		internal System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
		internal System.Windows.Forms.DataGridViewTextBoxColumn disc;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dscamnt;
		internal System.Windows.Forms.DataGridView DGRetrieve;
		internal DevExpress.XtraEditors.TextEdit txtInv;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.LookUpEdit leSupplier;
		internal DevExpress.XtraEditors.DateEdit deExpDate;
		internal DevExpress.XtraEditors.TextEdit txtLotNo;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.CalcEdit ceAmountDisc;
		internal DevExpress.XtraEditors.CalcEdit cePrcentDisc;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
	}
	
}
