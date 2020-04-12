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
    public partial class WebForm1 : System.Web.UI.Page
    {

        NpgsqlCommand comand;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Registration";


            try
            {
                TextBox1.Focus();
                Label1.Text = "Firstname";
                Label2.Text = "Lastname";
                Label3.Text = "E-mail";
                Label4.Text = "Password";
                Label5.Text = "Confirm password";
                Label6.Text = "Role";
                TextBox4.TextMode = TextBoxMode.Password;
                TextBox5.TextMode = TextBoxMode.Password;
                // Контролируем факт заполнения текстовых полей:
                RequiredFieldValidator1.ControlToValidate = "TextBox1";
                RequiredFieldValidator1.ErrorMessage = "* fill Name";
                RequiredFieldValidator2.ControlToValidate = "TextBox2";
                RequiredFieldValidator2.ErrorMessage = "* fill Surname ";
                RequiredFieldValidator3.ControlToValidate = "TextBox3";
                RequiredFieldValidator3.ErrorMessage = "* fill  E-mail";
                RequiredFieldValidator4.ControlToValidate = "TextBox4";
                RequiredFieldValidator4.ErrorMessage = "* fill password";
                RequiredFieldValidator5.ControlToValidate = "TextBox6";
                RequiredFieldValidator5.ErrorMessage = "* fill role";
                RegularExpressionValidator1.ControlToValidate = "TextBox3";
                RegularExpressionValidator1.ValidationExpression = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
                RegularExpressionValidator1.ErrorMessage = "* write correct e-mail ";
                // Контроль правильности введения пароля:
                CompareValidator1.ControlToValidate = "TextBox4";
                CompareValidator1.ControlToCompare = "TextBox5";
                CompareValidator1.ErrorMessage = "* Different passwords";
                Button1.Text = "Ready";
            }
            catch (Exception ex)
            {
                Response.Write("<BR>" + ex.Message);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                //Определение максимального ID
                comand = new NpgsqlCommand("Select Max(id) From users", WebForm3.conn);
                int id = Convert.ToInt32(comand.ExecuteScalar()) + 1;

                // ДОБАВЛЕНИЕ ЗАПИСИ О ПОЛЬЗОВАТЕЛЕ В БД.
                // Строка SQL-запроса
                string sql = "INSERT INTO users (id, firstname, lastname, email, password, role)" +
                "VALUES (" + id + ", '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text +
                "', '" + TextBox4.Text + "', '" + TextBox6.Text + "')";
                comand.Dispose();
                comand = new NpgsqlCommand(sql, WebForm3.conn);

                // Выполнение команды SQL, т. е. ЗАПИСЬ В БД
                comand.ExecuteNonQuery();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                Response.Write("<br><br>" + ex.Message);
            }

        }
    }
}