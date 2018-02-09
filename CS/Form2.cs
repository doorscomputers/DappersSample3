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


/// <summary>
/// Sample Login screen page
/// </summary>
/// <remarks>by, Akhilesh B Chandran
/// akhileshbc @ VBForums</remarks>
namespace DoorsPOS.WinApp
{
	public partial class Form2
	{
		public Form2()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Form2 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
public static Form2 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Form2();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		bool bolExit = false; //~~~ Used to detect whether the form is being closed only after entering the correct password and not by pressing "Alt" + "F4"
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (txtPwd.Text.Trim().ToLower() == "abc") //~~~ Check if the password is correct
			{
				bolExit = true; //~~~ If so, we got the green signal to close the form :-)
				//MessageBox.Show("You are lucky !!!", "Success")
				this.Close(); //~~~ Close it
			}
			else //~~~ Otherwise, display a message
			{
				MessageBox.Show("Password Incorrect", "Wrong Password !!! ");
			}
		}
		
		public void Form2_DoubleClick(object sender, EventArgs e)
		{
			txtPwd.Visible = true;
			Label1.Visible = true;
			txtPwd.Focus();
		}
		
		public void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void Form2_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			if (bolExit == false) //~~~ When closing the form, checks whether it is being closed by "Alt" + "F4" or by entering the correct password.
			{
				e.Cancel = true; //~~~ If the closing is done without entering the correct password, then prevent the form from being closed
			}
		}
		
		public void Form2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F1)
			{
				txtPwd.Visible = true;
				Label1.Visible = true;
				txtPwd.Focus();
				//Button1.Visible = True
			}
		}
		
		public void Form2_Load(object sender, EventArgs e)
		{
			
		}
		
		public void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				
				ModCon.username = string.Empty;
				try
				{
					waitersManager mgremp = new waitersManager();
					waitersCollection cols = new waitersCollection();
					mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword;
					mgremp.Entity.pword = txtPwd.Text.Trim();
					cols = mgremp.BuildCollection();
					if (mgremp.DataObject.RowsAffected > 0)
					{
						bolExit = true; //~~~ If so, we got the green signal to close the form :-)
						//MessageBox.Show("You are lucky !!!", "Success")
						this.Close(); //~~~ Close it
					}
					else
					{
						MessageBox.Show("Not a valid password, try again.");
						
					}
				}
				catch (PDSAValidationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
	}
}
