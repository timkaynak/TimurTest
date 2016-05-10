using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace trykac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.Write("Decimal".PadRight(10));
	        Console.Write("ASCII".PadRight(10));
	        Console.Write("Hex".PadRight(10));
	        Console.WriteLine();


            
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text.Length == 2)
                {

                    switch (Convert.ToInt32(textBox3.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            textBox1.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            textBox1.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            textBox1.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            textBox1.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            textBox1.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            textBox1.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            textBox1.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            textBox1.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            textBox1.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(textBox3.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            textBox1.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (textBox3.Text.Length == 1)
                {
                    switch (Convert.ToInt32(textBox3.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            textBox1.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            textBox1.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            textBox1.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            textBox1.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            textBox1.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            textBox1.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            textBox1.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            textBox1.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            textBox1.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            textBox1.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }                
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            int result = BitConverter.ToInt32(bytes, 0);
            textBox2.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CT1 = "";

            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                CT1 = CT1 + Convert.ToInt32(Convert.ToChar(textBox3.Text.Substring(i, 1))).ToString();
            }

            textBox1.Text = CT1.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string giris;
            //giris = textBox1.Text;

            //int cikis = int.Parse(giris, System.Globalization.NumberStyles.HexNumber);
            //textBox2.Text = cikis.ToString();

            lblLastMShift_A.Text = tbSlabID.Text.Substring(0, 2);
            lblLastMShift_B.Text = tbSlabID.Text.Substring(2, 2);
            lblLastMShift_C.Text = tbSlabID.Text.Substring(4, 2);
            lblLastMShift_D.Text = tbSlabID.Text.Substring(6, 2);
            lblLastMShift_E.Text = tbSlabID.Text.Substring(8, 2);
            lblLastMShift_F.Text = tbSlabID.Text.Substring(10, 2);
            lblLastMShift_G.Text = tbSlabID.Text.Substring(12, 1);

           
            
            //CT1

            try
            {
                if (lblLastMShift_A.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_A.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT1asci.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT1asci.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT1asci.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT1asci.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT1asci.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT1asci.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT1asci.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT1asci.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT1asci.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_A.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT1asci.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_A.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_A.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT1asci.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT1asci.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT1asci.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            lblCT1asci.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            lblCT1asci.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            lblCT1asci.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            lblCT1asci.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            lblCT1asci.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            lblCT1asci.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            lblCT1asci.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }


            //CT3

            try
            {
                if (lblLastMShift_B.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_B.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT3asci.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT3asci.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT3asci.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT3asci.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT3asci.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT3asci.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT3asci.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT3asci.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT3asci.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_B.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT3asci.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_B.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_B.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT3asci.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT3asci.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT3asci.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            lblCT3asci.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            lblCT3asci.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            lblCT3asci.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            lblCT3asci.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            lblCT3asci.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            lblCT3asci.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            lblCT3asci.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }

            //CT5

            try
            {
                if (lblLastMShift_C.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_C.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT5asci.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT5asci.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT5asci.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT5asci.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT5asci.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT5asci.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT5asci.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT5asci.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT5asci.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_C.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT5asci.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_C.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_C.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT5asci.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT5asci.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT5asci.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            lblCT5asci.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            lblCT5asci.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            lblCT5asci.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            lblCT5asci.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            lblCT5asci.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            lblCT5asci.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            lblCT5asci.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }


            //CT7

            try
            {
                if (lblLastMShift_D.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_D.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT7asci.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT7asci.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT7asci.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT7asci.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT7asci.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT7asci.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT7asci.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT7asci.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT7asci.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_D.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT7asci.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_D.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_D.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT7asci.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT7asci.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT7asci.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            lblCT7asci.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            lblCT7asci.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            lblCT7asci.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            lblCT7asci.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            lblCT7asci.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            lblCT7asci.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            lblCT7asci.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }

            //CT9

            try
            {
                if (lblLastMShift_E.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_E.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT9asci.Text = sondeger0.ToString();

                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT9asci.Text = sondeger1.ToString();

                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT9asci.Text = sondeger2.ToString();
                            break;


                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT9asci.Text = sondeger3.ToString();
                            break;


                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT9asci.Text = sondeger4.ToString();
                            break;


                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT9asci.Text = sondeger5.ToString();
                            break;


                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT9asci.Text = sondeger6.ToString();
                            break;


                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT9asci.Text = sondeger7.ToString();
                            break;


                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT9asci.Text = sondeger8.ToString();
                            break;


                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_E.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT9asci.Text = sondeger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_E.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_E.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT9asci.Text = deger0.ToString();

                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT9asci.Text = deger1.ToString();

                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT9asci.Text = deger2.ToString();
                            break;


                        case 3:
                            int deger3 = 51;
                            lblCT9asci.Text = deger3.ToString();
                            break;


                        case 4:
                            int deger4 = 52;
                            lblCT9asci.Text = deger4.ToString();
                            break;


                        case 5:
                            int deger5 = 53;
                            lblCT9asci.Text = deger5.ToString();
                            break;


                        case 6:
                            int deger6 = 54;
                            lblCT9asci.Text = deger6.ToString();
                            break;


                        case 7:
                            int deger7 = 55;
                            lblCT9asci.Text = deger7.ToString();
                            break;


                        case 8:
                            int deger8 = 56;
                            lblCT9asci.Text = deger8.ToString();
                            break;


                        case 9:
                            int deger9 = 57;
                            lblCT9asci.Text = deger9.ToString();
                            break;


                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }


            //CT11

            try
            {
                if (lblLastMShift_F.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_F.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT11asci.Text = sondeger0.ToString();
                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT11asci.Text = sondeger1.ToString();
                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT11asci.Text = sondeger2.ToString();
                            break;

                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT11asci.Text = sondeger3.ToString();
                            break;

                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT11asci.Text = sondeger4.ToString();
                            break;

                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT11asci.Text = sondeger5.ToString();
                            break;

                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT11asci.Text = sondeger6.ToString();
                            break;

                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT11asci.Text = sondeger7.ToString();
                            break;

                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT11asci.Text = sondeger8.ToString();
                            break;

                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_F.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT11asci.Text = sondeger9.ToString();
                            break;

                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_F.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_F.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT11asci.Text = deger0.ToString();
                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT11asci.Text = deger1.ToString();
                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT11asci.Text = deger2.ToString();
                            break;

                        case 3:
                            int deger3 = 51;
                            lblCT11asci.Text = deger3.ToString();
                            break;

                        case 4:
                            int deger4 = 52;
                            lblCT11asci.Text = deger4.ToString();
                            break;

                        case 5:
                            int deger5 = 53;
                            lblCT11asci.Text = deger5.ToString();
                            break;

                        case 6:
                            int deger6 = 54;
                            lblCT11asci.Text = deger6.ToString();
                            break;

                        case 7:
                            int deger7 = 55;
                            lblCT11asci.Text = deger7.ToString();
                            break;

                        case 8:
                            int deger8 = 56;
                            lblCT11asci.Text = deger8.ToString();
                            break;

                        case 9:
                            int deger9 = 57;
                            lblCT11asci.Text = deger9.ToString();
                            break;

                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }


            //CT13

            try
            {
                if (lblLastMShift_G.Text.Length == 2)
                {

                    switch (Convert.ToInt32(lblLastMShift_G.Text.Substring(0, 1)))
                    {

                        case 0:
                            int deger0 = 12336;
                            int fark0 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger0 = deger0 + fark0;
                            lblCT13asci.Text = sondeger0.ToString();
                            break;

                        case 1:
                            int deger1 = 12592;
                            int fark1 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger1 = deger1 + fark1;
                            lblCT13asci.Text = sondeger1.ToString();
                            break;

                        case 2:
                            int deger2 = 12848;
                            int fark2 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger2 = deger2 + fark2;
                            lblCT13asci.Text = sondeger2.ToString();
                            break;

                        case 3:
                            int deger3 = 13104;
                            int fark3 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger3 = deger3 + fark3;
                            lblCT13asci.Text = sondeger3.ToString();
                            break;

                        case 4:
                            int deger4 = 13360;
                            int fark4 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger4 = deger4 + fark4;
                            lblCT13asci.Text = sondeger4.ToString();
                            break;

                        case 5:
                            int deger5 = 13616;
                            int fark5 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger5 = deger5 + fark5;
                            lblCT13asci.Text = sondeger5.ToString();
                            break;

                        case 6:
                            int deger6 = 13872;
                            int fark6 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger6 = deger6 + fark6;
                            lblCT13asci.Text = sondeger6.ToString();
                            break;

                        case 7:
                            int deger7 = 14128;
                            int fark7 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger7 = deger7 + fark7;
                            lblCT13asci.Text = sondeger7.ToString();
                            break;

                        case 8:
                            int deger8 = 14384;
                            int fark8 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger8 = deger8 + fark8;
                            lblCT13asci.Text = sondeger8.ToString();
                            break;

                        case 9:
                            int deger9 = 14640;
                            int fark9 = Convert.ToInt32(lblLastMShift_G.Text.Substring(1, 1)) - 0;
                            int sondeger9 = deger9 + fark9;
                            lblCT13asci.Text = sondeger9.ToString();
                            break;

                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }

                else if (lblLastMShift_G.Text.Length == 1)
                {
                    switch (Convert.ToInt32(lblLastMShift_G.Text))
                    {

                        case 0:
                            int deger0 = 48;
                            lblCT13asci.Text = deger0.ToString();
                            break;

                        case 1:
                            int deger1 = 49;
                            lblCT13asci.Text = deger1.ToString();
                            break;

                        case 2:
                            int deger2 = 50;
                            lblCT13asci.Text = deger2.ToString();
                            break;

                        case 3:
                            int deger3 = 51;
                            lblCT13asci.Text = deger3.ToString();
                            break;

                        case 4:
                            int deger4 = 52;
                            lblCT13asci.Text = deger4.ToString();
                            break;

                        case 5:
                            int deger5 = 53;
                            lblCT13asci.Text = deger5.ToString();
                            break;

                        case 6:
                            int deger6 = 54;
                            lblCT13asci.Text = deger6.ToString();
                            break;

                        case 7:
                            int deger7 = 55;
                            lblCT13asci.Text = deger7.ToString();
                            break;

                        case 8:
                            int deger8 = 56;
                            lblCT13asci.Text = deger8.ToString();
                            break;

                        case 9:
                            int deger9 = 57;
                            lblCT13asci.Text = deger9.ToString();
                            break;

                        default:
                            MessageBox.Show("bir yerde bi bokluk var sanirim");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("bir yerde bi bokluk var sanirim");
            }

        }

  
	

        
    

       
    }
}
