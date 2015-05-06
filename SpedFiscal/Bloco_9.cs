using System;
namespace SpedFiscal
{
    public class Bloco_9
    {
        /// <summary>
        /// ABERTURA DO BLOCO 9
        /// </summary>
        public class Registro_9001
        {
            /// <summary>
            /// Texto fixo contendo “9001”.
            /// </summary>
            private string F_REG = "9001";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            private string F_IND_MOV = "";
            public string IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            public string GetRegistro_9001(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (F_IND_MOV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV */
                    if (F_IND_MOV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(F_IND_MOV.Equals("0") || F_IND_MOV.Equals("1")))
                    {
                        return "Erro - O campo IND_MOV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_IND_MOV);
            }
        }

        /// <summary>
        /// REGISTROS DO ARQUIVO.
        /// </summary>
        public class Registro_9900
        {
            /// <summary>
            /// Texto fixo contendo “9900”.
            /// </summary>
            private string F_REG = "9900";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Registro que será totalizado no próximo campo.
            /// </summary>
            private string F_REG_BLC = "";
            public string REG_BLC
            {
                get { return F_REG_BLC; }
                set { F_REG_BLC = value.ToUpper(); }
            }

            /// <summary>
            /// Total de registros do tipo informado no campo anterior.
            /// </summary>
            private string F_QTD_REG_BLC = "";
            public string QTD_REG_BLC
            {
                get { return F_QTD_REG_BLC; }
                set { F_QTD_REG_BLC = value.ToUpper(); }
            }

            public string GetRegistro_9900(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG_BLC */
                    if (F_REG_BLC.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG_BLC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG_BLC */
                    if (F_REG_BLC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG_BLC não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG_BLC */
                    if (F_REG_BLC.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG_BLC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_REG_BLC */
                    if (F_QTD_REG_BLC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_REG_BLC não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_REG_BLC, F_QTD_REG_BLC);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO 9
        /// </summary>
        public class Registro_9990
        {
            /// <summary>
            /// Texto fixo contendo “9990”.
            /// </summary>
            private string F_REG = "9990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco 9.
            /// </summary>
            private string F_QTD_LIN_9 = "";
            public string QTD_LIN_9
            {
                get { return F_QTD_LIN_9; }
                set { F_QTD_LIN_9 = value.ToUpper(); }
            }

            public string GetRegistro_9990(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_LIN_9 */
                    if (F_QTD_LIN_9.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_9 não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_9);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO ARQUIVO DIGITAL.
        /// </summary>
        public class Registro_9999
        {
            /// <summary>
            /// Texto fixo contendo “9999”.
            /// </summary>
            private string F_REG = "9999";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do arquivo digital.
            /// </summary>
            private string F_QTD_LIN = "";
            public string QTD_LIN
            {
                get { return F_QTD_LIN; }
                set { F_QTD_LIN = value.ToUpper(); }
            }

            public string GetRegistro_9999(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_LIN */
                    if (F_QTD_LIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN);
            }
        }
    }
}
