using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamInfo
    {
        int ExamId
        {
            set;
            get;
        }
        string ExamName
        {
            get;
            set;
        }
        int LevelsCount
        {
            get;
        }
        List<IExamLevelInfo> Levels
        {
            set;
        }
        IExamLevelInfo getLevelByIndex(int levelIndex);
    }
}
