using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.Common.PileForwardPlayer;
using SuperMemory.Model.Biz.Common.PileForwardOrderControl;
using SuperMemory.Entities;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    public class CTranscodingBiz : ITranscodingBiz
    {
        public CTranscodingBiz()
        {
            this.pilesMgr.TranscodingBiz = this;
            this.groupsMgr.PilesMgr = this.pilesMgr;
            this.answerVerifier.GroupsMgr = this.groupsMgr;
            this.answerVerifier.PilesMgr = this.pilesMgr;

        }
 
        internal void beginTrainning()
        {
            this.answerVerifier.beginTrainning();
            this.pilesMgr.beginTrainning();
            // 洗牌
            this.pilesMgr.genRandOrderPrimPiles();
            this.groupsMgr.nextGroup();

        }

        internal void onAnswerPileChosen(IPileView pileView)
        {
            this.answerVerifier.CurChosenAnswerPile = pileView; 
            this.answerVerifier.verifyDo();
        }

        internal void onAskPileChosen(IPileView pileView)
        {
            this.answerVerifier.CurChosenAskPile = pileView;
            this.answerVerifier.verifyDo();
        }

        internal int getPilesCount()
        {
            return this.pilesMgr.PrimPiles.Count;
        }


        internal bool hasPiles()
        {
            return this.pilesMgr.hasPiles();
        }

        private CPileType curPileType;
        public CPileType CurPileType
        {
            get { return curPileType; }
            set
            {
                curPileType = value;
                this.pilesMgr.updatePiles(this.curPileType.PileTypeId);
            }
        }

        public IPileGroupView AskPilesGroupView
        {
            set { 
                this.groupsMgr.AskPilesGroupView = value; }
        }


        public IPileGroupView AnswerPilesGroupView
        {
            set { 
                this.groupsMgr.AnswerPilesGroupView = value; }
        }

        private ITranscodingPanel transcodingPanel;

        public ITranscodingPanel TranscodingPanel
        {
            get { return transcodingPanel; }
            set { 
                transcodingPanel = value;
                this.groupsMgr.TranscodingPanel = value;
                this.answerVerifier.TranscodingPanel = value;
            }
        }

        public ISecTickerView GroupCountDownView
        {
            set
            {
                this.answerVerifier.GroupCountDownView = value;
            }
        }

        public ISecTickerView TrainningTimingView
        {
            set
            {
                this.answerVerifier.TrainningTimingView = value;
            }
        }

        private IPilesMgr pilesMgr = new CPilesMgr();
        private IGroupsMgr groupsMgr = new CGroupsMgr();
        private IAnswerVerifier answerVerifier = new CAnswerVerifier();


        #region ITranscodingBiz 成员

        CTrainningSet ITranscodingBiz.TrainningSet
        {
            get { return this.trainningSet; }
        }
        private CTrainningSet trainningSet = new CTrainningSet();
        #endregion


    }
}
