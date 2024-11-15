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
	partial class frmAddtnlCash : System.Windows.Forms.Form
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
			this.txtremark = new DevExpress.XtraEditors.TextEdit();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmAddtnlCash_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmAddtnlCash_KeyDown);
			base.Load += new System.EventHandler(frmAddtnlCash_Load);
			this.btncancel = new System.Windows.Forms.Button();
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			this.btnsave = new System.Windows.Forms.Button();
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			this.btnnew = new System.Windows.Forms.Button();
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
			this.btnclose = new System.Windows.Forms.Button();
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			this.ceamount = new DevExpress.XtraEditors.CalcEdit();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.custid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtrefno = new System.Windows.Forms.TextBox();
			this.depaydate = new DevExpress.XtraEditors.DateEdit();
			((System.ComponentModel.ISupportInitialize) this.txtremark.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).BeginInit();
			this.SuspendLayout();
			//
			//txtremark
			//
			this.txtremark.EnterMoveNextControl = true;
			this.txtremark.Location = new System.Drawing.Point(133, 82);
			this.txtremark.Name = "txtremark";
			this.txtremark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtremark.Properties.Appearance.Options.UseFont = true;
			this.txtremark.Size = new System.Drawing.Size(475, 26);
			this.txtremark.TabIndex = 3;
			//
			//btncancel
			//
			this.btncancel.Enabled = false;
			this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btncancel.Location = new System.Drawing.Point(338, 139);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(120, 33);
			this.btncancel.TabIndex = 51;
			this.btncancel.Text = "Cance&l";
			this.btncancel.UseVisualStyleBackColor = true;
			//
			//btnsave
			//
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnsave.Location = new System.Drawing.Point(187, 139);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(120, 33);
			this.btnsave.TabIndex = 4;
			this.btnsave.Text = "Sa&ve";
			this.btnsave.UseVisualStyleBackColor = true;
			//
			//btnnew
			//
			this.btnnew.Enabled = false;
			this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnnew.Location = new System.Drawing.Point(36, 139);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(120, 33);
			this.btnnew.TabIndex = 0;
			this.btnnew.Text = "&Add Cash";
			this.btnnew.UseVisualStyleBackColor = true;
			//
			//btnclose
			//
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnclose.Location = new System.Drawing.Point(489, 139);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(120, 33);
			this.btnclose.TabIndex = 50;
			this.btnclose.Text = "&Close";
			this.btnclose.UseVisualStyleBackColor = true;
			//
			//ceamount
			//
			this.ceamount.EnterMoveNextControl = true;
			this.ceamount.Location = new System.Drawing.Point(133, 47);
			this.ceamount.Name = "ceamount";
			this.ceamount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceamount.Properties.Appearance.Options.UseFont = true;
			this.ceamount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceamount.Properties.Mask.BeepOnError = true;
			this.ceamount.Properties.Mask.EditMask = "n2";
			this.ceamount.Size = new System.Drawing.Size(150, 26);
			this.ceamount.TabIndex = 2;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label5.Location = new System.Drawing.Point(60, 86);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(67, 20);
			this.Label5.TabIndex = 44;
			this.Label5.Text = "Remark";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label3.Location = new System.Drawing.Point(9, 53);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(118, 20);
			this.Label3.TabIndex = 48;
			this.Label3.Text = "Amount Added";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(337, 18);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(116, 20);
			this.Label2.TabIndex = 46;
			this.Label2.Text = "Reference No.";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(82, 18);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 20);
			this.Label1.TabIndex = 43;
			this.Label1.Text = "Date";
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.collastname, this.colfirstname, this.colmiddlename, this.colbalance, this.custid});
			this.GridView1.Name = "GridView1";
			this.GridView1.OptionsBehavior.Editable = false;
			this.GridView1.OptionsFind.AlwaysVisible = true;
			this.GridView1.OptionsView.ShowFooter = true;
			this.GridView1.OptionsView.ShowGroupPanel = false;
			this.GridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colbalance, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//collastname
			//
			this.collastname.Caption = "Last Name";
			this.collastname.FieldName = "lastname";
			this.collastname.Name = "collastname";
			this.collastname.Visible = true;
			this.collastname.VisibleIndex = 0;
			this.collastname.Width = 302;
			//
			//colfirstname
			//
			this.colfirstname.Caption = "First Name";
			this.colfirstname.FieldName = "firstname";
			this.colfirstname.Name = "colfirstname";
			this.colfirstname.Visible = true;
			this.colfirstname.VisibleIndex = 1;
			this.colfirstname.Width = 233;
			//
			//colmiddlename
			//
			this.colmiddlename.Caption = "Middle Name";
			this.colmiddlename.FieldName = "middlename";
			this.colmiddlename.Name = "colmiddlename";
			this.colmiddlename.Visible = true;
			this.colmiddlename.VisibleIndex = 2;
			this.colmiddlename.Width = 249;
			//
			//colbalance
			//
			this.colbalance.Caption = "Blalance";
			this.colbalance.DisplayFormat.FormatString = "N2";
			this.colbalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colbalance.FieldName = "balance";
			this.colbalance.Name = "colbalance";
			this.colbalance.Visible = true;
			this.colbalance.VisibleIndex = 3;
			this.colbalance.Width = 264;
			//
			//custid
			//
			this.custid.Caption = "custid";
			this.custid.FieldName = "custid";
			this.custid.Name = "custid";
			this.custid.Width = 53;
			//
			//txtrefno
			//
			this.txtrefno.Enabled = false;
			this.txtrefno.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtrefno.Location = new System.Drawing.Point(459, 12);
			this.txtrefno.Name = "txtrefno";
			this.txtrefno.Size = new System.Drawing.Size(150, 26);
			this.txtrefno.TabIndex = 49;
			//
			//depaydate
			//
			this.depaydate.EditValue = null;
			this.depaydate.EnterMoveNextControl = true;
			this.depaydate.Location = new System.Drawing.Point(133, 12);
			this.depaydate.Name = "depaydate";
			this.depaydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.depaydate.Properties.Appearance.Options.UseFont = true;
			this.depaydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Size = new System.Drawing.Size(150, 26);
			this.depaydate.TabIndex = 1;
			//
			//frmAddtnlCash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 190);
			this.Controls.Add(this.txtremark);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.ceamount);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtrefno);
			this.Controls.Add(this.depaydate);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddtnlCash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Additional Cash Entry Form";
			((System.ComponentModel.ISupportInitialize) this.txtremark.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraGrid.Columns.GridColumn custid;
		internal DevExpress.XtraEditors.TextEdit txtremark;
		internal DevExpress.XtraGrid.Columns.GridColumn colmiddlename;
		internal System.Windows.Forms.Button btncancel;
		internal DevExpress.XtraGrid.Columns.GridColumn colfirstname;
		internal DevExpress.XtraGrid.Columns.GridColumn collastname;
		internal DevExpress.XtraGrid.Columns.GridColumn colbalance;
		internal System.Windows.Forms.Button btnsave;
		internal System.Windows.Forms.Button btnnew;
		internal System.Windows.Forms.Button btnclose;
		internal DevExpress.XtraEditors.CalcEdit ceamount;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal System.Windows.Forms.TextBox txtrefno;
		internal DevExpress.XtraEditors.DateEdit depaydate;
	}
	
}
