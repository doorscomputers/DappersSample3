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

using PDSA.DataLayer.DataClasses;
using PDSA.Validation;

namespace DoorsPOS.WinApp
{
	public partial class frmLoginEmp
	{
		public frmLoginEmp()
		{
			InitializeComponent();
		}
		int userid = 0;
		string username = string.Empty;
		
		public void frmLoginEmp_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				userid = 0;
				username = string.Empty;
				try
				{
					waitersManager mgremp = new waitersManager();
					waitersCollection cols = new waitersCollection();
					mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword;
					mgremp.Entity.pword = txtPass.Text.Trim();
					cols = mgremp.BuildCollection();
					if (mgremp.DataObject.RowsAffected > 0)
					{
						userid = mgremp.DataObject.Entity.wtid;
						username = mgremp.DataObject.Entity.waiter;
						
						//Check if the user is already logged in
						try
						{
							EmployeeTransManager mgr = new EmployeeTransManager();
							EmployeeTransCollection colss = new EmployeeTransCollection();
							mgr.DataObject.WhereFilter = EmployeeTransData.WhereFilters.fkdate;
							mgr.Entity.fkwtid = userid;
							mgr.Entity.trandate = DateTime.Today;
							colss = mgr.BuildCollection();
							if (mgr.DataObject.RowsAffected > 0)
							{
								MessageBox.Show("User is already logged in");
							}
							else
							{
								//add a new record to the Employee Trans table
								try
								{
									EmployeeTransManager mgrempadd = new EmployeeTransManager();
									mgrempadd.Entity.trandate = DateTime.Today;
									mgrempadd.Entity.empbreak = DateAndTime.Now;
									mgrempadd.Entity.empbreakin = DateAndTime.Now;
									mgrempadd.Entity.empin = DateAndTime.Now;
									mgrempadd.Entity.empout = DateAndTime.Now;
									mgrempadd.Entity.stats = false;
									mgrempadd.Entity.fkwtid = userid;
									//mgremp.Entity
									mgrempadd.DataObject.Insert();
									MessageBox.Show(username + " Successfully Logged In");
									this.Close();
								}
								catch (PDSA.Validation.PDSAValidationException ex)
								{
									MessageBox.Show(ex.Message);
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.ToString());
								}
							}
							
							
						}
						catch (PDSA.Validation.PDSAValidationException ex)
						{
							MessageBox.Show(ex.Message);
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.ToString());
						}
						
					}
					else
					{
						MessageBox.Show("Not a valid password, try again.");
						
					}
				}
				catch (PDSAApplicationException ex)
				{
					MessageBox.Show(ex.Message);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}
		
		public void txtPass_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
