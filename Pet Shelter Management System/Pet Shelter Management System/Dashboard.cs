using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MetroFramework.Forms;


namespace Pet_Shelter_Management_System
{
    public partial class Dashboard : MetroForm
    {
        internal DataAccess da { get; set; }
        internal string sql { get; set; }
        internal DataSet ds { get; set; }

        public Dashboard()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.PopularGridViewSeePets();

        }

        private void btnSearchAv_Click(object sender, EventArgs e)
        {
            this.sql = @"select * from petinfo
                    where pettype = '"+this.txtLookigFor.Text+"' and petcatagory like '"+this.cmbSelectCatagory.Text+"';";

            this.PopularGridViewSeePets(sql);

        }

       

        private void btnSeeAvailablePets_Click(object sender, EventArgs e)
        {
            this.sql = @"select * from petinfo;";
            this.PopularGridViewSeePets();
        }

        private void PopularGridViewSeePets(string sql = @"select * from petinfo;")
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvSeePetDetail.AutoGenerateColumns = false;
            this.dgvSeePetDetail.DataSource = this.ds.Tables[0];
            
        }
        private bool IsValidToSaveRequestInfo()
        {

            if (String.IsNullOrEmpty(this.txtFilloutUserID.Text) 
                || String.IsNullOrEmpty(this.txtFillOutType.Text)
                || String.IsNullOrEmpty(this.cmbFillOutCatagory.Text))
                

            {
                return false;
            }
            else
            {
                return true;
            }
        }





        private void btnFillOutRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveRequestInfo())
                {
                    this.sql = @"insert into requestinfo
                        values('" + this.txtFilloutUserID.Text + "','" + this.txtFillOutPetID.Text + @"'
                           ,'" + this.txtFillOutType.Text + "','" + this.cmbFillOutCatagory.Text + "','" + this.cmbFillOutFoster.Text + "');";
                    int count = this.da.ExecuteUpdateQuery(this.sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insert seccessfully");
                    }
                    else
                    {
                        MessageBox.Show("Check data");
                    }
                }
                else 
                {
                    MessageBox.Show("Pleaase Fill All The Information");
                }


                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error"+exc.Message);
            }
            
        
        }
        private void ClearData() 
        {
            this.txtFilloutUserID.Text = "";
            this.txtFillOutPetID.Text = "";
            this.txtFillOutType.Text = "";
            this.cmbFillOutCatagory.Text = "";
            this.cmbFillOutFoster.Text = "";
        }

        private void btnFillClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        private void btnDashboardLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
