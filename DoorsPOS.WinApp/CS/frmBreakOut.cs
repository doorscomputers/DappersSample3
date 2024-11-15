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
	public partial class frmBreakOut
	{
		public frmBreakOut()
		{
			InitializeComponent();
		}
		int userid = 0;
		string username = string.Empty;
		int pkemptrans = 0;
		public void frmBreakOut_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		
		public void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				userid = 0;
				username = string.Empty;
				pkemptrans = 0;
				try
				{
					// check if the password exist
					waitersManager mgremp = new waitersManager();
					waitersCollection cols = new waitersCollection();
					mgremp.DataObject.WhereFilter = waitersData.WhereFilters.pword;
					mgremp.Entity.pword = txtPass.Text.Trim();
					cols = mgremp.BuildCollection();
					if (mgremp.DataObject.RowsAffected > 0)
					{
						userid = mgremp.DataObject.Entity.wtid;
						username = mgremp.DataObject.Entity.waiter;
						
						//Check if the user is already logged in by checking the fkwtid
						// and the current date field
						try
						{
							EmployeeTransManager mgr = new EmployeeTransManager();
							EmployeeTransCollection colss = new EmployeeTransCollection();
							mgr.DataObject.SelectFilter = EmployeeTransData.SelectFilters.All;
							mgr.DataObject.WhereFilter = EmployeeTransData.WhereFilters.fkdate;
							mgr.Entity.fkwtid = userid;
							mgr.Entity.trandate = DateTime.Today;
							//colss = mgr.BuildCollection()
							mgr.DataObject.Load();
							if (mgr.DataObject.RowsAffected > 0)
							{
								if (mgr.Entity.bempbreak == true)
								{
									MessageBox.Show("Employee has already completed this operation.");
									this.Close();
									return;
								}
								//MessageBox.Show("User is already logged in")
								//edit the empbreak field
								//get the primary key for update criteria
								pkemptrans = mgr.DataObject.Entity.linoutid;
								try
								{
									
									mgr.Entity.linoutid = pkemptrans;
									mgr.Entity.empbreak = DateAndTime.Now;
									mgr.Entity.bempbreak = true;
									mgr.DataObject.UpdateFilter = EmployeeTransData.UpdateFilters.PrimaryKey;
									mgr.DataObject.Update();
									MessageBox.Show("Break operation Successfull for " + username);
									this.Close();
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
							else
							{
								MessageBox.Show("Employee may not be logged in yet");
								this.Close();
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
		
	}
}
