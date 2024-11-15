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
	partial class frmCreditPayment : System.Windows.Forms.Form
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmCreditPayment_FormClosed);
			base.Load += new System.EventHandler(frmCreditPayment_Load);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.depaydate = new DevExpress.XtraEditors.DateEdit();
			this.txtrefno = new System.Windows.Forms.TextBox();
			this.ceamount = new DevExpress.XtraEditors.CalcEdit();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtcustid = new System.Windows.Forms.TextBox();
			this.txtlast = new System.Windows.Forms.TextBox();
			this.txtfirst = new System.Windows.Forms.TextBox();
			this.btnsearch = new System.Windows.Forms.Button();
			this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
			this.btnclose = new System.Windows.Forms.Button();
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			this.btnnew = new System.Windows.Forms.Button();
			this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
			this.btnsave = new System.Windows.Forms.Button();
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			this.btncancel = new System.Windows.Forms.Button();
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyDown);
			this.MemberBalanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DsBalance = new DoorsPOS.WinApp.dsBalance();
			this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.collastname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colfirstname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colmiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colbalance = new DevExpress.XtraGrid.Columns.GridColumn();
			this.custid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.MemberBalanceTableAdapter = new DoorsPOS.WinApp.dsBalanceTableAdapters.MemberBalanceTableAdapter();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.cebalance = new DevExpress.XtraEditors.CalcEdit();
			this.txtacntname = new DevExpress.XtraEditors.TextEdit();
			this.txtbank = new DevExpress.XtraEditors.TextEdit();
			this.txtcheque = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.MemberBalanceBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DsBalance).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cebalance.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtacntname.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtbank.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtcheque.Properties).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(83, 83);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Date";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(12, 117);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(116, 20);
			this.Label2.TabIndex = 0;
			this.Label2.Text = "Reference No.";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label3.Location = new System.Drawing.Point(62, 151);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(66, 20);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Amount";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label4.Location = new System.Drawing.Point(32, 253);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 20);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Cheque No.";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label5.Location = new System.Drawing.Point(9, 185);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(119, 20);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "Account Name";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label6.Location = new System.Drawing.Point(81, 219);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(47, 20);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "Bank";
			//
			//depaydate
			//
			this.depaydate.EditValue = null;
			this.depaydate.EnterMoveNextControl = true;
			this.depaydate.Location = new System.Drawing.Point(134, 77);
			this.depaydate.Name = "depaydate";
			this.depaydate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.depaydate.Properties.Appearance.Options.UseFont = true;
			this.depaydate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.depaydate.Size = new System.Drawing.Size(150, 26);
			this.depaydate.TabIndex = 2;
			//
			//txtrefno
			//
			this.txtrefno.Enabled = false;
			this.txtrefno.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtrefno.Location = new System.Drawing.Point(134, 112);
			this.txtrefno.Name = "txtrefno";
			this.txtrefno.Size = new System.Drawing.Size(150, 26);
			this.txtrefno.TabIndex = 2;
			//
			//ceamount
			//
			this.ceamount.EnterMoveNextControl = true;
			this.ceamount.Location = new System.Drawing.Point(134, 147);
			this.ceamount.Name = "ceamount";
			this.ceamount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceamount.Properties.Appearance.Options.UseFont = true;
			this.ceamount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceamount.Properties.Mask.BeepOnError = true;
			this.ceamount.Properties.Mask.EditMask = "n2";
			this.ceamount.Size = new System.Drawing.Size(150, 26);
			this.ceamount.TabIndex = 3;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label7.Location = new System.Drawing.Point(46, 39);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(82, 20);
			this.Label7.TabIndex = 0;
			this.Label7.Text = "Customer";
			//
			//txtcustid
			//
			this.txtcustid.Enabled = false;
			this.txtcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtcustid.Location = new System.Drawing.Point(134, 36);
			this.txtcustid.Name = "txtcustid";
			this.txtcustid.Size = new System.Drawing.Size(85, 26);
			this.txtcustid.TabIndex = 10;
			//
			//txtlast
			//
			this.txtlast.Enabled = false;
			this.txtlast.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtlast.Location = new System.Drawing.Point(234, 36);
			this.txtlast.Name = "txtlast";
			this.txtlast.Size = new System.Drawing.Size(199, 26);
			this.txtlast.TabIndex = 11;
			//
			//txtfirst
			//
			this.txtfirst.Enabled = false;
			this.txtfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtfirst.Location = new System.Drawing.Point(450, 36);
			this.txtfirst.Name = "txtfirst";
			this.txtfirst.Size = new System.Drawing.Size(199, 26);
			this.txtfirst.TabIndex = 12;
			//
			//btnsearch
			//
			this.btnsearch.Enabled = false;
			this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnsearch.Location = new System.Drawing.Point(666, 36);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(120, 26);
			this.btnsearch.TabIndex = 1;
			this.btnsearch.Text = "&Search Customer";
			this.btnsearch.UseVisualStyleBackColor = true;
			//
			//btnclose
			//
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnclose.Location = new System.Drawing.Point(666, 296);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(120, 33);
			this.btnclose.TabIndex = 8;
			this.btnclose.Text = "&Close";
			this.btnclose.UseVisualStyleBackColor = true;
			//
			//btnnew
			//
			this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnnew.Location = new System.Drawing.Point(36, 296);
			this.btnnew.Name = "btnnew";
			this.btnnew.Size = new System.Drawing.Size(120, 33);
			this.btnnew.TabIndex = 0;
			this.btnnew.Text = "&New Payment";
			this.btnnew.UseVisualStyleBackColor = true;
			//
			//btnsave
			//
			this.btnsave.Enabled = false;
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnsave.Location = new System.Drawing.Point(188, 296);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(120, 33);
			this.btnsave.TabIndex = 7;
			this.btnsave.Text = "Sa&ve";
			this.btnsave.UseVisualStyleBackColor = true;
			//
			//btncancel
			//
			this.btncancel.Enabled = false;
			this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btncancel.Location = new System.Drawing.Point(348, 296);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(120, 33);
			this.btncancel.TabIndex = 9;
			this.btncancel.Text = "Cance&l";
			this.btncancel.UseVisualStyleBackColor = true;
			//
			//gridControl1
			//
			this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridControl1.DataSource = this.MemberBalanceBindingSource;
			this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
			this.gridControl1.Enabled = false;
			this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.gridControl1.Location = new System.Drawing.Point(16, 32);
			this.gridControl1.MainView = this.GridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(774, 293);
			this.gridControl1.TabIndex = 13;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.GridView1});
			this.gridControl1.Visible = false;
			//
			//MemberBalanceBindingSource
			//
			this.MemberBalanceBindingSource.DataMember = "MemberBalance";
			this.MemberBalanceBindingSource.DataSource = this.DsBalance;
			//
			//DsBalance
			//
			this.DsBalance.DataSetName = "dsBalance";
			this.DsBalance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//GridView1
			//
			this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.collastname, this.colfirstname, this.colmiddlename, this.colbalance, this.custid});
			this.GridView1.GridControl = this.gridControl1;
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
			//MemberBalanceTableAdapter
			//
			this.MemberBalanceTableAdapter.ClearBeforeFill = true;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label8.Location = new System.Drawing.Point(130, 9);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(26, 20);
			this.Label8.TabIndex = 0;
			this.Label8.Text = "ID";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label9.Location = new System.Drawing.Point(230, 9);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(91, 20);
			this.Label9.TabIndex = 0;
			this.Label9.Text = "Last Name";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label10.Location = new System.Drawing.Point(447, 9);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(92, 20);
			this.Label10.TabIndex = 0;
			this.Label10.Text = "First Name";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label11.Location = new System.Drawing.Point(363, 83);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(70, 20);
			this.Label11.TabIndex = 0;
			this.Label11.Text = "Balance";
			//
			//cebalance
			//
			this.cebalance.Enabled = false;
			this.cebalance.Location = new System.Drawing.Point(451, 77);
			this.cebalance.Name = "cebalance";
			this.cebalance.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cebalance.Properties.Appearance.Options.UseFont = true;
			this.cebalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cebalance.Size = new System.Drawing.Size(150, 26);
			this.cebalance.TabIndex = 3;
			//
			//txtacntname
			//
			this.txtacntname.EnterMoveNextControl = true;
			this.txtacntname.Location = new System.Drawing.Point(134, 182);
			this.txtacntname.Name = "txtacntname";
			this.txtacntname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtacntname.Properties.Appearance.Options.UseFont = true;
			this.txtacntname.Size = new System.Drawing.Size(299, 26);
			this.txtacntname.TabIndex = 4;
			//
			//txtbank
			//
			this.txtbank.EnterMoveNextControl = true;
			this.txtbank.Location = new System.Drawing.Point(134, 216);
			this.txtbank.Name = "txtbank";
			this.txtbank.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtbank.Properties.Appearance.Options.UseFont = true;
			this.txtbank.Size = new System.Drawing.Size(299, 26);
			this.txtbank.TabIndex = 5;
			//
			//txtcheque
			//
			this.txtcheque.EnterMoveNextControl = true;
			this.txtcheque.Location = new System.Drawing.Point(134, 250);
			this.txtcheque.Name = "txtcheque";
			this.txtcheque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtcheque.Properties.Appearance.Options.UseFont = true;
			this.txtcheque.Size = new System.Drawing.Size(299, 26);
			this.txtcheque.TabIndex = 6;
			//
			//frmCreditPayment
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 347);
			this.Controls.Add(this.txtcheque);
			this.Controls.Add(this.txtbank);
			this.Controls.Add(this.txtacntname);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnnew);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.btnsearch);
			this.Controls.Add(this.cebalance);
			this.Controls.Add(this.ceamount);
			this.Controls.Add(this.txtfirst);
			this.Controls.Add(this.txtlast);
			this.Controls.Add(this.txtcustid);
			this.Controls.Add(this.txtrefno);
			this.Controls.Add(this.depaydate);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreditPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Credit Payment Form";
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.depaydate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceamount.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.MemberBalanceBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DsBalance).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cebalance.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtacntname.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtbank.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtcheque.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal DevExpress.XtraEditors.DateEdit depaydate;
		internal System.Windows.Forms.TextBox txtrefno;
		internal DevExpress.XtraEditors.CalcEdit ceamount;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtcustid;
		internal System.Windows.Forms.TextBox txtlast;
		internal System.Windows.Forms.TextBox txtfirst;
		internal System.Windows.Forms.Button btnsearch;
		internal System.Windows.Forms.Button btnclose;
		internal System.Windows.Forms.Button btnnew;
		internal System.Windows.Forms.Button btnsave;
		internal System.Windows.Forms.Button btncancel;
		internal DevExpress.XtraGrid.GridControl gridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DoorsPOS.WinApp.dsBalance DsBalance;
		internal System.Windows.Forms.BindingSource MemberBalanceBindingSource;
		internal DoorsPOS.WinApp.dsBalanceTableAdapters.MemberBalanceTableAdapter MemberBalanceTableAdapter;
		internal DevExpress.XtraGrid.Columns.GridColumn collastname;
		internal DevExpress.XtraGrid.Columns.GridColumn colfirstname;
		internal DevExpress.XtraGrid.Columns.GridColumn colmiddlename;
		internal DevExpress.XtraGrid.Columns.GridColumn colbalance;
		internal DevExpress.XtraGrid.Columns.GridColumn custid;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal DevExpress.XtraEditors.CalcEdit cebalance;
		internal DevExpress.XtraEditors.TextEdit txtacntname;
		internal DevExpress.XtraEditors.TextEdit txtbank;
		internal DevExpress.XtraEditors.TextEdit txtcheque;
	}
	
}
