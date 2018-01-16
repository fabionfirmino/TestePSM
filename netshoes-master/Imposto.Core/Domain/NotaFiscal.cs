using System.Collections.Generic;

namespace Imposto.Core.Domain
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public int Serie { get; set; }
        public string NomeCliente { get; set; }

        public string EstadoDestino { get; set; }
        public string EstadoOrigem { get; set; }

        public double Desconto { get; set; }

        public List<NotaFiscalItem> ItensDaNotaFiscal { get; set; }

        public NotaFiscal()
        {
            ItensDaNotaFiscal = new List<NotaFiscalItem>();
        }

        //public void EmitirNotaFiscal(Pedido pedido)
        //{
        //    this.NumeroNotaFiscal = 99999;
        //    this.Serie = new Random().Next(Int32.MaxValue);
        //    this.NomeCliente = pedido.NomeCliente;

        //    this.EstadoDestino = pedido.EstadoDestino;
        //    this.EstadoOrigem = pedido.EstadoOrigem;

        //    foreach (PedidoItem itemPedido in pedido.ItensDoPedido)
        //    {
        //        NotaFiscalItem notaFiscalItem = new NotaFiscalItem();
        //        if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "RJ"))
        //        {
        //            notaFiscalItem.Cfop = "6.000";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "PE"))
        //        {
        //            notaFiscalItem.Cfop = "6.001";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "MG"))
        //        {
        //            notaFiscalItem.Cfop = "6.002";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "PB"))
        //        {
        //            notaFiscalItem.Cfop = "6.003";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "PR"))
        //        {
        //            notaFiscalItem.Cfop = "6.004";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "PI"))
        //        {
        //            notaFiscalItem.Cfop = "6.005";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "RO"))
        //        {
        //            notaFiscalItem.Cfop = "6.006";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "SE"))
        //        {
        //            notaFiscalItem.Cfop = "6.007";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "TO"))
        //        {
        //            notaFiscalItem.Cfop = "6.008";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "SE"))
        //        {
        //            notaFiscalItem.Cfop = "6.009";
        //        }
        //        else if ((this.EstadoOrigem == "SP") && (this.EstadoDestino == "PA"))
        //        {
        //            notaFiscalItem.Cfop = "6.010";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "RJ"))
        //        {
        //            notaFiscalItem.Cfop = "6.000";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "PE"))
        //        {
        //            notaFiscalItem.Cfop = "6.001";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "MG"))
        //        {
        //            notaFiscalItem.Cfop = "6.002";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "PB"))
        //        {
        //            notaFiscalItem.Cfop = "6.003";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "PR"))
        //        {
        //            notaFiscalItem.Cfop = "6.004";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "PI"))
        //        {
        //            notaFiscalItem.Cfop = "6.005";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "RO"))
        //        {
        //            notaFiscalItem.Cfop = "6.006";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "SE"))
        //        {
        //            notaFiscalItem.Cfop = "6.007";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "TO"))
        //        {
        //            notaFiscalItem.Cfop = "6.008";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "SE"))
        //        {
        //            notaFiscalItem.Cfop = "6.009";
        //        }
        //        else if ((this.EstadoOrigem == "MG") && (this.EstadoDestino == "PA"))
        //        {
        //            notaFiscalItem.Cfop = "6.010";
        //        }
        //        else
        //        {
        //            notaFiscalItem.Cfop = "0";
        //        }

        //        if (this.EstadoDestino == this.EstadoOrigem)
        //        {
        //            notaFiscalItem.TipoIcms = "60";
        //            notaFiscalItem.AliquotaIcms = 0.18;
        //            notaFiscalItem.Cfop = "0";
        //        }
        //        else
        //        {
        //            notaFiscalItem.TipoIcms = "10";
        //            notaFiscalItem.AliquotaIcms = 0.17;
        //        }
        //        if (notaFiscalItem.Cfop == "6.009")
        //        {
        //            notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido * 0.90; //redução de base
        //        }
        //        else
        //        {
        //            notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido;
        //        }
        //        notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;

        //        if (itemPedido.Brinde)
        //        {
        //            notaFiscalItem.TipoIcms = "60";
        //            notaFiscalItem.AliquotaIcms = 0.18;
        //            notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
        //            notaFiscalItem.AliquotaIPI = 0;
        //        }
        //        else
        //        {
        //            notaFiscalItem.AliquotaIPI = 0.10;
        //        }

        //        notaFiscalItem.BaseIPI = itemPedido.ValorItemPedido;

        //        notaFiscalItem.ValorIPI = notaFiscalItem.BaseIPI * notaFiscalItem.AliquotaIPI;

        //        notaFiscalItem.NomeProduto = itemPedido.NomeProduto;
        //        notaFiscalItem.CodigoProduto = itemPedido.CodigoProduto;

        //        ItensDaNotaFiscal.Add(notaFiscalItem);
        //    }

        //    if (PersistirNotaFiscal(this))
        //    {
        //        NotaFiscalDB NFdb = new NotaFiscalDB();
        //        NFdb.InserirNotaFiscal(this);
        //        NFdb.InserirNotaFiscalItem(this.ItensDaNotaFiscal);
        //    }
        //}


        //private bool PersistirNotaFiscal(NotaFiscal nf)
        //{
        //    StringWriter sw = new StringWriter();
        //    XmlTextWriter tw = null;
        //    bool retorno;

        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(nf.GetType());
        //        tw = new XmlTextWriter(sw);
        //        serializer.Serialize(tw, nf);
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        if (sw.ToString() != string.Empty)
        //        {
        //            retorno = true;
        //        }
        //        else
        //        {
        //            retorno = false;
        //        }
        //    }

        //    return retorno;
        //}
    }
}
