using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Model.Biz.Common.PileForwardPlayer;
using SuperMemory.Model.Biz.Common.PileForwardOrderControl;
using System.Drawing;
using SuperMemory.Global;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    public class CPicChoiceMeaningBiz : CPileForwardPlayerBase, ITimingControllerObserver
    {
        
        public CPicChoiceMeaningBiz()
        {
            this.forwardOrderController = new CPileForwardOrderControllerRandOrderNotLoop(this);
            this.choicesMgr = new CChoicesMgr(this);
            this.timingController = new CTimingContorller(this);

        }
        
        #region 接口们
        internal void beginTrainning()
        {
            this.isTrainning = true;
            this.timingController.trainningTimingStart();
            this.timingController.groupCountdownStart();
            firstGroup();
        }


        internal void choice(CPile pile)
        {
            if (this.isChoiceCorrect(pile))
            {
                this.onChoiceCorrect();
                return;
            }

            this.onChoiceErr();
        }
        internal void closeTraining()
        {
            if (!this.isTrainning)
            {
                return;
            }
            this.stopTrainning();

            reportTrainning();

            this.clean();
        }
        #endregion
        #region ITimingControllerObserver 成员

        void ITimingControllerObserver.onCountdownZero()
        {
            this.onChoiceErr();
        }

        #endregion

        #region 覆盖父类
        protected override void updatePilesOther()
        {
            new CPilesCopyUtil().copyPiles(this.piles, this.AllCurTypePiles);
        }

        protected override void concrectRemovePile(CPile pile)
        {
            this.piles.Remove(pile);
        }
        protected override void concrectResetPiles()
        {
            new CPilesCopyUtil().copyPiles(this.AllCurTypePiles, this.piles);
        }
        #endregion
        #region 选择操作
        private bool isChoiceCorrect(CPile pile)
        {
            if(pile.PrimOrder == this.curPicPile.PrimOrder)
            {
                return true;
            }
            return false;
        }

        private void onChoiceCorrect()
        {
            this.countCorrectIncrease();
            this.showCorrectPrompt();
            nextGroup();
        }

        private void countCorrectIncrease()
        {
            this.countCorrect++;
            this.updateCountCorrectView();
        }

        private void updateCountCorrectView()
        {
            if (null == this.curChoiceForm)
            {
                return;
            }
            this.curChoiceForm.updateCountCorrect(this.countCorrect);
        }
        private int countCorrect = 0;
        private void onChoiceErr()
        {
            this.countErrIncrease();
            this.showErrPrompt();
            this.timingController.resetCountdown();
        }

        private void countErrIncrease()
        {
            this.countErr++;
            updateCountErrView();
        }

        private void updateCountErrView()
        {
            if(null == this.curChoiceForm)
            {
                return;
            }
            this.curChoiceForm.updateCountErr(this.countErr);
        }
        private int countErr = 0;
        private void showCorrectPrompt()
        {
            if(null == this.curChoiceForm)
            {
                return;
            }

            this.curChoiceForm.showRightPrompt();
        }



        private void showErrPrompt()
        {
            if (null == this.curChoiceForm)
            {
                return;
            }

            this.curChoiceForm.showErrPrompt();
        }

        #endregion
        #region 训练进展
        /// <summary>
        /// 第一组
        /// </summary>
        private void firstGroup()
        {
            this.firstPic();
            this.firstChoices();
        }

        private void firstPic()
        {
            this.forwardOrderController.reset();
            nextPic();
        }

        private void firstChoices()
        {
            this.choicesMgr.nextChoices();

        }
        /// <summary>
        /// 下一组
        /// </summary>
        private void nextGroup()
        {
            if (this.piles.Count == 0)
            {
                this.onTrainningFinished();
                return;
            }
            this.timingController.resetCountdown();
            this.nextPic();
            this.choicesMgr.nextChoices();
        }



        private void onTrainningFinished()
        {
            stopTrainning();

            this.reportTrainning();

            this.clean();

        }

        private void stopTrainning()
        {
            this.isTrainning = false;
            this.timingController.trainningTimingStop();
            this.timingController.groupCountdownStop();
        }

        public void clean()
        {
            if (null != this.curPilePicView)
            {
                this.curPilePicView.setPic(null);
            }

            this.choicesMgr.clean();

            this.countErr = 0;
            this.updateCountErrView();

            this.countCorrect = 0;
            this.updateCountCorrectView();

            this.timingController.resetCountdown();
            this.timingController.resetTiming();
        }


        
        private void nextPic()
        {
            this.CurPicPile = this.forwardOrderController.nextPile();
        }
        #endregion


        private void updateCurPilePicView()
        {
            this.curPilePicView.setPic(Image.FromFile(CGlobal.Inst.PilePicDir + this.CurPicPile.Pic));
        }

        #region 报告成绩
        private void reportTrainning()
        {
            this.curChoiceForm.showReportDailog(this.getTrainningReport());
        }

        private CPicChoiceMeaningReport getTrainningReport()
        {
            CPicChoiceMeaningReport ret = new CPicChoiceMeaningReport();
            ret.CorrectAmount = this.countCorrect;
            ret.ErrAmout = this.countErr;
            ret.TotalQuestionsAmount = this.countErr + this.countCorrect;
            ret.TotalSecUsed = this.timingController.TrainingSecPass;
            ret.ReportDateTime = DateTime.Now.GetDateTimeFormats('F')[0].ToString();
            return ret;
        }
        #endregion

        #region 属性们

        #region 数据
        private CTrainningSet trainningSet = new CTrainningSet();

        public CTrainningSet TrainningSet
        {
            get { return trainningSet; }
        }
        private List<CPile> allCurTypePiles = new List<CPile>();

        public List<CPile> AllCurTypePiles
        {
            get { return allCurTypePiles; }
        }
        private CPile curPicPile;

        public CPile CurPicPile
        {
            get { return curPicPile; }
            set
            {
                curPicPile = value;
                this.updateCurPilePicView();
            }
        }
        #endregion        

        #region views
        private IPilePicView curPilePicView;

        public IPilePicView CurPilePicView
        {
            get { return curPilePicView; }
            set { curPilePicView = value; }
        }


        public IChoicePilesGroupView CurChoicePilesGroupView
        {
            set
            {
                this.choicesMgr.CurChoicePilesGroupView = value;
            }
        }

        public ISecTickerView GroupCountDownView
        {
            set
            {
                this.timingController.GroupCountDownView = value;
            }
        }
        private IFormPicChoice curChoiceForm;

        public IFormPicChoice CurChoiceForm
        {
            set
            {
                curChoiceForm = value;
                this.timingController.TrainningTimingView = value as ISecTickerView;
            }
        }
        #endregion
        #endregion

        private bool isTrainning = false;


        private IPileForwardOrderController forwardOrderController;
        private CChoicesMgr choicesMgr;
        private CTimingContorller timingController;






    }
}
