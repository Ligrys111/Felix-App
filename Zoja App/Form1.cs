using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Zoja_App
{
    public partial class formMenu : Form
    {

        
        public formMenu()
        {
            
            InitializeComponent();
            showProcesses();
            if(!System.IO.Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\data"))
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\data");
            }
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

        }
        private void showProcesses()
        {
            Process[] processes = Process.GetProcesses();


            foreach (Process process in processes)
            {
                if (process.MainWindowHandle.ToInt32() > 0) { 
                
                listmenager.Items.Add($"{process.MainWindowTitle}\t{process.Id}");
                
                }
            }
        }
        private void formMenuClick(object sender, EventArgs e)
        {

        }



        private void formGamesClick(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
           
           
                
                
            

        }
        private void formMusicClick(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.formFile = "data1.txt";
            form3.Show();

            this.Hide();
        }




        private void listmenagerItemClick(object sender, EventArgs e)
        {
            
            string selectedItem =  (string)listmenager.SelectedItems[0].ToString();
            int nameCount = selectedItem.Length - 1;
            string[] processData = selectedItem.Substring(1, nameCount -1 ).Split('\t');
            Console.WriteLine("kliknięto " + processData[1]);
            
            try
            {
                int id = int.Parse(processData[1]);
                Process prog = Process.GetProcessById(id);
                listmenager.Items.Remove(listmenager.SelectedItems[0]);

                prog.Kill();
                Console.WriteLine("proces wył");
                
            }
            catch {

                

            }
        }

        private void formMenuLoad(object sender, EventArgs e)
        {
            listmenager.Invalidate();
            int i = 0;
            while (i < listmenager.Items.Count)
            {
                var item = listmenager.Items[i];
                Console.WriteLine(item.Position.ToString());
                if (item.Position.X == 39)
                {
                    Console.Write($"element {i} o nazwie {item.Text.Split('\t')[0]} znajduje się po lewej stronie {item.Position.Y} px od góry");

                }
                else
                {
                    Console.Write($"element {i} o nazwie {item.Text.Split('\t')[0]} znajduje się po prawej stronie {item.Position.Y} px od góry");
                }
                Console.WriteLine("\r\n");
                /*if (item.Text.StartsWith("Calcu"))
                {
                    item.ForeColor = Color.Red;
                }
                */
                i++;

            }

        }

        private void refreshClick(object sender, EventArgs e)
        {
            listmenager.Clear();
            showProcesses();
            formMenuLoad(sender, e);

        }

        private void otherClick(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.formFile = "data2.txt";
            this.Hide();
            form.Show();
        }
    }
}


