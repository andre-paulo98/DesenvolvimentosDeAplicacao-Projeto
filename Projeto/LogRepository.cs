using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    
    class LogRepository {
        private string file = "access.dat";

        public bool addToLog(string username) {
            bool success = false;
            if(checkFile()) {
                using(StreamWriter sw = File.AppendText(file)) {
                    string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    sw.WriteLine(username + " fez login " + timestamp);
                }
                success = true;
            }
            return success;
        }

        public List<string> listLogs() {
            var logFile = File.ReadAllLines(file);
            List<string> listLogs = new List<string>(logFile);
            return listLogs;
        }

        private bool checkFile() {
            try {
                if(!File.Exists(file)) {
                    File.Create(file).Dispose();
                }
            } catch(Exception) {
                MessageBox.Show("Erro ao aceder ao ficheiro de log de utilizadores.", "Erro");
                return false;
            }
            return true;

        }
    }
}
