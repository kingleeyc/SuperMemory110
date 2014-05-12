using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    public class CPicChoiceMeaningReport
    {
        private int totalQuestionsAmount;

        public int TotalQuestionsAmount
        {
            get { return totalQuestionsAmount; }
            set { totalQuestionsAmount = value; }
        }
        private int correctAmount;

        public int CorrectAmount
        {
            get { return correctAmount; }
            set { correctAmount = value; }
        }
        private int errAmout;

        public int ErrAmout
        {
            get { return errAmout; }
            set { errAmout = value; }
        }
        private int totalSecUsed;

        public int TotalSecUsed
        {
            get { return totalSecUsed; }
            set { totalSecUsed = value; }
        }
        private string reportDateTime;

        public string ReportDateTime
        {
            get { return reportDateTime; }
            set { reportDateTime = value; }
        }
    }
}
