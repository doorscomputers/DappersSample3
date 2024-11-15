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
	partial class frmSearchItems : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtbcode = new System.Windows.Forms.TextBox();
			this.txtfilter = new System.Windows.Forms.TextBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.btnItem = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgitems = new System.Windows.Forms.DataGridView();
			this.txtitem = new System.Windows.Forms.TextBox();
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize) this.dgitems).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).BeginInit();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(596, 72);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(23, 23);
			this.Button1.TabIndex = 21;
			this.Button1.Text = "&B";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtbcode
			//
			this.txtbcode.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtbcode.Location = new System.Drawing.Point(134, 70);
			this.txtbcode.Name = "txtbcode";
			this.txtbcode.Size = new System.Drawing.Size(454, 26);
			this.txtbcode.TabIndex = 20;
			//
			//txtfilter
			//
			this.txtfilter.Enabled = false;
			this.txtfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.txtfilter.Location = new System.Drawing.Point(134, 36);
			this.txtfilter.Name = "txtfilter";
			this.txtfilter.Size = new System.Drawing.Size(454, 26);
			this.txtfilter.TabIndex = 19;
			//
			//btnFilter
			//
			this.btnFilter.Enabled = false;
			this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnFilter.Location = new System.Drawing.Point(595, 37);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(24, 26);
			this.btnFilter.TabIndex = 17;
			this.btnFilter.Text = "&F...";
			this.btnFilter.UseVisualStyleBackColor = true;
			//
			//btnItem
			//
			this.btnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnItem.Location = new System.Drawing.Point(595, 5);
			this.btnItem.Name = "btnItem";
			this.btnItem.Size = new System.Drawing.Size(24, 26);
			this.btnItem.TabIndex = 18;
			this.btnItem.Text = "&I...";
			this.btnItem.UseVisualStyleBackColor = true;
			//
			//btnSearch
			//
			this.btnSearch.Location = new System.Drawing.Point(639, 5);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(91, 26);
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "&Search Item Description";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(885, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 25);
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label3.Location = new System.Drawing.Point(12, 76);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 20);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Barcode";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(12, 42);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(47, 20);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Filter";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(12, 11);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(118, 20);
			this.Label1.TabIndex = 16;
			this.Label1.Text = "Item to Search";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//dgitems
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgitems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgitems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgitems.Location = new System.Drawing.Point(12, 106);
			this.dgitems.Name = "dgitems";
			this.dgitems.ReadOnly = true;
			this.dgitems.Size = new System.Drawing.Size(975, 401);
			this.dgitems.TabIndex = 12;
			//
			//txtitem
			//
			this.txtitem.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtitem.Location = new System.Drawing.Point(134, 4);
			this.txtitem.Name = "txtitem";
			this.txtitem.Size = new System.Drawing.Size(454, 26);
			this.txtitem.TabIndex = 10;
			//
			//GridControl1
			//
			this.GridControl1.Cursor = System.Windows.Forms.Cursors.Default;
			this.GridControl1.Location = new System.Drawing.Point(12, 106);
			this.GridControl1.MainView = this.gridView1;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.Size = new System.Drawing.Size(973, 246);
			this.GridControl1.TabIndex = 22;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.gridView1});
			//
			//gridView1
			//
			this.gridView1.GridControl = this.GridControl1;
			this.gridView1.Name = "gridView1";
			//
			//frmSearchItems
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 500);
			this.Controls.Add(this.GridControl1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.txtbcode);
			this.Controls.Add(this.txtfilter);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.btnItem);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgitems);
			this.Controls.Add(this.txtitem);
			this.KeyPreview = true;
			this.Name = "frmSearchItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search Items for Refund";
			((System.ComponentModel.ISupportInitialize) this.dgitems).EndInit();
			((System.ComponentModel.ISupportInitialize) this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.gridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtbcode;
		internal System.Windows.Forms.TextBox txtfilter;
		internal System.Windows.Forms.Button btnFilter;
		internal System.Windows.Forms.Button btnItem;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgitems;
		internal System.Windows.Forms.TextBox txtitem;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
	
}
