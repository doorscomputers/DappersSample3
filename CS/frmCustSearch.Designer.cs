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
	partial class frmCustSearch : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmCustSearch_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmCustSearch_KeyDown);
			base.Load += new System.EventHandler(frmCustSearch_Load);
			this.dgcustomer = new System.Windows.Forms.DataGridView();
			this.dgcustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgcustomer_KeyDown);
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.txtLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastname_KeyDown);
			this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			((System.ComponentModel.ISupportInitialize) this.dgcustomer).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(10, 25);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(201, 20);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Type Lastname to Search";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//dgcustomer
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgcustomer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgcustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgcustomer.Location = new System.Drawing.Point(12, 55);
			this.dgcustomer.Name = "dgcustomer";
			this.dgcustomer.Size = new System.Drawing.Size(839, 470);
			this.dgcustomer.TabIndex = 7;
			//
			//txtLastname
			//
			this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtLastname.Location = new System.Drawing.Point(217, 20);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(380, 26);
			this.txtLastname.TabIndex = 5;
			//
			//btnSearch
			//
			this.btnSearch.Location = new System.Drawing.Point(639, 19);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(91, 26);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "&Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			//
			//btnClose
			//
			this.btnClose.Location = new System.Drawing.Point(750, 20);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 25);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "E&xit Form";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(603, 21);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(30, 23);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "&C";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//frmCustSearch
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 541);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgcustomer);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnClose);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCustSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Search Form";
			((System.ComponentModel.ISupportInitialize) this.dgcustomer).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgcustomer;
		internal System.Windows.Forms.TextBox txtLastname;
		internal System.Windows.Forms.Button btnSearch;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button Button1;
	}
	
}
