using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl.PlayGroupControl
{
    public class CPlayStepController
    {
        private const int STEP_INDEX_MIN = -1;
        private const int STEP_INDEX_MAX = 4;
        private const int STEPS_AMOUNT = 5;

        public CPlayStepController(CPlayController playController)
        {
            this.playController = playController;
            this.initSteps();
        }

        private void initSteps()
        {
            this.steps = new EnumPlayPileSteps[STEPS_AMOUNT];
            this.steps[0] = EnumPlayPileSteps.Number;
            this.steps[1] = EnumPlayPileSteps.Pic;
            this.steps[2] = EnumPlayPileSteps.Word;
            this.steps[3] = EnumPlayPileSteps.Role;
            this.steps[4] = EnumPlayPileSteps.Action;
        }
        internal bool isStepsFinished()
        {
            return this.curStepIndex == STEP_INDEX_MAX;
        }

        internal void reset()
        {
            this.curStepIndex = STEP_INDEX_MIN;
        }

        internal void nextStep()
        {
            this.curStepIndex++;
        }


        public int CurStep
        {
            get { 
                return (int)steps[this.curStepIndex]; 
            }
        }

        private CPlayController playController;
        private EnumPlayPileSteps[] steps;
        private int curStepIndex;




    }
}
