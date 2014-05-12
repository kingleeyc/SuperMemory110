using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Partten.Observer;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear
{
    public class CPilesFlashCardGearBiz 
    {
        private CPileType curPileType;

        public CPileType CurPileType
        {
            get { return curPileType; }
            set { 
                curPileType = value;
                this.PlayController.updatePiles(this.curPileType.PileTypeId);
            }
        }

        private CPlayController playController = new CPlayController();

        public CPlayController PlayController
        {
            get { return playController; }
        }


        private UcPilesFlashCardGear view;

        public UcPilesFlashCardGear View
        {
            get { return view; }
            set { view = value; }
        }

        internal bool hasPiles()
        {
            return this.playController.hasPiles();

        }
    }
}
