using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseFrazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Frazione frazione = new Frazione();
        
        public void Inserimento()
        {
            frazione.Numeratore = float.Parse(textBox1.Text);
            frazione.Denominatore = float.Parse(textBox2.Text);

            int dec = int.Parse(textBox1.Text);
            int dec2 = int.Parse(textBox2.Text);

            int decim = dec / dec2;
            txt_decimale.Text= decim.ToString();

        }

        private void bttn_somma_Click(object sender, EventArgs e)
        {
            Inserimento();
            float somma;
            
            somma = frazione.Numeratore + frazione.Denominatore;

            MessageBox.Show($"Il risultato è:{somma}");
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void bttn_sottr_Click(object sender, EventArgs e)
        {
            Inserimento();
            float sottraz;

            sottraz = frazione.Numeratore - frazione.Denominatore;

            MessageBox.Show($"Il risultato è:{sottraz}");
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void bttn_moltip_Click(object sender, EventArgs e)
        {
            Inserimento();
            float moltipl;

            moltipl = frazione.Numeratore * frazione.Denominatore;

            MessageBox.Show($"Il risultato è:{moltipl}");
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inserimento();
            float divis;

            divis = frazione.Numeratore / frazione.Denominatore;

            MessageBox.Show($"Il risultato è:{divis}");
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
        public float TrovaMAx(float num, float den)
        {
            float n;
            if(num >= den)
            {
                n = num;
            }
            else
            {
                n= den;
            }
            return n;
        }

        private void bttn_sempl_Click(object sender, EventArgs e)
        {
            Inserimento();

            int n=1;
            float max = TrovaMAx(frazione.Numeratore, frazione.Denominatore);
            bool c=false;
            while(c==false)
            {
                for (int i = 1; i < max; i++)
                {
                    if (frazione.Numeratore % i==0 && frazione.Denominatore % i == 0)
                    {
                        n = i;
                        frazione.Numeratore /= n;
                        frazione.Denominatore /= n;
                    }

                }
                if(frazione.Numeratore % frazione.Denominatore !=0 || frazione.Denominatore % frazione.Numeratore != 0)
                {
                    c = true;

                }
                if(frazione.Numeratore == frazione.Denominatore)
                {
                    frazione.Numeratore = 1;
                    frazione.Denominatore = 1;
                    c = true;
                }
                textBox1.Text = frazione.Numeratore.ToString();
                textBox2.Text = frazione.Denominatore.ToString();

                max = TrovaMAx(frazione.Numeratore, frazione.Denominatore);
            }
            
        }
    }
}
    class Frazione
    {
        public float _numeroratore;
        public float _denominatore;

        public float Numeratore
        {
            get { return _numeroratore; }
            set { _numeroratore = value; }
            
        }

        public float Denominatore
        {
            get { return _denominatore; }
            set { _denominatore = value; }

        }
    }
