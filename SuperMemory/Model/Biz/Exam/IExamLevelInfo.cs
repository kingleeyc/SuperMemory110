using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamLevelInfo
    {
        IExamLevel1GroupInfo getGroupByIndex(int groupIndex);

        List<CPile> PrimPiles
        {
            set;
            get;
        }
        List<CPile> RandOrderPiles
        {
            set;
            get;
        }
        int OneGoupPilesNum
        {
            set;
            get;
        }

        List<IExamLevel1GroupInfo> Goups
        {
            set;
            get;
        }

        int ExamId
        {
            set;
            get;
        }

        string LevelName
        {
            set;
            get;
        }

        int LevelOrder
        {
            set;
            get;
        }

        string PilesTypeId
        {
            set;
            get;
        }

    }
}
