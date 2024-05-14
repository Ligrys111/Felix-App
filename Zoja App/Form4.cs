using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoja_App
{
    public partial class addAppForm : Form
    {
        Button Clicked;
        public static Form2 Games;
        public addAppForm()
        {
            
            InitializeComponent();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            if (addAppForm.Games.ClickedButton != null)
            {

                Clicked = addAppForm.Games.ClickedButton;
                if (Clicked.Tag != null)
                {
                    nameOfApp.Text = Clicked.Text;
                    command.Text = Clicked.Tag.ToString();
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            string appName = nameOfApp.Text;
            string appCommand = command.Text;
            Console.WriteLine(appName + " " + appCommand);
            if (appName.Length < 3)
            {
                MessageBox.Show("Nazwa musi mieć przynajmniej 3 znaki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (appCommand.Length < 3)
            {
                MessageBox.Show("Źródło musi mieć przynajmniej 3 znaki", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            string data = appName + "\t" + appCommand;
            if (Clicked != null)
            {
                string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + Games.formFile, Encoding.UTF8);
                string[] newLines = new string[lines.Length];
                int i = 0;
                foreach (string line in lines) 
                {
                Console.WriteLine(line);
                    if (line.StartsWith(Clicked.Text)){
                        newLines[i] = data;
                    }else
                    {
                        newLines[i] = line;
                    }

                    i++;
                }
                File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + Games.formFile, newLines);
               Console.WriteLine(newLines);
            }
            else { 
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + Games.formFile, true);
            sw.WriteLine(data);

            sw.Flush();
            sw.Close();
             }
           
            this.Close();

            Form2 form = new Form2();
            form.formFile = Games.formFile;
            form.Show();
            Games.Close();
           
        }
    }
}
