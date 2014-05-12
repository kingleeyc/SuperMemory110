using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamView
    {
        void updateLevelView(IExamLevelInfo levelData);

        void updateGroupView(IExamLevel1GroupInfo groupData);
    }
}
