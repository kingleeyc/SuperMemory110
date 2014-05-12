using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model;
using SuperMemory.Enums;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public partial class UcTopPilesGroup : UcRadioPileViewGroupBase, IPileGroupView
    {
        public UcTopPilesGroup()
        {
            InitializeComponent();
        }

        private void UcTopPilesGroup_Load(object sender, EventArgs e)
        {
            (pile1 as IRadioPileView).RadioId = 1;
            (pile1 as IRadioPileView).setGroup(this);
            this.addPile(pile1 as IRadioPileView);

            (pile2 as IRadioPileView).RadioId = 2;
            (pile2 as IRadioPileView).setGroup(this);
            this.addPile(pile2 as IRadioPileView);

            (pile3 as IRadioPileView).RadioId = 3;
            (pile3 as IRadioPileView).setGroup(this);
            this.addPile(pile3 as IRadioPileView);

            (pile4 as IRadioPileView).RadioId = 4;
            (pile4 as IRadioPileView).setGroup(this);
            this.addPile(pile4 as IRadioPileView);

            Biz.AskPilesGroupView = this;
        }

        #region IPileGroupView 成员

        void IPileGroupView.fill1PileData(SuperMemory.Entities.CPile pileData, int idx)
        {
            switch (idx)
            {
                case 0:
                    (this.pile1 as IRadioPileView).PileData = pileData;
                    break;
                case 1:
                    (this.pile2 as IRadioPileView).PileData = pileData;
                    break;
                case 2:
                    (this.pile3 as IRadioPileView).PileData = pileData;
                    break;
                case 3:
                    (this.pile4 as IRadioPileView).PileData = pileData;
                    break;
            }
        }

        #endregion

        override protected void on1PileChosen()
        {
            Biz.onAskPileChosen(this.curChosenPileView);
        }

        protected override void setTranscodingType(EnumTranscodingType transcodingType)
        {
            switch((int)transcodingType)
            {
                case (int)EnumTranscodingType.pic2num:
                    this.pilesViewField2Pic();
                    break;
                case (int)EnumTranscodingType.pic2word:
                    this.pilesViewField2Pic();
                    break;
                case (int)EnumTranscodingType.pic2role:
                    this.pilesViewField2Pic();
                    break;
                case (int)EnumTranscodingType.pic2action:
                    this.pilesViewField2Pic();
                    break;
                case (int)EnumTranscodingType.num2word:
                    this.pilesViewField2Num();
                    break;
                case (int)EnumTranscodingType.num2role:
                    this.pilesViewField2Num();
                    break;
                case (int)EnumTranscodingType.num2action:
                    this.pilesViewField2Num();
                    break;
                case (int)EnumTranscodingType.word2role:
                    this.pilesViewField2Word();
                    break;
                case (int)EnumTranscodingType.word2action:
                    this.pilesViewField2Word();
                    break;
            }
        }

        internal void cleanAllPilesMark()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.cleanMark();
            }
        }



        #region IPileGroupView 成员
        void IPileGroupView.cleanState()
        {
            this.cleanStateDo();
        }


        #endregion


    }
}

