using Imposto.Core.Data;
using Imposto.Core.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Imposto.Core.Business
{
    public class NotaFiscalBusiness
    {
        public void EmitirNotaFiscal(Pedido pedido)
        {
            NotaFiscal NF = new NotaFiscal();

            NF.NumeroNotaFiscal = 99999;
            NF.Serie = new Random().Next(Int32.MaxValue);
            NF.NomeCliente = pedido.NomeCliente;
            
            NF.EstadoDestino = pedido.EstadoDestino;
            NF.EstadoOrigem = pedido.EstadoOrigem;

            NF.ItensDaNotaFiscal = new List<NotaFiscalItem>();

            foreach (PedidoItem itemPedido in pedido.ItensDoPedido)
            {
                NotaFiscalItem notaFiscalItem = new NotaFiscalItem();
                if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "RJ"))
                {
                    notaFiscalItem.Cfop = "6.000";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "PE"))
                {
                    notaFiscalItem.Cfop = "6.001";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "MG"))
                {
                    notaFiscalItem.Cfop = "6.002";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "PB"))
                {
                    notaFiscalItem.Cfop = "6.003";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "PR"))
                {
                    notaFiscalItem.Cfop = "6.004";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "PI"))
                {
                    notaFiscalItem.Cfop = "6.005";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "RO"))
                {
                    notaFiscalItem.Cfop = "6.006";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "SE"))
                {
                    notaFiscalItem.Cfop = "6.007";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "TO"))
                {
                    notaFiscalItem.Cfop = "6.008";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "SE"))
                {
                    notaFiscalItem.Cfop = "6.009";
                }
                else if ((NF.EstadoOrigem == "SP") && (NF.EstadoDestino == "PA"))
                {
                    notaFiscalItem.Cfop = "6.010";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "RJ"))
                {
                    notaFiscalItem.Cfop = "6.000";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "PE"))
                {
                    notaFiscalItem.Cfop = "6.001";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "MG"))
                {
                    notaFiscalItem.Cfop = "6.002";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "PB"))
                {
                    notaFiscalItem.Cfop = "6.003";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "PR"))
                {
                    notaFiscalItem.Cfop = "6.004";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "PI"))
                {
                    notaFiscalItem.Cfop = "6.005";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "RO"))
                {
                    notaFiscalItem.Cfop = "6.006";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "SE"))
                {
                    notaFiscalItem.Cfop = "6.007";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "TO"))
                {
                    notaFiscalItem.Cfop = "6.008";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "SE"))
                {
                    notaFiscalItem.Cfop = "6.009";
                }
                else if ((NF.EstadoOrigem == "MG") && (NF.EstadoDestino == "PA"))
                {
                    notaFiscalItem.Cfop = "6.010";
                }
                else
                {
                    notaFiscalItem.Cfop = "0";
                }

                if (NF.EstadoDestino == NF.EstadoOrigem)
                {
                    notaFiscalItem.TipoIcms = "60";
                    notaFiscalItem.AliquotaIcms = 18;
                    notaFiscalItem.Cfop = "0";
                }
                else
                {
                    notaFiscalItem.TipoIcms = "10";
                    notaFiscalItem.AliquotaIcms = 17;
                }
                if (notaFiscalItem.Cfop == "6.009")
                {
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido * 0.90; //redução de base
                }
                else
                {
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido;
                }
                notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;

                if (itemPedido.Brinde)
                {
                    notaFiscalItem.TipoIcms = "60";
                    notaFiscalItem.AliquotaIcms = 18;
                    notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
                    notaFiscalItem.AliquotaIPI = 0;
                }
                else
                {
                    notaFiscalItem.AliquotaIPI = 10;
                }

                notaFiscalItem.BaseIPI = itemPedido.ValorItemPedido;

                notaFiscalItem.ValorIPI = notaFiscalItem.BaseIPI * notaFiscalItem.AliquotaIPI;

                notaFiscalItem.NomeProduto = itemPedido.NomeProduto;
                notaFiscalItem.CodigoProduto = itemPedido.CodigoProduto;

                NF.ItensDaNotaFiscal.Add(notaFiscalItem);
            }

            if (NF.EstadoDestino == "SP") {
                NF.Desconto = 10;
            }

            if (PersistirNotaFiscal(NF))
            {
                NotaFiscalDB NFdb = new NotaFiscalDB();
                NFdb.InserirNotaFiscal(NF);
                NFdb.InserirNotaFiscalItem(NF.ItensDaNotaFiscal);
            }
        }


        private bool PersistirNotaFiscal(NotaFiscal nf)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            bool retorno;

            try
            {
                XmlSerializer serializer = new XmlSerializer(nf.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, nf);
            }
            catch (Exception e)
            {

            }
            finally
            {
                if (sw.ToString() != string.Empty)
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
            }

            return retorno;
        }
    }
}
