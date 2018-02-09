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
	partial class frmPayment : System.Windows.Forms.Form
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
			this.txtChange = new System.Windows.Forms.TextBox();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmPayment_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(frmPayment_KeyDown);
			base.Load += new System.EventHandler(frmPayment_Load);
			this.ceTendered = new DevExpress.XtraEditors.CalcEdit();
			this.ceTendered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceTendered_KeyDown);
			this.ceTendered.EditValueChanged += new System.EventHandler(this.ceTendered_EditValueChanged);
			this.txtTotAmnt = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton4 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton6 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton7 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton8 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton9 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton10 = new DevExpress.XtraEditors.SimpleButton();
			this.SimpleButton10.Click += new System.EventHandler(this.SimpleButton10_Click);
			((System.ComponentModel.ISupportInitialize) this.ceTendered.Properties).BeginInit();
			this.SuspendLayout();
			//
			//txtChange
			//
			this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (72.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtChange.ForeColor = System.Drawing.Color.Red;
			this.txtChange.Location = new System.Drawing.Point(326, 314);
			this.txtChange.Name = "txtChange";
			this.txtChange.ReadOnly = true;
			this.txtChange.Size = new System.Drawing.Size(626, 116);
			this.txtChange.TabIndex = 2;
			this.txtChange.TabStop = false;
			this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//ceTendered
			//
			this.ceTendered.Location = new System.Drawing.Point(326, 169);
			this.ceTendered.Name = "ceTendered";
			this.ceTendered.Properties.AllowMouseWheel = false;
			this.ceTendered.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (72.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ceTendered.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
			this.ceTendered.Properties.Appearance.Options.UseFont = true;
			this.ceTendered.Properties.Appearance.Options.UseForeColor = true;
			this.ceTendered.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceTendered.Properties.CloseUpKey = new DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
				| System.Windows.Forms.Keys.Z);
			this.ceTendered.Properties.DisplayFormat.FormatString = "N2";
			this.ceTendered.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceTendered.Properties.EditFormat.FormatString = "N2";
			this.ceTendered.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ceTendered.Properties.Mask.BeepOnError = true;
			this.ceTendered.Properties.Mask.EditMask = "n2";
			this.ceTendered.Size = new System.Drawing.Size(626, 114);
			this.ceTendered.TabIndex = 0;
			//
			//txtTotAmnt
			//
			this.txtTotAmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (72.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtTotAmnt.ForeColor = System.Drawing.Color.Green;
			this.txtTotAmnt.Location = new System.Drawing.Point(326, 25);
			this.txtTotAmnt.Name = "txtTotAmnt";
			this.txtTotAmnt.ReadOnly = true;
			this.txtTotAmnt.Size = new System.Drawing.Size(626, 116);
			this.txtTotAmnt.TabIndex = 1;
			this.txtTotAmnt.TabStop = false;
			this.txtTotAmnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (26.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.Red;
			this.Label5.Location = new System.Drawing.Point(172, 358);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(137, 39);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Change";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (26.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.Blue;
			this.Label4.Location = new System.Drawing.Point(16, 209);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(293, 39);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Amount Tendered";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (26.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.Green;
			this.Label3.Location = new System.Drawing.Point(86, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(223, 39);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Total Amount";
			//
			//SimpleButton1
			//
			this.SimpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.SimpleButton1.Appearance.Options.UseFont = true;
			this.SimpleButton1.Location = new System.Drawing.Point(12, 446);
			this.SimpleButton1.Name = "SimpleButton1";
			this.SimpleButton1.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton1.TabIndex = 9;
			this.SimpleButton1.Text = "100 (F1)";
			//
			//SimpleButton2
			//
			this.SimpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.SimpleButton2.Appearance.Options.UseFont = true;
			this.SimpleButton2.Location = new System.Drawing.Point(104, 446);
			this.SimpleButton2.Name = "SimpleButton2";
			this.SimpleButton2.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton2.TabIndex = 10;
			this.SimpleButton2.Text = "200 (F2)";
			//
			//SimpleButton3
			//
			this.SimpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton3.Appearance.Options.UseFont = true;
			this.SimpleButton3.Location = new System.Drawing.Point(196, 446);
			this.SimpleButton3.Name = "SimpleButton3";
			this.SimpleButton3.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton3.TabIndex = 11;
			this.SimpleButton3.Text = "300 (F3)";
			//
			//SimpleButton4
			//
			this.SimpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton4.Appearance.Options.UseFont = true;
			this.SimpleButton4.Location = new System.Drawing.Point(288, 446);
			this.SimpleButton4.Name = "SimpleButton4";
			this.SimpleButton4.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton4.TabIndex = 12;
			this.SimpleButton4.Text = "400 (F4)";
			//
			//SimpleButton5
			//
			this.SimpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton5.Appearance.Options.UseFont = true;
			this.SimpleButton5.Location = new System.Drawing.Point(380, 446);
			this.SimpleButton5.Name = "SimpleButton5";
			this.SimpleButton5.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton5.TabIndex = 13;
			this.SimpleButton5.Text = "500 (F5)";
			//
			//SimpleButton6
			//
			this.SimpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton6.Appearance.Options.UseFont = true;
			this.SimpleButton6.Location = new System.Drawing.Point(472, 446);
			this.SimpleButton6.Name = "SimpleButton6";
			this.SimpleButton6.Size = new System.Drawing.Size(115, 47);
			this.SimpleButton6.TabIndex = 14;
			this.SimpleButton6.Text = "600 (F6)";
			//
			//SimpleButton7
			//
			this.SimpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton7.Appearance.Options.UseFont = true;
			this.SimpleButton7.Location = new System.Drawing.Point(593, 446);
			this.SimpleButton7.Name = "SimpleButton7";
			this.SimpleButton7.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton7.TabIndex = 15;
			this.SimpleButton7.Text = "700 (F7)";
			//
			//SimpleButton8
			//
			this.SimpleButton8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton8.Appearance.Options.UseFont = true;
			this.SimpleButton8.Location = new System.Drawing.Point(685, 446);
			this.SimpleButton8.Name = "SimpleButton8";
			this.SimpleButton8.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton8.TabIndex = 16;
			this.SimpleButton8.Text = "800 (F8)";
			//
			//SimpleButton9
			//
			this.SimpleButton9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton9.Appearance.Options.UseFont = true;
			this.SimpleButton9.Location = new System.Drawing.Point(777, 446);
			this.SimpleButton9.Name = "SimpleButton9";
			this.SimpleButton9.Size = new System.Drawing.Size(86, 47);
			this.SimpleButton9.TabIndex = 17;
			this.SimpleButton9.Text = "900 (F9)";
			//
			//SimpleButton10
			//
			this.SimpleButton10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (15.75F));
			this.SimpleButton10.Appearance.Options.UseFont = true;
			this.SimpleButton10.Location = new System.Drawing.Point(869, 446);
			this.SimpleButton10.Name = "SimpleButton10";
			this.SimpleButton10.Size = new System.Drawing.Size(126, 47);
			this.SimpleButton10.TabIndex = 18;
			this.SimpleButton10.Text = "1,000 (F10)";
			//
			//frmPayment
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 513);
			this.Controls.Add(this.SimpleButton10);
			this.Controls.Add(this.SimpleButton9);
			this.Controls.Add(this.SimpleButton8);
			this.Controls.Add(this.SimpleButton7);
			this.Controls.Add(this.SimpleButton6);
			this.Controls.Add(this.SimpleButton5);
			this.Controls.Add(this.SimpleButton4);
			this.Controls.Add(this.SimpleButton3);
			this.Controls.Add(this.SimpleButton2);
			this.Controls.Add(this.SimpleButton1);
			this.Controls.Add(this.txtChange);
			this.Controls.Add(this.ceTendered);
			this.Controls.Add(this.txtTotAmnt);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "COLLECT PAYMENT";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize) this.ceTendered.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.TextBox txtChange;
		internal DevExpress.XtraEditors.CalcEdit ceTendered;
		internal System.Windows.Forms.TextBox txtTotAmnt;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton2;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton3;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton4;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton5;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton6;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton7;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton8;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton9;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton10;
	}
	
}
