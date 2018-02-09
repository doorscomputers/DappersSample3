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
	partial class frmEmployee : System.Windows.Forms.Form
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
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.DsEmployees1 = new DoorsPOS.WinApp.dsEmployees();
			this.grdEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colwtid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colwaiter = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colpword = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.WaitersTableAdapter1 = new DoorsPOS.WinApp.dsEmployeesTableAdapters.waitersTableAdapter();
			this.c1DataViewSet1 = new C1.C1DataExtender.C1DataViewSet();
			this.simBtnSave = new DevExpress.XtraEditors.SimpleButton();
			this.simBtnSave.Click += new System.EventHandler(this.simBtnSave_Click);
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.BindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsEmployees1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.grdEmployees).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemTextEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).BeginInit();
			this.SuspendLayout();
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.DataSource = this.BindingSource1;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.grdEmployees;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemTextEdit1});
			this.GridControl1.Size = new System.Drawing.Size(839, 369);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.UseEmbeddedNavigator = true;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdEmployees});
			//
			//BindingSource1
			//
			this.BindingSource1.DataMember = "waiters";
			this.BindingSource1.DataSource = this.DsEmployees1;
			this.BindingSource1.Sort = "";
			//
			//DsEmployees1
			//
			this.DsEmployees1.DataSetName = "dsEmployees";
			this.DsEmployees1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//grdEmployees
			//
			this.grdEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colwtid, this.colwaiter, this.colpword});
			this.grdEmployees.GridControl = this.GridControl1;
			this.grdEmployees.Name = "grdEmployees";
			this.grdEmployees.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
			this.grdEmployees.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
			this.grdEmployees.OptionsEditForm.EditFormColumnCount = 1;
			this.grdEmployees.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
			this.grdEmployees.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
			//
			//colwtid
			//
			this.colwtid.AppearanceCell.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.colwtid.AppearanceCell.Options.UseFont = true;
			this.colwtid.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.colwtid.AppearanceHeader.Options.UseFont = true;
			this.colwtid.FieldName = "wtid";
			this.colwtid.Name = "colwtid";
			this.colwtid.OptionsColumn.ReadOnly = true;
			//
			//colwaiter
			//
			this.colwaiter.Caption = "Employee Name";
			this.colwaiter.FieldName = "waiter";
			this.colwaiter.Name = "colwaiter";
			this.colwaiter.Visible = true;
			this.colwaiter.VisibleIndex = 0;
			//
			//colpword
			//
			this.colpword.Caption = "Password";
			this.colpword.ColumnEdit = this.RepositoryItemTextEdit1;
			this.colpword.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
			this.colpword.FieldName = "pword";
			this.colpword.Name = "colpword";
			this.colpword.Visible = true;
			this.colpword.VisibleIndex = 1;
			//
			//RepositoryItemTextEdit1
			//
			this.RepositoryItemTextEdit1.AutoHeight = false;
			this.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1";
			this.RepositoryItemTextEdit1.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			//
			//WaitersTableAdapter1
			//
			this.WaitersTableAdapter1.ClearBeforeFill = true;
			//
			//c1DataViewSet1
			//
			this.c1DataViewSet1.DataSet = this.DsEmployees1;
			this.c1DataViewSet1.DiagramXML = "";
			//
			//simBtnSave
			//
			this.simBtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.simBtnSave.Appearance.ForeColor = System.Drawing.Color.Red;
			this.simBtnSave.Appearance.Options.UseFont = true;
			this.simBtnSave.Appearance.Options.UseForeColor = true;
			this.simBtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.simBtnSave.Location = new System.Drawing.Point(0, 346);
			this.simBtnSave.Name = "simBtnSave";
			this.simBtnSave.Size = new System.Drawing.Size(839, 23);
			this.simBtnSave.TabIndex = 1;
			this.simBtnSave.Text = "&Save";
			//
			//frmEmployee
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 369);
			this.Controls.Add(this.simBtnSave);
			this.Controls.Add(this.GridControl1);
			this.Name = "frmEmployee";
			this.Text = "Employees";
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.BindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsEmployees1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.grdEmployees).EndInit();
			((System.ComponentModel.ISupportInitialize) this.RepositoryItemTextEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.c1DataViewSet1).EndInit();
			this.ResumeLayout(false);
			
		}
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView grdEmployees;
		internal System.Windows.Forms.BindingSource BindingSource1;
		internal DoorsPOS.WinApp.dsEmployees DsEmployees1;
		internal DevExpress.XtraGrid.Columns.GridColumn colwtid;
		internal DevExpress.XtraGrid.Columns.GridColumn colwaiter;
		internal DevExpress.XtraGrid.Columns.GridColumn colpword;
		internal DoorsPOS.WinApp.dsEmployeesTableAdapters.waitersTableAdapter WaitersTableAdapter1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemTextEdit RepositoryItemTextEdit1;
		internal C1.C1DataExtender.C1DataViewSet c1DataViewSet1;
		internal DevExpress.XtraEditors.SimpleButton simBtnSave;
	}
	
}
