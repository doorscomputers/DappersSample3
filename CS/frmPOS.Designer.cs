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
	partial class frmPOS : System.Windows.Forms.Form
	{
		///'Uncomment the line above to bring the form to original windows forms
		///''''then copy the enclose with comments asterisk code
		//******************************************************************************************
		//Inherits PDSAFormBase
		public frmPOS()
		{
			DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Tahoma", (float) (8.5F));
			// Track User Flag must be set here or it won't be set in time
			// MyBase.UserTrack = False
			
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			
			// This is done for apparent speed
			Control ctlSelected;
			ctlSelected = PDSAForms.GetActiveMDIChildControl(this);
			
			//Add any initialization after the InitializeComponent() call
			
			//MyBase.CheckSecurityOnControls = True
		}
		//'******************************************************************************************
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
			this.Activated += new System.EventHandler(frmPOS_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmPOS_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmPOS_KeyDown);
			this.Load += new System.EventHandler(frmPOS_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
			DevExpress.Utils.SuperToolTip SuperToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem ToolTipItem1 = new DevExpress.Utils.ToolTipItem();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtSum = new System.Windows.Forms.TextBox();
			this.txtitem = new System.Windows.Forms.TextBox();
			this.txtitem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtitem_KeyDown);
			this.txtitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitem_KeyPress);
			this.txtitem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtitem_KeyUp);
			this.txtitem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
			this.PosGrid = new System.Windows.Forms.DataGridView();
			this.PosGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.PosGrid_CellBeginEdit);
			this.PosGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosGrid_CellEndEdit);
			this.PosGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PosGrid_KeyDown);
			this.PosGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.PosGrid_EditingControlShowing);
			this.PosGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosGrid_CellValueChanged);
			this.PosGrid.DoubleClick += new System.EventHandler(this.PosGrid_DoubleClick);
			this.PosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PosGrid_CellClick);
			this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discounts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Incentv = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtBarcode = new System.Windows.Forms.TextBox();
			this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
			this.txtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyUp);
			this.Label2 = new System.Windows.Forms.Label();
			this.tbSQL = new DevExpress.XtraEditors.TextEdit();
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.DGRetrieve = new System.Windows.Forms.DataGridView();
			this.DGRetrieve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGRetrieve_KeyDown);
			this.DGRetrieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGRetrieve_KeyPress);
			this.GridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
			this.GridLookUpEdit2.Enter += new System.EventHandler(this.GridLookUpEdit2_Enter);
			this.GridLookUpEdit2.GotFocus += new System.EventHandler(this.GridLookUpEdit2_GotFocus);
			this.GridLookUpEdit2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridLookUpEdit2_KeyDown);
			this.GridLookUpEdit2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GridLookUpEdit2_KeyPress);
			this.GridLookUpEdit2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridLookUpEdit2_KeyUp);
			this.GridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.stckid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.barcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.items = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cmbPriceMode = new System.Windows.Forms.ComboBox();
			this.cmbPaymentType = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.ceRefno = new DevExpress.XtraEditors.CalcEdit();
			this.txtTendered = new System.Windows.Forms.TextBox();
			this.lblChange = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtcustid = new System.Windows.Forms.TextBox();
			this.txtlastname = new System.Windows.Forms.TextBox();
			this.txtfirstname = new System.Windows.Forms.TextBox();
			this.txtStckid = new System.Windows.Forms.TextBox();
			this.txtbcodes = new System.Windows.Forms.TextBox();
			this.txtqty = new System.Windows.Forms.TextBox();
			this.btnSearchItems = new DevExpress.XtraEditors.SimpleButton();
			this.btnSearchItems.Click += new System.EventHandler(this.btnSearchItems_Click);
			this.btnCustomers = new DevExpress.XtraEditors.SimpleButton();
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			this.btnPriceMode = new DevExpress.XtraEditors.SimpleButton();
			this.btnPriceMode.Click += new System.EventHandler(this.btnPriceMode_Click);
			this.btnSaves = new DevExpress.XtraEditors.SimpleButton();
			this.btnSaves.Click += new System.EventHandler(this.btnSaves_Click);
			this.btnCreditPay = new DevExpress.XtraEditors.SimpleButton();
			this.btnCreditPay.Click += new System.EventHandler(this.btnCreditPay_Click);
			this.btnSuspend = new DevExpress.XtraEditors.SimpleButton();
			this.btnSuspend.Click += new System.EventHandler(this.btnSuspend_Click);
			this.btnRetrieve = new DevExpress.XtraEditors.SimpleButton();
			this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
			this.btnChequePayment = new DevExpress.XtraEditors.SimpleButton();
			this.btnChequePayment.Click += new System.EventHandler(this.btnChequePayment_Click);
			this.btnType = new DevExpress.XtraEditors.SimpleButton();
			this.btnType.Click += new System.EventHandler(this.btnType_Click);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			this.btnLookuprice = new DevExpress.XtraEditors.SimpleButton();
			this.btnLookuprice.Click += new System.EventHandler(this.btnLookuprice_Click);
			this.btnPickup = new DevExpress.XtraEditors.SimpleButton();
			this.btnPickup.Click += new System.EventHandler(this.btnPickup_Click);
			this.btnReprint = new DevExpress.XtraEditors.SimpleButton();
			this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
			this.SimpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton6 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton7 = new DevExpress.XtraEditors.SimpleButton();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.lblName = new DevExpress.XtraEditors.LabelControl();
			this.lblDate = new DevExpress.XtraEditors.LabelControl();
			this.lblTime = new DevExpress.XtraEditors.LabelControl();
			this.Button1 = new DevExpress.XtraEditors.SimpleButton();
			this.Button1.Click += new System.EventHandler(this.SimpleButton1_Click);
			this.btnDiscount = new DevExpress.XtraEditors.SimpleButton();
			this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
			this.btnAddCash = new DevExpress.XtraEditors.SimpleButton();
			this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
			this.btnnew = new DevExpress.XtraEditors.SimpleButton();
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
			this.btnBcode = new DevExpress.XtraEditors.SimpleButton();
			this.btnBcode.Click += new System.EventHandler(this.btnBcode_Click);
			this.btnRefund = new DevExpress.XtraEditors.SimpleButton();
			this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
			this.txtCounts = new DevExpress.XtraEditors.TextEdit();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgEmps = new System.Windows.Forms.DataGridView();
			this.dgEmps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgEmps_KeyDown);
			this.wtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.waiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ceWtid = new DevExpress.XtraEditors.CalcEdit();
			this.Label5 = new System.Windows.Forms.Label();
			this.ceQtyy = new DevExpress.XtraEditors.CalcEdit();
			this.ceQtyy.GotFocus += new System.EventHandler(this.ceQtyy_GotFocus);
			this.ceQtyy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceQtyy_KeyDown);
			this.dgitems = new System.Windows.Forms.DataGridView();
			this.dgitems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgitems_KeyDown);
			this.dgitems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgitems_KeyPress);
			((System.ComponentModel.ISupportInitialize) this.PosGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.tbSQL.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DGRetrieve).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridLookUpEdit2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridLookUpEdit2View).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceRefno.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtCounts.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgEmps).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceWtid.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceQtyy.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.dgitems).BeginInit();
			this.SuspendLayout();
			//
			//txtSum
			//
			this.txtSum.BackColor = System.Drawing.Color.AliceBlue;
			this.txtSum.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (70.0F), System.Drawing.FontStyle.Bold);
			this.txtSum.ForeColor = System.Drawing.Color.DarkGreen;
			this.txtSum.Location = new System.Drawing.Point(9, 41);
			this.txtSum.Name = "txtSum";
			this.txtSum.ReadOnly = true;
			this.txtSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtSum.Size = new System.Drawing.Size(1034, 113);
			this.txtSum.TabIndex = 19;
			this.txtSum.TabStop = false;
			//
			//txtitem
			//
			this.txtitem.Enabled = false;
			this.txtitem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtitem.Location = new System.Drawing.Point(50, 4);
			this.txtitem.Name = "txtitem";
			this.txtitem.Size = new System.Drawing.Size(774, 29);
			this.txtitem.TabIndex = 13;
			//
			//PosGrid
			//
			this.PosGrid.AllowUserToAddRows = false;
			this.PosGrid.AllowUserToDeleteRows = false;
			this.PosGrid.AllowUserToResizeColumns = false;
			this.PosGrid.AllowUserToResizeRows = false;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.PosGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.PosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ProdID, this.Barcode, this.Quantity, this.Cost, this.Item, this.Price, this.Total, this.OP, this.discounts, this.Incentv});
			DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.PosGrid.DefaultCellStyle = DataGridViewCellStyle10;
			this.PosGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.PosGrid.Enabled = false;
			this.PosGrid.Location = new System.Drawing.Point(12, 160);
			this.PosGrid.MultiSelect = false;
			this.PosGrid.Name = "PosGrid";
			DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.PosGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle11;
			DataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PosGrid.RowsDefaultCellStyle = DataGridViewCellStyle12;
			this.PosGrid.RowTemplate.Height = 30;
			this.PosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PosGrid.Size = new System.Drawing.Size(1031, 515);
			this.PosGrid.TabIndex = 12;
			//
			//ProdID
			//
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ProdID.DefaultCellStyle = DataGridViewCellStyle2;
			this.ProdID.HeaderText = "ProdID";
			this.ProdID.Name = "ProdID";
			this.ProdID.ReadOnly = true;
			this.ProdID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ProdID.Visible = false;
			//
			//Barcode
			//
			this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Barcode.DefaultCellStyle = DataGridViewCellStyle3;
			this.Barcode.HeaderText = "Barcode";
			this.Barcode.MaxInputLength = 22;
			this.Barcode.Name = "Barcode";
			this.Barcode.ReadOnly = true;
			this.Barcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Barcode.Visible = false;
			//
			//Quantity
			//
			DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle4.Format = "N0";
			DataGridViewCellStyle4.NullValue = null;
			this.Quantity.DefaultCellStyle = DataGridViewCellStyle4;
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Quantity.Width = 97;
			//
			//Cost
			//
			DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle5.Format = "N2";
			DataGridViewCellStyle5.NullValue = null;
			this.Cost.DefaultCellStyle = DataGridViewCellStyle5;
			this.Cost.HeaderText = "Cost";
			this.Cost.Name = "Cost";
			this.Cost.ReadOnly = true;
			this.Cost.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Cost.Visible = false;
			//
			//Item
			//
			DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle6.NullValue = null;
			this.Item.DefaultCellStyle = DataGridViewCellStyle6;
			this.Item.HeaderText = "Item";
			this.Item.Name = "Item";
			this.Item.ReadOnly = true;
			this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Item.Width = 520;
			//
			//Price
			//
			DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle7.Format = "N2";
			DataGridViewCellStyle7.NullValue = "0";
			this.Price.DefaultCellStyle = DataGridViewCellStyle7;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Price.Width = 130;
			//
			//Total
			//
			DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle8.Format = "N2";
			DataGridViewCellStyle8.NullValue = null;
			this.Total.DefaultCellStyle = DataGridViewCellStyle8;
			this.Total.HeaderText = "Amount";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Total.Width = 230;
			//
			//OP
			//
			DataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.OP.DefaultCellStyle = DataGridViewCellStyle9;
			this.OP.HeaderText = "OP";
			this.OP.Name = "OP";
			this.OP.Visible = false;
			//
			//discounts
			//
			this.discounts.HeaderText = "DetailDiscount";
			this.discounts.Name = "discounts";
			this.discounts.ReadOnly = true;
			this.discounts.Visible = false;
			//
			//Incentv
			//
			this.Incentv.HeaderText = "Incentive";
			this.Incentv.Name = "Incentv";
			this.Incentv.ReadOnly = true;
			this.Incentv.Visible = false;
			//
			//txtBarcode
			//
			this.txtBarcode.Enabled = false;
			this.txtBarcode.Font = new System.Drawing.Font("Times New Roman", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtBarcode.Location = new System.Drawing.Point(106, 7);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Size = new System.Drawing.Size(214, 26);
			this.txtBarcode.TabIndex = 0;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(5, 11);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(45, 20);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Item";
			//
			//tbSQL
			//
			this.tbSQL.Location = new System.Drawing.Point(615, 683);
			this.tbSQL.Name = "tbSQL";
			this.tbSQL.Size = new System.Drawing.Size(27, 20);
			this.tbSQL.TabIndex = 22;
			this.tbSQL.TabStop = false;
			this.tbSQL.Visible = false;
			//
			//DGRetrieve
			//
			this.DGRetrieve.AllowUserToAddRows = false;
			this.DGRetrieve.AllowUserToDeleteRows = false;
			DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGRetrieve.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13;
			this.DGRetrieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DGRetrieve.DefaultCellStyle = DataGridViewCellStyle14;
			this.DGRetrieve.Location = new System.Drawing.Point(50, 45);
			this.DGRetrieve.Name = "DGRetrieve";
			this.DGRetrieve.ReadOnly = true;
			DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DGRetrieve.RowHeadersDefaultCellStyle = DataGridViewCellStyle15;
			this.DGRetrieve.Size = new System.Drawing.Size(774, 279);
			this.DGRetrieve.TabIndex = 30;
			this.DGRetrieve.Visible = false;
			//
			//GridLookUpEdit2
			//
			this.GridLookUpEdit2.EditValue = "";
			this.GridLookUpEdit2.Enabled = false;
			this.GridLookUpEdit2.EnterMoveNextControl = true;
			this.GridLookUpEdit2.Location = new System.Drawing.Point(16, 44);
			this.GridLookUpEdit2.Name = "GridLookUpEdit2";
			this.GridLookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridLookUpEdit2.Properties.Appearance.Options.UseFont = true;
			this.GridLookUpEdit2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2.Properties.AppearanceDropDown.Options.UseFont = true;
			this.GridLookUpEdit2.Properties.AppearanceFocused.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2.Properties.AppearanceFocused.Options.UseFont = true;
			this.GridLookUpEdit2.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2.Properties.AppearanceReadOnly.Options.UseFont = true;
			this.GridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.GridLookUpEdit2.Properties.PopupFormSize = new System.Drawing.Size(860, 600);
			this.GridLookUpEdit2.Properties.View = this.GridLookUpEdit2View;
			this.GridLookUpEdit2.Size = new System.Drawing.Size(808, 32);
			this.GridLookUpEdit2.TabIndex = 1;
			this.GridLookUpEdit2.ToolTip = "Press CTRL + I to move focus to Item Search";
			this.GridLookUpEdit2.Visible = false;
			//
			//GridLookUpEdit2View
			//
			this.GridLookUpEdit2View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2View.Appearance.ColumnFilterButton.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.GridLookUpEdit2View.Appearance.FilterPanel.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2View.Appearance.FocusedCell.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2View.Appearance.FocusedRow.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.GridLookUpEdit2View.Appearance.HeaderPanel.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.Row.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2View.Appearance.Row.Options.UseFont = true;
			this.GridLookUpEdit2View.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridLookUpEdit2View.Appearance.SelectedRow.Options.UseFont = true;
			this.GridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.stckid, this.barcode1, this.items, this.GridColumn4, this.GridColumn5, this.GridColumn8, this.GridColumn9, this.GridColumn10, this.GridColumn11, this.GridColumn12, this.GridColumn13});
			this.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.GridLookUpEdit2View.Name = "GridLookUpEdit2View";
			this.GridLookUpEdit2View.OptionsBehavior.AllowPartialRedrawOnScrolling = false;
			this.GridLookUpEdit2View.OptionsFind.AlwaysVisible = true;
			this.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.GridLookUpEdit2View.OptionsView.ShowAutoFilterRow = true;
			this.GridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
			//
			//stckid
			//
			this.stckid.Caption = "StockID";
			this.stckid.FieldName = "stckid";
			this.stckid.Name = "stckid";
			this.stckid.Width = 96;
			//
			//barcode1
			//
			this.barcode1.AppearanceHeader.Options.UseTextOptions = true;
			this.barcode1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.barcode1.Caption = "Barcode";
			this.barcode1.FieldName = "barcode";
			this.barcode1.Name = "barcode1";
			this.barcode1.Width = 197;
			//
			//items
			//
			this.items.AppearanceHeader.Font = new System.Drawing.Font("Courier New", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.items.AppearanceHeader.Options.UseFont = true;
			this.items.Caption = "Item Description";
			this.items.FieldName = "itemdesc";
			this.items.Name = "items";
			this.items.Visible = true;
			this.items.VisibleIndex = 0;
			this.items.Width = 526;
			//
			//GridColumn4
			//
			this.GridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Courier New", (float) (12.0F), System.Drawing.FontStyle.Bold);
			this.GridColumn4.AppearanceHeader.Options.UseFont = true;
			this.GridColumn4.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.GridColumn4.Caption = "Selling Price";
			this.GridColumn4.DisplayFormat.FormatString = "N2";
			this.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.GridColumn4.FieldName = "retail";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.Visible = true;
			this.GridColumn4.VisibleIndex = 1;
			this.GridColumn4.Width = 170;
			//
			//GridColumn5
			//
			this.GridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (18.25F));
			this.GridColumn5.AppearanceCell.Options.UseFont = true;
			this.GridColumn5.AppearanceCell.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.GridColumn5.AppearanceHeader.Options.UseTextOptions = true;
			this.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.GridColumn5.Caption = "Wholesale";
			this.GridColumn5.DisplayFormat.FormatString = "N2";
			this.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.GridColumn5.FieldName = "retail2";
			this.GridColumn5.Name = "GridColumn5";
			this.GridColumn5.Width = 185;
			//
			//GridColumn8
			//
			this.GridColumn8.Caption = "GridColumn8";
			this.GridColumn8.Name = "GridColumn8";
			this.GridColumn8.Width = 33;
			//
			//GridColumn9
			//
			this.GridColumn9.Caption = "GridColumn9";
			this.GridColumn9.Name = "GridColumn9";
			this.GridColumn9.Width = 33;
			//
			//GridColumn10
			//
			this.GridColumn10.Caption = "GridColumn10";
			this.GridColumn10.Name = "GridColumn10";
			this.GridColumn10.Width = 33;
			//
			//GridColumn11
			//
			this.GridColumn11.Caption = "GridColumn11";
			this.GridColumn11.Name = "GridColumn11";
			this.GridColumn11.Width = 33;
			//
			//GridColumn12
			//
			this.GridColumn12.Caption = "GridColumn12";
			this.GridColumn12.Name = "GridColumn12";
			this.GridColumn12.Width = 33;
			//
			//GridColumn13
			//
			this.GridColumn13.Caption = "GridColumn13";
			this.GridColumn13.Name = "GridColumn13";
			this.GridColumn13.Width = 57;
			//
			//GridColumn1
			//
			this.GridColumn1.Caption = "GridColumn1";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.Visible = true;
			this.GridColumn1.VisibleIndex = 4;
			//
			//GridColumn2
			//
			this.GridColumn2.Caption = "GridColumn2";
			this.GridColumn2.Name = "GridColumn2";
			this.GridColumn2.Visible = true;
			this.GridColumn2.VisibleIndex = 5;
			//
			//GridColumn3
			//
			this.GridColumn3.Caption = "GridColumn3";
			this.GridColumn3.Name = "GridColumn3";
			this.GridColumn3.Visible = true;
			this.GridColumn3.VisibleIndex = 6;
			//
			//GridColumn6
			//
			this.GridColumn6.Caption = "GridColumn6";
			this.GridColumn6.Name = "GridColumn6";
			this.GridColumn6.Visible = true;
			this.GridColumn6.VisibleIndex = 7;
			//
			//GridColumn7
			//
			this.GridColumn7.Caption = "GridColumn7";
			this.GridColumn7.Name = "GridColumn7";
			this.GridColumn7.Visible = true;
			this.GridColumn7.VisibleIndex = 8;
			//
			//cmbPriceMode
			//
			this.cmbPriceMode.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmbPriceMode.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(0)), System.Convert.ToInt32(System.Convert.ToByte(192)), System.Convert.ToInt32(System.Convert.ToByte(0)));
			this.cmbPriceMode.FormattingEnabled = true;
			this.cmbPriceMode.Items.AddRange(new object[] {"Retail", "Wholesale", "Refund"});
			this.cmbPriceMode.Location = new System.Drawing.Point(1055, 39);
			this.cmbPriceMode.Name = "cmbPriceMode";
			this.cmbPriceMode.Size = new System.Drawing.Size(281, 37);
			this.cmbPriceMode.TabIndex = 43;
			this.cmbPriceMode.Text = "Retail";
			//
			//cmbPaymentType
			//
			this.cmbPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmbPaymentType.ForeColor = System.Drawing.Color.Green;
			this.cmbPaymentType.FormattingEnabled = true;
			this.cmbPaymentType.Items.AddRange(new object[] {"CASH", "CREDIT", "CHEQUE"});
			this.cmbPaymentType.Location = new System.Drawing.Point(1057, 418);
			this.cmbPaymentType.Name = "cmbPaymentType";
			this.cmbPaymentType.Size = new System.Drawing.Size(277, 37);
			this.cmbPaymentType.TabIndex = 44;
			this.cmbPaymentType.Text = "CASH";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.Blue;
			this.Label4.Location = new System.Drawing.Point(1049, 117);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(291, 29);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "A m o u n t   T e n d e r e d";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(1057, 226);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(136, 13);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "-------------------------------------------";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.Red;
			this.Label8.Location = new System.Drawing.Point(1049, 196);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(127, 29);
			this.Label8.TabIndex = 12;
			this.Label8.Text = "C h a n g e";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ceRefno
			//
			this.ceRefno.Enabled = false;
			this.ceRefno.Location = new System.Drawing.Point(1170, 83);
			this.ceRefno.Name = "ceRefno";
			this.ceRefno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ceRefno.Properties.Appearance.Options.UseFont = true;
			this.ceRefno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceRefno.Size = new System.Drawing.Size(144, 26);
			this.ceRefno.TabIndex = 49;
			//
			//txtTendered
			//
			this.txtTendered.BackColor = System.Drawing.Color.White;
			this.txtTendered.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (27.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtTendered.ForeColor = System.Drawing.Color.Blue;
			this.txtTendered.Location = new System.Drawing.Point(1055, 149);
			this.txtTendered.Name = "txtTendered";
			this.txtTendered.ReadOnly = true;
			this.txtTendered.Size = new System.Drawing.Size(280, 49);
			this.txtTendered.TabIndex = 54;
			this.txtTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//lblChange
			//
			this.lblChange.BackColor = System.Drawing.Color.White;
			this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (27.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblChange.ForeColor = System.Drawing.Color.Red;
			this.lblChange.Location = new System.Drawing.Point(1055, 232);
			this.lblChange.Name = "lblChange";
			this.lblChange.ReadOnly = true;
			this.lblChange.Size = new System.Drawing.Size(280, 49);
			this.lblChange.TabIndex = 55;
			this.lblChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(12, 690);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(78, 20);
			this.Label3.TabIndex = 57;
			this.Label3.Text = "Customer";
			//
			//txtcustid
			//
			this.txtcustid.Enabled = false;
			this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtcustid.Location = new System.Drawing.Point(96, 684);
			this.txtcustid.Name = "txtcustid";
			this.txtcustid.Size = new System.Drawing.Size(67, 26);
			this.txtcustid.TabIndex = 58;
			this.txtcustid.Text = "205";
			//
			//txtlastname
			//
			this.txtlastname.Enabled = false;
			this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtlastname.Location = new System.Drawing.Point(169, 684);
			this.txtlastname.Name = "txtlastname";
			this.txtlastname.Size = new System.Drawing.Size(143, 26);
			this.txtlastname.TabIndex = 58;
			this.txtlastname.Text = "CASH";
			//
			//txtfirstname
			//
			this.txtfirstname.Enabled = false;
			this.txtfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtfirstname.Location = new System.Drawing.Point(318, 684);
			this.txtfirstname.Name = "txtfirstname";
			this.txtfirstname.Size = new System.Drawing.Size(143, 26);
			this.txtfirstname.TabIndex = 58;
			//
			//txtStckid
			//
			this.txtStckid.Enabled = false;
			this.txtStckid.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtStckid.Location = new System.Drawing.Point(971, 4);
			this.txtStckid.Name = "txtStckid";
			this.txtStckid.Size = new System.Drawing.Size(55, 20);
			this.txtStckid.TabIndex = 59;
			this.txtStckid.Visible = false;
			//
			//txtbcodes
			//
			this.txtbcodes.Enabled = false;
			this.txtbcodes.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtbcodes.Location = new System.Drawing.Point(679, 5);
			this.txtbcodes.MaxLength = 22;
			this.txtbcodes.Name = "txtbcodes";
			this.txtbcodes.Size = new System.Drawing.Size(94, 29);
			this.txtbcodes.TabIndex = 61;
			this.txtbcodes.Visible = false;
			//
			//txtqty
			//
			this.txtqty.Enabled = false;
			this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtqty.Location = new System.Drawing.Point(615, 7);
			this.txtqty.MaxLength = 22;
			this.txtqty.Name = "txtqty";
			this.txtqty.Size = new System.Drawing.Size(45, 29);
			this.txtqty.TabIndex = 61;
			this.txtqty.Visible = false;
			//
			//btnSearchItems
			//
			this.btnSearchItems.Image = (System.Drawing.Image) (resources.GetObject("btnSearchItems.Image"));
			this.btnSearchItems.Location = new System.Drawing.Point(957, 3);
			this.btnSearchItems.Name = "btnSearchItems";
			this.btnSearchItems.Size = new System.Drawing.Size(97, 30);
			this.btnSearchItems.TabIndex = 64;
			this.btnSearchItems.Text = "Find &Item";
			//
			//btnCustomers
			//
			this.btnCustomers.Image = (System.Drawing.Image) (resources.GetObject("btnCustomers.Image"));
			this.btnCustomers.Location = new System.Drawing.Point(467, 684);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(117, 26);
			this.btnCustomers.TabIndex = 65;
			this.btnCustomers.Text = "Find &Customer";
			//
			//btnPriceMode
			//
			this.btnPriceMode.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnPriceMode.Appearance.Options.UseFont = true;
			this.btnPriceMode.Location = new System.Drawing.Point(1054, 3);
			this.btnPriceMode.Name = "btnPriceMode";
			this.btnPriceMode.Size = new System.Drawing.Size(282, 30);
			this.btnPriceMode.TabIndex = 66;
			this.btnPriceMode.Text = "S e &l l    T y p e";
			//
			//btnSaves
			//
			this.btnSaves.Image = (System.Drawing.Image) (resources.GetObject("btnSaves.Image"));
			this.btnSaves.Location = new System.Drawing.Point(1055, 286);
			this.btnSaves.Name = "btnSaves";
			this.btnSaves.Size = new System.Drawing.Size(138, 38);
			this.btnSaves.TabIndex = 67;
			this.btnSaves.Text = "Take &Payment(F12)";
			//
			//btnCreditPay
			//
			this.btnCreditPay.Image = (System.Drawing.Image) (resources.GetObject("btnCreditPay.Image"));
			this.btnCreditPay.Location = new System.Drawing.Point(1205, 286);
			this.btnCreditPay.Name = "btnCreditPay";
			this.btnCreditPay.Size = new System.Drawing.Size(131, 38);
			this.btnCreditPay.TabIndex = 68;
			this.btnCreditPay.Text = "Pa&y Credit(F3)";
			//
			//btnSuspend
			//
			this.btnSuspend.Image = (System.Drawing.Image) (resources.GetObject("btnSuspend.Image"));
			this.btnSuspend.Location = new System.Drawing.Point(1054, 329);
			this.btnSuspend.Name = "btnSuspend";
			this.btnSuspend.Size = new System.Drawing.Size(138, 38);
			this.btnSuspend.TabIndex = 69;
			this.btnSuspend.Text = "Suspend(F5)";
			//
			//btnRetrieve
			//
			this.btnRetrieve.Image = (System.Drawing.Image) (resources.GetObject("btnRetrieve.Image"));
			this.btnRetrieve.Location = new System.Drawing.Point(1205, 329);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(131, 38);
			this.btnRetrieve.TabIndex = 70;
			this.btnRetrieve.Text = "Retrieve(F6)";
			//
			//btnChequePayment
			//
			this.btnChequePayment.Enabled = false;
			this.btnChequePayment.Image = (System.Drawing.Image) (resources.GetObject("btnChequePayment.Image"));
			this.btnChequePayment.Location = new System.Drawing.Point(1204, 372);
			this.btnChequePayment.Name = "btnChequePayment";
			this.btnChequePayment.Size = new System.Drawing.Size(131, 41);
			this.btnChequePayment.TabIndex = 71;
			this.btnChequePayment.Text = "Ch&eque Payment";
			//
			//btnType
			//
			this.btnType.Image = (System.Drawing.Image) (resources.GetObject("btnType.Image"));
			this.btnType.Location = new System.Drawing.Point(1055, 372);
			this.btnType.Name = "btnType";
			this.btnType.Size = new System.Drawing.Size(137, 41);
			this.btnType.TabIndex = 72;
			this.btnType.Text = "&Type of Payment";
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LabelControl1.Location = new System.Drawing.Point(1054, 90);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(99, 19);
			this.LabelControl1.TabIndex = 73;
			this.LabelControl1.Text = "Reference No.";
			//
			//btnRemove
			//
			this.btnRemove.Image = (System.Drawing.Image) (resources.GetObject("btnRemove.Image"));
			this.btnRemove.Location = new System.Drawing.Point(1055, 461);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(137, 41);
			this.btnRemove.TabIndex = 74;
			this.btnRemove.Text = "&Remove Item";
			//
			//btnLookuprice
			//
			this.btnLookuprice.Image = (System.Drawing.Image) (resources.GetObject("btnLookuprice.Image"));
			this.btnLookuprice.Location = new System.Drawing.Point(590, 678);
			this.btnLookuprice.Name = "btnLookuprice";
			this.btnLookuprice.Size = new System.Drawing.Size(129, 41);
			this.btnLookuprice.TabIndex = 75;
			this.btnLookuprice.Text = "Price Lookup(F2)";
			//
			//btnPickup
			//
			this.btnPickup.Image = (System.Drawing.Image) (resources.GetObject("btnPickup.Image"));
			this.btnPickup.Location = new System.Drawing.Point(732, 678);
			this.btnPickup.Name = "btnPickup";
			this.btnPickup.Size = new System.Drawing.Size(102, 41);
			this.btnPickup.TabIndex = 76;
			this.btnPickup.Text = "&Get Cash";
			//
			//btnReprint
			//
			this.btnReprint.Image = (System.Drawing.Image) (resources.GetObject("btnReprint.Image"));
			this.btnReprint.Location = new System.Drawing.Point(1204, 461);
			this.btnReprint.Name = "btnReprint";
			this.btnReprint.Size = new System.Drawing.Size(131, 41);
			this.btnReprint.TabIndex = 77;
			this.btnReprint.Text = "Re-Print(F8)";
			//
			//SimpleButton5
			//
			this.SimpleButton5.Image = (System.Drawing.Image) (resources.GetObject("SimpleButton5.Image"));
			this.SimpleButton5.Location = new System.Drawing.Point(1055, 511);
			this.SimpleButton5.Name = "SimpleButton5";
			this.SimpleButton5.Size = new System.Drawing.Size(46, 36);
			this.SimpleButton5.TabIndex = 78;
			//
			//SimpleButton6
			//
			this.SimpleButton6.Image = (System.Drawing.Image) (resources.GetObject("SimpleButton6.Image"));
			this.SimpleButton6.Location = new System.Drawing.Point(1055, 552);
			this.SimpleButton6.Name = "SimpleButton6";
			this.SimpleButton6.Size = new System.Drawing.Size(46, 36);
			this.SimpleButton6.TabIndex = 79;
			//
			//SimpleButton7
			//
			this.SimpleButton7.Image = (System.Drawing.Image) (resources.GetObject("SimpleButton7.Image"));
			this.SimpleButton7.Location = new System.Drawing.Point(1057, 593);
			this.SimpleButton7.Name = "SimpleButton7";
			this.SimpleButton7.Size = new System.Drawing.Size(46, 36);
			this.SimpleButton7.TabIndex = 80;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LabelControl2.Location = new System.Drawing.Point(1107, 524);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(57, 23);
			this.LabelControl2.TabIndex = 81;
			this.LabelControl2.Text = "NAME:";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LabelControl3.Location = new System.Drawing.Point(1111, 565);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(53, 23);
			this.LabelControl3.TabIndex = 81;
			this.LabelControl3.Text = "DATE:";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.LabelControl4.Location = new System.Drawing.Point(1113, 606);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(51, 23);
			this.LabelControl4.TabIndex = 81;
			this.LabelControl4.Text = "TIME:";
			//
			//lblName
			//
			this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (18.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblName.Location = new System.Drawing.Point(1170, 518);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(70, 29);
			this.lblName.TabIndex = 81;
			this.lblName.Text = "NAME:";
			//
			//lblDate
			//
			this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblDate.Location = new System.Drawing.Point(1170, 565);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(46, 23);
			this.lblDate.TabIndex = 81;
			this.lblDate.Text = "DATE";
			//
			//lblTime
			//
			this.lblTime.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblTime.Location = new System.Drawing.Point(1170, 606);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(44, 23);
			this.lblTime.TabIndex = 81;
			this.lblTime.Text = "TIME";
			//
			//Button1
			//
			this.Button1.Image = (System.Drawing.Image) (resources.GetObject("Button1.Image"));
			this.Button1.Location = new System.Drawing.Point(847, 678);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(115, 41);
			this.Button1.TabIndex = 82;
			this.Button1.Text = "Set &Quantity";
			//
			//btnDiscount
			//
			this.btnDiscount.Image = (System.Drawing.Image) (resources.GetObject("btnDiscount.Image"));
			this.btnDiscount.Location = new System.Drawing.Point(1103, 678);
			this.btnDiscount.Name = "btnDiscount";
			this.btnDiscount.Size = new System.Drawing.Size(105, 41);
			this.btnDiscount.TabIndex = 83;
			this.btnDiscount.Text = "&Discount";
			//
			//btnAddCash
			//
			this.btnAddCash.Image = (System.Drawing.Image) (resources.GetObject("btnAddCash.Image"));
			this.btnAddCash.Location = new System.Drawing.Point(975, 678);
			this.btnAddCash.Name = "btnAddCash";
			this.btnAddCash.Size = new System.Drawing.Size(115, 41);
			this.btnAddCash.TabIndex = 84;
			this.btnAddCash.Text = "Add Cas&h";
			//
			//btnnew
			//
			this.btnnew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btnnew.Appearance.Options.UseFont = true;
			this.btnnew.Image = (System.Drawing.Image) (resources.GetObject("btnnew.Image"));
			this.btnnew.Location = new System.Drawing.Point(1055, 637);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(274, 35);
			this.btnnew.TabIndex = 85;
			this.btnnew.Text = "&N e w   T r a n s a c t i o n";
			//
			//btnBcode
			//
			this.btnBcode.Image = (System.Drawing.Image) (resources.GetObject("btnBcode.Image"));
			this.btnBcode.Location = new System.Drawing.Point(132, 7);
			this.btnBcode.Name = "btnBcode";
			this.btnBcode.Size = new System.Drawing.Size(91, 29);
			this.btnBcode.TabIndex = 86;
			this.btnBcode.Text = "&Barcode";
			this.btnBcode.Visible = false;
			//
			//btnRefund
			//
			this.btnRefund.Image = (System.Drawing.Image) (resources.GetObject("btnRefund.Image"));
			this.btnRefund.Location = new System.Drawing.Point(1221, 678);
			this.btnRefund.Name = "btnRefund";
			this.btnRefund.Size = new System.Drawing.Size(105, 41);
			this.btnRefund.TabIndex = 83;
			this.btnRefund.Text = "Refund(F7)";
			//
			//txtCounts
			//
			this.txtCounts.Enabled = false;
			this.txtCounts.Location = new System.Drawing.Point(1282, 199);
			this.txtCounts.Name = "txtCounts";
			this.txtCounts.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtCounts.Properties.Appearance.Options.UseFont = true;
			this.txtCounts.Size = new System.Drawing.Size(52, 26);
			ToolTipTitleItem1.Text = "ITEMS SOLD";
			ToolTipItem1.LeftIndent = 6;
			ToolTipItem1.Text = "TOTAL COUNT OF ITEMS SOLD";
			SuperToolTip1.Items.Add(ToolTipTitleItem1);
			SuperToolTip1.Items.Add(ToolTipItem1);
			this.txtCounts.SuperTip = SuperToolTip1;
			this.txtCounts.TabIndex = 88;
			this.txtCounts.Visible = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(1202, 207);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(74, 13);
			this.Label1.TabIndex = 89;
			this.Label1.Text = "ITEM COUNT";
			this.Label1.Visible = false;
			//
			//dgEmps
			//
			this.dgEmps.AllowUserToAddRows = false;
			this.dgEmps.AllowUserToDeleteRows = false;
			DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEmps.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16;
			this.dgEmps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgEmps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.wtid, this.waiter});
			DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgEmps.DefaultCellStyle = DataGridViewCellStyle17;
			this.dgEmps.Location = new System.Drawing.Point(363, 149);
			this.dgEmps.Name = "dgEmps";
			this.dgEmps.ReadOnly = true;
			DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgEmps.RowHeadersDefaultCellStyle = DataGridViewCellStyle18;
			this.dgEmps.Size = new System.Drawing.Size(450, 503);
			this.dgEmps.TabIndex = 90;
			this.dgEmps.Visible = false;
			//
			//wtid
			//
			this.wtid.HeaderText = "wtid";
			this.wtid.Name = "wtid";
			this.wtid.ReadOnly = true;
			this.wtid.Visible = false;
			//
			//waiter
			//
			this.waiter.HeaderText = "Employee Name";
			this.waiter.Name = "waiter";
			this.waiter.ReadOnly = true;
			this.waiter.Width = 400;
			//
			//ceWtid
			//
			this.ceWtid.EditValue = new decimal(new int[] {1, 0, 0, 0});
			this.ceWtid.Location = new System.Drawing.Point(1142, 242);
			this.ceWtid.Name = "ceWtid";
			this.ceWtid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceWtid.Size = new System.Drawing.Size(51, 20);
			this.ceWtid.TabIndex = 91;
			this.ceWtid.Visible = false;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(830, 10);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(44, 20);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "QTY";
			//
			//ceQtyy
			//
			this.ceQtyy.Location = new System.Drawing.Point(880, 2);
			this.ceQtyy.Name = "ceQtyy";
			this.ceQtyy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ceQtyy.Properties.Appearance.Options.UseFont = true;
			this.ceQtyy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceQtyy.Size = new System.Drawing.Size(71, 32);
			this.ceQtyy.TabIndex = 2;
			//
			//dgitems
			//
			this.dgitems.AllowUserToAddRows = false;
			DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19;
			this.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgitems.DefaultCellStyle = DataGridViewCellStyle20;
			this.dgitems.Location = new System.Drawing.Point(50, 34);
			this.dgitems.Name = "dgitems";
			this.dgitems.ReadOnly = true;
			this.dgitems.Size = new System.Drawing.Size(1004, 638);
			this.dgitems.TabIndex = 92;
			this.dgitems.Visible = false;
			//
			//frmPOS
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1347, 731);
			this.Controls.Add(this.dgitems);
			this.Controls.Add(this.ceQtyy);
			this.Controls.Add(this.ceWtid);
			this.Controls.Add(this.dgEmps);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtCounts);
			this.Controls.Add(this.btnBcode);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.btnAddCash);
			this.Controls.Add(this.btnRefund);
			this.Controls.Add(this.btnDiscount);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.SimpleButton7);
			this.Controls.Add(this.SimpleButton6);
			this.Controls.Add(this.SimpleButton5);
			this.Controls.Add(this.btnReprint);
			this.Controls.Add(this.btnPickup);
			this.Controls.Add(this.btnLookuprice);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.btnType);
			this.Controls.Add(this.btnChequePayment);
			this.Controls.Add(this.btnRetrieve);
			this.Controls.Add(this.btnSuspend);
			this.Controls.Add(this.btnCreditPay);
			this.Controls.Add(this.btnSaves);
			this.Controls.Add(this.btnPriceMode);
			this.Controls.Add(this.btnCustomers);
			this.Controls.Add(this.btnSearchItems);
			this.Controls.Add(this.txtqty);
			this.Controls.Add(this.txtbcodes);
			this.Controls.Add(this.txtStckid);
			this.Controls.Add(this.txtfirstname);
			this.Controls.Add(this.txtlastname);
			this.Controls.Add(this.txtcustid);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.lblChange);
			this.Controls.Add(this.txtTendered);
			this.Controls.Add(this.ceRefno);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.cmbPaymentType);
			this.Controls.Add(this.cmbPriceMode);
			this.Controls.Add(this.GridLookUpEdit2);
			this.Controls.Add(this.DGRetrieve);
			this.Controls.Add(this.tbSQL);
			this.Controls.Add(this.txtSum);
			this.Controls.Add(this.txtitem);
			this.Controls.Add(this.PosGrid);
			this.Controls.Add(this.txtBarcode);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label2);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPOS";
			this.Text = "Inventory and Sales Monitoring System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize) this.PosGrid).EndInit();
			((System.ComponentModel.ISupportInitialize) this.tbSQL.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DGRetrieve).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridLookUpEdit2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridLookUpEdit2View).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceRefno.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtCounts.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgEmps).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceWtid.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceQtyy.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.dgitems).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.TextBox txtSum;
		internal System.Windows.Forms.TextBox txtitem;
		internal System.Windows.Forms.DataGridView PosGrid;
		internal System.Windows.Forms.Label Label2;
		internal DevExpress.XtraEditors.TextEdit tbSQL;
		internal System.IO.Ports.SerialPort SerialPort1;
		internal System.Windows.Forms.DataGridView DGRetrieve;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit1View;
		internal DevExpress.XtraGrid.Columns.GridColumn colstckid;
		internal DevExpress.XtraGrid.Columns.GridColumn colitem;
		internal DevExpress.XtraGrid.Columns.GridColumn colbarcode;
		internal DevExpress.XtraGrid.Columns.GridColumn colretail;
		internal DevExpress.XtraEditors.GridLookUpEdit GridLookUpEdit2;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridLookUpEdit2View;
		internal DevExpress.XtraGrid.Columns.GridColumn stckid;
		internal DevExpress.XtraGrid.Columns.GridColumn barcode1;
		internal DevExpress.XtraGrid.Columns.GridColumn items;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn9;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn10;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn11;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn12;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn13;
		internal System.Windows.Forms.ComboBox cmbPriceMode;
		internal System.Windows.Forms.ComboBox cmbPaymentType;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label8;
		internal DevExpress.XtraEditors.CalcEdit ceRefno;
		internal System.Windows.Forms.TextBox txtBarcode;
		internal System.Windows.Forms.TextBox txtTendered;
		internal System.Windows.Forms.TextBox lblChange;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtcustid;
		internal System.Windows.Forms.TextBox txtlastname;
		internal System.Windows.Forms.TextBox txtfirstname;
		internal System.Windows.Forms.TextBox txtStckid;
		internal System.Windows.Forms.TextBox txtbcodes;
		internal System.Windows.Forms.TextBox txtqty;
		internal DevExpress.XtraEditors.SimpleButton btnSearchItems;
		internal DevExpress.XtraEditors.SimpleButton btnCustomers;
		internal DevExpress.XtraEditors.SimpleButton btnPriceMode;
		internal DevExpress.XtraEditors.SimpleButton btnSaves;
		internal DevExpress.XtraEditors.SimpleButton btnCreditPay;
		internal DevExpress.XtraEditors.SimpleButton btnSuspend;
		internal DevExpress.XtraEditors.SimpleButton btnRetrieve;
		internal DevExpress.XtraEditors.SimpleButton btnChequePayment;
		internal DevExpress.XtraEditors.SimpleButton btnType;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.SimpleButton btnRemove;
		internal DevExpress.XtraEditors.SimpleButton btnLookuprice;
		internal DevExpress.XtraEditors.SimpleButton btnPickup;
		internal DevExpress.XtraEditors.SimpleButton btnReprint;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton5;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton6;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton7;
		internal System.Windows.Forms.Timer Timer1;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl lblName;
		internal DevExpress.XtraEditors.LabelControl lblDate;
		internal DevExpress.XtraEditors.LabelControl lblTime;
		internal DevExpress.XtraEditors.SimpleButton Button1;
		internal DevExpress.XtraEditors.SimpleButton btnDiscount;
		internal DevExpress.XtraEditors.SimpleButton btnAddCash;
		internal DevExpress.XtraEditors.SimpleButton btnnew;
		internal DevExpress.XtraEditors.SimpleButton btnBcode;
		internal DevExpress.XtraEditors.SimpleButton btnRefund;
		internal DevExpress.XtraEditors.TextEdit txtCounts;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgEmps;
		internal System.Windows.Forms.DataGridViewTextBoxColumn wtid;
		internal System.Windows.Forms.DataGridViewTextBoxColumn waiter;
		public DevExpress.XtraEditors.CalcEdit ceWtid;
		internal System.Windows.Forms.Label Label5;
		internal DevExpress.XtraEditors.CalcEdit ceQtyy;
		internal System.Windows.Forms.DataGridView dgitems;
		internal System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Cost;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Item;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Price;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Total;
		internal System.Windows.Forms.DataGridViewTextBoxColumn OP;
		internal System.Windows.Forms.DataGridViewTextBoxColumn discounts;
		internal System.Windows.Forms.DataGridViewTextBoxColumn Incentv;
		
		
	}
	
}
