using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoja_App
{
    internal class appLuncher
    {
       public static void run(string nameApp, string name)
        {
            
            try { 
            Process p = Process.Start(nameApp);
            Console.WriteLine("{0} odpala sie {1}", p.ProcessName, p.Id);
            MessageBox.Show($"{name} odpala się", "Zamknij tego msgboxa");
                
            } 
            catch {
            MessageBox.Show($"Nie znaleziono aplikacji: {name}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

