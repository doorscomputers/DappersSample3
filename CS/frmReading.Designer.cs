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
	partial class frmReading : System.Windows.Forms.Form
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
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmReading_FormClosed);
			base.Load += new System.EventHandler(frmReading_Load);
			this.ceCheque = new DevExpress.XtraEditors.CalcEdit();
			this.ceCheque.GotFocus += new System.EventHandler(this.ceCheque_GotFocus);
			this.ceCheque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceCheque_KeyDown);
			this.ceCheque.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceCheque_Spin);
			this.ceCheque.EditValueChanged += new System.EventHandler(this.ceCheque_EditValueChanged);
			this.ceCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceCheque_KeyPress);
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.ceThousand = new DevExpress.XtraEditors.CalcEdit();
			this.ceThousand.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.ceThousand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.ceThousand.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.ceThousand.EditValueChanged += new System.EventHandler(this.ceThousand_EditValueChanged);
			this.ceFiveHundred = new DevExpress.XtraEditors.CalcEdit();
			this.ceFiveHundred.GotFocus += new System.EventHandler(this.ceFiveHundred_GotFocus);
			this.ceFiveHundred.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceFiveHundred_KeyDown);
			this.ceFiveHundred.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceFiveHundred_Spin);
			this.ceFiveHundred.EditValueChanged += new System.EventHandler(this.ceFiveHundred_EditValueChanged);
			this.ceTwoHundred = new DevExpress.XtraEditors.CalcEdit();
			this.ceTwoHundred.GotFocus += new System.EventHandler(this.ceTwoHundred_GotFocus);
			this.ceTwoHundred.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceTwoHundred_KeyDown);
			this.ceTwoHundred.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceTwoHundred_Spin);
			this.ceTwoHundred.EditValueChanged += new System.EventHandler(this.ceTwoHundred_EditValueChanged);
			this.ceOneHundred = new DevExpress.XtraEditors.CalcEdit();
			this.ceOneHundred.GotFocus += new System.EventHandler(this.ceOneHundred_GotFocus);
			this.ceOneHundred.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceOneHundred_KeyDown);
			this.ceOneHundred.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceOneHundred_Spin);
			this.ceOneHundred.EditValueChanged += new System.EventHandler(this.ceOneHundred_EditValueChanged);
			this.ceFifty = new DevExpress.XtraEditors.CalcEdit();
			this.ceFifty.GotFocus += new System.EventHandler(this.ceFifty_GotFocus);
			this.ceFifty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceFifty_KeyDown);
			this.ceFifty.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceFifty_Spin);
			this.ceFifty.EditValueChanged += new System.EventHandler(this.ceFifty_EditValueChanged);
			this.ceTwenty = new DevExpress.XtraEditors.CalcEdit();
			this.ceTwenty.GotFocus += new System.EventHandler(this.ceTwenty_GotFocus);
			this.ceTwenty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceTwenty_KeyDown);
			this.ceTwenty.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceTwenty_Spin);
			this.ceTwenty.EditValueChanged += new System.EventHandler(this.ceTwenty_EditValueChanged);
			this.ceTen = new DevExpress.XtraEditors.CalcEdit();
			this.ceTen.GotFocus += new System.EventHandler(this.ceTen_GotFocus);
			this.ceTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceTen_KeyDown);
			this.ceTen.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceTen_Spin);
			this.ceTen.EditValueChanged += new System.EventHandler(this.ceTen_EditValueChanged);
			this.ceFive = new DevExpress.XtraEditors.CalcEdit();
			this.ceFive.GotFocus += new System.EventHandler(this.ceFive_GotFocus);
			this.ceFive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceFive_KeyDown);
			this.ceFive.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceFive_Spin);
			this.ceFive.EditValueChanged += new System.EventHandler(this.ceFive_EditValueChanged);
			this.ceOne = new DevExpress.XtraEditors.CalcEdit();
			this.ceOne.GotFocus += new System.EventHandler(this.ceOne_GotFocus);
			this.ceOne.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceOne_KeyDown);
			this.ceOne.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceOne_Spin);
			this.ceOne.EditValueChanged += new System.EventHandler(this.ceOne_EditValueChanged);
			this.ceCents = new DevExpress.XtraEditors.CalcEdit();
			this.ceCents.GotFocus += new System.EventHandler(this.ceCents_GotFocus);
			this.ceCents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceCents_KeyDown);
			this.ceCents.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceCents_Spin);
			this.ceCents.EditValueChanged += new System.EventHandler(this.ceCents_EditValueChanged);
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.btnSave = new DevExpress.XtraEditors.SimpleButton();
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			this.btnClose = new DevExpress.XtraEditors.SimpleButton();
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.cekAmnt = new DevExpress.XtraEditors.CalcEdit();
			this.cekAmnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cekAmnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cekAmnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cefivehamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cefivehamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cefivehamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cefivehamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cethamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cethamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cethamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cethamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.ceonehundredamnt = new DevExpress.XtraEditors.CalcEdit();
			this.ceonehundredamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.ceonehundredamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.ceonehundredamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cefiftyamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cefiftyamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cefiftyamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cefiftyamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cetwentyamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cetwentyamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cetwentyamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cetwentyamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cetenamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cetenamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cetenamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cetenamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cefiveamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cefiveamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cefiveamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cefiveamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.ceonepesoamnt = new DevExpress.XtraEditors.CalcEdit();
			this.ceonepesoamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.ceonepesoamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.ceonepesoamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.cecentsamnt = new DevExpress.XtraEditors.CalcEdit();
			this.cecentsamnt.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.cecentsamnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.cecentsamnt.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.ceGT = new DevExpress.XtraEditors.CalcEdit();
			this.ceGT.GotFocus += new System.EventHandler(this.ceThousand_GotFocus);
			this.ceGT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ceThousand_KeyDown);
			this.ceGT.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.ceThousand_Spin);
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize) this.ceCheque.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceThousand.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceFiveHundred.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceTwoHundred.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceOneHundred.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceFifty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceTwenty.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceTen.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceFive.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceOne.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceCents.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cekAmnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cefivehamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cethamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceonehundredamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cefiftyamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cetwentyamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cetenamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cefiveamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceonepesoamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cecentsamnt.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ceGT.Properties).BeginInit();
			this.SuspendLayout();
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl1.Location = new System.Drawing.Point(29, 50);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(115, 19);
			this.LabelControl1.TabIndex = 34;
			this.LabelControl1.Text = "Cheque Amount";
			//
			//ceCheque
			//
			this.ceCheque.Location = new System.Drawing.Point(150, 47);
			this.ceCheque.Name = "ceCheque";
			this.ceCheque.Properties.AllowMouseWheel = false;
			this.ceCheque.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceCheque.Properties.Appearance.Options.UseFont = true;
			this.ceCheque.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceCheque.Properties.Mask.BeepOnError = true;
			this.ceCheque.Properties.Mask.EditMask = "n2";
			this.ceCheque.Size = new System.Drawing.Size(149, 26);
			this.ceCheque.TabIndex = 0;
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl2.Location = new System.Drawing.Point(40, 92);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(104, 19);
			this.LabelControl2.TabIndex = 33;
			this.LabelControl2.Text = "One Thousand";
			//
			//LabelControl3
			//
			this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl3.Location = new System.Drawing.Point(50, 134);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(94, 19);
			this.LabelControl3.TabIndex = 32;
			this.LabelControl3.Text = "Five Hundred";
			//
			//LabelControl4
			//
			this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl4.Location = new System.Drawing.Point(47, 174);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(97, 19);
			this.LabelControl4.TabIndex = 31;
			this.LabelControl4.Text = "Two Hundred";
			//
			//LabelControl5
			//
			this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl5.Location = new System.Drawing.Point(49, 214);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(95, 19);
			this.LabelControl5.TabIndex = 30;
			this.LabelControl5.Text = "One Hundred";
			//
			//LabelControl6
			//
			this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl6.Location = new System.Drawing.Point(114, 254);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(30, 19);
			this.LabelControl6.TabIndex = 29;
			this.LabelControl6.Text = "Fifty";
			//
			//LabelControl7
			//
			this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl7.Location = new System.Drawing.Point(92, 294);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(52, 19);
			this.LabelControl7.TabIndex = 28;
			this.LabelControl7.Text = "Twenty";
			//
			//LabelControl8
			//
			this.LabelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl8.Location = new System.Drawing.Point(117, 334);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(27, 19);
			this.LabelControl8.TabIndex = 27;
			this.LabelControl8.Text = "Ten";
			//
			//LabelControl9
			//
			this.LabelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl9.Location = new System.Drawing.Point(116, 374);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(28, 19);
			this.LabelControl9.TabIndex = 26;
			this.LabelControl9.Text = "Five";
			//
			//LabelControl10
			//
			this.LabelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl10.Location = new System.Drawing.Point(115, 414);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(29, 19);
			this.LabelControl10.TabIndex = 25;
			this.LabelControl10.Text = "One";
			//
			//LabelControl11
			//
			this.LabelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl11.Location = new System.Drawing.Point(15, 454);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(129, 19);
			this.LabelControl11.TabIndex = 24;
			this.LabelControl11.Text = "Twenty Five Cents";
			//
			//ceThousand
			//
			this.ceThousand.EnterMoveNextControl = true;
			this.ceThousand.Location = new System.Drawing.Point(150, 87);
			this.ceThousand.Name = "ceThousand";
			this.ceThousand.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceThousand.Properties.Appearance.Options.UseFont = true;
			this.ceThousand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceThousand.Properties.Mask.BeepOnError = true;
			this.ceThousand.Properties.Mask.EditMask = "n2";
			this.ceThousand.Size = new System.Drawing.Size(149, 26);
			this.ceThousand.TabIndex = 1;
			//
			//ceFiveHundred
			//
			this.ceFiveHundred.EnterMoveNextControl = true;
			this.ceFiveHundred.Location = new System.Drawing.Point(150, 127);
			this.ceFiveHundred.Name = "ceFiveHundred";
			this.ceFiveHundred.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceFiveHundred.Properties.Appearance.Options.UseFont = true;
			this.ceFiveHundred.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceFiveHundred.Properties.Mask.BeepOnError = true;
			this.ceFiveHundred.Properties.Mask.EditMask = "n2";
			this.ceFiveHundred.Size = new System.Drawing.Size(149, 26);
			this.ceFiveHundred.TabIndex = 2;
			//
			//ceTwoHundred
			//
			this.ceTwoHundred.EnterMoveNextControl = true;
			this.ceTwoHundred.Location = new System.Drawing.Point(150, 167);
			this.ceTwoHundred.Name = "ceTwoHundred";
			this.ceTwoHundred.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceTwoHundred.Properties.Appearance.Options.UseFont = true;
			this.ceTwoHundred.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceTwoHundred.Properties.Mask.BeepOnError = true;
			this.ceTwoHundred.Properties.Mask.EditMask = "n2";
			this.ceTwoHundred.Size = new System.Drawing.Size(149, 26);
			this.ceTwoHundred.TabIndex = 3;
			//
			//ceOneHundred
			//
			this.ceOneHundred.EnterMoveNextControl = true;
			this.ceOneHundred.Location = new System.Drawing.Point(150, 207);
			this.ceOneHundred.Name = "ceOneHundred";
			this.ceOneHundred.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceOneHundred.Properties.Appearance.Options.UseFont = true;
			this.ceOneHundred.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceOneHundred.Properties.Mask.BeepOnError = true;
			this.ceOneHundred.Properties.Mask.EditMask = "n2";
			this.ceOneHundred.Size = new System.Drawing.Size(149, 26);
			this.ceOneHundred.TabIndex = 4;
			//
			//ceFifty
			//
			this.ceFifty.EnterMoveNextControl = true;
			this.ceFifty.Location = new System.Drawing.Point(150, 247);
			this.ceFifty.Name = "ceFifty";
			this.ceFifty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceFifty.Properties.Appearance.Options.UseFont = true;
			this.ceFifty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceFifty.Properties.Mask.BeepOnError = true;
			this.ceFifty.Properties.Mask.EditMask = "n2";
			this.ceFifty.Size = new System.Drawing.Size(149, 26);
			this.ceFifty.TabIndex = 5;
			//
			//ceTwenty
			//
			this.ceTwenty.EnterMoveNextControl = true;
			this.ceTwenty.Location = new System.Drawing.Point(150, 287);
			this.ceTwenty.Name = "ceTwenty";
			this.ceTwenty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceTwenty.Properties.Appearance.Options.UseFont = true;
			this.ceTwenty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceTwenty.Properties.Mask.BeepOnError = true;
			this.ceTwenty.Properties.Mask.EditMask = "n2";
			this.ceTwenty.Size = new System.Drawing.Size(149, 26);
			this.ceTwenty.TabIndex = 6;
			//
			//ceTen
			//
			this.ceTen.EnterMoveNextControl = true;
			this.ceTen.Location = new System.Drawing.Point(150, 327);
			this.ceTen.Name = "ceTen";
			this.ceTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceTen.Properties.Appearance.Options.UseFont = true;
			this.ceTen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceTen.Properties.Mask.BeepOnError = true;
			this.ceTen.Properties.Mask.EditMask = "n2";
			this.ceTen.Size = new System.Drawing.Size(149, 26);
			this.ceTen.TabIndex = 7;
			//
			//ceFive
			//
			this.ceFive.EnterMoveNextControl = true;
			this.ceFive.Location = new System.Drawing.Point(150, 367);
			this.ceFive.Name = "ceFive";
			this.ceFive.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceFive.Properties.Appearance.Options.UseFont = true;
			this.ceFive.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceFive.Properties.Mask.BeepOnError = true;
			this.ceFive.Properties.Mask.EditMask = "n2";
			this.ceFive.Size = new System.Drawing.Size(149, 26);
			this.ceFive.TabIndex = 8;
			//
			//ceOne
			//
			this.ceOne.EnterMoveNextControl = true;
			this.ceOne.Location = new System.Drawing.Point(150, 407);
			this.ceOne.Name = "ceOne";
			this.ceOne.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceOne.Properties.Appearance.Options.UseFont = true;
			this.ceOne.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceOne.Properties.Mask.BeepOnError = true;
			this.ceOne.Properties.Mask.EditMask = "n2";
			this.ceOne.Size = new System.Drawing.Size(149, 26);
			this.ceOne.TabIndex = 9;
			//
			//ceCents
			//
			this.ceCents.EnterMoveNextControl = true;
			this.ceCents.Location = new System.Drawing.Point(150, 447);
			this.ceCents.Name = "ceCents";
			this.ceCents.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceCents.Properties.Appearance.Options.UseFont = true;
			this.ceCents.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceCents.Properties.Mask.BeepOnError = true;
			this.ceCents.Properties.Mask.EditMask = "n2";
			this.ceCents.Size = new System.Drawing.Size(149, 26);
			this.ceCents.TabIndex = 10;
			//
			//LabelControl12
			//
			this.LabelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl12.Location = new System.Drawing.Point(150, 12);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(43, 19);
			this.LabelControl12.TabIndex = 35;
			this.LabelControl12.Text = "Pieces";
			//
			//btnSave
			//
			this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnSave.Appearance.Options.UseFont = true;
			this.btnSave.Location = new System.Drawing.Point(19, 493);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(77, 32);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "&Save";
			//
			//btnClose
			//
			this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.btnClose.Appearance.Options.UseFont = true;
			this.btnClose.Location = new System.Drawing.Point(501, 493);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(77, 32);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "&Close";
			//
			//LabelControl13
			//
			this.LabelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl13.Location = new System.Drawing.Point(333, 12);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(57, 19);
			this.LabelControl13.TabIndex = 35;
			this.LabelControl13.Text = "Amount";
			//
			//cekAmnt
			//
			this.cekAmnt.EnterMoveNextControl = true;
			this.cekAmnt.Location = new System.Drawing.Point(333, 89);
			this.cekAmnt.Name = "cekAmnt";
			this.cekAmnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cekAmnt.Properties.Appearance.Options.UseFont = true;
			this.cekAmnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cekAmnt.Properties.Mask.BeepOnError = true;
			this.cekAmnt.Properties.Mask.EditMask = "n2";
			this.cekAmnt.Size = new System.Drawing.Size(149, 26);
			this.cekAmnt.TabIndex = 1;
			this.cekAmnt.TabStop = false;
			//
			//cefivehamnt
			//
			this.cefivehamnt.EnterMoveNextControl = true;
			this.cefivehamnt.Location = new System.Drawing.Point(333, 127);
			this.cefivehamnt.Name = "cefivehamnt";
			this.cefivehamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cefivehamnt.Properties.Appearance.Options.UseFont = true;
			this.cefivehamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cefivehamnt.Properties.Mask.BeepOnError = true;
			this.cefivehamnt.Properties.Mask.EditMask = "n2";
			this.cefivehamnt.Size = new System.Drawing.Size(149, 26);
			this.cefivehamnt.TabIndex = 1;
			this.cefivehamnt.TabStop = false;
			//
			//cethamnt
			//
			this.cethamnt.EnterMoveNextControl = true;
			this.cethamnt.Location = new System.Drawing.Point(333, 167);
			this.cethamnt.Name = "cethamnt";
			this.cethamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cethamnt.Properties.Appearance.Options.UseFont = true;
			this.cethamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cethamnt.Properties.Mask.BeepOnError = true;
			this.cethamnt.Properties.Mask.EditMask = "n2";
			this.cethamnt.Size = new System.Drawing.Size(149, 26);
			this.cethamnt.TabIndex = 1;
			this.cethamnt.TabStop = false;
			//
			//ceonehundredamnt
			//
			this.ceonehundredamnt.EnterMoveNextControl = true;
			this.ceonehundredamnt.Location = new System.Drawing.Point(333, 207);
			this.ceonehundredamnt.Name = "ceonehundredamnt";
			this.ceonehundredamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceonehundredamnt.Properties.Appearance.Options.UseFont = true;
			this.ceonehundredamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceonehundredamnt.Properties.Mask.BeepOnError = true;
			this.ceonehundredamnt.Properties.Mask.EditMask = "n2";
			this.ceonehundredamnt.Size = new System.Drawing.Size(149, 26);
			this.ceonehundredamnt.TabIndex = 1;
			this.ceonehundredamnt.TabStop = false;
			//
			//cefiftyamnt
			//
			this.cefiftyamnt.EnterMoveNextControl = true;
			this.cefiftyamnt.Location = new System.Drawing.Point(333, 247);
			this.cefiftyamnt.Name = "cefiftyamnt";
			this.cefiftyamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cefiftyamnt.Properties.Appearance.Options.UseFont = true;
			this.cefiftyamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cefiftyamnt.Properties.Mask.BeepOnError = true;
			this.cefiftyamnt.Properties.Mask.EditMask = "n2";
			this.cefiftyamnt.Size = new System.Drawing.Size(149, 26);
			this.cefiftyamnt.TabIndex = 1;
			this.cefiftyamnt.TabStop = false;
			//
			//cetwentyamnt
			//
			this.cetwentyamnt.EnterMoveNextControl = true;
			this.cetwentyamnt.Location = new System.Drawing.Point(333, 287);
			this.cetwentyamnt.Name = "cetwentyamnt";
			this.cetwentyamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cetwentyamnt.Properties.Appearance.Options.UseFont = true;
			this.cetwentyamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cetwentyamnt.Properties.Mask.BeepOnError = true;
			this.cetwentyamnt.Properties.Mask.EditMask = "n2";
			this.cetwentyamnt.Size = new System.Drawing.Size(149, 26);
			this.cetwentyamnt.TabIndex = 1;
			this.cetwentyamnt.TabStop = false;
			//
			//cetenamnt
			//
			this.cetenamnt.EnterMoveNextControl = true;
			this.cetenamnt.Location = new System.Drawing.Point(333, 327);
			this.cetenamnt.Name = "cetenamnt";
			this.cetenamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cetenamnt.Properties.Appearance.Options.UseFont = true;
			this.cetenamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cetenamnt.Properties.Mask.BeepOnError = true;
			this.cetenamnt.Properties.Mask.EditMask = "n2";
			this.cetenamnt.Size = new System.Drawing.Size(149, 26);
			this.cetenamnt.TabIndex = 1;
			this.cetenamnt.TabStop = false;
			//
			//cefiveamnt
			//
			this.cefiveamnt.EnterMoveNextControl = true;
			this.cefiveamnt.Location = new System.Drawing.Point(333, 367);
			this.cefiveamnt.Name = "cefiveamnt";
			this.cefiveamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cefiveamnt.Properties.Appearance.Options.UseFont = true;
			this.cefiveamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cefiveamnt.Properties.Mask.BeepOnError = true;
			this.cefiveamnt.Properties.Mask.EditMask = "n2";
			this.cefiveamnt.Size = new System.Drawing.Size(149, 26);
			this.cefiveamnt.TabIndex = 1;
			this.cefiveamnt.TabStop = false;
			//
			//ceonepesoamnt
			//
			this.ceonepesoamnt.EnterMoveNextControl = true;
			this.ceonepesoamnt.Location = new System.Drawing.Point(333, 407);
			this.ceonepesoamnt.Name = "ceonepesoamnt";
			this.ceonepesoamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceonepesoamnt.Properties.Appearance.Options.UseFont = true;
			this.ceonepesoamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceonepesoamnt.Properties.Mask.BeepOnError = true;
			this.ceonepesoamnt.Properties.Mask.EditMask = "n2";
			this.ceonepesoamnt.Size = new System.Drawing.Size(149, 26);
			this.ceonepesoamnt.TabIndex = 1;
			this.ceonepesoamnt.TabStop = false;
			//
			//cecentsamnt
			//
			this.cecentsamnt.EnterMoveNextControl = true;
			this.cecentsamnt.Location = new System.Drawing.Point(333, 447);
			this.cecentsamnt.Name = "cecentsamnt";
			this.cecentsamnt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.cecentsamnt.Properties.Appearance.Options.UseFont = true;
			this.cecentsamnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cecentsamnt.Properties.Mask.BeepOnError = true;
			this.cecentsamnt.Properties.Mask.EditMask = "n2";
			this.cecentsamnt.Size = new System.Drawing.Size(149, 26);
			this.cecentsamnt.TabIndex = 1;
			this.cecentsamnt.TabStop = false;
			//
			//ceGT
			//
			this.ceGT.EnterMoveNextControl = true;
			this.ceGT.Location = new System.Drawing.Point(333, 497);
			this.ceGT.Name = "ceGT";
			this.ceGT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.ceGT.Properties.Appearance.Options.UseFont = true;
			this.ceGT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ceGT.Properties.Mask.BeepOnError = true;
			this.ceGT.Properties.Mask.EditMask = "n";
			this.ceGT.Size = new System.Drawing.Size(149, 26);
			this.ceGT.TabIndex = 1;
			this.ceGT.TabStop = false;
			//
			//LabelControl14
			//
			this.LabelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", (float) (12.25F));
			this.LabelControl14.Location = new System.Drawing.Point(291, 504);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(36, 19);
			this.LabelControl14.TabIndex = 24;
			this.LabelControl14.Text = "Total";
			//
			//frmReading
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(590, 539);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.ceCents);
			this.Controls.Add(this.ceOne);
			this.Controls.Add(this.ceFive);
			this.Controls.Add(this.ceTen);
			this.Controls.Add(this.ceTwenty);
			this.Controls.Add(this.ceFifty);
			this.Controls.Add(this.ceOneHundred);
			this.Controls.Add(this.ceTwoHundred);
			this.Controls.Add(this.ceFiveHundred);
			this.Controls.Add(this.ceGT);
			this.Controls.Add(this.cecentsamnt);
			this.Controls.Add(this.ceonepesoamnt);
			this.Controls.Add(this.cefiveamnt);
			this.Controls.Add(this.cetenamnt);
			this.Controls.Add(this.cetwentyamnt);
			this.Controls.Add(this.cefiftyamnt);
			this.Controls.Add(this.ceonehundredamnt);
			this.Controls.Add(this.cethamnt);
			this.Controls.Add(this.cefivehamnt);
			this.Controls.Add(this.cekAmnt);
			this.Controls.Add(this.ceThousand);
			this.Controls.Add(this.ceCheque);
			this.Controls.Add(this.LabelControl14);
			this.Controls.Add(this.LabelControl11);
			this.Controls.Add(this.LabelControl10);
			this.Controls.Add(this.LabelControl9);
			this.Controls.Add(this.LabelControl8);
			this.Controls.Add(this.LabelControl7);
			this.Controls.Add(this.LabelControl6);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.LabelControl13);
			this.Controls.Add(this.LabelControl12);
			this.Controls.Add(this.LabelControl1);
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmReading";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cash and Cheque Breakdown Entry Form";
			((System.ComponentModel.ISupportInitialize) this.ceCheque.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceThousand.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceFiveHundred.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceTwoHundred.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceOneHundred.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceFifty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceTwenty.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceTen.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceFive.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceOne.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceCents.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cekAmnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cefivehamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cethamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceonehundredamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cefiftyamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cetwentyamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cetenamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cefiveamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceonepesoamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cecentsamnt.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ceGT.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.CalcEdit ceCheque;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.CalcEdit ceThousand;
		internal DevExpress.XtraEditors.CalcEdit ceFiveHundred;
		internal DevExpress.XtraEditors.CalcEdit ceTwoHundred;
		internal DevExpress.XtraEditors.CalcEdit ceOneHundred;
		internal DevExpress.XtraEditors.CalcEdit ceFifty;
		internal DevExpress.XtraEditors.CalcEdit ceTwenty;
		internal DevExpress.XtraEditors.CalcEdit ceTen;
		internal DevExpress.XtraEditors.CalcEdit ceFive;
		internal DevExpress.XtraEditors.CalcEdit ceOne;
		internal DevExpress.XtraEditors.CalcEdit ceCents;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.SimpleButton btnSave;
		internal DevExpress.XtraEditors.SimpleButton btnClose;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.CalcEdit cekAmnt;
		internal DevExpress.XtraEditors.CalcEdit cefivehamnt;
		internal DevExpress.XtraEditors.CalcEdit cethamnt;
		internal DevExpress.XtraEditors.CalcEdit ceonehundredamnt;
		internal DevExpress.XtraEditors.CalcEdit cefiftyamnt;
		internal DevExpress.XtraEditors.CalcEdit cetwentyamnt;
		internal DevExpress.XtraEditors.CalcEdit cetenamnt;
		internal DevExpress.XtraEditors.CalcEdit cefiveamnt;
		internal DevExpress.XtraEditors.CalcEdit ceonepesoamnt;
		internal DevExpress.XtraEditors.CalcEdit cecentsamnt;
		internal DevExpress.XtraEditors.CalcEdit ceGT;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
	}
	
}
