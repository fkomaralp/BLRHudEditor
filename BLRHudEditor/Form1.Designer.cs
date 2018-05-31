namespace BLRHudEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SceneComboBox = new System.Windows.Forms.ComboBox();
            this.KilledPlayerInfoWidget = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.yrot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fov = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.disptime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.opacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Widgets";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BLRHudEditor.Properties.Resources._209870_20180529222532_1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 479);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Test);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scene";
            // 
            // SceneComboBox
            // 
            this.SceneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SceneComboBox.FormattingEnabled = true;
            this.SceneComboBox.Items.AddRange(new object[] {
            "Combat"});
            this.SceneComboBox.Location = new System.Drawing.Point(57, 36);
            this.SceneComboBox.Name = "SceneComboBox";
            this.SceneComboBox.Size = new System.Drawing.Size(100, 21);
            this.SceneComboBox.Sorted = true;
            this.SceneComboBox.TabIndex = 6;
            // 
            // KilledPlayerInfoWidget
            // 
            this.KilledPlayerInfoWidget.Location = new System.Drawing.Point(350, 270);
            this.KilledPlayerInfoWidget.Name = "KilledPlayerInfoWidget";
            this.KilledPlayerInfoWidget.Size = new System.Drawing.Size(155, 31);
            this.KilledPlayerInfoWidget.TabIndex = 7;
            this.KilledPlayerInfoWidget.Text = "KilledPlayerInfoWidget";
            this.KilledPlayerInfoWidget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KilledPlayerInfoWidget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KilledPlayerInfoWidget_MouseDown);
            this.KilledPlayerInfoWidget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KilledPlayerInfoWidget_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // yrot
            // 
            this.yrot.Location = new System.Drawing.Point(280, 69);
            this.yrot.Name = "yrot";
            this.yrot.Size = new System.Drawing.Size(47, 20);
            this.yrot.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Yrot";
            // 
            // fov
            // 
            this.fov.Location = new System.Drawing.Point(195, 69);
            this.fov.Name = "fov";
            this.fov.Size = new System.Drawing.Size(47, 20);
            this.fov.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "FOV";
            // 
            // disptime
            // 
            this.disptime.Location = new System.Drawing.Point(508, 69);
            this.disptime.Name = "disptime";
            this.disptime.Size = new System.Drawing.Size(47, 20);
            this.disptime.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Display Time";
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(382, 69);
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(47, 20);
            this.opacity.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Opacity";
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(601, 69);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(47, 20);
            this.scale.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(561, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Scale";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(491, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Use arrow keys to move widgets";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(32, 69);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(47, 20);
            this.x.TabIndex = 9;
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(105, 69);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(47, 20);
            this.y.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 585);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.disptime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.yrot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fov);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.x);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KilledPlayerInfoWidget);
            this.Controls.Add(this.SceneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BLR Hud Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SceneComboBox;
        private System.Windows.Forms.Label KilledPlayerInfoWidget;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox yrot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fov;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox disptime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox opacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox scale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.TextBox y;
    }
}

