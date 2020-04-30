namespace GrowtopiaHack
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
            System.Windows.Forms.TabControl tabControl1;
            System.Windows.Forms.TabPage tabPage5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pathsave = new System.Windows.Forms.TextBox();
            this.processlabel = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rainbow1 = new System.Windows.Forms.Timer(this.components);
            this.rainbow2 = new System.Windows.Forms.Timer(this.components);
            this.rainbow3 = new System.Windows.Forms.Timer(this.components);
            this.end = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.prefix = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox36 = new System.Windows.Forms.CheckBox();
            this.nsrainbow = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.nlogo = new System.Windows.Forms.Label();
            this.hotkeys = new System.Windows.Forms.Timer(this.components);
            this.main2 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel4 = new MetroSuite.MetroLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl4 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.asdsd = new System.Windows.Forms.Timer(this.components);
            this.ChangeTitle = new System.Windows.Forms.Timer(this.components);
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage5 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage5);
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            tabControl1.Location = new System.Drawing.Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(512, 335);
            tabControl1.TabIndex = 189;
            tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage5
            // 
            tabPage5.AllowDrop = true;
            tabPage5.Controls.Add(this.tabControl2);
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new System.Drawing.Size(504, 307);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Wrong Decoder";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(15, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(622, 472);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage8
            // 
            this.tabPage8.AllowDrop = true;
            this.tabPage8.Controls.Add(this.button1);
            this.tabPage8.Controls.Add(this.richTextBox1);
            this.tabPage8.Controls.Add(this.label26);
            this.tabPage8.Controls.Add(this.button13);
            this.tabPage8.Controls.Add(this.button12);
            this.tabPage8.Controls.Add(this.button11);
            this.tabPage8.Controls.Add(this.pathsave);
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(614, 444);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.UseVisualStyleBackColor = true;
            this.tabPage8.Click += new System.EventHandler(this.tabPage8_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(374, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(368, 207);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(337, 7);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 15);
            this.label26.TabIndex = 6;
            this.label26.Text = "Text to Type:";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // button13
            // 
            this.button13.ForeColor = System.Drawing.Color.Blue;
            this.button13.Location = new System.Drawing.Point(374, 25);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(92, 23);
            this.button13.TabIndex = 4;
            this.button13.Text = "Your Save.Dat";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.ForeColor = System.Drawing.Color.Blue;
            this.button12.Location = new System.Drawing.Point(374, 76);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Refresh";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.ForeColor = System.Drawing.Color.Red;
            this.button11.Location = new System.Drawing.Point(374, 239);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 23);
            this.button11.TabIndex = 1;
            this.button11.Text = "Browse";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pathsave
            // 
            this.pathsave.AllowDrop = true;
            this.pathsave.Location = new System.Drawing.Point(3, 240);
            this.pathsave.Name = "pathsave";
            this.pathsave.Size = new System.Drawing.Size(356, 23);
            this.pathsave.TabIndex = 0;
            this.pathsave.Text = "C:\\Users\\Th\\AppData\\Local\\Growtopia";
            this.pathsave.TextChanged += new System.EventHandler(this.pathsave_TextChanged);
            // 
            // processlabel
            // 
            this.processlabel.Location = new System.Drawing.Point(0, 0);
            this.processlabel.Name = "processlabel";
            this.processlabel.Size = new System.Drawing.Size(100, 23);
            this.processlabel.TabIndex = 210;
            this.processlabel.Click += new System.EventHandler(this.processlabel_Click);
            // 
            // main
            // 
            this.main.Tick += new System.EventHandler(this.main_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rainbow1
            // 
            this.rainbow1.Tick += new System.EventHandler(this.rainbow1_Tick);
            // 
            // rainbow2
            // 
            this.rainbow2.Tick += new System.EventHandler(this.rainbow2_Tick);
            // 
            // rainbow3
            // 
            this.rainbow3.Tick += new System.EventHandler(this.rainbow3_Tick);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(0, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 23);
            this.end.TabIndex = 205;
            this.end.TextChanged += new System.EventHandler(this.end_TextChanged);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 206;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // prefix
            // 
            this.prefix.Location = new System.Drawing.Point(0, 0);
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(100, 23);
            this.prefix.TabIndex = 207;
            this.prefix.TextChanged += new System.EventHandler(this.prefix_TextChanged);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 208;
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 201;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 202;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 203;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 204;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox36
            // 
            this.checkBox36.Location = new System.Drawing.Point(0, 0);
            this.checkBox36.Name = "checkBox36";
            this.checkBox36.Size = new System.Drawing.Size(104, 24);
            this.checkBox36.TabIndex = 200;
            this.checkBox36.CheckedChanged += new System.EventHandler(this.checkBox36_CheckedChanged);
            // 
            // nsrainbow
            // 
            this.nsrainbow.Location = new System.Drawing.Point(0, 0);
            this.nsrainbow.Name = "nsrainbow";
            this.nsrainbow.Size = new System.Drawing.Size(104, 24);
            this.nsrainbow.TabIndex = 199;
            this.nsrainbow.CheckedChanged += new System.EventHandler(this.nsrainbow_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.Location = new System.Drawing.Point(0, 0);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(104, 24);
            this.checkBox18.TabIndex = 198;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // nlogo
            // 
            this.nlogo.Location = new System.Drawing.Point(0, 0);
            this.nlogo.Name = "nlogo";
            this.nlogo.Size = new System.Drawing.Size(100, 23);
            this.nlogo.TabIndex = 197;
            this.nlogo.Click += new System.EventHandler(this.nlogo_Click);
            // 
            // hotkeys
            // 
            this.hotkeys.Tick += new System.EventHandler(this.hotkeys_Tick);
            // 
            // main2
            // 
            this.main2.Tick += new System.EventHandler(this.main2_Tick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(834, 257);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 20);
            this.metroLabel4.TabIndex = 170;
            this.metroLabel4.Text = "About";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 196;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 195;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 194;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = null;
            this.bunifuDragControl3.Vertical = true;
            // 
            // bunifuDragControl4
            // 
            this.bunifuDragControl4.Fixed = true;
            this.bunifuDragControl4.Horizontal = true;
            this.bunifuDragControl4.TargetControl = null;
            this.bunifuDragControl4.Vertical = true;
            // 
            // asdsd
            // 
            this.asdsd.Tick += new System.EventHandler(this.asdsd_Tick);
            // 
            // ChangeTitle
            // 
            this.ChangeTitle.Enabled = true;
            this.ChangeTitle.Tick += new System.EventHandler(this.ChangeTitle_Tick);
            // 
            // Form1
            // 
            this.AccentColor = System.Drawing.Color.Gray;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 326);
            this.Controls.Add(tabControl1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.nlogo);
            this.Controls.Add(this.checkBox18);
            this.Controls.Add(this.nsrainbow);
            this.Controls.Add(this.checkBox36);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.prefix);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.processlabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.State = MetroSuite.MetroForm.FormState.Custom;
            this.Style = MetroSuite.Design.Style.Custom;
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label processlabel;
        private System.Windows.Forms.Timer main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer rainbow1;
        private System.Windows.Forms.Timer rainbow2;
        private System.Windows.Forms.Timer rainbow3;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox prefix;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox36;
        private System.Windows.Forms.CheckBox nsrainbow;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.Label nlogo;
        private System.Windows.Forms.Timer hotkeys;
        private System.Windows.Forms.Timer main2;
        private MetroSuite.MetroLabel metroLabel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl4;
        private System.Windows.Forms.Timer asdsd;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox pathsave;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Timer ChangeTitle;
        private System.Windows.Forms.Button button1;
    }
}

