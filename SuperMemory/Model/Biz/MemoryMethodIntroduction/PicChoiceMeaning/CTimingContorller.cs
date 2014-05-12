using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    class CTimingContorller
    {
        private const int GROUP_COUNTDOWN_SEC_INIT = 20;
        private const int TRAINNING_SEC_PASS_INIT = 0;

        public CTimingContorller(ITimingControllerObserver ob)
        {
            this.ob = ob;

            this.timerTrainningTiming.Elapsed += new ElapsedEventHandler(timerTrainningTiming_Elapsed);
            this.timerGroupCountdown.Elapsed += new ElapsedEventHandler(timerGroupCountdown_Elapsed);

            this.resetTiming();
            this.resetCountdown();

        }

        public void resetCountdown()
        {
            this.groupSecLast = GROUP_COUNTDOWN_SEC_INIT;
            this.updateCountdownView();
        }

        public void resetTiming()
        {
            this.trainingSecPass = TRAINNING_SEC_PASS_INIT;
            this.updateTimingView();
        }

        void timerGroupCountdown_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.groupSecLast--;
            
            updateCountdownView();

            if (0 == this.groupSecLast)
            {
                onCountdownZero();
            }
        }

        private void onCountdownZero()
        {
            if(null == this.ob)
            {
                return;
            }
            this.groupCountdownStop();
            this.ob.onCountdownZero();
        }

        private void updateCountdownView()
        {
            if(null == this.groupCountDownView)
            {
                return;
            }
            this.groupCountDownView.setSec(this.groupSecLast);
        }

        void timerTrainningTiming_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.trainingSecPass++;
            updateTimingView();
        }

        private void updateTimingView()
        {
            if(null == this.trainningTimingView)
            {
                return;
            }
            this.trainningTimingView.setSec(this.TrainingSecPass);
        }
        internal void trainningTimingStart()
        {
            this.resetTiming();
            this.timerTrainningTiming.Start();
        }

        internal void groupCountdownStart()
        {
            this.resetCountdown();
            this.timerGroupCountdown.Start();                        
        }



        internal void trainningTimingStop()
        {
            this.timerTrainningTiming.Stop();

        }

        internal void groupCountdownStop()
        {
            this.timerGroupCountdown.Stop();
            
        }

        private int trainingSecPass;

        public int TrainingSecPass
        {
            get { return trainingSecPass; }
        }
        private int groupSecLast;


        private Timer timerTrainningTiming = new Timer(1000);
        private Timer timerGroupCountdown = new Timer(1000);

        private ISecTickerView groupCountDownView;

        public ISecTickerView GroupCountDownView
        {
            set { groupCountDownView = value; }
        }

        private ISecTickerView trainningTimingView;

        public ISecTickerView TrainningTimingView
        {
            set { trainningTimingView = value; }
        }

        private ITimingControllerObserver ob;

    }
}
