using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velosiped
{
    public partial class Form1 : Form
    {
        Velosiped Velik = new Velosiped(10, 16,100);
        public Form1()
        {
            InitializeComponent();
            UpdateForm();
        }

        public void UpdateForm()
        {
           switch (Velik.SteeringWheelPosition)
            {
                case -1 : CurrentSteeringWheelPositionLabel.Text = "Руль влево"; break;
                case 0: CurrentSteeringWheelPositionLabel.Text = "Руль прямо"; break;
                case 1: CurrentSteeringWheelPositionLabel.Text = "Руль вправо"; break;
            }
            CurrentWheelOnePositionLabel.Text = ("Позиция переднего колеса  X: " + Velik.WheelOne.XCenterCoord + " Y: " + Velik.WheelOne.YCenterCoord + " Z: " + Velik.WheelOne.ZCenterCoord);
            CurrentWheelTwoPositionLabel.Text = ("Позиция заднего колеса X: " + Velik.WheelTwo.XCenterCoord + " Y: " + Velik.WheelTwo.YCenterCoord + " Z: " + Velik.WheelTwo.ZCenterCoord);
            CurrentPositionLabel.Text = ("Позиция велосипеда X: " + Velik.CurrentPositionX + " Y: " + Velik.CurrentPositionY + " Z: " + Velik.CurrentPostitionZ);
            HealthLabel.Text = "Состояние велосипеда : " + Velik.Health + "%";
        }

        private void TurnLeftButton_Click(object sender, EventArgs e)
        {
            if (Velik.SteeringWheelPosition >= 0)
            {
                Velik.TurnLeft();
            }
            else
            {
                MessageBox.Show("Руль уже повернут!");
            }
            UpdateForm();
        }

        private void TurnRightButton_Click(object sender, EventArgs e)
        {
            if (Velik.SteeringWheelPosition <= 0)
            {
                Velik.TurnRight();
            }
            else
            {
                MessageBox.Show("Руль уже повернут!");
            }
            UpdateForm();
        }

        private void MoveToLeftButton_Click(object sender, EventArgs e)
        {
            if(Velik.SteeringWheelPosition == -1)
            {
                Velik.MoveToLeft();
            }
            else
            {
                MessageBox.Show("Руль то поверни!");
            }
            UpdateForm();
        }

        private void MoveForwardButton_Click(object sender, EventArgs e)
        {
            if(Velik.SteeringWheelPosition == 0)
            {
                Velik.MoveForward();
            }
            else
            {
                MessageBox.Show("Руль то прямо поставь!");
            }
            UpdateForm();
        }

        private void MoveToRightButton_Click(object sender, EventArgs e)
        {
            if(Velik.SteeringWheelPosition == 1)
            {
                Velik.MoveToRight();
            }
            else
            {
                MessageBox.Show("Руль то поверни!");
            }
            UpdateForm();
        }

        private void LowHealthDamageButton_Click(object sender, EventArgs e)
        {
            Velik.LowDamage();
            UpdateForm();
        }

        private void HighHealthDamageButton_Click(object sender, EventArgs e)
        {
            Velik.HighDamage();
            UpdateForm();
        }
    }
}
