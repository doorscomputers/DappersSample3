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
	partial class frmBegCash : System.Windows.Forms.Form
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.cmbUserType = new System.Windows.Forms.ComboBox();
			this.cebegcash = new DevExpress.XtraEditors.CalcEdit();
			this.cebegcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cebegcash_KeyPress);
			this.cebegcash.EditValueChanged += new System.EventHandler(this.cebegcash_EditValueChanged);
			((System.ComponentModel.ISupportInitialize) this.cebegcash.Properties).BeginInit();
			this.SuspendLayout();
			//
			//btnOk
			//
			this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F));
			this.btnOk.Location = new System.Drawing.Point(21, 235);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 33);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "&OK";
			this.btnOk.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label1.Location = new System.Drawing.Point(17, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(86, 20);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "User Type";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.Label2.Location = new System.Drawing.Point(17, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(195, 20);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Beginning Cash on Hand";
			//
			//btnClose
			//
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (14.25F));
			this.btnClose.Location = new System.Drawing.Point(426, 235);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 33);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			//
			//cmbUserType
			//
			this.cmbUserType.Enabled = false;
			this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (12.25F));
			this.cmbUserType.FormattingEnabled = true;
			this.cmbUserType.Items.AddRange(new object[] {"Cashier", "Admin"});
			this.cmbUserType.Location = new System.Drawing.Point(109, 21);
			this.cmbUserType.Name = "cmbUserType";
			this.cmbUserType.Size = new System.Drawing.Size(173, 28);
			this.cmbUserType.TabIndex = 0;
			this.cmbUserType.Text = "Cashier";
			//
			//cebegcash
			//
			this.cebegcash.Location = new System.Drawing.Point(21, 88);
			this.cebegcash.Name = "cebegcash";
			this.cebegcash.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.cebegcash.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (70.25F));
			this.cebegcash.Properties.Appearance.Options.UseFont = true;
			this.cebegcash.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cebegcash.Properties.DisplayFormat.FormatString = "N2";
			this.cebegcash.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.cebegcash.Properties.Mask.EditMask = "n2";
			this.cebegcash.Size = new System.Drawing.Size(480, 120);
			this.cebegcash.TabIndex = 1;
			//
			//frmBegCash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 284);
			this.Controls.Add(this.cebegcash);
			this.Controls.Add(this.cmbUserType);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBegCash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Beginning Cash Entry Form";
			((System.ComponentModel.ISupportInitialize) this.cebegcash.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button btnOk;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.ComboBox cmbUserType;
		internal DevExpress.XtraEditors.CalcEdit cebegcash;
	}
	
}
