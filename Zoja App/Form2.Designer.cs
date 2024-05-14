namespace Zoja_App
{
    partial class Form2
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
            this.button2 = new System.Windows.Forms.Button();
            this.addAppBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wróć";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.backClick);
            // 
            // addAppBtn
            // 
            this.addAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.addAppBtn.Location = new System.Drawing.Point(15, 96);
            this.addAppBtn.Name = "addAppBtn";
            this.addAppBtn.Size = new System.Drawing.Size(75, 69);
            this.addAppBtn.TabIndex = 6;
            this.addAppBtn.Text = "+";
            this.addAppBtn.UseVisualStyleBackColor = true;
            this.addAppBtn.Click += new System.EventHandler(this.addNewBtn);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zoja_App.Properties.Resources.rfdsdf;
            this.ClientSize = new System.Drawing.Size(904, 502);
            this.Controls.Add(this.addAppBtn);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Felix App Games";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addAppBtn;
    }
}