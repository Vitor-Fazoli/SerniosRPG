using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sernios
{
    public partial class Combat : Form
    {
        private int weaponChoice;

        public void insertWeapon(Weapon p,Weapon s)
        {
            
        }
        public Combat()
        {
            InitializeComponent();
        }

        public Combat(string name,int lvlEnemy, int Life, int Action, int damagePerTurn)
        {
            InitializeComponent();

            labelNameEnemy.Text = name;

            labelLevelEnemy.Text = lvlEnemy.ToString();

            barEnemyHealth.Maximum = Life;
            barEnemyHealth.Value = 200;
            labelEnemyHealth.Text = barEnemyHealth.Value.ToString();

            barActionPointsEnemy.Maximum = Action;
            barActionPointsEnemy.Value = Action;
            labelActionPointsEnemy.Text = barActionPointsEnemy.Value.ToString();

            barPlayerHealth.Value = barPlayerHealth.Maximum;
            
        }

        private void buttonWeapon1_Click(object sender, EventArgs e)
        {
            buttonWeapon1.Enabled = false;
            weaponChoice = 1;

            buttonWeapon2.Enabled = true;
        }

        private void buttonWeapon2_Click(object sender, EventArgs e)
        {
            buttonWeapon2.Enabled = false;
            weaponChoice = 2;

            buttonWeapon1.Enabled = true;
        }

        private void skipTurn_Click(object sender, EventArgs e)
        {
            Random accuracy = new();

            if (weaponChoice == 1)
            {
                if(accuracy.Next(100) <= 90)
                    if (20 > barEnemyHealth.Value)
                    {
                        barEnemyHealth.Value = 0;
                    }
                    else
                    {
                        barEnemyHealth.Value -= 20;
                    }
            }
            else
            {
                if (accuracy.Next(100) <= 30)
                    if(50 > barEnemyHealth.Value)
                    {
                        barEnemyHealth.Value = 0;
                        MessageBox.Show(Application.CommonAppDataPath);
                    }
                    else
                    {
                        //SoundPlayer simpleSound = new SoundPlayer(Application.ExecutablePath + "Assets\0008657.mp3");
                        //simpleSound.Play();
                        MessageBox.Show(Application.CommonAppDataPath);
                        barEnemyHealth.Value -= 50;
                    }
            }

            EnemyTurn();

        }
        private void EnemyTurn()
        {
            Random accuracy = new();

            if (accuracy.Next(100) <= 90)
                if (20 > barPlayerHealth.Value)
                {
                    barPlayerHealth.Value = 0;
                }
                else
                {
                    barPlayerHealth.Value -= 20;
                }
        }
    }
}
