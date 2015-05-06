using System;

namespace SpedFiscal
{
    public class Bloco_0
    {

        /// <summary>
        /// ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO DA ENTIDADE
        /// </summary>
        public class Registro_0000
        {
            private string F_REG = "0000";

            private string F_COD_VER = "";
            /// <summary>
            /// Código da versão do leiaute conforme a tabela indicada no Ato COTEPE.
            /// </summary>
            public string COD_VER
            {
                get { return F_COD_VER; }
                set { F_COD_VER = value.ToUpper(); }
            }

            private string F_COD_FIN = "";
            /// <summary>
            /// Código da finalidade do arquivo: 0 - Remessa do arquivo original; 1 - Remessa do arquivo substituto.
            /// </summary>
            public string COD_FIN
            {
                get { return F_COD_FIN; }
                set { F_COD_FIN = value.ToUpper(); }
            }

            private string F_DT_INI = "";
            /// <summary>
            /// Data inicial das informações contidas no arquivo.
            /// </summary>
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            private string F_DT_FIN = "";
            /// <summary>
            /// Data final das informações contidas no arquivo.
            /// </summary>
            public string DT_FIN
            {
                get { return F_DT_FIN; }
                set { F_DT_FIN = value.ToUpper(); }
            }

            private string F_NOME = "";
            /// <summary>
            /// Nome empresarial da entidade.
            /// </summary>
            public string NOME
            {
                get { return F_NOME; }
                set { F_NOME = value.ToUpper(); }
            }

            private string F_CNPJ = "";
            /// <summary>
            /// Número de inscrição da entidade no CNPJ.
            /// </summary>
            public string CNPJ
            {
                get { return F_CNPJ; }
                set { F_CNPJ = value.ToUpper(); }
            }

            private string F_CPF = "";
            /// <summary>
            /// Número de inscrição da entidade no CPF.
            /// </summary>
            public string CPF
            {
                get { return F_CPF; }
                set { F_CPF = value.ToUpper(); }
            }

            private string F_UF = "";
            /// <summary>
            /// Sigla da unidade da federação da entidade.
            /// </summary>
            public string UF
            {
                get { return F_UF; }
                set { F_UF = value.ToUpper(); }
            }

            private string F_IE = "";
            /// <summary>
            /// Inscrição Estadual da entidade.
            /// </summary>
            public string IE
            {
                get { return F_IE; }
                set { F_IE = value.ToUpper(); }
            }

            private string F_COD_MUN = "";
            /// <summary>
            /// Código do município do domicílio fiscal da entidade, conforme a tabela IBGE
            /// </summary>
            public string COD_MUN
            {
                get { return F_COD_MUN; }
                set { F_COD_MUN = value.ToUpper(); }
            }

            private string F_IM = "";
            /// <summary>
            /// Inscrição Municipal da entidade.
            /// </summary>
            public string IM
            {
                get { return F_IM; }
                set { F_IM = value.ToUpper(); }
            }

            private string F_SUFRAMA = "";
            /// <summary>
            /// Inscrição da entidade na SUFRAMA
            /// </summary>
            public string SUFRAMA
            {
                get { return F_SUFRAMA; }
                set { F_SUFRAMA = value.ToUpper(); }
            }

            private string F_IND_PERFIL = "";
            /// <summary>
            /// Perfil de apresentação do arquivo fiscal; A – Perfil A; B – Perfil B.; c – Perfil C.
            /// </summary>
            public string IND_PERFIL
            {
                get { return F_IND_PERFIL; }
                set { F_IND_PERFIL = value.ToUpper(); }
            }

            private string F_IND_ATIV = "";
            /// <summary>
            /// Indicador de tipo de atividade: 0 – Industrial ou equiparado a industrial; 1 – Outros.
            /// </summary>
            public string IND_ATIV
            {
                get { return F_IND_ATIV; }
                set { F_IND_ATIV = value.ToUpper(); }
            }

            public string GetRegistro_0000(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_VER */
                    if (F_COD_VER.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_VER incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_VER */
                    if (F_COD_VER.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_VER não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_FIN */
                    if (F_COD_FIN.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de COD_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_FIN */
                    if (F_COD_FIN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_FIN não informado(a)";
                    }
                    /* Validacao para os dados informados a COD_FIN */
                    if (!(F_COD_FIN.Equals("0") || F_COD_FIN.Equals("1")))
                    {
                        return "Erro -> O campo COD_FIN possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (F_DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (F_DT_INI.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (F_DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIN */
                    if (F_DT_FIN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME */
                    if (F_NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (F_NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (F_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (F_CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (F_UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF */
                    if (F_UF.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo IE */
                    if (F_IE.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IE */
                    if (F_IE.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IE não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN */
                    if (F_COD_MUN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUFRAMA */
                    if (F_SUFRAMA.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de SUFRAMA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PERFIL */
                    if (F_IND_PERFIL.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PERFIL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_PERFIL */
                    if (F_IND_PERFIL.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_PERFIL não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_PERFIL */
                    if (!(F_IND_PERFIL.Equals("A") || F_IND_PERFIL.Equals("B") || F_IND_PERFIL.Equals("C")))
                    {
                        return "Erro -> O campo IND_PERFIL possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_ATIV */
                    if (F_IND_ATIV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_ATIV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_ATIV */
                    if (F_IND_ATIV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_ATIV não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_ATIV */
                    if (!(F_IND_ATIV.Equals("0") || F_IND_ATIV.Equals("1")))
                    {
                        return "Erro -> O campo IND_ATIV possui valores pré-definidos";
                    }
                    /* validacoes manuais */

                    /* validacao da data de fim no mesmo mes/ano da data inicio */
                    DateTime dataInicio;
                    DateTime dataFim;
                    try
                    {
                        dataInicio = DateTime.ParseExact(DT_INI, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        return "Erro -> Data inválida no campo DT_INI";
                    }
                    try
                    {
                        dataFim = DateTime.ParseExact(DT_FIN, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        return "Erro -> Data inválida no campo DT_FIM";
                    }
                    if ((dataInicio.Month != dataFim.Month) || (dataInicio.Year != dataFim.Year))
                    {
                        return "Erro -> Mês e Ano não conferem para Data_Final";
                    }
                    /* validar CPF / CNPJ */
                    if (!F_CNPJ.Trim().Trim().Equals(""))
                        if (!Utils.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    if (!F_CPF.Trim().Trim().Equals(""))
                        if (!Utils.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", F_REG, F_COD_VER, F_COD_FIN, F_DT_INI, F_DT_FIN, F_NOME, F_CNPJ, F_CPF, F_UF, F_IE, F_COD_MUN, F_IM, F_SUFRAMA, F_IND_PERFIL, F_IND_ATIV);
            }
        }

        /// <summary>
        /// ABERTURA DO BLOCO 0
        /// </summary>
        public class Registro_0001
        {
            private string F_REG = "0001";

            private string F_IND_MOV = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            public string IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            public string GetRegistro_0001(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (F_IND_MOV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV */
                    if (F_IND_MOV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(F_IND_MOV.Equals("0")))
                    {
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_IND_MOV);
            }
        }

        /// <summary>
        /// DADOS COMPLEMENTARES DA ENTIDADE
        /// </summary>
        public class Registro_0005
        {
            private string F_REG = "0005";
            /// <summary>
            /// Texto fixo contendo “0005”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_FANTASIA = "";
            /// <summary>
            /// Nome de fantasia associado ao nome empresarial.
            /// </summary>
            public string FANTASIA
            {
                get { return F_FANTASIA; }
                set { F_FANTASIA = value.ToUpper(); }
            }

            private string F_CEP = "";
            /// <summary>
            /// Código de Endereçamento Postal.
            /// </summary>
            public string CEP
            {
                get { return F_CEP; }
                set { F_CEP = value.ToUpper(); }
            }

            private string F_END = "";
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            public string END
            {
                get { return F_END; }
                set { F_END = value.ToUpper(); }
            }

            private string F_NUM = "";
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            public string NUM
            {
                get { return F_NUM; }
                set { F_NUM = value.ToUpper(); }
            }

            private string F_COMPL = "";
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string COMPL
            {
                get { return F_COMPL; }
                set { F_COMPL = value.ToUpper(); }
            }

            private string F_BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string BAIRRO
            {
                get { return F_BAIRRO; }
                set { F_BAIRRO = value.ToUpper(); }
            }

            private string F_FONE = "";
            /// <summary>
            /// Número do telefone (DDD+FONE).
            /// </summary>
            public string FONE
            {
                get { return F_FONE; }
                set { F_FONE = value.ToUpper(); }
            }

            private string F_FAX = "";
            /// <summary>
            /// Número do fax.
            /// </summary>
            public string FAX
            {
                get { return F_FAX; }
                set { F_FAX = value.ToUpper(); }
            }

            private string F_EMAIL = "";
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            public string EMAIL
            {
                get { return F_EMAIL; }
                set { F_EMAIL = value.ToUpper(); }
            }

            public string GetRegistro_0005(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo FANTASIA */
                    if (F_FANTASIA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de FANTASIA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo FANTASIA */
                    if (F_FANTASIA.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório FANTASIA não informado(a)";
                    }
                    /* validacao para o tamanho do campo CEP */
                    if (F_CEP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de CEP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CEP */
                    if (F_CEP.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CEP não informado(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (F_END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo END */
                    if (F_END.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório END não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (F_NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (F_COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (F_BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo BAIRRO */
                    if (F_BAIRRO.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório BAIRRO não informado(a)";
                    }
                    /* validacao para o tamanho do campo FONE */
                    if (F_FONE.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FONE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_FANTASIA, F_CEP, F_END, F_NUM, F_COMPL, F_BAIRRO, F_FONE, F_FAX, F_EMAIL);
            }
        }

        /// <summary>
        /// DADOS DO CONTRIBUINTE SUBSTITUTO
        /// </summary>
        public class Registro_0015
        {
            private string F_REG = "0015";

            private string F_UF_ST = "";
            /// <summary>
            /// Sigla da unidade da federação do contribuinte substituído.
            /// </summary>
            public string UF_ST
            {
                get { return F_UF_ST; }
                set { F_UF_ST = value.ToUpper(); }
            }

            private string F_IE_ST = "";
            /// <summary>
            /// Inscrição Estadual do contribuinte substituto na unidade da federação do contribuinte substituído.
            /// </summary>
            public string IE_ST
            {
                get { return F_IE_ST; }
                set { F_IE_ST = value.ToUpper(); }
            }

            public string GetRegistro_0015(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo UF_ST */
                    if (F_UF_ST.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF_ST */
                    if (F_UF_ST.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF_ST não informado(a)";
                    }
                    /* validacao para o tamanho do campo IE_ST */
                    if (F_IE_ST.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE_ST incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IE_ST */
                    if (F_IE_ST.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IE_ST não informado(a)";
                    }
                    /* validacoes manuais */
                    F_UF_ST = Utils.ValidaUF(F_UF_ST);
                    F_IE_ST = Utils.ValidaInscricaoEstadual(F_IE_ST, F_UF_ST);
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_UF_ST, F_IE_ST);
            }
        }

        /// <summary>
        /// DADOS DO CONTABILISTA
        /// </summary>
        public class Registro_0100
        {
            private string F_REG = "0100";

            private string F_NOME = "";
            /// <summary>
            /// Nome do contabilista.
            /// </summary>
            public string NOME
            {
                get { return F_NOME; }
                set { F_NOME = value.ToUpper(); }
            }

            private string F_CPF = "";
            /// <summary>
            /// Número de inscrição do contabilista no CPF.
            /// </summary>
            public string CPF
            {
                get { return F_CPF; }
                set { F_CPF = value.ToUpper(); }
            }

            private string F_CRC = "";
            /// <summary>
            /// Número de inscrição do contabilista no Conselho Regional de Contabilidade.
            /// </summary>
            public string CRC
            {
                get { return F_CRC; }
                set { F_CRC = value.ToUpper(); }
            }

            private string F_CNPJ = "";
            /// <summary>
            /// Número de inscrição do escritório de contabilidade no CNPJ, se houver.
            /// </summary>
            public string CNPJ
            {
                get { return F_CNPJ; }
                set { F_CNPJ = value.ToUpper(); }
            }

            private string F_CEP = "";
            /// <summary>
            /// Código de Endereçamento Postal.
            /// </summary>
            public string CEP
            {
                get { return F_CEP; }
                set { F_CEP = value.ToUpper(); }
            }

            private string F_END = "";
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            public string END
            {
                get { return F_END; }
                set { F_END = value.ToUpper(); }
            }

            private string F_NUM = "";
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            public string NUM
            {
                get { return F_NUM; }
                set { F_NUM = value.ToUpper(); }
            }

            private string F_COMPL = "";
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string COMPL
            {
                get { return F_COMPL; }
                set { F_COMPL = value.ToUpper(); }
            }

            private string F_BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string BAIRRO
            {
                get { return F_BAIRRO; }
                set { F_BAIRRO = value.ToUpper(); }
            }

            private string F_FONE = "";
            /// <summary>
            /// Número do telefone (DDD+FONE).
            /// </summary>
            public string FONE
            {
                get { return F_FONE; }
                set { F_FONE = value.ToUpper(); }
            }

            private string F_FAX = "";
            /// <summary>
            /// Número do fax.
            /// </summary>
            public string FAX
            {
                get { return F_FAX; }
                set { F_FAX = value.ToUpper(); }
            }

            private string F_EMAIL = "";
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            public string EMAIL
            {
                get { return F_EMAIL; }
                set { F_EMAIL = value.ToUpper(); }
            }

            private string F_COD_MUN = "";
            /// <summary>
            /// Código do município, conforme tabela IBGE.
            /// </summary>
            public string COD_MUN
            {
                get { return F_COD_MUN; }
                set { F_COD_MUN = value.ToUpper(); }
            }

            public string GetRegistro_0100(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME */
                    if (F_NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (F_NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (F_CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CPF */
                    if (F_CPF.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CPF não informado(a)";
                    }
                    /* validacao para o tamanho do campo CRC */
                    if (F_CRC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de CRC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CRC */
                    if (F_CRC.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CRC não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (F_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CEP */
                    if (F_CEP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de CEP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (F_END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (F_NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (F_COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (F_BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FONE */
                    if (F_FONE.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FONE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo EMAIL */
                    if (F_EMAIL.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório EMAIL não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacoes manuais */
                    /* validar CPF / CNPJ */
                    if (!F_CNPJ.Trim().Trim().Equals(""))
                        if (!Utils.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    if (!F_CPF.Trim().Trim().Equals(""))
                        if (!Utils.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_NOME, F_CPF, F_CRC, F_CNPJ, F_CEP, F_END, F_NUM, F_COMPL, F_BAIRRO, F_FONE, F_FAX, F_EMAIL, F_COD_MUN);
            }
        }

        /// <summary>
        /// TABELA DE CADASTRO DO PARTICIPANTE
        /// </summary>
        public class Registro_0150
        {
            private string F_REG = "0150";
            /// <summary>
            /// Texto fixo contendo “0150”.
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_PART = "";
            /// <summary>
            /// Código de identificação do participante no arquivo.
            /// </summary>
            public string COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value.ToUpper(); }
            }

            private string F_NOME = "";
            /// <summary>
            /// Nome pessoal ou empresarial do participante.
            /// </summary>
            public string NOME
            {
                get { return F_NOME; }
                set { F_NOME = value.ToUpper(); }
            }

            private string F_COD_PAIS = "";
            /// <summary>
            /// Código do país do participante, conforme a tabela indicada no item 3.2.1
            /// </summary>
            public string COD_PAIS
            {
                get { return F_COD_PAIS; }
                set { F_COD_PAIS = value.ToUpper(); }
            }

            private string F_CNPJ = "";
            /// <summary>
            /// CNPJ do participante.
            /// </summary>
            public string CNPJ
            {
                get { return F_CNPJ; }
                set { F_CNPJ = value.ToUpper(); }
            }

            private string F_CPF = "";
            /// <summary>
            /// CPF do participante.
            /// </summary>
            public string CPF
            {
                get { return F_CPF; }
                set { F_CPF = value.ToUpper(); }
            }

            private string F_IE = "";
            /// <summary>
            /// Inscrição Estadual do participante.
            /// </summary>
            public string IE
            {
                get { return F_IE; }
                set { F_IE = value.ToUpper(); }
            }

            private string F_COD_MUN = "";
            /// <summary>
            /// Código do município, conforme a tabela IBGE
            /// </summary>
            public string COD_MUN
            {
                get { return F_COD_MUN; }
                set { F_COD_MUN = value.ToUpper(); }
            }

            private string F_SUFRAMA = "";
            /// <summary>
            /// Número de inscrição do participante na SUFRAMA.
            /// </summary>
            public string SUFRAMA
            {
                get { return F_SUFRAMA; }
                set { F_SUFRAMA = value.ToUpper(); }
            }

            private string F_END = "";
            /// <summary>
            /// Logradouro e endereço do imóvel
            /// </summary>
            public string END
            {
                get { return F_END; }
                set { F_END = value.ToUpper(); }
            }

            private string F_NUM = "";
            /// <summary>
            /// Número do imóvel
            /// </summary>
            public string NUM
            {
                get { return F_NUM; }
                set { F_NUM = value.ToUpper(); }
            }

            private string F_COMPL = "";
            /// <summary>
            /// Dados complementares do endereço
            /// </summary>
            public string COMPL
            {
                get { return F_COMPL; }
                set { F_COMPL = value.ToUpper(); }
            }

            private string F_BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado
            /// </summary>
            public string BAIRRO
            {
                get { return F_BAIRRO; }
                set { F_BAIRRO = value.ToUpper(); }
            }

            public string GetRegistro_0150(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PART */
                    if (F_COD_PART.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PART incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_PART */
                    if (F_COD_PART.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_PART não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME */
                    if (F_NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (F_NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PAIS */
                    if (F_COD_PAIS.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de COD_PAIS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_PAIS */
                    if (F_COD_PAIS.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_PAIS não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (F_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (F_CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IE */
                    if (F_IE.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUFRAMA */
                    if (F_SUFRAMA.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de SUFRAMA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (F_END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo END */
                    if (F_END.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório END não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (F_NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (F_COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (F_BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacoes manuais */

                    /* validar codigo do pais */
                    F_COD_PAIS = Utils.ConsultaPais(TpConsulta.PorCodigo, F_COD_PAIS);
                    /* validar CNPJ */
                    if (!F_CNPJ.Trim().Trim().Equals("") || F_COD_PAIS.Equals("01058"))
                        if (!Utils.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    /* validar CPF */
                    if (!F_CPF.Trim().Trim().Equals("") || F_COD_PAIS.Equals("01058"))
                        if (!Utils.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                    /* validar inscricao estadual */
                    F_IE = Utils.ValidaInscricaoEstadual(F_IE,Utils.ConsultaMunicipio(TpConsulta.PorCodigoTrazendoUF,F_COD_MUN,""));

                    /*
                    Campo 02 - Preenchimento: informar o código de identificação do participante no arquivo.
                    Esta tabela pode conter COD_PART e respectivo registro 0150 com dados do próprio contribuinte informante, quando
                    apresentar documentos emitidos contra si próprio, em situações específicas (Exemplo: emissão de Nota Fiscal em operação
                    de retorno de produtos saídos para venda ambulante ou a negociar fora do estabelecimento).
                    Validação: o valor informado no campo COD_PART deve existir em pelo menos um registro dos demais blocos.
                    O código de participante, campo COD_PART, é de livre atribuição do estabelecimento, observado o disposto no item
                    2.4.2.1. do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.

                    Campo 08 - Validação: o valor informado no campo deve existir na Tabela de Municípios do IBGE (combinação do
                    código da UF e o código de município), possuindo 7 dígitos.
                    Obrigatório se campo COD_PAIS for igual a “01058” ou “1058”(Brasil). Se for exterior, informar campo “vazio” ou
                    preencher com o código “9999999”.                     
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", F_REG, F_COD_PART, F_NOME, F_COD_PAIS, F_CNPJ, F_CPF, F_IE, F_COD_MUN, F_SUFRAMA, F_END, F_NUM, F_COMPL, F_BAIRRO);
            }
        }

        /// <summary>
        /// ALTERAÇÃO DA TABELA DE CADASTRO DE PARTICIPANTE
        /// </summary>
        public class Registro_0175
        {
            private string F_REG = "0175";
            /// <summary>
            /// Texto fixo contendo “0175”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_DT_ALT = "";
            /// <summary>
            /// Data de alteração do cadastro
            /// </summary>
            public string DT_ALT
            {
                get { return F_DT_ALT; }
                set { F_DT_ALT = value.ToUpper(); }
            }

            private string F_NR_CAMPO = "";
            /// <summary>
            /// Número do campo alterado (campos 03 a 13, exceto 07)
            /// </summary>
            public string NR_CAMPO
            {
                get { return F_NR_CAMPO; }
                set { F_NR_CAMPO = value.ToUpper(); }
            }

            private string F_CONT_ANT = "";
            /// <summary>
            /// Conteúdo anterior do campo
            /// </summary>
            public string CONT_ANT
            {
                get { return F_CONT_ANT; }
                set { F_CONT_ANT = value.ToUpper(); }
            }

            public string GetRegistro_0175(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_ALT */
                    if (F_DT_ALT.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ALT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ALT */
                    if (F_DT_ALT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ALT não informado(a)";
                    }
                    /* validacao para o tamanho do campo NR_CAMPO */
                    if (F_NR_CAMPO.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de NR_CAMPO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NR_CAMPO */
                    if (F_NR_CAMPO.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NR_CAMPO não informado(a)";
                    }
                    /* validacao para o tamanho do campo CONT_ANT */
                    if (F_CONT_ANT.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de CONT_ANT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CONT_ANT */
                    if (F_CONT_ANT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CONT_ANT não informado(a)";
                    }
                    /*
                    Campo 03 - Preenchimento: informar o número do campo alterado, relativo ao registro 0150.
                    Validação: Valores Válidos: [03, 04, 05, 06, 08, 09, 10, 11, 12, 13]

                    Campo 04 - Preenchimento: os dados informados neste registro são válidos até às 24:00 horas do dia anterior à data de
                    alteração.
                    Validação: quando se tratar de alterações nos campos CNPJ ou CPF, referidos campos serão validados conforme as regras
                    de verificação de dígitos verificadores. Se COD_Mun será verificada sua existência na tabela IBGE.
                     */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_DT_ALT, F_NR_CAMPO, F_CONT_ANT);
            }
        }

        /// <summary>
        /// IDENTIFICAÇÃO DAS UNIDADES DE MEDIDA
        /// </summary>
        public class Registro_0190
        {
            private string F_REG = "0190";
            /// <summary>
            /// Texto fixo contendo "0190"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_UNID = "";
            /// <summary>
            /// Código da unidade de medida
            /// </summary>
            public string UNID
            {
                get { return F_UNID; }
                set { F_UNID = value.ToUpper(); }
            }

            private string F_DESCR = "";
            /// <summary>
            /// Descrição da unidade de medida
            /// </summary>
            public string DESCR
            {
                get { return F_DESCR; }
                set { F_DESCR = value.ToUpper(); }
            }

            public string GetRegistro_0190(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (F_UNID.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (F_UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR */
                    if (F_DESCR.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR não informado(a)";
                    }
                    /* validacoes manuais */
                    if (F_UNID.Equals(F_DESCR))
                    {
                        return "Erro -> Campo UNID e DESCR não podem ser iguais";
                    }
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_UNID, F_DESCR);
            }
        }

        /// <summary>
        /// TABELA DE IDENTIFICAÇÃO DO ITEM (PRODUTO E SERVIÇOS)
        /// </summary>
        public class Registro_0200
        {
            private string F_REG = "0200";
            /// <summary>
            /// Texto fixo contendo "0200"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do item
            /// </summary>
            public string COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value.ToUpper(); }
            }

            private string F_DESCR_ITEM = "";
            /// <summary>
            /// Descrição do item
            /// </summary>
            public string DESCR_ITEM
            {
                get { return F_DESCR_ITEM; }
                set { F_DESCR_ITEM = value.ToUpper(); }
            }

            private string F_COD_BARRA = "";
            /// <summary>
            /// Representação alfanumérico do código de barra do produto, se houver
            /// </summary>
            public string COD_BARRA
            {
                get { return F_COD_BARRA; }
                set { F_COD_BARRA = value.ToUpper(); }
            }

            private string F_COD_ANT_ITEM = "";
            /// <summary>
            /// Código anterior do item com relação à última informação apresentada.
            /// </summary>
            public string COD_ANT_ITEM
            {
                get { return F_COD_ANT_ITEM; }
                set { F_COD_ANT_ITEM = value.ToUpper(); }
            }

            private string F_UNID_INV = "";
            /// <summary>
            /// Unidade de medida utilizada na quantificação de estoques.
            /// </summary>
            public string UNID_INV
            {
                get { return F_UNID_INV; }
                set { F_UNID_INV = value.ToUpper(); }
            }

            private string F_TIPO_ITEM = "";
            /// <summary>
            /// Tipo do item / Atividades Industriais, Comerciais e Serviços: 00 – Mercadoria para Revenda; 01 – Matéria-Prima; 02 – Embalagem; 03 – Produto em Processo; 04 – Produto Acabado; 05 – Subproduto; 06 – Produto Intermediário; 07 – Material de Uso e Consumo; 08 – Ativo Imobilizado; 09 – Serviços; 10 – Outros insumos; 99 – Outras
            /// </summary>
            public string TIPO_ITEM
            {
                get { return F_TIPO_ITEM; }
                set { F_TIPO_ITEM = value.ToUpper(); }
            }

            private string F_COD_NCM = "";
            /// <summary>
            /// Código da Nomenclatura Comum do Mercosul
            /// </summary>
            public string COD_NCM
            {
                get { return F_COD_NCM; }
                set { F_COD_NCM = value.ToUpper(); }
            }

            private string F_EX_IPI = "";
            /// <summary>
            /// Código EX, conforme a TIPI
            /// </summary>
            public string EX_IPI
            {
                get { return F_EX_IPI; }
                set { F_EX_IPI = value.ToUpper(); }
            }

            private string F_COD_GEN = "";
            /// <summary>
            /// Código do gênero do item, conforme a Tabela 4.2.1
            /// </summary>
            public string COD_GEN
            {
                get { return F_COD_GEN; }
                set { F_COD_GEN = value.ToUpper(); }
            }

            private string F_COD_LST = "";
            /// <summary>
            /// Código do serviço conforme lista do Anexo I da Lei Complementar Federal nº 116/03.
            /// </summary>
            public string COD_LST
            {
                get { return F_COD_LST; }
                set { F_COD_LST = value.ToUpper(); }
            }

            private string F_ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota de ICMS aplicável ao item nas operações internas
            /// </summary>
            public string ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value.ToUpper(); }
            }

            public string GetRegistro_0200(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM */
                    if (F_COD_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_ITEM */
                    if (F_DESCR_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (F_COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ANT_ITEM */
                    if (F_COD_ANT_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ANT_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID_INV */
                    if (F_UNID_INV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_INV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID_INV */
                    if (F_UNID_INV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID_INV não informado(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_ITEM */
                    if (F_TIPO_ITEM.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TIPO_ITEM */
                    if (F_TIPO_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TIPO_ITEM não informado(a)";
                    }
                    /* Validacao dos dados passados a TIPO_ITEM */
                    if (!(F_TIPO_ITEM.Equals("00") || F_TIPO_ITEM.Equals("01") || F_TIPO_ITEM.Equals("02") || F_TIPO_ITEM.Equals("03") || F_TIPO_ITEM.Equals("04") || F_TIPO_ITEM.Equals("05") || F_TIPO_ITEM.Equals("06") || F_TIPO_ITEM.Equals("07") || F_TIPO_ITEM.Equals("08") || F_TIPO_ITEM.Equals("09") || F_TIPO_ITEM.Equals("10") || F_TIPO_ITEM.Equals("99")))
                    {
                        return "Erro -> O campo TIPO_ITEM possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_NCM */
                    if (F_COD_NCM.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_NCM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo EX_IPI */
                    if (F_EX_IPI.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de EX_IPI incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_GEN */
                    if (F_COD_GEN.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_GEN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_LST */
                    if (F_COD_LST.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de COD_LST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (F_ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    /* validacoes manuais */


                    /*
                    Validação: o valor informado neste campo deve existir em pelo menos um registro dos demais blocos ou no registro 0220.
                     * 
                    Campo 06 - Validação: existindo informação neste campo, esta deve existir no registro 0190, campo UNID, respectivo.
                     * 
                    Campo 10 - Preenchimento: obrigatório para todos os contribuintes na aquisição de produtos primários. A Tabela
                    "Gênero do Item de Mercadoria/Serviço", referenciada no Item 4.2.1 do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008,
                    corresponde à tabela de "Capítulos da NCM", acrescida do código "00 - Serviço".
                    Validação: o valor informado no campo deve existir na Tabela “Gênero do Item de Mercadoria/Serviço”, item 4.2.1 do
                    Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.
                     * 
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, F_COD_ITEM, F_DESCR_ITEM, F_COD_BARRA, F_COD_ANT_ITEM, F_UNID_INV, F_TIPO_ITEM, F_COD_NCM, F_EX_IPI, F_COD_GEN, F_COD_LST, F_ALIQ_ICMS);
            }
        }

        /// <summary>
        /// ALTERAÇÃO DO ITEM
        /// </summary>
        public class Registro_0205
        {
            private string F_REG = "0205";
            /// <summary>
            /// Texto fixo contendo "0205"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_DESCR_ANT_ITEM = "";
            /// <summary>
            /// Descrição anterior do item
            /// </summary>
            public string DESCR_ANT_ITEM
            {
                get { return F_DESCR_ANT_ITEM; }
                set { F_DESCR_ANT_ITEM = value.ToUpper(); }
            }

            private string F_DT_INI = "";
            /// <summary>
            /// Data inicial de utilização da descrição do item
            /// </summary>
            public string DT_INI
            {
                get { return F_DT_INI; }
                set { F_DT_INI = value.ToUpper(); }
            }

            private string F_DT_FIM = "";
            /// <summary>
            /// Data final de utilização da descrição do item
            /// </summary>
            public string DT_FIM
            {
                get { return F_DT_FIM; }
                set { F_DT_FIM = value.ToUpper(); }
            }

            private string F_COD_ANT_ITEM = "";
            /// <summary>
            /// Código anterior do item com relação à última informação apresentada.
            /// </summary>
            public string COD_ANT_ITEM
            {
                get { return F_COD_ANT_ITEM; }
                set { F_COD_ANT_ITEM = value.ToUpper(); }
            }

            public string GetRegistro_0205(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_ANT_ITEM */
                    if (F_DESCR_ANT_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_ANT_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (F_DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (F_DT_INI.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIM */
                    if (F_DT_FIM.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIM */
                    if (F_DT_FIM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ANT_ITEM */
                    if (F_COD_ANT_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ANT_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ANT_ITEM */
                    if (F_COD_ANT_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ANT_ITEM não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 04 - Preenchimento: informar o período final de utilização da descrição anterior do item.
                    Validação: o valor informado no campo deve ser uma data válida, obedecido o formato “ddmmaaaa”. O valor informado
                    no campo deve ser menor que o valor no campo DT_FIN do registro 0000.
                     * 
                     */

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_DESCR_ANT_ITEM, F_DT_INI, F_DT_FIM, F_COD_ANT_ITEM);
            }
        }

        /// <summary>
        /// CÓDIGO DE PRODUTO CONFORME TABELA PUBLICADA PELA ANP (COMBUSTÍVEIS)
        /// </summary>
        public class Registro_0206
        {
            private string F_REG = "0206";
            /// <summary>
            /// Texto fixo contendo "0206"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_COMB = "";
            /// <summary>
            /// Código do combustível, conforme tabela publicada pela ANP
            /// </summary>
            public string COD_COMB
            {
                get { return F_COD_COMB; }
                set { F_COD_COMB = value.ToUpper(); }
            }

            public string GetRegistro_0206(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_COMB */
                    if (F_COD_COMB.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_COMB não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 02 - Preenchimento: utilizar o código do combustível, conforme Tabela de Produtos para Combustíveis / Solvente
                    (Tabela 12 de códigos de produtos para o Sistema de Informações de Movimentação de Produtos (SIMP), conforme item
                    3.2.1 do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.
                    Validação: o valor informado no campo deve existir na tabela da ANP.
                     * 
                    */
                }
                return String.Format("|{0}|{1}|", F_REG, F_COD_COMB);
            }
        }

        /// <summary>
        /// CONSUMO ESPECÍFICO PADRONIZADO
        /// </summary>
        public class Registro_0210
        {
            private string F_REG = "0210";
            /// <summary>
            /// Texto fixo contendo "0210"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_ITEM_COMP = "";
            /// <summary>
            /// Código do item componente/insumo (campo 02 do Registro 0200)
            /// </summary>
            public string COD_ITEM_COMP
            {
                get { return F_COD_ITEM_COMP; }
                set { F_COD_ITEM_COMP = value.ToUpper(); }
            }

            private string F_QTD_COMP = "";
            /// <summary>
            /// Quantidade do item componente/insumo para se produzir uma unidade do item composto/resultante
            /// </summary>
            public string QTD_COMP
            {
                get { return F_QTD_COMP; }
                set { F_QTD_COMP = value.ToUpper(); }
            }

            private string F_PERDA = "";
            /// <summary>
            /// Perda/quebra normal percentual do insumo/componente para se produzir uma unidade do item composto/resultante
            /// </summary>
            public string PERDA
            {
                get { return F_PERDA; }
                set { F_PERDA = value.ToUpper(); }
            }

            public string GetRegistro_0210(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM_COMP */
                    if (F_COD_ITEM_COMP.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM_COMP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM_COMP */
                    if (F_COD_ITEM_COMP.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM_COMP não informado(a)";
                    }
                    /* validacao para o tamanho do campo QTD_COMP */
                    if (F_QTD_COMP.Length > 17)
                    {
                        return "Erro -> Tamanho do campo de QTD_COMP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_COMP */
                    if (F_QTD_COMP.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_COMP não informado(a)";
                    }
                    /* validacao para o tamanho do campo PERDA */
                    if (F_PERDA.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de PERDA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo PERDA */
                    if (F_PERDA.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório PERDA não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_ITEM_COMP, F_QTD_COMP, F_PERDA);
            }
        }

        /// <summary>
        /// FATORES DE CONVERSÃO DE UNIDADES
        /// </summary>
        public class Registro_0220
        {
            private string F_REG = "0220";
            /// <summary>
            /// Texto fixo contendo "0220"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_UNID_CONV = "";
            /// <summary>
            /// Unidade comercial a ser convertida na unidade de estoque, referida no registro 0200.
            /// </summary>
            public string UNID_CONV
            {
                get { return F_UNID_CONV; }
                set { F_UNID_CONV = value.ToUpper(); }
            }

            private string F_FAT_CONV = "";
            /// <summary>
            /// Fator de conversão: fator utilizado para converter (multiplicar) a unidade a ser convertida na unidade adotada no inventário.
            /// </summary>
            public string FAT_CONV
            {
                get { return F_FAT_CONV; }
                set { F_FAT_CONV = value.ToUpper(); }
            }

            public string GetRegistro_0220(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID_CONV */
                    if (F_UNID_CONV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_CONV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID_CONV */
                    if (F_UNID_CONV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID_CONV não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID_CONV */
                    if (F_UNID_CONV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_CONV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo FAT_CONV */
                    if (F_FAT_CONV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório FAT_CONV não informado(a)";
                    }
                    /* validacoes manuais */
                    if (!(Convert.ToInt32(F_FAT_CONV) > 0))
                    {
                        return "Erro -> FAT_CONV deve ser maior que '0'";
                    }

                    /*
                     * Campo 02 - Validação: o valor informado no campo deve existir no campo UNID do registro 0190.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_UNID_CONV, F_FAT_CONV);
            }
        }

        /// <summary>
        /// CADASTRO DE BENS OU COMPONENTES DO ATIVO IMOBILIZADO
        /// </summary>
        public class Registro_0300
        {
            private string F_REG = "0300";
            /// <summary>
            /// Texto fixo contendo "0300"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_IND_BEM = "";
            /// <summary>
            /// Código individualizado do bem ou componente adotado no controle patrimonial do estabelecimento informante
            /// </summary>
            public string COD_IND_BEM
            {
                get { return F_COD_IND_BEM; }
                set { F_COD_IND_BEM = value.ToUpper(); }
            }

            private string F_IDENT_MERC = "";
            /// <summary>
            /// Identificação do tipo de mercadoria: 1 - bem; 2 - componente.
            /// </summary>
            public string IDENT_MERC
            {
                get { return F_IDENT_MERC; }
                set { F_IDENT_MERC = value.ToUpper(); }
            }

            private string F_DESCR_ITEM = "";
            /// <summary>
            /// Descrição do bem ou componente (modelo, marca e outras características necessárias a sua individualização)
            /// </summary>
            public string DESCR_ITEM
            {
                get { return F_DESCR_ITEM; }
                set { F_DESCR_ITEM = value.ToUpper(); }
            }

            private string F_COD_PRNC = "";
            /// <summary>
            /// Código de cadastro do bem principal nos casos em que o bem ou componente ( campo 02) esteja vinculado a um bem principal.
            /// </summary>
            public string COD_PRNC
            {
                get { return F_COD_PRNC; }
                set { F_COD_PRNC = value.ToUpper(); }
            }

            private string F_COD_CTA = "";
            /// <summary>
            /// Código da conta analítica de contabilização do bem ou componente (campo 06 do Registro 0500)
            /// </summary>
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            private string F_NR_PARC = "";
            /// <summary>
            /// Número total de parcelas a serem apropriadas, segundo a legislação de cada unidade federada
            /// </summary>
            public string NR_PARC
            {
                get { return F_NR_PARC; }
                set { F_NR_PARC = value.ToUpper(); }
            }

            public string GetRegistro_0300(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_IND_BEM */
                    if (F_COD_IND_BEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_IND_BEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_IND_BEM */
                    if (F_COD_IND_BEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_IND_BEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo IDENT_MERC */
                    if (F_IDENT_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IDENT_MERC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IDENT_MERC */
                    if (F_IDENT_MERC.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IDENT_MERC não informado(a)";
                    }
                    /* Validacao para os dados informados a IDENT_MERC */
                    if (!(F_IDENT_MERC.Equals("1") || F_IDENT_MERC.Equals("2")))
                    {
                        return "Erro -> O campo IDENT_MERC possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IDENT_MERC */
                    if (F_IDENT_MERC.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IDENT_MERC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_ITEM */
                    if (F_DESCR_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_PRNC */
                    if (F_COD_PRNC.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_PRNC incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_CTA */
                    if (F_COD_CTA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CTA */
                    if (F_COD_CTA.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CTA não informado(a)";
                    }
                    /* validacao para o tamanho do campo NR_PARC */
                    if (F_NR_PARC.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de NR_PARC incorreto(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Campo 05: código do bem que esteja vinculado ao bem ou componente informado no campo 02, seja por se tratar:
                    a) de uma imobilização em andamento – código do bem resultante;
                    b) de um bem vinculado a um bem principal – código do bem principal.
                    Validação:
                    a) se o conteúdo do campo IDENT_MERC for igual a “2”, este campo deve obrigatoriamente estar preenchido com o
                    código do bem principal;
                    b) O conteúdo deste campo deve existir em outro registro no campo COD_IND_BEM que não tenha o campo
                    IDENT_MERC igual a “2”.
                    Obs.: Caso esteja digitando entrada de componentes no registro 0300 (opção CRIAR EFD-ICMS/IPI) é necessário
                    informar antes os registros 0500, 0600 e o código do bem principal no registro 0300.
                    
                     * Campo 06: Preenchimento: conta contábil de acordo com o Plano de Contas adotado pela empresa.
                    Validações: o conteúdo informado deve existir no campo COD_CTA e ser conta do ativo (COD_NAT_CC igual a “01”),
                    ambos do registro 0500 ;
                    
                     * Campo 07 - Preenchimento:
                    a) número total de parcelas a serem apropriadas do bem ou componente, segundo a legislação de cada Unidade
                    Federada. A maioria das Unidades Federadas adota o número total de parcelas definidas na Lei Complementar 87/96 –
                    48 parcelas. Entretanto, algumas Unidades Federadas podem definir um número total de parcelas de forma diversa,
                    seja em função da periodicidade de apuração do ICMS ou até mesmo em função de um determinado bem;
                    b) esta informação é obrigatória quando o bem ou componente gerar direito ao crédito de ICMS no momento da sua
                    entrada ou consumo.
                    Validação: informação obrigatória quando os campos 09 e 10 do Registro G125 estiverem preenchidos.
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_IND_BEM, F_IDENT_MERC, F_DESCR_ITEM, F_COD_PRNC, F_COD_CTA, F_NR_PARC);
            }
        }

        /// <summary>
        /// INFORMAÇÃO SOBRE A UTILIZAÇÃO DO BEM
        /// </summary>
        public class Registro_0305
        {
            private string F_REG = "0305";
            /// <summary>
            /// Texto fixo contendo "0305"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_CCUS = "";
            /// <summary>
            /// Código do centro de custo onde o bem está sendo ou será utilizado (campo 03 do Registro 0600)
            /// </summary>
            public string COD_CCUS
            {
                get { return F_COD_CCUS; }
                set { F_COD_CCUS = value.ToUpper(); }
            }

            private string F_FUNC = "";
            /// <summary>
            /// Descrição sucinta da função do bem na atividade do estabelecimento
            /// </summary>
            public string FUNC
            {
                get { return F_FUNC; }
                set { F_FUNC = value.ToUpper(); }
            }

            private string F_VIDA_UTIL = "";
            /// <summary>
            /// Vida útil estimada do bem, em número de meses
            /// </summary>
            public string VIDA_UTIL
            {
                get { return F_VIDA_UTIL; }
                set { F_VIDA_UTIL = value.ToUpper(); }
            }

            public string GetRegistro_0305(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CCUS */
                    if (F_COD_CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CCUS */
                    if (F_COD_CCUS.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CCUS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CCUS */
                    if (F_COD_CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo FUNC */
                    if (F_FUNC.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório FUNC não informado(a)";
                    }
                    /* validacao para o tamanho do campo VIDA_UTIL */
                    if (F_VIDA_UTIL.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de VIDA_UTIL incorreto(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_CCUS, F_FUNC, F_VIDA_UTIL);
            }
        }

        /// <summary>
        /// TABELA DE NATUREZA DA OPERAÇÃO/PRESTAÇÃO
        /// </summary>
        public class Registro_0400
        {
            private string F_REG = "0400";
            /// <summary>
            /// Texto fixo contendo "0400"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_NAT = "";
            /// <summary>
            /// Código da natureza da operação/prestação
            /// </summary>
            public string COD_NAT
            {
                get { return F_COD_NAT; }
                set { F_COD_NAT = value.ToUpper(); }
            }

            private string F_DESCR_NAT = "";
            /// <summary>
            /// Descrição da natureza da operação/prestação
            /// </summary>
            public string DESCR_NAT
            {
                get { return F_DESCR_NAT; }
                set { F_DESCR_NAT = value.ToUpper(); }
            }

            public string GetRegistro_0400(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_NAT */
                    if (F_COD_NAT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_NAT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_NAT */
                    if (F_DESCR_NAT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_NAT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 02 - Validação: o valor informado no campo COD_NAT deve existir em pelo menos um registro dos demais blocos.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_NAT, F_DESCR_NAT);
            }
        }

        /// <summary>
        /// TABELA DE INFORMAÇÃO COMPLEMENTAR DO DOCUMENTO FISCAL
        /// </summary>
        public class Registro_0450
        {
            private string F_REG = "0450";
            /// <summary>
            /// Texto fixo contendo "0450"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_INF = "";
            /// <summary>
            /// Código da informação complementar do documento fiscal.
            /// </summary>
            public string COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value.ToUpper(); }
            }

            private string F_TXT = "";
            /// <summary>
            /// Texto livre da informação complementar existente no documento fiscal, inclusive espécie de normas legais, poder normativo, número, capitulação, data e demais referências pertinentes com indicação referentes ao tributo.
            /// </summary>
            public string TXT
            {
                get { return F_TXT; }
                set { F_TXT = value.ToUpper(); }
            }

            public string GetRegistro_0450(bool Validate)
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
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_INF */
                    if (F_COD_INF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_INF não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (F_COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TXT */
                    if (F_TXT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TXT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Campo 02 - Validação: o valor informado deve existir em pelo menos um registro dos demais blocos.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_INF, F_TXT);
            }
        }

        /// <summary>
        /// TABELA DE OBSERVAÇÕES DO LANÇAMENTO FISCAL
        /// </summary>
        public class Registro_0460
        {
            private string F_REG = "0460";
            /// <summary>
            /// Texto fixo contendo "0460"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_OBS = "";
            /// <summary>
            /// Código da Observação do lançamento fiscal.
            /// </summary>
            public string COD_OBS
            {
                get { return F_COD_OBS; }
                set { F_COD_OBS = value.ToUpper(); }
            }

            private string F_TXT = "";
            /// <summary>
            /// Descrição da observação vinculada ao lançamento fiscal
            /// </summary>
            public string TXT
            {
                get { return F_TXT; }
                set { F_TXT = value.ToUpper(); }
            }

            public string GetRegistro_0460(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_OBS */
                    if (F_COD_OBS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_OBS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (F_COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TXT */
                    if (F_TXT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TXT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Campo 02 -Validação: o valor informado neste campo deve existir em pelo menos um registro dos demais blocos.
Campo 03 - Preenchimento: este campo corresponde às informações lançadas na coluna “Observação” dos Livros Fiscais
de Entradas, Saídas e de Apuração, de acordo com o estabelecido na legislação de cada unidade federada.
                     */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_OBS, F_TXT);
            }
        }

        /// <summary>
        /// PLANO DE CONTAS CONTÁBEIS
        /// </summary>
        public class Registro_0500
        {
            private string F_REG = "0500";
            /// <summary>
            /// Texto fixo contendo “0500”
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_DT_ALT = "";
            /// <summary>
            /// Data da inclusão/alteração
            /// </summary>
            public string DT_ALT
            {
                get { return F_DT_ALT; }
                set { F_DT_ALT = value.ToUpper(); }
            }

            private string F_COD_ = "";
            /// <summary>
            /// NAT_CC Código da natureza da conta/grupo de contas: 01 - Contas de ativo; 02 - Contas de passivo; 03 - Patrimônio líquido; 04 - Contas de resultado; 05 - Contas de compensação; 09 - Outras.
            /// </summary>
            public string COD_
            {
                get { return F_COD_; }
                set { F_COD_ = value.ToUpper(); }
            }

            private string F_IND_CTA = "";
            /// <summary>
            /// Indicador do tipo de conta: S - Sintética (grupo de contas); A - Analítica (conta).
            /// </summary>
            public string IND_CTA
            {
                get { return F_IND_CTA; }
                set { F_IND_CTA = value.ToUpper(); }
            }

            private string F_NÍVEL = "";
            /// <summary>
            /// Nível da conta analítica/grupo de contas.
            /// </summary>
            public string NÍVEL
            {
                get { return F_NÍVEL; }
                set { F_NÍVEL = value.ToUpper(); }
            }

            private string F_COD_CTA = "";
            /// <summary>
            /// Código da conta analítica/grupo de contas.
            /// </summary>
            public string COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value.ToUpper(); }
            }

            private string F_NOME_CTA = "";
            /// <summary>
            /// Nome da conta analítica/grupo de contas.
            /// </summary>
            public string NOME_CTA
            {
                get { return F_NOME_CTA; }
                set { F_NOME_CTA = value.ToUpper(); }
            }

            public string GetRegistro_0500(bool Validate)
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
                    /* validacao para o tamanho do campo DT_ALT */
                    if (F_DT_ALT.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ALT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ALT */
                    if (F_DT_ALT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ALT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ */
                    if (F_COD_.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ */
                    if (F_COD_.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ não informado(a)";
                    }
                    /* Validacao para os dados informados a COD_ */
                    if (!(F_COD_.Equals("01") || F_COD_.Equals("02") || F_COD_.Equals("03") || F_COD_.Equals("04") || F_COD_.Equals("05") || F_COD_.Equals("09")))
                    {
                        return "Erro -> O campo COD_ possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_CTA */
                    if (F_IND_CTA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_CTA */
                    if (F_IND_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_CTA não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_CTA */
                    if (!(F_IND_CTA.Equals("S") || F_IND_CTA.Equals("A")))
                    {
                        return "Erro -> O campo IND_CTA possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo NÍVEL */
                    if (F_NÍVEL.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de NÍVEL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NÍVEL */
                    if (F_NÍVEL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NÍVEL não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CTA */
                    if (F_COD_CTA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CTA */
                    if (F_COD_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CTA não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME_CTA */
                    if (F_NOME_CTA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de NOME_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME_CTA */
                    if (F_NOME_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME_CTA não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     Validação: a data não pode ser maior que a constante no campo DT_FIN.
                     * */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_DT_ALT, F_COD_, F_IND_CTA, F_NÍVEL, F_COD_CTA, F_NOME_CTA);
            }
        }

        /// <summary>
        /// CENTRO DE CUSTOS
        /// </summary>
        public class Registro_0600
        {
            private string F_REG = "0600";
            /// <summary>
            /// Texto fixo contendo “0600”.
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_DT_ALT = "";
            /// <summary>
            /// Data da inclusão/alteração.
            /// </summary>
            public string DT_ALT
            {
                get { return F_DT_ALT; }
                set { F_DT_ALT = value.ToUpper(); }
            }

            private string F_COD_CCUS = "";
            /// <summary>
            /// Código do centro de custos.
            /// </summary>
            public string COD_CCUS
            {
                get { return F_COD_CCUS; }
                set { F_COD_CCUS = value.ToUpper(); }
            }

            private string F_CCUS = "";
            /// <summary>
            /// Nome do centro de custos.
            /// </summary>
            public string CCUS
            {
                get { return F_CCUS; }
                set { F_CCUS = value.ToUpper(); }
            }

            public string GetRegistro_0600(bool Validate)
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
                    /* validacao para o tamanho do campo DT_ALT */
                    if (F_DT_ALT.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ALT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ALT */
                    if (F_DT_ALT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ALT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CCUS */
                    if (F_COD_CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CCUS */
                    if (F_COD_CCUS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CCUS não informado(a)";
                    }
                    /* validacao para o tamanho do campo CCUS */
                    if (F_CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CCUS */
                    if (F_CCUS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CCUS não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_DT_ALT, F_COD_CCUS, F_CCUS);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO 0
        /// </summary>
        public class Registro_0900
        {
            private string F_REG = "0990";
            /// <summary>
            /// Texto fixo contendo "0990"
            /// </summary>
            public string REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_QTD_LIN_0 = "";
            /// <summary>
            /// Quantidade total de linhas do Bloco 0
            /// </summary>
            public string QTD_LIN_0
            {
                get { return F_QTD_LIN_0; }
                set { F_QTD_LIN_0 = value.ToUpper(); }
            }

            public string GetRegistro_0900(bool Validate)
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
                    /* validacao para a obrigatoriedade do campo QTD_LIN_0 */
                    if (F_QTD_LIN_0.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_0 não informado(a)";
                    }
                    /* validacoes manuais */
                    
                    /*
                     * Validação: o número de linhas (registros) existentes no bloco 0 é igual ao valor informado neste campo.
                     * */
                }
                return String.Format("|{0}|{1}|", F_REG, F_QTD_LIN_0);
            }
        }
    }
}
