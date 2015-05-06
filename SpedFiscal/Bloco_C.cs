using System;

namespace SpedFiscal
{
    public class Bloco_C
    {
        /// <summary>
        /// ABERTURA DO BLOCO C
        /// </summary>
        public class Registro_C001
        {
            private string F_REG = "C001";
            /// <summary>
            /// Texto fixo contendo "C001"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_MOV = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados
            /// </summary>
            public string IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            public string GetRegistro_C001(bool Validate)
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
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|", F_REG, F_IND_MOV);
            }
        }

        /// <summary>
        /// NOTA FISCAL (CÓDIGO 01), NOTA FISCAL AVULSA (CÓDIGO 1B), NOTA FISCAL DE PRODUTOR (CÓDIGO 04), NF-e (CÓDIGO 55) e NFC-e (CÓDIGO 65).
        /// </summary>
        public class Registro_C100
        {
            private string F_REG = "C100";
            /// <summary>
            /// Texto fixo contendo "C100"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_OPER = "";
            /// <summary>
            /// Indicador do tipo de operação: 0- Entrada; 1- Saída
            /// </summary>
            public string IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value.ToUpper(); }
            }

            private string F_IND_EMIT = "";
            /// <summary>
            /// Indicador do emitente do documento fiscal: 0- Emissão própria; 1- Terceiros
            /// </summary>
            public string IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): > do emitente do documento ou do remetente das mercadorias, no caso de entradas; > do adquirente, no caso de saídas
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_COD_SIT = "";
            /// <summary>
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
            }

            private string F_SER = "";
            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_CHV_NFE = "";
            /// <summary>
            /// Chave da Nota Fiscal Eletrônica
            /// </summary>
            public string CHV_NFE
            {
                get { return F_CHV_NFE; }
                set { F_CHV_NFE = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_DT_E_S = "";
            /// <summary>
            /// Data da entrada ou da saída
            /// </summary>
            public string DT_E_S
            {
                get { return F_DT_E_S; }
                set { F_DT_E_S = value.ToUpper(); }
            }

            private string F_VL_DOC = "";
            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            private string F_IND_PGTO = "";
            /// <summary>
            /// Indicador do tipo de pagamento: 0- À vista; 1- A prazo; 2 - Outros
            /// </summary>
            public string IND_PGTO
            {
                get { return F_IND_PGTO; }
                set { F_IND_PGTO = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor total do desconto
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_VL_ABAT_NT = "";
            /// <summary>
            /// Abatimento não tributado e não comercial Ex. desconto ICMS nas remessas para ZFM.
            /// </summary>
            public string VL_ABAT_NT
            {
                get { return F_VL_ABAT_NT; }
                set { F_VL_ABAT_NT = value.ToUpper(); }
            }

            private string F_VL_MERC = "";
            /// <summary>
            /// Valor total das mercadorias e serviços N - 02 O OC. 17 IND_FRT Indicador do tipo do frete: 0- Por conta do emitente; 1- Por conta do destinatário/remetente; 2- Por conta de terceiros; 9- Sem cobrança de frete.
            /// </summary>
            public string VL_MERC
            {
                get { return F_VL_MERC; }
                set { F_VL_MERC = value.ToUpper(); }
            }

            private string F_VL_FRT = "";
            /// <summary>
            /// Valor do frete indicado no documento fiscal
            /// </summary>
            public string VL_FRT
            {
                get { return F_VL_FRT; }
                set { F_VL_FRT = value.ToUpper(); }
            }

            private string F_VL_SEG = "";
            /// <summary>
            /// Valor do seguro indicado no documento fiscal
            /// </summary>
            public string VL_SEG
            {
                get { return F_VL_SEG; }
                set { F_VL_SEG = value.ToUpper(); }
            }

            private string F_VL_OUT_DA = "";
            /// <summary>
            /// Valor de outras despesas acessórias
            /// </summary>
            public string VL_OUT_DA
            {
                get { return F_VL_OUT_DA; }
                set { F_VL_OUT_DA = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor do ICMS
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS_ST = "";
            /// <summary>
            /// Valor da base de cálculo do ICMS substituição tributária
            /// </summary>
            public string VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value.ToUpper(); }
            }

            private string F_VL_ICMS_ST = "";
            /// <summary>
            /// Valor do ICMS retido por substituição tributária
            /// </summary>
            public string VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value.ToUpper(); }
            }

            private string F_VL_IPI = "";
            /// <summary>
            /// Valor total do IPI
            /// </summary>
            public string VL_IPI
            {
                get { return F_VL_IPI; }
                set { F_VL_IPI = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor total do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_VL_PIS_ST = "";
            /// <summary>
            /// Valor total do PIS retido por substituição tributária
            /// </summary>
            public string VL_PIS_ST
            {
                get { return F_VL_PIS_ST; }
                set { F_VL_PIS_ST = value.ToUpper(); }
            }

            private string F_VL_COFINS_ST = "";
            /// <summary>
            /// Valor total da COFINS retido por substituição tributária
            /// </summary>
            public string VL_COFINS_ST
            {
                get { return F_VL_COFINS_ST; }
                set { F_VL_COFINS_ST = value.ToUpper(); }
            }

            public string GetRegistro_C100(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_OPER */
                    if (F_IND_OPER.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_OPER incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_OPER */
                    if (!(F_IND_OPER.Equals("0") || F_IND_OPER.Equals("1")))
                    {
                        return "Erro -> O campo IND_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_EMIT */
                    if (!(F_IND_EMIT.Equals("0") || F_IND_EMIT.Equals("1")))
                    {
                        return "Erro -> O campo IND_EMIT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_SIT */
                    if (F_COD_SIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_SIT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SER */
                    if (F_SER.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SER incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_NFE */
                    if (F_CHV_NFE.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_NFE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PGTO */
                    if (F_IND_PGTO.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PGTO incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_PGTO */
                    if (!(F_IND_PGTO.Equals("0") || F_IND_PGTO.Equals("1") || F_IND_PGTO.Equals("2")))
                    {
                        return "Erro -> O campo IND_PGTO possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_PGTO */
                    if (F_IND_PGTO.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PGTO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PGTO */
                    if (F_IND_PGTO.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PGTO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* Validacao para os dados informados a VL_MERC */
                    if (!(F_VL_MERC.Equals("N") || F_VL_MERC.Equals("0") || F_VL_MERC.Equals("1") || F_VL_MERC.Equals("2") || F_VL_MERC.Equals("9")))
                    {
                        return "Erro -> O campo VL_MERC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_MERC */
                    if (F_VL_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de VL_MERC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_NUM_DOC, F_CHV_NFE, F_DT_DOC, F_DT_E_S, F_VL_DOC, F_IND_PGTO, F_VL_DESC, F_VL_ABAT_NT, F_VL_MERC, F_VL_FRT, F_VL_SEG, F_VL_OUT_DA, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_ST, F_VL_ICMS_ST, F_VL_IPI, F_VL_PIS, F_VL_COFINS, F_VL_PIS_ST, F_VL_COFINS_ST);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM ICMS ST RECOLHIDO PARA UF DIVERSA DO DESTINATÁRIO DO DOCUMENTO FISCAL (CÓDIGO 55).
        /// </summary>
        public class Registro_C105
        {
            private string F_REG = "C105";
            /// <summary>
            /// Texto fixo contendo "C105"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_OPER = "";
            /// <summary>
            /// Indicador do tipo de operação: 0- Combustíveis e Lubrificantes; 1- leasing de veículos ou faturamento direto.
            /// </summary>
            public string OPER
            {
                get { return F_OPER; }
                set { F_OPER = value.ToUpper(); }
            }

            private string F_UF = "";
            /// <summary>
            /// Sigla da UF de destino do ICMS_ST
            /// </summary>
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            public string GetRegistro_C105(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo OPER */
                    if (F_OPER.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de OPER incorreto(a)";
                    }
                    /* Validacao para os dados informados a OPER */
                    if (!(F_OPER.Equals("0") || F_OPER.Equals("1")))
                    {
                        return "Erro -> O campo OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_OPER, F_UF);
            }
        }

        /// <summary>
        /// INFORMAÇÃO COMPLEMENTAR DA NOTA FISCAL (CÓDIGO 01, 1B, 04 e 55).
        /// </summary>
        public class Registro_C110
        {
            private string F_REG = "C110";
            /// <summary>
            /// Texto fixo contendo "C110"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_INF = "";
            /// <summary>
            /// Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            public string COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value.ToUpper(); }
            }

            private string F_TXT_COMPL = "";
            /// <summary>
            /// Descrição complementar do código de referência.
            /// </summary>
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_C110(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_INF, F_TXT_COMPL);
            }
        }

        /// <summary>
        /// PROCESSO REFERENCIADO
        /// </summary>
        public class Registro_C111
        {
            private string F_REG = "C111";
            /// <summary>
            /// Texto fixo contendo "C111"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_PROC = "";
            /// <summary>
            /// Identificação do processo ou ato concessório.
            /// </summary>
            public string NUM_PROC
            {
                get { return F_NUM_PROC; }
                set { F_NUM_PROC = value.ToUpper(); }
            }

            private string F_IND_PROC = "";
            /// <summary>
            /// Indicador da origem do processo: 0 - SEFAZ; 1 - Justiça Federal; 2 - Justiça Estadual; 3 - SECEX/SRF 9 - Outros.
            /// </summary>
            public string IND_PROC
            {
                get { return F_IND_PROC; }
                set { F_IND_PROC = value.ToUpper(); }
            }

            public string GetRegistro_C111(bool Validate)
            {
                if (Validate)
                {
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
                    if (!(F_IND_PROC.Equals("0") || F_IND_PROC.Equals("1") || F_IND_PROC.Equals("2") || F_IND_PROC.Equals("3") || F_IND_PROC.Equals("9")))
                    {
                        return "Erro -> O campo IND_PROC possui valores pré-definidos";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_NUM_PROC, F_IND_PROC);
            }
        }

        /// <summary>
        /// DOCUMENTO DE ARRECADAÇÃO REFERENCIADO.
        /// </summary>
        public class Registro_C112
        {
            private string F_REG = "C112";
            /// <summary>
            /// Texto fixo contendo "C112"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_DA = "";
            /// <summary>
            /// Código do modelo do documento de arrecadação : 0 - documento estadual de arrecadação 1 - GNRE
            /// </summary>
            public string COD_DA
            {
                get { return F_COD_DA; }
                set { F_COD_DA = value.ToUpper(); }
            }

            private string F_UF = "";
            /// <summary>
            /// Unidade federada beneficiária do recolhimento
            /// </summary>
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            private string F_NUM_DA = "";
            /// <summary>
            /// Número do documento de arrecadação
            /// </summary>
            public string NUM_DA
            {
                get { return F_NUM_DA; }
                set { F_NUM_DA = value.ToUpper(); }
            }

            private string F_COD_AUT = "";
            /// <summary>
            /// Código completo da autenticação bancária
            /// </summary>
            public string COD_AUT
            {
                get { return F_COD_AUT; }
                set { F_COD_AUT = value.ToUpper(); }
            }

            private string F_VL_DA = "";
            /// <summary>
            /// Valor do total do documento de arrecadação (principal, atualização monetária, juros e multa)
            /// </summary>
            public string VL_DA
            {
                get { return F_VL_DA; }
                set { F_VL_DA = value.ToUpper(); }
            }

            private string F_DT_VCTO = "";
            /// <summary>
            /// Data de vencimento do documento de arrecadação
            /// </summary>
            public string DT_VCTO
            {
                get { return F_DT_VCTO; }
                set { F_DT_VCTO = value.ToUpper(); }
            }

            private string F_DT_PGTO = "";
            /// <summary>
            /// Data de pagamento do documento de arrecadação, ou data do vencimento, no caso de ICMS antecipado a recolher.
            /// </summary>
            public string DT_PGTO
            {
                get { return F_DT_PGTO; }
                set { F_DT_PGTO = value.ToUpper(); }
            }

            public string GetRegistro_C112(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_DA */
                    if (F_COD_DA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de COD_DA incorreto(a)";
                    }
                    /* Validacao para os dados informados a COD_DA */
                    if (!(F_COD_DA.Equals("0") || F_COD_DA.Equals("1")))
                    {
                        return "Erro -> O campo COD_DA possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_PGTO */
                    if (F_DT_PGTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_PGTO incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_COD_DA, F_UF, F_NUM_DA, F_COD_AUT, F_VL_DA, F_DT_VCTO, F_DT_PGTO);
            }
        }

        /// <summary>
        /// DOCUMENTO FISCAL REFERENCIADO.
        /// </summary>
        public class Registro_C113
        {
            private string F_REG = "C113";
            /// <summary>
            /// Texto fixo contendo "C113"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_OPER = "";
            /// <summary>
            /// Indicador do tipo de operação: 0- Entrada/aquisição; 1- Saída/prestação
            /// </summary>
            public string IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value.ToUpper(); }
            }

            private string F_IND_EMIT = "";
            /// <summary>
            /// Indicador do emitente do título: 0- Emissão própria; 1- Terceiros
            /// </summary>
            public string IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código do participante emitente (campo 02 do Registro 0150) do documento referenciado.
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_SER = "";
            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            private string F_SUB = "";
            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            public string SUB
            {
                get { return F_SUB; }
                set { F_SUB = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal.
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            public string GetRegistro_C113(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_OPER */
                    if (F_IND_OPER.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_OPER incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_OPER */
                    if (!(F_IND_OPER.Equals("0") || F_IND_OPER.Equals("1")))
                    {
                        return "Erro -> O campo IND_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_EMIT */
                    if (!(F_IND_EMIT.Equals("0") || F_IND_EMIT.Equals("1")))
                    {
                        return "Erro -> O campo IND_EMIT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
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
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC);
            }
        }

        /// <summary>
        /// CUPOM FISCAL REFERENCIADO.
        /// </summary>
        public class Registro_C114
        {
            private string F_REG = "C114";
            /// <summary>
            /// Texto fixo contendo "C114"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a tabela indicada no item 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_ECF_FAB = "";
            /// <summary>
            /// Número de série de fabricação do ECF
            /// </summary>
            public string ECF_FAB
            {
                get { return F_ECF_FAB; }
                set { F_ECF_FAB = value.ToUpper(); }
            }

            private string F_ECF_CX = "";
            /// <summary>
            /// Número do caixa atribuído ao ECF
            /// </summary>
            public string ECF_CX
            {
                get { return F_ECF_CX; }
                set { F_ECF_CX = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            public string GetRegistro_C114(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ECF_FAB */
                    if (F_ECF_FAB.Length > 21)
                    {
                        return "Erro -> Tamanho do campo de ECF_FAB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ECF_CX */
                    if (F_ECF_CX.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de ECF_CX incorreto(a)";
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
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_COD_MOD, F_ECF_FAB, F_ECF_CX, F_NUM_DOC, F_DT_DOC);
            }
        }

        /// <summary>
        /// LOCAL DA COLETA E/OU ENTREGA (CÓDIGO 01, 1B E 04).
        /// </summary>
        public class Registro_C115
        {
            private string F_REG = "C115";
            /// <summary>
            /// Texto fixo contendo "C115"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_CARGA = "";
            /// <summary>
            /// Indicador do tipo de transporte: 0 – Rodoviário; 1 – Ferroviário; 2 – Rodo-Ferroviário; 3 – Aquaviário; 4 – Dutoviário; 5 – Aéreo; 9 – Outros.
            /// </summary>
            public string IND_CARGA
            {
                get { return F_IND_CARGA; }
                set { F_IND_CARGA = value.ToUpper(); }
            }

            private string F_CNPJ_COL = "";
            /// <summary>
            /// Número do CNPJ do contribuinte do local de coleta
            /// </summary>
            public string CNPJ_COL
            {
                get { return F_CNPJ_COL; }
                set { F_CNPJ_COL = value.ToUpper(); }
            }

            private string F_IE_COL = "";
            /// <summary>
            /// Inscrição Estadual do contribuinte do local de coleta
            /// </summary>
            public string IE_COL
            {
                get { return F_IE_COL; }
                set { F_IE_COL = value.ToUpper(); }
            }

            private string F_CPF_COL = "";
            /// <summary>
            /// CPF do contribuinte do local de coleta das mercadorias.
            /// </summary>
            public string CPF_COL
            {
                get { return F_CPF_COL; }
                set { F_CPF_COL = value.ToUpper(); }
            }

            private string F_COD_MUN_COL = "";
            /// <summary>
            /// Código do Município do local de coleta
            /// </summary>
            public string COD_MUN_COL
            {
                get { return F_COD_MUN_COL; }
                set { F_COD_MUN_COL = value.ToUpper(); }
            }

            private string F_CNPJ_ENTG = "";
            /// <summary>
            /// Número do CNPJ do contribuinte do local de entrega
            /// </summary>
            public string CNPJ_ENTG
            {
                get { return F_CNPJ_ENTG; }
                set { F_CNPJ_ENTG = value.ToUpper(); }
            }

            private string F_IE_ENTG = "";
            /// <summary>
            /// Inscrição Estadual do contribuinte do local de entrega
            /// </summary>
            public string IE_ENTG
            {
                get { return F_IE_ENTG; }
                set { F_IE_ENTG = value.ToUpper(); }
            }

            private string F_CPF_ENTG = "";
            /// <summary>
            /// Cpf do contribuinte do local de entrega
            /// </summary>
            public string CPF_ENTG
            {
                get { return F_CPF_ENTG; }
                set { F_CPF_ENTG = value.ToUpper(); }
            }

            private string F_COD_MUN_ENTG = "";
            /// <summary>
            /// Código do Município do local de entrega
            /// </summary>
            public string COD_MUN_ENTG
            {
                get { return F_COD_MUN_ENTG; }
                set { F_COD_MUN_ENTG = value.ToUpper(); }
            }

            public string GetRegistro_C115(bool Validate)
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
                    /* validacao para o tamanho do campo IND_CARGA */
                    if (F_IND_CARGA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_CARGA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_CARGA */
                    if (F_IND_CARGA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_CARGA não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_CARGA */
                    if (!(F_IND_CARGA.Equals("0") || F_IND_CARGA.Equals("1") || F_IND_CARGA.Equals("2") || F_IND_CARGA.Equals("3") || F_IND_CARGA.Equals("4") || F_IND_CARGA.Equals("5") || F_IND_CARGA.Equals("9")))
                    {
                        return "Erro -> O campo IND_CARGA possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo CNPJ_COL */
                    if (F_CNPJ_COL.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_COL */
                    if (F_IE_COL.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF_COL */
                    if (F_CPF_COL.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_COL */
                    if (F_COD_MUN_COL.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_ENTG */
                    if (F_CNPJ_ENTG.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_ENTG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_ENTG */
                    if (F_IE_ENTG.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_ENTG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF_ENTG */
                    if (F_CPF_ENTG.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF_ENTG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ENTG */
                    if (F_COD_MUN_ENTG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ENTG incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_IND_CARGA, F_CNPJ_COL, F_IE_COL, F_CPF_COL, F_COD_MUN_COL, F_CNPJ_ENTG, F_IE_ENTG, F_CPF_ENTG, F_COD_MUN_ENTG);
            }
        }

        /// <summary>
        /// CUPOM FISCAL ELETRÔNICO REFERENCIADO
        /// </summary>
        public class Registro_C116
        {
            private string F_REG = "C116";
            /// <summary>
            /// Texto fixo contendo "C116"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_NR_SAT = "";
            /// <summary>
            /// Número de Série do equipamento SAT
            /// </summary>
            public string NR_SAT
            {
                get { return F_NR_SAT; }
                set { F_NR_SAT = value.ToUpper(); }
            }

            private string F_CHV_CFE = "";
            /// <summary>
            /// Chave do Cupom Fiscal Eletrônico
            /// </summary>
            public string CHV_CFE
            {
                get { return F_CHV_CFE; }
                set { F_CHV_CFE = value.ToUpper(); }
            }

            private string F_NUM_CFE = "";
            /// <summary>
            /// Número do cupom fiscal eletrônico
            /// </summary>
            public string NUM_CFE
            {
                get { return F_NUM_CFE; }
                set { F_NUM_CFE = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            public string GetRegistro_C116(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NR_SAT */
                    if (F_NR_SAT.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NR_SAT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_CFE */
                    if (F_CHV_CFE.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CFE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_CFE */
                    if (F_NUM_CFE.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de NUM_CFE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_COD_MOD, F_NR_SAT, F_CHV_CFE, F_NUM_CFE, F_DT_DOC);
            }
        }

        /// <summary>
        /// COMPLEMENTO DE DOCUMENTO - OPERAÇÕES DE IMPORTAÇÃO (CÓDIGOS 01 e 55).
        /// </summary>
        public class Registro_C120
        {
            private string F_REG = "C120";
            /// <summary>
            /// Texto fixo contendo "C120"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_DOC_IMP = "";
            /// <summary>
            /// Documento de importação: 0 – Declaração de Importação; 1 – Declaração Simplificada de Importação.
            /// </summary>
            public string COD_DOC_IMP
            {
                get { return F_COD_DOC_IMP; }
                set { F_COD_DOC_IMP = value.ToUpper(); }
            }

            private string F_NUM_DOC__IM = "";
            /// <summary>
            /// P Número do documento de Importação.
            /// </summary>
            public string NUM_DOC__IM
            {
                get { return F_NUM_DOC__IM; }
                set { F_NUM_DOC__IM = value.ToUpper(); }
            }

            private string F_PIS_IMP = "";
            /// <summary>
            /// Valor pago de PIS na importação
            /// </summary>
            public string PIS_IMP
            {
                get { return F_PIS_IMP; }
                set { F_PIS_IMP = value.ToUpper(); }
            }

            private string F_COFINS_IMP = "";
            /// <summary>
            /// Valor pago de COFINS na importação
            /// </summary>
            public string COFINS_IMP
            {
                get { return F_COFINS_IMP; }
                set { F_COFINS_IMP = value.ToUpper(); }
            }

            private string F_NUM_ACDRAW = "";
            /// <summary>
            /// Número do Ato Concessório do regime Drawback
            /// </summary>
            public string NUM_ACDRAW
            {
                get { return F_NUM_ACDRAW; }
                set { F_NUM_ACDRAW = value.ToUpper(); }
            }

            public string GetRegistro_C120(bool Validate)
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
                    /* validacao para o tamanho do campo COD_DOC_IMP */
                    if (F_COD_DOC_IMP.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de COD_DOC_IMP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_DOC_IMP */
                    if (F_COD_DOC_IMP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_DOC_IMP não informado(a)";
                    }
                    /* Validacao dos dados passados a COD_DOC_IMP */
                    if (!(F_COD_DOC_IMP.Equals("0") || F_COD_DOC_IMP.Equals("1")))
                    {
                        return "Erro -> O campo COD_DOC_IMP possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo NUM_DOC__IM */
                    if (F_NUM_DOC__IM.Length > 12)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC__IM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC__IM */
                    if (F_NUM_DOC__IM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC__IM não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC__IM */
                    if (F_NUM_DOC__IM.Length > 12)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC__IM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC__IM */
                    if (F_NUM_DOC__IM.Length > 12)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC__IM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_ACDRAW */
                    if (F_NUM_ACDRAW.Length > 20)
                    {
                        return "Erro -> Tamanho do campo de NUM_ACDRAW incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_COD_DOC_IMP, F_NUM_DOC__IM, F_PIS_IMP, F_COFINS_IMP, F_NUM_ACDRAW);
            }
        }

        /// <summary>
        /// ISSQN, IRRF E PREVIDÊNCIA SOCIAL.
        /// </summary>
        public class Registro_C130
        {
            private string F_REG = "C130";
            /// <summary>
            /// Texto fixo contendo "C130"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_VL_SERV_NT = "";
            /// <summary>
            /// Valor dos serviços sob não-incidência ou nãotributados pelo ICMS
            /// </summary>
            public string VL_SERV_NT
            {
                get { return F_VL_SERV_NT; }
                set { F_VL_SERV_NT = value.ToUpper(); }
            }

            private string F_VL_BC_ISSQN = "";
            /// <summary>
            /// Valor da base de cálculo do ISSQN
            /// </summary>
            public string VL_BC_ISSQN
            {
                get { return F_VL_BC_ISSQN; }
                set { F_VL_BC_ISSQN = value.ToUpper(); }
            }

            private string F_VL_ISSQN = "";
            /// <summary>
            /// Valor do ISSQN
            /// </summary>
            public string VL_ISSQN
            {
                get { return F_VL_ISSQN; }
                set { F_VL_ISSQN = value.ToUpper(); }
            }

            private string F_VL_BC_IRRF = "";
            /// <summary>
            /// Valor da base de cálculo do Imposto de Renda Retido na Fonte
            /// </summary>
            public string VL_BC_IRRF
            {
                get { return F_VL_BC_IRRF; }
                set { F_VL_BC_IRRF = value.ToUpper(); }
            }

            private string F_VL_IRRF = "";
            /// <summary>
            /// Valor do Imposto de Renda - Retido na Fonte
            /// </summary>
            public string VL_IRRF
            {
                get { return F_VL_IRRF; }
                set { F_VL_IRRF = value.ToUpper(); }
            }

            private string F_VL_BC_PREV = "";
            /// <summary>
            /// Valor da base de cálculo de retenção da Previdência Social
            /// </summary>
            public string VL_BC_PREV
            {
                get { return F_VL_BC_PREV; }
                set { F_VL_BC_PREV = value.ToUpper(); }
            }

            private string F_VL_ = "";
            /// <summary>
            /// PREV Valor destacado para retenção da Previdência Social
            /// </summary>
            public string VL_
            {
                get { return F_VL_; }
                set { F_VL_ = value.ToUpper(); }
            }

            public string GetRegistro_C130(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_SERV_NT */
                    if (F_VL_SERV_NT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV_NT não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ISSQN */
                    if (F_VL_BC_ISSQN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ISSQN não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* Validacao para os dados informados a VL_IRRF */
                    if (!(F_VL_IRRF.Equals("DA")))
                    {
                        return "Erro -> O campo VL_IRRF possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_VL_SERV_NT, F_VL_BC_ISSQN, F_VL_ISSQN, F_VL_BC_IRRF, F_VL_IRRF, F_VL_BC_PREV, F_VL_);
            }
        }

        /// <summary>
        /// FATURA (CÓDIGO 01)
        /// </summary>
        public class Registro_C140
        {
            private string F_REG = "C140";
            /// <summary>
            /// Texto fixo contendo "C140"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_EMIT = "";
            /// <summary>
            /// Indicador do emitente do título: 0- Emissão própria; 1- Terceiros
            /// </summary>
            public string IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value.ToUpper(); }
            }

            private string F_IND_TIT = "";
            /// <summary>
            /// Indicador do tipo de título de crédito: 00- Duplicata; 01- Cheque; 02- Promissória; 03- Recibo; 99- Outros (descrever)
            /// </summary>
            public string IND_TIT
            {
                get { return F_IND_TIT; }
                set { F_IND_TIT = value.ToUpper(); }
            }

            private string F_DESC_TIT = "";
            /// <summary>
            /// Descrição complementar do título de crédito
            /// </summary>
            public string DESC_TIT
            {
                get { return F_DESC_TIT; }
                set { F_DESC_TIT = value.ToUpper(); }
            }

            private string F_NUM_TIT = "";
            /// <summary>
            /// Número ou código identificador do título de crédito
            /// </summary>
            public string NUM_TIT
            {
                get { return F_NUM_TIT; }
                set { F_NUM_TIT = value.ToUpper(); }
            }

            private string F_QTD_PARC = "";
            /// <summary>
            /// Quantidade de parcelas a receber/pagar
            /// </summary>
            public string QTD_PARC
            {
                get { return F_QTD_PARC; }
                set { F_QTD_PARC = value.ToUpper(); }
            }

            private string F_VL_TIT = "";
            /// <summary>
            /// Valor total dos títulos de créditos
            /// </summary>
            public string VL_TIT
            {
                get { return F_VL_TIT; }
                set { F_VL_TIT = value.ToUpper(); }
            }

            public string GetRegistro_C140(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_EMIT */
                    if (!(F_IND_EMIT.Equals("0") || F_IND_EMIT.Equals("1")))
                    {
                        return "Erro -> O campo IND_EMIT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_TIT */
                    if (F_IND_TIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de IND_TIT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_TIT */
                    if (!(F_IND_TIT.Equals("00") || F_IND_TIT.Equals("01") || F_IND_TIT.Equals("02") || F_IND_TIT.Equals("03") || F_IND_TIT.Equals("99")))
                    {
                        return "Erro -> O campo IND_TIT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_TIT */
                    if (F_IND_TIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de IND_TIT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_TIT */
                    if (F_IND_TIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de IND_TIT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo QTD_PARC */
                    if (F_QTD_PARC.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de QTD_PARC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo QTD_PARC */
                    if (F_QTD_PARC.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de QTD_PARC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_IND_EMIT, F_IND_TIT, F_DESC_TIT, F_NUM_TIT, F_QTD_PARC, F_VL_TIT);
            }
        }

        /// <summary>
        /// VENCIMENTO DA FATURA (CÓDIGO 01).
        /// </summary>
        public class Registro_C141
        {
            private string F_REG = "C141";
            /// <summary>
            /// Texto fixo contendo "C141"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_PARC = "";
            /// <summary>
            /// Número da parcela a receber/pagar
            /// </summary>
            public string NUM_PARC
            {
                get { return F_NUM_PARC; }
                set { F_NUM_PARC = value.ToUpper(); }
            }

            private string F_DT_VCTO = "";
            /// <summary>
            /// Data de vencimento da parcela
            /// </summary>
            public string DT_VCTO
            {
                get { return F_DT_VCTO; }
                set { F_DT_VCTO = value.ToUpper(); }
            }

            private string F_VL_PARC = "";
            /// <summary>
            /// Valor da parcela a receber/pagar
            /// </summary>
            public string VL_PARC
            {
                get { return F_VL_PARC; }
                set { F_VL_PARC = value.ToUpper(); }
            }

            public string GetRegistro_C141(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_PARC */
                    if (F_NUM_PARC.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de NUM_PARC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_VCTO */
                    if (F_DT_VCTO.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VCTO incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_NUM_PARC, F_DT_VCTO, F_VL_PARC);
            }
        }

        /// <summary>
        /// VOLUMES TRANSPORTADOS (CÓDIGO 01 E 04) - EXCETO COMBUSTÍVEIS.
        /// </summary>
        public class Registro_C160
        {
            private string F_REG = "C160";
            /// <summary>
            /// Texto fixo contendo "C160"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): > transportador, se houver
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_VEIC_ID = "";
            /// <summary>
            /// Placa de identificação do veículo automotor
            /// </summary>
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            private string F_QTD_VOL = "";
            /// <summary>
            /// Quantidade de volumes transportados
            /// </summary>
            public string QTD_VOL
            {
                get { return F_QTD_VOL; }
                set { F_QTD_VOL = value.ToUpper(); }
            }

            private string F_PESO_BRT = "";
            /// <summary>
            /// Peso bruto dos volumes transportados (em Kg)
            /// </summary>
            public string PESO_BRT
            {
                get { return F_PESO_BRT; }
                set { F_PESO_BRT = value.ToUpper(); }
            }

            private string F_PESO_LIQ = "";
            /// <summary>
            /// Peso líquido dos volumes transportados (em Kg)
            /// </summary>
            public string PESO_LIQ
            {
                get { return F_PESO_LIQ; }
                set { F_PESO_LIQ = value.ToUpper(); }
            }

            private string F_UF_ID = "";
            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            public string UF_ID
            {
                get { return F_UF_ID; }
                set { F_UF_ID = value.ToUpper(); }
            }

            public string GetRegistro_C160(bool Validate)
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
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_VOL */
                    if (F_QTD_VOL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_VOL não informado(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PESO_BRT */
                    if (F_PESO_BRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PESO_BRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PESO_LIQ */
                    if (F_PESO_LIQ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PESO_LIQ não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF_ID */
                    if (F_UF_ID.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_PART, F_VEIC_ID, F_QTD_VOL, F_PESO_BRT, F_PESO_LIQ, F_UF_ID);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM COMBUSTÍVEIS (CÓDIGO 01).
        /// </summary>
        public class Registro_C165
        {
            private string F_REG = "C165";
            /// <summary>
            /// Texto fixo contendo "C165”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): > transportador, se houver
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_VEIC_ID = "";
            /// <summary>
            /// Placa de identificação do veículo
            /// </summary>
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            private string F_COD_AUT = "";
            /// <summary>
            /// Código da autorização fornecido pela SEFAZ (combustíveis)
            /// </summary>
            public string COD_AUT
            {
                get { return F_COD_AUT; }
                set { F_COD_AUT = value.ToUpper(); }
            }

            private string F_NR_PASSE = "";
            /// <summary>
            /// Número do Passe Fiscal
            /// </summary>
            public string NR_PASSE
            {
                get { return F_NR_PASSE; }
                set { F_NR_PASSE = value.ToUpper(); }
            }

            private string F_HORA = "";
            /// <summary>
            /// Hora da saída das mercadorias
            /// </summary>
            public string HORA
            {
                get { return F_HORA; }
                set { F_HORA = value.ToUpper(); }
            }

            private string F_TEMPER = "";
            /// <summary>
            /// Temperatura em graus Celsius utilizada para quantificação do volume de combustível
            /// </summary>
            public string TEMPER
            {
                get { return F_TEMPER; }
                set { F_TEMPER = value.ToUpper(); }
            }

            private string F_QTD_VOL = "";
            /// <summary>
            /// Quantidade de volumes transportados
            /// </summary>
            public string QTD_VOL
            {
                get { return F_QTD_VOL; }
                set { F_QTD_VOL = value.ToUpper(); }
            }

            private string F_PESO_BRT = "";
            /// <summary>
            /// Peso bruto dos volumes transportados (em Kg)
            /// </summary>
            public string PESO_BRT
            {
                get { return F_PESO_BRT; }
                set { F_PESO_BRT = value.ToUpper(); }
            }

            private string F_PESO_LIQ = "";
            /// <summary>
            /// Peso líquido dos volumes transportados (em Kg)
            /// </summary>
            public string PESO_LIQ
            {
                get { return F_PESO_LIQ; }
                set { F_PESO_LIQ = value.ToUpper(); }
            }

            private string F_NOM_MOT = "";
            /// <summary>
            /// Nome do motorista
            /// </summary>
            public string NOM_MOT
            {
                get { return F_NOM_MOT; }
                set { F_NOM_MOT = value.ToUpper(); }
            }

            private string F_CPF = "";
            /// <summary>
            /// CPF do motorista
            /// </summary>
            public string CPF
            {
                get { return F_CPF; }
                set { F_CPF = value.ToUpper(); }
            }

            private string F_UF_ID = "";
            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            public string UF_ID
            {
                get { return F_UF_ID; }
                set { F_UF_ID = value.ToUpper(); }
            }

            public string GetRegistro_C165(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VEIC_ID */
                    if (F_VEIC_ID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VEIC_ID não informado(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo HORA */
                    if (F_HORA.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de HORA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo HORA */
                    if (F_HORA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório HORA não informado(a)";
                    }
                    /* validacao para o tamanho do campo HORA */
                    if (F_HORA.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de HORA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo HORA */
                    if (F_HORA.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de HORA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_VOL */
                    if (F_QTD_VOL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_VOL não informado(a)";
                    }
                    /* validacao para o tamanho do campo HORA */
                    if (F_HORA.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de HORA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PESO_BRT */
                    if (F_PESO_BRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PESO_BRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo HORA */
                    if (F_HORA.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de HORA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PESO_LIQ */
                    if (F_PESO_LIQ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PESO_LIQ não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOM_MOT */
                    if (F_NOM_MOT.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de NOM_MOT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (F_CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF_ID */
                    if (F_UF_ID.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", F_REG, F_COD_PART, F_VEIC_ID, F_COD_AUT, F_NR_PASSE, F_HORA, F_TEMPER, F_QTD_VOL, F_PESO_BRT, F_PESO_LIQ, F_NOM_MOT, F_CPF, F_UF_ID);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO (CÓDIGO 01, 1B, 04 e 55).
        /// </summary>
        public class Registro_C170
        {
            private string F_REG = "C170";
            /// <summary>
            /// Texto fixo contendo "C170"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_ITEM = "";
            /// <summary>
            /// Número sequencial do item no documento fiscal
            /// </summary>
            public string NUM_ITEM
            {
                get { return F_NUM_ITEM; }
                set { F_NUM_ITEM = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_DESCR_COMPL = "";
            /// <summary>
            /// Descrição complementar do item como adotado no documento fiscal
            /// </summary>
            public string DESCR_COMPL
            {
                get { return F_DESCR_COMPL; }
                set { F_DESCR_COMPL = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor total do item (mercadorias ou serviços)
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor do desconto comercial
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_IND_MOV = "";
            /// <summary>
            /// Movimentação física do ITEM/PRODUTO: 0- SIM 1- NÃO
            /// </summary>
            public string IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            private string F_CST_ICMS = "";
            /// <summary>
            /// Código da Situação Tributária referente ao ICMS, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            private string F_CFOP = "";
            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            private string F_COD_NAT = "";
            /// <summary>
            /// Código da natureza da operação (campo 02 do Registro 0400)
            /// </summary>
            public string COD_NAT
            {
                get { return F_COD_NAT; }
                set { F_COD_NAT = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor do ICMS creditado/debitado
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS_ST = "";
            /// <summary>
            /// Valor da base de cálculo referente à substituição tributária
            /// </summary>
            public string VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value.ToUpper(); }
            }

            private string F_ALIQ_ST = "";
            /// <summary>
            /// Alíquota do ICMS da substituição tributária na unidade da federação de destino
            /// </summary>
            public string ALIQ_ST
            {
                get { return F_ALIQ_ST; }
                set { F_ALIQ_ST = value.ToUpper(); }
            }

            private string F_VL_ICMS_ST = "";
            /// <summary>
            /// Valor do ICMS referente à substituição tributária
            /// </summary>
            public string VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value.ToUpper(); }
            }

            private string F_IND_APUR = "";
            /// <summary>
            /// Indicador de período de apuração do IPI: 0 - Mensal; 1 - Decendial
            /// </summary>
            public string IND_APUR
            {
                get { return F_IND_APUR; }
                set { F_IND_APUR = value.ToUpper(); }
            }

            private string F_CST_IPI = "";
            /// <summary>
            /// Código da Situação Tributária referente ao IPI, conforme a Tabela indicada no item 4.3.2.
            /// </summary>
            public string CST_IPI
            {
                get { return F_CST_IPI; }
                set { F_CST_IPI = value.ToUpper(); }
            }

            private string F_COD_ENQ = "";
            /// <summary>
            /// Código de enquadramento legal do IPI, conforme tabela indicada no item 4.5.3.
            /// </summary>
            public string COD_ENQ
            {
                get { return F_COD_ENQ; }
                set { F_COD_ENQ = value.ToUpper(); }
            }

            private string F_VL_BC_IPI = "";
            /// <summary>
            /// Valor da base de cálculo do IPI
            /// </summary>
            public string VL_BC_IPI
            {
                get { return F_VL_BC_IPI; }
                set { F_VL_BC_IPI = value.ToUpper(); }
            }

            private string F_ALIQ_IPI = "";
            /// <summary>
            /// Alíquota do IPI
            /// </summary>
            public string ALIQ_IPI
            {
                get { return F_ALIQ_IPI; }
                set { F_ALIQ_IPI = value.ToUpper(); }
            }

            private string F_VL_IPI = "";
            /// <summary>
            /// Valor do IPI creditado/debitado
            /// </summary>
            public string VL_IPI
            {
                get { return F_VL_IPI; }
                set { F_VL_IPI = value.ToUpper(); }
            }

            private string F_CST_PIS = "";
            /// <summary>
            /// Código da Situação Tributária referente ao PIS.
            /// </summary>
            public string CST_PIS
            {
                get { return F_CST_PIS; }
                set { F_CST_PIS = value.ToUpper(); }
            }

            private string F_VL_BC_PIS = "";
            /// <summary>
            /// Valor da base de cálculo do PIS
            /// </summary>
            public string VL_BC_PIS
            {
                get { return F_VL_BC_PIS; }
                set { F_VL_BC_PIS = value.ToUpper(); }
            }

            private string F_ALIQ_PIS_PERC = "";
            /// <summary>
            /// Alíquota do PIS (em percentual)
            /// </summary>
            public string ALIQ_PIS_PERC
            {
                get { return F_ALIQ_PIS_PERC; }
                set { F_ALIQ_PIS_PERC = value.ToUpper(); }
            }

            private string F_QUANT_BC_PIS = "";
            /// <summary>
            /// Quantidade – Base de cálculo PIS
            /// </summary>
            public string QUANT_BC_PIS
            {
                get { return F_QUANT_BC_PIS; }
                set { F_QUANT_BC_PIS = value.ToUpper(); }
            }

            private string F_ALIQ_PIS = "";
            /// <summary>
            /// Alíquota do PIS (em reais)
            /// </summary>
            public string ALIQ_PIS
            {
                get { return F_ALIQ_PIS; }
                set { F_ALIQ_PIS = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_CST_COFINS = "";
            /// <summary>
            /// Código da Situação Tributária referente ao COFINS.
            /// </summary>
            public string CST_COFINS
            {
                get { return F_CST_COFINS; }
                set { F_CST_COFINS = value.ToUpper(); }
            }

            private string F_VL_BC_COFINS = "";
            /// <summary>
            /// Valor da base de cálculo da COFINS
            /// </summary>
            public string VL_BC_COFINS
            {
                get { return F_VL_BC_COFINS; }
                set { F_VL_BC_COFINS = value.ToUpper(); }
            }

            private string F_ALIQ_COFINS_PERC = "";
            /// <summary>
            /// Alíquota do COFINS (em percentual)
            /// </summary>
            public string ALIQ_COFINS_PERC
            {
                get { return F_ALIQ_COFINS_PERC; }
                set { F_ALIQ_COFINS_PERC = value.ToUpper(); }
            }

            private string F_QUANT_BC_COFINS = "";
            /// <summary>
            /// Quantidade – Base de cálculo COFINS
            /// </summary>
            public string QUANT_BC_COFINS
            {
                get { return F_QUANT_BC_COFINS; }
                set { F_QUANT_BC_COFINS = value.ToUpper(); }
            }

            private string F_ALIQ_COFINS = "";
            /// <summary>
            /// Alíquota da COFINS (em reais)
            /// </summary>
            public string ALIQ_COFINS
            {
                get { return F_ALIQ_COFINS; }
                set { F_ALIQ_COFINS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_COD_CTA = "";
            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_C170(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_ITEM */
                    if (F_NUM_ITEM.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_ITEM incorreto(a)";
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (F_IND_MOV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(F_IND_MOV.Equals("0") || F_IND_MOV.Equals("1")))
                    {
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CFOP */
                    if (F_CFOP.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de CFOP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_APUR */
                    if (F_IND_APUR.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_APUR incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_APUR */
                    if (!(F_IND_APUR.Equals("0") || F_IND_APUR.Equals("1")))
                    {
                        return "Erro -> O campo IND_APUR possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo CST_IPI */
                    if (F_CST_IPI.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_IPI incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ENQ */
                    if (F_COD_ENQ.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_ENQ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ENQ */
                    if (F_COD_ENQ.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_ENQ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_IPI */
                    if (F_ALIQ_IPI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_IPI incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_IPI */
                    if (F_ALIQ_IPI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_IPI incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CST_PIS */
                    if (F_CST_PIS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_PIS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_BC_PIS */
                    if (F_VL_BC_PIS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de VL_BC_PIS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_PIS_PERC */
                    if (F_ALIQ_PIS_PERC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_PIS_PERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo QUANT_BC_PIS */
                    if (F_QUANT_BC_PIS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de QUANT_BC_PIS incorreto(a)";
                    }
                    /* Validacao dos dados passados a QUANT_BC_PIS */
                    if (!(F_QUANT_BC_PIS.Equals("DE")))
                    {
                        return "Erro -> O campo QUANT_BC_PIS possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo ALIQ_PIS */
                    if (F_ALIQ_PIS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_PIS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_PIS */
                    if (F_ALIQ_PIS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_PIS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CST_COFINS */
                    if (F_CST_COFINS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de CST_COFINS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo VL_BC_COFINS */
                    if (F_VL_BC_COFINS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de VL_BC_COFINS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_COFINS_PERC */
                    if (F_ALIQ_COFINS_PERC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_COFINS_PERC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo QUANT_BC_COFINS */
                    if (F_QUANT_BC_COFINS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de QUANT_BC_COFINS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_COFINS */
                    if (F_ALIQ_COFINS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_COFINS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_COFINS */
                    if (F_ALIQ_COFINS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_COFINS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_COFINS */
                    if (F_ALIQ_COFINS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_COFINS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|{27}|{28}|{29}|{30}|{31}|{32}|{33}|{34}|{35}|{36}|", F_REG, F_NUM_ITEM, F_COD_ITEM, F_DESCR_COMPL, F_QTD, F_UNID, F_VL_ITEM, F_VL_DESC, F_IND_MOV, F_CST_ICMS, F_CFOP, F_COD_NAT, F_VL_BC_ICMS, F_ALIQ_ICMS, F_VL_ICMS, F_VL_BC_ICMS_ST, F_ALIQ_ST, F_VL_ICMS_ST, F_IND_APUR, F_CST_IPI, F_COD_ENQ, F_VL_BC_IPI, F_ALIQ_IPI, F_VL_IPI, F_CST_PIS, F_VL_BC_PIS, F_ALIQ_PIS_PERC, F_QUANT_BC_PIS, F_ALIQ_PIS, F_VL_PIS, F_CST_COFINS, F_VL_BC_COFINS, F_ALIQ_COFINS_PERC, F_QUANT_BC_COFINS, F_ALIQ_COFINS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// ARMAZENAMENTO DE COMBUSTIVEIS (código 01, 55).
        /// </summary>
        public class Registro_C171
        {
            private string F_REG = "C171";
            /// <summary>
            /// Texto fixo contendo "C171"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_TANQUE = "";
            /// <summary>
            /// Tanque onde foi armazenado o combustível
            /// </summary>
            public string NUM_TANQUE
            {
                get { return F_NUM_TANQUE; }
                set { F_NUM_TANQUE = value.ToUpper(); }
            }

            private string F_QTDE = "";
            /// <summary>
            /// Quantidade ou volume armazenado
            /// </summary>
            public string QTDE
            {
                get { return F_QTDE; }
                set { F_QTDE = value.ToUpper(); }
            }

            public string GetRegistro_C171(bool Validate)
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
                    /* validacao para o tamanho do campo NUM_TANQUE */
                    if (F_NUM_TANQUE.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_TANQUE incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_TANQUE */
                    if (F_NUM_TANQUE.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_TANQUE não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_TANQUE */
                    if (F_NUM_TANQUE.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NUM_TANQUE incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTDE */
                    if (F_QTDE.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTDE não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_NUM_TANQUE, F_QTDE);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM ISSQN (CÓDIGO 01)
        /// </summary>
        public class Registro_C172
        {
            private string F_REG = "C172";
            /// <summary>
            /// Texto fixo contendo "C172"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_VL_BC_ISSQN = "";
            /// <summary>
            /// Valor da base de cálculo do ISSQN
            /// </summary>
            public string VL_BC_ISSQN
            {
                get { return F_VL_BC_ISSQN; }
                set { F_VL_BC_ISSQN = value.ToUpper(); }
            }

            private string F_ALIQ_ISSQN = "";
            /// <summary>
            /// Alíquota do ISSQN
            /// </summary>
            public string ALIQ_ISSQN
            {
                get { return F_ALIQ_ISSQN; }
                set { F_ALIQ_ISSQN = value.ToUpper(); }
            }

            private string F_VL_ISSQN = "";
            /// <summary>
            /// Valor do ISSQN
            /// </summary>
            public string VL_ISSQN
            {
                get { return F_VL_ISSQN; }
                set { F_VL_ISSQN = value.ToUpper(); }
            }

            public string GetRegistro_C172(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_BC_ISSQN */
                    if (F_VL_BC_ISSQN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ISSQN não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ALIQ_ISSQN não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ISSQN */
                    if (F_VL_ISSQN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ISSQN não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_VL_BC_ISSQN, F_ALIQ_ISSQN, F_VL_ISSQN);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM MEDICAMENTOS (CÓDIGO 01 e 55).
        /// </summary>
        public class Registro_C173
        {
            private string F_REG = "C173";
            /// <summary>
            /// Texto fixo contendo "C173"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_LOTE_MED = "";
            /// <summary>
            /// Número do lote de fabricação do medicamento
            /// </summary>
            public string LOTE_MED
            {
                get { return F_LOTE_MED; }
                set { F_LOTE_MED = value.ToUpper(); }
            }

            private string F_QTD_ITEM = "";
            /// <summary>
            /// Quantidade de item por lote
            /// </summary>
            public string QTD_ITEM
            {
                get { return F_QTD_ITEM; }
                set { F_QTD_ITEM = value.ToUpper(); }
            }

            private string F_DT_FAB = "";
            /// <summary>
            /// Data de fabricação do medicamento
            /// </summary>
            public string DT_FAB
            {
                get { return F_DT_FAB; }
                set { F_DT_FAB = value.ToUpper(); }
            }

            private string F_DT_VAL = "";
            /// <summary>
            /// Data de expiração da validade do medicamento
            /// </summary>
            public string DT_VAL
            {
                get { return F_DT_VAL; }
                set { F_DT_VAL = value.ToUpper(); }
            }

            private string F_IND_MED = "";
            /// <summary>
            /// Indicador de tipo de referência da base de cálculo do ICMS (ST) do produto farmacêutico: 0- Base de cálculo referente ao preço tabelado ou preço máximo sugerido; 1- Base cálculo > Margem de valor agregado; 2- Base de cálculo referente à Lista Negativa; 3- Base de cálculo referente à Lista Positiva; 4- Base de cálculo referente à Lista Neutra
            /// </summary>
            public string IND_MED
            {
                get { return F_IND_MED; }
                set { F_IND_MED = value.ToUpper(); }
            }

            private string F_TP_PROD = "";
            /// <summary>
            /// Tipo de produto: 0- Similar; 1- Genérico; 2- Ético ou de marca;
            /// </summary>
            public string TP_PROD
            {
                get { return F_TP_PROD; }
                set { F_TP_PROD = value.ToUpper(); }
            }

            private string F_VL_TAB_MAX = "";
            /// <summary>
            /// Valor do preço tabelado ou valor do preço máximo
            /// </summary>
            public string VL_TAB_MAX
            {
                get { return F_VL_TAB_MAX; }
                set { F_VL_TAB_MAX = value.ToUpper(); }
            }

            public string GetRegistro_C173(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_FAB */
                    if (F_DT_FAB.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FAB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_VAL */
                    if (F_DT_VAL.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_VAL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_MED */
                    if (F_IND_MED.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MED incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_MED */
                    if (!(F_IND_MED.Equals("0") || F_IND_MED.Equals("1") || F_IND_MED.Equals("2") || F_IND_MED.Equals("3") || F_IND_MED.Equals("4")))
                    {
                        return "Erro -> O campo IND_MED possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_MED */
                    if (F_IND_MED.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MED incorreto(a)";
                    }
                    /* Validacao para os dados informados a TP_PROD */
                    if (!(F_TP_PROD.Equals("0") || F_TP_PROD.Equals("1") || F_TP_PROD.Equals("2")))
                    {
                        return "Erro -> O campo TP_PROD possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_MED */
                    if (F_IND_MED.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MED incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_LOTE_MED, F_QTD_ITEM, F_DT_FAB, F_DT_VAL, F_IND_MED, F_TP_PROD, F_VL_TAB_MAX);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM ARMAS DE FOGO (CÓDIGO 01).
        /// </summary>
        public class Registro_C174
        {
            private string F_REG = "C174";
            /// <summary>
            /// Texto fixo contendo "C174"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_ARM = "";
            /// <summary>
            /// Indicador do tipo da arma de fogo: 0- Uso permitido; 1- Uso restrito
            /// </summary>
            public string IND_ARM
            {
                get { return F_IND_ARM; }
                set { F_IND_ARM = value.ToUpper(); }
            }

            private string F_NUM_ARM = "";
            /// <summary>
            /// Numeração de série de fabricação da arma
            /// </summary>
            public string NUM_ARM
            {
                get { return F_NUM_ARM; }
                set { F_NUM_ARM = value.ToUpper(); }
            }

            private string F_DESCR_COMPL = "";
            /// <summary>
            /// Descrição da arma, compreendendo: número do cano, calibre, marca, capacidade de cartuchos, tipo de funcionamento, quantidade de canos, comprimento, tipo de alma, quantidade e sentido das raias e demais elementos que permitam sua perfeita identificação
            /// </summary>
            public string DESCR_COMPL
            {
                get { return F_DESCR_COMPL; }
                set { F_DESCR_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_C174(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_ARM */
                    if (F_IND_ARM.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_ARM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_ARM */
                    if (F_IND_ARM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_ARM não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_ARM */
                    if (!(F_IND_ARM.Equals("0") || F_IND_ARM.Equals("1")))
                    {
                        return "Erro -> O campo IND_ARM possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_ARM */
                    if (F_IND_ARM.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_ARM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_ARM */
                    if (F_NUM_ARM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_ARM não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_ARM */
                    if (F_IND_ARM.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_ARM incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_IND_ARM, F_NUM_ARM, F_DESCR_COMPL);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM VEÍCULOS NOVOS (CÓDIGO 01 e 55).
        /// </summary>
        public class Registro_C175
        {
            private string F_REG = "C175";
            /// <summary>
            /// Texto fixo contendo "C175"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_VEIC_OPER = "";
            /// <summary>
            /// Indicador do tipo de operação com veículo: 0- Venda para concessionária; 1- Faturamento direto; 2- Venda direta; 3- Venda da concessionária; 9- Outros
            /// </summary>
            public string IND_VEIC_OPER
            {
                get { return F_IND_VEIC_OPER; }
                set { F_IND_VEIC_OPER = value.ToUpper(); }
            }

            private string F_CNPJ = "";
            /// <summary>
            /// CNPJ da Concessionária
            /// </summary>
            public string CNPJ
            {
                get { return F_CNPJ; }
                set { F_CNPJ = value.ToUpper(); }
            }

            private string F_UF = "";
            /// <summary>
            /// Sigla da unidade da federação da Concessionária
            /// </summary>
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            private string F_CHASSI_VEIC = "";
            /// <summary>
            /// Chassi do veículo
            /// </summary>
            public string CHASSI_VEIC
            {
                get { return F_CHASSI_VEIC; }
                set { F_CHASSI_VEIC = value.ToUpper(); }
            }

            public string GetRegistro_C175(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_VEIC_OPER */
                    if (F_IND_VEIC_OPER.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_VEIC_OPER incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_VEIC_OPER */
                    if (!(F_IND_VEIC_OPER.Equals("0") || F_IND_VEIC_OPER.Equals("1") || F_IND_VEIC_OPER.Equals("2") || F_IND_VEIC_OPER.Equals("3") || F_IND_VEIC_OPER.Equals("9")))
                    {
                        return "Erro -> O campo IND_VEIC_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (F_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHASSI_VEIC */
                    if (F_CHASSI_VEIC.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de CHASSI_VEIC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_IND_VEIC_OPER, F_CNPJ, F_UF, F_CHASSI_VEIC);
            }
        }

        /// <summary>
        /// RESSARCIMENTO DE ICMS EM OPERAÇÕES COM SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 01, 55).
        /// </summary>
        public class Registro_C176
        {
            private string F_REG = "C176";
            /// <summary>
            /// Texto fixo contendo "C176”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD_ULT_E = "";
            /// <summary>
            /// Código do modelo do documento fiscal relativa a última entrada
            /// </summary>
            public string COD_MOD_ULT_E
            {
                get { return F_COD_MOD_ULT_E; }
                set { F_COD_MOD_ULT_E = value.ToUpper(); }
            }

            private string F_NUM_DOC_ULT_E = "";
            /// <summary>
            /// Número do documento fiscal relativa a última entrada
            /// </summary>
            public string NUM_DOC_ULT_E
            {
                get { return F_NUM_DOC_ULT_E; }
                set { F_NUM_DOC_ULT_E = value.ToUpper(); }
            }

            private string F_SER_ULT_E = "";
            /// <summary>
            /// Série do documento fiscal relativa a última entrada
            /// </summary>
            public string SER_ULT_E
            {
                get { return F_SER_ULT_E; }
                set { F_SER_ULT_E = value.ToUpper(); }
            }

            private string F_DT_ULT_E = "";
            /// <summary>
            /// Data relativa a última entrada da mercadoria
            /// </summary>
            public string DT_ULT_E
            {
                get { return F_DT_ULT_E; }
                set { F_DT_ULT_E = value.ToUpper(); }
            }

            private string F_COD_PART_ULT_E = "";
            /// <summary>
            /// Código do participante (do emitente do documento relativa a última entrada)
            /// </summary>
            public string COD_PART_ULT_E
            {
                get { return F_COD_PART_ULT_E; }
                set { F_COD_PART_ULT_E = value.ToUpper(); }
            }

            private string F_QUANT_ULT_E = "";
            /// <summary>
            /// Quantidade do item relativa a última entrada
            /// </summary>
            public string QUANT_ULT_E
            {
                get { return F_QUANT_ULT_E; }
                set { F_QUANT_ULT_E = value.ToUpper(); }
            }

            private string F_VL_UNIT_ULT_E = "";
            /// <summary>
            /// Valor unitário da mercadoria constante na NF relativa a última entrada inclusive despesas acessórias.
            /// </summary>
            public string VL_UNIT_ULT_E
            {
                get { return F_VL_UNIT_ULT_E; }
                set { F_VL_UNIT_ULT_E = value.ToUpper(); }
            }

            private string F_VL_UNIT_BC_ST = "";
            /// <summary>
            /// Valor unitário da base de cálculo do imposto pago por substituição.
            /// </summary>
            public string VL_UNIT_BC_ST
            {
                get { return F_VL_UNIT_BC_ST; }
                set { F_VL_UNIT_BC_ST = value.ToUpper(); }
            }

            public string GetRegistro_C176(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MOD_ULT_E */
                    if (F_COD_MOD_ULT_E.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MOD_ULT_E */
                    if (F_COD_MOD_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MOD_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC_ULT_E */
                    if (F_NUM_DOC_ULT_E.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC_ULT_E */
                    if (F_NUM_DOC_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo SER_ULT_E */
                    if (F_SER_ULT_E.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SER_ULT_E incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_ULT_E */
                    if (F_DT_ULT_E.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ULT_E */
                    if (F_DT_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_ULT_E */
                    if (F_COD_PART_ULT_E.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_PART_ULT_E */
                    if (F_COD_PART_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_PART_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_ULT_E */
                    if (F_COD_PART_ULT_E.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QUANT_ULT_E */
                    if (F_QUANT_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QUANT_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_ULT_E */
                    if (F_COD_PART_ULT_E.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_ULT_E incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_UNIT_ULT_E */
                    if (F_VL_UNIT_ULT_E.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_UNIT_ULT_E não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_ULT_E */
                    if (F_COD_PART_ULT_E.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_ULT_E incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_COD_MOD_ULT_E, F_NUM_DOC_ULT_E, F_SER_ULT_E, F_DT_ULT_E, F_COD_PART_ULT_E, F_QUANT_ULT_E, F_VL_UNIT_ULT_E, F_VL_UNIT_BC_ST);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM PRODUTOS SUJEITOS A SELO DE CONTROLE IPI.
        /// </summary>
        public class Registro_C177
        {
            private string F_REG = "C177";
            /// <summary>
            /// Texto fixo contendo "C177"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_SELO_IPI = "";
            /// <summary>
            /// Código do selo de controle do IPI, conforme Tabela 4.5.2
            /// </summary>
            public string COD_SELO_IPI
            {
                get { return F_COD_SELO_IPI; }
                set { F_COD_SELO_IPI = value.ToUpper(); }
            }

            private string F_QT_SELO_IPI = "";
            /// <summary>
            /// Quantidade de selo de controle do IPI aplicada
            /// </summary>
            public string QT_SELO_IPI
            {
                get { return F_QT_SELO_IPI; }
                set { F_QT_SELO_IPI = value.ToUpper(); }
            }

            public string GetRegistro_C177(bool Validate)
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
                    /* validacao para o tamanho do campo COD_SELO_IPI */
                    if (F_COD_SELO_IPI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_SELO_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_SELO_IPI */
                    if (F_COD_SELO_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_SELO_IPI não informado(a)";
                    }
                    /* validacao para o tamanho do campo QT_SELO_IPI */
                    if (F_QT_SELO_IPI.Length > 12)
                    {
                        return "Erro -> Tamanho do campo de QT_SELO_IPI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QT_SELO_IPI */
                    if (F_QT_SELO_IPI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QT_SELO_IPI não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_SELO_IPI, F_QT_SELO_IPI);
            }
        }

        /// <summary>
        /// OPERAÇÕES COM PRODUTOS SUJEITOS À TRIBUTAÇÀO DE IPI POR UNIDADE OU QUANTIDADE DE PRODUTO.
        /// </summary>
        public class Registro_C178
        {
            private string F_REG = "C178";
            /// <summary>
            /// Texto fixo contendo "C178"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_CL_ENQ = "";
            /// <summary>
            /// Código da classe de enquadramento do IPI, conforme Tabela 4.5.1.
            /// </summary>
            public string CL_ENQ
            {
                get { return F_CL_ENQ; }
                set { F_CL_ENQ = value.ToUpper(); }
            }

            private string F_VL_UNID = "";
            /// <summary>
            /// Valor por unidade padrão de tributação
            /// </summary>
            public string VL_UNID
            {
                get { return F_VL_UNID; }
                set { F_VL_UNID = value.ToUpper(); }
            }

            private string F_QUANT_PAD = "";
            /// <summary>
            /// Quantidade total de produtos na unidade padrão de tributação
            /// </summary>
            public string QUANT_PAD
            {
                get { return F_QUANT_PAD; }
                set { F_QUANT_PAD = value.ToUpper(); }
            }

            public string GetRegistro_C178(bool Validate)
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
                    /* validacao para o tamanho do campo CL_ENQ */
                    if (F_CL_ENQ.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de CL_ENQ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CL_ENQ */
                    if (F_CL_ENQ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CL_ENQ não informado(a)";
                    }
                    /* validacao para o tamanho do campo CL_ENQ */
                    if (F_CL_ENQ.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de CL_ENQ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_UNID */
                    if (F_VL_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo CL_ENQ */
                    if (F_CL_ENQ.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de CL_ENQ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QUANT_PAD */
                    if (F_QUANT_PAD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QUANT_PAD não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_CL_ENQ, F_VL_UNID, F_QUANT_PAD);
            }
        }

        /// <summary>
        /// INFORMAÇÕES COMPLEMENTARES ST (CÓDIGO 01).
        /// </summary>
        public class Registro_C179
        {
            private string F_REG = "C179";
            /// <summary>
            /// Texto fixo contendo "C179”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_BC_ST_ORIG_DEST = "";
            /// <summary>
            /// Valor da base de cálculo ST na origem/destino em operações interestaduais.
            /// </summary>
            public string BC_ST_ORIG_DEST
            {
                get { return F_BC_ST_ORIG_DEST; }
                set { F_BC_ST_ORIG_DEST = value.ToUpper(); }
            }

            private string F_ICMS_ST_REP = "";
            /// <summary>
            /// Valor do ICMS-ST a repassar/deduzir em operações interestaduais
            /// </summary>
            public string ICMS_ST_REP
            {
                get { return F_ICMS_ST_REP; }
                set { F_ICMS_ST_REP = value.ToUpper(); }
            }

            private string F_ICMS_ST_COMPL = "";
            /// <summary>
            /// Valor do ICMS-ST a complementar à UF de destino
            /// </summary>
            public string ICMS_ST_COMPL
            {
                get { return F_ICMS_ST_COMPL; }
                set { F_ICMS_ST_COMPL = value.ToUpper(); }
            }

            private string F_BC_RET = "";
            /// <summary>
            /// Valor da BC de retenção em remessa promovida por Substituído intermediário
            /// </summary>
            public string BC_RET
            {
                get { return F_BC_RET; }
                set { F_BC_RET = value.ToUpper(); }
            }

            private string F_ICMS_RET = "";
            /// <summary>
            /// Valor da parcela do imposto retido em remessa promovida por substituído intermediário
            /// </summary>
            public string ICMS_RET
            {
                get { return F_ICMS_RET; }
                set { F_ICMS_RET = value.ToUpper(); }
            }

            public string GetRegistro_C179(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo BC_ST_ORIG_DEST */
                    if (F_BC_ST_ORIG_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório BC_ST_ORIG_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ICMS_ST_REP */
                    if (F_ICMS_ST_REP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ICMS_ST_REP não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_BC_ST_ORIG_DEST, F_ICMS_ST_REP, F_ICMS_ST_COMPL, F_BC_RET, F_ICMS_RET);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DO DOCUMENTO (CÓDIGO 01, 1B, 04, 55 e 65).
        /// </summary>
        public class Registro_C190
        {
            private string F_REG = "C190";
            /// <summary>
            /// Texto fixo contendo "C190"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_CST_ICMS = "";
            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            private string F_CFOP = "";
            /// <summary>
            /// Código Fiscal de Operação e Prestação do agrupamento de itens
            /// </summary>
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_OPR = "";
            /// <summary>
            /// Valor da operação na combinação de CST_ICMS, CFOP e alíquota do ICMS, correspondente ao somatório do valor das mercadorias, despesas acessórias (frete, seguros e outras despesas acessórias), ICMS_ST e IPI.
            /// </summary>
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS_ST = "";
            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" da substituição tributária referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value.ToUpper(); }
            }

            private string F_VL_ICMS_ST = "";
            /// <summary>
            /// Parcela correspondente ao valor creditado/debitado do ICMS da substituição tributária, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            public string VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value.ToUpper(); }
            }

            private string F_VL_RED_BC = "";
            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            private string F_VL_IPI = "";
            /// <summary>
            /// Parcela correspondente ao "Valor do IPI" referente à combinação CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_IPI
            {
                get { return F_VL_IPI; }
                set { F_VL_IPI = value.ToUpper(); }
            }

            private string F_COD_OBS = "";
            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_C190(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CFOP */
                    if (F_CFOP.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de CFOP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_ST, F_VL_ICMS_ST, F_VL_RED_BC, F_VL_IPI, F_COD_OBS);
            }
        }

        /// <summary>
        /// OBSERVAÇOES DO LANÇAMENTO FISCAL (CÓDIGO 01, 1B, 04 E 55)
        /// </summary>
        public class Registro_C195
        {
            private string F_REG = "C195";
            /// <summary>
            /// Texto fixo contendo "C195"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_OBS = "";
            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            private string F_TXT_COMPL = "";
            /// <summary>
            /// Descrição complementar do código de observação.
            /// </summary>
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_C195(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_OBS, F_TXT_COMPL);
            }
        }

        /// <summary>
        /// OUTRAS OBRIGAÇÕES TRIBUTÁRIAS, AJUSTES E INFORMAÇÕES DE VALORES PROVENIENTES DE DOCUMENTO FISCAL.
        /// </summary>
        public class Registro_C197
        {
            private string F_REG = "C197";
            /// <summary>
            /// Texto fixo contendo "C197"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_AJ = "";
            /// <summary>
            /// Código do ajustes/benefício/incentivo, conforme tabela indicada no item 5.3.
            /// </summary>
            public string COD_AJ
            {
                get { return F_COD_AJ; }
                set { F_COD_AJ = value.ToUpper(); }
            }

            private string F_DESCR_COMPL_AJ = "";
            /// <summary>
            /// Descrição complementar do ajuste do documento fiscal
            /// </summary>
            public string DESCR_COMPL_AJ
            {
                get { return F_DESCR_COMPL_AJ; }
                set { F_DESCR_COMPL_AJ = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Base de cálculo do ICMS ou do ICMS ST
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor do ICMS ou do ICMS ST
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_OUTROS = "";
            /// <summary>
            /// Outros valores
            /// </summary>
            public string VL_OUTROS
            {
                get { return F_VL_OUTROS; }
                set { F_VL_OUTROS = value.ToUpper(); }
            }

            public string GetRegistro_C197(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ */
                    if (F_COD_AJ.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_AJ */
                    if (F_COD_AJ.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_AJ incorreto(a)";
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_COD_AJ, F_DESCR_COMPL_AJ, F_COD_ITEM, F_VL_BC_ICMS, F_ALIQ_ICMS, F_VL_ICMS, F_VL_OUTROS);
            }
        }

        /// <summary>
        /// RESUMO DIÁRIO DAS NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02)
        /// </summary>
        public class Registro_C300
        {
            private string F_REG = "C300";
            /// <summary>
            /// Texto fixo contendo "C300"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_SER = "";
            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            private string F_SUB = "";
            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            public string SUB
            {
                get { return F_SUB; }
                set { F_SUB = value.ToUpper(); }
            }

            private string F_NUM_DOC_INI = "";
            /// <summary>
            /// Número do documento fiscal inicial
            /// </summary>
            public string NUM_DOC_INI
            {
                get { return F_NUM_DOC_INI; }
                set { F_NUM_DOC_INI = value.ToUpper(); }
            }

            private string F_NUM_DOC_FIN = "";
            /// <summary>
            /// Número do documento fiscal final
            /// </summary>
            public string NUM_DOC_FIN
            {
                get { return F_NUM_DOC_FIN; }
                set { F_NUM_DOC_FIN = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão dos documentos fiscais
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_VL_DOC = "";
            /// <summary>
            /// Valor total dos documentos
            /// </summary>
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor total do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_COD_CTA = "";
            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_C300(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo SER */
                    if (F_SER.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório SER não informado(a)";
                    }
                    /* validacao para o tamanho do campo SUB */
                    if (F_SUB.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SUB incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC_INI */
                    if (F_NUM_DOC_INI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC_INI */
                    if (F_NUM_DOC_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC_FIN */
                    if (F_NUM_DOC_FIN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC_FIN */
                    if (F_NUM_DOC_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC_FIN não informado(a)";
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
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DOC */
                    if (F_VL_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC_INI, F_NUM_DOC_FIN, F_DT_DOC, F_VL_DOC, F_VL_PIS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// DOCUMENTOS CANCELADOS DE NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02).
        /// </summary>
        public class Registro_C310
        {
            private string F_REG = "C310";
            /// <summary>
            /// Texto fixo contendo "C310"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_DOC_CANC = "";
            /// <summary>
            /// Número do documento fiscal cancelado
            /// </summary>
            public string NUM_DOC_CANC
            {
                get { return F_NUM_DOC_CANC; }
                set { F_NUM_DOC_CANC = value.ToUpper(); }
            }

            public string GetRegistro_C310(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo NUM_DOC_CANC */
                    if (F_NUM_DOC_CANC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC_CANC não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|", F_REG, F_NUM_DOC_CANC);
            }
        }

        /// <summary>
        /// ITENS DO RESUMO DIÁRIO DOS DOCUMENTOS (CÓDIGO 02).
        /// </summary>
        public class Registro_C320
        {
            private string F_REG = "C321";
            /// <summary>
            /// Texto fixo contendo "C321"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade acumulada do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor acumulado do item
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor do desconto acumulado
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor acumulado do ICMS debitado
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor acumulado do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor acumulado da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_C320(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ITEM */
                    if (F_VL_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_ITEM, F_QTD, F_UNID, F_VL_ITEM, F_VL_DESC, F_VL_BC_ICMS, F_VL_ICMS, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// NOTA FISCAL DE VENDA A CONSUMIDOR (CÓDIGO 02)
        /// </summary>
        public class Registro_C350
        {
            private string F_REG = "C350";
            /// <summary>
            /// Texto fixo contendo "C350"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_SER = "";
            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            private string F_SUB_SER = "";
            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            public string SUB_SER
            {
                get { return F_SUB_SER; }
                set { F_SUB_SER = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_CNPJ_CPF = "";
            /// <summary>
            /// CNPJ ou CPF do destinatário
            /// </summary>
            public string CNPJ_CPF
            {
                get { return F_CNPJ_CPF; }
                set { F_CNPJ_CPF = value.ToUpper(); }
            }

            private string F_VL_MERC = "";
            /// <summary>
            /// Valor das mercadorias constantes no documento fiscal
            /// </summary>
            public string VL_MERC
            {
                get { return F_VL_MERC; }
                set { F_VL_MERC = value.ToUpper(); }
            }

            private string F_VL_DOC = "";
            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor total do desconto
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor total do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_COD_CTA = "";
            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_C350(bool Validate)
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
                    /* validacao para o tamanho do campo SER */
                    if (F_SER.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SER incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUB_SER */
                    if (F_SUB_SER.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de SUB_SER incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 6)
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
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_MERC */
                    if (F_VL_MERC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_MERC não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DOC */
                    if (F_VL_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF */
                    if (F_CNPJ_CPF.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, F_SER, F_SUB_SER, F_NUM_DOC, F_DT_DOC, F_CNPJ_CPF, F_VL_MERC, F_VL_DOC, F_VL_DESC, F_VL_PIS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO (CÓDIGO 02)
        /// </summary>
        public class Registro_C370
        {
            private string F_REG = "C370";
            /// <summary>
            /// Texto fixo contendo "C370"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NUM_ITEM = "";
            /// <summary>
            /// Número sequencial do item no documento fiscal
            /// </summary>
            public string NUM_ITEM
            {
                get { return F_NUM_ITEM; }
                set { F_NUM_ITEM = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do Item (campo 02 do registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor total do item
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor total do desconto no item
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            public string GetRegistro_C370(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ITEM */
                    if (F_VL_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_NUM_ITEM, F_COD_ITEM, F_QTD, F_UNID, F_VL_ITEM, F_VL_DESC);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DAS NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02)
        /// </summary>
        public class Registro_C390
        {
            private string F_REG = "C390";
            /// <summary>
            /// Texto fixo contendo "C390"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_CST_ICMS = "";
            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            private string F_CFOP = "";
            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_OPR = "";
            /// <summary>
            /// Valor total acumulado das operações correspondentes à combinação de CST_ICMS, CFOP e alíquota do ICMS, incluídas as despesas acessórias e acréscimos.
            /// </summary>
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor acumulado do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_RED_BC = "";
            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            private string F_COD_OBS = "";
            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_C390(bool Validate)
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
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CST_ICMS */
                    if (F_CST_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CST_ICMS não informado(a)";
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OPR */
                    if (F_VL_OPR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OPR não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_RED_BC, F_COD_OBS);
            }
        }

        /// <summary>
        /// EQUIPAMENTO ECF (CÓDIGO 02, 2D e 60).
        /// </summary>
        public class Registro_C400
        {
            private string F_REG = "C400";
            /// <summary>
            /// Texto fixo contendo "C400"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_ECF_MOD = "";
            /// <summary>
            /// Modelo do equipamento
            /// </summary>
            public string ECF_MOD
            {
                get { return F_ECF_MOD; }
                set { F_ECF_MOD = value.ToUpper(); }
            }

            private string F_ECF_FAB = "";
            /// <summary>
            /// Número de série de fabricação do ECF
            /// </summary>
            public string ECF_FAB
            {
                get { return F_ECF_FAB; }
                set { F_ECF_FAB = value.ToUpper(); }
            }

            private string F_ECF_CX = "";
            /// <summary>
            /// Número do caixa atribuído ao ECF
            /// </summary>
            public string ECF_CX
            {
                get { return F_ECF_CX; }
                set { F_ECF_CX = value.ToUpper(); }
            }

            public string GetRegistro_C400(bool Validate)
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
                    /* validacao para o tamanho do campo ECF_MOD */
                    if (F_ECF_MOD.Length > 20)
                    {
                        return "Erro -> Tamanho do campo de ECF_MOD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ECF_MOD */
                    if (F_ECF_MOD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ECF_MOD não informado(a)";
                    }
                    /* validacao para o tamanho do campo ECF_FAB */
                    if (F_ECF_FAB.Length > 21)
                    {
                        return "Erro -> Tamanho do campo de ECF_FAB incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ECF_FAB */
                    if (F_ECF_FAB.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ECF_FAB não informado(a)";
                    }
                    /* validacao para o tamanho do campo ECF_CX */
                    if (F_ECF_CX.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de ECF_CX incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo ECF_CX */
                    if (F_ECF_CX.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório ECF_CX não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_MOD, F_ECF_MOD, F_ECF_FAB, F_ECF_CX);
            }
        }

        /// <summary>
        /// REDUÇÃO Z (CÓDIGO 02, 2D e 60).
        /// </summary>
        public class Registro_C405
        {
            private string F_REG = "C405";
            /// <summary>
            /// Texto fixo contendo "C405"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data do movimento a que se refere a Redução Z
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_CRO = "";
            /// <summary>
            /// Posição do Contador de Reinício de Operação
            /// </summary>
            public string CRO
            {
                get { return F_CRO; }
                set { F_CRO = value.ToUpper(); }
            }

            private string F_CRZ = "";
            /// <summary>
            /// Posição do Contador de Redução Z
            /// </summary>
            public string CRZ
            {
                get { return F_CRZ; }
                set { F_CRZ = value.ToUpper(); }
            }

            private string F_NUM_COO_FIN = "";
            /// <summary>
            /// Número do Contador de Ordem de Operação do último documento emitido no dia. (Número do COO na Redução Z)
            /// </summary>
            public string NUM_COO_FIN
            {
                get { return F_NUM_COO_FIN; }
                set { F_NUM_COO_FIN = value.ToUpper(); }
            }

            private string F_GT_FIN = "";
            /// <summary>
            /// Valor do Grande Total final
            /// </summary>
            public string GT_FIN
            {
                get { return F_GT_FIN; }
                set { F_GT_FIN = value.ToUpper(); }
            }

            private string F_VL_BRT = "";
            /// <summary>
            /// Valor da venda bruta
            /// </summary>
            public string VL_BRT
            {
                get { return F_VL_BRT; }
                set { F_VL_BRT = value.ToUpper(); }
            }

            public string GetRegistro_C405(bool Validate)
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
                    /* validacao para o tamanho do campo CRO */
                    if (F_CRO.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CRO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CRO */
                    if (F_CRO.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CRO não informado(a)";
                    }
                    /* validacao para o tamanho do campo CRZ */
                    if (F_CRZ.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de CRZ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CRZ */
                    if (F_CRZ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CRZ não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_COO_FIN */
                    if (F_NUM_COO_FIN.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_COO_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_COO_FIN */
                    if (F_NUM_COO_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_COO_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_COO_FIN */
                    if (F_NUM_COO_FIN.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_COO_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo GT_FIN */
                    if (F_GT_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório GT_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_COO_FIN */
                    if (F_NUM_COO_FIN.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_COO_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BRT */
                    if (F_VL_BRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BRT não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_DT_DOC, F_CRO, F_CRZ, F_NUM_COO_FIN, F_GT_FIN, F_VL_BRT);
            }
        }

        /// <summary>
        /// PIS E COFINS TOTALIZADOS NO DIA (CÓDIGO 02 e 2D).
        /// </summary>
        public class Registro_C410
        {
            private string F_REG = "C410";
            /// <summary>
            /// Texto fixo contendo "C410"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor total do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_C410(bool Validate)
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
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// REGISTRO DOS TOTALIZADORES PARCIAIS DA REDUÇÃO Z (COD 02, 2D e 60).
        /// </summary>
        public class Registro_C420
        {
            private string F_REG = "C420";
            /// <summary>
            /// Texto fixo contendo "C420"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_TOT_PAR = "";
            /// <summary>
            /// Código do totalizador, conforme Tabela 4.4.6
            /// </summary>
            public string COD_TOT_PAR
            {
                get { return F_COD_TOT_PAR; }
                set { F_COD_TOT_PAR = value.ToUpper(); }
            }

            private string F_VLR_ACUM_TOT = "";
            /// <summary>
            /// Valor acumulado no totalizador, relativo à respectiva Redução Z.
            /// </summary>
            public string VLR_ACUM_TOT
            {
                get { return F_VLR_ACUM_TOT; }
                set { F_VLR_ACUM_TOT = value.ToUpper(); }
            }

            private string F_NR_TOT = "";
            /// <summary>
            /// Número do totalizador quando ocorrer mais de uma situação com a mesma carga tributária efetiva.
            /// </summary>
            public string NR_TOT
            {
                get { return F_NR_TOT; }
                set { F_NR_TOT = value.ToUpper(); }
            }

            private string F_DESCR_NR_TOT = "";
            /// <summary>
            /// Descrição da situação tributária relativa ao totalizador parcial, quando houver mais de um com a mesma carga tributária efetiva.
            /// </summary>
            public string DESCR_NR_TOT
            {
                get { return F_DESCR_NR_TOT; }
                set { F_DESCR_NR_TOT = value.ToUpper(); }
            }

            public string GetRegistro_C420(bool Validate)
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
                    /* validacao para o tamanho do campo COD_TOT_PAR */
                    if (F_COD_TOT_PAR.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_TOT_PAR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_TOT_PAR */
                    if (F_COD_TOT_PAR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_TOT_PAR não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_TOT_PAR */
                    if (F_COD_TOT_PAR.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_TOT_PAR incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VLR_ACUM_TOT */
                    if (F_VLR_ACUM_TOT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VLR_ACUM_TOT não informado(a)";
                    }
                    /* validacao para o tamanho do campo NR_TOT */
                    if (F_NR_TOT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de NR_TOT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NR_TOT */
                    if (F_NR_TOT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de NR_TOT incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_TOT_PAR, F_VLR_ACUM_TOT, F_NR_TOT, F_DESCR_NR_TOT);
            }
        }

        /// <summary>
        /// RESUMO DE ITENS DO MOVIMENTO DIÁRIO (CÓDIGO 02 e 2D).
        /// </summary>
        public class Registro_C425
        {
            private string F_REG = "C425";
            /// <summary>
            /// Texto fixo contendo "C425"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade acumulada do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor acumulado do item
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_C425(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ITEM */
                    if (F_VL_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_ITEM, F_QTD, F_UNID, F_VL_ITEM, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// DOCUMENTO FISCAL EMITIDO POR ECF (CÓDIGO 02, 2D e 60).
        /// </summary>
        public class Registro_C460
        {
            private string F_REG = "C460";
            /// <summary>
            /// Texto fixo contendo "C460"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_COD_SIT = "";
            /// <summary>
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal (COO)
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_VL_DOC = "";
            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_CPF_CNPJ = "";
            /// <summary>
            /// CPF ou CNPJ do adquirente
            /// </summary>
            public string CPF_CNPJ
            {
                get { return F_CPF_CNPJ; }
                set { F_CPF_CNPJ = value.ToUpper(); }
            }

            private string F_NOM_ADQ = "";
            /// <summary>
            /// Nome do adquirente
            /// </summary>
            public string NOM_ADQ
            {
                get { return F_NOM_ADQ; }
                set { F_NOM_ADQ = value.ToUpper(); }
            }

            public string GetRegistro_C460(bool Validate)
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
                    /* validacao para o tamanho do campo COD_SIT */
                    if (F_COD_SIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_SIT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_SIT */
                    if (F_COD_SIT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_SIT não informado(a)";
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
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_DOC */
                    if (F_VL_DOC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_DOC não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF_CNPJ */
                    if (F_CPF_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CPF_CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NOM_ADQ */
                    if (F_NOM_ADQ.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de NOM_ADQ incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_MOD, F_COD_SIT, F_NUM_DOC, F_DT_DOC, F_VL_DOC, F_VL_PIS, F_VL_COFINS, F_CPF_CNPJ, F_NOM_ADQ);
            }
        }

        /// <summary>
        /// COMPLEMENTO DO CUPOM FISCAL ELETRÔNICO EMITIDO POR ECF – CF-e-ECF (CÓDIGO 60).
        /// </summary>
        public class Registro_C465
        {
            private string F_REG = "C465";
            /// <summary>
            /// Texto fixo contendo "C465"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_CHV_CFE = "";
            /// <summary>
            /// Chave do Cupom Fiscal Eletrônico
            /// </summary>
            public string CHV_CFE
            {
                get { return F_CHV_CFE; }
                set { F_CHV_CFE = value.ToUpper(); }
            }

            private string F_NUM_CCF = "";
            /// <summary>
            /// Número do Contador de Cupom Fiscal
            /// </summary>
            public string NUM_CCF
            {
                get { return F_NUM_CCF; }
                set { F_NUM_CCF = value.ToUpper(); }
            }

            public string GetRegistro_C465(bool Validate)
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
                    /* validacao para o tamanho do campo CHV_CFE */
                    if (F_CHV_CFE.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CFE incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CHV_CFE */
                    if (F_CHV_CFE.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CHV_CFE não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM_CCF */
                    if (F_NUM_CCF.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_CCF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_CCF */
                    if (F_NUM_CCF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_CCF não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_CHV_CFE, F_NUM_CCF);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO FISCAL EMITIDO POR ECF (CÓDIGO 02 e 2D).
        /// </summary>
        public class Registro_C470
        {
            private string F_REG = "C470";
            /// <summary>
            /// Texto fixo contendo "C470"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_QTD_CANC = "";
            /// <summary>
            /// Quantidade cancelada, no caso de cancelamento parcial de item
            /// </summary>
            public string QTD_CANC
            {
                get { return F_QTD_CANC; }
                set { F_QTD_CANC = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor total do item
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_CST_ICMS = "";
            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1.
            /// </summary>
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            private string F_CFOP = "";
            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS > Carga tributária efetiva em percentual
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_C470(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ITEM */
                    if (F_VL_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CST_ICMS */
                    if (F_CST_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CST_ICMS não informado(a)";
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_COD_ITEM, F_QTD, F_QTD_CANC, F_UNID, F_VL_ITEM, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DO MOVIMENTO DIÁRIO (CÓDIGO 02, 2D e 60).
        /// </summary>
        public class Registro_C490
        {
            private string F_REG = "C490";
            /// <summary>
            /// Texto fixo contendo "C490"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_CST_ICMS = "";
            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            private string F_CFOP = "";
            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_VL_OPR = "";
            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS, incluídas as despesas acessórias e acréscimos
            /// </summary>
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor acumulado do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_COD_OBS = "";
            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_C490(bool Validate)
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
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CST_ICMS */
                    if (F_CST_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CST_ICMS não informado(a)";
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_OPR */
                    if (F_VL_OPR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OPR não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS */
                    if (F_VL_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_COD_OBS);
            }
        }

        /// <summary>
        /// RESUMO MENSAL DE ITENS DO ECF POR ESTABELECIMENTO (CÓDIGO 02 e 2D).
        /// </summary>
        public class Registro_C495
        {
            private string F_REG = "C495";
            /// <summary>
            /// Texto fixo contendo "C495"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_QTD = "";
            /// <summary>
            /// Quantidade acumulada do item
            /// </summary>
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            private string F_QTD_CANC = "";
            /// <summary>
            /// Quantidade cancelada acumulada, no caso de cancelamento parcial de item
            /// </summary>
            public string QTD_CANC
            {
                get { return F_QTD_CANC; }
                set { F_QTD_CANC = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_VL_ITEM = "";
            /// <summary>
            /// Valor acumulado do item
            /// </summary>
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor acumulado dos descontos
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_VL_CANC = "";
            /// <summary>
            /// Valor acumulado dos cancelamentos
            /// </summary>
            public string VL_CANC
            {
                get { return F_VL_CANC; }
                set { F_VL_CANC = value.ToUpper(); }
            }

            private string F_VL_ACMO = "";
            /// <summary>
            /// Valor acumulado dos acréscimos
            /// </summary>
            public string VL_ACMO
            {
                get { return F_VL_ACMO; }
                set { F_VL_ACMO = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor acumulado do ICMS
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_ISEN = "";
            /// <summary>
            /// Valor das saídas isentas do ICMS
            /// </summary>
            public string VL_ISEN
            {
                get { return F_VL_ISEN; }
                set { F_VL_ISEN = value.ToUpper(); }
            }

            private string F_VL_NT = "";
            /// <summary>
            /// Valor das saídas sob não-incidência ou nãotributadas pelo ICMS
            /// </summary>
            public string VL_NT
            {
                get { return F_VL_NT; }
                set { F_VL_NT = value.ToUpper(); }
            }

            private string F_VL_ICMS_ST = "";
            /// <summary>
            /// Valor das saídas de mercadorias adquiridas com substituição tributária do ICMS
            /// </summary>
            public string VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value.ToUpper(); }
            }

            public string GetRegistro_C495(bool Validate)
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ITEM */
                    if (F_VL_ITEM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", F_REG, F_ALIQ_ICMS, F_COD_ITEM, F_QTD, F_QTD_CANC, F_UNID, F_VL_ITEM, F_VL_DESC, F_VL_CANC, F_VL_ACMO, F_VL_BC_ICMS, F_VL_ICMS, F_VL_ISEN, F_VL_NT, F_VL_ICMS_ST);
            }
        }

        /// <summary>
        /// NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06), NOTA FISCAL/CONTA DE FORNECIMENTO D'ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL CONSUMO FORNECIMENTO DE GÁS (CÓDIGO 28).
        /// </summary>
        public class Registro_C500
        {
            private string F_REG = "C500";
            /// <summary>
            /// Texto fixo contendo "C500"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_IND_OPER = "";
            /// <summary>
            /// Indicador do tipo de operação: 0- Entrada; 1- Saída
            /// </summary>
            public string IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value.ToUpper(); }
            }

            private string F_IND_EMIT = "";
            /// <summary>
            /// Indicador do emitente do documento fiscal: 0- Emissão própria; 1- Terceiros
            /// </summary>
            public string IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): > do adquirente, no caso das saídas; > do fornecedor no caso de entradas
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_COD_MOD = "";
            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1
            /// </summary>
            public string COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value.ToUpper(); }
            }

            private string F_COD_SIT = "";
            /// <summary>
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
            }

            private string F_SER = "";
            /// <summary>
            /// Série do documento fiscal
            /// </summary>
            public string SER
            {
                get { return F_SER; }
                set { F_SER = value.ToUpper(); }
            }

            private string F_SUB = "";
            /// <summary>
            /// Subsérie do documento fiscal
            /// </summary>
            public string SUB
            {
                get { return F_SUB; }
                set { F_SUB = value.ToUpper(); }
            }

            private string F_COD_CONS = "";
            /// <summary>
            /// > Código de classe de consumo de energia elétrica ou gás: 01 - Comercial 02 - Consumo Próprio 03 - Iluminação Pública 04 - Industrial 05 - Poder Público 06 - Residencial 07 - Rural 08 - Serviço Público. > Código de classe de consumo de Fornecimento D´água > Tabela 4.4.2.
            /// </summary>
            public string COD_CONS
            {
                get { return F_COD_CONS; }
                set { F_COD_CONS = value.ToUpper(); }
            }

            private string F_NUM_DOC = "";
            /// <summary>
            /// Número do documento fiscal
            /// </summary>
            public string NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value.ToUpper(); }
            }

            private string F_DT_DOC = "";
            /// <summary>
            /// Data da emissão do documento fiscal
            /// </summary>
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            private string F_DT_E_S = "";
            /// <summary>
            /// Data da entrada ou da saída
            /// </summary>
            public string DT_E_S
            {
                get { return F_DT_E_S; }
                set { F_DT_E_S = value.ToUpper(); }
            }

            private string F_VL_DOC = "";
            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            private string F_VL_DESC = "";
            /// <summary>
            /// Valor total do desconto
            /// </summary>
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            private string F_VL_FORN = "";
            /// <summary>
            /// Valor total fornecido/consumido
            /// </summary>
            public string VL_FORN
            {
                get { return F_VL_FORN; }
                set { F_VL_FORN = value.ToUpper(); }
            }

            private string F_VL_SERV_NT = "";
            /// <summary>
            /// Valor total dos serviços não-tributados pelo ICMS
            /// </summary>
            public string VL_SERV_NT
            {
                get { return F_VL_SERV_NT; }
                set { F_VL_SERV_NT = value.ToUpper(); }
            }

            private string F_VL_TERC = "";
            /// <summary>
            /// Valor total cobrado em nome de terceiros
            /// </summary>
            public string VL_TERC
            {
                get { return F_VL_TERC; }
                set { F_VL_TERC = value.ToUpper(); }
            }

            private string F_VL_DA = "";
            /// <summary>
            /// Valor total de despesas acessórias indicadas no documento fiscal
            /// </summary>
            public string VL_DA
            {
                get { return F_VL_DA; }
                set { F_VL_DA = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            private string F_VL_ICMS = "";
            /// <summary>
            /// Valor acumulado do ICMS
            /// </summary>
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            private string F_VL_BC_ICMS_ST = "";
            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS substituição tributária
            /// </summary>
            public string VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value.ToUpper(); }
            }

            private string F_VL_ICMS_ST = "";
            /// <summary>
            /// Valor acumulado do ICMS retido por substituição tributária
            /// </summary>
            public string VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value.ToUpper(); }
            }

            private string F_COD_INF = "";
            /// <summary>
            /// Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            public string COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value.ToUpper(); }
            }

            private string F_VL_PIS = "";
            /// <summary>
            /// Valor do PIS
            /// </summary>
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            private string F_VL_COFINS = "";
            /// <summary>
            /// Valor da COFINS
            /// </summary>
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            private string F_TP_LIGACAO = "";
            /// <summary>
            /// Código de tipo de Ligação 1 - Monofásico 2 - Bifásico 3 - Trifásico
            /// </summary>
            public string TP_LIGACAO
            {
                get { return F_TP_LIGACAO; }
                set { F_TP_LIGACAO = value.ToUpper(); }
            }

            private string F_COD_GRUPO_TENSAO = "";
            /// <summary>
            /// Código de grupo de tensão: 01 - A1 > Alta Tensão (230kV ou mais) 02 - A2 > Alta Tensão (88 a 138kV) 03 - A3 > Alta Tensão (69kV) 04 - A3a > Alta Tensão (30kV a 44kV) 05 - A4 > Alta Tensão (2,3kV a 25kV) 06 - AS > Alta Tensão Subterrâneo 06 07 - B1 > Residencial 07 08 - B1 > Residencial Baixa Renda 08 09 - B2 > Rural 09 10 - B2 > Cooperativa de Eletrificação Rural 11 - B2 > Serviço Público de Irrigação 12 - B3 > Demais Classes 13 - B4a > Iluminação Pública > rede de distribuição 14 - B4b > Iluminação Pública > bulbo de lâmpada
            /// </summary>
            public string COD_GRUPO_TENSAO
            {
                get { return F_COD_GRUPO_TENSAO; }
                set { F_COD_GRUPO_TENSAO = value.ToUpper(); }
            }

            public string GetRegistro_C500(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_OPER */
                    if (F_IND_OPER.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_OPER incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_OPER */
                    if (!(F_IND_OPER.Equals("0") || F_IND_OPER.Equals("1")))
                    {
                        return "Erro -> O campo IND_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_EMIT */
                    if (!(F_IND_EMIT.Equals("0") || F_IND_EMIT.Equals("1")))
                    {
                        return "Erro -> O campo IND_EMIT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MOD */
                    if (F_COD_MOD.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_MOD incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_SIT */
                    if (F_COD_SIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_SIT incorreto(a)";
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
                    /* validacao para o tamanho do campo COD_CONS */
                    if (F_COD_CONS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_CONS incorreto(a)";
                    }
                    /* Validacao para os dados informados a COD_CONS */
                    if (!(F_COD_CONS.Equals("01") || F_COD_CONS.Equals("02") || F_COD_CONS.Equals("03") || F_COD_CONS.Equals("04") || F_COD_CONS.Equals("05") || F_COD_CONS.Equals("06") || F_COD_CONS.Equals("07") || F_COD_CONS.Equals("08")))
                    {
                        return "Erro -> O campo COD_CONS possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_E_S */
                    if (F_DT_E_S.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_E_S incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TP_LIGACAO */
                    if (F_TP_LIGACAO.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de TP_LIGACAO incorreto(a)";
                    }
                    /* Validacao para os dados informados a TP_LIGACAO */
                    if (!(F_TP_LIGACAO.Equals("1") || F_TP_LIGACAO.Equals("2") || F_TP_LIGACAO.Equals("3")))
                    {
                        return "Erro -> O campo TP_LIGACAO possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_GRUPO_TENSAO */
                    if (F_COD_GRUPO_TENSAO.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_GRUPO_TENSAO incorreto(a)";
                    }
                    /* Validacao para os dados informados a COD_GRUPO_TENSAO */
                    if (!(F_COD_GRUPO_TENSAO.Equals("01") || F_COD_GRUPO_TENSAO.Equals("02") || F_COD_GRUPO_TENSAO.Equals("03") || F_COD_GRUPO_TENSAO.Equals("04") || F_COD_GRUPO_TENSAO.Equals("05") || F_COD_GRUPO_TENSAO.Equals("06") || F_COD_GRUPO_TENSAO.Equals("07") || F_COD_GRUPO_TENSAO.Equals("08") || F_COD_GRUPO_TENSAO.Equals("09") || F_COD_GRUPO_TENSAO.Equals("10") || F_COD_GRUPO_TENSAO.Equals("11") || F_COD_GRUPO_TENSAO.Equals("12") || F_COD_GRUPO_TENSAO.Equals("13") || F_COD_GRUPO_TENSAO.Equals("14")))
                    {
                        return "Erro -> O campo COD_GRUPO_TENSAO possui valores pré-definidos";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_SUB, F_COD_CONS, F_NUM_DOC, F_DT_DOC, F_DT_E_S, F_VL_DOC, F_VL_DESC, F_VL_FORN, F_VL_SERV_NT, F_VL_TERC, F_VL_DA, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_ST, F_VL_ICMS_ST, F_COD_INF, F_VL_PIS, F_VL_COFINS, F_TP_LIGACAO, F_COD_GRUPO_TENSAO);
            }
        }



        /*  */
    }
}
