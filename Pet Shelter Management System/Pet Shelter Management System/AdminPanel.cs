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
    public partial class AdminPanel : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal string Sql { get; set; }
        internal DataSet Ds { get; set; }
        internal DataTable Dt { get; set; }
     
        

        public AdminPanel()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
            this.PopularGridView();
           
            this.PopularGridViewSeePet();
           
            this.PopularGridViewRequestPet();
            this.AutoIdGenerate();
            this.AutoIdGeneratePet();
        }

        private void grdviewMember_Click(object sender, EventArgs e)
        {

           // this.sql = @"select * from info;";
            this.PopularGridView();
        }

        private void btnGDVseepetdetails_Click(object sender, EventArgs e)
        {

           // this.sql = @"select * from petinfo;";
            this.PopularGridViewSeePet();
        }

        private void btnGDVRequestedPet_Click(object sender, EventArgs e)
        {
           // this.sql = @"select * from requestinfo;";
            this.PopularGridViewRequestPet();
        }


         private void PopularGridView(string sql = @"select * from info;")
         {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvMemberDetails.AutoGenerateColumns = false;
           this.dgvMemberDetails.DataSource = this.Ds.Tables[0];
        }

        private void PopularGridViewSeePet (string sql = @"select * from petinfo;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvSeePetDetails.AutoGenerateColumns = false;
            this.dgvSeePetDetails.DataSource = this.Ds.Tables[0];
        }

       private void PopularGridViewRequestPet(string sql = @"select * from requestinfo;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvRequestedPet.AutoGenerateColumns = false;
            this.dgvRequestedPet.DataSource = this.Ds.Tables[0];
        }

        private void btnMemberSearch_Click(object sender, EventArgs e)
         {
            this.Sql = @"select * from info
                         where type = '"+this.txtSearchType.Text+"';";
            this.PopularGridView(Sql);
        }

        private void btnSearchPetType_Click(object sender, EventArgs e)
        {
            this.Sql = @"select* from petinfo
                        where pettype = '"+this.txtSearchPetType.Text+"';";
            this.PopularGridViewSeePet(Sql);

        }

        private void btnSearchCatagory_Click(object sender, EventArgs e)
        {


            this.Sql = @"select* from requestinfo
                        where catagory = '"+this.txtSearchCatagory.Text+"';";
            this.PopularGridViewRequestPet(Sql);

            
        }
        private bool IsValidToSaveInfo() 
        {

            if (String.IsNullOrEmpty(this.txtFullName.Text) || String.IsNullOrEmpty(this.txtNewID.Text)
                || String.IsNullOrEmpty(this.cmbNewAccountType.Text)
                || String.IsNullOrEmpty(this.txtNewAge.Text) || String.IsNullOrEmpty(this.txtNewPassword.Text)
                || String.IsNullOrEmpty(this.cmbNewGender.Text) || String.IsNullOrEmpty(this.txtNewAddress.Text) 
                || String.IsNullOrEmpty(this.dtpDOB.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsValidToSaveInfo())
                {

                    DataTable dt = this.Da.ExecuteQueryTable(@"select * from info where id = '"+this.txtNewID.Text+"';");

                    if (dt.Rows.Count == 1)
                    {
                        this.Sql = @"update info
                                    set 
                                    type = '"+this.cmbNewAccountType.Text+@"',
                                    fullname = '"+this.txtFullName.Text+@"',
                                     password = '"+this.txtNewPassword.Text+@"',
                                    dob = '"+this.dtpDOB.Text+@"',
                                    age = "+this.txtNewAge.Text+@",
                                     gender = '"+this.cmbNewGender.Text+@"'
                                     where id = '"+this.txtNewID.Text+"';";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                        {
                            MessageBox.Show("Data updated seccessfully");
                        }
                        else
                        {
                            MessageBox.Show("Check data");
                        }
                        this.PopularGridView();
                        this.DataClearInfo();
                    }
                    else if(dt.Rows.Count == 0)
                    {
                        this.Sql = @"insert into info
                       values('" + this.txtFullName.Text + "','" + this.cmbNewAccountType.Text + "','" + this.txtNewID.Text + "'," +
                       "'" + this.txtNewPassword.Text + @"','" + this.dtpDOB.Text + "'," + this.txtNewAge.Text + "" +
                       ",'" + this.cmbNewGender.Text + @"','" + this.txtNewAddress.Text + "');";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                        {
                            MessageBox.Show("Data insert seccessfully");
                        }
                        else
                        {
                            MessageBox.Show("Check data");
                        }
                        this.PopularGridView();
                        this.DataClearInfo();
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Pleaase Fill All The Information");
                }
                
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Error : " + exc.Message);
            }
           

        }

        private bool IsValidToSavePetInfo()
        {

            if (String.IsNullOrEmpty(this.txtPetNewID.Text) || String.IsNullOrEmpty(this.txtPetNewType.Text)
                || String.IsNullOrEmpty(this.txtPetNewAge.Text)
                || String.IsNullOrEmpty(this.txtPetNewWeight.Text) || String.IsNullOrEmpty(this.txtPetNewColor.Text)
                || String.IsNullOrEmpty(this.cmbPetNewCatagory.Text))
                
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnPetSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.IsValidToSavePetInfo())
                {
                   DataTable dt = this.Da.ExecuteQueryTable(@"select * from petinfo where petid = '" + this.txtPetNewID.Text + "';");

                    if (dt.Rows.Count == 1)
                    {
                        this.Sql = @"update petinfo
                                   set 
                                       pettype = '" + this.txtPetNewType.Text + @"',
                                       petage = '" + this.txtPetNewAge.Text + @"',
                                        weight = '" + this.txtPetNewWeight.Text + @"',
                                         color = '" + this.txtPetNewColor.Text + @"',
                                       petcatagory = '" +this.cmbPetNewCatagory.Text + @"'
                                       where petid = '" + this.txtPetNewID.Text + "';";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Data Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("check data");
                        }

                        this.PopularGridViewSeePet();
                        this.DataClearPetInfo();

                    }
                    else if (dt.Rows.Count == 0) 
                    {

                        this.Sql = @"insert into petinfo
                         values('" + this.txtPetNewID.Text + "','" + this.txtPetNewType.Text + @"'," +
                        "'" + this.txtPetNewAge.Text + "','" + this.txtPetNewWeight.Text + @"" +
                        "','" + this.txtPetNewColor.Text + "','" + this.cmbPetNewCatagory.Text + "');";

                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                        {
                            MessageBox.Show("Data insert seccessfully");
                        }
                        else
                        {
                            MessageBox.Show("Check data");
                        }
                        this.PopularGridViewSeePet();
                        this.DataClearPetInfo();
                    }
                    else
                    {
                        MessageBox.Show("Pleaase Fill All The Information");
                    }
                }
            }



            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }

            
        }

        private void btnPetDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvSeePetDetails.CurrentRow.Cells[0].Value.ToString();
                this.Sql = @"delete from petinfo where petid= '"+ id +"';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Pet ID "+ id +" has been deleted");
                }
                else
                {
                    MessageBox.Show("Error while deleting data");
                }
                this.PopularGridViewSeePet();
                this.DataClearPetInfo();

                


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error : " + exc.Message);
            }
        }

        private void btnNewAccountDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = this.dgvMemberDetails.CurrentRow.Cells["fullname"].Value.ToString();
                this.Sql = @"delete from info where fullname= '"+ fullname +"';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Member " + fullname + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Error while deleting data");
                }
                this.PopularGridView();
                this.DataClearInfo();

                //MessageBox.Show(fullname);
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Error : " + exc.Message);
            }
        }
        private void DataClearInfo()
        {
            this.txtFullName.Text = "";
            this.AutoIdGenerate();
            //this.AutoIdGenerateUser();
            //this.txtNewID.Text = "";
            this.cmbNewAccountType.Text = "";
            this.txtNewAge.Text = "";
            this.txtNewPassword.Text = "";
            this.cmbNewGender.Text = "";
            this.dtpDOB.Text = "";
            this.txtNewAddress.Text = "";
        }

        private void btnNewClear_Click(object sender, EventArgs e)
        {
            this.DataClearInfo();
        }

        private void DataClearPetInfo() 
        {
            // this.txtPetNewID.Text = "";
            this.AutoIdGeneratePet();
            this.txtPetNewType.Text = "";
            this.txtPetNewAge.Text = "";
            this.txtPetNewWeight.Text = "";
            this.txtPetNewColor.Text = "";
            this.cmbPetNewCatagory.Text = "";
        }
        private void btnPetNewClear_Click(object sender, EventArgs e)
        {
            this.DataClearPetInfo();
          
        }

        private void dgvMemberDetails_DoubleClick(object sender, EventArgs e)
        {
            this.txtFullName.Text = this.dgvMemberDetails.CurrentRow.Cells["fullname"].Value.ToString();
            this.txtNewID.Text = this.dgvMemberDetails.CurrentRow.Cells["id"].Value.ToString();
            this.cmbNewAccountType.Text = this.dgvMemberDetails.CurrentRow.Cells["type"].Value.ToString();
            this.txtNewAge.Text = this.dgvMemberDetails.CurrentRow.Cells["age"].Value.ToString();
            this.txtNewPassword.Text = this.dgvMemberDetails.CurrentRow.Cells["password"].Value.ToString();
            this.cmbNewGender.Text = this.dgvMemberDetails.CurrentRow.Cells["gender"].Value.ToString();
            this.dtpDOB.Text = this.dgvMemberDetails.CurrentRow.Cells["dob"].Value.ToString();
            this.txtNewAddress.Text = this.dgvMemberDetails.CurrentRow.Cells["address"].Value.ToString();
        }

        private void dgvSeePetDetails_DoubleClick(object sender, EventArgs e)
        {

            this.txtPetNewID.Text = this.dgvSeePetDetails.CurrentRow.Cells["petid"].Value.ToString();
            this.txtPetNewType.Text = this.dgvSeePetDetails.CurrentRow.Cells["pettype"].Value.ToString();
            this.txtPetNewAge.Text = this.dgvSeePetDetails.CurrentRow.Cells["petage"].Value.ToString();
            this.txtPetNewWeight.Text = this.dgvSeePetDetails.CurrentRow.Cells["weight"].Value.ToString();
            this.cmbPetNewCatagory.Text = this.dgvSeePetDetails.CurrentRow.Cells["petcatagory"].Value.ToString();
            this.txtPetNewColor.Text = this.dgvSeePetDetails.CurrentRow.Cells["color"].Value.ToString();
           
        }

        private void AutoIdGenerate() 
        {
            if (this.cmbNewAccountType.Text == "admin")
            {
                this.Sql = @"select id from info where type = 'admin' order by id desc;";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string previousId = dt.Rows[0][0].ToString();
                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string newId = "A-" + (++serialNo).ToString("000");
                this.txtNewID.Text = newId;
            }

            else if (this.cmbNewAccountType.Text == "user")
            {
                this.Sql = @"select id from info where type = 'user' order by id desc;";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string previousId = dt.Rows[0][0].ToString();
                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string newId1 = "U-" + (++serialNo).ToString("000");
                this.txtNewID.Text = newId1;
            } 
        }
        private void AutoIdGeneratePet()
        {
            this.Sql = @"select petid from petinfo  order by petid desc;";

             Ds= this.Da.ExecuteQuery(this.Sql);
            string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId1 = "P-" + (++serialNo).ToString("000");
            this.txtPetNewID.Text = newId1;
        }

        private void dgvMemberDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
    }

