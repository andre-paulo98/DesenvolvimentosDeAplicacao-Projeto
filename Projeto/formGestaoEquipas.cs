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
    public partial class formGestaoEquipas : Form {
        private EquipasRepository eqRepo;
        private List<Team> listaEquipas;
        Modelo_Container dbContainer;
        public formGestaoEquipas(Modelo_Container dbContainer) {
            InitializeComponent();
            this.dbContainer = dbContainer;
            eqRepo = new EquipasRepository(dbContainer);
        }

        private void button1_Click(object sender, EventArgs e) {
            formEquipas formEquipa = new formEquipas(dbContainer);
            formEquipa.FormClosing += (object formSender, FormClosingEventArgs fromE) => {
                //RefreshDeckList();
            };
            formEquipa.ShowDialog(this);
        }
    }
}
