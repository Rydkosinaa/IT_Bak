using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bak
{
    public partial class ITBak : Form
    {
        Bak bak = new Bak();
        public ITBak()
        {
            InitializeComponent();
            AddWater();
        }
       async public void AddWater()
        {
            HighLevel.Text = "0";
            LowLevel.Text = "0";
            pumpe.Text = "0";
            while (true)
            {
                Random random = new Random();
                bak.Volume += random.Next(1, 5);
                BakVolume.Text = "Об'єм  " + bak.Volume.ToString() + "%";
                await Task.Delay(500);
                if (bak.Volume >= bak.LowLevel)
                {
                    LowLevel.Text = "1";
                }
                else  
                {
                    LowLevel.Text = "0";
                }
                if (bak.Volume >= bak.HighLevel)
                {
                    HighLevel.Text = "1";
                    Pump();
                }
                else 
                {
                    HighLevel.Text = "0";
                }
            }

        }
        async void Pump()
        {
            await Task.Delay(3000);
            while (bak.Volume > bak.LowLevel) 
            {
                pumpe.Text = "1";
                Random random = new Random();
                bak.Volume -= random.Next(1, 6);
                await Task.Delay(500);
            }
            pumpe.Text = "0";
        }
    }

    class Bak
    {
        private double volume;
        public double HighLevel = 80;
        public double LowLevel = 20;

        public double Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
            }
        }
    }

}
