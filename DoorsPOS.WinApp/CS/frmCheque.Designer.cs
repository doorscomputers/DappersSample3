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
	partial class frmCheque : System.Windows.Forms.Form
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
			this.txtcheque = new DevExpress.XtraEditors.TextEdit();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmCheque_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmCheque_KeyDown);
			base.Load += new System.EventHandler(frmCheque_Load);
			this.txtacntname = new DevExpress.XtraEditors.TextEdit();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.custid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.txtbank = new DevExpress.XtraEditors.TextEdit();
			this.btncancel = new System.Windows.Forms.Button();
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			this.btnsave = new System.Windows.Forms.Button();
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			this.btnnew = new System.Windows.Forms.Button();
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
			this.btnclose = new System.Windows.Forms.Button();
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			this.ceamount = new DevExpress.XtraEditors.CalcEdit();
			this.txtrefno = new System.Windows.Forms.TextBox();
			this.depaydate = new DevExpress.XtraEditors.DateEdit();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtremark = new DevExpress.XtraEditors.TextEdit();
			this.Label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.txtcheque.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtacntname.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtbank.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtremark.Properties).BeginInit();
			this.SuspendLayout();
			//
			//txtcheque
			//
			this.txtcheque.EnterMoveNextControl = true;
			this.txtcheque.Location = new System.Drawing.Point(128, 153);
			this.txtcheque.Name = "txtcheque";
			this.txtcheque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtcheque.Properties.Appearance.Options.UseFont = true;
			this.txtcheque.Size = new System.Drawing.Size(324, 26);
			this.txtcheque.TabIndex = 5;
			//
			//txtacntname
			//
			this.txtacntname.EnterMoveNextControl = true;
			this.txtacntname.Location = new System.Drawing.Point(128, 85);
			this.txtacntname.Name = "txtacntname";
			this.txtacntname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtacntname.Properties.Appearance.Options.UseFont = true;
			this.txtacntname.Size = new System.Drawing.Size(475, 26);
			this.txtacntname.TabIndex = 3;
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
			//txtbank
			//
			this.txtbank.EnterMoveNextControl = true;
			this.txtbank.Location = new System.Drawing.Point(128, 120);
			this.txtbank.Name = "txtbank";
			this.txtbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtbank.Properties.Appearance.Options.UseFont = true;
			this.txtbank.Size = new System.Drawing.Size(475, 26);
			this.txtbank.TabIndex = 4;
			//
			//btncancel
			//
			this.btncancel.Enabled = false;
			this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btncancel.Location = new System.Drawing.Point(332, 241);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(120, 33);
			this.btncancel.TabIndex = 35;
			this.btncancel.Text = "Cance&l";
			this.btncancel.UseVisualStyleBackColor = true;
			//
			//btnsave
			//
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnsave.Location = new System.Drawing.Point(181, 241);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(120, 33);
			this.btnsave.TabIndex = 7;
			this.btnsave.Text = "Sa&ve";
			this.btnsave.UseVisualStyleBackColor = true;
			//
			//btnnew
			//
			this.btnnew.Enabled = false;
			this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnnew.Location = new System.Drawing.Point(30, 241);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(120, 33);
			this.btnnew.TabIndex = 0;
			this.btnnew.Text = "&New Payment";
			this.btnnew.UseVisualStyleBackColor = true;
			//
			//btnclose
			//
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnclose.Location = new System.Drawing.Point(483, 241);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(120, 33);
			this.btnclose.TabIndex = 34;
			this.btnclose.Text = "&Close";
			this.btnclose.UseVisualStyleBackColor = true;
			//
			//ceamount
			//
			this.ceamount.EnterMoveNextControl = true;
			this.ceamount.Location = new System.Drawing.Point(128, 50);
			this.ceamount.Name = "ceamount";
			this.ceamount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceamount.Properties.Appearance.Options.UseFont = true;
			this.ceamount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceamount.Properties.Mask.BeepOnError = true;
			this.ceamount.Properties.Mask.EditMask = "n2";
			this.ceamount.Size = new System.Drawing.Size(150, 26);
			this.ceamount.TabIndex = 2;
			//
			//txtrefno
			//
			this.txtrefno.Enabled = false;
			this.txtrefno.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtrefno.Location = new System.Drawing.Point(454, 15);
			this.txtrefno.Name = "txtrefno";
			this.txtrefno.Size = new System.Drawing.Size(150, 26);
			this.txtrefno.TabIndex = 26;
			//
			//depaydate
			//
			this.depaydate.EditValue = null;
			this.depaydate.EnterMoveNextControl = true;
			this.depaydate.Location = new System.Drawing.Point(128, 15);
			this.depaydate.Name = "depaydate";
			this.depaydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.depaydate.Properties.Appearance.Options.UseFont = true;
			this.depaydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Size = new System.Drawing.Size(150, 26);
			this.depaydate.TabIndex = 1;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label6.Location = new System.Drawing.Point(75, 123);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(47, 20);
			this.Label6.TabIndex = 15;
			this.Label6.Text = "Bank";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label5.Location = new System.Drawing.Point(3, 89);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(119, 20);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Account Name";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label4.Location = new System.Drawing.Point(26, 157);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 19;
			this.Label4.Text = "Cheque No.";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label3.Location = new System.Drawing.Point(56, 55);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(66, 20);
			this.Label3.TabIndex = 20;
			this.Label3.Text = "Amount";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(332, 21);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(116, 20);
			this.Label2.TabIndex = 17;
			this.Label2.Text = "Reference No.";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(77, 21);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 20);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Date";
			//
			//txtremark
			//
			this.txtremark.EnterMoveNextControl = true;
			this.txtremark.Location = new System.Drawing.Point(128, 186);
			this.txtremark.Name = "txtremark";
			this.txtremark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtremark.Properties.Appearance.Options.UseFont = true;
			this.txtremark.Size = new System.Drawing.Size(475, 26);
			this.txtremark.TabIndex = 6;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label7.Location = new System.Drawing.Point(55, 190);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(67, 20);
			this.Label7.TabIndex = 19;
			this.Label7.Text = "Remark";
			//
			//frmCheque
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 291);
			this.Controls.Add(this.txtcheque);
			this.Controls.Add(this.txtremark);
			this.Controls.Add(this.txtacntname);
			this.Controls.Add(this.txtbank);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.ceamount);
			this.Controls.Add(this.txtrefno);
			this.Controls.Add(this.depaydate);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCheque";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cheque Payment Form";
			((System.ComponentModel.ISupportInitialize) this.txtcheque.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtacntname.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtbank.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtremark.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.TextEdit txtcheque;
		internal DevExpress.XtraEditors.TextEdit txtacntname;
		internal DevExpress.XtraGrid.Columns.GridColumn custid;
		internal DevExpress.XtraGrid.Columns.GridColumn colbalance;
		internal DevExpress.XtraGrid.Columns.GridColumn colmiddlename;
		internal DevExpress.XtraGrid.Columns.GridColumn colfirstname;
		internal DevExpress.XtraGrid.Columns.GridColumn collastname;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.XtraEditors.TextEdit txtbank;
		internal System.Windows.Forms.Button btncancel;
		internal System.Windows.Forms.Button btnsave;
		internal System.Windows.Forms.Button btnnew;
		internal System.Windows.Forms.Button btnclose;
		internal DevExpress.XtraEditors.CalcEdit ceamount;
		internal System.Windows.Forms.TextBox txtrefno;
		internal DevExpress.XtraEditors.DateEdit depaydate;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal DevExpress.XtraEditors.TextEdit txtremark;
		internal System.Windows.Forms.Label Label7;
	}
	
}
