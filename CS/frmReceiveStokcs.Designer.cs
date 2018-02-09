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
	partial class frmReceiveStokcs : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmReceiveStokcs_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dscamnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stckid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.txtbcodes = new System.Windows.Forms.TextBox();
			this.leLocation = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.txtStckid = new System.Windows.Forms.TextBox();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnItemSearch = new DevExpress.XtraEditors.SimpleButton();
			this.btnItemSearch.Click += new System.EventHandler(this.btnItemSearch_Click);
			this.txtItem = new System.Windows.Forms.TextBox();
			this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
			this.txtItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItem_KeyPress);
			this.txtItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyUp);
			this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
			this.dedlvrydate = new DevExpress.XtraEditors.DateEdit();
			this.cmbType = new DevExpress.XtraEditors.ComboBoxEdit();
			this.ceQty = new DevExpress.XtraEditors.CalcEdit();
			this.ceQty.LostFocus += new System.EventHandler(this.ceQty_LostFocus);
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			this.ceCost = new DevExpress.XtraEditors.CalcEdit();
			this.txtsum = new System.Windows.Forms.TextBox();
			this.btnRetrieve = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnPost = new DevExpress.XtraEditors.SimpleButton();
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.drgrid = new System.Windows.Forms.DataGridView();
			this.drgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellClick);
			this.drgrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellEndEdit);
			this.drgrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellValueChanged);
			this.FormAssistant1 = new DevExpress.XtraBars.FormAssistant();
			this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.dgitems = new System.Windows.Forms.DataGridView();
			this.dgitems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgitems_KeyDown);
			this.dgitems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgitems_KeyPress);
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.leLocation.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmbType.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.drgrid).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgitems).BeginInit();
			this.SuspendLayout();
			//
			//dscamnt
			//
			this.dscamnt.HeaderText = "dscamnt";
			this.dscamnt.Name = "dscamnt";
			this.dscamnt.Visible = false;
			//
			//LotNo
			//
			this.LotNo.HeaderText = "Lot No";
			this.LotNo.Name = "LotNo";
			this.LotNo.Visible = false;
			//
			//ExpiryDate
			//
			this.ExpiryDate.HeaderText = "Expiry Date";
			this.ExpiryDate.Name = "ExpiryDate";
			this.ExpiryDate.Visible = false;
			//
			//Amount
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle1.Format = "N2";
			DataGridViewCellStyle1.NullValue = "0";
			this.Amount.DefaultCellStyle = DataGridViewCellStyle1;
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			this.Amount.Width = 200;
			//
			//Price
			//
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle2.Format = "N2";
			DataGridViewCellStyle2.NullValue = "0";
			this.Price.DefaultCellStyle = DataGridViewCellStyle2;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Width = 200;
			//
			//Qty
			//
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle3.Format = "N0";
			DataGridViewCellStyle3.NullValue = "0";
			this.Qty.DefaultCellStyle = DataGridViewCellStyle3;
			this.Qty.HeaderText = "Qty";
			this.Qty.Name = "Qty";
			//
			//Item
			//
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Item.DefaultCellStyle = DataGridViewCellStyle4;
			this.Item.HeaderText = "Item Description";
			this.Item.Name = "Item";
			this.Item.Width = 400;
			//
			//stckid
			//
			DataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.stckid.DefaultCellStyle = DataGridViewCellStyle5;
			this.stckid.HeaderText = "StockID";
			this.stckid.Name = "stckid";
			this.stckid.Visible = false;
			this.stckid.Width = 5;
			//
			//disc
			//
			this.disc.HeaderText = "disc";
			this.disc.Name = "disc";
			this.disc.Visible = false;
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.txtbcodes);
			this.GroupControl1.Controls.Add(this.leLocation);
			this.GroupControl1.Controls.Add(this.LabelControl1);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl9);
			this.GroupControl1.Controls.Add(this.LabelControl8);
			this.GroupControl1.Controls.Add(this.txtStckid);
			this.GroupControl1.Controls.Add(this.LabelControl2);
			this.GroupControl1.Controls.Add(this.btnItemSearch);
			this.GroupControl1.Controls.Add(this.txtItem);
			this.GroupControl1.Controls.Add(this.dedlvrydate);
			this.GroupControl1.Controls.Add(this.cmbType);
			this.GroupControl1.Controls.Add(this.ceQty);
			this.GroupControl1.Controls.Add(this.btnAdd);
			this.GroupControl1.Controls.Add(this.ceCost);
			this.GroupControl1.Enabled = false;
			this.GroupControl1.Location = new System.Drawing.Point(2, 3);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(967, 109);
			this.GroupControl1.TabIndex = 54;
			//
			//txtbcodes
			//
			this.txtbcodes.Enabled = false;
			this.txtbcodes.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtbcodes.Location = new System.Drawing.Point(788, 31);
			this.txtbcodes.MaxLength = 22;
			this.txtbcodes.Name = "txtbcodes";
			this.txtbcodes.Size = new System.Drawing.Size(94, 29);
			this.txtbcodes.TabIndex = 62;
			this.txtbcodes.Visible = false;
			//
			//leLocation
			//
			this.leLocation.Location = new System.Drawing.Point(374, 24);
			this.leLocation.Name = "leLocation";
			this.leLocation.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.leLocation.Properties.Appearance.Options.UseFont = true;
			this.leLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leLocation.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("locid", "locid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("location", "Location", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.leLocation.Size = new System.Drawing.Size(354, 26);
			this.leLocation.TabIndex = 1;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(26, 31);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(99, 19);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Date Received";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(92, 78);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(33, 19);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "Item";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl9.Location = new System.Drawing.Point(710, 78);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(34, 19);
			this.LabelControl9.TabIndex = 0;
			this.LabelControl9.Text = "Price";
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl8.Location = new System.Drawing.Point(601, 78);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(25, 19);
			this.LabelControl8.TabIndex = 0;
			this.LabelControl8.Text = "Qty";
			//
			//txtStckid
			//
			this.txtStckid.Location = new System.Drawing.Point(20, 64);
			this.txtStckid.Name = "txtStckid";
			this.txtStckid.Size = new System.Drawing.Size(105, 20);
			this.txtStckid.TabIndex = 14;
			this.txtStckid.Visible = false;
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(263, 31);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(104, 19);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Received From";
			//
			//btnItemSearch
			//
			this.btnItemSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemSearch.Appearance.Options.UseFont = true;
			this.btnItemSearch.Location = new System.Drawing.Point(532, 72);
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
			this.txtItem.Location = new System.Drawing.Point(131, 71);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(398, 26);
			this.txtItem.TabIndex = 2;
			this.txtItem.TabStop = false;
			//
			//dedlvrydate
			//
			this.dedlvrydate.EditValue = null;
			this.dedlvrydate.EnterMoveNextControl = true;
			this.dedlvrydate.Location = new System.Drawing.Point(131, 24);
			this.dedlvrydate.Name = "dedlvrydate";
			this.dedlvrydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.dedlvrydate.Properties.Appearance.Options.UseFont = true;
			this.dedlvrydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Size = new System.Drawing.Size(121, 26);
			this.dedlvrydate.TabIndex = 0;
			this.dedlvrydate.ToolTip = "Date the Goods were delivered";
			//
			//cmbType
			//
			this.cmbType.EnterMoveNextControl = true;
			this.cmbType.Location = new System.Drawing.Point(132, 64);
			this.cmbType.Name = "cmbType";
			this.cmbType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cmbType.Properties.Appearance.Options.UseFont = true;
			this.cmbType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbType.Properties.Items.AddRange(new object[] {"COD", "I.S.", "Consignment"});
			this.cmbType.Size = new System.Drawing.Size(106, 26);
			this.cmbType.TabIndex = 32;
			this.cmbType.ToolTip = "COD,IS or Consignment";
			this.cmbType.Visible = false;
			//
			//ceQty
			//
			this.ceQty.EnterMoveNextControl = true;
			this.ceQty.Location = new System.Drawing.Point(632, 71);
			this.ceQty.Name = "ceQty";
			this.ceQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceQty.Properties.Appearance.Options.UseFont = true;
			this.ceQty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQty.Size = new System.Drawing.Size(64, 26);
			this.ceQty.TabIndex = 4;
			this.ceQty.ToolTip = "Qty Delivered by the supplier";
			//
			//btnAdd
			//
			this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (10.25F));
			this.btnAdd.Appearance.Options.UseFont = true;
			this.btnAdd.Location = new System.Drawing.Point(875, 74);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(76, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "&Add";
			this.btnAdd.ToolTip = "Add the item to the list";
			//
			//ceCost
			//
			this.ceCost.EnterMoveNextControl = true;
			this.ceCost.Location = new System.Drawing.Point(748, 71);
			this.ceCost.Name = "ceCost";
			this.ceCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceCost.Properties.Appearance.Options.UseFont = true;
			this.ceCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceCost.Properties.Mask.BeepOnError = true;
			this.ceCost.Properties.Mask.EditMask = "n2";
			this.ceCost.Size = new System.Drawing.Size(110, 26);
			this.ceCost.TabIndex = 5;
			this.ceCost.TabStop = false;
			this.ceCost.ToolTip = "Cost of the item delivered";
			//
			//txtsum
			//
			this.txtsum.Enabled = false;
			this.txtsum.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F));
			this.txtsum.Location = new System.Drawing.Point(780, 534);
			this.txtsum.Name = "txtsum";
			this.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtsum.Size = new System.Drawing.Size(189, 29);
			this.txtsum.TabIndex = 53;
			this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//btnRetrieve
			//
			this.btnRetrieve.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnRetrieve.Appearance.Options.UseFont = true;
			this.btnRetrieve.Enabled = false;
			this.btnRetrieve.Location = new System.Drawing.Point(489, 531);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(102, 32);
			this.btnRetrieve.TabIndex = 49;
			this.btnRetrieve.Text = "&Retrieve";
			this.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry";
			this.btnRetrieve.Visible = false;
			//
			//btnNew
			//
			this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.Location = new System.Drawing.Point(7, 531);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(102, 32);
			this.btnNew.TabIndex = 50;
			this.btnNew.Text = "&New";
			this.btnNew.ToolTip = "Click this to enter a new delivery.";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(364, 531);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 32);
			this.btnSave.TabIndex = 51;
			this.btnSave.Text = "&Save";
			this.btnSave.ToolTip = "Save the List for later modification";
			this.btnSave.Visible = false;
			//
			//btnPost
			//
			this.btnPost.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnPost.Appearance.Options.UseFont = true;
			this.btnPost.Enabled = false;
			this.btnPost.Location = new System.Drawing.Point(125, 531);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(102, 32);
			this.btnPost.TabIndex = 52;
			this.btnPost.Text = "&Post";
			this.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier";
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl10.Location = new System.Drawing.Point(723, 544);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(51, 19);
			this.LabelControl10.TabIndex = 47;
			this.LabelControl10.Text = "TOTAL";
			//
			//drgrid
			//
			this.drgrid.AllowUserToAddRows = false;
			this.drgrid.AllowUserToDeleteRows = false;
			this.drgrid.AllowUserToResizeRows = false;
			DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6;
			this.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.drgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.stckid, this.Item, this.Qty, this.Price, this.Amount, this.ExpiryDate, this.LotNo, this.disc, this.dscamnt});
			this.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.drgrid.Location = new System.Drawing.Point(3, 117);
			this.drgrid.MultiSelect = false;
			this.drgrid.Name = "drgrid";
			DataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle7;
			this.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.drgrid.Size = new System.Drawing.Size(966, 408);
			this.drgrid.TabIndex = 48;
			//
			//DefaultLookAndFeel1
			//
			this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
			//
			//dgitems
			//
			this.dgitems.AllowUserToAddRows = false;
			DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8;
			this.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgitems.DefaultCellStyle = DataGridViewCellStyle9;
			this.dgitems.Location = new System.Drawing.Point(133, 102);
			this.dgitems.Name = "dgitems";
			this.dgitems.ReadOnly = true;
			this.dgitems.Size = new System.Drawing.Size(726, 426);
			this.dgitems.TabIndex = 93;
			this.dgitems.Visible = false;
			//
			//frmReceiveStokcs
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 575);
			this.Controls.Add(this.dgitems);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.txtsum);
			this.Controls.Add(this.btnRetrieve);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.LabelControl10);
			this.Controls.Add(this.drgrid);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmReceiveStokcs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Receive Stocks Form";
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.leLocation.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmbType.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.drgrid).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgitems).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.DataGridViewTextBoxColumn dscamnt;
		internal System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
		internal System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Price;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Item;
		internal System.Windows.Forms.DataGridViewTextBoxColumn stckid;
		internal System.Windows.Forms.DataGridViewTextBoxColumn disc;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.LookUpEdit leLocation;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal System.Windows.Forms.TextBox txtStckid;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.SimpleButton btnItemSearch;
		internal System.Windows.Forms.TextBox txtItem;
		internal DevExpress.XtraEditors.DateEdit dedlvrydate;
		internal DevExpress.XtraEditors.ComboBoxEdit cmbType;
		internal DevExpress.XtraEditors.CalcEdit ceQty;
		internal DevExpress.XtraEditors.SimpleButton btnAdd;
		internal DevExpress.XtraEditors.CalcEdit ceCost;
		internal System.Windows.Forms.TextBox txtsum;
		internal DevExpress.XtraEditors.SimpleButton btnRetrieve;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnPost;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal System.Windows.Forms.DataGridView drgrid;
		internal DevExpress.XtraBars.FormAssistant FormAssistant1;
		internal DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel1;
		internal System.Windows.Forms.DataGridView dgitems;
		internal System.Windows.Forms.TextBox txtbcodes;
	}
	
}
