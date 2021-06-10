using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //connection string
        private string connectionString = @"Data Source=DESKTOP-9FSC4QP\SQLEXPRESS;Initial Catalog=Golf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
        SqlConnection Con = new SqlConnection();
        DataTable GolfTable = new DataTable(); 
        public Form1()
        {
            InitializeComponent();
            Con.ConnectionString = connectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnload_db_Click(object sender, EventArgs e)
        {
            loaddb();
        }

        private void loaddb()
        {
            //load datatable columns 
            datatablecolumns();
            //Wrap your code in a Using statement to dispose of it later
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Ask a question
                string QueryString = @"SELECT * FROM Golf order by ID";
                //Open your connection
                connection.Open();
                SqlCommand Command = new SqlCommand(QueryString, connection);
                //Start your DB reader
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add in each row to the datatable
                    GolfTable.Rows.Add(
                    reader["ID"],
                    reader["Title"],
                    reader["Firstname"],
                    reader["Surname"],
                    reader["Gender"],
                    reader["DOB"],
                    reader["Street"],
                    reader["Suburb"],
                    reader["City"],
                    reader["Available week days"],
                    reader["Handicap"]);
                }
                //Close your DB reader
                reader.Close();
                //Close your connection
                connection.Close();
                //add the datatable to the Data Grid View
                dgvGolf.DataSource = GolfTable;
            }
        }

        public void datatablecolumns()
        {
            //cle
            
            //ar the old data
            GolfTable.Clear();
            //add in the column titles to the datatable
            try
            {
                GolfTable.Columns.Add("ID");
                GolfTable.Columns.Add("Title");
                GolfTable.Columns.Add("Firstname");
                GolfTable.Columns.Add("Surname");
                GolfTable.Columns.Add("Gender");
                GolfTable.Columns.Add("DOB");
                GolfTable.Columns.Add("Street");
                GolfTable.Columns.Add("Suburb");
                GolfTable.Columns.Add("City");
                GolfTable.Columns.Add("Available week days");
                GolfTable.Columns.Add("Handicap");
            }
            catch
            {
                //MessageBox.Show("Datatable not loading");
            }
        }

        private void dgvGolf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = dgvGolf.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " +
                e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                txtid.Text = dgvGolf.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttitle.Text = dgvGolf.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtsurname.Text = dgvGolf.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtfirstnamee.Text = dgvGolf.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtgender.Text = dgvGolf.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtdob.Text = dgvGolf.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtstreet.Text = dgvGolf.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtsuburb.Text = dgvGolf.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtcity.Text = dgvGolf.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtavailable.Text = dgvGolf.Rows[e.RowIndex].Cells[9].Value.ToString();
                txthandicap.Text = dgvGolf.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch
            {
            }

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database

            string NewEntry = "INSERT INTO Golf (Title, Firstname, Surname, Gender, DOB, Street, Suburb, City, [Available week days], Handicap) VALUES(@title, @firstname, @Surname, @Gender, @DOB, @Street, @Suburb, @City, @Available,@Handicap)";
             using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@Title", txttitle.Text);
                newdata.Parameters.AddWithValue("@Firstname", txtfirstnamee.Text);
                newdata.Parameters.AddWithValue("@Surname", txtsurname.Text);
                newdata.Parameters.AddWithValue("@Street", txtstreet.Text);
                newdata.Parameters.AddWithValue("@Suburb", txtsuburb.Text);
                newdata.Parameters.AddWithValue("@City", txtcity.Text);
                newdata.Parameters.AddWithValue("@Gender", txtgender.Text);
                newdata.Parameters.Add("@DOB", SqlDbType.DateTime).Value = txtdob.Text;
                newdata.Parameters.AddWithValue("@Handicap", txthandicap.Text);
                newdata.Parameters.AddWithValue("@Available", txtavailable.Text);
                Con.Open(); //open a connection to the database
                            //its a NONQuery as it doesn't return any data its only going up to the server
                newdata.ExecuteNonQuery(); //Run the Query
                Con.Close(); //Close a connection to the database
                             //a happy message box

                MessageBox.Show("Data has been Inserted !! ");
            }
            //Run the LoadDatabase method we made earler to see the new data.
            loaddb();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //this updates existing data in the database where the ID of the data equals the ID in  the text box

            string updatestatement = "UPDATE Golf set Title=@Title, Firstname=@Firstname, Surname=@Surname, Gender = @Gender, DOB = @DOB, Street = @Street, Suburb = @Suburb, City = @City, [Available week days]= @Available, Handicap = @Handicap where ID = @ID";
            SqlCommand update = new SqlCommand(updatestatement, Con);
            //create the parameters and pass the data from the textboxes
            update.Parameters.AddWithValue("@ID", txtid.Text);
            update.Parameters.AddWithValue("@Title", txttitle.Text);
            update.Parameters.AddWithValue("@Firstname", txtfirstnamee.Text);
            update.Parameters.AddWithValue("@Surname", txtsurname.Text);
            update.Parameters.AddWithValue("@Street", txtstreet.Text);
            update.Parameters.AddWithValue("@Suburb", txtsuburb.Text);
            update.Parameters.AddWithValue("@City", txtcity.Text);
            update.Parameters.AddWithValue("@Gender", txtgender.Text);
            update.Parameters.Add("@DOB", SqlDbType.DateTime).Value = txtdob.Text;
            update.Parameters.AddWithValue("@Handicap", txthandicap.Text);
            update.Parameters.AddWithValue("@Available", txtavailable.Text);
            Con.Open();
            //its NONQuery as data is only going up
            update.ExecuteNonQuery();
            Con.Close();
            loaddb();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string DeleteCommand = "Delete Golf where ID = @ID";
            SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
            DeleteData.Parameters.AddWithValue("@ID", txtid.Text);
            Con.Open();
            DeleteData.ExecuteNonQuery();
            Con.Close();
            loaddb();
        }
    }
        
    
}
