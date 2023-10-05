using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carInventory = new List<Car>(); 

        public Form1()
        {
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string year, make, colour, mileage;

            year = yearInput.Text;
            make = makeInput.Text;
            colour = colourInput.Text;
            mileage = mileageInput.Text;

            Car newCar = new Car(year, make, colour, mileage);
            carInventory.Add(newCar);

            DisplayCars();

            //outputLabel.Text = "";

            //for (int i = 0; i < carInventory.Count; i++)
            //{
            //    outputLabel.Text += $"{carInventory[i].year} {carInventory[i].make} {carInventory[i].colour} {carInventory[i].mileage}\n";
            //}

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string year = yearInput.Text;

            for (int i = 0; i < carInventory.Count; i++)
            {
                if (carInventory[i].year == year)
                {
                    carInventory.RemoveAt(i);
                    break;
                }
            }

            DisplayCars();
 
        }

        public void DisplayCars()
        {
            outputLabel.Text = "";

            foreach (Car c in carInventory)
            {
                outputLabel.Text += $"{c.year} {c.make} {c.colour} {c.mileage}\n";
            }
        }
    }
}
