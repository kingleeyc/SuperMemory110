using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public interface IExamDataLoader
    {
        IExamInfo loadById(int examId);
    }
}
