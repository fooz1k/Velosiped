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
        Velosiped Velik = new Velosiped(10, 16,100,false);

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
            if (Velik.Movement) MovementLabel.Text = "Едем";
            if (!Velik.Movement) MovementLabel.Text = "Стоим";
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

        private void LowHealthDamageButton_Click(object sender, EventArgs e)
        {
            Velik.Damage(10);
            UpdateForm();
        }

        private void HighHealthDamageButton_Click(object sender, EventArgs e)
        {
            Velik.Damage(50);
            UpdateForm();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Velik.Movement = false;
            UpdateForm();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {

                Velik.Movement = true;
                while (true)
                {
                if (Velik.Health > 0)
                {
                    System.Threading.Thread.Sleep(100);

                    Velik.Move(Velik.SteeringWheelPosition);

                    UpdateForm();
                    Application.DoEvents();
                    if (!Velik.Movement) break;
                }
                else
                {
                    MessageBox.Show("Велику плохо, не поедет никуда");
                    Velik.Movement = false;
                    break;
                }
            }
        }

        private void ReparButton_Click(object sender, EventArgs e)
        {
            Velik.Repair();
            UpdateForm();
        }
    }
}
