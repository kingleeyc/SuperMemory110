using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Partten.Observer;
using SuperMemory.Entities;
using System.Windows.Forms;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PilesLearn
{
    public class CPilesLearnBiz : CObeservableBase
    {
        public const int MIN_ORDER = 1;
        public const int MAX_ORDER = 110;


        public const int EVENT_PILE_TYPE_CHANGED = 1;
        public const int EVENT_PILE_CHANGED = 2;
        public const int EVENT_PILE_EDIT_STATE_CHANGED = 3;

        public const int EDIT_STATE_PILE_NUMBER_EDIT = 1;
        public const int EDIT_STATE_PILE_WORD_EDIT = 2;

        private int pilesOrderUpLimit;

        private CPile curPile;

        public CPile CurPile
        {
            get { return curPile; }
            set { 
                curPile = value;
                notifyAllObservers(EVENT_PILE_CHANGED);
            }
        }

        private CPileType curPileType;

        public CPileType CurPileType
        {
            get { return curPileType; }
            set { 
                curPileType = value;
                this.updatePilesLimt();
                notifyAllObservers(EVENT_PILE_TYPE_CHANGED);
            }
        }

        private int editState = EDIT_STATE_PILE_NUMBER_EDIT;

        public int EditState
        {
            get { return editState; }
            set { 
                editState = value;
                notifyAllObservers(EVENT_PILE_EDIT_STATE_CHANGED);
            }
        }
       

        private void updatePilesLimt()
        {
            this.pilesOrderUpLimit = CModelMgr.Inst.Db.Pile.loadPilesLastOrderByTypeId(this.curPileType.PileTypeId);
        }

 
        internal void nextPile()
        {
            if(this.pilesOrderUpLimit < MIN_ORDER)
            {
                return;
            }
            nextPileOrder();
            //this.CurPile = dummyPile1();
        }



        private CPile dummyPile1()
        {
            CPile ret = new CPile();
            ret.PileNumber = "0";
            ret.PrimOrder = 1;
            ret.Word = "Áå";
            ret.Action = "Áå¶ùÏì¶£µ±";
            ret.Pic = Application.StartupPath + "\\pics\\20131114005.jpg";//"File:\\" + Application.StartupPath + "\\pics\\20131114005.jpg";

            return ret;
        }

        internal void lastPile()
        {
            lastPileOrder();
        }

        private void lastPileOrder()
        {
            curPileOrder--;
            if (curPileOrder < MIN_ORDER)
            {
                curPileOrder = this.pilesOrderUpLimit;
            }

            loadPileByCurOrder();
        }


        private void nextPileOrder()
        {
            curPileOrder++;
            if (curPileOrder > this.pilesOrderUpLimit)
            {
                curPileOrder = MIN_ORDER;
            }

            loadPileByCurOrder();
        }


        private void loadPileByCurOrder()
        {
            this.CurPile = CModelMgr.Inst.Db.Pile.loadPileByTypeIdAndOrder(this.curPileType.PileTypeId,curPileOrder);
        }

        private int curPileOrder = 0;

        internal void pileNumberEdit()
        {
            this.EditState = EDIT_STATE_PILE_NUMBER_EDIT;
        }

        internal void pileWordEdit()
        {
            this.EditState = EDIT_STATE_PILE_WORD_EDIT;
        }
    }
}
