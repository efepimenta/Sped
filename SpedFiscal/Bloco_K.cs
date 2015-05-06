using System;

namespace SpedFiscal
{
    public class Bloco_K
    {
        /// <summary>
        /// ABERTURA DO BLOCO K
        /// </summary>
        public class Registro_K001
        {
            /// <summary>
            /// Texto fixo contendo "K001"
            /// </summary>
            private string F_REG = "K001";
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

            public string GetRegistro_k001(bool Validate)
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
        /// PERÍODO DE APURAÇÃO DO ICMS/IPI
        /// </summary>
        public class Registro_K100
        {
            /// <summary>
            /// Texto fixo contendo "K100"
            /// </summary>
            private string F_REG = "K100";
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

            public string GetRegistro_K100(bool Validate)
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
        /// ESTOQUE ESCRITURADO
        /// </summary>
        public class Registro_K200
        {
            /// <summary>
            /// Texto fixo contendo "K200"
            /// </summary>
            private string F_REG = "K200";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data do estoque final
            /// </summary>
            private string F_DT_EST = "";
            public string DT_EST
            {
                get { return F_DT_EST; }
                set { F_DT_EST = value.ToUpper(); }
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
            /// Quantidade em estoque
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            /// <summary>
            /// Indicador do tipo de estoque: 0 - Estoque de propriedade do informante e em seu poder; 1 - Estoque de propriedade do informante e em posse de terceiros; 2 - Estoque de propriedade de terceiros e em posse do informante
            /// </summary>
            private string F_IND_EST = "";
            public string IND_EST
            {
                get { return F_IND_EST; }
                set { F_IND_EST = value.ToUpper(); }
            }

            /// <summary>
            /// Código do participante (campo 02 do Registro 0150): proprietário/possuidor que não seja o informante do arquivo
            /// </summary>
            private string F_COD_PART = "";
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            public string GetRegistro_K200(bool Validate)
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
                    /* validacao para o tamanho do campo DT_EST */
                    if (F_DT_EST.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_EST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_EST */
                    if (F_DT_EST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_EST não informado(a)";
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
                    /* validacao para o tamanho do campo QTD */
                    if (F_QTD.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_EST */
                    if (F_IND_EST.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_EST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_EST */
                    if (F_IND_EST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_EST não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_EST */
                    if (!(F_IND_EST.Equals("0") || F_IND_EST.Equals("1") || F_IND_EST.Equals("2")))
                    {
                        return "Erro - O campo IND_EST possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_DT_EST, F_COD_ITEM, F_QTD, F_IND_EST, F_COD_PART);
            }
        }

        /// <summary>
        /// OUTRAS MOVIMENTAÇÕES INTERNAS ENTRE MERCADORIAS
        /// </summary>
        public class Registro_K220
        {
            /// <summary>
            /// Texto fixo contendo "K220"
            /// </summary>
            private string F_REG = "K220";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data da movimentação interna
            /// </summary>
            private string F_DT_MOV = "";
            public string DT_MOV
            {
                get { return F_DT_MOV; }
                set { F_DT_MOV = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item de origem (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM_ORI = "";
            public string COD_ITEM_ORI
            {
                get { return F_COD_ITEM_ORI; }
                set { F_COD_ITEM_ORI = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item de destino (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM_DEST = "";
            public string COD_ITEM_DEST
            {
                get { return F_COD_ITEM_DEST; }
                set { F_COD_ITEM_DEST = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade movimentada
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            public string GetRegistro_K220(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM_ORI */
                    if (F_COD_ITEM_ORI.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM_ORI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM_ORI */
                    if (F_COD_ITEM_ORI.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM_ORI não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM_DEST */
                    if (F_COD_ITEM_DEST.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM_DEST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM_DEST */
                    if (F_COD_ITEM_DEST.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM_DEST não informado(a)";
                    }
                    /* validacao para o tamanho do campo QTD */
                    if (F_QTD.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_DT_MOV, F_COD_ITEM_ORI, F_COD_ITEM_DEST, F_QTD);
            }
        }

        /// <summary>
        /// ITENS PRODUZIDOS
        /// </summary>
        public class Registro_K230
        {
            /// <summary>
            /// Texto fixo contendo "K230"
            /// </summary>
            private string F_REG = "K230";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data de início da ordem de produção
            /// </summary>
            private string F_DT_INI_OP = "";
            public string DT_INI_OP
            {
                get { return F_DT_INI_OP; }
                set { F_DT_INI_OP = value.ToUpper(); }
            }

            /// <summary>
            /// Data de conclusão da ordem de produção
            /// </summary>
            private string F_DT_FIN_OP = "";
            public string DT_FIN_OP
            {
                get { return F_DT_FIN_OP; }
                set { F_DT_FIN_OP = value.ToUpper(); }
            }

            /// <summary>
            /// Código de identificação da ordem de produção
            /// </summary>
            private string F_COD_DOC_OP = "";
            public string COD_DOC_OP
            {
                get { return F_COD_DOC_OP; }
                set { F_COD_DOC_OP = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item produzido (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade de produção acabada
            /// </summary>
            private string F_QTD_ENC = "";
            public string QTD_ENC
            {
                get { return F_QTD_ENC; }
                set { F_QTD_ENC = value.ToUpper(); }
            }

            public string GetRegistro_K230(bool Validate)
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
                    /* validacao para o tamanho do campo DT_INI_OP */
                    if (F_DT_INI_OP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI_OP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN_OP */
                    if (F_DT_FIN_OP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN_OP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_DOC_OP */
                    if (F_COD_DOC_OP.Length > 30)
                    {
                        return "Erro -> Tamanho do campo de COD_DOC_OP incorreto(a)";
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
                    /* validacao para o tamanho do campo QTD_ENC */
                    if (F_QTD_ENC.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD_ENC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_ENC */
                    if (F_QTD_ENC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_ENC não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_DT_INI_OP, F_DT_FIN_OP, F_COD_DOC_OP, F_COD_ITEM, F_QTD_ENC);
            }
        }

        /// <summary>
        /// INSUMOS CONSUMIDOS
        /// </summary>
        public class Registro_K235
        {
            /// <summary>
            /// Texto fixo contendo "K235"
            /// </summary>
            private string F_REG = "K235";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data de saída do estoque para alocação ao produto
            /// </summary>
            private string F_DT_SAÍDA = "";
            public string DT_SAÍDA
            {
                get { return F_DT_SAÍDA; }
                set { F_DT_SAÍDA = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item componente/insumo (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade consumida do item
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            /// <summary>
            /// Código do insumo que foi substituído, caso ocorra a substituição (campo 02 do Registro 0210)
            /// </summary>
            private string F_COD_INS_SUBST = "";
            public string COD_INS_SUBST
            {
                get { return F_COD_INS_SUBST; }
                set { F_COD_INS_SUBST = value.ToUpper(); }
            }

            public string GetRegistro_K235(bool Validate)
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
                    /* validacao para o tamanho do campo DT_SAÍDA */
                    if (F_DT_SAÍDA.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_SAÍDA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_SAÍDA */
                    if (F_DT_SAÍDA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_SAÍDA não informado(a)";
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
                    /* validacao para o tamanho do campo QTD */
                    if (F_QTD.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INS_SUBST */
                    if (F_COD_INS_SUBST.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_INS_SUBST incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_DT_SAÍDA, F_COD_ITEM, F_QTD, F_COD_INS_SUBST);
            }
        }

        /// <summary>
        /// INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS – ITENS PRODUZIDOS
        /// </summary>
        public class Registro_K250
        {
            /// <summary>
            /// Texto fixo contendo "K250"
            /// </summary>
            private string F_REG = "K250";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data do reconhecimento da produção ocorrida no terceiro
            /// </summary>
            private string F_DT_PROD = "";
            public string DT_PROD
            {
                get { return F_DT_PROD; }
                set { F_DT_PROD = value.ToUpper(); }
            }

            /// <summary>
            /// Código do item produzido (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade produzida
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            public string GetRegistro_K250(bool Validate)
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
                    /* validacao para o tamanho do campo DT_PROD */
                    if (F_DT_PROD.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_PROD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_PROD */
                    if (F_DT_PROD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_PROD não informado(a)";
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
                    /* validacao para o tamanho do campo QTD */
                    if (F_QTD.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_DT_PROD, F_COD_ITEM, F_QTD);
            }
        }

        /// <summary>
        /// INDUSTRIALIZAÇÃO EM TERCEIROS – INSUMOS CONSUMIDOS
        /// </summary>
        public class Registro_K255
        {
            /// <summary>
            /// Texto fixo contendo "K255"
            /// </summary>
            private string F_REG = "K255";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data do reconhecimento do consumo do insumo referente ao produto informado no campo 04 do Registro K250
            /// </summary>
            private string F_DT_CONS = "";
            public string DT_CONS
            {
                get { return F_DT_CONS; }
                set { F_DT_CONS = value.ToUpper(); }
            }

            /// <summary>
            /// Código do insumo (campo 02 do Registro 0200)
            /// </summary>
            private string F_COD_ITEM = "";
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade de consumo do insumo.
            /// </summary>
            private string F_QTD = "";
            public string QTD
            {
                get { return F_QTD; }
                set { F_QTD = value.ToUpper(); }
            }

            /// <summary>
            /// Código do insumo que foi substituído, caso ocorra a substituição (campo 02 do Registro 0210)
            /// </summary>
            private string F_COD_INS_SUBST = "";
            public string COD_INS_SUBST
            {
                get { return F_COD_INS_SUBST; }
                set { F_COD_INS_SUBST = value.ToUpper(); }
            }

            public string GetRegistro_K255(bool Validate)
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
                    /* validacao para o tamanho do campo DT_CONS */
                    if (F_DT_CONS.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_CONS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_CONS */
                    if (F_DT_CONS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_CONS não informado(a)";
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
                    /* validacao para o tamanho do campo QTD */
                    if (F_QTD.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD */
                    if (F_QTD.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INS_SUBST */
                    if (F_COD_INS_SUBST.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_INS_SUBST incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_DT_CONS, F_COD_ITEM, F_QTD, F_COD_INS_SUBST);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO K
        /// </summary>
        public class Registro_K990
        {
            /// <summary>
            /// Texto fixo contendo "K990"
            /// </summary>
            private string F_REG = "K990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco K
            /// </summary>
            private string F_QTD_LIN_H = "";
            public string QTD_LIN_H
            {
                get { return F_QTD_LIN_H; }
                set { F_QTD_LIN_H = value.ToUpper(); }
            }

            public string GetRegistro_K990(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo QTD_LIN_H */
                    if (F_QTD_LIN_H.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_H não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_H);
            }
        }
    }
}
