using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ergasia2
{
    
    public partial class Form1 : Form
    {
        OleDbConnection connection;
        //string connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Game_user.mdb";
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Game_user.mdb;";
        public Form1(){ 
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2= new Form2();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection =new OleDbConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            StringBuilder sb = new StringBuilder();
            String query = "Select user from player where user ='"+ textBox1.Text +"';";
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText= query;
            OleDbDataReader reader = cmd.ExecuteReader();
            connection.Close();   
        }
    }

}
