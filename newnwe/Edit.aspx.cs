using System;
using System.Data;
using System.Web;
using System.Web.UI;
using Npgsql;

namespace newnwe
{
   
    public partial class Edit : System.Web.UI.Page
    {
        string sql;
        string sql1;
        public NpgsqlCommand comand;

        protected void Page_Load(object sender, EventArgs e)
        {
            sql = "Select * From receipt";
            NpgsqlDataAdapter dat = new NpgsqlDataAdapter(sql, WebForm3.conn);
            DataSet ds = new DataSet();
            dat.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

            dat.Dispose();
            Label1.Text = " Enter name of user and number of receipt which you whant to edit, please";
            Label2.Text = " name: ";
            TextBox2.Focus();
           
            Label3.Text = " number: ";
            TextBox3.Focus();
            
            Button1.Text = "Edit";
           



        }
        protected void Button1_Click (object sender, EventArgs e)
        {

            //sql = "Select * From receipt where name = '" + TextBox2.Text + "' and number = '" + TextBox3.Text + "'";

            Label4.Text = " Enter new  receipt";
            Label5.Text = " name: ";
            TextBox5.Focus();
            Label6.Text = " company: ";
            TextBox6.Focus();
            Label7.Text = " number: ";
            TextBox7.Focus();
            Label8.Text = " arrears: ";
            TextBox8.Focus();
            Label9.Text = " suma: ";
            TextBox9.Focus();
            Button2.Text = " ready ";

        }
        protected void Button2_Click(object sender, EventArgs e )
        {

            bool auto = false;
            sql = "Delete from receipt where name = '" + TextBox2.Text + "' and number = '" + TextBox3.Text + "'";
            // Выполнение команды SQL
            comand = new NpgsqlCommand(sql, WebForm3.conn);

            // Выполнение команды SQL
            comand.ExecuteNonQuery();

            comand.Dispose();

            comand = new NpgsqlCommand("Select Max(id) From users", WebForm3.conn);
            int id = Convert.ToInt32(comand.ExecuteScalar()) + 1;
            
            sql1 = "INSERT INTO receipt(id, name, company, number, arrears, suma) VALUES('" + id + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "', '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + TextBox9.Text + "')";
            try
            {   // Выполнение команды SQL
                comand = new NpgsqlCommand(sql1, WebForm3.conn);

                // Выполнение команды SQL
                comand.ExecuteNonQuery();

                comand.Dispose();


                auto = true;
            }
            catch (Exception ex)
            {
                Label7.Text = "<br />" + ex.Message;
            }
            if (auto)
            {// Направляем пользователя на уже разрешенную страницу
                Response.Redirect("Info.aspx");
            }
        }
    }
}
