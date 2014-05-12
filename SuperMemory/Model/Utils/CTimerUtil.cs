using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace SuperMemory.Model.Utils
{
    public class CTimerUtil
    {
        private const int TICK_PRIM = 50; 
        private static CTimerUtil inst = new CTimerUtil();

        public static CTimerUtil Inst
        {
            get { return CTimerUtil.inst; }
        }
        private CTimerUtil()
        {
            this.initAndStartMainTimer();
        }

        private void initAndStartMainTimer()
        {
            this.mainTimer = new Timer(TICK_PRIM);
            this.mainTimer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            this.mainTimer.Start();
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
        }

        private Timer mainTimer;

          
    }
}
