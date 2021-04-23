using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace address_book
{
    public partial class Form1 : Form
    {
        List<User> users;
        User user;
        Personal_info personal_Info;
        Academic_info academic_Info;
        Professional_info professional_Info;
        StreamWriter sw;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
            btn_submit.ForeColor = ColorTranslator.FromHtml("#fd6e00");
            users = new List<User>(); 
        }
        private bool validate_personal_info()
        {
            if(string.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) || string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_city.Text) || string.IsNullOrWhiteSpace(txt_address.Text) || string.IsNullOrWhiteSpace(txt_country.Text))
            {
                return false;
            }
            return true;
        }
        private bool validate_academic_info()
        {
            if (string.IsNullOrWhiteSpace(txt_cgpa.Text) || string.IsNullOrWhiteSpace(txt_uni.Text) || string.IsNullOrWhiteSpace(txt_degree.Text) ||
                string.IsNullOrWhiteSpace(txt_program.Text))
            {
                return false;
            }
            return true;
        }
        private bool validate_professional_info()
        {
            if (string.IsNullOrWhiteSpace(txt_sal.Text) || string.IsNullOrWhiteSpace(txt_com.Text) || string.IsNullOrWhiteSpace(txt_work_exp.Text) ||
                string.IsNullOrWhiteSpace(txt_desig.Text))
            {
                return false;
            }
            return true;
        }
        private void insrt_data()
        {
            personal_Info = new Personal_info(txt_fname.Text, txt_lname.Text, txt_email.Text, txt_city.Text, txt_address.Text, txt_country.Text);
            academic_Info = new Academic_info(Convert.ToDecimal(txt_cgpa.Text), txt_uni.Text, txt_degree.Text, txt_program.Text);
            professional_Info = new Professional_info(Int32.Parse(txt_sal.Text), txt_com.Text, txt_work_exp.Text, txt_desig.Text);
            user = new User(personal_Info, academic_Info, professional_Info);
            users.Add(user);
        }
        private void write_data()
        {
            sw = new StreamWriter("address.txt");
            int i = 1;
            foreach(User us in users)
            {
                sw.WriteLine(string.Format("---- User {0} ----\n",i));
                sw.WriteLine(us.Print_user());
                i++;
            }
            sw.Close();
        }
        private string read_data()
        {
            sr = new StreamReader("address.txt");
            string rec = sr.ReadToEnd();
            sr.Close();
            return rec;
        }
        private void ClearAll()
        {
            foreach(TabPage i in tabControl1.TabPages)
            {
                foreach (Control control in i.Controls)
                {
                    if (!(control is Label || control is Button || control is RichTextBox))
                    {
                        control.ResetText();
                    }

                }
            }
            
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if(validate_personal_info() && validate_academic_info() && validate_professional_info())
            {
                insrt_data();
                write_data();
                ClearAll();
                rchtxt_out.Text = read_data();
                MessageBox.Show("Data scucessfully Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl1.SelectedTab = tabPage4;
            }
            else
            {
                MessageBox.Show("Please Fill All the Fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
