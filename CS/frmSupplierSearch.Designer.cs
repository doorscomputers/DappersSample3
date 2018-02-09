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
	partial class frmSupplierSearch : System.Windows.Forms.Form
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
			this.btnSup = new System.Windows.Forms.Button();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmItemSearch_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmItemSearch_KeyDown);
			base.Load += new System.EventHandler(frmItemSearch_Load);
			this.btnSup.Click += new System.EventHandler(this.btnItem_Click);
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.dgSuppliers = new System.Windows.Forms.DataGridView();
			this.dgSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgSuppliers_KeyDown);
			this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
			this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown1);
			this.txtSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplier_KeyPress);
			((System.ComponentModel.ISupportInitialize) this.dgSuppliers).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupplier.Properties).BeginInit();
			this.SuspendLayout();
			//
			//btnSup
			//
			this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.btnSup.Location = new System.Drawing.Point(499, 7);
			this.btnSup.Name = "btnSup";
			this.btnSup.Size = new System.Drawing.Size(24, 26);
			this.btnSup.TabIndex = 3;
			this.btnSup.Text = "&I...";
			this.btnSup.UseVisualStyleBackColor = true;
			//
			//btnSearch
			//
			this.btnSearch.Location = new System.Drawing.Point(529, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(91, 26);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(654, 8);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 25);
			this.btnClose.TabIndex = 9;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(12, 13);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(147, 20);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Supplier to Search";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//dgSuppliers
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgSuppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgSuppliers.Location = new System.Drawing.Point(12, 39);
			this.dgSuppliers.Name = "dgSuppliers";
			this.dgSuppliers.Size = new System.Drawing.Size(744, 470);
			this.dgSuppliers.TabIndex = 2;
			//
			//txtSupplier
			//
			this.txtSupplier.Location = new System.Drawing.Point(165, 7);
			this.txtSupplier.Name = "txtSupplier";
			this.txtSupplier.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.txtSupplier.Properties.Appearance.Options.UseFont = true;
			this.txtSupplier.Size = new System.Drawing.Size(328, 26);
			this.txtSupplier.TabIndex = 0;
			this.txtSupplier.ToolTip = "Type a Partial Supplier Name and Click Search. Press the Down arrow key to select" + 
				" the desired suppleir name.";
			//
			//frmSupplierSearch
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 515);
			this.Controls.Add(this.txtSupplier);
			this.Controls.Add(this.btnSup);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgSuppliers);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSupplierSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Supplier Search Form";
			((System.ComponentModel.ISupportInitialize) this.dgSuppliers).EndInit();
			((System.ComponentModel.ISupportInitialize) this.txtSupplier.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button btnSup;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgSuppliers;
		internal DevExpress.XtraEditors.TextEdit txtSupplier;
	}
	
}
