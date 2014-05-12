using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Common
{
    public class CTrainningResult
    {
        public void reset()
        {
            this.correctCount = 0;
            this.errCount = 0;
            this.view.updateErrCount(this.errCount);
            this.view.updateCrrtCount(this.correctCount);
        }

        public void newErr()
        {
            this.errCount++;
            this.view.updateErrCount(this.errCount);
        }

        public void newCorrect()
        {
            this.correctCount++;
            this.view.updateCrrtCount(this.correctCount);
        }

        public int ErrCount
        {
            get
            {
                return this.errCount;
            }
        }
        private int errCount;

        public int CorrectCount
        {
            get
            {
                return this.correctCount;
            }
        }
        private int correctCount;

        public ITrainningResultView View
        {
            set
            {
                this.view = value;
            }
        }
        private ITrainningResultView view;
    }
}
