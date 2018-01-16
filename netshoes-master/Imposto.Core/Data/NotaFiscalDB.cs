using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto.Core.Domain;
using Imposto.Core.Data.Comum;
using System.Data;
using System.Reflection;

namespace Imposto.Core.Data
{
    public class NotaFiscalDB
    {
        int NfId = 0;
        int NfItemId = 0;

        Comum.Comum conexao;

        public NotaFiscalDB()
        {
            conexao = new Comum.Comum();
            conexao.AbrirConexao();
        }

        public void InserirNotaFiscal(NotaFiscal nf)
        {
            Type tipo = nf.GetType();
            PropertyInfo[] propriedades = tipo.GetProperties();

            ProcParam p = new ProcParam();
            p.paramsColection = new List<ProcAttr>();

            foreach (PropertyInfo prop in propriedades)
            {
                ProcAttr attr = new ProcAttr();
                if (prop.Name != "ItensDaNotaFiscal")
                {
                    attr.attrName = prop.Name;

                    recuperarSQLDBType(ref attr.attrType, prop.PropertyType.Name);

                    attr.attrValue = prop.GetValue(nf, null);
                    p.paramsColection.Add(attr);
                }
            }

            conexao.ExecutarProcedure("P_NOTA_FISCAL", p.paramsColection, out NfId);
        }

        public void InserirNotaFiscalItem(List<NotaFiscalItem> nfI)
        {
            foreach (NotaFiscalItem itemNF in nfI)
            {
                itemNF.IdNotaFiscal = NfId;

                Type tipo = itemNF.GetType();
                PropertyInfo[] propriedades = tipo.GetProperties();

                ProcParam p = new ProcParam();
                p.paramsColection = new List<ProcAttr>();

                foreach (PropertyInfo prop in propriedades)
                {
                    ProcAttr attr = new ProcAttr();

                    attr.attrName = prop.Name;

                    recuperarSQLDBType(ref attr.attrType, prop.PropertyType.Name);

                    attr.attrValue = prop.GetValue(itemNF, null);
                    p.paramsColection.Add(attr);

                }
                conexao.ExecutarProcedure("P_NOTA_FISCAL_ITEM", p.paramsColection, out NfItemId);
            }
        }

        private void recuperarSQLDBType(ref SqlDbType attrType, String PropertyType)
        {
            switch (PropertyType)
            {
                case "Int16":
                    attrType = SqlDbType.SmallInt;
                    break;
                case "Int32":
                    attrType = SqlDbType.Int;
                    break;
                case "Int64":
                    attrType = SqlDbType.BigInt;
                    break;
                case "Decimal":
                    attrType = SqlDbType.Decimal;
                    break;
                case "String":
                    attrType = SqlDbType.VarChar;
                    break;
            }
        }

        private void EncerrarDB()
        {
            conexao.FecharConexao();
        }
    }
}
