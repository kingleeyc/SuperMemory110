using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    public class CExam
    {
        private int examId;

        public int ExamId
        {
            get { return examId; }
            set { examId = value; }
        }
        private string examName;

        public string ExamName
        {
            get { return examName; }
            set { examName = value; }
        }
    }
}
