using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoApp
{
    public partial class Form1 : Form
    {
        List<string> countries = new List<string>() { "USA", "TURKEY", "CHINA" };
        List<string> cargo_types = new List<string>() { "Standart", "Maye" };

        public Form1()
        {
            InitializeComponent();
            dropDown.DataSource = countries;
            cargoTypes.DataSource = cargo_types;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            PriceHandler calculatePrice = new PriceHandler();

            calculatePrice.Width = (float)widthInput.Value;
            calculatePrice.Height = (float)heightInput.Value;
            calculatePrice.Weight = (float)weightInput.Value;
            calculatePrice.Count = (int)countInput.Value;
            calculatePrice.Length = (float)lengthInput.Value;
            calculatePrice.Country = (string)dropDown.SelectedItem;
            calculatePrice.Type = (string)cargoTypes.SelectedItem;
            float totalPrice = calculatePrice.Calculate();

            totalText.ForeColor = Color.FromArgb(50, 205, 50);
            totalText.Text = $"{Math.Round(totalPrice, 2)}$";
        }
    }
}
