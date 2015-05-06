using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SpedFiscal
{
    public partial class frmMainFiscal : Form
    {
        public frmMainFiscal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bloco_0.Registro_0000 B0_Registro_0000 = new Bloco_0.Registro_0000();
            /*
            B0_Registro_0000.COD_VER = "107";
            B0_Registro_0000.COD_FIN = "0";
            B0_Registro_0000.DT_INI = "99999999";
            B0_Registro_0000.CPF = "02304281931";
            B0_Registro_0000.CNPJ = "84948991000129";
            B0_Registro_0000.DT_FIN = "31122013";
            B0_Registro_0000.NOME = edtNome.Text;
            B0_Registro_0000.UF = "PR";
            B0_Registro_0000.IE = "isento";
            B0_Registro_0000.COD_MUN = Utils.ConsultaMunicipio(TpConsulta.PorNome,"londrina",B0_Registro_0000.UF);
            B0_Registro_0000.IND_PERFIL = edtPerfil.Text;
            B0_Registro_0000.IND_ATIV = edtAtividade.Text;
            B0_Registro_0000.DT_INI = "01122013";

            lblSaida.Text = B0_Registro_0000.GetRegistro_0000(checkBox1.Checked);
            */

            B0_Registro_0000 = null;

            Bloco_0.Registro_0150 B0_Registro_0150 = new Bloco_0.Registro_0150();
            B0_Registro_0150.COD_PART = "0";
            B0_Registro_0150.NOME = "fabio";
            B0_Registro_0150.COD_PAIS = Utils.ConsultaPais(TpConsulta.PorNome,"Brasil");
            B0_Registro_0150.END = "venezuela";

            lblSaida.Text = B0_Registro_0150.GetRegistro_0150(checkBox1.Checked);

            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
