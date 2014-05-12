using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;
using SuperMemory.Model;
using SuperMemory.Partten.Observer;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayControl;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    public partial class UcPilesFlashCardGear : UcFormMainBase,IObserver,
        ILeafPileTypeSelectOberver, IPileOrderAreaSetObserver,
        IPlayOrderSetObserver, IPlayPrioritySetObserver,
        IPlayGroupAmountSetObserver, ITrainPeriodSetObserver,
        IPlayIntervalSetObserver, IPlayControlObserver
    {
        public UcPilesFlashCardGear()
        {
            InitializeComponent();
        }

        public override void initLoad()
        {

            biz().View = this;

            biz().PlayController.add(this);

            biz().PlayController.setTranningProgressView(this.ucTraningProgresser);
            biz().PlayController.setStepProgressView(this.ucStepProgresser);
            

            this.ucLeafPileTypesSelector.setSelChangedObserver(this);
            this.ucLeafPileTypesSelector.initLoad();

            this.ucPileOrderAreaSet.setObserver(this);
            this.ucPlayerOrderSet.setObserver(this);

            this.ucPlayerPrioritySet.setObserver(this);
            this.ucPlayerPrioritySet.initLoad();

            this.ucPlayerGroupAmountSet.setObserver(this);
            this.ucPlayerGroupAmountSet.initLoad();

            this.ucTrainPeriodSet.setObserver(this);
            this.ucTrainPeriodSet.initLoad();

            this.ucPlayIntervalSet.setObserver(this);
            this.ucPlayIntervalSet.initLoad();

            this.ucPlayController.setObserver(this);
        }

        #region ILeafPileTypeSelectOberver 成员

        void ILeafPileTypeSelectOberver.onPileTypeSelectChanged(SuperMemory.Entities.CPileType curPileType)
        {
            biz().CurPileType = curPileType;
            if (biz().hasPiles())
            {
                this.enablePlayControllers();
            }
            else
            {
                this.unEnablePlayControllers();
            }
        }

        private void unEnablePlayControllers()
        {
            this.ucPlayController.Enabled = false;
        }

        private void enablePlayControllers()
        {
            this.ucPlayController.Enabled = true;
        }



        #endregion

        #region IPileOrderAreaSetObserver 成员
        /// <summary>
        /// 当前桩开始序号改变
        /// </summary>
        /// <param name="curOrderBegin"></param>
        void IPileOrderAreaSetObserver.onOrderBeginChanged(int curOrderBegin)
        {
            biz().PlayController.PlayCondition.PilesOrderAreaSet.iBeginOrderSet = curOrderBegin;
        }
        /// <summary>
        /// 当前桩结束序号改变
        /// </summary>
        /// <param name="curOrderEnd"></param>
        void IPileOrderAreaSetObserver.onOrderEndChanged(int curOrderEnd)
        {
            biz().PlayController.PlayCondition.PilesOrderAreaSet.iEndOrderSet = curOrderEnd;
        }

        #endregion

        private CPilesFlashCardGearBiz biz()
        {
            return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PilesFlashCardGear;
        }

        #region IObserver 成员

        void IObserver.notified(int eventId)
        {
            switch(eventId)
            {
            case CPlayController.EVENT_PLAY_STATE_CHANGED:
                this.onPlayStateChanged();
                break;
            }
        }



        #endregion

        #region 当前播放状态改变
        /// <summary>
        /// 当前播放状态改变
        /// </summary>
        private void onPlayStateChanged()
        {
            switch(biz().PlayController.PlayState)
            {
                case CPlayController.STATE_STOP:
                    this.onPlayStateStop();
                    break;
                case CPlayController.STATE_PLAYING:
                    this.onPlayStatePlaying();
                    break;
                case CPlayController.STATE_PAUSE:
                    this.onPlayStatePause();
                    break;
            }
        }

        private void onPlayStatePause()
        {
            this.ucPlayController.state2Pause();
            this.unEnablePlayConditionSets();
        }

        private void enablePlayConditonSets()
        {
            this.ucLeafPileTypesSelector.Enabled = true;
            this.ucPileOrderAreaSet.Enabled = true;
            this.ucPlayerGroupAmountSet.Enabled = true;
            this.ucPlayerOrderSet.Enabled = true;
            this.ucPlayerPrioritySet.Enabled = true;
            this.ucPlayIntervalSet.Enabled = true;
            this.ucTrainPeriodSet.Enabled = true;
        }

        private void onPlayStatePlaying()
        {
            this.ucPlayController.state2Playing();
            this.unEnablePlayConditionSets(); 
        }

        private delegate void onPlayStateStopDele();
        private void onPlayStateStop()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new onPlayStateStopDele(onPlayStateStop));
                return;
            }

            this.ucPlayController.state2Stop();

            this.enablePlayConditonSets();
        }

        private void unEnablePlayConditionSets()
        {
            this.ucLeafPileTypesSelector.Enabled = false;
            this.ucPileOrderAreaSet.Enabled = false;
            this.ucPlayerGroupAmountSet.Enabled = false;
            this.ucPlayerOrderSet.Enabled = false;
            this.ucPlayerPrioritySet.Enabled = false;
            this.ucPlayIntervalSet.Enabled = false;
            this.ucTrainPeriodSet.Enabled = false;
        }
        #endregion


        #region IPlayOrderSetObserver 成员
        /// <summary>
        /// 当前播放顺序改变
        /// </summary>
        /// <param name="curOrderState"></param>
        void IPlayOrderSetObserver.onPlayOrderStateChanged(int curOrderState)
        {
            biz().PlayController.PlayCondition.PlayOrderState = curOrderState;
        }

        #endregion

        #region IPlayPrioritySetObserver 成员

        void IPlayPrioritySetObserver.onPlayPriorityChanged(int curPlayPriority)
        {
            biz().PlayController.PlayCondition.PlayPriority = curPlayPriority;
        }

        #endregion

        #region IPlayGroupAmountSetObserver 成员

        void IPlayGroupAmountSetObserver.onPlayGroupAmountChanged(int curAmount)
        {
            biz().PlayController.PlayCondition.PlayGroupAmount = curAmount;

            switch (curAmount)
            {
                case UcPlayGroupAmountSet.VALUE_GROUP_AMOUNT_ONE:
                    switch2PileGroupOne();
                    break;
                case UcPlayGroupAmountSet.VALUE_GROUP_AMOUNT_TWO:
                    switch2PileGroupTwo();
                    break;
                case UcPlayGroupAmountSet.VALUE_GROUP_AMOUNT_THREE:
                    switch2PileGroupThree();
                    break;
            }
        }

        private void switch2PileGroupThree()
        {
            this.ucPileGroupOne.Visible = false;
            this.ucPileGroupTwo.Visible = false;
            this.ucPileGroupThree.Visible = true;

            biz().PlayController.PlayGroupController.View = this.ucPileGroupThree;
        }

        private void switch2PileGroupTwo()
        {
            this.ucPileGroupOne.Visible = false;
            this.ucPileGroupTwo.Visible = true;
            this.ucPileGroupThree.Visible = false;

            biz().PlayController.PlayGroupController.View = this.ucPileGroupTwo;
        }

        private void switch2PileGroupOne()
        {
            this.ucPileGroupOne.Visible = true;
            this.ucPileGroupTwo.Visible = false;
            this.ucPileGroupThree.Visible = false;

            biz().PlayController.PlayGroupController.View = this.ucPileGroupOne;
        }

        #endregion

        /// <summary>
        /// 训练时间
        /// </summary>
        /// <param name="curPeroid"></param>
        #region ITrainPeriodSetObserver 成员

        void ITrainPeriodSetObserver.onTrainPeroidChanged(int curPeroid)
        {
            biz().PlayController.PlayCondition.TrainPeriod = curPeroid;
        }

        #endregion
        /// <summary>
        /// 间隔时间
        /// </summary>
        /// <param name="curInterval"></param>
        #region IPlayIntervalSetObserver 成员

        void IPlayIntervalSetObserver.onPlayIntervalChanged(int curInterval)
        {
            biz().PlayController.PlayCondition.PlayInterval = curInterval;
        }

        #endregion

        #region IPlayControlObserver 成员

        void IPlayControlObserver.onPlayOrPauseClick()
        {
            biz().PlayController.playOrPause();
        }

        void IPlayControlObserver.onStopClick()
        {
            biz().PlayController.stop();
        }

        #endregion
    }
}
