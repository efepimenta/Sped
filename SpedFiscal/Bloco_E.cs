using System;

namespace SpedFiscal
{
    public class Bloco_E
    {
        /// <summary>
        /// ABERTURA DO BLOCO E
        /// </summary>
        public class Registro_E001
        {
            /// <summary>
            /// Texto fixo contendo "E001"
            /// </summary>
            private string F_REG = "E001";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados
            /// </summary>
            private string F_IND_MOV = "";
            public string IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            public string GetRegistro_E001(bool Validate)
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
        /// PERÍODO DA APURAÇÃO DO ICMS.
        /// </summary>
        public class Registro_E100
        {
            /// <summary>
            /// Texto fixo contendo "E100"
            /// </summary>
            private string F_REG = "E100";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data inicial a que a apuração se refere
            /// </summary>
            private string F_DT_INI = "";
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Data final a que a apuração se refere
            /// </summary>
            private string F_DT_FIN = "";
            public string DT_FIN
            {
                get { return F_DT_FIN; }
                set { F_DT_FIN = value.ToUpper(); }
            }

            public string GetRegistro_E100(bool Validate)
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
                    /* validacao para o tamanho do campo DT_INI */
                    if (F_DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (F_DT_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIN */
                    if (F_DT_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIN não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_DT_INI, F_DT_FIN);
            }
        }

        /// <summary>
        /// APURAÇÃO DO ICMS – OPERAÇÕES PRÓPRIAS.
        /// </summary>
        public class Registro_E110
        {
            /// <summary>
            /// Texto fixo contendo "E110"
            /// </summary>
            private string F_REG = "E110";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos débitos por "Saídas e prestações com débito do imposto"
            /// </summary>
            private string F_VL_TOT_DEBITOS = "";
            public string VL_TOT_DEBITOS
            {
                get { return F_VL_TOT_DEBITOS; }
                set { F_VL_TOT_DEBITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos ajustes a débito decorrentes do documento fiscal.
            /// </summary>
            private string F_VL_AJ_DEBITOS = "";
            public string VL_AJ_DEBITOS
            {
                get { return F_VL_AJ_DEBITOS; }
                set { F_VL_AJ_DEBITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "Ajustes a débito"
            /// </summary>
            private string F_VL_TOT_AJ_DEBITOS = "";
            public string VL_TOT_AJ_DEBITOS
            {
                get { return F_VL_TOT_AJ_DEBITOS; }
                set { F_VL_TOT_AJ_DEBITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de Ajustes “Estornos de créditos”
            /// </summary>
            private string F_VL_ESTORNOS_CRED = "";
            public string VL_ESTORNOS_CRED
            {
                get { return F_VL_ESTORNOS_CRED; }
                set { F_VL_ESTORNOS_CRED = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos créditos por "Entradas e aquisições com crédito do imposto"
            /// </summary>
            private string F_VL_TOT_CREDITOS = "";
            public string VL_TOT_CREDITOS
            {
                get { return F_VL_TOT_CREDITOS; }
                set { F_VL_TOT_CREDITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos ajustes a crédito decorrentes do documento fiscal.
            /// </summary>
            private string F_VL_AJ_CREDITOS = "";
            public string VL_AJ_CREDITOS
            {
                get { return F_VL_AJ_CREDITOS; }
                set { F_VL_AJ_CREDITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "Ajustes a crédito"
            /// </summary>
            private string F_VL_TOT_AJ_CREDITOS = "";
            public string VL_TOT_AJ_CREDITOS
            {
                get { return F_VL_TOT_AJ_CREDITOS; }
                set { F_VL_TOT_AJ_CREDITOS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de Ajustes “Estornos de Débitos”
            /// </summary>
            private string F_VL_ESTORNOS_DEB = "";
            public string VL_ESTORNOS_DEB
            {
                get { return F_VL_ESTORNOS_DEB; }
                set { F_VL_ESTORNOS_DEB = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "Saldo credor do período anterior"
            /// </summary>
            private string F_VL_SLD_CREDOR_ANT = "";
            public string VL_SLD_CREDOR_ANT
            {
                get { return F_VL_SLD_CREDOR_ANT; }
                set { F_VL_SLD_CREDOR_ANT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do saldo devedor apurado
            /// </summary>
            private string F_VL_SLD_APURADO = "";
            public string VL_SLD_APURADO
            {
                get { return F_VL_SLD_APURADO; }
                set { F_VL_SLD_APURADO = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "Deduções"
            /// </summary>
            private string F_VL_TOT_DED = "";
            public string VL_TOT_DED
            {
                get { return F_VL_TOT_DED; }
                set { F_VL_TOT_DED = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "ICMS a recolher (11-12)
            /// </summary>
            private string F_VL_ICMS_RECOLHER = "";
            public string VL_ICMS_RECOLHER
            {
                get { return F_VL_ICMS_RECOLHER; }
                set { F_VL_ICMS_RECOLHER = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de "Saldo credor a transportar para o período seguinte”
            /// </summary>
            private string F_VL_SLD_CREDOR_TRANSPORTAR = "";
            public string VL_SLD_CREDOR_TRANSPORTAR
            {
                get { return F_VL_SLD_CREDOR_TRANSPORTAR; }
                set { F_VL_SLD_CREDOR_TRANSPORTAR = value.ToUpper(); }
            }

            /// <summary>
            /// Valores recolhidos ou a recolher, extraapuração.
            /// </summary>
            private string F_DEB_ESP = "";
            public string DEB_ESP
            {
                get { return F_DEB_ESP; }
                set { F_DEB_ESP = value.ToUpper(); }
            }

            public string GetRegistro_E110(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_TOT_DEBITOS */
                    if (F_VL_TOT_DEBITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOT_DEBITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_DEBITOS */
                    if (F_VL_AJ_DEBITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_DEBITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOT_AJ_DEBITOS */
                    if (F_VL_TOT_AJ_DEBITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOT_AJ_DEBITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ESTORNOS_CRED */
                    if (F_VL_ESTORNOS_CRED.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ESTORNOS_CRED não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOT_CREDITOS */
                    if (F_VL_TOT_CREDITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOT_CREDITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_CREDITOS */
                    if (F_VL_AJ_CREDITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_CREDITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOT_AJ_CREDITOS */
                    if (F_VL_TOT_AJ_CREDITOS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOT_AJ_CREDITOS não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ESTORNOS_DEB */
                    if (F_VL_ESTORNOS_DEB.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ESTORNOS_DEB não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_CREDOR_ANT */
                    if (F_VL_SLD_CREDOR_ANT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_CREDOR_ANT não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_APURADO */
                    if (F_VL_SLD_APURADO.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_APURADO não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOT_DED */
                    if (F_VL_TOT_DED.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOT_DED não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS_RECOLHER */
                    if (F_VL_ICMS_RECOLHER.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS_RECOLHER não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_CREDOR_TRANSPORTAR */
                    if (F_VL_SLD_CREDOR_TRANSPORTAR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_CREDOR_TRANSPORTAR não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DEB_ESP */
                    if (F_DEB_ESP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DEB_ESP não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", F_REG, F_VL_TOT_DEBITOS, F_VL_AJ_DEBITOS, F_VL_TOT_AJ_DEBITOS, F_VL_ESTORNOS_CRED, F_VL_TOT_CREDITOS, F_VL_AJ_CREDITOS, F_VL_TOT_AJ_CREDITOS, F_VL_ESTORNOS_DEB, F_VL_SLD_CREDOR_ANT, F_VL_SLD_APURADO, F_VL_TOT_DED, F_VL_ICMS_RECOLHER, F_VL_SLD_CREDOR_TRANSPORTAR, F_DEB_ESP);
            }
        }

        /// <summary>
        /// AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO ICMS.
        /// </summary>
        public class Registro_E111
        {
            /// <summary>
            /// Texto fixo contendo "E111"
            /// </summary>
            private string F_REG = "E111";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do ajuste da apuração e dedução, conforme a Tabela indicada no item 5.1.1.
            /// </summary>
            private string F_COD_AJ_APUR = "";
            public string COD_AJ_APUR
            {
                get { return F_COD_AJ_APUR; }
                set { F_COD_AJ_APUR = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar do ajuste da apuração.
            /// </summary>
            private string F_DESCR_COMPL_AJ = "";
            public string DESCR_COMPL_AJ
            {
                get { return F_DESCR_COMPL_AJ; }
                set { F_DESCR_COMPL_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ajuste da apuração
            /// </summary>
            private string F_VL_AJ_APUR = "";
            public string VL_AJ_APUR
            {
                get { return F_VL_AJ_APUR; }
                set { F_VL_AJ_APUR = value.ToUpper(); }
            }

            public string GetRegistro_E111(bool Validate)
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
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_AJ_APUR não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_APUR */
                    if (F_VL_AJ_APUR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_APUR não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_AJ_APUR, F_DESCR_COMPL_AJ, F_VL_AJ_APUR);
            }
        }

        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS.
        /// </summary>
        public class Registro_E112
        {
            /// <summary>
            /// Texto fixo contendo "E112"
            /// </summary>
            private string F_REG = "E112";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento de arrecadação estadual, se houver
            /// </summary>
            private string F_NUM_DA = "";
            public string NUM_DA
            {
                get { return F_NUM_DA; }
                set { F_NUM_DA = value.ToUpper(); }
            }

            /// <summary>
            /// Número do processo ao qual o ajuste está vinculado, se houver
            /// </summary>
            private string F_NUM_PROC = "";
            public string NUM_PROC
            {
                get { return F_NUM_PROC; }
                set { F_NUM_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da origem do processo: 0- Sefaz; 1- Justiça Federal; 2- Justiça Estadual; 9- Outros
            /// </summary>
            private string F_IND_PROC = "";
            public string IND_PROC
            {
                get { return F_IND_PROC; }
                set { F_IND_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição resumida do processo que embasou o lançamento
            /// </summary>
            private string F_PROC = "";
            public string PROC
            {
                get { return F_PROC; }
                set { F_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_E112(bool Validate)
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
                    /* validacao para o tamanho do campo NUM_PROC */
                    if (F_NUM_PROC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de NUM_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_PROC */
                    if (!(F_IND_PROC.Equals("0") || F_IND_PROC.Equals("1") || F_IND_PROC.Equals("2") || F_IND_PROC.Equals("9")))
                    {
                        return "Erro - O campo IND_PROC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_NUM_DA, F_NUM_PROC, F_IND_PROC, F_PROC, F_TXT_COMPL);
            }
        }

        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS – IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS.
        /// </summary>
        public class Registro_E113
        {
            /// <summary>
            /// Texto fixo contendo "E113"
            /// </summary>
            private string F_REG = "E113";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): - do emitente do documento ou do remetente das mercadorias, no caso de entradas; - do adquirente, no caso de saídas
            /// </summary>
            private string F_COD_PART = "";
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            private string F_COD_MOD = "";
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            private string F_SER = "";
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            /// <summary>
            /// Subserie do documento fiscal
            /// </summary>
            private string F_SUB = "";
            public string SUB
            {
                get { return F_SUB; }
                set { F_SUB = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            private string F_NUM_DOC = "";
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ajuste para a operação/item
            /// </summary>
            private string F_VL_AJ_ITEM = "";
            public string VL_AJ_ITEM
            {
                get { return F_VL_AJ_ITEM; }
                set { F_VL_AJ_ITEM = value.ToUpper(); }
            }

            public string GetRegistro_E113(bool Validate)
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
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_PART */
                    if (F_COD_PART.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_PART não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MOD */
                    if (F_COD_MOD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MOD não informado(a)";
                    }
                    /* validacao para o tamanho do campo SER */
                    if (F_SER.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de SER incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUB */
                    if (F_SUB.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SUB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC */
                    if (F_NUM_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_DOC */
                    if (F_DT_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_ITEM */
                    if (F_VL_AJ_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_ITEM não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_COD_PART, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC, F_COD_ITEM, F_VL_AJ_ITEM);
            }
        }

        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DA APURAÇÃO – VALORES DECLARATÓRIOS.
        /// </summary>
        public class Registro_E115
        {
            /// <summary>
            /// Texto fixo contendo "E115"
            /// </summary>
            private string F_REG = "E115";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da informação adicional conforme tabela a ser definida pelas SEFAZ, conforme tabela definida no item 5.2.
            /// </summary>
            private string F_COD_INF_ADIC = "";
            public string COD_INF_ADIC
            {
                get { return F_COD_INF_ADIC; }
                set { F_COD_INF_ADIC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor referente à informação adicional
            /// </summary>
            private string F_VL_INF_ADIC = "";
            public string VL_INF_ADIC
            {
                get { return F_VL_INF_ADIC; }
                set { F_VL_INF_ADIC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar do ajuste
            /// </summary>
            private string F_DESCR_COMPL_AJ = "";
            public string DESCR_COMPL_AJ
            {
                get { return F_DESCR_COMPL_AJ; }
                set { F_DESCR_COMPL_AJ = value.ToUpper(); }
            }

            public string GetRegistro_E115(bool Validate)
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
                    /* validacao para o tamanho do campo COD_INF_ADIC */
                    if (F_COD_INF_ADIC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_INF_ADIC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_INF_ADIC */
                    if (F_COD_INF_ADIC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_INF_ADIC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF_ADIC */
                    if (F_COD_INF_ADIC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_INF_ADIC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_INF_ADIC */
                    if (F_VL_INF_ADIC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_INF_ADIC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF_ADIC */
                    if (F_COD_INF_ADIC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_INF_ADIC incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_INF_ADIC, F_VL_INF_ADIC, F_DESCR_COMPL_AJ);
            }
        }

        /// <summary>
        /// OBRIGAÇÕES DO ICMS RECOLHIDO OU A RECOLHER – OPERAÇÕES PRÓPRIAS.
        /// </summary>
        public class Registro_E116
        {
            /// <summary>
            /// Texto fixo contendo "E116"
            /// </summary>
            private string F_REG = "E116";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da obrigação a recolher, conforme a Tabela 5.4
            /// </summary>
            private string F_COD_OR = "";
            public string COD_OR
            {
                get { return F_COD_OR; }
                set { F_COD_OR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da obrigação a recolher
            /// </summary>
            private string F_VL_OR = "";
            public string VL_OR
            {
                get { return F_VL_OR; }
                set { F_VL_OR = value.ToUpper(); }
            }

            /// <summary>
            /// Data de vencimento da obrigação
            /// </summary>
            private string F_DT_VCTO = "";
            public string DT_VCTO
            {
                get { return F_DT_VCTO; }
                set { F_DT_VCTO = value.ToUpper(); }
            }

            /// <summary>
            /// Código de receita referente à obrigação, próprio da unidade da federação, conforme legislação estadual,
            /// </summary>
            private string F_COD_REC = "";
            public string COD_REC
            {
                get { return F_COD_REC; }
                set { F_COD_REC = value.ToUpper(); }
            }

            /// <summary>
            /// Número do processo ou auto de infração ao qual a obrigação está vinculada, se houver.
            /// </summary>
            private string F_NUM_PROC = "";
            public string NUM_PROC
            {
                get { return F_NUM_PROC; }
                set { F_NUM_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da origem do processo: 0- SEFAZ; 1- Justiça Federal; 2- Justiça Estadual; 9- Outros
            /// </summary>
            private string F_IND_PROC = "";
            public string IND_PROC
            {
                get { return F_IND_PROC; }
                set { F_IND_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição resumida do processo que embasou o lançamento
            /// </summary>
            private string F_PROC = "";
            public string PROC
            {
                get { return F_PROC; }
                set { F_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar das obrigações a recolher.
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            /// <summary>
            /// Informe o mês de referência no formato “mmaaaa”
            /// </summary>
            private string F_MES_REF = "";
            public string MES_REF
            {
                get { return F_MES_REF; }
                set { F_MES_REF = value.ToUpper(); }
            }

            public string GetRegistro_E116(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OR */
                    if (F_COD_OR.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_OR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_OR */
                    if (F_COD_OR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_OR não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OR */
                    if (F_COD_OR.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_OR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OR */
                    if (F_VL_OR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OR não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_VCTO */
                    if (F_DT_VCTO.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_VCTO não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_REC */
                    if (F_COD_REC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_REC não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PROC */
                    if (F_NUM_PROC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de NUM_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_PROC */
                    if (!(F_IND_PROC.Equals("0") || F_IND_PROC.Equals("1") || F_IND_PROC.Equals("2") || F_IND_PROC.Equals("9")))
                    {
                        return "Erro - O campo IND_PROC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo MES_REF */
                    if (F_MES_REF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de MES_REF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo MES_REF */
                    if (F_MES_REF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório MES_REF não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_OR, F_VL_OR, F_DT_VCTO, F_COD_REC, F_NUM_PROC, F_IND_PROC, F_PROC, F_TXT_COMPL, F_MES_REF);
            }
        }

        /// <summary>
        /// PERÍODO DA APURAÇÃO DO ICMS - SUBSTITUIÇÃO TRIBUTÁRIA.
        /// </summary>
        public class Registro_E200
        {
            /// <summary>
            /// Texto fixo contendo "E200"
            /// </summary>
            private string F_REG = "E200";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da unidade da federação a que se refere a apuração do ICMS ST
            /// </summary>
            private string F_UF = "";
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Data inicial a que a apuração se refere
            /// </summary>
            private string F_DT_INI = "";
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Data final a que a apuração se refere
            /// </summary>
            private string F_DT_FIN = "";
            public string DT_FIN
            {
                get { return F_DT_FIN; }
                set { F_DT_FIN = value.ToUpper(); }
            }

            public string GetRegistro_E200(bool Validate)
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
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF */
                    if (F_UF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (F_DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (F_DT_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIN */
                    if (F_DT_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIN não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_UF, F_DT_INI, F_DT_FIN);
            }
        }

        /// <summary>
        /// APURAÇÃO DO ICMS – SUBSTITUIÇÃO TRIBUTÁRIA.
        /// </summary>
        public class Registro_E210
        {
            /// <summary>
            /// Texto fixo contendo "E210"
            /// </summary>
            private string F_REG = "E210";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador de movimento: 0 – Sem operações com ST 1 – Com operações de ST
            /// </summary>
            private string F_IND_MOV_ST = "";
            public string IND_MOV_ST
            {
                get { return F_IND_MOV_ST; }
                set { F_IND_MOV_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do "Saldo credor de período anterior – Substituição Tributária"
            /// </summary>
            private string F_VL_SLD_CRED_ANT_ST = "";
            public string VL_SLD_CRED_ANT_ST
            {
                get { return F_VL_SLD_CRED_ANT_ST; }
                set { F_VL_SLD_CRED_ANT_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS ST de devolução de mercadorias
            /// </summary>
            private string F_VL_DEVOL_ST = "";
            public string VL_DEVOL_ST
            {
                get { return F_VL_DEVOL_ST; }
                set { F_VL_DEVOL_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS ST de ressarcimentos
            /// </summary>
            private string F_VL_RESSARC_ST = "";
            public string VL_RESSARC_ST
            {
                get { return F_VL_RESSARC_ST; }
                set { F_VL_RESSARC_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de Ajustes "Outros créditos ST" e “Estorno de débitos ST”
            /// </summary>
            private string F_VL_OUT_CRED_ST = "";
            public string VL_OUT_CRED_ST
            {
                get { return F_VL_OUT_CRED_ST; }
                set { F_VL_OUT_CRED_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos ajustes a crédito de ICMS ST, provenientes de ajustes do documento fiscal.
            /// </summary>
            private string F_VL_AJ_CREDITOS_ST = "";
            public string VL_AJ_CREDITOS_ST
            {
                get { return F_VL_AJ_CREDITOS_ST; }
                set { F_VL_AJ_CREDITOS_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor Total do ICMS retido por Substituição Tributária
            /// </summary>
            private string F_VL_RETENÇAO_ST = "";
            public string VL_RETENÇAO_ST
            {
                get { return F_VL_RETENÇAO_ST; }
                set { F_VL_RETENÇAO_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor Total dos ajustes "Outros débitos ST" " e “Estorno de créditos ST”
            /// </summary>
            private string F_VL_OUT_DEB_ST = "";
            public string VL_OUT_DEB_ST
            {
                get { return F_VL_OUT_DEB_ST; }
                set { F_VL_OUT_DEB_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos ajustes a débito de ICMS ST, provenientes de ajustes do documento fiscal.
            /// </summary>
            private string F_VL_AJ_DEBITOS_ST = "";
            public string VL_AJ_DEBITOS_ST
            {
                get { return F_VL_AJ_DEBITOS_ST; }
                set { F_VL_AJ_DEBITOS_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de Saldo devedor antes das deduções
            /// </summary>
            private string F_VL_SLD_DEV_ANT_ST = "";
            public string VL_SLD_DEV_ANT_ST
            {
                get { return F_VL_SLD_DEV_ANT_ST; }
                set { F_VL_SLD_DEV_ANT_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos ajustes "Deduções ST"
            /// </summary>
            private string F_VL_DEDUÇÕES_ST = "";
            public string VL_DEDUÇÕES_ST
            {
                get { return F_VL_DEDUÇÕES_ST; }
                set { F_VL_DEDUÇÕES_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Imposto a recolher ST (11-12)
            /// </summary>
            private string F_VL_ICMS_RECOL_ST = "";
            public string VL_ICMS_RECOL_ST
            {
                get { return F_VL_ICMS_RECOL_ST; }
                set { F_VL_ICMS_RECOL_ST = value.ToUpper(); }
            }

            /// <summary>
            /// SPORTAR Saldo credor de ST a transportar para o período seguinte [(03+04+05+06+07)– (08+09+10)].
            /// </summary>
            private string F_VL_SLD_CRED_ST_TRAN = "";
            public string VL_SLD_CRED_ST_TRAN
            {
                get { return F_VL_SLD_CRED_ST_TRAN; }
                set { F_VL_SLD_CRED_ST_TRAN = value.ToUpper(); }
            }

            /// <summary>
            /// Valores recolhidos ou a recolher, extraapuração.
            /// </summary>
            private string F_DEB_ESP_ST = "";
            public string DEB_ESP_ST
            {
                get { return F_DEB_ESP_ST; }
                set { F_DEB_ESP_ST = value.ToUpper(); }
            }

            public string GetRegistro_E210(bool Validate)
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
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV_ST não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_MOV_ST */
                    if (!(F_IND_MOV_ST.Equals("0") || F_IND_MOV_ST.Equals("1")))
                    {
                        return "Erro - O campo IND_MOV_ST possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_CRED_ANT_ST */
                    if (F_VL_SLD_CRED_ANT_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_CRED_ANT_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DEVOL_ST */
                    if (F_VL_DEVOL_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DEVOL_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_RESSARC_ST */
                    if (F_VL_RESSARC_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_RESSARC_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OUT_CRED_ST */
                    if (F_VL_OUT_CRED_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OUT_CRED_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_CREDITOS_ST */
                    if (F_VL_AJ_CREDITOS_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_CREDITOS_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_RETENÇAO_ST */
                    if (F_VL_RETENÇAO_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_RETENÇAO_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OUT_DEB_ST */
                    if (F_VL_OUT_DEB_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OUT_DEB_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_DEBITOS_ST */
                    if (F_VL_AJ_DEBITOS_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_DEBITOS_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_DEV_ANT_ST */
                    if (F_VL_SLD_DEV_ANT_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_DEV_ANT_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DEDUÇÕES_ST */
                    if (F_VL_DEDUÇÕES_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DEDUÇÕES_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS_RECOL_ST */
                    if (F_VL_ICMS_RECOL_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS_RECOL_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SLD_CRED_ST_TRAN */
                    if (F_VL_SLD_CRED_ST_TRAN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SLD_CRED_ST_TRAN não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV_ST */
                    if (F_IND_MOV_ST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DEB_ESP_ST */
                    if (F_DEB_ESP_ST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DEB_ESP_ST não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", F_REG, F_IND_MOV_ST, F_VL_SLD_CRED_ANT_ST, F_VL_DEVOL_ST, F_VL_RESSARC_ST, F_VL_OUT_CRED_ST, F_VL_AJ_CREDITOS_ST, F_VL_RETENÇAO_ST, F_VL_OUT_DEB_ST, F_VL_AJ_DEBITOS_ST, F_VL_SLD_DEV_ANT_ST, F_VL_DEDUÇÕES_ST, F_VL_ICMS_RECOL_ST, F_VL_SLD_CRED_ST_TRAN, F_DEB_ESP_ST);
            }
        }

        /// <summary>
        /// AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA.
        /// </summary>
        public class Registro_E220
        {
            /// <summary>
            /// Texto fixo contendo "E220"
            /// </summary>
            private string F_REG = "E220";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do ajuste da apuração e dedução, conforme a Tabela indicada no item 5.1.1
            /// </summary>
            private string F_COD_AJ_APUR = "";
            public string COD_AJ_APUR
            {
                get { return F_COD_AJ_APUR; }
                set { F_COD_AJ_APUR = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar do ajuste da apuração
            /// </summary>
            private string F_DESCR_COMPL_AJ = "";
            public string DESCR_COMPL_AJ
            {
                get { return F_DESCR_COMPL_AJ; }
                set { F_DESCR_COMPL_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ajuste da apuração
            /// </summary>
            private string F_VL_AJ_APUR = "";
            public string VL_AJ_APUR
            {
                get { return F_VL_AJ_APUR; }
                set { F_VL_AJ_APUR = value.ToUpper(); }
            }

            public string GetRegistro_E220(bool Validate)
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
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_AJ_APUR não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ_APUR */
                    if (F_COD_AJ_APUR.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ_APUR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_APUR */
                    if (F_VL_AJ_APUR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_APUR não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_AJ_APUR, F_DESCR_COMPL_AJ, F_VL_AJ_APUR);
            }
        }

        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA.
        /// </summary>
        public class Registro_E230
        {
            /// <summary>
            /// Texto fixo contendo "E230"
            /// </summary>
            private string F_REG = "E230";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento de arrecadação estadual, se houver
            /// </summary>
            private string F_NUM_DA = "";
            public string NUM_DA
            {
                get { return F_NUM_DA; }
                set { F_NUM_DA = value.ToUpper(); }
            }

            /// <summary>
            /// Número do processo ao qual o ajuste está vinculado, se houver
            /// </summary>
            private string F_NUM_PROC = "";
            public string NUM_PROC
            {
                get { return F_NUM_PROC; }
                set { F_NUM_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da origem do processo: 0- Sefaz; 1- Justiça Federal; 2- Justiça Estadual; 9- Outros
            /// </summary>
            private string F_IND_PROC = "";
            public string IND_PROC
            {
                get { return F_IND_PROC; }
                set { F_IND_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição resumida do processo que embasou o lançamento
            /// </summary>
            private string F_PROC = "";
            public string PROC
            {
                get { return F_PROC; }
                set { F_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_E230(bool Validate)
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
                    /* validacao para o tamanho do campo NUM_PROC */
                    if (F_NUM_PROC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de NUM_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_PROC */
                    if (!(F_IND_PROC.Equals("0") || F_IND_PROC.Equals("1") || F_IND_PROC.Equals("2") || F_IND_PROC.Equals("9")))
                    {
                        return "Erro - O campo IND_PROC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_NUM_DA, F_NUM_PROC, F_IND_PROC, F_PROC, F_TXT_COMPL);
            }
        }

        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA – IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS.
        /// </summary>
        public class Registro_E240
        {
            /// <summary>
            /// Texto fixo contendo "E240"
            /// </summary>
            private string F_REG = "E240";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): - do emitente do documento ou do remetente das mercadorias, no caso de entradas; - do adquirente, no caso de saídas
            /// </summary>
            private string F_COD_PART = "";
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            private string F_COD_MOD = "";
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            private string F_SER = "";
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            private string F_SUB = "";
            public string SUB
            {
                get { return F_SUB; }
                set { F_SUB = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            private string F_NUM_DOC = "";
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ajuste para a operação/item
            /// </summary>
            private string F_VL_AJ_ITEM = "";
            public string VL_AJ_ITEM
            {
                get { return F_VL_AJ_ITEM; }
                set { F_VL_AJ_ITEM = value.ToUpper(); }
            }

            public string GetRegistro_E240(bool Validate)
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
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_PART */
                    if (F_COD_PART.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_PART não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MOD */
                    if (F_COD_MOD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MOD não informado(a)";
                    }
                    /* validacao para o tamanho do campo SER */
                    if (F_SER.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de SER incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUB */
                    if (F_SUB.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SUB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC */
                    if (F_NUM_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_DOC */
                    if (F_DT_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ_ITEM */
                    if (F_VL_AJ_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ_ITEM não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_COD_PART, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC, F_COD_ITEM, F_VL_AJ_ITEM);
            }
        }

        /// <summary>
        /// OBRIGAÇÕES DO ICMS RECOLHIDO OU A RECOLHER – SUBSTITUIÇÃO TRIBUTÁRIA.
        /// </summary>
        public class Registro_E250
        {
            /// <summary>
            /// Texto fixo contendo "E250"
            /// </summary>
            private string F_REG = "E250";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da obrigação a recolher, conforme a Tabela 5.4
            /// </summary>
            private string F_COD_OR = "";
            public string COD_OR
            {
                get { return F_COD_OR; }
                set { F_COD_OR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da obrigação ICMS ST a recolher
            /// </summary>
            private string F_VL_OR = "";
            public string VL_OR
            {
                get { return F_VL_OR; }
                set { F_VL_OR = value.ToUpper(); }
            }

            /// <summary>
            /// Data de vencimento da obrigação
            /// </summary>
            private string F_DT_VCTO = "";
            public string DT_VCTO
            {
                get { return F_DT_VCTO; }
                set { F_DT_VCTO = value.ToUpper(); }
            }

            /// <summary>
            /// Código de receita referente à obrigação, próprio da unidade da federação do contribuinte substituído.
            /// </summary>
            private string F_COD_REC = "";
            public string COD_REC
            {
                get { return F_COD_REC; }
                set { F_COD_REC = value.ToUpper(); }
            }

            /// <summary>
            /// Número do processo ou auto de infração ao qual a obrigação está vinculada, se houver
            /// </summary>
            private string F_NUM_PROC = "";
            public string NUM_PROC
            {
                get { return F_NUM_PROC; }
                set { F_NUM_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da origem do processo: 0- SEFAZ; 1- Justiça Federal; 2- Justiça Estadual; 9- Outros
            /// </summary>
            private string F_IND_PROC = "";
            public string IND_PROC
            {
                get { return F_IND_PROC; }
                set { F_IND_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição resumida do processo que embasou o lançamento
            /// </summary>
            private string F_PROC = "";
            public string PROC
            {
                get { return F_PROC; }
                set { F_PROC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar das obrigações a recolher
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            /// <summary>
            /// Informe o mês de referência no formato “mmaaaa”
            /// </summary>
            private string F_MES_REF = "";
            public string MES_REF
            {
                get { return F_MES_REF; }
                set { F_MES_REF = value.ToUpper(); }
            }

            public string GetRegistro_E250(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OR */
                    if (F_COD_OR.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_OR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_OR */
                    if (F_COD_OR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_OR não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OR */
                    if (F_COD_OR.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_OR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OR */
                    if (F_VL_OR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OR não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_VCTO */
                    if (F_DT_VCTO.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_VCTO não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_REC */
                    if (F_COD_REC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_REC não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PROC */
                    if (F_NUM_PROC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de NUM_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_PROC */
                    if (!(F_IND_PROC.Equals("0") || F_IND_PROC.Equals("1") || F_IND_PROC.Equals("2") || F_IND_PROC.Equals("9")))
                    {
                        return "Erro - O campo IND_PROC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PROC */
                    if (F_IND_PROC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo MES_REF */
                    if (F_MES_REF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de MES_REF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo MES_REF */
                    if (F_MES_REF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório MES_REF não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_OR, F_VL_OR, F_DT_VCTO, F_COD_REC, F_NUM_PROC, F_IND_PROC, F_PROC, F_TXT_COMPL, F_MES_REF);
            }
        }

        /// <summary>
        /// PERÍODO DE APURAÇÃO DO IPI.
        /// </summary>
        public class Registro_E500
        {
            /// <summary>
            /// Texto fixo contendo "E500"
            /// </summary>
            private string F_REG = "E500";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador de período de apuração do IPI: 0 - Mensal; 1 - Decendial
            /// </summary>
            private string F_IND_APUR = "";
            public string IND_APUR
            {
                get { return F_IND_APUR; }
                set { F_IND_APUR = value.ToUpper(); }
            }

            /// <summary>
            /// Data inicial a que a apuração se refere
            /// </summary>
            private string F_DT_INI = "";
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Data final a que a apuração se refere
            /// </summary>
            private string F_DT_FIN = "";
            public string DT_FIN
            {
                get { return F_DT_FIN; }
                set { F_DT_FIN = value.ToUpper(); }
            }

            public string GetRegistro_E500(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo IND_APUR */
                    if (F_IND_APUR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_APUR não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_APUR */
                    if (!(F_IND_APUR.Equals("0") || F_IND_APUR.Equals("1")))
                    {
                        return "Erro - O campo IND_APUR possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (F_DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (F_DT_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIN */
                    if (F_DT_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIN não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_IND_APUR, F_DT_INI, F_DT_FIN);
            }
        }

        /// <summary>
        /// CONSOLIDAÇÃO DOS VALORES DO IPI.
        /// </summary>
        public class Registro_E510
        {
            /// <summary>
            /// Texto fixo contendo "E510"
            /// </summary>
            private string F_REG = "E510";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação do agrupamento de itens
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária referente ao IPI, conforme a Tabela indicada no item 4.3.2.
            /// </summary>
            private string F_CST_IPI = "";
            public string CST_IPI
            {
                get { return F_CST_IPI; }
                set { F_CST_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor Contábil" referente ao CFOP e ao Código de Tributação do IPI
            /// </summary>
            private string F_VL_CONT_IPI = "";
            public string VL_CONT_IPI
            {
                get { return F_VL_CONT_IPI; }
                set { F_VL_CONT_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do IPI" referente ao CFOP e ao Código de Tributação do IPI, para operações tributadas
            /// </summary>
            private string F_VL_BC_IPI = "";
            public string VL_BC_IPI
            {
                get { return F_VL_BC_IPI; }
                set { F_VL_BC_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor do IPI" referente ao CFOP e ao Código de Tributação do IPI, para operações tributadas
            /// </summary>
            private string F_VL_IPI = "";
            public string VL_IPI
            {
                get { return F_VL_IPI; }
                set { F_VL_IPI = value.ToUpper(); }
            }

            public string GetRegistro_E510(bool Validate)
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
                    /* validacao para o tamanho do campo CFOP */
                    if (F_CFOP.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de CFOP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CFOP */
                    if (F_CFOP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CFOP não informado(a)";
                    }
                    /* validacao para o tamanho do campo CST_IPI */
                    if (F_CST_IPI.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CST_IPI */
                    if (F_CST_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CST_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo CST_IPI */
                    if (F_CST_IPI.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_CONT_IPI */
                    if (F_VL_CONT_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_CONT_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo CST_IPI */
                    if (F_CST_IPI.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_IPI */
                    if (F_VL_BC_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo CST_IPI */
                    if (F_CST_IPI.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_IPI */
                    if (F_VL_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_IPI não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_CFOP, F_CST_IPI, F_VL_CONT_IPI, F_VL_BC_IPI, F_VL_IPI);
            }
        }

        /// <summary>
        /// APURAÇÃO DO IPI.
        /// </summary>
        public class Registro_E520
        {
            /// <summary>
            /// Texto fixo contendo "E520"
            /// </summary>
            private string F_REG = "E520";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Saldo credor do IPI transferido do período anterior
            /// </summary>
            private string F_VL_SD_ANT_IPI = "";
            public string VL_SD_ANT_IPI
            {
                get { return F_VL_SD_ANT_IPI; }
                set { F_VL_SD_ANT_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos débitos por "Saídas com débito do imposto"
            /// </summary>
            private string F_VL_DEB_IPI = "";
            public string VL_DEB_IPI
            {
                get { return F_VL_DEB_IPI; }
                set { F_VL_DEB_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos créditos por "Entradas e aquisições com crédito do imposto"
            /// </summary>
            private string F_VL_CRED_IPI = "";
            public string VL_CRED_IPI
            {
                get { return F_VL_CRED_IPI; }
                set { F_VL_CRED_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de "Outros débitos" do IPI (inclusive estornos de crédito)
            /// </summary>
            private string F_VL_OD_IPI = "";
            public string VL_OD_IPI
            {
                get { return F_VL_OD_IPI; }
                set { F_VL_OD_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de "Outros créditos" do IPI (inclusive estornos de débitos)
            /// </summary>
            private string F_VL_OC_IPI = "";
            public string VL_OC_IPI
            {
                get { return F_VL_OC_IPI; }
                set { F_VL_OC_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do saldo credor do IPI a transportar para o período seguinte
            /// </summary>
            private string F_VL_SC_IPI = "";
            public string VL_SC_IPI
            {
                get { return F_VL_SC_IPI; }
                set { F_VL_SC_IPI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do saldo devedor do IPI a recolher
            /// </summary>
            private string F_VL_SD_IPI = "";
            public string VL_SD_IPI
            {
                get { return F_VL_SD_IPI; }
                set { F_VL_SD_IPI = value.ToUpper(); }
            }

            public string GetRegistro_E520(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_SD_ANT_IPI */
                    if (F_VL_SD_ANT_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SD_ANT_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DEB_IPI */
                    if (F_VL_DEB_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DEB_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_CRED_IPI */
                    if (F_VL_CRED_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_CRED_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OD_IPI */
                    if (F_VL_OD_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OD_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OC_IPI */
                    if (F_VL_OC_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OC_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SC_IPI */
                    if (F_VL_SC_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SC_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SD_IPI */
                    if (F_VL_SD_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SD_IPI não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_VL_SD_ANT_IPI, F_VL_DEB_IPI, F_VL_CRED_IPI, F_VL_OD_IPI, F_VL_OC_IPI, F_VL_SC_IPI, F_VL_SD_IPI);
            }
        }

        /// <summary>
        /// AJUSTES DA APURAÇÃO DO IPI.
        /// </summary>
        public class Registro_E530
        {
            /// <summary>
            /// Texto fixo contendo "E530"
            /// </summary>
            private string F_REG = "E530";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de ajuste: 0- Ajuste a débito; 1- Ajuste a crédito
            /// </summary>
            private string F_IND_AJ = "";
            public string IND_AJ
            {
                get { return F_IND_AJ; }
                set { F_IND_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ajuste
            /// </summary>
            private string F_VL_AJ = "";
            public string VL_AJ
            {
                get { return F_VL_AJ; }
                set { F_VL_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Código do ajuste da apuração, conforme a Tabela indicada no item 4.5.4.
            /// </summary>
            private string F_COD_AJ = "";
            public string COD_AJ
            {
                get { return F_COD_AJ; }
                set { F_COD_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da origem do documento vinculado ao ajuste: 0 - Processo Judicial; 1 - Processo Administrativo; 2 - PER/DCOMP; 9 - Outros.
            /// </summary>
            private string F_IND_DOC = "";
            public string IND_DOC
            {
                get { return F_IND_DOC; }
                set { F_IND_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento / processo / declaração ao qual o ajuste está vinculado, se houver
            /// </summary>
            private string F_NUM_DOC = "";
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição detalhada do ajuste, com citação dos documentos fiscais.
            /// </summary>
            private string F_DESCR_AJ = "";
            public string DESCR_AJ
            {
                get { return F_DESCR_AJ; }
                set { F_DESCR_AJ = value.ToUpper(); }
            }

            public string GetRegistro_E530(bool Validate)
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
                    /* validacao para o tamanho do campo IND_AJ */
                    if (F_IND_AJ.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_AJ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_AJ */
                    if (F_IND_AJ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_AJ não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_AJ */
                    if (!(F_IND_AJ.Equals("0") || F_IND_AJ.Equals("1")))
                    {
                        return "Erro - O campo IND_AJ possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_AJ */
                    if (F_IND_AJ.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_AJ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_AJ */
                    if (F_VL_AJ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_AJ não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ */
                    if (F_COD_AJ.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_AJ */
                    if (F_COD_AJ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_AJ não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_DOC */
                    if (F_IND_DOC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_DOC incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_DOC */
                    if (!(F_IND_DOC.Equals("0") || F_IND_DOC.Equals("1") || F_IND_DOC.Equals("2") || F_IND_DOC.Equals("9")))
                    {
                        return "Erro - O campo IND_DOC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_DOC */
                    if (F_IND_DOC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_DOC */
                    if (F_IND_DOC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_AJ */
                    if (F_DESCR_AJ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_AJ não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_IND_AJ, F_VL_AJ, F_COD_AJ, F_IND_DOC, F_NUM_DOC, F_DESCR_AJ);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO E
        /// </summary>
        public class Registro_E990
        {
            /// <summary>
            /// Texto fixo contendo "E990"
            /// </summary>
            private string F_REG = "E990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco E
            /// </summary>
            private string F_QTD_LIN_E = "";
            public string QTD_LIN_E
            {
                get { return F_QTD_LIN_E; }
                set { F_QTD_LIN_E = value.ToUpper(); }
            }

            public string GetRegistro_E990(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo QTD_LIN_E */
                    if (F_QTD_LIN_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_E não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_E);
            }
        }
    }
}
