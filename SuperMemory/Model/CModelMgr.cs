using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz;
using SuperMemory.Model.DB;

namespace SuperMemory.Model
{
    public class CModelMgr
    {
        private CModelMgr() { }
        private static CModelMgr inst = new CModelMgr();

        public static CModelMgr Inst
        {
            get { return CModelMgr.inst; }
        }


        private CBizMgr biz = new CBizMgr();

        public CBizMgr Biz
        {
            get { return biz; }
        }

        private CDBMgr db = new CDBMgr();

        internal CDBMgr Db
        {
            get { return db; }
        }

    }
}
