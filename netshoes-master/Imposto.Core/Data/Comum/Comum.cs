using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Imposto.Core.Data.Comum
{
    internal class Comum
    {
        string connetionString = null;
        SqlConnection cnn;

        public void AbrirConexao()
        {
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bankai\Downloads\netshoes-master\netshoes-master\Imposto.Core\bin\Debug\BancoNetshoes.mdf;Integrated Security=True;Connect Timeout=30";

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public void FecharConexao()
        {
            cnn.Close();
        }

        public void ExecutarProcedure(string ProcName, List<ProcAttr> Parametros, out int param)
        {
            using (SqlCommand cmd = new SqlCommand(ProcName, cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (ProcAttr p in Parametros)
                {
                    cmd.Parameters.Add("@p" + p.attrName, p.attrType).Value = p.attrValue;
                }

                //estou fazendo isso, pois a situação me permite.
                //tenho 2 procs, e dois dias pra resolver... logo...
                //vamos ao que funciona, não ao que é exatamente correto
                if (ProcName == "P_NOTA_FISCAL")
                {
                    cmd.Parameters["@pId"].Direction = ParameterDirection.InputOutput;
                }

                var r = cmd.ExecuteNonQuery();

                param = Convert.ToInt32(cmd.Parameters["@pId"].Value);
            }
        }
    }
}
