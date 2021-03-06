﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velosiped
{
    class Velosiped : Koleso
    {
        public int SteeringWheelPosition;
        public double WheelBase;
        public double WheelRadius;

        public double CurrentPositionX;
        public double CurrentPositionY;
        public double CurrentPostitionZ;

        public int Health;

        public bool Movement;

        public Koleso WheelOne = new Koleso();
        public Koleso WheelTwo = new Koleso();

        public Velosiped(double wheelBase, double wheelRadius, int health, bool movement)
        {
            SteeringWheelPosition = 0;
            WheelBase = wheelBase;
            WheelRadius = wheelRadius;

            Health = health;

            Movement = movement;

            CurrentPositionX = 0.0;
            CurrentPositionY = 0.0;
            CurrentPostitionZ = 0.0;

            WheelOne.XCenterCoord = CurrentPositionX;
            WheelOne.YCenterCoord = CurrentPositionY - WheelRadius;
            WheelOne.ZCenterCoord = CurrentPostitionZ;

            WheelTwo.XCenterCoord = CurrentPositionX;
            WheelTwo.YCenterCoord = WheelOne.YCenterCoord - WheelBase;
            WheelTwo.ZCenterCoord = CurrentPostitionZ;
        }

        public void Move (int direction)
        {
            switch(direction)
            {
                case -1: {
                        CurrentPositionX -= 5;
                        CurrentPositionY += 10;

                        WheelOne.XCenterCoord += CurrentPositionX;
                        WheelOne.YCenterCoord = CurrentPositionY - WheelRadius;

                        WheelTwo.XCenterCoord += CurrentPositionX;
                        WheelTwo.YCenterCoord = WheelOne.YCenterCoord - WheelBase;
                        break;
                    }
                case 0: {
                        CurrentPositionY += 10;
                        WheelOne.YCenterCoord = CurrentPositionY - WheelRadius;
                        WheelTwo.YCenterCoord = WheelOne.YCenterCoord - WheelBase;
                        break;
                    }
                case 1: {
                        CurrentPositionX += 5;
                        CurrentPositionY += 10;

                        WheelOne.XCenterCoord += CurrentPositionX;
                        WheelOne.YCenterCoord = CurrentPositionY - WheelRadius;

                        WheelTwo.XCenterCoord += CurrentPositionX;
                        WheelTwo.YCenterCoord = WheelOne.YCenterCoord - WheelBase;
                        break;
                    }
            }

        }

        public void TurnRight()
        {
            SteeringWheelPosition += 1;
        }

        public void TurnLeft()
        {
           SteeringWheelPosition -= 1;
        }

        public void Damage(int damage)
        {
            if (Health >= damage)
            {
                Health -= damage;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Велику и так плохо!");
            }
        }

        public void Repair()
        {
            Health = 100;
        }
    }
}

