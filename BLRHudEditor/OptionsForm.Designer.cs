namespace BLRHudEditor
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.autoFindRadioBtn = new System.Windows.Forms.RadioButton();
            this.customRadioBtn = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.saveOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autoFindRadioBtn
            // 
            this.autoFindRadioBtn.AutoSize = true;
            this.autoFindRadioBtn.Location = new System.Drawing.Point(12, 12);
            this.autoFindRadioBtn.Name = "autoFindRadioBtn";
            this.autoFindRadioBtn.Size = new System.Drawing.Size(67, 17);
            this.autoFindRadioBtn.TabIndex = 0;
            this.autoFindRadioBtn.TabStop = true;
            this.autoFindRadioBtn.Text = "Auto find";
            this.autoFindRadioBtn.UseVisualStyleBackColor = true;
            this.autoFindRadioBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateFolderPath);
            // 
            // customRadioBtn
            // 
            this.customRadioBtn.AutoSize = true;
            this.customRadioBtn.Location = new System.Drawing.Point(12, 61);
            this.customRadioBtn.Name = "customRadioBtn";
            this.customRadioBtn.Size = new System.Drawing.Size(60, 17);
            this.customRadioBtn.TabIndex = 1;
            this.customRadioBtn.TabStop = true;
            this.customRadioBtn.Text = "Custom";
            this.customRadioBtn.UseVisualStyleBackColor = true;
            this.customRadioBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateFolderPath);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(437, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(437, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // saveOptions
            // 
            this.saveOptions.Location = new System.Drawing.Point(12, 110);
            this.saveOptions.Name = "saveOptions";
            this.saveOptions.Size = new System.Drawing.Size(75, 23);
            this.saveOptions.TabIndex = 5;
            this.saveOptions.Text = "Save";
            this.saveOptions.UseVisualStyleBackColor = true;
            this.saveOptions.Click += new System.EventHandler(this.saveOptions_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 142);
            this.Controls.Add(this.saveOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customRadioBtn);
            this.Controls.Add(this.autoFindRadioBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton autoFindRadioBtn;
        private System.Windows.Forms.RadioButton customRadioBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveOptions;
    }
}