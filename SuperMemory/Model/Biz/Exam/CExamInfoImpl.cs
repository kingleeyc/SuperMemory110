using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamInfoImpl : IExamInfo
    {
        #region IExamInfo 成员


        IExamLevelInfo IExamInfo.getLevelByIndex(int levelIndex)
        {
            return this.levels[levelIndex];
        }

        int IExamInfo.LevelsCount
        {
            get {

                return this.levels.Count;
            }
        }


        List<IExamLevelInfo> IExamInfo.Levels
        {
            set { levels = value; }
        }

        #endregion

        private List<IExamLevelInfo> levels;



        #region IExamInfo 成员

        int IExamInfo.ExamId
        {
            get
            {
                return this.examId;
            }
            set
            {
                this.examId = value;
            }
        }
        private int examId;

        string IExamInfo.ExamName
        {
            get
            {
                return this.examName;
            }
            set
            {
                this.examName = value;
            }
        }
        private string examName;
        #endregion
    }
}
