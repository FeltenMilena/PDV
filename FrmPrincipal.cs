using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class frmPrincipal : Form
    {
        #region [ Inicializador Form ]
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region [ Eventos Form ]
        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario frm = new FrmFuncionario();
            frm.ShowDialog();
        }
        #endregion
    }
}
