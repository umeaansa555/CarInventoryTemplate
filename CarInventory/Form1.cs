using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
         List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, color, mileage;
            year = yearInput.Text;
            make = makeInput.Text;
            color = colourInput.Text;
            mileage = mileageInput.Text;

            Car newCar = new Car(year, make, color, mileage);
            cars.Add(newCar);

            outputLabel.Text = "";

            for (int i = 0; i < cars.Count; i++)
            {
                outputLabel.Text += $"{cars[i].make} {cars[i].color}\n";
            }

            /* newCar.year = year;

            Car newCar2 = new Car();
            newCar2.year = "2010"; */
        }
    }
}
