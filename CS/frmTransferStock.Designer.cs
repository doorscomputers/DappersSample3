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
	partial class frmTransferStock : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			base.Load += new System.EventHandler(frmTransferStock_Load);
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
			this.drgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drgrid_CellContentClick);
			this.stckid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LotNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dscamnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.leLocation.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dedlvrydate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmbType.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceQty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.drgrid).BeginInit();
			this.SuspendLayout();
			//
			//GroupControl1
			//
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
			this.GroupControl1.Location = new System.Drawing.Point(-4, -27);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(967, 109);
			this.GroupControl1.TabIndex = 46;
			this.GroupControl1.Text = "Delivery Header";
			//
			//leLocation
			//
			this.leLocation.Location = new System.Drawing.Point(342, 37);
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
			this.LabelControl1.Location = new System.Drawing.Point(12, 44);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(113, 19);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Date Transfered";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(92, 85);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(33, 19);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "Item";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl9.Location = new System.Drawing.Point(710, 85);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(34, 19);
			this.LabelControl9.TabIndex = 0;
			this.LabelControl9.Text = "Price";
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl8.Location = new System.Drawing.Point(601, 85);
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
			this.LabelControl2.Location = new System.Drawing.Point(258, 44);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(78, 19);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Transfer to";
			//
			//btnItemSearch
			//
			this.btnItemSearch.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.0F));
			this.btnItemSearch.Appearance.Options.UseFont = true;
			this.btnItemSearch.Location = new System.Drawing.Point(532, 79);
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
			this.txtItem.Location = new System.Drawing.Point(131, 78);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(398, 26);
			this.txtItem.TabIndex = 2;
			this.txtItem.TabStop = false;
			//
			//dedlvrydate
			//
			this.dedlvrydate.EditValue = null;
			this.dedlvrydate.EnterMoveNextControl = true;
			this.dedlvrydate.Location = new System.Drawing.Point(131, 37);
			this.dedlvrydate.Name = "dedlvrydate";
			this.dedlvrydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.dedlvrydate.Properties.Appearance.Options.UseFont = true;
			this.dedlvrydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dedlvrydate.Size = new System.Drawing.Size(107, 26);
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
			this.ceQty.Location = new System.Drawing.Point(632, 78);
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
			this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnAdd.Appearance.Options.UseFont = true;
			this.btnAdd.Location = new System.Drawing.Point(875, 81);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(76, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "&Add";
			this.btnAdd.ToolTip = "Add the item to the list";
			//
			//ceCost
			//
			this.ceCost.EnterMoveNextControl = true;
			this.ceCost.Location = new System.Drawing.Point(748, 78);
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
			this.txtsum.Location = new System.Drawing.Point(774, 504);
			this.txtsum.Name = "txtsum";
			this.txtsum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtsum.Size = new System.Drawing.Size(189, 29);
			this.txtsum.TabIndex = 43;
			this.txtsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//btnRetrieve
			//
			this.btnRetrieve.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnRetrieve.Appearance.Options.UseFont = true;
			this.btnRetrieve.Enabled = false;
			this.btnRetrieve.Location = new System.Drawing.Point(483, 501);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(102, 32);
			this.btnRetrieve.TabIndex = 38;
			this.btnRetrieve.Text = "&Retrieve";
			this.btnRetrieve.ToolTip = "Retrieve a list of uncompleted delivery entry";
			this.btnRetrieve.Visible = false;
			//
			//btnNew
			//
			this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.Location = new System.Drawing.Point(1, 501);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(102, 32);
			this.btnNew.TabIndex = 39;
			this.btnNew.Text = "&New";
			this.btnNew.ToolTip = "Click this to enter a new delivery.";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(358, 501);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 32);
			this.btnSave.TabIndex = 40;
			this.btnSave.Text = "&Save";
			this.btnSave.ToolTip = "Save the List for later modification";
			this.btnSave.Visible = false;
			//
			//btnPost
			//
			this.btnPost.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnPost.Appearance.Options.UseFont = true;
			this.btnPost.Enabled = false;
			this.btnPost.Location = new System.Drawing.Point(119, 501);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(102, 32);
			this.btnPost.TabIndex = 41;
			this.btnPost.Text = "&Post";
			this.btnPost.ToolTip = "Click this button to update the inventory and the Balance per supplier";
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl10.Location = new System.Drawing.Point(717, 514);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(51, 19);
			this.LabelControl10.TabIndex = 36;
			this.LabelControl10.Text = "TOTAL";
			//
			//drgrid
			//
			this.drgrid.AllowUserToAddRows = false;
			this.drgrid.AllowUserToDeleteRows = false;
			this.drgrid.AllowUserToResizeRows = false;
			DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drgrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10;
			this.drgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.drgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.stckid, this.Item, this.Qty, this.Price, this.Amount, this.ExpiryDate, this.LotNo, this.disc, this.dscamnt});
			DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.drgrid.DefaultCellStyle = DataGridViewCellStyle16;
			this.drgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.drgrid.Location = new System.Drawing.Point(-3, 87);
			this.drgrid.MultiSelect = false;
			this.drgrid.Name = "drgrid";
			DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.drgrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle17;
			DataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.drgrid.RowsDefaultCellStyle = DataGridViewCellStyle18;
			this.drgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.drgrid.Size = new System.Drawing.Size(966, 408);
			this.drgrid.TabIndex = 37;
			//
			//stckid
			//
			DataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.stckid.DefaultCellStyle = DataGridViewCellStyle11;
			this.stckid.HeaderText = "StockID";
			this.stckid.Name = "stckid";
			this.stckid.Visible = false;
			this.stckid.Width = 5;
			//
			//Item
			//
			DataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Item.DefaultCellStyle = DataGridViewCellStyle12;
			this.Item.HeaderText = "Item Description";
			this.Item.Name = "Item";
			this.Item.Width = 400;
			//
			//Qty
			//
			DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle13.Format = "N0";
			DataGridViewCellStyle13.NullValue = "0";
			this.Qty.DefaultCellStyle = DataGridViewCellStyle13;
			this.Qty.HeaderText = "Qty";
			this.Qty.Name = "Qty";
			//
			//Price
			//
			DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle14.Format = "N2";
			DataGridViewCellStyle14.NullValue = "0";
			this.Price.DefaultCellStyle = DataGridViewCellStyle14;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Width = 200;
			//
			//Amount
			//
			DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F));
			DataGridViewCellStyle15.Format = "N2";
			DataGridViewCellStyle15.NullValue = "0";
			this.Amount.DefaultCellStyle = DataGridViewCellStyle15;
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
			//frmTransferStock
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 545);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.txtsum);
			this.Controls.Add(this.btnRetrieve);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnPost);
			this.Controls.Add(this.LabelControl10);
			this.Controls.Add(this.drgrid);
			this.Name = "frmTransferStock";
			this.Text = "Transfer Stock Form";
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
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
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
		internal System.Windows.Forms.DataGridViewTextBoxColumn stckid;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Item;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Price;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		internal System.Windows.Forms.DataGridViewTextBoxColumn ExpiryDate;
		internal System.Windows.Forms.DataGridViewTextBoxColumn LotNo;
		internal System.Windows.Forms.DataGridViewTextBoxColumn disc;
		internal System.Windows.Forms.DataGridViewTextBoxColumn dscamnt;
		internal DevExpress.XtraEditors.LookUpEdit leLocation;
	}
	
}
