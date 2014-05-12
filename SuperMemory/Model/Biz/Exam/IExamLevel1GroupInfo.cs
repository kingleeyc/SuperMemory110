using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamLevel1GroupInfo
    {
        List<CPile> Piles
        {
            set;
            get;
        }

    }
}
