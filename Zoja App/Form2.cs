using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zoja_App
{
    public partial class Form2 : Form
    {

        public string formName;
        public string formFile = "data.txt";

        ContextMenuStrip menu = new ContextMenuStrip();
        
        
        const string EDIT = "Edytuj";
        const string REMOVE = "Usuń";
        public Button ClickedButton;
        public Form2()
        {
            InitializeComponent();

            menu.Items.Add(EDIT);
            menu.Items.Add(REMOVE);

            menu.ItemClicked += menuItemClicked;
        }

        private void menuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

            if (e.ClickedItem.ToString() == EDIT)
            {

                Form addBtnHasClicked = new addAppForm();
                addAppForm.Games = this;

                addBtnHasClicked.Show();

            }
            else
            {
                string data =ClickedButton.Text +"\t" + ClickedButton.Tag;
                this.Controls.Remove(ClickedButton);
                string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + formFile, Encoding.UTF8);
                string[] newLines = new string[lines.Length -1];
                int i = 0;
                foreach (string line in lines)
                {
                    
                    Console.WriteLine(line);
                    if (!line.StartsWith(ClickedButton.Text))
                    {
                       
                        newLines[i++] = line;

                        
                    }
                    
                    

                    
                }
               
                File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + formFile, newLines);
                Form2 form = new Form2();
                form.formFile = formFile;
                form.Show();
                this.Close();
                
            }
        }

        

        private void backClick(object sender, EventArgs e)
        {
            formMenu form1 = new formMenu();
            form1.Show();

            this.Close();
        }

        
        public void Form2_Load(object sender, EventArgs e)
        {
            
            int i = 0;
            int j = 1;
            int l = 11;
            int w = 76;
            int h = 69;
            int s = 80;
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + formFile))
            {
             var f =   File.Create(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + formFile);
                f.Close();
            }
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\data\\" + formFile);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string line = sr.ReadLine();
            
            while (line != null)
            {
                string[] splitLine = line.Split('\t');
                if (splitLine.Length == 1)
                {
                    break;
                }
                string appName = splitLine[0];
                string appCommand = splitLine[1];

                Button btn = new Button();

                btn.Tag = appCommand;
                btn.Location = new Point((i-1) * w + s, j * h + s / 4);
                btn.MouseDown += addAppBtn_Click;
                btn.Width = w;
                btn.Height = h;
                btn.Text = appName;
                this.Controls.Add(btn);
                line = sr.ReadLine();
                
                i++;
                if(i == l)
                {
                    j++;
                    i = 0;
                }
                
            }
            addAppBtn.Location = new Point((i-1)* w +s, j* h + s / 4);
            
            sr.Close();
            Process[] processes = Process.GetProcesses();
            

            // Wyświetl informacje o każdym procesie
            
            
        }
            

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            ClickedButton = (Button)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            Console.WriteLine(me.Button);
            if(me.Button == MouseButtons.Right)
            {
                menu.Show(this, ClickedButton.Location);



                /*if (menu.Items.Contains(edit))
                {

                }*/
                
            }
            else
            {
                appLuncher.run(ClickedButton.Tag.ToString(), ClickedButton.Text);
            }
            
            
        }

        private void addNewBtn(object sender, EventArgs e)
        {
            Form addBtnHasClicked = new addAppForm();
            addAppForm.Games = this;
            addBtnHasClicked.Show();
        }
    }
    

}
