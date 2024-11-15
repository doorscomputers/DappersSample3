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
	public partial class frmSupplierSearch
	{
		public frmSupplierSearch()
		{
			InitializeComponent();
		}
		
		public string vSupplier = string.Empty;
		public int vSupCode = 0;
		suppliersManager mgrSupplier;
		suppliersCollection cols;
		
		public void btnSearch_Click(object sender, EventArgs e)
		{
			SearchSuppliers();
			//txtSupplier.Focus()
			//txtSupplier.SelectAll()
		}
		public void SearchSuppliers()
		{
			if (txtSupplier.Text == string.Empty)
			{
				MessageBox.Show("Enter a Supplier to seaarch.");
				txtSupplier.Focus();
				return;
			}
			else
			{
				
				
				try
				{
					mgrSupplier = new suppliersManager();
					mgrSupplier.DataObject.SelectFilter = suppliersData.SelectFilters.ListBox;
					mgrSupplier.DataObject.WhereFilter = suppliersData.WhereFilters.Likesupplier;
					mgrSupplier.Entity.supplier = txtSupplier.Text.Trim();
					mgrSupplier.DataObject.OrderByFilter = suppliersData.OrderByFilters.supplier;
					//mgrSupplier.DataObject.Load()
					cols = mgrSupplier.BuildCollection();
					if (mgrSupplier.DataObject.RowsAffected > 0)
					{
						dgSuppliers.DataSource = cols;
						dgSuppliers.Columns[0].Visible = false;
						dgSuppliers.Columns[1].Visible = true;
						//dgitems.Columns(1).Width = 500
						dgSuppliers.Columns[1].HeaderText = "Supplier";
						dgSuppliers.Columns[1].Width = 700;
						//dgSuppliers.Columns(3).Width = 300
						//dgitems.Columns(4).Width = 400
						dgSuppliers.Columns[2].Visible = false;
						dgSuppliers.Columns[3].Visible = false;
						dgSuppliers.Columns[4].Visible = false;
						dgSuppliers.Columns[5].Visible = false;
						dgSuppliers.Columns[6].Visible = false;
						dgSuppliers.Columns[7].Visible = false;
						dgSuppliers.Columns[8].Visible = false;
						dgSuppliers.Columns[9].Visible = false;
						dgSuppliers.Columns[10].Visible = false;
						dgSuppliers.Columns[11].Visible = false;
						dgSuppliers.Columns[12].Visible = false;
						dgSuppliers.Columns[13].Visible = false;
						dgSuppliers.Columns[14].Visible = false;
						dgSuppliers.Columns[15].Visible = false;
						dgSuppliers.Columns[16].Visible = false;
						dgSuppliers.Columns[17].Visible = false;
						dgSuppliers.Columns[18].Visible = false;
						
						dgSuppliers.Focus();
					}
					else
					{
						MessageBox.Show("No Supplier(s) related to the search criteria!");
						txtSupplier.Focus();
						txtSupplier.SelectAll();
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
		public void dgSuppliers_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				
				if (dgSuppliers.Rows.Count < 1)
				{
					return;
				}
				try
				{
					int vRow = 0;
					int vint = 0;
					string x1 = string.Empty;
					
					
					vRow = dgSuppliers.CurrentRow.Index;
					vint = System.Convert.ToInt32(dgSuppliers[0, vRow].Value);
					x1 = (dgSuppliers[1, vRow].Value).ToString();
					
					vSupCode = vint;
					vSupplier = x1;
					
					this.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				e.SuppressKeyPress = true;
			}
			
		}
		
		public void frmItemSearch_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void frmItemSearch_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
		public void frmItemSearch_Load(object sender, EventArgs e)
		{
			txtSupplier.Focus();
		}
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void btnItem_Click(object sender, EventArgs e)
		{
			txtSupplier.Focus();
			txtSupplier.SelectAll();
		}
		
		public void txtSupplier_KeyDown1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				dgSuppliers.Focus();
			}
			if (e.KeyCode == Keys.Right)
			{
				btnSearch.Focus();
			}
		}
		public void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				SearchSuppliers();
			}
		}
	}
	
	
}
