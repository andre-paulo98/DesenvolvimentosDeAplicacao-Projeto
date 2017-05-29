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
                try {
                    FileStream fs = File.Create(file, 2048, FileOptions.None);
                    BinaryWriter bw = new BinaryWriter(fs);

                    string s = "this is a test";

                    ASCIIEncoding asen = new ASCIIEncoding();
                    byte[] ba = asen.GetBytes(s);

                    bw.Write(ba);

                    bw.Close();
                    fs.Close();
                } catch(Exception e) {
                    Console.Write(e.Message);
                    Console.ReadKey(true);
                }/*
                using(var fileStream = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.None))
                using(var bw = new BinaryWriter(fileStream)) {
                    string timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    bw.Write(username + " fez login " + timestamp);
                }*/
                success = true;
            }
            return success;
        }

        /*public List listLogs() {

        }*/

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
