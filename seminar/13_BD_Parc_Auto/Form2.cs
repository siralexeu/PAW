using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_BD_Parc_Auto
{
    public partial class Form2 : Form
    {
        //private dbParcAutoEntities db = new dbParcAutoEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEntityFramework_Click(object sender, EventArgs e)
        {
            using (var context = new dbParcAutoEntities())
            {
                foreach (var row in context.tblCamioane)
                {
                    tbMes.Text += $" \r\n{row.Id} \t {row.Marca} \t {row.Capacitate} \t {row.ToneKm}";
                    if (row.ToneKm <= 100) row.ToneKm = 150;
                }
                context.SaveChanges();
            }
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            /*String strComanda = "SELECT * FROM tblCamioane";
            sqlConnection1 myCon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=dbParcAuto;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");
            myCon.Open();
            SqlCommand myCmd = new SqlCommand(strComanda, myCon);
            SqlDataReader myRdr = null;
            myRdr = myCmd.ExecuteReader();
            tbMes.Clear();
            while (myRdr.Read())
            {
                tbMes.Text += $" \r\n{myRdr["Id"]} \t {myRdr[1]} \t {myRdr[2]} \t {myRdr[3]}";
            }
            myRdr.Close();
            myCon.Close();*/
        }
    }
} 
