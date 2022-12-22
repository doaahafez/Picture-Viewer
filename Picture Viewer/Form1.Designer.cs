namespace for_test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2_choose_images = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.im_lst = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleElectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mutiSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slideShowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.single_select = new System.Windows.Forms.Button();
            this.multi_select = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2_choose_images
            // 
            this.button2_choose_images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2_choose_images.ForeColor = System.Drawing.Color.Red;
            this.button2_choose_images.Location = new System.Drawing.Point(184, 414);
            this.button2_choose_images.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2_choose_images.Name = "button2_choose_images";
            this.button2_choose_images.Size = new System.Drawing.Size(312, 60);
            this.button2_choose_images.TabIndex = 7;
            this.button2_choose_images.Text = "Choose Images ";
            this.toolTip1.SetToolTip(this.button2_choose_images, "choose images from browser");
            this.button2_choose_images.UseVisualStyleBackColor = false;
            this.button2_choose_images.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(14, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "* List of image names you selected :  ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt|jpg files(*.jpg)|*.jpg|png files(*.pn" +
    "g)|*.png";
            this.ofd.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // im_lst
            // 
            this.im_lst.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.im_lst.ImageSize = new System.Drawing.Size(256, 256);
            this.im_lst.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modesToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exiteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 58);
            // 
            // modesToolStripMenuItem1
            // 
            this.modesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleElectToolStripMenuItem,
            this.mutiSelectToolStripMenuItem,
            this.slideShowToolStripMenuItem1});
            this.modesToolStripMenuItem1.Name = "modesToolStripMenuItem1";
            this.modesToolStripMenuItem1.Size = new System.Drawing.Size(123, 24);
            this.modesToolStripMenuItem1.Text = "Modes";
            // 
            // singleElectToolStripMenuItem
            // 
            this.singleElectToolStripMenuItem.Name = "singleElectToolStripMenuItem";
            this.singleElectToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.singleElectToolStripMenuItem.Text = "Single Picture Select";
            this.singleElectToolStripMenuItem.Click += new System.EventHandler(this.singleElectToolStripMenuItem_Click);
            // 
            // mutiSelectToolStripMenuItem
            // 
            this.mutiSelectToolStripMenuItem.Name = "mutiSelectToolStripMenuItem";
            this.mutiSelectToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.mutiSelectToolStripMenuItem.Text = "Multi Picture Select";
            this.mutiSelectToolStripMenuItem.Click += new System.EventHandler(this.mutiSelectToolStripMenuItem_Click);
            // 
            // slideShowToolStripMenuItem1
            // 
            this.slideShowToolStripMenuItem1.Name = "slideShowToolStripMenuItem1";
            this.slideShowToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.slideShowToolStripMenuItem1.Text = "Slide Show";
            this.slideShowToolStripMenuItem1.Click += new System.EventHandler(this.slideShowToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // exiteToolStripMenuItem
            // 
            this.exiteToolStripMenuItem.Name = "exiteToolStripMenuItem";
            this.exiteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.exiteToolStripMenuItem.Text = "Exit";
            this.exiteToolStripMenuItem.Click += new System.EventHandler(this.exiteToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(9, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(690, 244);
            this.listBox1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.listBox1, "right click to choose a mode of show you want");
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // single_select
            // 
            this.single_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.single_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.single_select.Location = new System.Drawing.Point(105, 340);
            this.single_select.Name = "single_select";
            this.single_select.Size = new System.Drawing.Size(154, 51);
            this.single_select.TabIndex = 20;
            this.single_select.Text = "single select";
            this.toolTip1.SetToolTip(this.single_select, "selected one image");
            this.single_select.UseVisualStyleBackColor = false;
            this.single_select.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // multi_select
            // 
            this.multi_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multi_select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.multi_select.Location = new System.Drawing.Point(268, 340);
            this.multi_select.Name = "multi_select";
            this.multi_select.Size = new System.Drawing.Size(152, 51);
            this.multi_select.TabIndex = 21;
            this.multi_select.Text = "multi select";
            this.toolTip1.SetToolTip(this.multi_select, "selected more image you want to show");
            this.multi_select.UseVisualStyleBackColor = false;
            this.multi_select.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 578);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusBar1.Size = new System.Drawing.Size(1208, 31);
            this.statusBar1.TabIndex = 27;
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(433, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "stop slide show";
            this.toolTip1.SetToolTip(this.button1, "to stop slide show if you want to show");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(184, 496);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 60);
            this.button3.TabIndex = 31;
            this.button3.Text = "Clear Images ";
            this.toolTip1.SetToolTip(this.button3, "clear images from picture");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(733, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 560);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1208, 609);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.multi_select);
            this.Controls.Add(this.single_select);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2_choose_images);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2_choose_images;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList im_lst;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleElectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mutiSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slideShowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exiteToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button single_select;
        private System.Windows.Forms.Button multi_select;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

