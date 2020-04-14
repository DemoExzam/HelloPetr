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

namespace Ikzamen
{
    public partial class Aftorizacia : Form
    {
        string connection_string = "Data Source=svc0.ddns.net;Initial Catalog=db35;Persist Security Info=True;User ID=user35;Password=***********";
        SqlConnection connection;
        string roleFromDB;
        string loginFromDB;
        string passwordFromDB;
        public Aftorizacia()
        {
            InitializeComponent();
           // Load();
        }

        private void Aftorizacia_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connection_string);
           // connection.Open();
        }

        private void button2_reg_Click(object sender, EventArgs e)
        {
            Reg open = new Reg();
            open.Show();
        }

        private void button1_exit_Click(object sender, EventArgs e)
        {
            string login = textBox1_log.Text;
            string password = textBox2_pas.Text;
            try
            {
                string query = "select * from [Пользователи] where [Логин] = '" + login + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    loginFromDB = (string)reader[0];
                    passwordFromDB = (string)reader[1];
                    roleFromDB = (string)reader[2];
                }
                reader.Close();
                if (login != "" || password != "")
                {
                    if (login == loginFromDB && password == passwordFromDB)
                    {
                        if (roleFromDB == "Администратор")
                        {
                            MessageBox.Show("Добро пожаловать администратор!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StartAdmin open = new StartAdmin();
                            open.Show();
                        }
                        else if (roleFromDB == "Пользователь")
                        {
                            MessageBox.Show("Добро пожаловать пользователь!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StartPol open = new StartPol();
                           // open.label1.Text = login;
                            open.Show();
                        }
                    }
                    else
                        MessageBox.Show("Не верный логин или пароль! Если вы не зарегистрированы, то это можно сделать нажав на кнопку 'Зарегистрироваться'", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Заполните все поля!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /* string login = textBox_log.Text;
             string password = textBox_pas.Text;

             string a = "select [role] from [User] where [Login] = '" + login + "'";
             SqlCommand role = new SqlCommand(a, connection);
             string user_role = ((string)role.ExecuteScalar());

             string a2 = "select [role] from [User] where [Password] = '" + login + "'";
             SqlCommand pass = new SqlCommand(a2, connection);
             string user_pass = ((string)pass.ExecuteScalar());

             if (login == "Enter your email address" || password == "Enter your password")
             {
                 MessageBox.Show("Пожалуйста заполните все поля.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (password != user_pass)
             {
                 MessageBox.Show("Введен неверный логин или пароль. Попробуйте ещё раз или зарегестрируйтесь.", "ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }
    }
}
