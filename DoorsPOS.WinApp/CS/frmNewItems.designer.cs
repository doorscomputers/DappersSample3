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
	partial class frmNewItems : System.Windows.Forms.Form
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
			this.txtBarcode = new DevExpress.XtraEditors.TextEdit();
			base.Load += new System.EventHandler(frmNewItems_Load);
			this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			this.txtBarcode.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtBarcode_Layout);
			this.txtBarcode.LostFocus += new System.EventHandler(this.txtBarcode_LostFocus);
			this.txtBarcode.EditValueChanged += new System.EventHandler(this.txtBarcode_EditValueChanged);
			this.txtItem = new DevExpress.XtraEditors.TextEdit();
			this.txtItem.LostFocus += new System.EventHandler(this.txtItem_LostFocus);
			this.leSuppliers = new DevExpress.XtraEditors.LookUpEdit();
			this.leCategories = new DevExpress.XtraEditors.LookUpEdit();
			this.ceCost = new DevExpress.XtraEditors.CalcEdit();
			this.ceWholesale = new DevExpress.XtraEditors.CalcEdit();
			this.ceWholesale.LostFocus += new System.EventHandler(this.ceWholesale_LostFocus);
			this.ceMin = new DevExpress.XtraEditors.CalcEdit();
			this.ceMax = new DevExpress.XtraEditors.CalcEdit();
			this.btnNew = new DevExpress.XtraEditors.SimpleButton();
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.compretail = new DevExpress.XtraEditors.TextEdit();
			this.compmup2 = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.compmup1 = new DevExpress.XtraEditors.CalcEdit();
			this.compmup1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compmup1_KeyPress);
			this.compwholesale = new DevExpress.XtraEditors.CalcEdit();
			this.compwholesale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.compwholesale_KeyPress);
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.leType = new DevExpress.XtraEditors.LookUpEdit();
			this.ceRetail = new DevExpress.XtraEditors.CalcEdit();
			this.ceRetail.LostFocus += new System.EventHandler(this.ceRetail_LostFocus);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.leBrand = new DevExpress.XtraEditors.LookUpEdit();
			((System.ComponentModel.ISupportInitialize) this.txtBarcode.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtItem.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leSuppliers.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leCategories.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceWholesale.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceMin.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceMax.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.compretail.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.compmup2.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.compmup1.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.compwholesale.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.leType.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceRetail.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.leBrand.Properties).BeginInit();
			this.SuspendLayout();
			//
			//txtBarcode
			//
			this.txtBarcode.EnterMoveNextControl = true;
			this.txtBarcode.Location = new System.Drawing.Point(202, 13);
			this.txtBarcode.Name = "txtBarcode";
			this.txtBarcode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtBarcode.Properties.Appearance.Options.UseFont = true;
			this.txtBarcode.Size = new System.Drawing.Size(217, 26);
			this.txtBarcode.TabIndex = 0;
			//
			//txtItem
			//
			this.txtItem.EnterMoveNextControl = true;
			this.txtItem.Location = new System.Drawing.Point(202, 49);
			this.txtItem.Name = "txtItem";
			this.txtItem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtItem.Properties.Appearance.Options.UseFont = true;
			this.txtItem.Size = new System.Drawing.Size(441, 26);
			this.txtItem.TabIndex = 1;
			//
			//leSuppliers
			//
			this.leSuppliers.EditValue = "<Null>";
			this.leSuppliers.Enabled = false;
			this.leSuppliers.EnterMoveNextControl = true;
			this.leSuppliers.Location = new System.Drawing.Point(202, 85);
			this.leSuppliers.Margin = new System.Windows.Forms.Padding(2);
			this.leSuppliers.Name = "leSuppliers";
			this.leSuppliers.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leSuppliers.Properties.Appearance.Options.UseFont = true;
			this.leSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leSuppliers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supcode", "supcode", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("supplier", "Supplier")});
			this.leSuppliers.Size = new System.Drawing.Size(441, 26);
			this.leSuppliers.TabIndex = 2;
			//
			//leCategories
			//
			this.leCategories.Enabled = false;
			this.leCategories.EnterMoveNextControl = true;
			this.leCategories.Location = new System.Drawing.Point(202, 121);
			this.leCategories.Margin = new System.Windows.Forms.Padding(2);
			this.leCategories.Name = "leCategories";
			this.leCategories.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leCategories.Properties.Appearance.Options.UseFont = true;
			this.leCategories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leCategories.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("categoryid", "categoryid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("catgory", "Category")});
			this.leCategories.Properties.DropDownRows = 15;
			this.leCategories.Size = new System.Drawing.Size(441, 26);
			this.leCategories.TabIndex = 3;
			//
			//ceCost
			//
			this.ceCost.EnterMoveNextControl = true;
			this.ceCost.Location = new System.Drawing.Point(202, 230);
			this.ceCost.Margin = new System.Windows.Forms.Padding(2);
			this.ceCost.Name = "ceCost";
			this.ceCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceCost.Properties.Appearance.Options.UseFont = true;
			this.ceCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceCost.Size = new System.Drawing.Size(91, 26);
			this.ceCost.TabIndex = 6;
			//
			//ceWholesale
			//
			this.ceWholesale.EnterMoveNextControl = true;
			this.ceWholesale.Location = new System.Drawing.Point(202, 301);
			this.ceWholesale.Margin = new System.Windows.Forms.Padding(2);
			this.ceWholesale.Name = "ceWholesale";
			this.ceWholesale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceWholesale.Properties.Appearance.Options.UseFont = true;
			this.ceWholesale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceWholesale.Size = new System.Drawing.Size(91, 26);
			this.ceWholesale.TabIndex = 8;
			//
			//ceMin
			//
			this.ceMin.EnterMoveNextControl = true;
			this.ceMin.Location = new System.Drawing.Point(202, 336);
			this.ceMin.Margin = new System.Windows.Forms.Padding(2);
			this.ceMin.Name = "ceMin";
			this.ceMin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceMin.Properties.Appearance.Options.UseFont = true;
			this.ceMin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceMin.Size = new System.Drawing.Size(91, 26);
			this.ceMin.TabIndex = 9;
			//
			//ceMax
			//
			this.ceMax.EnterMoveNextControl = true;
			this.ceMax.Location = new System.Drawing.Point(202, 372);
			this.ceMax.Margin = new System.Windows.Forms.Padding(2);
			this.ceMax.Name = "ceMax";
			this.ceMax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceMax.Properties.Appearance.Options.UseFont = true;
			this.ceMax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceMax.Size = new System.Drawing.Size(91, 26);
			this.ceMax.TabIndex = 10;
			//
			//btnNew
			//
			this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.0F));
			this.btnNew.Appearance.Options.UseFont = true;
			this.btnNew.Location = new System.Drawing.Point(9, 420);
			this.btnNew.Margin = new System.Windows.Forms.Padding(2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(81, 39);
			this.btnNew.TabIndex = 12;
			this.btnNew.Text = "&New";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (10.0F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(115, 420);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(81, 39);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "&Save";
			//
			//btnCancel
			//
			this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (10.0F));
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.Enabled = false;
			this.btnCancel.Location = new System.Drawing.Point(221, 420);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(81, 39);
			this.btnCancel.TabIndex = 24;
			this.btnCancel.Text = "&Cancel";
			//
			//btnClose
			//
			this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (10.0F));
			this.btnClose.Appearance.Options.UseFont = true;
			this.btnClose.Location = new System.Drawing.Point(559, 420);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(81, 39);
			this.btnClose.TabIndex = 25;
			this.btnClose.Text = "C&lose";
			//
			//compretail
			//
			this.compretail.Location = new System.Drawing.Point(186, 58);
			this.compretail.Name = "compretail";
			this.compretail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.compretail.Properties.Appearance.Options.UseFont = true;
			this.compretail.Size = new System.Drawing.Size(105, 26);
			this.compretail.TabIndex = 1;
			//
			//compmup2
			//
			this.compmup2.Location = new System.Drawing.Point(186, 95);
			this.compmup2.Name = "compmup2";
			this.compmup2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.compmup2.Properties.Appearance.Options.UseFont = true;
			this.compmup2.Size = new System.Drawing.Size(105, 26);
			this.compmup2.TabIndex = 2;
			//
			//LabelControl17
			//
			this.LabelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl17.Location = new System.Drawing.Point(54, 23);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(116, 19);
			this.LabelControl17.TabIndex = 4;
			this.LabelControl17.Text = "Markup1 (Input)";
			//
			//LabelControl18
			//
			this.LabelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl18.Location = new System.Drawing.Point(46, 65);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(124, 19);
			this.LabelControl18.TabIndex = 5;
			this.LabelControl18.Text = "Retail(Computed)";
			//
			//LabelControl20
			//
			this.LabelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl20.Location = new System.Drawing.Point(76, 137);
			this.LabelControl20.Name = "LabelControl20";
			this.LabelControl20.Size = new System.Drawing.Size(94, 19);
			this.LabelControl20.TabIndex = 7;
			this.LabelControl20.Text = "Retail (Input)";
			//
			//compmup1
			//
			this.compmup1.EnterMoveNextControl = true;
			this.compmup1.Location = new System.Drawing.Point(186, 23);
			this.compmup1.Margin = new System.Windows.Forms.Padding(2);
			this.compmup1.Name = "compmup1";
			this.compmup1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.compmup1.Properties.Appearance.Options.UseFont = true;
			this.compmup1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.compmup1.Size = new System.Drawing.Size(105, 26);
			this.compmup1.TabIndex = 0;
			//
			//compwholesale
			//
			this.compwholesale.EnterMoveNextControl = true;
			this.compwholesale.Location = new System.Drawing.Point(186, 130);
			this.compwholesale.Margin = new System.Windows.Forms.Padding(2);
			this.compwholesale.Name = "compwholesale";
			this.compwholesale.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.compwholesale.Properties.Appearance.Options.UseFont = true;
			this.compwholesale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.compwholesale.Size = new System.Drawing.Size(105, 26);
			this.compwholesale.TabIndex = 3;
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.LabelControl19);
			this.GroupControl1.Controls.Add(this.compwholesale);
			this.GroupControl1.Controls.Add(this.compmup1);
			this.GroupControl1.Controls.Add(this.LabelControl20);
			this.GroupControl1.Controls.Add(this.LabelControl18);
			this.GroupControl1.Controls.Add(this.LabelControl17);
			this.GroupControl1.Controls.Add(this.compmup2);
			this.GroupControl1.Controls.Add(this.compretail);
			this.GroupControl1.Location = new System.Drawing.Point(314, 229);
			this.GroupControl1.Margin = new System.Windows.Forms.Padding(2);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(328, 173);
			this.GroupControl1.TabIndex = 26;
			this.GroupControl1.Text = "Markup and Retail Computations";
			//
			//LabelControl19
			//
			this.LabelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl19.Location = new System.Drawing.Point(24, 102);
			this.LabelControl19.Name = "LabelControl19";
			this.LabelControl19.Size = new System.Drawing.Size(146, 19);
			this.LabelControl19.TabIndex = 6;
			this.LabelControl19.Text = "Markup2(Computed)";
			//
			//leType
			//
			this.leType.Enabled = false;
			this.leType.EnterMoveNextControl = true;
			this.leType.Location = new System.Drawing.Point(202, 193);
			this.leType.Margin = new System.Windows.Forms.Padding(2);
			this.leType.Name = "leType";
			this.leType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leType.Properties.Appearance.Options.UseFont = true;
			this.leType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sizeid", "sizeid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("sayz", "Type")});
			this.leType.Size = new System.Drawing.Size(441, 26);
			this.leType.TabIndex = 5;
			//
			//ceRetail
			//
			this.ceRetail.EnterMoveNextControl = true;
			this.ceRetail.Location = new System.Drawing.Point(202, 266);
			this.ceRetail.Margin = new System.Windows.Forms.Padding(2);
			this.ceRetail.Name = "ceRetail";
			this.ceRetail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceRetail.Properties.Appearance.Options.UseFont = true;
			this.ceRetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceRetail.Size = new System.Drawing.Size(91, 26);
			this.ceRetail.TabIndex = 7;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(109, 14);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(85, 20);
			this.Label1.TabIndex = 27;
			this.Label1.Text = "Item Code";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(62, 55);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(132, 20);
			this.Label2.TabIndex = 27;
			this.Label2.Text = "Item Description";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label3.Location = new System.Drawing.Point(124, 91);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(70, 20);
			this.Label3.TabIndex = 27;
			this.Label3.Text = "Supplier";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label4.Location = new System.Drawing.Point(118, 127);
			this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(76, 20);
			this.Label4.TabIndex = 27;
			this.Label4.Text = "Category";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label5.Location = new System.Drawing.Point(140, 163);
			this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(54, 20);
			this.Label5.TabIndex = 27;
			this.Label5.Text = "Brand";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label6.Location = new System.Drawing.Point(149, 199);
			this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(45, 20);
			this.Label6.TabIndex = 27;
			this.Label6.Text = "Type";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label7.Location = new System.Drawing.Point(150, 236);
			this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(44, 20);
			this.Label7.TabIndex = 27;
			this.Label7.Text = "Cost";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label8.Location = new System.Drawing.Point(142, 272);
			this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(52, 20);
			this.Label8.TabIndex = 27;
			this.Label8.Text = "Retail";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label9.Location = new System.Drawing.Point(102, 307);
			this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(92, 20);
			this.Label9.TabIndex = 27;
			this.Label9.Text = "Whole sale";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label10.Location = new System.Drawing.Point(117, 342);
			this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(77, 20);
			this.Label10.TabIndex = 27;
			this.Label10.Text = "Minimum";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label11.Location = new System.Drawing.Point(113, 378);
			this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(81, 20);
			this.Label11.TabIndex = 27;
			this.Label11.Text = "Maximum";
			//
			//leBrand
			//
			this.leBrand.Enabled = false;
			this.leBrand.EnterMoveNextControl = true;
			this.leBrand.Location = new System.Drawing.Point(203, 157);
			this.leBrand.Name = "leBrand";
			this.leBrand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.leBrand.Properties.Appearance.Options.UseFont = true;
			this.leBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.leBrand.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {new DevExpress.XtraEditors.Controls.LookUpColumnInfo("deptid", "deptid", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPTD", "DEPTD")});
			this.leBrand.Size = new System.Drawing.Size(440, 26);
			this.leBrand.TabIndex = 4;
			//
			//frmNewItems
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(661, 469);
			this.Controls.Add(this.leBrand);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.leType);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.ceMax);
			this.Controls.Add(this.ceMin);
			this.Controls.Add(this.ceWholesale);
			this.Controls.Add(this.ceRetail);
			this.Controls.Add(this.ceCost);
			this.Controls.Add(this.leCategories);
			this.Controls.Add(this.leSuppliers);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.txtBarcode);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNewItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Items Entry Form";
			((System.ComponentModel.ISupportInitialize) this.txtBarcode.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtItem.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leSuppliers.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leCategories.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceCost.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceWholesale.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceMin.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceMax.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.compretail.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.compmup2.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.compmup1.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.compwholesale.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.leType.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceRetail.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.leBrand.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.TextEdit txtBarcode;
		internal DevExpress.XtraEditors.TextEdit txtItem;
		internal DevExpress.XtraEditors.LookUpEdit leSuppliers;
		internal DevExpress.XtraEditors.LookUpEdit leCategories;
		internal DevExpress.XtraEditors.CalcEdit ceCost;
		internal DevExpress.XtraEditors.CalcEdit ceWholesale;
		internal DevExpress.XtraEditors.CalcEdit ceMin;
		internal DevExpress.XtraEditors.CalcEdit ceMax;
		internal DevExpress.XtraEditors.SimpleButton btnNew;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnCancel;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.TextEdit compretail;
		internal DevExpress.XtraEditors.TextEdit compmup2;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl20;
		internal DevExpress.XtraEditors.CalcEdit compmup1;
		internal DevExpress.XtraEditors.CalcEdit compwholesale;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl19;
		internal DevExpress.XtraEditors.LookUpEdit leType;
		internal DevExpress.XtraEditors.CalcEdit ceRetail;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal DevExpress.XtraEditors.LookUpEdit leBrand;
	}
	
}
