using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA250622_G5.Entities.Enums;

namespace WFA250622_G5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = SeedData.customers.Count;


            foreach (var item in SeedData.reservations)
            {
                MessageBox.Show(item.Customer.Name + " " + item.Customer.Surname + " " + item.Hotel.HotelName);
            }

            foreach (var item in SeedData.hotels)
            {
                if (cbLocations.Items.Contains(item.HotelLocation))
                {
                    continue;
                }
                else
                {
                    cbLocations.Items.Add(item.HotelLocation);
                }
            }

        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            foreach (var item in SeedData.customers)
            {
                if (item.ID == numericUpDown1.Value)
                {
                    txtName.Text = item.Name;
                    txtSurname.Text = item.Surname;

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("HotelName", "Hotel Name: ");
            dataGridView1.Columns.Add("Price", "Price: ");
            dataGridView1.Columns.Add("Currency", "Currency Unit: ");

            foreach (var item in SeedData.hotels)
            {
                if (item.HotelLocation.ToString() == cbLocations.Text)  // ve if(item.Location==(Locations)cbLocation.SelectedItem) yazabiliriz.
                {
                    dataGridView1.Rows.Add(item.HotelName, item.Price, item.CurrencyUnits);
                }
            }

        }
    }
}
