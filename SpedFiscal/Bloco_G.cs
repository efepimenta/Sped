using System;
namespace SpedFiscal
{
    public class Bloco_G
    {
        /// <summary>
        /// ABERTURA DO BLOCO G
        /// </summary>
        public class Registro_G001
        {
            /// <summary>
            /// Texto fixo contendo "G001"
            /// </summary>
            private string F_REG = "G001";
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

            public string GetRegistro_G001(bool Validate)
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
        /// ATIVO PERMANENTE – CIAP
        /// </summary>
        public class Registro_G110
        {
            /// <summary>
            /// Texto fixo contendo "G110"
            /// </summary>
            private string F_REG = "G110";
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

            /// <summary>
            /// Saldo inicial de ICMS do CIAP, composto por ICMS de bens que entraram anteriormente ao período de apuração (somatório dos campos 05 a 08 dos registros G125)
            /// </summary>
            private string F_SALDO_IN_ICMS = "";
            public string SALDO_IN_ICMS
            {
                get { return F_SALDO_IN_ICMS; }
                set { F_SALDO_IN_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Somatório das parcelas de ICMS passível de apropriação de cada bem (campo 10 do G125)
            /// </summary>
            private string F_SOM_PARC = "";
            public string SOM_PARC
            {
                get { return F_SOM_PARC; }
                set { F_SOM_PARC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do somatório das saídas tributadas e saídas para exportação
            /// </summary>
            private string F_VL_TRIB_EXP = "";
            public string VL_TRIB_EXP
            {
                get { return F_VL_TRIB_EXP; }
                set { F_VL_TRIB_EXP = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de saídas
            /// </summary>
            private string F_VL_TOTAL = "";
            public string VL_TOTAL
            {
                get { return F_VL_TOTAL; }
                set { F_VL_TOTAL = value.ToUpper(); }
            }

            /// <summary>
            /// Índice de participação do valor do somatório das saídas tributadas e saídas para exportação no valor total de saídas (Campo 06 dividido pelo campo 07)
            /// </summary>
            private string F_IND_PER_SAI = "";
            public string IND_PER_SAI
            {
                get { return F_IND_PER_SAI; }
                set { F_IND_PER_SAI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de ICMS a ser apropriado na apuração do ICMS, correspondente á multiplicação do campo 05 pelo campo 08.
            /// </summary>
            private string F_ICMS_APROP = "";
            public string ICMS_APROP
            {
                get { return F_ICMS_APROP; }
                set { F_ICMS_APROP = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de outros créditos a ser apropriado na Apuração do ICMS, correspondente ao somatório do campo 09 do registro G126.
            /// </summary>
            private string F_SOM_ICMS_OC = "";
            public string SOM_ICMS_OC
            {
                get { return F_SOM_ICMS_OC; }
                set { F_SOM_ICMS_OC = value.ToUpper(); }
            }

            public string GetRegistro_G110(bool Validate)
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
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo SALDO_IN_ICMS */
                    if (F_SALDO_IN_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório SALDO_IN_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo SOM_PARC */
                    if (F_SOM_PARC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório SOM_PARC não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TRIB_EXP */
                    if (F_VL_TRIB_EXP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TRIB_EXP não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOTAL */
                    if (F_VL_TOTAL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOTAL não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_PER_SAI */
                    if (F_IND_PER_SAI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_PER_SAI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ICMS_APROP */
                    if (F_ICMS_APROP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ICMS_APROP não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo SOM_ICMS_OC */
                    if (F_SOM_ICMS_OC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório SOM_ICMS_OC não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_DT_INI, F_DT_FIN, F_SALDO_IN_ICMS, F_SOM_PARC, F_VL_TRIB_EXP, F_VL_TOTAL, F_IND_PER_SAI, F_ICMS_APROP, F_SOM_ICMS_OC);
            }
        }

        /// <summary>
        /// MOVIMENTAÇÃO DE BEM OU COMPONENTE DO ATIVO IMOBILIZADO
        /// </summary>
        public class Registro_G125
        {
            /// <summary>
            /// Texto fixo contendo "G125"
            /// </summary>
            private string F_REG = "G125";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código individualizado do bem ou componente adotado no controle patrimonial do estabelecimento informante
            /// </summary>
            private string F_COD_IND_BEM = "";
            public string COD_IND_BEM
            {
                get { return F_COD_IND_BEM; }
                set { F_COD_IND_BEM = value.ToUpper(); }
            }

            /// <summary>
            /// Data da movimentação ou do saldo inicial
            /// </summary>
            private string F_DT_MOV = "";
            public string DT_MOV
            {
                get { return F_DT_MOV; }
                set { F_DT_MOV = value.ToUpper(); }
            }

            /// <summary>
            /// Tipo de movimentação do bem ou componente: SI - Saldo inicial de bens imobilizados; IM - Imobilização de bem individual; IA - Imobilização em Andamento - Componente; CI - Conclusão de Imobilização em Andamento > Bem Resultante; MC - Imobilização oriunda do Ativo Circulante; BA - Baixa do bem - Fim do período de apropriação; AT - Alienação ou Transferência; PE - Perecimento, Extravio ou Deterioração; OT - Outras Saídas do Imobilizado
            /// </summary>
            private string F_TIPO_MOV = "";
            public string TIPO_MOV
            {
                get { return F_TIPO_MOV; }
                set { F_TIPO_MOV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS da Operação Própria na entrada do bem ou componente
            /// </summary>
            private string F_VL_IMOB_ICMS_OP = "";
            public string VL_IMOB_ICMS_OP
            {
                get { return F_VL_IMOB_ICMS_OP; }
                set { F_VL_IMOB_ICMS_OP = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS da Oper. por Sub. Tributária na entrada do bem ou componente
            /// </summary>
            private string F_VL_IMOB_ICMS_ST = "";
            public string VL_IMOB_ICMS_ST
            {
                get { return F_VL_IMOB_ICMS_ST; }
                set { F_VL_IMOB_ICMS_ST = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS sobre Frete do Conhecimento de Transporte na entrada do bem ou componente
            /// </summary>
            private string F_VL_IMOB_ICMS_FRT = "";
            public string VL_IMOB_ICMS_FRT
            {
                get { return F_VL_IMOB_ICMS_FRT; }
                set { F_VL_IMOB_ICMS_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS - Diferencial de Alíquota, conforme Doc. de Arrecadação, na entrada do bem ou componente
            /// </summary>
            private string F_VL_IMOB_ICMS_DIF = "";
            public string VL_IMOB_ICMS_DIF
            {
                get { return F_VL_IMOB_ICMS_DIF; }
                set { F_VL_IMOB_ICMS_DIF = value.ToUpper(); }
            }

            /// <summary>
            /// Número da parcela do ICMS
            /// </summary>
            private string F_NUM_PARC = "";
            public string NUM_PARC
            {
                get { return F_NUM_PARC; }
                set { F_NUM_PARC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da parcela de ICMS passível de apropriação (antes da aplicação da participação percentual do valor das saídas tributadas/exportação sobre as saídas totais)
            /// </summary>
            private string F_VL_PARC_PASS = "";
            public string VL_PARC_PASS
            {
                get { return F_VL_PARC_PASS; }
                set { F_VL_PARC_PASS = value.ToUpper(); }
            }

            public string GetRegistro_G125(bool Validate)
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
                    /* validacao para o tamanho do campo COD_IND_BEM */
                    if (F_COD_IND_BEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_IND_BEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_IND_BEM */
                    if (F_COD_IND_BEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_IND_BEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_MOV */
                    if (F_DT_MOV.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_MOV */
                    if (F_DT_MOV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_MOV não informado(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_MOV */
                    if (F_TIPO_MOV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TIPO_MOV */
                    if (F_TIPO_MOV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TIPO_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a TIPO_MOV */
                    if (!(F_TIPO_MOV.Equals("SI") || F_TIPO_MOV.Equals("IM") || F_TIPO_MOV.Equals("IA") || F_TIPO_MOV.Equals("TO") || F_TIPO_MOV.Equals("CI") || F_TIPO_MOV.Equals("MC") || F_TIPO_MOV.Equals("BA") || F_TIPO_MOV.Equals("EM") || F_TIPO_MOV.Equals("AT") || F_TIPO_MOV.Equals("PE") || F_TIPO_MOV.Equals("OT")))
                    {
                        return "Erro - O campo TIPO_MOV possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo TIPO_MOV */
                    if (F_TIPO_MOV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_MOV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_MOV */
                    if (F_TIPO_MOV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_MOV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_MOV */
                    if (F_TIPO_MOV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_MOV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_MOV */
                    if (F_TIPO_MOV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_MOV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_IND_BEM, F_DT_MOV, F_TIPO_MOV, F_VL_IMOB_ICMS_OP, F_VL_IMOB_ICMS_ST, F_VL_IMOB_ICMS_FRT, F_VL_IMOB_ICMS_DIF, F_NUM_PARC, F_VL_PARC_PASS);
            }
        }

        /// <summary>
        /// OUTROS CRÉDITOS CIAP
        /// </summary>
        public class Registro_G126
        {
            /// <summary>
            /// Texto fixo contendo "G126"
            /// </summary>
            private string F_REG = "G126";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data inicial do período de apuração
            /// </summary>
            private string F_DT_INI = "";
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Data final do período de apuração
            /// </summary>
            private string F_DT_FIM = "";
            public string DT_FIM
            {
                get { return F_DT_FIM; }
                set { F_DT_FIM = value.ToUpper(); }
            }

            /// <summary>
            /// Número da parcela do ICMS
            /// </summary>
            private string F_NUM_PARC = "";
            public string NUM_PARC
            {
                get { return F_NUM_PARC; }
                set { F_NUM_PARC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da parcela de ICMS passível de apropriação - antes da aplicação da participação percentual do valor das saídas tributadas/exportação sobre as saídas totais
            /// </summary>
            private string F_VL_PARC_PASS = "";
            public string VL_PARC_PASS
            {
                get { return F_VL_PARC_PASS; }
                set { F_VL_PARC_PASS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do somatório das saídas tributadas e saídas para exportação no período indicado neste registro
            /// </summary>
            private string F_VL_TRIB_OC = "";
            public string VL_TRIB_OC
            {
                get { return F_VL_TRIB_OC; }
                set { F_VL_TRIB_OC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total de saídas no período indicado neste registro
            /// </summary>
            private string F_VL_TOTAL = "";
            public string VL_TOTAL
            {
                get { return F_VL_TOTAL; }
                set { F_VL_TOTAL = value.ToUpper(); }
            }

            /// <summary>
            /// Índice de participação do valor do somatório das saídas tributadas e saídas para exportação no valor total de saídas (Campo 06 dividido pelo campo 07)
            /// </summary>
            private string F_IND_PER_SAI = "";
            public string IND_PER_SAI
            {
                get { return F_IND_PER_SAI; }
                set { F_IND_PER_SAI = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de outros créditos de ICMS a ser apropriado na apuração (campo 05 vezes o campo 08)
            /// </summary>
            private string F_VL_PARC_APROP = "";
            public string VL_PARC_APROP
            {
                get { return F_VL_PARC_APROP; }
                set { F_VL_PARC_APROP = value.ToUpper(); }
            }

            public string GetRegistro_G126(bool Validate)
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
                    /* validacao para o tamanho do campo DT_FIM */
                    if (F_DT_FIM.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIM */
                    if (F_DT_FIM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIM não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_PARC */
                    if (F_NUM_PARC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_PARC não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_PARC_PASS */
                    if (F_VL_PARC_PASS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_PARC_PASS não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TRIB_OC */
                    if (F_VL_TRIB_OC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TRIB_OC não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_TOTAL */
                    if (F_VL_TOTAL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_TOTAL não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_PER_SAI */
                    if (F_IND_PER_SAI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_PER_SAI não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_PARC_APROP */
                    if (F_VL_PARC_APROP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_PARC_APROP não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_DT_INI, F_DT_FIM, F_NUM_PARC, F_VL_PARC_PASS, F_VL_TRIB_OC, F_VL_TOTAL, F_IND_PER_SAI, F_VL_PARC_APROP);
            }
        }

        /// <summary>
        /// IDENTIFICAÇÃO DO DOCUMENTO FISCAL
        /// </summary>
        public class Registro_G130
        {
            /// <summary>
            /// Texto fixo contendo "G130"
            /// </summary>
            private string F_REG = "G130";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do emitente do documento fiscal: 0- Emissão própria; 1- Terceiros
            /// </summary>
            private string F_IND_EMIT = "";
            public string IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante : do emitente do documento ou do remetente das mercadorias, no caso de entradas; do adquirente, no caso de saídas
            /// </summary>
            private string F_COD_PART = "";
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            /// <summary>
            /// Código do modelo de documento fiscal, conforme tabela 4.1.1
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
            private string F_SERIE = "";
            public string SERIE
            {
                get { return F_SERIE; }
                set { F_SERIE = value.ToUpper(); }
            }

            /// <summary>
            /// Número de documento fiscal
            /// </summary>
            private string F_NUM_DOC = "";
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Chave do documento fiscal eletrônico
            /// </summary>
            private string F_CHV_NFE_CTE = "";
            public string CHV_NFE_CTE
            {
                get { return F_CHV_NFE_CTE; }
                set { F_CHV_NFE_CTE = value.ToUpper(); }
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

            public string GetRegistro_G130(bool Validate)
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
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_EMIT */
                    if (F_IND_EMIT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_EMIT não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_EMIT */
                    if (!(F_IND_EMIT.Equals("0") || F_IND_EMIT.Equals("1")))
                    {
                        return "Erro - O campo IND_EMIT possui valores pré-definidos";
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
                    /* validacao para o tamanho do campo SERIE */
                    if (F_SERIE.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SERIE incorreto(a)";
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
                    /* validacao para o tamanho do campo CHV_NFE_CTE */
                    if (F_CHV_NFE_CTE.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_NFE_CTE incorreto(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_SERIE, F_NUM_DOC, F_CHV_NFE_CTE, F_DT_DOC);
            }
        }

        /// <summary>
        /// IDENTIFICAÇÃO DO ITEM DO DOCUMENTO FISCAL
        /// </summary>
        public class Registro_G140
        {
            /// <summary>
            /// Texto fixo contendo "G140"
            /// </summary>
            private string F_REG = "G140";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número sequencial do item no documento fiscal
            /// </summary>
            private string F_NUM_ITEM = "";
            public string NUM_ITEM
            {
                get { return F_NUM_ITEM; }
                set { F_NUM_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Código correspondente do bem no documento fiscal (campo 02 do registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            public string GetRegistro_G140(bool Validate)
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
                    /* validacao para o tamanho do campo NUM_ITEM */
                    if (F_NUM_ITEM.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_ITEM */
                    if (F_NUM_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM */
                    if (F_COD_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_NUM_ITEM, F_COD_ITEM);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO G
        /// </summary>
        public class Registro_G990
        {
            /// <summary>
            /// Texto fixo contendo "G990"
            /// </summary>
            private string F_REG = "G990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco G
            /// </summary>
            private string F_QTD_LIN_G = "";
            public string QTD_LIN_G
            {
                get { return F_QTD_LIN_G; }
                set { F_QTD_LIN_G = value.ToUpper(); }
            }

            public string GetRegistro_G990(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo QTD_LIN_G */
                    if (F_QTD_LIN_G.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_G não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_G);
            }
        }
    }
}
