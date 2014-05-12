using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction;
using SuperMemory.Model.Biz.DataMgr;

namespace SuperMemory.Model.Biz
{
    public class CBizMgr
    {
        private CMemoryMethodIntroductionBiz memoryMethodIntroduction = new CMemoryMethodIntroductionBiz();

        public CMemoryMethodIntroductionBiz MemoryMethodIntroduction
        {
            get { return memoryMethodIntroduction; }
        }

        private CDataMgrBiz dataMgr = new CDataMgrBiz();

        public CDataMgrBiz DataMgr
        {
            get { return dataMgr; }
        }


    }
}
