using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.Exam;

namespace SuperMemory.Views
{
    public class CViewsMgr
    {
        private static CViewsMgr inst = new CViewsMgr();
        private CViewsMgr() { }
        public static CViewsMgr Inst
        {
            get
            {
                return inst;
            }
        }

        public IExamView ExamView
        {
            set
            {
                this.examView = value;
            }
            get
            {
                return this.examView;
            }
        }
        private IExamView examView;
    }
}
