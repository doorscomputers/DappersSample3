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
	partial class frmSuppliers : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSuppliers_Load);
			this.simBtnSave = new DevExpress.XtraEditors.SimpleButton();
			this.simBtnSave.Click += new System.EventHandler(this.simBtnSave_Click);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsSupplierss = new DoorsPOS.WinApp.dsSupplierss();
			this.grdSuppliers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.SupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LocationAdd = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TelNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.CP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TinNo = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Faxno = new DevExpress.XtraGrid.Columns.GridColumn();
			this.c1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			this.suppliersTableAdapter = new DoorsPOS.WinApp.dsSupplierssTableAdapters.suppliersTableAdapter();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.SuppliersBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsSupplierss).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.grdSuppliers).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).BeginInit();
			this.SuspendLayout();
			//
			//simBtnSave
			//
			this.simBtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.simBtnSave.Appearance.ForeColor = System.Drawing.Color.Red;
			this.simBtnSave.Appearance.Options.UseFont = true;
			this.simBtnSave.Appearance.Options.UseForeColor = true;
			this.simBtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.simBtnSave.Location = new System.Drawing.Point(0, 356);
			this.simBtnSave.Name = "simBtnSave";
			this.simBtnSave.Size = new System.Drawing.Size(942, 23);
			this.simBtnSave.TabIndex = 3;
			this.simBtnSave.Text = "&Save";
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.SuppliersBindingSource;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.grdSuppliers;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(942, 356);
			this.GridControl1.TabIndex = 4;
			this.GridControl1.UseEmbeddedNavigator = true;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdSuppliers});
			//
			//SuppliersBindingSource
			//
			this.SuppliersBindingSource.DataMember = "suppliers";
			this.SuppliersBindingSource.DataSource = this.DsSupplierss;
			//
			//DsSupplierss
			//
			this.DsSupplierss.DataSetName = "dsSupplierss";
			this.DsSupplierss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//grdSuppliers
			//
			this.grdSuppliers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.SupplierName, this.LocationAdd, this.TelNo, this.CP, this.TinNo, this.Faxno});
			this.grdSuppliers.GridControl = this.GridControl1;
			this.grdSuppliers.Name = "grdSuppliers";
			this.grdSuppliers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.grdSuppliers.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
			this.grdSuppliers.OptionsEditForm.EditFormColumnCount = 1;
			this.grdSuppliers.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
			//
			//SupplierName
			//
			this.SupplierName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.SupplierName.AppearanceCell.Options.UseFont = true;
			this.SupplierName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.SupplierName.AppearanceHeader.Options.UseFont = true;
			this.SupplierName.Caption = "Supplier Name";
			this.SupplierName.FieldName = "supplier";
			this.SupplierName.Name = "SupplierName";
			this.SupplierName.Visible = true;
			this.SupplierName.VisibleIndex = 0;
			//
			//LocationAdd
			//
			this.LocationAdd.Caption = "Address/Location";
			this.LocationAdd.FieldName = "address";
			this.LocationAdd.Name = "LocationAdd";
			this.LocationAdd.Visible = true;
			this.LocationAdd.VisibleIndex = 1;
			//
			//TelNo
			//
			this.TelNo.Caption = "Telephone No";
			this.TelNo.FieldName = "telno";
			this.TelNo.Name = "TelNo";
			this.TelNo.Visible = true;
			this.TelNo.VisibleIndex = 2;
			//
			//CP
			//
			this.CP.Caption = "Cellphone No.";
			this.CP.FieldName = "phone1";
			this.CP.Name = "CP";
			this.CP.Visible = true;
			this.CP.VisibleIndex = 3;
			//
			//TinNo
			//
			this.TinNo.Caption = "Tin No.";
			this.TinNo.FieldName = "tinno";
			this.TinNo.Name = "TinNo";
			this.TinNo.Visible = true;
			this.TinNo.VisibleIndex = 4;
			//
			//Faxno
			//
			this.Faxno.Caption = "Fax No";
			this.Faxno.FieldName = "faxno";
			this.Faxno.Name = "Faxno";
			this.Faxno.Visible = true;
			this.Faxno.VisibleIndex = 5;
			//
			//c1DataViewSet1
			//
			this.c1DataViewSet1.DataSet = this.DsSupplierss;
			this.c1DataViewSet1.DiagramXML = "";
			//
			//suppliersTableAdapter
			//
			this.suppliersTableAdapter.ClearBeforeFill = true;
			//
			//frmSuppliers
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(942, 379);
			this.Controls.Add(this.GridControl1);
			this.Controls.Add(this.simBtnSave);
			this.Name = "frmSuppliers";
			this.Text = "Suppliers";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.SuppliersBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsSupplierss).EndInit();
			((System.ComponentModel.ISupportInitialize) this.grdSuppliers).EndInit();
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraEditors.SimpleButton simBtnSave;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView grdSuppliers;
		internal C1.C1DataExtender.C1DataViewSet c1DataViewSet1;
		internal DevExpress.XtraGrid.Columns.GridColumn SupplierName;
		internal DevExpress.XtraGrid.Columns.GridColumn LocationAdd;
		internal DevExpress.XtraGrid.Columns.GridColumn TelNo;
		internal DevExpress.XtraGrid.Columns.GridColumn CP;
		internal DevExpress.XtraGrid.Columns.GridColumn TinNo;
		internal DevExpress.XtraGrid.Columns.GridColumn Faxno;
		internal DoorsPOS.WinApp.dsSupplierss DsSupplierss;
		internal System.Windows.Forms.BindingSource SuppliersBindingSource;
		internal DoorsPOS.WinApp.dsSupplierssTableAdapters.suppliersTableAdapter suppliersTableAdapter;
	}
	
}
