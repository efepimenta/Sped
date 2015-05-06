using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SpedFiscal
{
        public enum TpConsulta
        {
            PorCodigo, PorNome,     //para a busca por municipio ou pais
            PorCodigoTrazendoUF     //para a pesquisa que retorna a UF
        }

    public static class Utils
    {
        [DllImport("DllInscE32.dll")]
        static extern int ConsisteInscricaoEstadual(string cInsc, string cUF);
        /// <summary>
        /// verifica a validade da inscricao estadual
        /// </summary>
        /// <param name="IE">IE</param>
        /// <param name="UF">UF</param>
        /// <returns>string</returns>
        public static string ValidaInscricaoEstadual(string IE, string UF)
        {
            if (IE.Trim().Trim().Equals(""))
                IE = "isento";
            int valido = ConsisteInscricaoEstadual(IE, UF);
            switch (valido)
	        {
                case 0:
                    return IE;
                case 1:
                    return "Erro -> IE Inv";
                default:
                    return "isento";
	        }
        }

        public static string ValidaUF(string UF)
        {
            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
                                 "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" };
            if (estados.Contains(UF.ToUpper()))
                return UF.ToUpper();
            else
                return "Erro";
        }

        /// <summary>
        /// Remove os acentos de uma string
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>string</returns>
        public static string RemoverAcentos(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            else
            {
                byte[] bytes = System.Text.Encoding.GetEncoding("iso-8859-8").GetBytes(input);
                return System.Text.Encoding.UTF8.GetString(bytes);
            }
        }

        /// <summary>
        /// Realiza a validação do CNPJ
        /// </summary>
        public static bool ValidaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Realiza a validação do CPF
        /// </summary>
        public static bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Consulta um municipio
        /// </summary>
        /// <param name="Tipo">Tipo de consulta</param>
        /// <param name="Valor">string</param>
        /// <param name="UF">string</param>
        /// <returns></returns>
        public static string ConsultaMunicipio(TpConsulta Tipo, string Valor, string UF)
        {
            if (Valor.Trim().Trim().Equals(""))
                return "Erro -> Parâmetro Valor não informado";
            if (UF.Trim().Trim().Equals(""))
                return "Erro -> Parâmetro UF não informado";
            if (UF.Length > 2)
                return "Erro -> arâmetro UF deve conter apenas 2 letras";
            Valor = RemoverAcentos(Valor);
            string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\fabio\Dropbox\C#\Projetos\SpedContabilFiscal\SpedFiscal\Tabela.mdf;
                Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            DataSet ds = new DataSet();
            string campo = "";
            string coluna = "";
            string query = "";
            switch (Tipo)
            {
                case TpConsulta.PorCodigo:
                    campo = "NOME_MUN";
                    coluna = "COD_MUN";
                    break;
                case TpConsulta.PorNome:
                    campo = "COD_MUN";
                    coluna = "NOME_MUN";
                    break;
                case TpConsulta.PorCodigoTrazendoUF:
                    campo = "UF";
                    coluna = "COD_MUN";
                    break;
            }
            query = String.Format("SELECT {0} FROM Municipios WHERE {1} = '{2}' AND UF_MUN = '{3}'",campo,coluna,Valor,UF);
            if (Tipo == TpConsulta.PorCodigoTrazendoUF)
                query = String.Format("SELECT {0} FROM Municipios WHERE {1} = '{2}'", campo, coluna, Valor);
            SqlCommand cmd = new SqlCommand(query, conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                DataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(ds);
                if (ds.Tables[0].Rows.Count != 1)
                    return "Erro -> Município não encontrado";
                else
                    return ds.Tables[0].Rows[0][campo].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }

        public static string ConsultaPais(TpConsulta Tipo, string Valor)
        {
            if (Valor.Trim().Trim().Equals(""))
                return "Erro -> Parâmetro Valor não informado";
            Valor = RemoverAcentos(Valor).PadLeft(5,'0');
            string strcon = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Fabio\Dropbox\C#\Projetos\SpedContabilFiscal\SpedFiscal\Tabela.mdf;Integrated Security=True;
                Integrated Security=True";
            SqlConnection conexao = new SqlConnection(strcon);
            DataSet ds = new DataSet();
            string campo = "";
            string coluna = "";
            string query = "";
            switch (Tipo)
            {
                case TpConsulta.PorCodigo:
                    campo = "NOME";
                    coluna = "COD";
                    break;
                case TpConsulta.PorNome:
                    campo = "COD";
                    coluna = "NOME";
                    break;
            }
            query = String.Format("SELECT {0} FROM Paises WHERE {1} = '{2}'", campo, coluna, Valor);
            SqlCommand cmd = new SqlCommand(query, conexao);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
                DataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(ds);
                if (ds.Tables[0].Rows.Count != 1)
                    return "Erro -> País não encontrado";
                else
                    return ds.Tables[0].Rows[0][campo].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro -> " + ex.Message);
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}