namespace Zoja_App
{
    partial class formMenu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.other = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listmenager = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fortniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minecraftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(614, 141);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(278, 349);
            this.other.TabIndex = 2;
            this.other.Text = "inne";
            this.other.UseVisualStyleBackColor = true;
            this.other.Click += new System.EventHandler(this.otherClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(227, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz co chcesz zrobić?";
            // 
            // listmenager
            // 
            this.listmenager.HideSelection = false;
            this.listmenager.Location = new System.Drawing.Point(900, 51);
            this.listmenager.Name = "listmenager";
            this.listmenager.Size = new System.Drawing.Size(207, 439);
            this.listmenager.TabIndex = 5;
            this.listmenager.UseCompatibleStateImageBehavior = false;
            this.listmenager.Click += new System.EventHandler(this.listmenagerItemClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.button4.Location = new System.Drawing.Point(851, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "↻";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.refreshClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button2.Image = global::Zoja_App.Properties.Resources.source;
            this.button2.Location = new System.Drawing.Point(316, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 349);
            this.button2.TabIndex = 1;
            this.button2.Text = "Muzyka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.formMusicClick);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Image = global::Zoja_App.Properties.Resources.aitubo_1710271637514;
            this.button1.Location = new System.Drawing.Point(12, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 349);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.formGamesClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fortniteToolStripMenuItem,
            this.minecraftToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // fortniteToolStripMenuItem
            // 
            this.fortniteToolStripMenuItem.Name = "fortniteToolStripMenuItem";
            this.fortniteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.fortniteToolStripMenuItem.Text = "fortnite";
            // 
            // minecraftToolStripMenuItem
            // 
            this.minecraftToolStripMenuItem.Name = "minecraftToolStripMenuItem";
            this.minecraftToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.minecraftToolStripMenuItem.Text = "minecraft";
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 502);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listmenager);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.other);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "formMenu";
            this.Text = "Felix App";
            this.Load += new System.EventHandler(this.formMenuLoad);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button other;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listmenager;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fortniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minecraftToolStripMenuItem;
    }
}

