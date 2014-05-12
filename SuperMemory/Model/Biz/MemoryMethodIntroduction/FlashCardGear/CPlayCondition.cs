using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear
{
    public class CPlayCondition
    {
        private CPilesOrderAreaSet pilesOrderAreaSet = new CPilesOrderAreaSet();

        public CPilesOrderAreaSet PilesOrderAreaSet
        {
            get { return pilesOrderAreaSet; }
        }

        private int playOrderState;

        public int PlayOrderState
        {
            get { return playOrderState; }
            set { playOrderState = value; }
        }
        private int playPriority;

        public int PlayPriority
        {
            get { return playPriority; }
            set { playPriority = value; }
        }
        private int playGroupAmount;

        public int PlayGroupAmount
        {
            get { return playGroupAmount; }
            set { playGroupAmount = value; }
        }
        private int trainPeriod;

        public int TrainPeriod
        {
            get { return trainPeriod; }
            set { trainPeriod = value; }
        }
        private int playInterval;

        public int PlayInterval
        {
            get { return playInterval; }
            set { playInterval = value; }
        }
    }
}
