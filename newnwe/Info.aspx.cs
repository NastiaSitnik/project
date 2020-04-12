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
    public partial class Info : System.Web.UI.Page
    {
        string url;
        string sql;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            //Определение, с какой Web - страницы вы пришли на данную
            // страницу, т.е.определение локального адреса(пути)
            try
            {
                //url = Request.UrlReferrer.LocalPath.ToLower();
                //Console.WriteLine(url);

                // Более эффективно определять абсолюный виртуальный адрес:
                url = Request.UrlReferrer.AbsoluteUri;
            
                if (url == @"http://127.0.0.1:8080/" || url ==@"http://127.0.0.1:8080/Insert.aspx" || url == @"http://127.0.0.1:8080/Delete.aspx" || url == @"http://127.0.0.1:8080/Info.aspx" || url == @"http://127.0.0.1:8080/Edit.aspx" )
                    {

                    Label2.Text = "you are registered user so you have acsees. You came on this page from: " + url + "!";

                    try
                    {


                        


                        if (WebForm3.role == "admin")
                        {
                            sql = "Select * From receipt";
                            Button1.Text = "Insert ";
                            Button1.Width = 125;
                            Button2.Text = "Delete ";
                            Button2.Width = 125;
                            Label3.Text = "Sort: ";
                            if (!IsPostBack)
                            {
                                ListItem sortListName = new ListItem("By name", "name");
                                ListItem sortListCompany = new ListItem("By company", "company");
                                //ListItem sortListNumber = new ListItem("By number", "number");
                                ListItem sortListArrears = new ListItem("By arrears", "arrears");
                                ListItem sortListSuma = new ListItem("By suma", "suma");
                                DropdowmList1.Items.Add(sortListName);
                                DropdowmList1.Items.Add(sortListCompany);
                                //DropdowmList1.Items.Add(sortListNumber);
                                DropdowmList1.Items.Add(sortListArrears);
                                DropdowmList1.Items.Add(sortListSuma);
                               
                                Button3.Text = " sort ";

                                Button4.Text = "Edit";

                                
                            }
 
                        }

                        else
                        { sql = "Select * From receipt where name = '" + WebForm3.name + "'"; }

                        NpgsqlDataAdapter dat = new NpgsqlDataAdapter(sql, WebForm3.conn);
                        DataSet ds = new DataSet();
                        dat.Fill(ds);
                        GridView1.DataSource = ds.Tables[0];
                        

                        GridView1.DataBind();
                        
                        dat.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);

                    }



                    return;
                }
            }
            catch (Exception ex)
            {
                Label2.Text = "you are not registered user " +
                   "because you came on this page typing URL in address line " +
                   ".<br />" + ex.Message;
                return;
            }

            Label2.Text = "you are not registered user " +
               ", because you came from page" + url;


        }
        protected void Button1_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Add"
            Response.Redirect("Insert.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Add"
            Response.Redirect("Delete.aspx");
        }
        protected void Button3_Click (object sender, EventArgs e)
        {
            if (DropdowmList1.SelectedItem.Value == "name")
            {
                sql = " Select * from receipt order by name"; 
            }
            else if (DropdowmList1.SelectedItem.Value == "company")
            {
                sql = " Select * from receipt order by company";
            }
            //else if (DropdowmList1.SelectedItem.Value == "number")
            //{
            //    sql = " Select * from receipt order by number";
            //}
            else if (DropdowmList1.SelectedItem.Value == "arrears")
            {
                sql = " Select * from receipt order by arrears";
            }
            else if (DropdowmList1.SelectedItem.Value == "suma")
            {
                sql = " Select * from receipt order by suma";
            }


            NpgsqlDataAdapter dat = new NpgsqlDataAdapter(sql, WebForm3.conn);
            DataSet ds = new DataSet();
            dat.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            dat.Dispose();
        }
        protected void Button4_Click(object sender, EventArgs e)
        { // Щелчок на кнопке "Add"
            Response.Redirect("Edit.aspx");
        }
    }
}