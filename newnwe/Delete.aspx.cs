using System;
using System.Web;
using System.Web.UI;
using Npgsql;

namespace newnwe
{

    public partial class Delete : System.Web.UI.Page
    {
        private NpgsqlCommand comand;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Delete a receipt ";
            Label2.Text = "Name";
            Label3.Text = "Number";
            TextBox2.Focus();
            TextBox3.Focus();
            Button1.Text = "Ready";
            Button1.Width = 125;
            RequiredFieldValidator2.ControlToValidate = "TextBox2";
            RequiredFieldValidator2.ErrorMessage = "* fill Name";
            RequiredFieldValidator3.ControlToValidate = "TextBox3";
            RequiredFieldValidator3.ErrorMessage = "* fill Number ";

        }
        protected void Button1_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Готово"
            bool auto = false;
            string sql = "Delete from receipt where name ='" + TextBox2.Text + "' and number = '" + TextBox3.Text + "'";
            try
            {   // Выполнение команды SQL
                comand = new NpgsqlCommand(sql, WebForm3.conn);

                // Выполнение команды SQL
                comand.ExecuteNonQuery();

                comand.Dispose();
                Label4.Text = "Successfully deleted";
                auto = true;

            }
            catch (Exception ex)
            {
                Label4.Text = Label4.Text + "<br />" + ex.Message;
            }

            if (auto)
            {// Направляем пользователя на уже разрешенную страницу
                Response.Redirect("Info.aspx");
            }
        }
    }
}
