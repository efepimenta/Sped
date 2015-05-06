using System;

namespace SpedFiscal
{
    public class Bloco_D
    {
        /// <summary>
        /// ABERTURA DO BLOCO D
        /// </summary>
        public class Registro_D0001
        {
            /// <summary>
            /// Texto fixo contendo "D001"
            /// </summary>
            private string F_REG = "D001";
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

            public string GetRegistro_D0001(bool Validate)
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
        /// NOTA FISCAL DE SERVIÇO DE TRANSPORTE (CÓDIGO 07) E CONHECIMENTOS DE TRANSPORTE RODOVIÁRIO DE CARGAS (CÓDIGO 08), CONHECIMENTOS DE TRANSPORTE DE CARGAS AVULSO (CÓDIGO 8B), AQUAVIÁRIO DE CARGAS (CÓDIGO 09), AÉREO (CÓDIGO 10), FERROVIÁRIO DE CARGAS (CÓDIGO 11) E MULTIMODAL DE CARGAS (CÓDIGO 26), NOTA FISCAL DE TRANSPORTE FERROVIÁRIO DE CARGA ( CÓDIGO 27) E CONHECIMENTO DE TRANSPORTE ELETRÔNICO – CT-e (CÓDIGO 57).
        /// </summary>
        public class Registro_D100
        {
            /// <summary>
            /// Texto fixo contendo "D100"
            /// </summary>
            private string F_REG = "D100";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de operação: 0- Aquisição; 1- Prestação
            /// </summary>
            private string F_IND_OPER = "";
            public string IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value.ToUpper(); }
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
            /// Código do participante (campo 02 do Registro 0150): - do prestador de serviço, no caso de aquisição de serviço; - do tomador do serviço, no caso de prestação de serviços.
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
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            private string F_COD_SIT = "";
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
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
            /// Chave do Conhecimento de Transporte Eletrônico
            /// </summary>
            private string F_CHV_CTE = "";
            public string CHV_CTE
            {
                get { return F_CHV_CTE; }
                set { F_CHV_CTE = value.ToUpper(); }
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
            /// Data da aquisição ou da prestação do serviço
            /// </summary>
            private string F_DT_A_P = "";
            public string DT_A_P
            {
                get { return F_DT_A_P; }
                set { F_DT_A_P = value.ToUpper(); }
            }

            /// <summary>
            /// Tipo de Conhecimento de Transporte Eletrônico conforme definido no Manual de Integração do CT-e
            /// </summary>
            private string F_TP_CTe = "";
            public string TP_CTe
            {
                get { return F_TP_CTe; }
                set { F_TP_CTe = value.ToUpper(); }
            }

            /// <summary>
            /// Chave do CT-e de referência cujos valores foram complementados (opção “1” do campo anterior) ou cujo débito foi anulado(opção “2” do campo anterior).
            /// </summary>
            private string F_CHV_CTE_REF = "";
            public string CHV_CTE_REF
            {
                get { return F_CHV_CTE_REF; }
                set { F_CHV_CTE_REF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo do frete: 0- Por conta do emitente; 1- Por conta do destinatário/remetente; 2- Por conta de terceiros; 9- Sem cobrança de frete.
            /// </summary>
            private string F_IND_FRT = "";
            public string IND_FRT
            {
                get { return F_IND_FRT; }
                set { F_IND_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não-tributado
            /// </summary>
            private string F_VL_NT = "";
            public string VL_NT
            {
                get { return F_VL_NT; }
                set { F_VL_NT = value.ToUpper(); }
            }

            /// <summary>
            /// Código da informação complementar do documento fiscal (campo 02 do Registro 0450)
            /// </summary>
            private string F_COD_INF = "";
            public string COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_D100(bool Validate)
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
                        return "Erro - O campo IND_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
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
                    /* validacao para o tamanho do campo NUM_DOC */
                    if (F_NUM_DOC.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_CTE */
                    if (F_CHV_CTE.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CTE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TP_CTe */
                    if (F_TP_CTe.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de TP_CTe incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_CTE_REF */
                    if (F_CHV_CTE_REF.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CTE_REF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_CTE_REF */
                    if (F_CHV_CTE_REF.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CTE_REF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CHV_CTE_REF */
                    if (F_CHV_CTE_REF.Length > 44)
                    {
                        return "Erro -> Tamanho do campo de CHV_CTE_REF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_FRT */
                    if (F_IND_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT incorreto(a)";
                    }
                    /* Validacao para os dados informados a IND_FRT */
                    if (!(F_IND_FRT.Equals("0") || F_IND_FRT.Equals("1") || F_IND_FRT.Equals("2") || F_IND_FRT.Equals("9")))
                    {
                        return "Erro - O campo IND_FRT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_FRT */
                    if (F_IND_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_FRT */
                    if (F_IND_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_FRT */
                    if (F_IND_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_FRT */
                    if (F_IND_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT incorreto(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_SUB, F_NUM_DOC, F_CHV_CTE, F_DT_DOC, F_DT_A_P, F_TP_CTe, F_CHV_CTE_REF, F_VL_DOC, F_VL_DESC, F_IND_FRT, F_VL_SERV, F_VL_BC_ICMS, F_VL_ICMS, F_VL_NT, F_COD_INF, F_COD_CTA);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO - NOTA FISCAL DE SERVIÇOS DE TRANSPORTE (CÓDIGO 07)
        /// </summary>
        public class Registro_C110
        {
            /// <summary>
            /// Texto fixo contendo "D110"
            /// </summary>
            private string F_REG = "D110";
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
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
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
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_NUM_ITEM, F_COD_ITEM, F_VL_SERV, F_VL_OUT);
            }
        }

        /// <summary>
        /// COMPLEMENTO DA NOTA FISCAL DE SERVIÇOS DE TRANSPORTE (CÓDIGO 07).
        /// </summary>
        public class Registro_D120
        {
            /// <summary>
            /// Texto fixo contendo "D120"
            /// </summary>
            private string F_REG = "D120";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Placa de identificação do veículo
            /// </summary>
            private string F_VEIC_ID = "";
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            private string F_UF_ID = "";
            public string UF_ID
            {
                get { return F_UF_ID; }
                set { F_UF_ID = value.ToUpper(); }
            }

            public string GetRegistro_D120(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF_ID */
                    if (F_UF_ID.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ID incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_MUN_ORIG, F_COD_MUN_DEST, F_VEIC_ID, F_UF_ID);
            }
        }

        /// <summary>
        /// COMPLEMENTO DO CONHECIMENTO RODOVIÁRIO DE CARGAS (CÓDIGO 08) E DO CONHECIMENTO RODOVIÁRIO DE CARGAS AVULSO (CÓDIGO 8B).
        /// </summary>
        public class Registro_D130
        {
            /// <summary>
            /// Texto fixo contendo "D130"
            /// </summary>
            private string F_REG = "D130";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): consignatário, se houver
            /// </summary>
            private string F_COD_PART_CONSG = "";
            public string COD_PART_CONSG
            {
                get { return F_COD_PART_CONSG; }
                set { F_COD_PART_CONSG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): redespachado, se houver
            /// </summary>
            private string F_COD_PART_RED = "";
            public string COD_PART_RED
            {
                get { return F_COD_PART_RED; }
                set { F_COD_PART_RED = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo do frete da operação de redespacho: 0 - Sem redespacho; 1 - Por conta do emitente; 2 - Por conta do destinatário; 9 - Outros.
            /// </summary>
            private string F_IND_FRT_RED = "";
            public string IND_FRT_RED
            {
                get { return F_IND_FRT_RED; }
                set { F_IND_FRT_RED = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Placa de identificação do veículo
            /// </summary>
            private string F_VEIC_ID = "";
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            /// <summary>
            /// Valor líquido do frete
            /// </summary>
            private string F_VL_LIQ_FRT = "";
            public string VL_LIQ_FRT
            {
                get { return F_VL_LIQ_FRT; }
                set { F_VL_LIQ_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Soma de valores de Sec/Cat (serviços de coleta/custo adicional de transporte)
            /// </summary>
            private string F_VL_SEC_CAT = "";
            public string VL_SEC_CAT
            {
                get { return F_VL_SEC_CAT; }
                set { F_VL_SEC_CAT = value.ToUpper(); }
            }

            /// <summary>
            /// Soma de valores de despacho
            /// </summary>
            private string F_VL_DESP = "";
            public string VL_DESP
            {
                get { return F_VL_DESP; }
                set { F_VL_DESP = value.ToUpper(); }
            }

            /// <summary>
            /// Soma dos valores de pedágio
            /// </summary>
            private string F_VL_PEDG = "";
            public string VL_PEDG
            {
                get { return F_VL_PEDG; }
                set { F_VL_PEDG = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do frete
            /// </summary>
            private string F_VL_FRT = "";
            public string VL_FRT
            {
                get { return F_VL_FRT; }
                set { F_VL_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            private string F_UF_ID = "";
            public string UF_ID
            {
                get { return F_UF_ID; }
                set { F_UF_ID = value.ToUpper(); }
            }

            public string GetRegistro_D130(bool Validate)
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
                    /* validacao para o tamanho do campo COD_PART_CONSG */
                    if (F_COD_PART_CONSG.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_CONSG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_RED */
                    if (F_COD_PART_RED.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_RED incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_FRT_RED */
                    if (F_IND_FRT_RED.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_FRT_RED incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_FRT_RED */
                    if (F_IND_FRT_RED.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_FRT_RED não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_FRT_RED */
                    if (!(F_IND_FRT_RED.Equals("0") || F_IND_FRT_RED.Equals("1") || F_IND_FRT_RED.Equals("2") || F_IND_FRT_RED.Equals("9")))
                    {
                        return "Erro - O campo IND_FRT_RED possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_LIQ_FRT */
                    if (F_VL_LIQ_FRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_LIQ_FRT não informado(a)";
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
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_FRT */
                    if (F_VL_FRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_FRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF_ID */
                    if (F_UF_ID.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ID incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_COD_PART_CONSG, F_COD_PART_RED, F_IND_FRT_RED, F_COD_MUN_ORIG, F_COD_MUN_DEST, F_VEIC_ID, F_VL_LIQ_FRT, F_VL_SEC_CAT, F_VL_DESP, F_VL_PEDG, F_VL_OUT, F_VL_FRT, F_UF_ID);
            }
        }

        /// <summary>
        /// COMPLEMENTO DO CONHECIMENTO AQUAVIÁRIO DE CARGAS (CÓDIGO 09).
        /// </summary>
        public class Registro_D140
        {
            /// <summary>
            /// Texto fixo contendo "D140"
            /// </summary>
            private string F_REG = "D140";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): consignatário, se houver
            /// </summary>
            private string F_COD_PART_CONSG = "";
            public string COD_PART_CONSG
            {
                get { return F_COD_PART_CONSG; }
                set { F_COD_PART_CONSG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo do veículo transportador: 0- Embarcação; 1- Empurrador/rebocador
            /// </summary>
            private string F_IND_VEIC = "";
            public string IND_VEIC
            {
                get { return F_IND_VEIC; }
                set { F_IND_VEIC = value.ToUpper(); }
            }

            /// <summary>
            /// Identificação da embarcação (IRIM ou Registro CPP)
            /// </summary>
            private string F_VEIC_ID = "";
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo da navegação: 0- Interior; 1- Cabotagem
            /// </summary>
            private string F_IND_NAV = "";
            public string IND_NAV
            {
                get { return F_IND_NAV; }
                set { F_IND_NAV = value.ToUpper(); }
            }

            /// <summary>
            /// Número da viagem
            /// </summary>
            private string F_VIAGEM = "";
            public string VIAGEM
            {
                get { return F_VIAGEM; }
                set { F_VIAGEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor líquido do frete
            /// </summary>
            private string F_VL_FRT_LIQ = "";
            public string VL_FRT_LIQ
            {
                get { return F_VL_FRT_LIQ; }
                set { F_VL_FRT_LIQ = value.ToUpper(); }
            }

            /// <summary>
            /// Valor das despesas portuárias
            /// </summary>
            private string F_VL_DESP_PORT = "";
            public string VL_DESP_PORT
            {
                get { return F_VL_DESP_PORT; }
                set { F_VL_DESP_PORT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor das despesas com carga e descarga
            /// </summary>
            private string F_VL_DESP_CAR_DESC = "";
            public string VL_DESP_CAR_DESC
            {
                get { return F_VL_DESP_CAR_DESC; }
                set { F_VL_DESP_CAR_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor bruto do frete
            /// </summary>
            private string F_VL_FRT_BRT = "";
            public string VL_FRT_BRT
            {
                get { return F_VL_FRT_BRT; }
                set { F_VL_FRT_BRT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor adicional do frete para renovação da Marinha Mercante
            /// </summary>
            private string F_VL_FRT_MM = "";
            public string VL_FRT_MM
            {
                get { return F_VL_FRT_MM; }
                set { F_VL_FRT_MM = value.ToUpper(); }
            }

            public string GetRegistro_D140(bool Validate)
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
                    /* validacao para o tamanho do campo COD_PART_CONSG */
                    if (F_COD_PART_CONSG.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_CONSG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_VEIC */
                    if (F_IND_VEIC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_VEIC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_VEIC */
                    if (F_IND_VEIC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_VEIC não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_VEIC */
                    if (!(F_IND_VEIC.Equals("0") || F_IND_VEIC.Equals("1")))
                    {
                        return "Erro - O campo IND_VEIC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_VEIC */
                    if (F_IND_VEIC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_VEIC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_NAV */
                    if (F_IND_NAV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_NAV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_NAV */
                    if (!(F_IND_NAV.Equals("0") || F_IND_NAV.Equals("1")))
                    {
                        return "Erro - O campo IND_NAV possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_FRT_LIQ */
                    if (F_VL_FRT_LIQ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_FRT_LIQ não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_FRT_BRT */
                    if (F_VL_FRT_BRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_FRT_BRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAV */
                    if (F_IND_NAV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAV incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_COD_PART_CONSG, F_COD_MUN_ORIG, F_COD_MUN_DEST, F_IND_VEIC, F_VEIC_ID, F_IND_NAV, F_VIAGEM, F_VL_FRT_LIQ, F_VL_DESP_PORT, F_VL_DESP_CAR_DESC, F_VL_OUT, F_VL_FRT_BRT, F_VL_FRT_MM);
            }
        }

        /// <summary>
        /// COMPLEMENTO DO CONHECIMENTO AÉREO (CÓDIGO 10).
        /// </summary>
        public class Registro_D150
        {
            /// <summary>
            /// Texto fixo contendo "D150"
            /// </summary>
            private string F_REG = "D150";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Identificação da aeronave (DAC)
            /// </summary>
            private string F_VEIC_ID = "";
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            /// <summary>
            /// Número do vôo.
            /// </summary>
            private string F_VIAGEM = "";
            public string VIAGEM
            {
                get { return F_VIAGEM; }
                set { F_VIAGEM = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de tarifa aplicada: 0- Exp.; 1- Enc.; 2- C.I.; 9- Outra
            /// </summary>
            private string F_IND_TFA = "";
            public string IND_TFA
            {
                get { return F_IND_TFA; }
                set { F_IND_TFA = value.ToUpper(); }
            }

            /// <summary>
            /// Peso taxado
            /// </summary>
            private string F_VL_PESO_TX = "";
            public string VL_PESO_TX
            {
                get { return F_VL_PESO_TX; }
                set { F_VL_PESO_TX = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da taxa terrestre
            /// </summary>
            private string F_VL_TX_TERR = "";
            public string VL_TX_TERR
            {
                get { return F_VL_TX_TERR; }
                set { F_VL_TX_TERR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da taxa de redespacho
            /// </summary>
            private string F_VL_TX_RED = "";
            public string VL_TX_RED
            {
                get { return F_VL_TX_RED; }
                set { F_VL_TX_RED = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da taxa "ad valorem"
            /// </summary>
            private string F_VL_TX_ADV = "";
            public string VL_TX_ADV
            {
                get { return F_VL_TX_ADV; }
                set { F_VL_TX_ADV = value.ToUpper(); }
            }

            public string GetRegistro_D150(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_TFA */
                    if (F_IND_TFA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_TFA não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_TFA */
                    if (!(F_IND_TFA.Equals("0") || F_IND_TFA.Equals("1") || F_IND_TFA.Equals("2") || F_IND_TFA.Equals("9")))
                    {
                        return "Erro - O campo IND_TFA possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_PESO_TX */
                    if (F_VL_PESO_TX.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_PESO_TX não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_TFA */
                    if (F_IND_TFA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_TFA incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_COD_MUN_ORIG, F_COD_MUN_DEST, F_VEIC_ID, F_VIAGEM, F_IND_TFA, F_VL_PESO_TX, F_VL_TX_TERR, F_VL_TX_RED, F_VL_OUT, F_VL_TX_ADV);
            }
        }

        /// <summary>
        /// CARGA TRANSPORTADA (CÓDIGO 08, 8B, 09, 10, 11, 26 e 27).
        /// </summary>
        public class Registro_D160
        {
            /// <summary>
            /// Texto fixo contendo "D160"
            /// </summary>
            private string F_REG = "D160";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Identificação do número do despacho
            /// </summary>
            private string F_DESPACHO = "";
            public string DESPACHO
            {
                get { return F_DESPACHO; }
                set { F_DESPACHO = value.ToUpper(); }
            }

            /// <summary>
            /// CNPJ ou CPF do remetente das mercadorias que constam na nota fiscal.
            /// </summary>
            private string F_CNPJ_CPF_REM = "";
            public string CNPJ_CPF_REM
            {
                get { return F_CNPJ_CPF_REM; }
                set { F_CNPJ_CPF_REM = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do remetente das mercadorias que constam na nota fiscal.
            /// </summary>
            private string F_IE_REM = "";
            public string IE_REM
            {
                get { return F_IE_REM; }
                set { F_IE_REM = value.ToUpper(); }
            }

            /// <summary>
            /// Código do Município de origem, conforme tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORI = "";
            public string COD_MUN_ORI
            {
                get { return F_COD_MUN_ORI; }
                set { F_COD_MUN_ORI = value.ToUpper(); }
            }

            /// <summary>
            /// CNPJ ou CPF do destinatário das mercadorias que constam na nota fiscal.
            /// </summary>
            private string F_CNPJ_CPF_DEST = "";
            public string CNPJ_CPF_DEST
            {
                get { return F_CNPJ_CPF_DEST; }
                set { F_CNPJ_CPF_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do destinatário das mercadorias que constam na nota fiscal.
            /// </summary>
            private string F_IE_DEST = "";
            public string IE_DEST
            {
                get { return F_IE_DEST; }
                set { F_IE_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Código do Município de destino, conforme tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            public string GetRegistro_D160(bool Validate)
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
                    /* validacao para o tamanho do campo CNPJ_CPF_REM */
                    if (F_CNPJ_CPF_REM.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_REM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_REM */
                    if (F_IE_REM.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_REM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORI */
                    if (F_COD_MUN_ORI.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORI */
                    if (F_COD_MUN_ORI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORI não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF_DEST */
                    if (F_CNPJ_CPF_DEST.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_DEST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_DEST */
                    if (F_IE_DEST.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_DEST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_DESPACHO, F_CNPJ_CPF_REM, F_IE_REM, F_COD_MUN_ORI, F_CNPJ_CPF_DEST, F_IE_DEST, F_COD_MUN_DEST);
            }
        }

        /// <summary>
        /// LOCAL DA COLETA E ENTREGA (CÓDIGO 08, 8B, 09, 10, 11 e 26).
        /// </summary>
        public class Registro_D161
        {
            /// <summary>
            /// Texto fixo contendo "D161"
            /// </summary>
            private string F_REG = "D161";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de transporte da carga coletada: 0-Rodoviário 1-Ferroviário 2-Rodo-Ferroviário 3-Aquaviário 4-Dutoviário 5-Aéreo 9-Outros
            /// </summary>
            private string F_IND_CARGA = "";
            public string IND_CARGA
            {
                get { return F_IND_CARGA; }
                set { F_IND_CARGA = value.ToUpper(); }
            }

            /// <summary>
            /// Número do CNPJ ou CPF do local da coleta
            /// </summary>
            private string F_CNPJ_CPF_COL = "";
            public string CNPJ_CPF_COL
            {
                get { return F_CNPJ_CPF_COL; }
                set { F_CNPJ_CPF_COL = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do contribuinte do local de coleta
            /// </summary>
            private string F_IE_COL = "";
            public string IE_COL
            {
                get { return F_IE_COL; }
                set { F_IE_COL = value.ToUpper(); }
            }

            /// <summary>
            /// Código do Município do local de coleta, conforme tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_COL = "";
            public string COD_MUN_COL
            {
                get { return F_COD_MUN_COL; }
                set { F_COD_MUN_COL = value.ToUpper(); }
            }

            /// <summary>
            /// Número do CNPJ ou CPF do local da entrega
            /// </summary>
            private string F_CNPJ_CPF_ENTG = "";
            public string CNPJ_CPF_ENTG
            {
                get { return F_CNPJ_CPF_ENTG; }
                set { F_CNPJ_CPF_ENTG = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do contribuinte do local de entrega
            /// </summary>
            private string F_IE_ENTG = "";
            public string IE_ENTG
            {
                get { return F_IE_ENTG; }
                set { F_IE_ENTG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do Município do local de entrega, conforme tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ENTG = "";
            public string COD_MUN_ENTG
            {
                get { return F_COD_MUN_ENTG; }
                set { F_COD_MUN_ENTG = value.ToUpper(); }
            }

            public string GetRegistro_D161(bool Validate)
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
                    /* validacao para o tamanho do campo CNPJ_CPF_COL */
                    if (F_CNPJ_CPF_COL.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_COL */
                    if (F_IE_COL.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_COL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_COL */
                    if (F_COD_MUN_COL.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_COL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_COL */
                    if (F_COD_MUN_COL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_COL não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF_ENTG */
                    if (F_CNPJ_CPF_ENTG.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_ENTG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE_ENTG */
                    if (F_IE_ENTG.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_ENTG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ENTG */
                    if (F_COD_MUN_ENTG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ENTG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ENTG */
                    if (F_COD_MUN_ENTG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ENTG não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_IND_CARGA, F_CNPJ_CPF_COL, F_IE_COL, F_COD_MUN_COL, F_CNPJ_CPF_ENTG, F_IE_ENTG, F_COD_MUN_ENTG);
            }
        }

        /// <summary>
        /// IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS (CÓDIGOS 08, 8B, 09, 10, 11, 26 E 27)
        /// </summary>
        public class Registro_D162
        {
            /// <summary>
            /// Texto fixo contendo "D162"
            /// </summary>
            private string F_REG = "D162";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
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
            /// Valor total do documento fiscal
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor das mercadorias constantes no documento fiscal
            /// </summary>
            private string F_VL_MERC = "";
            public string VL_MERC
            {
                get { return F_VL_MERC; }
                set { F_VL_MERC = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade de volumes transportados
            /// </summary>
            private string F_QTD_VOL = "";
            public string QTD_VOL
            {
                get { return F_QTD_VOL; }
                set { F_QTD_VOL = value.ToUpper(); }
            }

            /// <summary>
            /// Peso bruto dos volumes transportados (em Kg)
            /// </summary>
            private string F_PESO_BRT = "";
            public string PESO_BRT
            {
                get { return F_PESO_BRT; }
                set { F_PESO_BRT = value.ToUpper(); }
            }

            /// <summary>
            /// Peso líquido dos volumes transportados (em Kg)
            /// </summary>
            private string F_PESO_LIQ = "";
            public string PESO_LIQ
            {
                get { return F_PESO_LIQ; }
                set { F_PESO_LIQ = value.ToUpper(); }
            }

            public string GetRegistro_D162(bool Validate)
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
                    /* validacao para o tamanho do campo SER */
                    if (F_SER.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de SER incorreto(a)";
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
                    /* validacao para a obrigatoriedade do campo QTD_VOL */
                    if (F_QTD_VOL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_VOL não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_MOD, F_SER, F_NUM_DOC, F_DT_DOC, F_VL_DOC, F_VL_MERC, F_QTD_VOL, F_PESO_BRT, F_PESO_LIQ);
            }
        }

        /// <summary>
        /// COMPLEMENTO DO CONHECIMENTO MULTIMODAL DE CARGAS (CÓDIGO 26).
        /// </summary>
        public class Registro_D170
        {
            /// <summary>
            /// Texto fixo contendo "D170"
            /// </summary>
            private string F_REG = "D170";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): consignatário, se houver
            /// </summary>
            private string F_COD_PART_CONSG = "";
            public string COD_PART_CONSG
            {
                get { return F_COD_PART_CONSG; }
                set { F_COD_PART_CONSG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): redespachante, se houver
            /// </summary>
            private string F_COD_PART_RED = "";
            public string COD_PART_RED
            {
                get { return F_COD_PART_RED; }
                set { F_COD_PART_RED = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Registro do operador de transporte multimodal
            /// </summary>
            private string F_OTM = "";
            public string OTM
            {
                get { return F_OTM; }
                set { F_OTM = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador da natureza do frete: 0- Negociável; 1- Não negociável
            /// </summary>
            private string F_IND_NAT_FRT = "";
            public string IND_NAT_FRT
            {
                get { return F_IND_NAT_FRT; }
                set { F_IND_NAT_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor líquido do frete
            /// </summary>
            private string F_VL_LIQ_FRT = "";
            public string VL_LIQ_FRT
            {
                get { return F_VL_LIQ_FRT; }
                set { F_VL_LIQ_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do gris (gerenciamento de risco)
            /// </summary>
            private string F_VL_GRIS = "";
            public string VL_GRIS
            {
                get { return F_VL_GRIS; }
                set { F_VL_GRIS = value.ToUpper(); }
            }

            /// <summary>
            /// Somatório dos valores de pedágio
            /// </summary>
            private string F_VL_PDG = "";
            public string VL_PDG
            {
                get { return F_VL_PDG; }
                set { F_VL_PDG = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do frete
            /// </summary>
            private string F_VL_FRT = "";
            public string VL_FRT
            {
                get { return F_VL_FRT; }
                set { F_VL_FRT = value.ToUpper(); }
            }

            /// <summary>
            /// Placa de identificação do veículo
            /// </summary>
            private string F_VEIC_ID = "";
            public string VEIC_ID
            {
                get { return F_VEIC_ID; }
                set { F_VEIC_ID = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da UF da placa do veículo
            /// </summary>
            private string F_UF_ID = "";
            public string UF_ID
            {
                get { return F_UF_ID; }
                set { F_UF_ID = value.ToUpper(); }
            }

            public string GetRegistro_D170(bool Validate)
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
                    /* validacao para o tamanho do campo COD_PART_CONSG */
                    if (F_COD_PART_CONSG.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_CONSG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART_RED */
                    if (F_COD_PART_RED.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART_RED incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo OTM */
                    if (F_OTM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório OTM não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_NAT_FRT não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_NAT_FRT */
                    if (!(F_IND_NAT_FRT.Equals("0") || F_IND_NAT_FRT.Equals("1")))
                    {
                        return "Erro - O campo IND_NAT_FRT possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_LIQ_FRT */
                    if (F_VL_LIQ_FRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_LIQ_FRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_NAT_FRT */
                    if (F_IND_NAT_FRT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_NAT_FRT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_FRT */
                    if (F_VL_FRT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_FRT não informado(a)";
                    }
                    /* validacao para o tamanho do campo VEIC_ID */
                    if (F_VEIC_ID.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de VEIC_ID incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF_ID */
                    if (F_UF_ID.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ID incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_COD_PART_CONSG, F_COD_PART_RED, F_COD_MUN_ORIG, F_COD_MUN_DEST, F_OTM, F_IND_NAT_FRT, F_VL_LIQ_FRT, F_VL_GRIS, F_VL_PDG, F_VL_OUT, F_VL_FRT, F_VEIC_ID, F_UF_ID);
            }
        }

        /// <summary>
        /// MODAIS (CÓDIGO 26)
        /// </summary>
        public class Registro_D180
        {
            /// <summary>
            /// Texto fixo contendo "D180"
            /// </summary>
            private string F_REG = "D180";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número de ordem sequencial do modal
            /// </summary>
            private string F_NUM_SEQ = "";
            public string NUM_SEQ
            {
                get { return F_NUM_SEQ; }
                set { F_NUM_SEQ = value.ToUpper(); }
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
            /// CNPJ ou CPF do participante emitente do modal
            /// </summary>
            private string F_CNPJ_CPF_EMIT = "";
            public string CNPJ_CPF_EMIT
            {
                get { return F_CNPJ_CPF_EMIT; }
                set { F_CNPJ_CPF_EMIT = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da unidade da federação do participante emitente do modal
            /// </summary>
            private string F_UF_EMIT = "";
            public string UF_EMIT
            {
                get { return F_UF_EMIT; }
                set { F_UF_EMIT = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do participante emitente do modal
            /// </summary>
            private string F_IE_EMIT = "";
            public string IE_EMIT
            {
                get { return F_IE_EMIT; }
                set { F_IE_EMIT = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// CNPJ/CPF do participante tomador do serviço
            /// </summary>
            private string F_CNPJ_CPF_TOM = "";
            public string CNPJ_CPF_TOM
            {
                get { return F_CNPJ_CPF_TOM; }
                set { F_CNPJ_CPF_TOM = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da unidade da federação do participante tomador do serviço
            /// </summary>
            private string F_UF_TOM = "";
            public string UF_TOM
            {
                get { return F_UF_TOM; }
                set { F_UF_TOM = value.ToUpper(); }
            }

            /// <summary>
            /// Inscrição Estadual do participante tomador do serviço
            /// </summary>
            private string F_IE_TOM = "";
            public string IE_TOM
            {
                get { return F_IE_TOM; }
                set { F_IE_TOM = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de destino, conforme a tabela IBGE(Preencher com 9999999, se Exterior)
            /// </summary>
            private string F_COD_MUN_DEST = "";
            public string COD_MUN_DEST
            {
                get { return F_COD_MUN_DEST; }
                set { F_COD_MUN_DEST = value.ToUpper(); }
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
            /// Valor total do documento fiscal
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            public string GetRegistro_D180(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo NUM_SEQ */
                    if (F_NUM_SEQ.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_SEQ não informado(a)";
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
                    /* validacao para o tamanho do campo CNPJ_CPF_EMIT */
                    if (F_CNPJ_CPF_EMIT.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_EMIT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CNPJ_CPF_EMIT */
                    if (F_CNPJ_CPF_EMIT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CNPJ_CPF_EMIT não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF_EMIT */
                    if (F_UF_EMIT.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_EMIT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF_EMIT */
                    if (F_UF_EMIT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF_EMIT não informado(a)";
                    }
                    /* validacao para o tamanho do campo IE_EMIT */
                    if (F_IE_EMIT.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_EMIT incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ_CPF_TOM */
                    if (F_CNPJ_CPF_TOM.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ_CPF_TOM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CNPJ_CPF_TOM */
                    if (F_CNPJ_CPF_TOM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CNPJ_CPF_TOM não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF_TOM */
                    if (F_UF_TOM.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_TOM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF_TOM */
                    if (F_UF_TOM.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF_TOM não informado(a)";
                    }
                    /* validacao para o tamanho do campo IE_TOM */
                    if (F_IE_TOM.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_TOM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_DEST */
                    if (F_COD_MUN_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_DEST não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|", F_REG, F_NUM_SEQ, F_IND_EMIT, F_CNPJ_CPF_EMIT, F_UF_EMIT, F_IE_EMIT, F_COD_MUN_ORIG, F_CNPJ_CPF_TOM, F_UF_TOM, F_IE_TOM, F_COD_MUN_DEST, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC, F_VL_DOC);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGO 07, 08, 8B, 09, 10, 11, 26, 27 e 57).
        /// </summary>
        public class Registro_D190
        {
            /// <summary>
            /// Texto fixo contendo "D190"
            /// </summary>
            private string F_REG = "D190";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação CST_ICMS, CFOP e alíquota do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_D190(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_RED_BC, F_COD_OBS);
            }
        }

        /// <summary>
        /// OBSERVAÇOES DO LANÇAMENTO FISCAL
        /// </summary>
        public class Registro_D195
        {
            /// <summary>
            /// Texto fixo contendo "D195"
            /// </summary>
            private string F_REG = "D195";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar do código de observação.
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
            }

            public string GetRegistro_D195(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_OBS, F_TXT_COMPL);
            }
        }

        /// <summary>
        /// OUTRAS OBRIGAÇÕES TRIBUTÁRIAS, AJUSTES E INFORMAÇÕES DE VALORES PROVENIENTES DE DOCUMENTO FISCAL.
        /// </summary>
        public class Registro_D197
        {
            /// <summary>
            /// Texto fixo contendo "D197"
            /// </summary>
            private string F_REG = "D197";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do ajustes/benefício/incentivo, conforme tabela indicada no item 5.3.
            /// </summary>
            private string F_COD_AJ = "";
            public string COD_AJ
            {
                get { return F_COD_AJ; }
                set { F_COD_AJ = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição complementar do ajuste do documento fiscal
            /// </summary>
            private string F_DESCR_COMPL_AJ = "";
            public string DESCR_COMPL_AJ
            {
                get { return F_DESCR_COMPL_AJ; }
                set { F_DESCR_COMPL_AJ = value.ToUpper(); }
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
            /// Base de cálculo do ICMS ou do ICMS ST
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS ou do ICMS ST
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Outros valores
            /// </summary>
            private string F_VL_OUTROS = "";
            public string VL_OUTROS
            {
                get { return F_VL_OUTROS; }
                set { F_VL_OUTROS = value.ToUpper(); }
            }

            public string GetRegistro_D197(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_COD_AJ, F_DESCR_COMPL_AJ, F_COD_ITEM, F_VL_BC_ICMS, F_ALIQ_ICMS, F_VL_ICMS, F_VL_OUTROS);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DOS BILHETES CONSOLIDADOS DE PASSAGEM RODOVIÁRIO (CÓDIGO 13), DE PASSAGEM AQUAVIÁRIO (CÓDIGO 14), DE PASSAGEM E NOTA DE BAGAGEM (CÓDIGO 15) E DE PASSAGEM FERROVIÁRIO (CÓDIGO 16).
        /// </summary>
        public class Registro_D300
        {
            /// <summary>
            /// Texto fixo contendo "D300"
            /// </summary>
            private string F_REG = "D300";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
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
            /// Número do primeiro documento fiscal emitido (mesmo modelo, série e subsérie)
            /// </summary>
            private string F_NUM_DOC_INI = "";
            public string NUM_DOC_INI
            {
                get { return F_NUM_DOC_INI; }
                set { F_NUM_DOC_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Número do último documento fiscal emitido (mesmo modelo, série e subsérie)
            /// </summary>
            private string F_NUM_DOC_FIN = "";
            public string NUM_DOC_FIN
            {
                get { return F_NUM_DOC_FIN; }
                set { F_NUM_DOC_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação conforme tabela indicada no item 4.2.2
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Data da emissão dos documentos fiscais
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total acumulado das operações correspondentes à combinação de CST_ICMS, CFOP e alíquota do ICMS, incluídas as despesas acessórias e acréscimos.
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos descontos
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de seguro
            /// </summary>
            private string F_VL_SEG = "";
            public string VL_SEG
            {
                get { return F_VL_SEG; }
                set { F_VL_SEG = value.ToUpper(); }
            }

            /// <summary>
            /// DESP Valor de outras despesas
            /// </summary>
            private string F_VL_OUT = "";
            public string VL_OUT
            {
                get { return F_VL_OUT; }
                set { F_VL_OUT = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_D300(bool Validate)
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
                    if (F_SUB.Length > 4)
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
                    /* validacao para o tamanho do campo NUM_DOC_INI */
                    if (F_NUM_DOC_INI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NUM_DOC_FIN */
                    if (F_NUM_DOC_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NUM_DOC_FIN não informado(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_OPR */
                    if (F_VL_OPR.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_OPR não informado(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS */
                    if (F_VL_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_RED_BC */
                    if (F_VL_RED_BC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_RED_BC não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|", F_REG, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC_INI, F_NUM_DOC_FIN, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_DT_DOC, F_VL_OPR, F_VL_DESC, F_VL_SERV, F_VL_SEG, F_VL_OUT, F_VL_BC_ICMS, F_VL_ICMS, F_VL_RED_BC, F_COD_OBS, F_COD_CTA);
            }
        }

        /// <summary>
        /// DOCUMENTOS CANCELADOS DOS BILHETES DE PASSAGEM RODOVIÁRIO (CÓDIGO 13), DE PASSAGEM AQUAVIÁRIO (CÓDIGO 14), DE PASSAGEM E NOTA DE BAGAGEM (CÓDIGO 15) E DE PASSAGEM FERROVIÁRIO (CÓDIGO 16).
        /// </summary>
        public class Registro_D301
        {
            /// <summary>
            /// Texto fixo contendo "D301"
            /// </summary>
            private string F_REG = "D301";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento fiscal cancelado
            /// </summary>
            private string F_NUM_DOC_CANC = "";
            public string NUM_DOC_CANC
            {
                get { return F_NUM_DOC_CANC; }
                set { F_NUM_DOC_CANC = value.ToUpper(); }
            }

            public string GetRegistro_D301(bool Validate)
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
                }
                return String.Format("|{0}|{1}|", F_REG, F_NUM_DOC_CANC);
            }
        }

        /// <summary>
        /// COMPLEMENTO DOS BILHETES (CÓDIGO 13, 14, 15 E 16).
        /// </summary>
        public class Registro_D310
        {
            /// <summary>
            /// Texto fixo contendo "D310"
            /// </summary>
            private string F_REG = "D310";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_D310(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_MUN_ORIG, F_VL_SERV, F_VL_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// EQUIPAMENTO ECF (CÓDIGOS 2E, 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D350
        {
            /// <summary>
            /// Texto fixo contendo "D350"
            /// </summary>
            private string F_REG = "D350";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
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
            /// Modelo do equipamento
            /// </summary>
            private string F_ECF_MOD = "";
            public string ECF_MOD
            {
                get { return F_ECF_MOD; }
                set { F_ECF_MOD = value.ToUpper(); }
            }

            /// <summary>
            /// Número de série de fabricação do ECF
            /// </summary>
            private string F_ECF_FAB = "";
            public string ECF_FAB
            {
                get { return F_ECF_FAB; }
                set { F_ECF_FAB = value.ToUpper(); }
            }

            /// <summary>
            /// Número do caixa atribuído ao ECF
            /// </summary>
            private string F_ECF_CX = "";
            public string ECF_CX
            {
                get { return F_ECF_CX; }
                set { F_ECF_CX = value.ToUpper(); }
            }

            public string GetRegistro_D350(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_MOD, F_ECF_MOD, F_ECF_FAB, F_ECF_CX);
            }
        }

        /// <summary>
        /// REDUÇÃO Z (CÓDIGOS 2E, 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D355
        {
            /// <summary>
            /// Texto fixo contendo "D355"
            /// </summary>
            private string F_REG = "D355";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data do movimento a que se refere a Redução Z
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Posição do Contador de Reinício de Operação
            /// </summary>
            private string F_CRO = "";
            public string CRO
            {
                get { return F_CRO; }
                set { F_CRO = value.ToUpper(); }
            }

            /// <summary>
            /// Posição do Contador de Redução Z
            /// </summary>
            private string F_CRZ = "";
            public string CRZ
            {
                get { return F_CRZ; }
                set { F_CRZ = value.ToUpper(); }
            }

            /// <summary>
            /// Número do Contador de Ordem de Operação do último documento emitido no dia. (Número do COO na Redução Z)
            /// </summary>
            private string F_NUM_COO_FIN = "";
            public string NUM_COO_FIN
            {
                get { return F_NUM_COO_FIN; }
                set { F_NUM_COO_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do Grande Total final
            /// </summary>
            private string F_GT_FIN = "";
            public string GT_FIN
            {
                get { return F_GT_FIN; }
                set { F_GT_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da venda bruta
            /// </summary>
            private string F_VL_BRT = "";
            public string VL_BRT
            {
                get { return F_VL_BRT; }
                set { F_VL_BRT = value.ToUpper(); }
            }

            public string GetRegistro_D355(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_DT_DOC, F_CRO, F_CRZ, F_NUM_COO_FIN, F_GT_FIN, F_VL_BRT);
            }
        }

        /// <summary>
        /// PIS E COFINS TOTALIZADOS NO DIA (CÓDIGOS 2E, 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D360
        {
            /// <summary>
            /// Texto fixo contendo "D360"
            /// </summary>
            private string F_REG = "D360";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_D360(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// REGISTRO DOS TOTALIZADORES PARCIAIS DA REDUÇÃO Z (CÓDIGOS 2E, 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D365
        {
            /// <summary>
            /// Texto fixo contendo "D365"
            /// </summary>
            private string F_REG = "D365";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do totalizador, conforme Tabela 4.4.6
            /// </summary>
            private string F_COD_TOT_PAR = "";
            public string COD_TOT_PAR
            {
                get { return F_COD_TOT_PAR; }
                set { F_COD_TOT_PAR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado no totalizador, relativo à respectiva Redução Z.
            /// </summary>
            private string F_VLR_ACUM_TOT = "";
            public string VLR_ACUM_TOT
            {
                get { return F_VLR_ACUM_TOT; }
                set { F_VLR_ACUM_TOT = value.ToUpper(); }
            }

            /// <summary>
            /// Número do totalizador quando ocorrer mais de uma situação com a mesma carga tributária efetiva.
            /// </summary>
            private string F_NR_TOT = "";
            public string NR_TOT
            {
                get { return F_NR_TOT; }
                set { F_NR_TOT = value.ToUpper(); }
            }

            /// <summary>
            /// Descrição da situação tributária relativa ao totalizador parcial, quando houver mais de um com a mesma carga tributária efetiva.
            /// </summary>
            private string F_DESCR_NR_TOT = "";
            public string DESCR_NR_TOT
            {
                get { return F_DESCR_NR_TOT; }
                set { F_DESCR_NR_TOT = value.ToUpper(); }
            }

            public string GetRegistro_D365(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_TOT_PAR, F_VLR_ACUM_TOT, F_NR_TOT, F_DESCR_NR_TOT);
            }
        }

        /// <summary>
        /// COMPLEMENTO DOS DOCUMENTOS INFORMADOS (CÓDIGOS 13, 14, 15 e 16 e 2E)
        /// </summary>
        public class Registro_D370
        {
            /// <summary>
            /// Texto fixo contendo "D370"
            /// </summary>
            private string F_REG = "D370";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade de bilhetes emitidos
            /// </summary>
            private string F_QTD_BILH = "";
            public string QTD_BILH
            {
                get { return F_QTD_BILH; }
                set { F_QTD_BILH = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_D370(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_BILH */
                    if (F_QTD_BILH.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_BILH não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_COD_MUN_ORIG, F_VL_SERV, F_QTD_BILH, F_VL_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DO MOVIMENTO DIÁRIO (CÓDIGOS 13, 14, 15, 16 E 2E).
        /// </summary>
        public class Registro_D390
        {
            /// <summary>
            /// Texto fixo contendo "D390"
            /// </summary>
            private string F_REG = "D390";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1.
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS, incluídas as despesas acessórias e acréscimos
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da base de cálculo do ISSQN
            /// </summary>
            private string F_VL_BC_ISSQN = "";
            public string VL_BC_ISSQN
            {
                get { return F_VL_BC_ISSQN; }
                set { F_VL_BC_ISSQN = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ISSQN
            /// </summary>
            private string F_ALIQ_ISSQN = "";
            public string ALIQ_ISSQN
            {
                get { return F_ALIQ_ISSQN; }
                set { F_ALIQ_ISSQN = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ISSQN
            /// </summary>
            private string F_VL_ISSQN = "";
            public string VL_ISSQN
            {
                get { return F_VL_ISSQN; }
                set { F_VL_ISSQN = value.ToUpper(); }
            }

            /// <summary>
            /// Base de cálculo do ICMS acumulada relativa à alíquota informada
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS acumulado relativo à alíquota informada
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_D390(bool Validate)
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
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ISSQN */
                    if (F_ALIQ_ISSQN.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ISSQN incorreto(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ISSQN, F_ALIQ_ISSQN, F_VL_ISSQN, F_VL_BC_ICMS, F_VL_ICMS, F_COD_OBS);
            }
        }

        /// <summary>
        /// RESUMO DE MOVIMENTO DIÁRIO - RMD (CÓDIGO 18).
        /// </summary>
        public class Registro_D400
        {
            /// <summary>
            /// Texto fixo contendo "D400"
            /// </summary>
            private string F_REG = "D400";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): agência, filial ou posto
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
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            private string F_COD_SIT = "";
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
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
            /// Número do documento fiscal resumo.
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
            /// Valor total do documento fiscal
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado dos descontos
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_D400(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|", F_REG, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC, F_VL_DOC, F_VL_DESC, F_VL_SERV, F_VL_BC_ICMS, F_VL_ICMS, F_VL_PIS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// DOCUMENTOS INFORMADOS (CÓDIGOS 13, 14, 15 E 16).
        /// </summary>
        public class Registro_D410
        {
            /// <summary>
            /// Texto fixo contendo "D410"
            /// </summary>
            private string F_REG = "D410";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do modelo do documento fiscal , conforme a Tabela 4.1.1
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
            /// Número do documento fiscal inicial (mesmo modelo, série e subsérie)
            /// </summary>
            private string F_NUM_DOC_INI = "";
            public string NUM_DOC_INI
            {
                get { return F_NUM_DOC_INI; }
                set { F_NUM_DOC_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento fiscal final(mesmo modelo, série e subsérie)
            /// </summary>
            private string F_NUM_DOC_FIN = "";
            public string NUM_DOC_FIN
            {
                get { return F_NUM_DOC_FIN; }
                set { F_NUM_DOC_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Data da emissão dos documentos fiscais
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total acumulado das operações correspondentes à combinação de CST_ICMS, CFOP e alíquota do ICMS, incluídas as despesas acessórias e acréscimos.
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado dos descontos
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_D410(bool Validate)
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
                    /* validacao para o tamanho do campo NUM_DOC_INI */
                    if (F_NUM_DOC_INI.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de NUM_DOC_INI incorreto(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", F_REG, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC_INI, F_NUM_DOC_FIN, F_DT_DOC, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_DESC, F_VL_SERV, F_VL_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// DOCUMENTOS CANCELADOS DOS DOCUMENTOS INFORMADOS (CÓDIGO 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D411
        {
            /// <summary>
            /// Texto fixo contendo "D411"
            /// </summary>
            private string F_REG = "D411";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Número do documento fiscal cancelado
            /// </summary>
            private string F_NUM_DOC_CANC = "";
            public string NUM_DOC_CANC
            {
                get { return F_NUM_DOC_CANC; }
                set { F_NUM_DOC_CANC = value.ToUpper(); }
            }

            public string GetRegistro_D411(bool Validate)
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
                }
                return String.Format("|{0}|{1}|", F_REG, F_NUM_DOC_CANC);
            }
        }

        /// <summary>
        /// COMPLEMENTO DOS DOCUMENTOS INFORMADOS (CÓDIGO 13, 14, 15 e 16).
        /// </summary>
        public class Registro_D420
        {
            /// <summary>
            /// Texto fixo contendo "D420"
            /// </summary>
            private string F_REG = "D420";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do município de origem do serviço, conforme a tabela IBGE
            /// </summary>
            private string F_COD_MUN_ORIG = "";
            public string COD_MUN_ORIG
            {
                get { return F_COD_MUN_ORIG; }
                set { F_COD_MUN_ORIG = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da prestação de serviço
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_D420(bool Validate)
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
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN_ORIG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN_ORIG */
                    if (F_COD_MUN_ORIG.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN_ORIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS */
                    if (F_VL_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_COD_MUN_ORIG, F_VL_SERV, F_VL_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// NOTA FISCAL DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E NOTA FISCAL DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22).
        /// </summary>
        public class Registro_D500
        {
            /// <summary>
            /// Texto fixo contendo "D500"
            /// </summary>
            private string F_REG = "D500";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de operação: 0- Aquisição; 1- Prestação
            /// </summary>
            private string F_IND_OPER = "";
            public string IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value.ToUpper(); }
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
            /// Código do participante (campo 02 do Registro 0150): do prestador do serviço, no caso de aquisição; do tomador do serviço, no caso de prestação.
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
            /// Código da situação do documento fiscal, conforme a Tabela 4.1.2
            /// </summary>
            private string F_COD_SIT = "";
            public string COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value.ToUpper(); }
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
            /// Data da entrada (aquisição) ou da saída (prestação do serviço)
            /// </summary>
            private string F_DT_A_P = "";
            public string DT_A_P
            {
                get { return F_DT_A_P; }
                set { F_DT_A_P = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do documento fiscal
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da prestação de serviços
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total dos serviços não-tributados pelo ICMS
            /// </summary>
            private string F_VL_SERV_NT = "";
            public string VL_SERV_NT
            {
                get { return F_VL_SERV_NT; }
                set { F_VL_SERV_NT = value.ToUpper(); }
            }

            /// <summary>
            /// Valores cobrados em nome de terceiros
            /// </summary>
            private string F_VL_TERC = "";
            public string VL_TERC
            {
                get { return F_VL_TERC; }
                set { F_VL_TERC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor de outras despesas indicadas no documento fiscal
            /// </summary>
            private string F_VL_DA = "";
            public string VL_DA
            {
                get { return F_VL_DA; }
                set { F_VL_DA = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da informação complementar (campo 02 do Registro 0450)
            /// </summary>
            private string F_COD_INF = "";
            public string COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            /// <summary>
            /// Código do Tipo de Assinante: 1 - Comercial/Industrial 2 - Poder Público 3 - Residencial/Pessoa física 4 - Público 5 - Semi-Público 6 - Outros
            /// </summary>
            private string F_TP_ASSINANTE = "";
            public string TP_ASSINANTE
            {
                get { return F_TP_ASSINANTE; }
                set { F_TP_ASSINANTE = value.ToUpper(); }
            }

            public string GetRegistro_D500(bool Validate)
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
                        return "Erro - O campo IND_OPER possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_EMIT */
                    if (F_IND_EMIT.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EMIT incorreto(a)";
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
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_A_P */
                    if (F_DT_A_P.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_A_P incorreto(a)";
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
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo TP_ASSINANTE */
                    if (F_TP_ASSINANTE.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de TP_ASSINANTE incorreto(a)";
                    }
                    /* Validacao para os dados informados a TP_ASSINANTE */
                    if (!(F_TP_ASSINANTE.Equals("1") || F_TP_ASSINANTE.Equals("2") || F_TP_ASSINANTE.Equals("3") || F_TP_ASSINANTE.Equals("4") || F_TP_ASSINANTE.Equals("5") || F_TP_ASSINANTE.Equals("6")))
                    {
                        return "Erro - O campo TP_ASSINANTE possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_SUB, F_NUM_DOC, F_DT_DOC, F_DT_A_P, F_VL_DOC, F_VL_DESC, F_VL_SERV, F_VL_SERV_NT, F_VL_TERC, F_VL_DA, F_VL_BC_ICMS, F_VL_ICMS, F_COD_INF, F_VL_PIS, F_VL_COFINS, F_COD_CTA, F_TP_ASSINANTE);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO – NOTA FISCAL DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22).
        /// </summary>
        public class Registro_D510
        {
            /// <summary>
            /// Texto fixo contendo "D510"
            /// </summary>
            private string F_REG = "D510";
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
            /// Código do item (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Código de classificação do item do serviço de comunicação ou de telecomunicação, conforme a Tabela 4.4.1
            /// </summary>
            private string F_COD_CLASS = "";
            public string COD_CLASS
            {
                get { return F_COD_CLASS; }
                set { F_COD_CLASS = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade do item
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            private string F_UNID = "";
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do item
            /// </summary>
            private string F_VL_ITEM = "";
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do desconto
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS creditado/debitado
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// F Valor da base de cálculo do ICMS de outras UFs
            /// </summary>
            private string F_VL_BC_ICMS_U = "";
            public string VL_BC_ICMS_U
            {
                get { return F_VL_BC_ICMS_U; }
                set { F_VL_BC_ICMS_U = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS de outras UFs
            /// </summary>
            private string F_VL_ICMS_UF = "";
            public string VL_ICMS_UF
            {
                get { return F_VL_ICMS_UF; }
                set { F_VL_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de receita: 0- Receita própria / serviços prestados; 1- Receita própria / cobrança de débitos; 2- Receita própria / venda de mercadorias; 3- Receita própria / venda de serviço pré-pago; 4- Outras receitas próprias; 5- Receitas de terceiros (co faturamento); 9- Outras receitas de terceiros
            /// </summary>
            private string F_IND_REC = "";
            public string IND_REC
            {
                get { return F_IND_REC; }
                set { F_IND_REC = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150) receptor da receita, terceiro da operação, se houver.
            /// </summary>
            private string F_COD_PART = "";
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_D510(bool Validate)
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
                    /* validacao para o tamanho do campo COD_CLASS */
                    if (F_COD_CLASS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de COD_CLASS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CLASS */
                    if (F_COD_CLASS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CLASS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CLASS */
                    if (F_COD_CLASS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de COD_CLASS incorreto(a)";
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
                    /* validacao para o tamanho do campo IND_REC */
                    if (F_IND_REC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_REC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_REC */
                    if (F_IND_REC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_REC não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_REC */
                    if (!(F_IND_REC.Equals("0") || F_IND_REC.Equals("1") || F_IND_REC.Equals("2") || F_IND_REC.Equals("3") || F_IND_REC.Equals("PR") || F_IND_REC.Equals("4") || F_IND_REC.Equals("5") || F_IND_REC.Equals("9")))
                    {
                        return "Erro - O campo IND_REC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|", F_REG, F_NUM_ITEM, F_COD_ITEM, F_COD_CLASS, F_QTD, F_UNID, F_VL_ITEM, F_VL_DESC, F_CST_ICMS, F_CFOP, F_VL_BC_ICMS, F_ALIQ_ICMS, F_VL_ICMS, F_VL_BC_ICMS_U, F_VL_ICMS_UF, F_IND_REC, F_COD_PART, F_VL_PIS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// TERMINAL FATURADO.
        /// </summary>
        public class Registro_D530
        {
            /// <summary>
            /// Texto fixo contendo "D530"
            /// </summary>
            private string F_REG = "D530";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de serviço prestado: 0- Telefonia; 1- Comunicação de dados; 2- TV por assinatura; 3- Provimento de acesso à Internet; 4- Multimídia; 9- Outros
            /// </summary>
            private string F_IND_SERV = "";
            public string IND_SERV
            {
                get { return F_IND_SERV; }
                set { F_IND_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Data em que se iniciou a prestação do serviço
            /// </summary>
            private string F_DT_INI_SERV = "";
            public string DT_INI_SERV
            {
                get { return F_DT_INI_SERV; }
                set { F_DT_INI_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Data em que se encerrou a prestação do serviço
            /// </summary>
            private string F_DT_FIN_SERV = "";
            public string DT_FIN_SERV
            {
                get { return F_DT_FIN_SERV; }
                set { F_DT_FIN_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// Período fiscal da prestação do serviço (MMAAAA)
            /// </summary>
            private string F_PER_FISCAL = "";
            public string PER_FISCAL
            {
                get { return F_PER_FISCAL; }
                set { F_PER_FISCAL = value.ToUpper(); }
            }

            /// <summary>
            /// Código de área do terminal faturado
            /// </summary>
            private string F_COD_AREA = "";
            public string COD_AREA
            {
                get { return F_COD_AREA; }
                set { F_COD_AREA = value.ToUpper(); }
            }

            /// <summary>
            /// Identificação do terminal faturado
            /// </summary>
            private string F_TERMINAL = "";
            public string TERMINAL
            {
                get { return F_TERMINAL; }
                set { F_TERMINAL = value.ToUpper(); }
            }

            public string GetRegistro_D530(bool Validate)
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
                    /* validacao para o tamanho do campo IND_SERV */
                    if (F_IND_SERV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_SERV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_SERV */
                    if (F_IND_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_SERV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_SERV */
                    if (!(F_IND_SERV.Equals("0") || F_IND_SERV.Equals("1") || F_IND_SERV.Equals("2") || F_IND_SERV.Equals("3") || F_IND_SERV.Equals("4") || F_IND_SERV.Equals("9")))
                    {
                        return "Erro - O campo IND_SERV possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo DT_INI_SERV */
                    if (F_DT_INI_SERV.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI_SERV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN_SERV */
                    if (F_DT_FIN_SERV.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN_SERV incorreto(a)";
                    }
                    /* validacao para o tamanho do campo PER_FISCAL */
                    if (F_PER_FISCAL.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de PER_FISCAL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PER_FISCAL */
                    if (F_PER_FISCAL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PER_FISCAL não informado(a)";
                    }
                    /* validacao para o tamanho do campo PER_FISCAL */
                    if (F_PER_FISCAL.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de PER_FISCAL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo PER_FISCAL */
                    if (F_PER_FISCAL.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de PER_FISCAL incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_IND_SERV, F_DT_INI_SERV, F_DT_FIN_SERV, F_PER_FISCAL, F_COD_AREA, F_TERMINAL);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DO DOCUMENTO (CÓDIGO 21 E 22).
        /// </summary>
        public class Registro_D590
        {
            /// <summary>
            /// Texto fixo contendo "D590"
            /// </summary>
            private string F_REG = "D590";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS, incluídas as despesas acessórias e acréscimos
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// F Parcela correspondente ao valor da base de cálculo do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_BC_ICMS_U = "";
            public string VL_BC_ICMS_U
            {
                get { return F_VL_BC_ICMS_U; }
                set { F_VL_BC_ICMS_U = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao valor do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            private string F_VL_ICMS_UF = "";
            public string VL_ICMS_UF
            {
                get { return F_VL_ICMS_UF; }
                set { F_VL_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_D590(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_U, F_VL_ICMS_UF, F_VL_RED_BC, F_COD_OBS);
            }
        }

        /// <summary>
        /// CONSOLIDAÇÃO DA PRESTAÇÃO DE SERVIÇOS - NOTAS DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22).
        /// </summary>
        public class Registro_D600
        {
            /// <summary>
            /// Texto fixo contendo "D600"
            /// </summary>
            private string F_REG = "D600";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
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
            /// Código do município dos terminais faturados, conforme a tabela IBGE
            /// </summary>
            private string F_COD_MUN = "";
            public string COD_MUN
            {
                get { return F_COD_MUN; }
                set { F_COD_MUN = value.ToUpper(); }
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
            /// Código de classe de consumo dos serviços de comunicação ou de telecomunicação, conforme a Tabela 4.4.4
            /// </summary>
            private string F_COD_CONS = "";
            public string COD_CONS
            {
                get { return F_COD_CONS; }
                set { F_COD_CONS = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade de documentos consolidados neste registro
            /// </summary>
            private string F_QTD_CONS = "";
            public string QTD_CONS
            {
                get { return F_QTD_CONS; }
                set { F_QTD_CONS = value.ToUpper(); }
            }

            /// <summary>
            /// Data dos documentos consolidados
            /// </summary>
            private string F_DT_DOC = "";
            public string DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total acumulado dos documentos fiscais
            /// </summary>
            private string F_VL_DOC = "";
            public string VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado dos descontos
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado das prestações de serviços tributados pelo ICMS
            /// </summary>
            private string F_VL_SERV = "";
            public string VL_SERV
            {
                get { return F_VL_SERV; }
                set { F_VL_SERV = value.ToUpper(); }
            }

            /// <summary>
            /// T Valor acumulado dos serviços nãotributados pelo ICMS
            /// </summary>
            private string F_VL_SERV_N = "";
            public string VL_SERV_N
            {
                get { return F_VL_SERV_N; }
                set { F_VL_SERV_N = value.ToUpper(); }
            }

            /// <summary>
            /// Valores cobrados em nome de terceiros
            /// </summary>
            private string F_VL_TERC = "";
            public string VL_TERC
            {
                get { return F_VL_TERC; }
                set { F_VL_TERC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado das despesas acessórias
            /// </summary>
            private string F_VL_DA = "";
            public string VL_DA
            {
                get { return F_VL_DA; }
                set { F_VL_DA = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            public string GetRegistro_D600(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo COD_MOD */
                    if (F_COD_MOD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MOD não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN */
                    if (F_COD_MUN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN não informado(a)";
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
                    /* validacao para o tamanho do campo COD_CONS */
                    if (F_COD_CONS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_CONS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CONS */
                    if (F_COD_CONS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CONS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CONS */
                    if (F_COD_CONS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_CONS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_CONS */
                    if (F_QTD_CONS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_CONS não informado(a)";
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
                    /* validacao para a obrigatoriedade do campo VL_SERV */
                    if (F_VL_SERV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_SERV não informado(a)";
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
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC */
                    if (F_DT_DOC.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS */
                    if (F_VL_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|", F_REG, F_COD_MOD, F_COD_MUN, F_SER, F_SUB, F_COD_CONS, F_QTD_CONS, F_DT_DOC, F_VL_DOC, F_VL_DESC, F_VL_SERV, F_VL_SERV_N, F_VL_TERC, F_VL_DA, F_VL_BC_ICMS, F_VL_ICMS, F_VL_PIS, F_VL_COFINS);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO CONSOLIDADO (CÓDIGO 21 E 22).
        /// </summary>
        public class Registro_D610
        {
            /// <summary>
            /// Texto fixo contendo "D610"
            /// </summary>
            private string F_REG = "D610";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código de classificação do item do serviço de comunicação ou de telecomunicação, conforme a Tabela 4.4.1
            /// </summary>
            private string F_COD_CLASS = "";
            public string COD_CLASS
            {
                get { return F_COD_CLASS; }
                set { F_COD_CLASS = value.ToUpper(); }
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
            /// Quantidade acumulada do item
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            /// <summary>
            /// Unidade do item (Campo 02 do registro 0190)
            /// </summary>
            private string F_UNID = "";
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado do item
            /// </summary>
            private string F_VL_ITEM = "";
            public string VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado dos descontos
            /// </summary>
            private string F_VL_DESC = "";
            public string VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação conforme tabela indicada no item 4.2.2.
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado do ICMS debitado
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// _UF Valor da base de cálculo do ICMS de outras UFs
            /// </summary>
            private string F_VL_BC_ICMS_OUTRAS = "";
            public string VL_BC_ICMS_OUTRAS
            {
                get { return F_VL_BC_ICMS_OUTRAS; }
                set { F_VL_BC_ICMS_OUTRAS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS de outras UFs
            /// </summary>
            private string F_VL_ICMS_UF = "";
            public string VL_ICMS_UF
            {
                get { return F_VL_ICMS_UF; }
                set { F_VL_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado do PIS
            /// </summary>
            private string F_VL_PIS = "";
            public string VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor acumulado da COFINS
            /// </summary>
            private string F_VL_COFINS = "";
            public string VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value.ToUpper(); }
            }

            /// <summary>
            /// Código da conta analítica contábil debitada/creditada
            /// </summary>
            private string F_COD_CTA = "";
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            public string GetRegistro_(bool Validate)
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
                    /* validacao para o tamanho do campo COD_CLASS */
                    if (F_COD_CLASS.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de COD_CLASS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CLASS */
                    if (F_COD_CLASS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CLASS não informado(a)";
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|", F_REG, F_COD_CLASS, F_COD_ITEM, F_QTD, F_UNID, F_VL_ITEM, F_VL_DESC, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_OUTRAS, F_VL_ICMS_UF, F_VL_RED_BC, F_VL_PIS, F_VL_COFINS, F_COD_CTA);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGOS 21 e 22).
        /// </summary>
        public class Registro_D690
        {
            /// <summary>
            /// Texto fixo contendo "D690"
            /// </summary>
            private string F_REG = "D690";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS, incluídas as despesas acessórias e acréscimos
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao valor da base de cálculo do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_BC_ICMS_UF = "";
            public string VL_BC_ICMS_UF
            {
                get { return F_VL_BC_ICMS_UF; }
                set { F_VL_BC_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao valor do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS.
            /// </summary>
            private string F_VL_ICMS_UF = "";
            public string VL_ICMS_UF
            {
                get { return F_VL_ICMS_UF; }
                set { F_VL_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_D690(bool Validate)
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS_UF */
                    if (F_VL_BC_ICMS_UF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS_UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS_UF */
                    if (F_VL_ICMS_UF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS_UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_RED_BC */
                    if (F_VL_RED_BC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_RED_BC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_UF, F_VL_ICMS_UF, F_VL_RED_BC, F_COD_OBS);
            }
        }

        /// <summary>
        /// CONSOLIDAÇÃO DA PRESTAÇÃO DE SERVIÇOS - NOTAS DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22) (EMPRESAS OBRIGADAS À ENTREGA DOS ARQUIVOS PREVISTOS NO CONVÊNIO ICMS 115/03).
        /// </summary>
        public class Registro_D695
        {
            /// <summary>
            /// Texto fixo contendo "D695"
            /// </summary>
            private string F_REG = "D695";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código do modelo do documento fiscal, conforme a Tabela 4.1.1.
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
            /// Número de ordem inicial
            /// </summary>
            private string F_NRO_ORD_INI = "";
            public string NRO_ORD_INI
            {
                get { return F_NRO_ORD_INI; }
                set { F_NRO_ORD_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Número de ordem final
            /// </summary>
            private string F_NRO_ORD_FIN = "";
            public string NRO_ORD_FIN
            {
                get { return F_NRO_ORD_FIN; }
                set { F_NRO_ORD_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Data de emissão inicial dos documentos / Data inicial de vencimento da fatura
            /// </summary>
            private string F_DT_DOC_INI = "";
            public string DT_DOC_INI
            {
                get { return F_DT_DOC_INI; }
                set { F_DT_DOC_INI = value.ToUpper(); }
            }

            /// <summary>
            /// Data de emissão final dos documentos / Data final do vencimento da fatura
            /// </summary>
            private string F_DT_DOC_FIN = "";
            public string DT_DOC_FIN
            {
                get { return F_DT_DOC_FIN; }
                set { F_DT_DOC_FIN = value.ToUpper(); }
            }

            /// <summary>
            /// Nome do arquivo Mestre de Documento Fiscal
            /// </summary>
            private string F_NOM_MEST = "";
            public string NOM_MEST
            {
                get { return F_NOM_MEST; }
                set { F_NOM_MEST = value.ToUpper(); }
            }

            /// <summary>
            /// Chave de codificação digital do arquivo Mestre de Documento Fiscal
            /// </summary>
            private string F_CHV_COD_DIG = "";
            public string CHV_COD_DIG
            {
                get { return F_CHV_COD_DIG; }
                set { F_CHV_COD_DIG = value.ToUpper(); }
            }

            public string GetRegistro_D695(bool Validate)
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
                    /* validacao para o tamanho do campo NRO_ORD_INI */
                    if (F_NRO_ORD_INI.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NRO_ORD_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NRO_ORD_INI */
                    if (F_NRO_ORD_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NRO_ORD_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo NRO_ORD_FIN */
                    if (F_NRO_ORD_FIN.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de NRO_ORD_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NRO_ORD_FIN */
                    if (F_NRO_ORD_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NRO_ORD_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC_INI */
                    if (F_DT_DOC_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_DOC_INI */
                    if (F_DT_DOC_INI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_DOC_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_DOC_FIN */
                    if (F_DT_DOC_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_DOC_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_DOC_FIN */
                    if (F_DT_DOC_FIN.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_DOC_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOM_MEST */
                    if (F_NOM_MEST.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de NOM_MEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOM_MEST */
                    if (F_NOM_MEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOM_MEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo CHV_COD_DIG */
                    if (F_CHV_COD_DIG.Length > 32)
                    {
                        return "Erro -> Tamanho do campo de CHV_COD_DIG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CHV_COD_DIG */
                    if (F_CHV_COD_DIG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CHV_COD_DIG não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", F_REG, F_COD_MOD, F_SER, F_NRO_ORD_INI, F_NRO_ORD_FIN, F_DT_DOC_INI, F_DT_DOC_FIN, F_NOM_MEST, F_CHV_COD_DIG);
            }
        }

        /// <summary>
        /// REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGO 21 E 22).
        /// </summary>
        public class Registro_D696
        {
            /// <summary>
            /// Texto fixo contendo "D696"
            /// </summary>
            private string F_REG = "D696";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária, conforme a tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Código Fiscal de Operação e Prestação, conforme a tabela indicada no item 4.2.2
            /// </summary>
            private string F_CFOP = "";
            public string CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value.ToUpper(); }
            }

            /// <summary>
            /// Alíquota do ICMS
            /// </summary>
            private string F_ALIQ_ICMS = "";
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da operação correspondente à combinação de CST_ICMS, CFOP, e alíquota do ICMS, incluídas as despesas acessórias e acréscimos
            /// </summary>
            private string F_VL_OPR = "";
            public string VL_OPR
            {
                get { return F_VL_OPR; }
                set { F_VL_OPR = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor da base de cálculo do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao "Valor do ICMS" referente à combinação CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao valor da base de cálculo do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS
            /// </summary>
            private string F_VL_BC_ICMS_UF = "";
            public string VL_BC_ICMS_UF
            {
                get { return F_VL_BC_ICMS_UF; }
                set { F_VL_BC_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Parcela correspondente ao valor do ICMS de outras UFs, referente à combinação de CST_ICMS, CFOP, e alíquota do ICMS
            /// </summary>
            private string F_VL_ICMS_UF = "";
            public string VL_ICMS_UF
            {
                get { return F_VL_ICMS_UF; }
                set { F_VL_ICMS_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor não tributado em função da redução da base de cálculo do ICMS, referente à combinação de CST_ICMS, CFOP e alíquota do ICMS.
            /// </summary>
            private string F_VL_RED_BC = "";
            public string VL_RED_BC
            {
                get { return F_VL_RED_BC; }
                set { F_VL_RED_BC = value.ToUpper(); }
            }

            /// <summary>
            /// Código da observação do lançamento fiscal (campo 02 do Registro 0460)
            /// </summary>
            private string F_COD_OBS = "";
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            public string GetRegistro_D696(bool Validate)
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
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS_UF */
                    if (F_VL_BC_ICMS_UF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS_UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS_UF */
                    if (F_VL_ICMS_UF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS_UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_RED_BC */
                    if (F_VL_RED_BC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_RED_BC não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_CST_ICMS, F_CFOP, F_ALIQ_ICMS, F_VL_OPR, F_VL_BC_ICMS, F_VL_ICMS, F_VL_BC_ICMS_UF, F_VL_ICMS_UF, F_VL_RED_BC, F_COD_OBS);
            }
        }

        /// <summary>
        /// REGISTRO DE INFORMAÇÕES DE OUTRAS UFs, RELATIVAMENTE AOS SERVIÇOS “NÃO-MEDIDOS” DE TELEVISÃO POR ASSINATURA VIA SATÉLITE.
        /// </summary>
        public class Registro_D697
        {
            /// <summary>
            /// Texto fixo contendo "D697"
            /// </summary>
            private string F_REG = "D697";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Sigla da unidade da federação
            /// </summary>
            private string F_UF = "";
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            /// <summary>
            /// Valor da base de cálculo do ICMS
            /// </summary>
            private string F_VL_BC_ICMS = "";
            public string VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Valor do ICMS
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_D697(bool Validate)
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
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_BC_ICMS */
                    if (F_VL_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_UF, F_VL_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO D.
        /// </summary>
        public class Registro_D990
        {
            /// <summary>
            /// Texto fixo contendo "D990"
            /// </summary>
            private string F_REG = "D990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco D
            /// </summary>
            private string F_QTD_LIN_D = "";
            public string QTD_LIN_D
            {
                get { return F_QTD_LIN_D; }
                set { F_QTD_LIN_D = value.ToUpper(); }
            }

            public string GetRegistro_D990(bool Validate)
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
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_D);
            }
        }
    }
}
