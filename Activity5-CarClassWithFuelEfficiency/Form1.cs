using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5_CarClassWithFuelEfficiency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMaxDistance_Click(object sender, EventArgs e)
        {
            try
                {
                Car car = new Car(double.Parse(numericUpDownFuelCapacity.Text), double.Parse(numericUpDownFuelEfficiency.Text));
              
                
                labelOutput.Text = $"Fuel Capacity: {car.FuelCapacity}L\nFuel Efficiency: {car.FuelEfficiency} km/L\nMaximum Distance: {car.MaxDistance:F2} km";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for fuel efficiency and fuel in tank.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
