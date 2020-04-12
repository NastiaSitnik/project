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
    public partial class WebForm3 : System.Web.UI.Page
    {

        public static NpgsqlConnection conn;
        public static string role = "";
        public static string name = "";
        public NpgsqlCommand comand;
        NpgsqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Authorization"; 
            Page.Form.Method = "post";
            Label1.Text = "Authorization of user";
            
            Label2.Text = "E-mail"; Label3.Text = "Password";

            Label4.Text = Label5.Text = "";
            TextBox1.Focus();
            TextBox2.TextMode = TextBoxMode.Password;
            Button1.Text = "Ready"; Button2.Text = "Registration";
            Button1.Width = 125; Button2.Width = 125;
            TextBox1.Width = 140; TextBox1.Width = 140;

            RequiredFieldValidator1.ControlToValidate = "TextBox1";
            RequiredFieldValidator1.ErrorMessage = "* you should fill E-mail";
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.ErrorMessage = "* you should fill password";

            RegularExpressionValidator1.ControlToValidate = "TextBox1";
            RegularExpressionValidator1.ValidationExpression = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            RegularExpressionValidator1.ErrorMessage = "* write correct e-mail please";


            //Подключение к БД
            string conn_param = "Server=localhost;Port=5432;User Id=postgres;Password=041018;Database=Receipt;";
            conn = new NpgsqlConnection(conn_param);

            try
            {
                conn.Open();
            }

            catch (Exception ex)
            {
                Response.Write("<BR>" + ex.Message);
            }

        }

        
        //Готово
        protected void Button1_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Готово"
            bool auto = false;

            // Строка SQL-запроса для проверки имени и пароля
            string sql = "SELECT firstname, email, password, role FROM users WHERE email = '" +
                    TextBox1.Text + "' AND password = '" + TextBox2.Text + "'";
            // Создание объекта Command с заданием SQL-запроса

            try
            {   // Выполнение команды SQL
                comand = new NpgsqlCommand(sql, conn);

                // Выполнение команды SQL
                reader = comand.ExecuteReader();
                
                if (reader.Read())
                {
                    auto = true;
                    name = reader[0].ToString();
                    role = reader[3].ToString().ToLower();
                    Label4.Text = "User is authenticated";
                }
                else
                {
                    auto = false;
                    Label4.Text = " Incorrect e-mail or password, please log in!";
                }

                reader.Close();
                comand.Dispose();
            }
            catch (Exception ex)
            {
                Label5.Text = Label5.Text + "<br />" + ex.Message;
            }
            
            if (auto)
                // Направляем пользователя на уже разрешенную страницу
                Response.Redirect("Info.aspx");
        }

        //Регистрация
        protected void Button2_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Регистрация"
            Response.Redirect("Registration.aspx");
        }
    }
}