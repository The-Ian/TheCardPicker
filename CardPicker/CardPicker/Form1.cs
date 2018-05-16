using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPicker
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int TopPos = 0;
        int LeftPos = 270;
        int index = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string card in imageList1.Images.Keys)
            {
                imageList1.Images.Keys.ToString();
                listBox1.Items.Add(card);

            }


         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = listBox1.SelectedItem.ToString();
            pictureBox1.Image = imageList1.Images[SelectedItem];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string card in imageList1.Images.Keys)
            {
                try
                {
                    PictureBox newCard = new PictureBox();
                    newCard.Size = new Size(50, 75);
                    newCard.SizeMode = PictureBoxSizeMode.Zoom;
                    newCard.Location = new Point(LeftPos, TopPos);
                    newCard.Image = imageList1.Images[index];
                    this.Controls.Add(newCard);
                    newCard.BringToFront();
                    LeftPos = (LeftPos + 10);


                    if (LeftPos > 550)
                    {
                        TopPos = TopPos + 75;
                        LeftPos = 270;

                    }

                    index++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
