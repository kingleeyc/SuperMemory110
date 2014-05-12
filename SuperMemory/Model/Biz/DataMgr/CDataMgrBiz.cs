using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.DataMgr.PilesDataMgr;

namespace SuperMemory.Model.Biz.DataMgr
{
    public class CDataMgrBiz
    {
        private CPilesDataMgrBiz pilesDatMgr = new CPilesDataMgrBiz();

        public CPilesDataMgrBiz PilesDatMgr
        {
            get { return pilesDatMgr; }
        }

    }
}
