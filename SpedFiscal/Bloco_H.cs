using System;
namespace SpedFiscal
{
    public class Bloco_H
    {
        /// <summary>
        /// ABERTURA DO BLOCO H
        /// </summary>
        public class Registro_H001
        {
            /// <summary>
            /// Texto fixo contendo "H001"
            /// </summary>
            private string F_REG = "H001";
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

            public string GetRegistro_H001(bool Validate)
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
        /// TOTAIS DO INVENTÁRIO
        /// </summary>
        public class Registro_H005
        {
            /// <summary>
            /// Texto fixo contendo "H005"
            /// </summary>
            private string F_REG = "H005";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Data do inventário
            /// </summary>
            private string F_DT_INV = "";
            public string DT_INV
            {
                get { return F_DT_INV; }
                set { F_DT_INV = value.ToUpper(); }
            }

            /// <summary>
            /// Valor total do estoque
            /// </summary>
            private string F_VL_INV = "";
            public string VL_INV
            {
                get { return F_VL_INV; }
                set { F_VL_INV = value.ToUpper(); }
            }

            /// <summary>
            /// Informe o motivo do Inventário: 01 – No final no período; 02 – Na mudança de forma de tributação da mercadoria (ICMS); 03 – Na solicitação da baixa cadastral, paralisação temporária e outras situações; 04 – Na alteração de regime de pagamento – condição do contribuinte; 05 – Por determinação dos fiscos.
            /// </summary>
            private string F_MOT_INV = "";
            public string MOT_INV
            {
                get { return F_MOT_INV; }
                set { F_MOT_INV = value.ToUpper(); }
            }

            public string GetRegistro_H005(bool Validate)
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
                    /* validacao para o tamanho do campo DT_INV */
                    if (F_DT_INV.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INV */
                    if (F_DT_INV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INV não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_INV */
                    if (F_DT_INV.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_INV */
                    if (F_VL_INV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_INV não informado(a)";
                    }
                    /* validacao para o tamanho do campo MOT_INV */
                    if (F_MOT_INV.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de MOT_INV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo MOT_INV */
                    if (F_MOT_INV.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório MOT_INV não informado(a)";
                    }
                    /* Validacao dos dados passados a MOT_INV */
                    if (!(F_MOT_INV.Equals("01") || F_MOT_INV.Equals("02") || F_MOT_INV.Equals("03") || F_MOT_INV.Equals("04") || F_MOT_INV.Equals("TO") || F_MOT_INV.Equals("05")))
                    {
                        return "Erro - O campo MOT_INV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_DT_INV, F_VL_INV, F_MOT_INV);
            }
        }

        /// <summary>
        /// INVENTÁRIO.
        /// </summary>
        public class Registro_H010
        {
            /// <summary>
            /// Texto fixo contendo "H010"
            /// </summary>
            private string F_REG = "H010";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
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
            /// Unidade do item
            /// </summary>
            private string F_UNID = "";
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
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
            /// Valor unitário do item
            /// </summary>
            private string F_VL_UNIT = "";
            public string VL_UNIT
            {
                get { return F_VL_UNIT; }
                set { F_VL_UNIT = value.ToUpper(); }
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
            /// Indicador de propriedade/posse do item: 0- Item de propriedade do informante e em seu poder; 1- Item de propriedade do informante em posse de terceiros; 2- Item de propriedade de terceiros em posse do informante
            /// </summary>
            private string F_IND_PROP = "";
            public string IND_PROP
            {
                get { return F_IND_PROP; }
                set { F_IND_PROP = value.ToUpper(); }
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

            /// <summary>
            /// Descrição complementar.
            /// </summary>
            private string F_TXT_COMPL = "";
            public string TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value.ToUpper(); }
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
            /// Valor do item para efeitos do Imposto de Renda.
            /// </summary>
            private string F_VL_ITEM_IR = "";
            public string VL_ITEM_IR
            {
                get { return F_VL_ITEM_IR; }
                set { F_VL_ITEM_IR = value.ToUpper(); }
            }

            public string GetRegistro_H010(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo VL_UNIT */
                    if (F_VL_UNIT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_UNIT não informado(a)";
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
                    /* validacao para o tamanho do campo IND_PROP */
                    if (F_IND_PROP.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PROP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_PROP */
                    if (F_IND_PROP.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_PROP não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_PROP */
                    if (!(F_IND_PROP.Equals("0") || F_IND_PROP.Equals("1") || F_IND_PROP.Equals("2")))
                    {
                        return "Erro - O campo IND_PROP possui valores pré-definidos";
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
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_COD_ITEM, F_UNID, F_QTD, F_VL_UNIT, F_VL_ITEM, F_IND_PROP, F_COD_PART, F_TXT_COMPL, F_COD_CTA, F_VL_ITEM_IR);
            }
        }

        /// <summary>
        /// Informação complementar do Inventário.
        /// </summary>
        public class Registro_H020
        {
            /// <summary>
            /// Texto fixo contendo "H020"
            /// </summary>
            private string F_REG = "H020";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Código da Situação Tributária referente ao ICMS, conforme a Tabela indicada no item 4.3.1
            /// </summary>
            private string F_CST_ICMS = "";
            public string CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Informe a base de cálculo do ICMS
            /// </summary>
            private string F_BC_ICMS = "";
            public string BC_ICMS
            {
                get { return F_BC_ICMS; }
                set { F_BC_ICMS = value.ToUpper(); }
            }

            /// <summary>
            /// Informe o valor do ICMS a ser debitado ou creditado
            /// </summary>
            private string F_VL_ICMS = "";
            public string VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_H020(bool Validate)
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
                    /* validacao para o tamanho do campo CST_ICMS */
                    if (F_CST_ICMS.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de CST_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo BC_ICMS */
                    if (F_BC_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório BC_ICMS não informado(a)";
                    }
                    /* validacao para o tamanho do campo VL_ICMS */
                    if (F_VL_ICMS.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de VL_ICMS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo VL_ICMS */
                    if (F_VL_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório VL_ICMS não informado(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_CST_ICMS, F_BC_ICMS, F_VL_ICMS);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO H.
        /// </summary>
        public class Registro_H990
        {
            /// <summary>
            /// Texto fixo contendo "H990"
            /// </summary>
            private string F_REG = "H990";
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            /// <summary>
            /// Quantidade total de linhas do Bloco H
            /// </summary>
            private string F_QTD_LIN_H = "";
            public string QTD_LIN_H
            {
                get { return F_QTD_LIN_H; }
                set { F_QTD_LIN_H = value.ToUpper(); }
            }

            public string GetRegistro_H990(bool Validate)
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
