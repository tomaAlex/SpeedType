using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] cuv = new string[3001];
        RichTextBox[] cuv_label = new RichTextBox[3001];
        int counter = 0;
        int v = 5;
        int scor;
        TextBox intrare = new TextBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr_check.Enabled = false;
            cuv = System.IO.File.ReadAllLines(@"E:\Eugen\SpeedType\SpeedType\bin\Debug\lista_cuvinte.txt");
            this.BackColor = Color.Navy;
            //for (int i = 1; i <= 3000; i++) MessageBox.Show(cuv[i]);
            this.Controls.Add(intrare);
            for (int i = 1; i <= 3000; i++)
            {
                cuv_label[i] = new RichTextBox();
                //cuv_label[i].Text = "test";
                cuv_label[i].Enabled = false;
                //cuv_label[i].Top = 10;
                //cuv_label[i].Left = 10;
                //cuv_label[i].Height = 40;
                //cuv_label[i].Width = 40;
                //cuv_label[i].BorderStyle = BorderStyle.Fixed3D;
                cuv_label[i].AutoSize = true;
                this.Controls.Add(cuv_label[i]);
            }
            intrare.Enabled = true;
            //intrare.Top = this.Height + 20;
            //intrare.Visible = false;
            tmr_check.Enabled = true;
        }

        private void tmr_aparitieCuv_Tick(object sender, EventArgs e)
        {
            if (counter < 3000)
            {
                counter++;
                cuv_label[counter].Enabled = true;
                Random rnd = new Random();
                int x = rnd.Next(5, 16);
                int y = rnd.Next(5, this.Height - 50);
                cuv_label[counter].Top = y;
                cuv_label[counter].Left = x;
                //cuv_label[counter].Size = 10;
                cuv_label[counter].Font = new Font("Arial", 15, FontStyle.Bold);
                cuv_label[counter].ForeColor = Color.White;
                cuv_label[counter].Text = cuv[counter];
                cuv_label[counter].Visible = true;
                cuv_label[counter].ReadOnly = true;
                cuv_label[counter].Multiline = false;
                cuv_label[counter].BorderStyle = BorderStyle.None;
                //cuv_label[counter].Cursor = Cursor.
                cuv_label[counter].MaxLength = 30;
                cuv_label[counter].BackColor = Color.Navy;
                //MessageBox.Show(" " + counter);
            }
            else counter = 0;
        }

        private void tmr_acceleratie_Tick(object sender, EventArgs e)
        {
            v += 3;
        }

        private void tmr_misca_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= counter; i++)
            {
                cuv_label[i].Left += v;
                if (cuv_label[i].Left >= this.Width && cuv_label[i].Enabled == true)
                {
                    tmr_misca.Enabled = false;
                    tmr_aparitieCuv.Enabled = false;
                    i = counter + 1;
                    MessageBox.Show("GAME OVER\nYOUR SCORE: " + scor);
                    this.Close();
                }
            }
        }

        private void tmr_check_Tick(object sender, EventArgs e)
        {
            // verifica daca textbox-ul are vreun cuvant din cele active si sterge-l
            for(int i=1;i<=counter;i++)
            {
                if (intrare.Text.Length > 0 && intrare.Text[0] == cuv_label[i].Text[0] && cuv_label[i].Enabled == true)
                {
                    //MessageBox.Show("sunt in if, la cuvantul " + i);
                    // verificam ce litere coloram
                    int pana_unde = intrare.Text.Length;
                    if (cuv_label[i].Text.Length < pana_unde) pana_unde = cuv_label[i].Text.Length;
                    for (int j = 0; j < pana_unde; j++)
                    {
                        if (cuv_label[i].Text[j] == intrare.Text[j])
                        {
                            // coloram litera asta
                            cuv_label[i].Select(j, 1);
                            cuv_label[i].SelectionColor = Color.Red;
                            cuv_label[i].DeselectAll();
                        }
                        else
                        {
                            for (int poz_recolorare = j; poz_recolorare < pana_unde; poz_recolorare++)
                            {
                                // coloram litera asta
                                cuv_label[i].Select(poz_recolorare, poz_recolorare);
                                cuv_label[i].SelectionColor = Color.White;
                                cuv_label[i].DeselectAll();
                            }
                            j = pana_unde + 1;
                        }
                    }
                }
                if (intrare.Text.Length > 0)
                {
                    int len_min = intrare.Text.Length;
                    if (len_min > cuv_label[i].Text.Length) len_min = cuv_label[i].Text.Length;
                    for (int j = 1; j < len_min; j++)
                    {
                        if (intrare.Text[j] != cuv_label[i].Text[j] && cuv_label[i].Enabled == true)
                        {
                            cuv_label[i].Select(j, cuv_label[i].Text.Length - j);
                            cuv_label[i].SelectionColor = Color.White;
                            j = len_min + 1;
                        }
                    }
                }
                if(cuv_label[i].Enabled==true && intrare.Text==cuv_label[i].Text)
                {
                    cuv_label[i].Enabled = false;
                    cuv_label[i].Visible = false;
                    intrare.Text = "";
                    scor++;
                    label1.Text = scor.ToString();
                }
            }
        }
    }
}
