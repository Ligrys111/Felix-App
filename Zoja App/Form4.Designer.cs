namespace Zoja_App
{
    partial class addAppForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nameOfApp = new System.Windows.Forms.TextBox();
            this.yesBtn = new System.Windows.Forms.Button();
            this.noBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.command = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameOfApp
            // 
            this.nameOfApp.Location = new System.Drawing.Point(34, 62);
            this.nameOfApp.Name = "nameOfApp";
            this.nameOfApp.Size = new System.Drawing.Size(192, 20);
            this.nameOfApp.TabIndex = 0;
            this.nameOfApp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yesBtn.Location = new System.Drawing.Point(151, 116);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 43);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Zapisz!";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // noBtn
            // 
            this.noBtn.BackColor = System.Drawing.Color.Red;
            this.noBtn.Location = new System.Drawing.Point(34, 116);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(75, 43);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "Jednak nie...";
            this.noBtn.UseVisualStyleBackColor = false;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chcesz zapisać?";
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(34, 90);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(192, 20);
            this.command.TabIndex = 4;
            // 
            // addAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 165);
            this.Controls.Add(this.command);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.nameOfApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAppForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox nameOfApp;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox command;
    }
}