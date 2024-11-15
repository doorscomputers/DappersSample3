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
	public partial class frmCustSearch
	{
		public frmCustSearch()
		{
			InitializeComponent();
		}
		public int vCustid = 0;
		public string vLname = string.Empty;
		public string vFname = string.Empty;
		public void frmCustSearch_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmCustSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				MessageBox.Show("Please Note that no customer is selected when you pressed the ESC key!");
				vCustid = 205;
				vLname = "CASH";
				vFname = "CASH";
				this.Close();
			}
		}
		
		public void frmCustSearch_Load(object sender, EventArgs e)
		{
			txtLastname.Focus();
		}
		
		public void LoadCust()
		{
			if (txtLastname.Text == string.Empty)
			{
				MessageBox.Show("Enter a lastname to seaarch !");
				txtLastname.Focus();
				return;
			}
			else
			{
				
				membersManager mgrmembers = default(membersManager);
				membersCollection cols = default(membersCollection);
				try
				{
					mgrmembers = new membersManager();
					mgrmembers.DataObject.SelectFilter = membersData.SelectFilters.ListBox;
					mgrmembers.DataObject.WhereFilter = membersData.WhereFilters.Likelastname;
					mgrmembers.Entity.lastname = txtLastname.Text.ToString();
					mgrmembers.DataObject.OrderByFilter = membersData.OrderByFilters.lastname;
					cols = mgrmembers.BuildCollection();
					if (mgrmembers.DataObject.RowsAffected > 0)
					{
						dgcustomer.DataSource = cols;
						dgcustomer.Columns[0].Width = 0;
						dgcustomer.Columns[1].Width = 300;
						dgcustomer.Columns[2].Width = 300;
						dgcustomer.Columns[3].Width = 50;
						dgcustomer.Focus();
					}
					else
					{
						MessageBox.Show("No customers related to the search criteria!");
					}
					
				}
				catch (PDSAValidationException)
				{
					//    MessageBox.Show(ex.Message)
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void btnSearch_Click(object sender, EventArgs e)
		{
			LoadCust();
		}
		
		public void txtLastname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				dgcustomer.Focus();
			}
			if (e.KeyCode == Keys.Right)
			{
				btnSearch.Focus();
			}
		}
		
		public void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				LoadCust();
			}
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void dgcustomer_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				
				if (dgcustomer.Rows.Count < 1)
				{
					return;
				}
				try
				{
					int vRow = 0;
					int vint = 0;
					string x1 = string.Empty;
					string x2 = string.Empty;
					vRow = dgcustomer.CurrentRow.Index;
					vint = System.Convert.ToInt32(dgcustomer[0, vRow].Value);
					x1 = (dgcustomer[1, vRow].Value).ToString();
					x2 = (dgcustomer[2, vRow].Value).ToString();
					vCustid = vint;
					vLname = x1;
					vFname = x2;
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				e.SuppressKeyPress = true;
			}
			
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			txtLastname.Focus();
		}
	}
}
