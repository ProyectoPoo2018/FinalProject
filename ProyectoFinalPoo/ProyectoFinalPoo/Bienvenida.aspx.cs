using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions; // libreria para metodo regex para validar password

namespace ProyectoFinalPoo
{
    public partial class Bienvenina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {


            String passwd; // contraseña por defecto
            passwd = txtUsuario.Text;
            Director Perfil = new Director();
            RecuperarPassword objPassword = new RecuperarPassword();
            //pasado(txtusuario.Text);

            //usernullPass = txtusuario.Text;
            // Cambia de ventanas al hacer click en el buton
            
            String perfil;
            perfil = txtUsuario.Text;
            // coneccion a la BD
            SqlConnection sqlcon = new SqlConnection(@"Data Source=ADRIANGARCIA;Initial Catalog=BD_Pruebas;Integrated Security=True");

            // Ingresar contraseña normal
            String query = "Select * from tbl_Login Where username = '" + txtUsuario.Text.Trim() + "'and password = '" + txtPassword.Text.Trim() + "'";
            DataTable dtbl = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            sda.Fill(dtbl);
            // ingresar contraseña temporal
            String query1 = "Select * from tbl_Login Where username = '" + txtUsuario.Text.Trim() + "'and PasswordTem = '" + txtPassword.Text.Trim() + "'";
            DataTable dtbl1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, sqlcon);
            sda1.Fill(dtbl1);

            // Ingreso por token
            // Ingresar contraseña normal
            String query2 = "Select * from tbl_Login Where Token = '" + txtUsuario.Text.Trim() + "'and password = '" + txtPassword.Text.Trim() + "'";
            DataTable dtbl2 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(query2, sqlcon);
            sda2.Fill(dtbl2);
            // ingresar contraseña temporal
            String query3 = "Select * from tbl_Login Where Token = '" + txtUsuario.Text.Trim() + "'and PasswordTem = '" + txtPassword.Text.Trim() + "'";
            DataTable dtbl3 = new DataTable();
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, sqlcon);
            sda3.Fill(dtbl3);


            RecuperarPassword aux = new RecuperarPassword();


            if (dtbl.Rows.Count == 1 || dtbl1.Rows.Count == 1 || dtbl2.Rows.Count == 1 || dtbl3.Rows.Count == 1)

            {
                // _verPerfil.lool = txtusuario.Text;    /// usuario auxi para borrar clavet temporal
                //// this.Close();
                //_verPerfil.ShowDialog();
                Response.Redirect("Colaborador.aspx");

            }
            else
            {
                try
                {
                    throw new Exception("Error Al Iniciar.");
                }
                catch (Exception ex)
                {
                    string script = @"<script type='text/javascript'>
                            alert('{0}');
                        </script>";

                    script = string.Format(script, ex.Message);

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecuperarPassword.aspx");


            

        }
        public void Main()
        {
            string[] partNumbers = { "1298-673-4192", "A08Z-931-468A",
                              "_A90-123-129X", "12345-KKA-1230",
                              "0919-2893-1256" };
            Regex rgx = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]$");
            foreach (string partNumber in partNumbers)
                Console.WriteLine("{0} {1} a valid part number.",
                                  partNumber,
                                  rgx.IsMatch(partNumber) ? "is" : "is not");
        }

        protected void lnkCrearUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");

            // Agregado al Repositorio     

            // prueba de comentario

        }
    }
}