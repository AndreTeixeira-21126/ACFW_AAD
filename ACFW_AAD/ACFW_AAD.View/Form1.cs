using ACFW_AAD.BELayer;
using ACFW_AAD.DALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACFW_AAD.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Donator.NextID = DataAcess.GetNumberDonators() + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ZipCode zipCode = new ZipCode();
                zipCode.ZIPCode = txt_zipcode.Text;
                zipCode.Locality = txt_locality.Text;

                LoginData loginData = new LoginData();
                loginData.Email = txt_email.Text;
                loginData.Password = txt_password.Text;

                Address address = new Address();
                address.ID = Address.NextID++;
                address.Street = txt_street.Text;
                address.Number = int.Parse(txt_streetNumber.Text);
                address.ZIPCode = zipCode;

                Donator donator = new Donator() { Adr = address, Name = txt_name.Text, LData = loginData };
                
                DataAcess.InsertDonator(donator);

                MessageBox.Show("Donator inserted sucessfully");


            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error adding donator:({ex.Message}) ", "ACFW Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
