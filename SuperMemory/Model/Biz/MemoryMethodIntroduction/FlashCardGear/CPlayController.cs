using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Partten.Observer;
using SuperMemory.Entities;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet;
using System.Timers;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress;
using SuperMemory.Model.Biz.Common.PileForwardOrderControl;
using SuperMemory.Model.Biz.Common.PileForwardPlayer;


namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear
{
    public class CPlayController : CPileForwardPlayerBase
    {
        public const int STATE_STOP = 1;
        public const int STATE_PLAYING = 2;
        public const int STATE_PAUSE = 3;

        public const int EVENT_PLAY_STATE_CHANGED = 21;

        private const int PROGRESS_UPDATE_TICK = 10;
          

        public CPlayController()
        {
            this.playGroupController = new CPlayGroupController(this);

            this.progressTimer = new Timer(PROGRESS_UPDATE_TICK);
            this.progressTimer.Elapsed += new ElapsedEventHandler(progressTimer_Elapsed);
            this.progressTimer.Start();
        }

        void progressTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.updateTranningProgress();
            this.updateStepProgress();
        }


        protected override int getConcreteFirstPileOrder()
        {
            return this.playCondition.PilesOrderAreaSet.getFirstOrder();
        }


        protected override int getConcreteLastPileOrder()
        {
            return this.playCondition.PilesOrderAreaSet.getLastOrder();
        }


        #region 接口们
        /// <summary>
        /// 播放或暂停
        /// </summary>
        internal void playOrPause()
        {
            switch(this.PlayState)
            {
                case STATE_STOP:
                    this.playBegin();
                    break;
                case STATE_PLAYING:
                    this.pause();
                    break;
                case STATE_PAUSE:
                    this.playContinue();
                    break;
            }
        }
        /// <summary>
        /// 停止
        /// </summary>
        internal void stop()
        {
            this.PlayState = STATE_STOP;
            // 销毁播放
            this.destroyPlay();
        }


        /// <summary>
        /// 练习时间进度显示
        /// </summary>
        /// <param name="ucTraningProgresser"></param>
        internal void setTranningProgressView(IProgresser traningProgresser)
        {
            this.traningProgresser = traningProgresser;
        }
        /// <summary>
        /// 间隔进度显示
        /// </summary>
        /// <param name="stepProgresser"></param>
        internal void setStepProgressView(IProgresser stepProgresser)
        {
            this.stepProgresser = stepProgresser;
        }



        private IProgresser traningProgresser;
        private IProgresser stepProgresser;
        #endregion

        #region 更新序号上下限
        /// <summary>
        /// 更新序号上下限
        /// </summary>
        protected override void updatePilesPrimOrderLimit()
        {
            this.playCondition.PilesOrderAreaSet.iPilePrimOrderMin = this.getPilesMinPrimOrder();
            this.playCondition.PilesOrderAreaSet.iPilePrimOrderMax = this.getPilesMaxPrimOrder();
        }


        #endregion

        #region 播放控制
        /// <summary>
        /// 继续播放
        /// </summary>
        private void playContinue()
        {
            this.PlayState = STATE_PLAYING;
        }
        /// <summary>
        /// 暂停播放
        /// </summary>
        private void pause()
        {
            this.PlayState = STATE_PAUSE;
        }
        /// <summary>
        /// 开始播放
        /// </summary>
        private void playBegin()
        {
            // 创建播放
            this.createPlay();
            this.PlayState = STATE_PLAYING;
        }
        /// <summary>
        /// 创建播放
        /// </summary>
        private void createPlay()
        {
            this.beginTranning();

            this.PlayGroupController.reset();
            this.PlayGroupController.firstGroup();

            this.tranningTimer = new Timer(this.PlayCondition.PlayInterval);
            this.tranningTimer.Elapsed += new ElapsedEventHandler(tranningTimer_Elapsed);
            this.tranningTimer.Start();
        }

        private void beginTranning()
        {
            this.tranningMilliSecPass = 0;
        }

        void tranningTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.onTranningTimerTick();
        }
        /// <summary>
        /// 销毁播放
        /// </summary>
        private void destroyPlay()
        {
            this.tranningTimer.Stop();
            this.tranningTimer.Dispose();
            this.tranningTimer = null;
        }

        private int tranningMilliSecPass;

        #endregion

        /// <summary>
        /// 一个时钟周期
        /// </summary>
        private void onTranningTimerTick()
        { 
            if(this.playState == STATE_PAUSE)
            {
                return;
            }

            if(this.isTranningTimeOver())
            {
                this.onTranningTimeOver();
                return;
            }

            if (this.playGroupController.isStepsFinished())
            {
                // 下一组桩
                this.playGroupController.nextGroup();
            }else{
                // 下一步
                this.playGroupController.nextStep();
                this.onStepPass();
            }

            this.updateTranningTime();
            
        }

        private void onStepPass()
        {
            this.stepMilliSecPass = 0;
        }
        /// <summary>
        /// 步内毫秒消耗
        /// </summary>
        private int stepMilliSecPass = 0;
        private void updateTranningTime()
        {
            this.tranningMilliSecPass += this.playCondition.PlayInterval;
            
        }

        private void updateTranningProgress()
        {
            if (this.playState != STATE_PLAYING)
            {
                return;
            }
            if(null != this.traningProgresser)
            {
                this.traningProgresser.updateProgress((int)((float)this.tranningMilliSecPass / (float)this.getTranningPeroidMilliSec() * 100));
            }
        }

        private void updateStepProgress()
        {
            if (this.playState != STATE_PLAYING)
            {
                return;
            }
            if(null == this.stepProgresser)
            {
                return;
            }
            this.stepMilliSecPass += PROGRESS_UPDATE_TICK;
            this.stepProgresser.updateProgress(this.getStepProgressValue());
        }

        private int getStepProgressValue()
        {
            return (int)((float)this.stepMilliSecPass / (float)this.PlayCondition.PlayInterval * 100);
        }

        private bool isTranningTimeOver()
        {
            return this.tranningMilliSecPass > this.getTranningPeroidMilliSec();
        }

        private int getTranningPeroidMilliSec()
        {
            return this.playCondition.TrainPeriod * 60 * 1000;
        }

        private void onTranningTimeOver()
        {
            this.stop();
        }
        


        #region 数据们
        private CPlayCondition playCondition = new CPlayCondition();

        public CPlayCondition PlayCondition
        {
            get { return playCondition; }
        }

        private int playState = STATE_STOP;

        public int PlayState
        {
            get { return playState; }
            set { 
                playState = value;
                notifyAllObservers(EVENT_PLAY_STATE_CHANGED);
            }
        }

      
        #endregion

        
        private CPlayGroupController playGroupController;

        public CPlayGroupController PlayGroupController
        {
            get { return playGroupController; }
        }
        

        private Timer tranningTimer;
        private Timer progressTimer;






    }
}
