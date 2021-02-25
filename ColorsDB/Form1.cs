using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsDB
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsDB.Properties.Settings.ColorsConnectionString"].ConnectionString;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateColorTable();
        }

        private void PopulateColorTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ColorType", connection))
            {
                DataTable colorTable = new DataTable();
                adapter.Fill(colorTable);

                listColors.DisplayMember = "ColorTypeName";
                listColors.ValueMember = "Id";
                listColors.DataSource = colorTable;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColorNames();
        }


        private void PopulateColorNames()
        {
            string query = "SELECT Color.Name FROM ColorType INNER JOIN Color ON Color.TypeId = ColorType.Id WHERE ColorType.Id = @TypeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@TypeId", listColors.SelectedValue);
                DataTable colorNameTable = new DataTable();
                adapter.Fill(colorNameTable);

                listColorNames.DisplayMember = "Name";
                listColorNames.ValueMember = "Id";
                listColorNames.DataSource = colorNameTable;

            }
        }
    }
}
