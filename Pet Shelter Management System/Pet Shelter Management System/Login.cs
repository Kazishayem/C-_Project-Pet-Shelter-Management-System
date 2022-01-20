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
    public partial class Login : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal string Sql { get; set; }
        internal DataSet Ds { get; set; }
        internal DataTable Dt { get; set; }




        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }



        private void btnSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                this.Sql = @"select *  from info
                      where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";

                this.Ds = this.Da.ExecuteQuery(this.Sql);
                string a = Ds.Tables[0].Rows[0][1].ToString();
                if (a == "user")
                {
                    MessageBox.Show("Login Successfull");

                    Dashboard user = new Dashboard();
                    this.Hide();
                    user.Show();
                }
                else if (a == "admin") 
                {
                    MessageBox.Show("Login Successfull");

                    AdminPanel admin = new AdminPanel();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid id or password");

                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error :" + exc.Message);
            }
            


          /* this.Sql = @"select  DISTINCT type from info ;";
             DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
             string type = Dt.Rows[0][1].ToString();
             //string newId = Dt.Rows[0][0].ToString();
             if (type == "admin")

             {
                if (this.txtLoginID.Text == "id" && this.txtLoginPassword.Text == "password")
                 {
                     MessageBox.Show("SDSD");
                     this.Hide();
                     AdminPanel admin = new AdminPanel();

                     admin.Show();
                }
                 else 
                 {
                     MessageBox.Show("Invalid id or password");
                 }

             }

             else if(type == "user")
             {
               //  if (this.txtLoginID.Text == "id" && this.txtLoginPassword.Text == "password")
               //  {
                     MessageBox.Show("Login Sccessfull");
                     Dashboard user = new Dashboard();
                     this.Hide();
                     user.Show();
                 }
                 else 
                 {
                     MessageBox.Show(this.Ds.Tables[0].Rows[0][0].ToString());
                 }

             }  */

            /* try
             {
                 this.Sql = @"select type = 'admin' from info
                      where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";

                 this.Ds = this.Da.ExecuteQuery(this.Sql);
                 if (Ds.Tables[0].Rows.Count == 1)
                 {
                     MessageBox.Show("Login Successfull");

                     AdminPanel admin = new AdminPanel();
                     this.Hide();
                     admin.Show();
                 }
                 else 
                 {
                     MessageBox.Show("Login Unsuccessfull");

                 }
             }

             catch (Exception exc)
             {
                 MessageBox.Show("Error :" + exc.Message);
             }

             try 
             {
                 this.Sql = @"select type = 'user' from info
                      where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";

                 this.Ds = this.Da.ExecuteQuery(this.Sql);
                 if (Ds.Tables[0].Rows.Count == 1)
                 {
                     MessageBox.Show("Login Successfull");

                     Dashboard user = new Dashboard();
                     this.Hide();
                     user.Show();
                 }
                 else
                 {
                     MessageBox.Show("Login Unsuccessfull");

                 }
             }

             catch (Exception exc)
             {
                 MessageBox.Show("Error :" + exc.Message);
             } */

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtLoginID.Text = "";
            this.txtLoginPassword.Text = "";
        }
    }
}

 

            /* try 
             {
                 this.Sql = @"select id from info where id ='A-001'";
                 DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
                 string id = Dt.Rows[0][0].ToString();


                 this.Sql = @"select  from info where id ='A-001'";

                 DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

                 string id = Dt.Rows[0][0].ToString();


             }
             catch (Exception exc) 
             { 

             } */

// private FormManager Fm { get; set; }
//  private FormCashier Fc { get; set; }
/* try
 {
     this.Sql = "select id from info where id=' " + this.txtLoginID.Text + "';";
     DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
     string id = Dt.Rows[0][0].ToString();

     this.Sql = "select password from info where id ='" + id + "';";
     DataTable Dt1 = this.Da.ExecuteQueryTable(this.Sql);
     string password = Dt1.Rows[0][0].ToString();

     this.Sql = "select type from info where id ='" + id + "';";
     DataTable Dt2 = this.Da.ExecuteQueryTable(this.Sql);
     string userType = Dt2.Rows[0][0].ToString();

     if (this.txtLoginPassword.Text == password && userType == "admin")
     {
         this.Clear();
         this.Visible = false;
         AdminPanel admin = new AdminPanel();
         admin.Visible = true;
         MessageBox.Show("Success");

     }
     else if (this.txtLoginPassword.Text == password && userType == "user")
     {
         this.Clear();
         this.Visible = false;
     Dashboard user = new Dashboard();
         user.Visible = true;
         MessageBox.Show("Success");
     }
     else
         MessageBox.Show("Password is not correct");
 }

 catch (Exception)
 {
     MessageBox.Show("User not found");
 }
}

private void Clear()
{
 this.txtLoginID.Text = "";
 this.txtLoginPassword.Text = "";
} */



/*  this.sql = @"select  DISTINCT type from info ;";
 DataTable dt = this.da.ExecuteQueryTable(this.sql);
 string previousId = dt.Rows[0][            if (previousId == "admin")
0].ToString();
 {
     MessageBox.Show("Login Sccessfull");
     AdminPanel admin = new AdminPanel();
     this.Hide();
     admin.Show();
 }
 else 
 {
     MessageBox.Show("Login Sccessfull");
     Dashboard user = new Dashboard();
     this.Hide();
     user.Show();
 } */



/*  try
   {
       this.sql = @"select type = 'admin' from info
                 where id = '"+this.txtLoginID.Text+"' and password = '"+this.txtLoginPassword.Text+"';";

       this.ds = this.da.ExecuteQuery(this.sql);
       if (ds.Tables[0].Rows.Count == 1)
       {
           MessageBox.Show("Login Sccessfull");
           AdminPanel admin = new AdminPanel();
           this.Hide();
           admin.Show();
       }
       else if(this.sql == @"select type = 'user' from info
                          where id = '"+this.txtLoginID.Text+"' and password = '"+this.txtLoginPassword.Text+"';")
       {


         // this.sql = @"select type = 'user' from info
         //  where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";
          // this.ds = this.da.ExecuteQuery(this.sql);
       //   if (ds.Tables[0].Rows.Count == 1)
           // {
           MessageBox.Show("Login Sccessfull");
            Dashboard user = new Dashboard();
            this.Hide();
            user.Show();
           // }
      }


   }
   catch (Exception exc)
   {
       MessageBox.Show("Error :"+exc.Message);
   }

/*  try
  {
      this.sql = @"select type = 'user' from info
                 where id = '" + this.txtLoginID.Text + "' and password = '" + this.txtLoginPassword.Text + "';";

      this.ds = this.da.ExecuteQuery(this.sql);
      if (ds.Tables[0].Rows.Count == 1)
      {
          MessageBox.Show("Login Sccessfull");
          Dashboard user = new Dashboard();
          this.Hide();
          user.Show();
      }
      else
      {
          MessageBox.Show("Error");

      }
  }

  catch (Exception exc)
  {
      MessageBox.Show("Error :" + exc.Message);
  }








  /* if (this.sql == @"select type = 'admin' from info
       where id = '"+this.txtLoginID.Text+"' and password = '"+this.txtLoginPassword.Text+"';") 
   {
       this.ds = this.da.ExecuteQuery(this.sql);
       if (ds.Tables[0].Rows.Count == 1)
       {
           MessageBox.Show("Login Sccessfull");
           AdminPanel admin = new AdminPanel();
           this.Hide();
           admin.Show();
       }
       else if(this.sql == @"select type = 'user' from info
                   where id = '"+this.txtLoginID.Text+"' and password = '"+this.txtLoginPassword.Text+"';")
       {
           this.ds = this.da.ExecuteQuery(this.sql);
           //ds.Tables[0].Rows.Count = 1;
           Dashboard user = new Dashboard();
           this.Hide();
           user.Show();
           //MessageBox.Show("Login Unsccessfull");
       }
   } */




