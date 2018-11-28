using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOV
{
    public partial class Fov : Form
    {
        public Fov()
        {
            InitializeComponent();
            //skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\Calmness.ssk";  //选择皮肤文件
            //skinEngine1.DisableTag = 9999;
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Calmness.ssk";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Fovsize02_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fovsize01_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Fov_Load(object sender, EventArgs e)
        {
         

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            double resolution01;
            double resolution02;
            double formatsize01;
            double formatsize02;
            double formatsize03;
            double fovsize01;
            double fovsize02;
            double pixelsize;
            double wd;
            double ppi;
            double focus;
            double fdbl;
            double inch;
            float in_fdbl;
            int jtlp01;

            if (checkBox1.Checked == false)
            {
                if ((this.Resolution01.Text.Trim() == "") || (this.Resolution02.Text.Trim() == "") || (this.Pixelsize.Text.Trim() == "") || (this.WD.Text.Trim() == "") || (this.Focus.Text.Trim() == ""))
                {
                    MessageBox.Show("请输入完整信息", "错误");
                    return;

                }
            }
            else
            {
                if ((this.Resolution01.Text.Trim() == "") || (this.Resolution02.Text.Trim() == "") || (this.Pixelsize.Text.Trim() == "") || (this.TB_FDBL.Text.Trim() == "") )
                {
                    MessageBox.Show("请输入完整信息", "错误");
                    return;

                }
            }



            resolution01 = double.Parse(Resolution01.Text);
            resolution02 = double.Parse(Resolution02.Text);
            

            pixelsize = double.Parse(Pixelsize.Text);
    



            formatsize01 = resolution01 * (pixelsize / 1000);
            formatsize02 = resolution02 * (pixelsize / 1000);
            formatsize03 = Math.Sqrt(formatsize01 * formatsize01 + formatsize02 * formatsize02);
            inch = formatsize03 / 16;

            Formatsize01.Text = Math.Round(formatsize01, 2).ToString();
            Formatsize02.Text = Math.Round(formatsize02, 2).ToString();
            Formatsize03.Text = Math.Round(formatsize03, 2).ToString();
            INCH_TXT.Text = Math.Round(inch, 1).ToString();




            if (checkBox1.Checked == true)
            {
                in_fdbl = float.Parse(TB_FDBL.Text);

                fovsize01 = formatsize01 / in_fdbl;
                fovsize02 = formatsize02 / in_fdbl;
                Fovsize01.Text = Math.Round(fovsize01, 2).ToString();
                Fovsize02.Text = Math.Round(fovsize02, 2).ToString();

                ppi = fovsize01 / resolution01 * 1000;
                PPI.Text = Math.Round(ppi, 2).ToString();

                fdbl = in_fdbl;
                FDBL.Text = Math.Round(fdbl, 4).ToString();

                jtlp01 = System.Convert.ToInt32(500 / pixelsize);
                JTLP01.Text = jtlp01.ToString();
            }
            else
            {
                wd = double.Parse(WD.Text);
                focus = double.Parse(Focus.Text);

                fovsize01 = (formatsize01 * wd) / focus;
                fovsize02 = (formatsize02 * wd) / focus;
                Fovsize01.Text = Math.Round(fovsize01, 2).ToString();
                Fovsize02.Text = Math.Round(fovsize02, 2).ToString();

                ppi = fovsize01 / resolution01 * 1000;
                PPI.Text = Math.Round(ppi, 2).ToString();

                fdbl = formatsize01 / fovsize01;
                FDBL.Text = Math.Round(fdbl, 4).ToString();

                jtlp01 = System.Convert.ToInt32(500 / pixelsize);
                JTLP01.Text = jtlp01.ToString();
            }

 

        }

        private void RC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RC.Text.Trim())
            {
                case "CA050-IMX264":
                    Resolution01.Text = "2448";
                    Resolution02.Text = "2048";
                    Pixelsize.Text = "3.45";
                    break;
                case "CA050-PYTHON5000":
                    Resolution01.Text = "2592";
                    Resolution02.Text = "2048";
                    Pixelsize.Text = "4.8";
                    break;
                case "CA060-IMX178":
                    Resolution01.Text = "3072";
                    Resolution02.Text = "2048";
                    Pixelsize.Text = "2.4";
                    break;
                case "CH089-IMX276":
                    Resolution01.Text = "4096";
                    Resolution02.Text = "2160";
                    Pixelsize.Text = "3.45";
                    break;
                case "CH120-IMX304":
                    Resolution01.Text = "4096";
                    Resolution02.Text = "3000";
                    Pixelsize.Text = "3.45";
                    break;
                case "CH250-GMAX0505":
                    Resolution01.Text = "5120";
                    Resolution02.Text = "5120";
                    Pixelsize.Text = "2.5";
                    break;
                case "CH250-PYTHON25K":
                    Resolution01.Text = "5120";
                    Resolution02.Text = "5120";
                    Pixelsize.Text = "4.5";
                    break;
                case "CH290-KAI29050":
                    Resolution01.Text = "6576";
                    Resolution02.Text = "4384";
                    Pixelsize.Text = "5.5";
                    break;
                case "101MC-IMX461":
                    Resolution01.Text = "11648";
                    Resolution02.Text = "8742";
                    Pixelsize.Text = "3.76";
                    break;
                case "CH1510-IMX411":
                    Resolution01.Text = "14208";
                    Resolution02.Text = "10640";
                    Pixelsize.Text = "3.76";
                    break;
                case "LineScan-8K 5um":
                    Resolution01.Text = "8192";
                    Resolution02.Text = "1";
                    Pixelsize.Text = "5";
                    break;
                case "LineScan-8K 7um":
                    Resolution01.Text = "8192";
                    Resolution02.Text = "1";
                    Pixelsize.Text = "7";
                    break;
                case "LineScan-16K 3.5um":
                    Resolution01.Text = "16384";
                    Resolution02.Text = "1";
                    Pixelsize.Text = "3.5";
                    break;
                case "LineScan-16K 5um":
                    Resolution01.Text = "16384";
                    Resolution02.Text = "1";
                    Pixelsize.Text = "5";
                    break;
                case "CE050-AR0521":
                    Resolution01.Text = "2592";
                    Resolution02.Text = "1944";
                    Pixelsize.Text = "2.2";
                    break;
                case "CE200-IMX183":
                    Resolution01.Text = "5472";
                    Resolution02.Text = "3684";
                    Pixelsize.Text = "2.4";
                    break;
                case "CA023-IMX249":
                    Resolution01.Text = "1920";
                    Resolution02.Text = "1200";
                    Pixelsize.Text = "5.86";
                    break;


            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RC02.Text.Trim())
            {
                case "0.3MP":
                    RS01.Text = "640";
                    RS02.Text = "480";
                    PS02.Text = "6";
                    break;
                case "0.5MP":
                    RS01.Text = "808";
                    RS02.Text = "608";
                    PS02.Text = "4.8";
                    break;
                case "1.3MP":
                    RS01.Text = "1280";
                    RS02.Text = "1024";
                    PS02.Text = "4.8";
                    break;
                case "1.6MP":
                    RS01.Text = "1440";
                    RS02.Text = "1080";
                    PS02.Text = "3.45";
                    break;
                case "2.3MP":
                    RS01.Text = "1920";
                    RS02.Text = "1200";
                    PS02.Text = "5.86";
                    break;
                case "3MP":
                    RS01.Text = "1920";
                    RS02.Text = "1440";
                    PS02.Text = "3.69";
                    break;
                case "3.2MP":
                    RS01.Text = "2048";
                    RS02.Text = "1536";
                    PS02.Text = "3.45";
                    break;
                case "5MP":
                    RS01.Text = "2448";
                    RS02.Text = "2048";
                    PS02.Text = "3.45";
                    break;
                case "6MP":
                    RS01.Text = "3072";
                    RS02.Text = "2048";
                    PS02.Text = "2.4";
                    break;
                case "8MP":
                    RS01.Text = "3264";
                    RS02.Text = "2448";
                    PS02.Text = "5.5";
                    break;
                case "10MP":
                    RS01.Text = "3672";
                    RS02.Text = "2754";
                    PS02.Text = "1.67";
                    break;
                case "12MP":
                    RS01.Text = "4024";
                    RS02.Text = "3036";
                    PS02.Text = "3.45";
                    break;
                case "20MP":
                    RS01.Text = "5472";
                    RS02.Text = "3648";
                    PS02.Text = "2.4";
                    break;
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double rs01;
            double fov02;
            double wd02;
            double ps02;
            double f02;
            double f020;
            double wd020;
            int jtlp;
            if ((this.RS01.Text.Trim() == "") || (this.Fov02.Text.Trim() == "") || (this.PS02.Text.Trim() == "") || (this.WD02.Text.Trim() == "") )
            {
                MessageBox.Show("请输入完整信息", "错误");
                return;

            }



            rs01 = double.Parse(RS01.Text);
            wd02 = double.Parse(WD02.Text);
            fov02 = double.Parse(Fov02.Text);
            ps02 = double.Parse(PS02.Text);
            f020 = 0;
            wd020 = 0;

            f02 = (wd02*rs01*ps02)/fov02/1000;
           
            if (f02<=0||f02>150)
            {
                f020 = -1;
            }
            else if (f02 >0&f02 <15)
            {
                f020 = 12;
            }
            else if (f02>=15&f02 < 32)
            {
                f020 = 16;
            }
            else if (f02 >= 32 & f02 < 48)
            {
                f020 = 35;
            }
            else if (f02 >= 48 & f02 < 73)
            {
                f020 = 50;
            }
            else if (f02 >= 73 & f02 < 98)
            {
                f020 = 75;
            }
            else if (f02 >= 98 & f02 < 150)
            {
                f020 = 100;
            }

            F02.Text = Math.Round(f02, 2).ToString();
            if (f020==-1)
            {
                F020.Text ="特殊规格";
            }
            else
            {
              F020.Text = Math.Round(f020, 2).ToString();
            }
            jtlp = System.Convert.ToInt32(1000 / ps02/2); 
            wd020 = (fov02 * f020) / (rs01 * ps02) * 1000;
            WD020.Text = Math.Round(wd020, 0).ToString();
            JTLP.Text = jtlp.ToString();
        }

        private void WD020_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mhq03;
            double f03;
            double ff03;
            double wd03;
            double tt;
            double tr;
            double tf;
            double js;
            mhq03 = 0;
            if ((this.JS03.Text.Trim() == "") || (this.FF03.Text.Trim() == "") || (this.F03.Text.Trim() == "") || (this.WD03.Text.Trim() == ""))
            {
                MessageBox.Show("请输入完整信息", "错误");
                return;

            }
            mhq03 = double.Parse(JS03.Text.Trim());

            wd03 = double.Parse(WD03.Text);
            f03 = double.Parse(F03.Text);
            ff03 = double.Parse(FF03.Text);

            tf = (mhq03 * ff03 * wd03 * wd03) / ((f03 * f03)+(mhq03*ff03*wd03));
            tr = (mhq03 * ff03 * wd03 * wd03) / ((f03 * f03) - (mhq03 * ff03 * wd03));
            if (tr>0)
            {
                tt = tf + tr;
                js = 2 * mhq03 * ff03;
                TF.Text = Math.Round(tf, 2).ToString();
                TR.Text = Math.Round(tr, 2).ToString();
                TT.Text = Math.Round(tt, 2).ToString();
                JS.Text = Math.Round(js, 2).ToString();

            }
            else
            {
                tt = tf;
                js = 2 * mhq03 * ff03;
                TF.Text = Math.Round(tf, 2).ToString();
                TR.Text = "∞";
                TT.Text = "∞";
                JS.Text = Math.Round(js, 2).ToString();

            }





        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
        }

        private void JS03_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Cal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void cal_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void FDBL_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Focus.Enabled = false;
                WD.Enabled = false;
                TB_FDBL.Enabled = true;
                Focus.Text = "-";
                WD.Text = "-";



            }
            else
            {
                Focus.Enabled = true;
                WD.Enabled = true;
                TB_FDBL.Enabled =false;
                TB_FDBL.Text = "-";

            }
        }

        private void label56_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
