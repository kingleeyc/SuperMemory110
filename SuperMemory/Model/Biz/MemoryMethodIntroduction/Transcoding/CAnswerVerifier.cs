using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    public class CAnswerVerifier : IAnswerVerifier, ITimingControllerObserver
    {
        public CAnswerVerifier()
        {
            this.timingController = new CTimingContorller(this);
        }

        #region IAnswerVerifier 成员
        void IAnswerVerifier.verifyDo()
        {
            if (!this.IsChosenPairCompleted())
            {
                return;
            }

            if (this.curChosenAskPile.PileData.PrimOrder == this.curChosenAnswerPile.PileData.PrimOrder)
            {
                this.onAnswerRigh();
            }
            else
            {
                this.onAnswerFault();
            }

            this.removeChosenPiles();


            if (this.groupsMgr.isCurGroupFinish())
            {
                this.onGroupFinish();
            }
        }



        private IPileView curChosenAnswerPile = null;
        IPileView IAnswerVerifier.CurChosenAnswerPile
        {
            get
            {
                return this.curChosenAnswerPile;
            }
            set
            {
                this.curChosenAnswerPile = value;
            }
        }

        private IPileView curChosenAskPile = null;
        IPileView IAnswerVerifier.CurChosenAskPile
        {
            get
            {
                return this.curChosenAskPile;
            }
            set
            {
                this.curChosenAskPile = value;
            }
        }

        ITranscodingPanel IAnswerVerifier.TranscodingPanel
        {
            set { transcodingPanel = value; }
        }
        private ITranscodingPanel transcodingPanel;


        IGroupsMgr IAnswerVerifier.GroupsMgr
        {
            set { groupsMgr = value; }
        }
        private IGroupsMgr groupsMgr;


        IPilesMgr IAnswerVerifier.PilesMgr
        {
            set { pilesMgr = value; }
        }
        private IPilesMgr pilesMgr;
        #endregion

        #region ITimingControllerObserver 成员

        void ITimingControllerObserver.onCountdownZero()
        {
            this.transcodingPanel.showResetGroupPromp();
            this.resetCurGroup();
            this.beginCurGroup();            
        }

        private void resetCurGroup()
        {
            this.groupsMgr.resetCurGroup();
            //this.cleanCurChosenPilesMark();
            this.cleanAllPilesViewMark();
            this.removeChosenPiles();
        }

        private void cleanAllPilesViewMark()
        {
            this.transcodingPanel.cleanAllPilesMark();
        }

        private void cleanCurChosenPilesMark()
        {
            if (null != this.curChosenAnswerPile)
            {
                //this.curChosenAnswerPile.unChoice();
                this.curChosenAnswerPile.cleanMark();
                //this.curChosenAnswerPile = null;
            }
            if (null != this.curChosenAskPile)
            {
                //this.curChosenAskPile.unChoice();
                this.curChosenAskPile.cleanMark();
                //this.curChosenAskPile = null;
            }
        }

        #endregion
        private void onGroupFinish()
        {
            //throw new Exception("The method or operation is not implemented.");

            if (this.pilesMgr.isAllPilesPass())
            {
                this.onTrainningFinish();
                return;
            }
            // 提示继续下一组
            this.transcodingPanel.showContinueNextGroupPrompt();
            this.groupsMgr.nextGroup();

            this.timingController.groupCountdownStart();
        }

        private void onTrainningFinish()
        {
            this.transcodingPanel.showTrainningFinishPrompt();

            this.timingController.resetCountdown();
            this.timingController.groupCountdownStop();

            this.trainningResult.reset();
        }


        private void onAnswerFault()
        {
            // 显示答错效果（打叉）
            // 弹出重做本题提示
            // 重做本组
            // 去除选中显示
            this.curChosenAskPile.markError();
            this.transcodingPanel.showResetGroupPromp();

            //this.groupsMgr.resetCurGroup();
            //this.curChosenAskPile.cleanMark();
            ////this.cleanChosenPiles();
            //this.timingController.groupCountdownStart();

            this.resetCurGroup();
            this.beginCurGroup();

            this.trainningResult.newErr();
        }



        private void onAnswerRigh()
        {
            // 显示答对效果（打勾）
            this.curChosenAskPile.markCorrect();
            this.groupsMgr.nextPileInCurGroup();

            this.trainningResult.newCorrect();
        }

        private void removeChosenPiles()
        {
            if (null != this.curChosenAnswerPile)
            {
                this.curChosenAnswerPile.unChoice();
                //this.curChosenAnswerPile.cleanMark();
                this.curChosenAnswerPile = null;
            }
            if (null != this.curChosenAskPile)
            {
                this.curChosenAskPile.unChoice();
                //this.curChosenAskPile.cleanMark();
                this.curChosenAskPile = null;
            }

        }

        private bool IsChosenPairCompleted()
        {
            if (null == this.curChosenAskPile)
            {
                return false;
            }
            if (null == this.curChosenAnswerPile)
            {
                return false;
            }
            return true;
        }






        #region IAnswerVerifier 成员

        void IAnswerVerifier.beginTrainning()
        {
            beginCurGroup();
            this.timingController.trainningTimingStart();
        }

        private void beginCurGroup()
        {
            this.timingController.groupCountdownStart();
        }

        ISecTickerView IAnswerVerifier.GroupCountDownView
        {
            set { this.timingController.GroupCountDownView = value; }
        }

        ISecTickerView IAnswerVerifier.TrainningTimingView
        {
            set { 
                this.timingController.TrainningTimingView = value;
                this.trainningResult.View = value as ITrainningResultView;
            }
        }

        private CTimingContorller timingController;

        CTrainningResult IAnswerVerifier.TrainningResult
        {
            get { return this.trainningResult; }
        }
        private CTrainningResult trainningResult = new CTrainningResult();
        #endregion



    }
}
