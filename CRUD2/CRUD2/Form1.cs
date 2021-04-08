using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace CRUD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ID;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=i001-Balikoev;Integrated Security=True");
        private void getUsersRecord()
        {

            SqlCommand cmd = new SqlCommand("Select * from Users", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            UserTableView.DataSource = dt;
            UserTableView.Columns[0].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getUsersRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                bool Isvld = true;
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@Name,@surname,@patrynomic,@login)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", UserNameBox.Text);
                    cmd.Parameters.AddWithValue("@surname", UserSurnameBox.Text);
                    cmd.Parameters.AddWithValue("@patrynomic", UserPatronBox.Text);
                    cmd.Parameters.AddWithValue("@login", LoginBox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException exp)
                {
                    if (exp.Number == 2627)
                    {
                        MessageBox.Show("Дубликат Логина!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Isvld = false;
                    }

                }
                finally
                {
                    if (Isvld == true)
                    {
                        MessageBox.Show("Новый Пользователь успешно добавлен", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getUsersRecord();
                        ResetTextFields();
                    }

                }
            }
        }

        private bool IsValid()
        {
            if (UserNameBox.Text == string.Empty)
            {
                MessageBox.Show("Имя должно быть заполнено", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (UserSurnameBox.Text == string.Empty)
            {
                MessageBox.Show("Фамилия должна быть заполнена", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (UserPatronBox.Text == string.Empty)
            {
                MessageBox.Show("Отчество должно быть заполнено", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (LoginBox.Text == string.Empty)
            {
                MessageBox.Show("Логин должен быть заполнен", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetTextFields();
        }

        private void ResetTextFields()
        {
            ID = 0; 
            LoginBox.Clear();
            UserPatronBox.Clear();
            UserSurnameBox.Clear();
            UserNameBox.Clear();
            UserNameBox.Focus();
        }

        private void UserTableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(UserTableView.SelectedRows[0].Cells[0].Value);
            UserNameBox.Text = UserTableView.SelectedRows[0].Cells[1].Value.ToString();
            UserSurnameBox.Text = UserTableView.SelectedRows[0].Cells[2].Value.ToString();
            UserPatronBox.Text = UserTableView.SelectedRows[0].Cells[3].Value.ToString();
            LoginBox.Text = UserTableView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                bool Isvld = true;
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Name = @Name,surname = @surname,patrynomic = @patrynomic,login = @login WHERE ID = @ID", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", UserNameBox.Text);
                    cmd.Parameters.AddWithValue("@surname", UserSurnameBox.Text);
                    cmd.Parameters.AddWithValue("@patrynomic", UserPatronBox.Text);
                    cmd.Parameters.AddWithValue("@login", LoginBox.Text);
                    cmd.Parameters.AddWithValue("@ID", this.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException exp)
                {
                    if (exp.Number == 2627)
                    {
                        MessageBox.Show("Дубликат Логина!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Isvld = false;
                    }
                }
                finally
                {
                    if (Isvld == true)
                    {
                        MessageBox.Show("Редактирование завершено успешно", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getUsersRecord();
                        ResetTextFields();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Users  WHERE ID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Удаление прошло успешно", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUsersRecord();
                ResetTextFields();
               

            } 
        }
    }
}