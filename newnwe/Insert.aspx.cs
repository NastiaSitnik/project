using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Npgsql;


namespace newnwe
{


    public partial class Insert : System.Web.UI.Page
    {
       
        
        private NpgsqlCommand comand;
        
    
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Insert";
            Page.Form.Method = "post";
            Label1.Text = "Add a receipt ";
            Label2.Text = "Name"; Label3.Text = "Company";
            Label4.Text = "Number"; Label5.Text = "Arrears";
            Label6.Text = "Suma";
            TextBox2.Focus();
            TextBox3.Focus();
            TextBox4.Focus();
            TextBox5.Focus();
            TextBox6.Focus();
            Button1.Text = "Ready";
            Button1.Width = 125;
            TextBox2.Width = 140;
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.ErrorMessage = "* fill Name";
            RequiredFieldValidator3.ControlToValidate = "TextBox3";
            RequiredFieldValidator3.ErrorMessage = "* fill Company ";
            RequiredFieldValidator4.ControlToValidate = "TextBox4";
            RequiredFieldValidator4.ErrorMessage = "* fill  Number";
            RequiredFieldValidator5.ControlToValidate = "TextBox5";
            RequiredFieldValidator5.ErrorMessage = "* fill Arrears";
            RequiredFieldValidator6.ControlToValidate = "TextBox6";
            RequiredFieldValidator6.ErrorMessage = "* fill Suma";

        }

        protected void Button1_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Готово"
            bool auto = false;
            comand = new NpgsqlCommand("Select Max(id) From receipt", WebForm3.conn);
            int id = Convert.ToInt32(comand.ExecuteScalar()) + 1;
            // Строка SQL-запроса для проверки имени и пароля
            string sql = "INSERT INTO receipt (id,name,company,number,arrears,suma) VALUES('"+id+"','" + TextBox2.Text + "','" + TextBox3.Text + "', '" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')";
            // Создание объекта Command с заданием SQL-запроса'
            comand.Dispose();
            try
            {   // Выполнение команды SQL
                comand = new NpgsqlCommand(sql, WebForm3.conn);

                // Выполнение команды SQL
                comand.ExecuteNonQuery();

                comand.Dispose();
               Label7.Text = "Successfully aded";
                auto = true;
               
            }
            catch (Exception ex)
            {
                Label7.Text = "<br />" + ex.Message;
            }

            if (auto)
            // Направляем пользователя на уже разрешенную страницу
            {
                Response.Redirect("Info.aspx");
            }
        }
    }
}
