using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace Karesz
{
	partial class Form1
	{
        public Form1()
		{
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-us");
            InitializeComponent();
            Saját_InitializeComponent();
		}

        void InitializeComponent()
        {
            this.monitorpanel2 = new System.Windows.Forms.Panel();
            this.keyCountText = new System.Windows.Forms.Label();
            this.helpgomb = new System.Windows.Forms.Button();
            this.stepgomb = new System.Windows.Forms.Button();
            this.pausegomb = new System.Windows.Forms.Button();
            this.várakozásidő_updown = new System.Windows.Forms.NumericUpDown();
            this.várakozásidő_slider = new System.Windows.Forms.TrackBar();
            this.pályagomb = new System.Windows.Forms.Button();
            this.pályatextbox = new System.Windows.Forms.TextBox();
            this.robotnévlabel = new System.Windows.Forms.Label();
            this.következőrobotgomb = new System.Windows.Forms.Button();
            this.elozorobotgomb = new System.Windows.Forms.Button();
            this.startgomb2 = new System.Windows.Forms.Button();
            this.várakozási_időbox = new System.Windows.Forms.GroupBox();
            this.robotbox = new System.Windows.Forms.GroupBox();
            this.karesznagyításkeret = new System.Windows.Forms.PictureBox();
            this.mivanalattamnagyításkeret = new System.Windows.Forms.PictureBox();
            this.pályabox = new System.Windows.Forms.GroupBox();
            this.legacycheck = new System.Windows.Forms.CheckBox();
            this.resetgomb = new System.Windows.Forms.Button();
            this.mivanitttextbox = new System.Windows.Forms.TextBox();
            this.mivanalattamlabel = new System.Windows.Forms.Label();
            this.pozícióYtextbox = new System.Windows.Forms.TextBox();
            this.pozícióXtextbox = new System.Windows.Forms.TextBox();
            this.zsebeibenlabel = new System.Windows.Forms.Label();
            this.hótextbox = new System.Windows.Forms.TextBox();
            this.sárgatextbox = new System.Windows.Forms.TextBox();
            this.hólabel = new System.Windows.Forms.Label();
            this.sárgalabel = new System.Windows.Forms.Label();
            this.zöldtextbox = new System.Windows.Forms.TextBox();
            this.pirostextbox = new System.Windows.Forms.TextBox();
            this.feketetextbox = new System.Windows.Forms.TextBox();
            this.zöldlabel = new System.Windows.Forms.Label();
            this.piroslabel = new System.Windows.Forms.Label();
            this.feketelabel = new System.Windows.Forms.Label();
            this.ultrahangtextbox = new System.Windows.Forms.TextBox();
            this.hőtextbox = new System.Windows.Forms.TextBox();
            this.ultrahanglabel = new System.Windows.Forms.Label();
            this.hőmérsékletlabel = new System.Windows.Forms.Label();
            this.pozíciólabel = new System.Windows.Forms.Label();
            this.monitorpanel1 = new System.Windows.Forms.Panel();
            this.képkeret = new System.Windows.Forms.PictureBox();
            this.keyCount = new System.Windows.Forms.TextBox();
            this.monitorpanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.várakozásidő_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.várakozásidő_slider)).BeginInit();
            this.robotbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.karesznagyításkeret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mivanalattamnagyításkeret)).BeginInit();
            this.pályabox.SuspendLayout();
            this.monitorpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.képkeret)).BeginInit();
            this.SuspendLayout();
            // 
            // monitorpanel2
            // 
            this.monitorpanel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.monitorpanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorpanel2.Controls.Add(this.keyCount);
            this.monitorpanel2.Controls.Add(this.keyCountText);
            this.monitorpanel2.Controls.Add(this.helpgomb);
            this.monitorpanel2.Controls.Add(this.stepgomb);
            this.monitorpanel2.Controls.Add(this.pausegomb);
            this.monitorpanel2.Controls.Add(this.várakozásidő_updown);
            this.monitorpanel2.Controls.Add(this.várakozásidő_slider);
            this.monitorpanel2.Controls.Add(this.pályagomb);
            this.monitorpanel2.Controls.Add(this.pályatextbox);
            this.monitorpanel2.Controls.Add(this.robotnévlabel);
            this.monitorpanel2.Controls.Add(this.következőrobotgomb);
            this.monitorpanel2.Controls.Add(this.elozorobotgomb);
            this.monitorpanel2.Controls.Add(this.startgomb2);
            this.monitorpanel2.Controls.Add(this.várakozási_időbox);
            this.monitorpanel2.Controls.Add(this.robotbox);
            this.monitorpanel2.Controls.Add(this.pályabox);
            this.monitorpanel2.Location = new System.Drawing.Point(997, 35);
            this.monitorpanel2.Name = "monitorpanel2";
            this.monitorpanel2.Size = new System.Drawing.Size(159, 743);
            this.monitorpanel2.TabIndex = 2;
            // 
            // keyCountText
            // 
            this.keyCountText.AutoSize = true;
            this.keyCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.keyCountText.Location = new System.Drawing.Point(11, 354);
            this.keyCountText.Name = "keyCountText";
            this.keyCountText.Size = new System.Drawing.Size(64, 17);
            this.keyCountText.TabIndex = 37;
            this.keyCountText.Text = "Kulcsok";
            // 
            // helpgomb
            // 
            this.helpgomb.Location = new System.Drawing.Point(6, 713);
            this.helpgomb.Name = "helpgomb";
            this.helpgomb.Size = new System.Drawing.Size(145, 23);
            this.helpgomb.TabIndex = 47;
            this.helpgomb.Text = "Felület használása (help)";
            this.helpgomb.UseVisualStyleBackColor = true;
            this.helpgomb.Click += new System.EventHandler(this.helpgomb_Click);
            // 
            // stepgomb
            // 
            this.stepgomb.Image = global::Karesz.Properties.Resources.step;
            this.stepgomb.Location = new System.Drawing.Point(79, 56);
            this.stepgomb.Name = "stepgomb";
            this.stepgomb.Size = new System.Drawing.Size(69, 43);
            this.stepgomb.TabIndex = 42;
            this.stepgomb.UseVisualStyleBackColor = true;
            this.stepgomb.Click += new System.EventHandler(this.stepgomb_Click);
            // 
            // pausegomb
            // 
            this.pausegomb.Image = global::Karesz.Properties.Resources.pause;
            this.pausegomb.Location = new System.Drawing.Point(9, 56);
            this.pausegomb.Name = "pausegomb";
            this.pausegomb.Size = new System.Drawing.Size(67, 43);
            this.pausegomb.TabIndex = 40;
            this.pausegomb.UseVisualStyleBackColor = true;
            this.pausegomb.Click += new System.EventHandler(this.pausegomb_Click);
            // 
            // várakozásidő_updown
            // 
            this.várakozásidő_updown.BackColor = System.Drawing.SystemColors.Window;
            this.várakozásidő_updown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.várakozásidő_updown.Location = new System.Drawing.Point(17, 148);
            this.várakozásidő_updown.Name = "várakozásidő_updown";
            this.várakozásidő_updown.Size = new System.Drawing.Size(126, 20);
            this.várakozásidő_updown.TabIndex = 39;
            this.várakozásidő_updown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.várakozásidő_updown.ValueChanged += new System.EventHandler(this.várakozásidő_updown_ValueChanged);
            // 
            // várakozásidő_slider
            // 
            this.várakozásidő_slider.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.várakozásidő_slider.Location = new System.Drawing.Point(9, 123);
            this.várakozásidő_slider.Maximum = 100;
            this.várakozásidő_slider.Name = "várakozásidő_slider";
            this.várakozásidő_slider.Size = new System.Drawing.Size(139, 45);
            this.várakozásidő_slider.TabIndex = 38;
            this.várakozásidő_slider.Value = 100;
            this.várakozásidő_slider.Scroll += new System.EventHandler(this.várakozásidő_slider_Scroll);
            // 
            // pályagomb
            // 
            this.pályagomb.Location = new System.Drawing.Point(80, 654);
            this.pályagomb.Name = "pályagomb";
            this.pályagomb.Size = new System.Drawing.Size(68, 26);
            this.pályagomb.TabIndex = 32;
            this.pályagomb.Text = "betölt";
            this.pályagomb.UseVisualStyleBackColor = true;
            this.pályagomb.Click += new System.EventHandler(this.pályagomb_Click);
            // 
            // pályatextbox
            // 
            this.pályatextbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pályatextbox.Location = new System.Drawing.Point(11, 629);
            this.pályatextbox.Name = "pályatextbox";
            this.pályatextbox.Size = new System.Drawing.Size(136, 20);
            this.pályatextbox.TabIndex = 31;
            this.pályatextbox.Text = "palya01.txt";
            this.pályatextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pályatextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pályatextbox_KeyDown);
            // 
            // robotnévlabel
            // 
            this.robotnévlabel.AutoSize = true;
            this.robotnévlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.robotnévlabel.Location = new System.Drawing.Point(41, 199);
            this.robotnévlabel.Name = "robotnévlabel";
            this.robotnévlabel.Size = new System.Drawing.Size(75, 20);
            this.robotnévlabel.TabIndex = 3;
            this.robotnévlabel.Text = "0. Karesz";
            this.robotnévlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // következőrobotgomb
            // 
            this.következőrobotgomb.Image = global::Karesz.Properties.Resources.forward;
            this.következőrobotgomb.Location = new System.Drawing.Point(83, 221);
            this.következőrobotgomb.Name = "következőrobotgomb";
            this.következőrobotgomb.Size = new System.Drawing.Size(65, 43);
            this.következőrobotgomb.TabIndex = 2;
            this.következőrobotgomb.UseVisualStyleBackColor = true;
            this.következőrobotgomb.Click += new System.EventHandler(this.következőrobotgomb_Click);
            // 
            // elozorobotgomb
            // 
            this.elozorobotgomb.AccessibleName = "";
            this.elozorobotgomb.Image = global::Karesz.Properties.Resources.back;
            this.elozorobotgomb.Location = new System.Drawing.Point(10, 221);
            this.elozorobotgomb.Name = "elozorobotgomb";
            this.elozorobotgomb.Size = new System.Drawing.Size(66, 43);
            this.elozorobotgomb.TabIndex = 1;
            this.elozorobotgomb.UseVisualStyleBackColor = true;
            this.elozorobotgomb.Click += new System.EventHandler(this.elozorobotgomb_Click);
            // 
            // startgomb2
            // 
            this.startgomb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startgomb2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startgomb2.Image = global::Karesz.Properties.Resources.play;
            this.startgomb2.Location = new System.Drawing.Point(9, 7);
            this.startgomb2.Name = "startgomb2";
            this.startgomb2.Size = new System.Drawing.Size(140, 43);
            this.startgomb2.TabIndex = 0;
            this.startgomb2.UseVisualStyleBackColor = true;
            this.startgomb2.Click += new System.EventHandler(this.startgomb2_Click);
            // 
            // várakozási_időbox
            // 
            this.várakozási_időbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.várakozási_időbox.Location = new System.Drawing.Point(6, 102);
            this.várakozási_időbox.Name = "várakozási_időbox";
            this.várakozási_időbox.Size = new System.Drawing.Size(145, 79);
            this.várakozási_időbox.TabIndex = 44;
            this.várakozási_időbox.TabStop = false;
            this.várakozási_időbox.Text = "várakozási idő";
            // 
            // robotbox
            // 
            this.robotbox.Controls.Add(this.karesznagyításkeret);
            this.robotbox.Controls.Add(this.mivanalattamnagyításkeret);
            this.robotbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.robotbox.Location = new System.Drawing.Point(6, 185);
            this.robotbox.Name = "robotbox";
            this.robotbox.Size = new System.Drawing.Size(145, 160);
            this.robotbox.TabIndex = 45;
            this.robotbox.TabStop = false;
            this.robotbox.Text = "robot";
            // 
            // karesznagyításkeret
            // 
            this.karesznagyításkeret.Location = new System.Drawing.Point(5, 85);
            this.karesznagyításkeret.Name = "karesznagyításkeret";
            this.karesznagyításkeret.Size = new System.Drawing.Size(64, 64);
            this.karesznagyításkeret.TabIndex = 12;
            this.karesznagyításkeret.TabStop = false;
            this.karesznagyításkeret.Click += new System.EventHandler(this.karesznagyításkeret_Click);
            // 
            // mivanalattamnagyításkeret
            // 
            this.mivanalattamnagyításkeret.BackColor = System.Drawing.Color.White;
            this.mivanalattamnagyításkeret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mivanalattamnagyításkeret.Location = new System.Drawing.Point(77, 85);
            this.mivanalattamnagyításkeret.Name = "mivanalattamnagyításkeret";
            this.mivanalattamnagyításkeret.Size = new System.Drawing.Size(64, 64);
            this.mivanalattamnagyításkeret.TabIndex = 37;
            this.mivanalattamnagyításkeret.TabStop = false;
            this.mivanalattamnagyításkeret.Paint += new System.Windows.Forms.PaintEventHandler(this.mivanalattamnagyításkeret_Paint);
            // 
            // pályabox
            // 
            this.pályabox.Controls.Add(this.legacycheck);
            this.pályabox.Controls.Add(this.resetgomb);
            this.pályabox.Location = new System.Drawing.Point(6, 612);
            this.pályabox.Name = "pályabox";
            this.pályabox.Size = new System.Drawing.Size(145, 97);
            this.pályabox.TabIndex = 46;
            this.pályabox.TabStop = false;
            this.pályabox.Text = "pálya";
            // 
            // legacycheck
            // 
            this.legacycheck.AutoSize = true;
            this.legacycheck.Location = new System.Drawing.Point(58, 73);
            this.legacycheck.Name = "legacycheck";
            this.legacycheck.Size = new System.Drawing.Size(84, 17);
            this.legacycheck.TabIndex = 48;
            this.legacycheck.Text = "Legacy mód";
            this.legacycheck.UseVisualStyleBackColor = true;
            // 
            // resetgomb
            // 
            this.resetgomb.Location = new System.Drawing.Point(4, 42);
            this.resetgomb.Name = "resetgomb";
            this.resetgomb.Size = new System.Drawing.Size(69, 26);
            this.resetgomb.TabIndex = 48;
            this.resetgomb.Text = "reset";
            this.resetgomb.UseVisualStyleBackColor = true;
            this.resetgomb.Click += new System.EventHandler(this.resetgomb_Click);
            // 
            // mivanitttextbox
            // 
            this.mivanitttextbox.Location = new System.Drawing.Point(420, 2);
            this.mivanitttextbox.Name = "mivanitttextbox";
            this.mivanitttextbox.Size = new System.Drawing.Size(64, 20);
            this.mivanitttextbox.TabIndex = 36;
            this.mivanitttextbox.Text = "semmi";
            this.mivanitttextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mivanalattamlabel
            // 
            this.mivanalattamlabel.AutoSize = true;
            this.mivanalattamlabel.Location = new System.Drawing.Point(361, 5);
            this.mivanalattamlabel.Name = "mivanalattamlabel";
            this.mivanalattamlabel.Size = new System.Drawing.Size(53, 13);
            this.mivanalattamlabel.TabIndex = 35;
            this.mivanalattamlabel.Text = "Mi van itt:";
            // 
            // pozícióYtextbox
            // 
            this.pozícióYtextbox.Location = new System.Drawing.Point(92, 2);
            this.pozícióYtextbox.Name = "pozícióYtextbox";
            this.pozícióYtextbox.Size = new System.Drawing.Size(31, 20);
            this.pozícióYtextbox.TabIndex = 34;
            this.pozícióYtextbox.Text = "5";
            this.pozícióYtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pozícióXtextbox
            // 
            this.pozícióXtextbox.Location = new System.Drawing.Point(55, 2);
            this.pozícióXtextbox.Name = "pozícióXtextbox";
            this.pozícióXtextbox.Size = new System.Drawing.Size(31, 20);
            this.pozícióXtextbox.TabIndex = 33;
            this.pozícióXtextbox.Text = "12";
            this.pozícióXtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zsebeibenlabel
            // 
            this.zsebeibenlabel.AutoSize = true;
            this.zsebeibenlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zsebeibenlabel.Location = new System.Drawing.Point(495, 5);
            this.zsebeibenlabel.Name = "zsebeibenlabel";
            this.zsebeibenlabel.Size = new System.Drawing.Size(89, 13);
            this.zsebeibenlabel.TabIndex = 28;
            this.zsebeibenlabel.Text = "Bezsebelt kövek:";
            // 
            // hótextbox
            // 
            this.hótextbox.Location = new System.Drawing.Point(1082, 2);
            this.hótextbox.Name = "hótextbox";
            this.hótextbox.Size = new System.Drawing.Size(64, 20);
            this.hótextbox.TabIndex = 26;
            this.hótextbox.Text = "5";
            this.hótextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sárgatextbox
            // 
            this.sárgatextbox.Location = new System.Drawing.Point(984, 2);
            this.sárgatextbox.Name = "sárgatextbox";
            this.sárgatextbox.Size = new System.Drawing.Size(64, 20);
            this.sárgatextbox.TabIndex = 25;
            this.sárgatextbox.Text = "13";
            this.sárgatextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hólabel
            // 
            this.hólabel.AutoSize = true;
            this.hólabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hólabel.ForeColor = System.Drawing.Color.White;
            this.hólabel.Location = new System.Drawing.Point(1052, 3);
            this.hólabel.Name = "hólabel";
            this.hólabel.Size = new System.Drawing.Size(26, 17);
            this.hólabel.TabIndex = 23;
            this.hólabel.Text = "hó";
            // 
            // sárgalabel
            // 
            this.sárgalabel.AutoSize = true;
            this.sárgalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sárgalabel.ForeColor = System.Drawing.Color.Yellow;
            this.sárgalabel.Location = new System.Drawing.Point(932, 3);
            this.sárgalabel.Name = "sárgalabel";
            this.sárgalabel.Size = new System.Drawing.Size(49, 17);
            this.sárgalabel.TabIndex = 22;
            this.sárgalabel.Text = "sárga";
            // 
            // zöldtextbox
            // 
            this.zöldtextbox.Location = new System.Drawing.Point(866, 2);
            this.zöldtextbox.Name = "zöldtextbox";
            this.zöldtextbox.Size = new System.Drawing.Size(64, 20);
            this.zöldtextbox.TabIndex = 21;
            this.zöldtextbox.Text = "17";
            this.zöldtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pirostextbox
            // 
            this.pirostextbox.Location = new System.Drawing.Point(758, 2);
            this.pirostextbox.Name = "pirostextbox";
            this.pirostextbox.Size = new System.Drawing.Size(64, 20);
            this.pirostextbox.TabIndex = 20;
            this.pirostextbox.Text = "10";
            this.pirostextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feketetextbox
            // 
            this.feketetextbox.Location = new System.Drawing.Point(643, 2);
            this.feketetextbox.Name = "feketetextbox";
            this.feketetextbox.Size = new System.Drawing.Size(64, 20);
            this.feketetextbox.TabIndex = 19;
            this.feketetextbox.Text = "20";
            this.feketetextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zöldlabel
            // 
            this.zöldlabel.AutoSize = true;
            this.zöldlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zöldlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.zöldlabel.Location = new System.Drawing.Point(825, 3);
            this.zöldlabel.Name = "zöldlabel";
            this.zöldlabel.Size = new System.Drawing.Size(37, 17);
            this.zöldlabel.TabIndex = 18;
            this.zöldlabel.Text = "szín";
            // 
            // piroslabel
            // 
            this.piroslabel.AutoSize = true;
            this.piroslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.piroslabel.ForeColor = System.Drawing.Color.Red;
            this.piroslabel.Location = new System.Drawing.Point(710, 3);
            this.piroslabel.Name = "piroslabel";
            this.piroslabel.Size = new System.Drawing.Size(44, 17);
            this.piroslabel.TabIndex = 17;
            this.piroslabel.Text = "piros";
            // 
            // feketelabel
            // 
            this.feketelabel.AutoSize = true;
            this.feketelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feketelabel.Location = new System.Drawing.Point(586, 3);
            this.feketelabel.Name = "feketelabel";
            this.feketelabel.Size = new System.Drawing.Size(53, 17);
            this.feketelabel.TabIndex = 16;
            this.feketelabel.Text = "fekete";
            // 
            // ultrahangtextbox
            // 
            this.ultrahangtextbox.Location = new System.Drawing.Point(291, 2);
            this.ultrahangtextbox.Name = "ultrahangtextbox";
            this.ultrahangtextbox.Size = new System.Drawing.Size(64, 20);
            this.ultrahangtextbox.TabIndex = 15;
            this.ultrahangtextbox.Text = "17";
            this.ultrahangtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hőtextbox
            // 
            this.hőtextbox.Location = new System.Drawing.Point(159, 2);
            this.hőtextbox.Name = "hőtextbox";
            this.hőtextbox.Size = new System.Drawing.Size(64, 20);
            this.hőtextbox.TabIndex = 14;
            this.hőtextbox.Text = "200";
            this.hőtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ultrahanglabel
            // 
            this.ultrahanglabel.AutoSize = true;
            this.ultrahanglabel.Location = new System.Drawing.Point(229, 5);
            this.ultrahanglabel.Name = "ultrahanglabel";
            this.ultrahanglabel.Size = new System.Drawing.Size(56, 13);
            this.ultrahanglabel.TabIndex = 10;
            this.ultrahanglabel.Text = "Ultrahang:";
            // 
            // hőmérsékletlabel
            // 
            this.hőmérsékletlabel.AutoSize = true;
            this.hőmérsékletlabel.Location = new System.Drawing.Point(129, 5);
            this.hőmérsékletlabel.Name = "hőmérsékletlabel";
            this.hőmérsékletlabel.Size = new System.Drawing.Size(24, 13);
            this.hőmérsékletlabel.TabIndex = 8;
            this.hőmérsékletlabel.Text = "Hő:";
            // 
            // pozíciólabel
            // 
            this.pozíciólabel.AutoSize = true;
            this.pozíciólabel.Location = new System.Drawing.Point(3, 5);
            this.pozíciólabel.Name = "pozíciólabel";
            this.pozíciólabel.Size = new System.Drawing.Size(49, 13);
            this.pozíciólabel.TabIndex = 6;
            this.pozíciólabel.Text = "Pozíció: ";
            // 
            // monitorpanel1
            // 
            this.monitorpanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.monitorpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monitorpanel1.Controls.Add(this.pozíciólabel);
            this.monitorpanel1.Controls.Add(this.pozícióXtextbox);
            this.monitorpanel1.Controls.Add(this.pozícióYtextbox);
            this.monitorpanel1.Controls.Add(this.hőmérsékletlabel);
            this.monitorpanel1.Controls.Add(this.hőtextbox);
            this.monitorpanel1.Controls.Add(this.mivanitttextbox);
            this.monitorpanel1.Controls.Add(this.ultrahanglabel);
            this.monitorpanel1.Controls.Add(this.mivanalattamlabel);
            this.monitorpanel1.Controls.Add(this.hótextbox);
            this.monitorpanel1.Controls.Add(this.zsebeibenlabel);
            this.monitorpanel1.Controls.Add(this.hólabel);
            this.monitorpanel1.Controls.Add(this.sárgatextbox);
            this.monitorpanel1.Controls.Add(this.ultrahangtextbox);
            this.monitorpanel1.Controls.Add(this.feketelabel);
            this.monitorpanel1.Controls.Add(this.sárgalabel);
            this.monitorpanel1.Controls.Add(this.feketetextbox);
            this.monitorpanel1.Controls.Add(this.zöldtextbox);
            this.monitorpanel1.Controls.Add(this.piroslabel);
            this.monitorpanel1.Controls.Add(this.zöldlabel);
            this.monitorpanel1.Controls.Add(this.pirostextbox);
            this.monitorpanel1.Location = new System.Drawing.Point(5, 3);
            this.monitorpanel1.Name = "monitorpanel1";
            this.monitorpanel1.Size = new System.Drawing.Size(1151, 26);
            this.monitorpanel1.TabIndex = 1;
            // 
            // képkeret
            // 
            this.képkeret.BackColor = System.Drawing.Color.LightGray;
            this.képkeret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.képkeret.Cursor = System.Windows.Forms.Cursors.Cross;
            this.képkeret.Location = new System.Drawing.Point(5, 35);
            this.képkeret.Name = "képkeret";
            this.képkeret.Size = new System.Drawing.Size(984, 744);
            this.képkeret.TabIndex = 0;
            this.képkeret.TabStop = false;
            this.képkeret.Paint += new System.Windows.Forms.PaintEventHandler(this.képkeret_Paint);
            this.képkeret.MouseDown += new System.Windows.Forms.MouseEventHandler(this.képkeret_MouseDown);
            // 
            // keyCount
            // 
            this.keyCount.Location = new System.Drawing.Point(12, 374);
            this.keyCount.Name = "keyCount";
            this.keyCount.Size = new System.Drawing.Size(64, 20);
            this.keyCount.TabIndex = 37;
            this.keyCount.Text = "0";
            this.keyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1160, 783);
            this.Controls.Add(this.monitorpanel1);
            this.Controls.Add(this.monitorpanel2);
            this.Controls.Add(this.képkeret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karesz+";
            this.monitorpanel2.ResumeLayout(false);
            this.monitorpanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.várakozásidő_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.várakozásidő_slider)).EndInit();
            this.robotbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.karesznagyításkeret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mivanalattamnagyításkeret)).EndInit();
            this.pályabox.ResumeLayout(false);
            this.pályabox.PerformLayout();
            this.monitorpanel1.ResumeLayout(false);
            this.monitorpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.képkeret)).EndInit();
            this.ResumeLayout(false);

        }

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

        private PictureBox képkeret;
        private Panel monitorpanel2;
        private Button startgomb2;
        private Button következőrobotgomb;
        private Button elozorobotgomb;
        private Label robotnévlabel;
        private Label pozíciólabel;
        private Label hőmérsékletlabel;
        private Label zsebeibenlabel;
        private TextBox hótextbox;
        private TextBox sárgatextbox;
        private Label hólabel;
        private Label sárgalabel;
        private TextBox zöldtextbox;
        private TextBox pirostextbox;
        private TextBox feketetextbox;
        private Label zöldlabel;
        private Label piroslabel;
        private Label feketelabel;
        private TextBox ultrahangtextbox;
        private TextBox hőtextbox;
        private PictureBox karesznagyításkeret;
        private Label ultrahanglabel;
        private Button pályagomb;
        private TextBox pályatextbox;
        private TextBox pozícióYtextbox;
        private TextBox pozícióXtextbox;
        private PictureBox mivanalattamnagyításkeret;
        private TextBox mivanitttextbox;
        private Label mivanalattamlabel;
        private NumericUpDown várakozásidő_updown;
        private TrackBar várakozásidő_slider;
        private Button pausegomb;
        private Panel monitorpanel1;
        private Button stepgomb;
        private GroupBox várakozási_időbox;
        private GroupBox robotbox;
        private GroupBox pályabox;
        private Button helpgomb;
        private Button resetgomb;
        private CheckBox legacycheck;
        private Label keyCountText;
        private TextBox keyCount;
    }
}