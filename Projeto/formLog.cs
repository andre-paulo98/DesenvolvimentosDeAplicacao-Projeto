using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto {
    public partial class formLog : Form {
        LogRepository logRepo = new LogRepository();
        public formLog() {
            InitializeComponent();
        }

        private void formLog_Load(object sender, EventArgs e) {
            lbLog.Items.AddRange(logRepo.listLogs().ToArray());
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
