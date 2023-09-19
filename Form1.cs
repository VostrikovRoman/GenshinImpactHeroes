using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Genshin_Impact_Heroes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "genshin_Impact_HeroesDataSet.Heroes". При необходимости она может быть перемещена или удалена.
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);

        }
        private void background_white_Paint(object sender, PaintEventArgs e)
        {

        }
        //Начальная кнопка//
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            button1.Visible = false;
            menu_panel.Visible = true;
            back_button.Visible = true;
            picture_background.Visible = false;
            menu_button.Visible = false;
        }
        //Кнопка возврата на начальный экран//
        private void back_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            button1.Visible = true;
            menu_panel.Visible = false;
            back_button.Visible = false;
            picture_background.Visible = false;
            menu_button.Visible = false;
            database.Visible = false;
            add_panel.Visible = false;
            clean_panel.Visible = false;
            plan_panel.Visible = false;
        }
        //Кнопка добавления персонажа//
        private void add_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            picture_background.Visible = true;
            menu_button.Visible = true;
            add_panel.Visible = true;
            back_button.Visible = false;
            id_box.Value = (int)id_box_hidden.Value + 1;
        }
        //Кнопка удаления персонажа//
        private void delete_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            picture_background.Visible = true;
            menu_button.Visible = true;
            back_button.Visible = false;
            delete_panel.Visible = true;
        }
        //Кнопка изменения персонажа//
        private void edit_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            picture_background.Visible = true;
            menu_button.Visible = true;
            back_button.Visible = false;
            edit_panel.Visible = true;
        }
        //Кнопка для показа всех персонажей//
        private void show_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            picture_background.Visible = true;
            menu_button.Visible = true;
            back_button.Visible = false;
            database.Visible = true;
        }
        //Кнопка для чистки таблицы//
        private void clean_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            picture_background.Visible = true;
            menu_button.Visible = true;
            back_button.Visible = false;
            //Здесь считается, сколько будет удалено записей//
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand clean_count_command = new SqlCommand("SELECT COUNT(*) AS count FROM Heroes", connection);
                int count = (int)clean_count_command.ExecuteScalar();

                cleanLabel.Text = "Всего персонажей было удалено: " + count;
                clean_count_command.ExecuteNonQuery();
            }
            //Непосредственное удаление//
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand clean_command = new SqlCommand("DELETE FROM Heroes", connection);
                clean_command.ExecuteNonQuery();
            }
            
            clean_panel.Visible = true;
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
        //Кнопка-посев//
        private void seed_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            try
            {
                int id=0;
                object name="";
                object nickname ="";
                object element ="";
                object weapon_type ="";
                object biography ="";
                DateTime date= new DateTime(1900,01,01);
                int count_while = 0;
                
                while (count_while<5)
                {
                    if (count_while==0)
                    {
                        id = (int)id_box_hidden.Value + 1;
                        name = "Kandakia";
                        nickname = "Hydro Spearwoman from Sumeru";
                        element = "Hydro";
                        weapon_type = "Spear";
                        biography = "Yes, this defender has her own understanding of joy...";
                        date = new DateTime(1998, 02, 14);

                    }
                    if (count_while == 1)
                    {
                        id = (int)id_box_hidden.Value + 2;
                        name = "Sinobu";
                        nickname = "Electro character";
                        element = "Electro";
                        weapon_type = "Sword";
                        biography = "She is intelligent, well versed in both literature and martial arts, a truly invaluable assistant...";
                        date = new DateTime(2001, 04, 08);
                    }
                    if (count_while == 2)
                    {
                        id = (int)id_box_hidden.Value + 3;
                        name = "Itto";
                        nickname = "Leader of the Arataki gang";
                        element = "Geo";
                        weapon_type = "Two-handed sword";
                        biography = "";
                        date = new DateTime(1997, 05, 30);
                    }
                    if (count_while == 3)
                    {
                        id = (int)id_box_hidden.Value + 4;
                        name = "Hu Tao";
                        nickname = "Controversial and sometimes arrogant funeral home owner";
                        element = "Pyro";
                        weapon_type = "Spear";
                        biography = "";
                        date = new DateTime(1999, 12, 14);
                    }
                    if (count_while == 4)
                    {
                        id = (int)id_box_hidden.Value + 5;
                        name = "Dori";
                        nickname = "Character from Sumeru electro poems";
                        element = "Electro";
                        weapon_type = "Two-handed sword";
                        biography = "Even the rarest materials for experiments can be purchased from Dory.";
                        date = new DateTime(2000, 04, 19);
                    }
                    using (SqlConnection add = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                    {
                        add.Open();
                        SqlCommand seed_command = new SqlCommand("INSERT INTO Heroes (id,name,nickname,element,weapon_type,birthday,biography) VALUES (@id,@name,@nickname,@element,@weapon_type,@date,@biography)", add);

                        SqlParameter n1 = new SqlParameter("@name", name);
                        seed_command.Parameters.Add(n1);
                        SqlParameter n2 = new SqlParameter("@nickname", nickname);
                        seed_command.Parameters.Add(n2);
                        SqlParameter n3 = new SqlParameter("@element", element);
                        seed_command.Parameters.Add(n3);
                        SqlParameter n4 = new SqlParameter("@weapon_type", weapon_type);
                        seed_command.Parameters.Add(n4);
                        SqlParameter n5 = new SqlParameter("@date", date);
                        seed_command.Parameters.Add(n5);
                        SqlParameter n6 = new SqlParameter("@biography", biography);
                        seed_command.Parameters.Add(n6);
                        SqlParameter n7 = new SqlParameter("@id", id);
                        seed_command.Parameters.Add(n7);
                        seed_command.ExecuteNonQuery();
                    }
                    count_while++;
                }
                MessageBox.Show("Персонажи были добавлены.");
                id_box.Value = 6;

            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
        //Кнопка выхода в меню//
        private void menu_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            button1.Visible = false;
            menu_panel.Visible = true;
            back_button.Visible = true;
            picture_background.Visible = false;
            menu_button.Visible = false;
            database.Visible = false;
            add_panel.Visible = false;
            clean_panel.Visible = false;
            edit_panel.Visible = false;
            edit_panel2.Visible = false;
            delete_panel.Visible = false;
            plan_panel.Visible = false;
            edit_name.Text = "";
            edit_element.Text = "";
        }

        private void heroesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.heroesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.genshin_Impact_HeroesDataSet);

        }

        //Кнопка подтверждения добавления персонажа//

        private void add_send_button_MouseClick(object sender, MouseEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            button1.Visible = false;
            menu_panel.Visible = true;
            back_button.Visible = false;
            picture_background.Visible = false;
            menu_button.Visible = true;
            database.Visible = false;
            add_panel.Visible = false;
            int id = (int)id_box.Value;
            string name = name_box.Text;
            string nickname = nickname_box.Text;
            string element = element_box.Text;
            string weapon_type = weapon_type_box.Text;
            string biography = biography_box.Text;
            DateTime date = date_box.Value;
            try {
                using (SqlConnection add = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    add.Open();
                    SqlCommand add_command = new SqlCommand("INSERT INTO Heroes (id,name,nickname,element,weapon_type,birthday,biography) VALUES (@id,@name,@nickname,@element,@weapon_type,@date,@biography)", add);
                    

                    SqlParameter p1 = new SqlParameter("@name", name);
                    add_command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@nickname", nickname);
                    add_command.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@element", element);
                    add_command.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@weapon_type", weapon_type);
                    add_command.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@date", date);
                    add_command.Parameters.Add(p5);
                    SqlParameter p6 = new SqlParameter("@biography", biography);
                    add_command.Parameters.Add(p6);
                    SqlParameter p7 = new SqlParameter("@id", id);
                    add_command.Parameters.Add(p7);
                    add_command.ExecuteNonQuery();
                }
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка! Возможно персонаж с этим номером уже существует.");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            id_box.Value = (int)id + 1;
            name_box.Text = "";
            nickname_box.Text = "";
            element_box.Text = "";
            weapon_type_box.Text = "";
            biography_box.Text = "";
            id_box_hidden.Value = (int)id;


            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
        //Кнопка для выхода из приложения//
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Кнопка для подтверждения удаления персонажа//
        private void delete_yes_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            string name_delete = delete_name.Text;
            string element_delete = delete_element.Text;
            button1.Visible = false;
            menu_panel.Visible = true;
            back_button.Visible = false;
            picture_background.Visible = false;
            menu_button.Visible = true;
            delete_panel.Visible = false;
            try
            {
                using (SqlConnection delete = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    delete.Open();
                    SqlCommand delete_command = new SqlCommand("DELETE FROM Heroes WHERE name = @name_delete AND element = @element_delete", delete);

                    SqlParameter p1 = new SqlParameter("@name_delete", name_delete);
                    delete_command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@element_delete", element_delete);
                    delete_command.Parameters.Add(p2);
                    delete_command.ExecuteNonQuery();
                }
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка! Возможно этого персонажа не существует.");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            delete_name.Text = "";
            delete_element.Text = "";
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
        //Кнопка для вывода окна новых данных персонажа//
        private void edit_new_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            string name_edit = edit_name.Text;
            string element_edit = edit_element.Text;
            try
            {
                
                using (SqlConnection true_or_not = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    true_or_not.Open();
                    SqlCommand true_command = new SqlCommand("SELECT COUNT(id) AS count FROM Heroes WHERE name = @name_edit AND element = @element_edit", true_or_not);
                    SqlParameter p1 = new SqlParameter("@name_edit", name_edit);
                    true_command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@element_edit", element_edit);
                    true_command.Parameters.Add(p2);
                    object count = (object)true_command.ExecuteScalar();
                    true_command.ExecuteNonQuery();
                    if ((int)count == 0)
                    {
                        MessageBox.Show("Ошибка! Такого персонажа нет.");
                    }
                    else
                    {
                        edit_panel.Visible = false;
                        edit_panel2.Visible = true;
                        using (SqlConnection edit = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                        {
                            edit.Open();
                            
                            //NAME//
                            SqlCommand edit_name_command = new SqlCommand("SELECT name FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter n1 = new SqlParameter("@name_edit", name_edit);
                            edit_name_command.Parameters.Add(n1);
                            SqlParameter n2 = new SqlParameter("@element_edit", element_edit);
                            edit_name_command.Parameters.Add(n2);
                            string old_name = (string)edit_name_command.ExecuteScalar();
                            edit_name_command.ExecuteNonQuery();
                            //NICKNAME//
                            SqlCommand edit_nickname_command = new SqlCommand("SELECT nickname FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter nn1 = new SqlParameter("@name_edit", name_edit);
                            edit_nickname_command.Parameters.Add(nn1);
                            SqlParameter nn2 = new SqlParameter("@element_edit", element_edit);
                            edit_nickname_command.Parameters.Add(nn2);
                            string old_nickname = (string)edit_nickname_command.ExecuteScalar();
                            edit_nickname_command.ExecuteNonQuery();
                            //ELEMENT//
                            SqlCommand edit_element_command = new SqlCommand("SELECT element FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter e1 = new SqlParameter("@name_edit", name_edit);
                            edit_element_command.Parameters.Add(e1);
                            SqlParameter e2 = new SqlParameter("@element_edit", element_edit);
                            edit_element_command.Parameters.Add(e2);
                            string old_element = (string)edit_element_command.ExecuteScalar();
                            edit_element_command.ExecuteNonQuery();
                            //WEAPON_TYPE//
                            SqlCommand edit_weapon_type_command = new SqlCommand("SELECT weapon_type FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter w1 = new SqlParameter("@name_edit", name_edit);
                            edit_weapon_type_command.Parameters.Add(w1);
                            SqlParameter w2 = new SqlParameter("@element_edit", element_edit);
                            edit_weapon_type_command.Parameters.Add(w2);
                            string old_weapon_type = (string)edit_weapon_type_command.ExecuteScalar();
                            edit_weapon_type_command.ExecuteNonQuery();
                            //BIOGRAPHY//
                            SqlCommand edit_biography_command = new SqlCommand("SELECT biography FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter b1 = new SqlParameter("@name_edit", name_edit);
                            edit_biography_command.Parameters.Add(b1);
                            SqlParameter b2 = new SqlParameter("@element_edit", element_edit);
                            edit_biography_command.Parameters.Add(b2);
                            object old_biography = (object)edit_biography_command.ExecuteScalar();
                            edit_biography_command.ExecuteNonQuery();
                            //BIRTHDAY//
                            SqlCommand edit_birthday_command = new SqlCommand("SELECT birthday FROM Heroes WHERE name = @name_edit AND element = @element_edit", edit);
                            SqlParameter bd1 = new SqlParameter("@name_edit", name_edit);
                            edit_birthday_command.Parameters.Add(bd1);
                            SqlParameter bd2 = new SqlParameter("@element_edit", element_edit);
                            edit_birthday_command.Parameters.Add(bd2);
                            DateTime old_birthday = (DateTime)edit_birthday_command.ExecuteScalar();
                            edit_birthday_command.ExecuteNonQuery();
                            edit_yes_name.Text = (string)old_name;
                            edit_yes_nickname.Text = (string)old_nickname;
                            edit_yes_element.Text = (string)old_element;
                            edit_yes_weapon_type.Text = (string)old_weapon_type;
                            edit_yes_biography.Text = (string)old_biography;
                            edit_yes_date.Value = (DateTime)old_birthday;
                        }
                        hidden_name.Text = name_edit;
                        hidden_element.Text = element_edit;
                        edit_name.Text = "";
                        edit_element.Text = "";
                        using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                        {
                            connection.Open();
                            SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                            id_box_hidden.Value = (int)check.ExecuteScalar();
                            check.ExecuteNonQuery();
                        }
                    };
                }
                
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка! Возможно этого персонажа не существует.");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
        //Кнопка для подтверждения изменений персонажа//
        private void edit_yes_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            button1.Visible = false;
            menu_panel.Visible = true;
            back_button.Visible = false;
            picture_background.Visible = false;
            menu_button.Visible = true;
            edit_panel2.Visible = false;
            string name_edit = hidden_name.Text;
            string element_edit = hidden_element.Text;
            string new_name = edit_yes_name.Text;
            string new_nickname = edit_yes_nickname.Text;
            string new_element = edit_yes_element.Text;
            string new_weapon_type = edit_yes_weapon_type.Text;
            object new_biography = edit_yes_biography.Text;
            DateTime new_birthday = (DateTime)edit_yes_date.Value;
            try
            {
                using (SqlConnection edit = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    edit.Open();
                    SqlCommand edit_send_command = new SqlCommand("UPDATE Heroes SET name=@name, nickname=@nickname, element=@element, weapon_type=@weapon_type, biography=@biography, birthday=@birthday WHERE name = @name_edit AND element = @element_edit", edit);
                    SqlParameter p1 = new SqlParameter("@name", new_name);
                    edit_send_command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@element", new_element);
                    edit_send_command.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("@nickname", new_nickname);
                    edit_send_command.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("@weapon_type", new_weapon_type);
                    edit_send_command.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("@biography", new_biography);
                    edit_send_command.Parameters.Add(p5);
                    SqlParameter p6 = new SqlParameter("@birthday", new_birthday);
                    edit_send_command.Parameters.Add(p6);
                    SqlParameter p7 = new SqlParameter("@name_edit", name_edit);
                    edit_send_command.Parameters.Add(p7);
                    SqlParameter p8 = new SqlParameter("@element_edit", element_edit);
                    edit_send_command.Parameters.Add(p8);
                    edit_send_command.ExecuteNonQuery();
                }
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            delete_name.Text = "";
            delete_element.Text = "";
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }

        private void plan_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            menu_panel.Visible = false;
            menu_button.Visible = true;
            back_button.Visible = false;
            plan_panel.Visible = true;
        }

        private void plan_add_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            int id = (int)id_box_hidden.Value + 1;
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    connection.Open();
                    SqlCommand add_plan = new SqlCommand("INSERT INTO Heroes VALUES (@id, '','','','','','')", connection);
                    SqlParameter p1 = new SqlParameter("@id", id);
                    add_plan.Parameters.Add(p1);
                    add_plan.ExecuteNonQuery();
                }
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }

        private void plan_clean_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    connection.Open();
                    SqlCommand add_plan = new SqlCommand("DELETE FROM Heroes", connection);
                    
                    add_plan.ExecuteNonQuery();
                }
                MessageBox.Show("Всего персонажей было удалено: " + id_box_hidden.Value);
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }

        private void plan_seed_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            try
            {
                int id=0;
                object name = "";
                object nickname = "";
                object element = "";
                object weapon_type = "";
                object biography = "";
                DateTime date = new DateTime(1900, 01, 01);
                int count_while = 0;

                while (count_while < 5)
                {
                    if (count_while == 0)
                    {
                        id = (int)id_box_hidden.Value + 1;
                        name = "Kandakia";
                        nickname = "Hydro Spearwoman from Sumeru";
                        element = "Hydro";
                        weapon_type = "Spear";
                        biography = "Yes, this defender has her own understanding of joy...";
                        date = new DateTime(1998, 02, 14);

                    }
                    if (count_while == 1)
                    {
                        id = (int)id_box_hidden.Value + 2;
                        name = "Sinobu";
                        nickname = "Electro character";
                        element = "Electro";
                        weapon_type = "Sword";
                        biography = "She is intelligent, well versed in both literature and martial arts, a truly invaluable assistant...";
                        date = new DateTime(2001, 04, 08);
                    }
                    if (count_while == 2)
                    {
                        id = (int)id_box_hidden.Value + 3;
                        name = "Itto";
                        nickname = "Leader of the Arataki gang";
                        element = "Geo";
                        weapon_type = "Two-handed sword";
                        biography = "";
                        date = new DateTime(1997, 05, 30);
                    }
                    if (count_while == 3)
                    {
                        id = (int)id_box_hidden.Value + 4;
                        name = "Hu Tao";
                        nickname = "Controversial and sometimes arrogant funeral home owner";
                        element = "Pyro";
                        weapon_type = "Spear";
                        biography = "";
                        date = new DateTime(1999, 12, 14);
                    }
                    if (count_while == 4)
                    {
                        id = (int)id_box_hidden.Value + 5;
                        name = "Dori";
                        nickname = "Character from Sumeru electro poems";
                        element = "Electro";
                        weapon_type = "Two-handed sword";
                        biography = "Even the rarest materials for experiments can be purchased from Dory.";
                        date = new DateTime(2000, 04, 19);
                    }
                    using (SqlConnection add = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                    {
                        add.Open();
                        SqlCommand seed_command = new SqlCommand("INSERT INTO Heroes (id,name,nickname,element,weapon_type,birthday,biography) VALUES (@id,@name,@nickname,@element,@weapon_type,@date,@biography)", add);

                        SqlParameter n1 = new SqlParameter("@name", name);
                        seed_command.Parameters.Add(n1);
                        SqlParameter n2 = new SqlParameter("@nickname", nickname);
                        seed_command.Parameters.Add(n2);
                        SqlParameter n3 = new SqlParameter("@element", element);
                        seed_command.Parameters.Add(n3);
                        SqlParameter n4 = new SqlParameter("@weapon_type", weapon_type);
                        seed_command.Parameters.Add(n4);
                        SqlParameter n5 = new SqlParameter("@date", date);
                        seed_command.Parameters.Add(n5);
                        SqlParameter n6 = new SqlParameter("@biography", biography);
                        seed_command.Parameters.Add(n6);
                        SqlParameter n7 = new SqlParameter("@id", id);
                        seed_command.Parameters.Add(n7);
                        seed_command.ExecuteNonQuery();
                    }
                    count_while++;
                }
                id_box.Value = 6;

            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }

        private void plan_delete_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
            {
                connection.Open();
                SqlCommand check = new SqlCommand("SELECT COUNT(id) AS max FROM Heroes", connection);
                id_box_hidden.Value = (int)check.ExecuteScalar();
                check.ExecuteNonQuery();
            }
            string name_delete =plan_name_box.Text;
            string element_delete = plan_element_box.Text;
            
            try
            {
                using (SqlConnection delete = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Genshin_Impact_Heroes.mdf;Integrated Security=True; Connect Timeout=30"))
                {
                    delete.Open();
                    SqlCommand delete_command = new SqlCommand("DELETE FROM Heroes WHERE name = @name_delete AND element = @element_delete", delete);

                    SqlParameter p1 = new SqlParameter("@name_delete", name_delete);
                    delete_command.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("@element_delete", element_delete);
                    delete_command.Parameters.Add(p2);
                    delete_command.ExecuteNonQuery();
                }
            }
            catch (FormatException a)
            {
                MessageBox.Show("Ошибка!");
            }
            catch (SqlException a)
            {
                MessageBox.Show("Ошибка! Возможно этого персонажа не существует.");
            }
            catch (OverflowException a)
            {
                MessageBox.Show("Ошибка!");
            }
            
            this.heroesTableAdapter.Fill(this.genshin_Impact_HeroesDataSet.Heroes);
        }
    }
}
