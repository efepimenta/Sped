using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpedContabil
{
    public partial class frmMainContabil : Form
    {
        public frmMainContabil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloco_0.Registro_0000 bl_0_reg_0 = new Bloco_0.Registro_0000();
            bl_0_reg_0.CNPJ = 123;
            bl_0_reg_0.IND_SIT_ESP = 0;
            bl_0_reg_0.COD_MUN = 3442;
            string saida = bl_0_reg_0.GetRegistro0000(false);
            MessageBox.Show(saida);
            bl_0_reg_0 = null;
        }
    }
}
