using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Data.Comum
{
    internal class ProcAttr
    {
        public string attrName;
        public SqlDbType attrType;
        public object attrValue;
    }

    internal class ProcParam
    {
        public List<ProcAttr> paramsColection;
    }
}
