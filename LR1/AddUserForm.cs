using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LR1.DBContext;

namespace LR1
{
    public partial class AddUserForm : Form
    {
        Model1 model = new Model1();

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            bindingSourceRole.DataSource = model.Roles.ToList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
RegexOptions.IgnoreCase);
            if (!reg.IsMatch(tbEMail.Text))
            {
                MessageBox.Show("Почта не соотвествует требованиям!");
                return;
            }
            if (!tbPass.Text.Equals(tbPassRep.Text))
            {
                MessageBox.Show("Пароли не равны!");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbLog.Text) ||
            String.IsNullOrWhiteSpace(tbPass.Text) ||
            String.IsNullOrWhiteSpace(tbName.Text) ||
            String.IsNullOrWhiteSpace(tbSurname.Text) ||
            !tbPhone.MaskCompleted)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            //Заполнение данных о новом пользователе
            Users users = new Users();
            users.ID = 0;
            users.Login = tbLog.Text;
            users.Password = tbPass.Text;
            users.Email = tbEMail.Text;
            users.Phone = tbPhone.Text;
            users.First_Name = tbName.Text;
            users.Second_Name = tbSurname.Text;
            users.RoleID = (int)tbRole.SelectedValue;
            users.Gender = rbMale.Checked ? "Мужской" : "Женский";
            try
            {
                model.Users.Add(users);
                model.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Данные добавленны!");
            Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
