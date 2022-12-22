using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace for_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            List<string> imalist = new List<string>();
        PictureBox pim = new PictureBox();
       
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "choose Files";
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           // ofd.InitialDirectory = "C:\\";
            ofd.Multiselect = true;
            ofd.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt|jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
            ofd.ShowDialog();
            //DialogResult dr = this.ofd.ShowDialog();
            //if (ofd.ShowDialog() == DialogResult.OK)
                foreach (String file in ofd.FileNames)
                {
                    Image ima = new Bitmap(ofd.FileName);
                    listBox1.Items.Add(Path.GetFileName(file));
                    imalist.Add(file.ToString());
                }
        }

        private void textBox1_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Welcome in my project ☺ ☺");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void label_filename_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        bool ok = false;
        PictureBox p = new PictureBox();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ok)
              {
                int cont = listBox1.Items.Count;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                p.Size = new Size(pictureBox1.Width, pictureBox1.Height);
                p.Location = new Point(10, 10);
                p.Image = Image.FromFile(imalist[x].ToString());
                this.pictureBox1.Controls.Add(p);

                //this.panel1.Controls.Add(p);
                statusBar1.Text ="Name of Image : "+Path.GetFileName(listBox1.Items[x].ToString());
                if (x == cont-1)
                    x = 0;
                else 
                    x++;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks to use my project ♥");
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            PictureBox po = new PictureBox();
        private void singleElectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ok = false;
            statusBar1.Text = " ";
            pictureBox1.Controls.Clear();
          //  panel1.Controls.Clear();
            pim.Image = null;
            string s;
            
            int i;
            i = listBox1.SelectedIndex;
                po.Size = new Size(pictureBox1.Width, pictureBox1.Height);

            po.Location = new Point(10, 10);
                po.SizeMode = PictureBoxSizeMode.StretchImage;
                po.BorderStyle = BorderStyle.Fixed3D;
            s = imalist[i];
                po.Image = Image.FromFile(s);
            this.pictureBox1.Controls.Add(po);
           // this.panel1.Controls.Add(po);
        }
        PictureBox pic = new PictureBox();

        private void mutiSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ok = false;
             pictureBox1.Controls.Clear();
            //panel1.Controls.Clear();
                statusBar1.Text = " ";
                int x, y,wi = 10, he = 10, i = 0;
                int cons = listBox1.SelectedItems.Count;
              //  panel1.AutoScroll = true;
                foreach (string s in listBox1.SelectedItems)
                {
                            int st;
                            st=listBox1.SelectedIndices[i];
                            x = wi;
                            y = he;
                             pic = new PictureBox();
                            pic.Location = new Point(x, y);
                            pic.Size = new Size(100, 100);
                            pic.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic.BorderStyle = BorderStyle.Fixed3D;
                            string stt = imalist[st];
                            pic.Image = Image.FromFile(stt);
                 this.pictureBox1.Controls.Add(pic);
                //this.panel1.Controls.Add(pic);
                
                wi += 115;
                            if(wi>pictureBox1.Width)
                            {
                                wi = 10;
                                he += 115;
                            }
                           i++;
                
                   }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.One;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }

        private void slideShowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ok = true;
            pictureBox1.Controls.Clear();
            //panel1.Controls.Clear();
            pictureBox1.Show();
            //panel1.Show();
            p.Image = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void stimer_Elapsed(object sender, ElapsedEventArgs e)
        {
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ok = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ok = true;
            timer1.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
            //panel1.Controls.Clear();
        }
    }
}
