using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamLevel
    {
        void firstGroup();
        void nextGroup();
        bool isLevelFinish();
        IExamLevel1Group CurGroup
        {
            get;
        }
        void reset();
    }
}
