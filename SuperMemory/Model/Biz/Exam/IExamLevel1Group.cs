using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamLevel1Group
    {
        bool isGroupFinish();
        int PassPileCount
        {
            set;
            get;
        }
    }
}
