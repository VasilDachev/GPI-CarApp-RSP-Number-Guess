using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class MainForm : Form
    {
        double price = 0;
        double extras = 0;
        double discount1 = 0;
        double DicountCheck = 0;
        double discount2 = 0;
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = CarApp.Properties.Resources.Benz;
            price = 25000;
            lbPrice.Text = price.ToString() + '$';
        }

        private void rbVW_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = CarApp.Properties.Resources.VW;
            price = 15000;
            lbPrice.Text = price.ToString() + '$';
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            pbGallery.Image = CarApp.Properties.Resources.Audi;
            price = 20000;
            lbPrice.Text = price.ToString() + '$';
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbABS_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbABS.Checked)
            {
                price += 1500;
                extras += 1500;
                lbExtras.Text = extras.ToString() + '$';
            }

            else if (cbABS.Checked == false)
            {
                price -= 1500;
                extras -= 1500;
                lbExtras.Text = extras.ToString() + '$';
            }
        }

        private void cbLights_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLights.Checked)
            {
                price += 1000;
                extras += 1000;
                lbExtras.Text = extras.ToString() + '$';
            }

            else if (cbLights.Checked==false)
            {
                price -= 1000;
                extras -= 1000;
                lbExtras.Text = extras.ToString() + '$';
            } 
        }

        private void cbChains_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChains.Checked)
            {
                price += 400;
                extras += 400;
                lbExtras.Text = extras.ToString() + '$';
            }
            else if (cbChains.Checked==false)
            {
                extras -= 400;
                price -= 400;
                lbExtras.Text = extras.ToString() + '$';
            }
          
         
        }

        private void cbABS_CheckStateChanged(object sender, EventArgs e)
        {
            //whoops!
        }

        private void btnCheckD_Click(object sender, EventArgs e)
        {
            if (cbLights.Checked && cbChains.Checked  && cbABS.Checked)
            {
                discount1 = 0.1;
              
            }
            else if(cbLights.Checked == false || cbChains.Checked == false || cbABS.Checked == false)
            {
                discount1 = 0;
                
            }
            if (rbCash.Checked)
            {
                discount2 = 0.05;
            }
            else if (rbCash.Checked==false)
            {
                discount2 = 0;
            }


            DicountCheck = (price + extras) * (discount1 + discount2);
            lbDiscount.Text = '-' + DicountCheck.ToString() + '$';


        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {

            double TotalPrice = 0;
            TotalPrice = price + extras - DicountCheck;
            lbTotal.Text = TotalPrice.ToString() + '$';
        }
    }
}
