using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.DB.TablePile;
using SuperMemory.Model.DB.TablePileType;

namespace SuperMemory.Model.DB
{
    public class CDBMgr
    {
        private CTablePile pile = new CTablePile();

        public CTablePile Pile
        {
            get { return pile; }
        }

        private CTablePileType pileType = new CTablePileType();

        public CTablePileType PileType
        {
            get { return pileType; }
        }

    }
}
