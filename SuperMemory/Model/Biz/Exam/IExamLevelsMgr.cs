using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamLevelsMgr
    {
        void firstLevel();
        void nextLevel();
        bool isExamFinish();
        IExamLevel CurLevel
        {
            get;
        }


        
    }
}
