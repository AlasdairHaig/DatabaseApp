using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        private string pathToDB;
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            pathToDB = @"C:\Users\b.wood\Desktop\1234.accdb";
            connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathToDB + ";Persist Security Info=False;";
            
        }

        private void contact_ListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contact_ListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void contact_ListBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.contact_ListBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

            GetDataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "database1DataSet.Contact_List". Sie können sie bei Bedarf verschieben oder entfernen.
            this.contact_ListTableAdapter.Fill(this.database1DataSet.Contact_List);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void GetDataSet()
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "Select * from Mitarbeiter";
                command.Prepare();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(reader["Name"].ToString());
                }
            }


        }
    }
}
