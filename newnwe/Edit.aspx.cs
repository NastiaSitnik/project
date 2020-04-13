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
            Label2.Text = "Name: ";
            TextBox2.Focus();
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.ErrorMessage = "* fill Name";

            Label3.Text = "Number: ";
            TextBox3.Focus();
            RequiredFieldValidator3.ControlToValidate = "TextBox3";
            RequiredFieldValidator3.ErrorMessage = "* fill Number";
            Button1.Text = "Edit";
            Button2.Visible = false;
            Label4.Visible = Label5.Visible = Label6.Visible = Label7.Visible = Label8.Visible = Label9.Visible = false;
            TextBox5.Visible = TextBox6.Visible = TextBox7.Visible = TextBox8.Visible = TextBox9.Visible = false;
            RequiredFieldValidator5.Visible = RequiredFieldValidator6.Visible= RequiredFieldValidator7.Visible= RequiredFieldValidator8.Visible= RequiredFieldValidator9.Visible = false;


        }
        protected void Button1_Click (object sender, EventArgs e)
        {

            //sql = "Select * From receipt where name = '" + TextBox2.Text + "' and number = '" + TextBox3.Text + "'";
            Label4.Visible = Label5.Visible = Label6.Visible = Label7.Visible = Label8.Visible = Label9.Visible = true;
            TextBox5.Visible = TextBox6.Visible = TextBox7.Visible = TextBox8.Visible = TextBox9.Visible = true;
            RequiredFieldValidator5.Visible = RequiredFieldValidator6.Visible = RequiredFieldValidator7.Visible = RequiredFieldValidator8.Visible = RequiredFieldValidator9.Visible = true;
            RequiredFieldValidator5.Visible = true;
            Button2.Visible = true;
            Label4.Text = " Enter new  receipt";
            Label5.Text = " Name: ";
            TextBox5.Focus();
            RequiredFieldValidator5.ControlToValidate = "TextBox5";
            RequiredFieldValidator5.ErrorMessage = "* fill Name";
            Label6.Text = " Company: ";
            TextBox6.Focus();
            RequiredFieldValidator6.ControlToValidate = "TextBox6";
            RequiredFieldValidator6.ErrorMessage = "* fill Company";
            Label7.Text = " Number: ";
            TextBox7.Focus();
            RequiredFieldValidator7.ControlToValidate = "TextBox7";
            RequiredFieldValidator7.ErrorMessage = "* fill Number";
            Label8.Text = " Arrears: ";
            TextBox8.Focus();
            RequiredFieldValidator8.ControlToValidate = "TextBox8";
            RequiredFieldValidator8.ErrorMessage = "* fill Arrears";
            Label9.Text = " Suma: ";
            TextBox9.Focus();
            RequiredFieldValidator9.ControlToValidate = "TextBox9";
            RequiredFieldValidator9.ErrorMessage = "* fill Suma";
            Button2.Text = "Ready ";
           

        }
        protected void Button2_Click(object sender, EventArgs e )
        {

            bool auto = false;
            //sql = "Delete from receipt where name = '" + TextBox2.Text + "' and number = '" + TextBox3.Text + "'";
            //// Выполнение команды SQL
           
            //    comand = new NpgsqlCommand(sql, WebForm3.conn);

            //// Выполнение команды SQL
            //comand.ExecuteNonQuery();

            //comand.Dispose();
           

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
