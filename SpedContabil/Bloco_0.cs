using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SpedContabil
{
    public class Bloco_0
    {
        public class Registro_0000
        {
            private string fREG;    //conteudo fixo
            private string fLECD;   //conteudo fixo
            private int fDT_INI;
            private int fDT_FIN;
            private string fNOME;
            private int fCNPJ;
            private string fUF;
            private string fIE;
            private int fCOD_MUN;
            private int fIM;
            private int fIND_SIT_ESP;

            /// <summary>
            /// Indicador de situação especial (conforme tabela publicada pelo Sped)
            /// </summary>
            public int IND_SIT_ESP
            {
                get { return fIND_SIT_ESP; }
                set { fIND_SIT_ESP = value; }
            }

            /// <summary>
            /// Inscrição Municipal da pessoa jurídica.
            /// </summary>
            public int IM
            {
                get { return fIM; }
                set { fIM = value; }
            }

            /// <summary>
            /// Código do município do domicílio fiscal da pessoa jurídica,
            /// conforme tabela do IBGE – Instituto Brasileiro de Geografia e Estatística.
            /// </summary>
            public int COD_MUN
            {
                get { return fCOD_MUN; }
                set { fCOD_MUN = value; }
            }


            public string IE
            {
                get { return fIE; }
                set { fIE = value; }
            }


            public string UF
            {
                get { return fUF; }
                set { fUF = value; }
            }


            public int CNPJ
            {
                get { return fCNPJ; }
                set { fCNPJ = value; }
            }


            public string NOME
            {
                get { return fNOME; }
                set { fNOME = value; }
            }


            public int DT_FIN
            {
                get { return fDT_FIN; }
                set { fDT_FIN = value; }
            }


            public int DT_INI
            {
                get { return fDT_INI; }
                set { fDT_INI = value; }
            }


            public string LECD
            {
                get { return fLECD; }
                set { fLECD = value; }
            }


            public string REG
            {
                get { return fREG; }
                set { fREG = value; }
            }

            public string GetRegistro0000(Boolean Validate)
            {
                if (Validate)
                {
                    //fazer as validacoes constantes no arquivo de layout
                    return "saida é " + fCNPJ;
                }
                else
                {
                    //criar a saida sem validacao
                    return "saida é " + fCNPJ;
                }
                
            }
        }
        class registro_0001
        {
            private string fREG;
            private int fIND_DAD;

            public int IND_DAD
            {
                get { return fIND_DAD; }
                set { fIND_DAD = value; }
            }


            public string REG
            {
                get { return fREG; }
                set { fREG = value; }
            }

            public string GetRegistro0001()
            {
                return "saida é " + fIND_DAD;
            }

        }
    }
}
