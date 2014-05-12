using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    public class CExamLevel
    {
        private int examId;

        public int ExamId
        {
            get { return examId; }
            set { examId = value; }
        }
        private string levelName;

        public string LevelName
        {
            get { return levelName; }
            set { levelName = value; }
        }
        private int levelOrder;

        public int LevelOrder
        {
            get { return levelOrder; }
            set { levelOrder = value; }
        }
        private int groupPilesNum;

        public int GroupPilesNum
        {
            get { return groupPilesNum; }
            set { groupPilesNum = value; }

        }

        private string pilesTypeId;

        public string PilesTypeId
        {
            get { return pilesTypeId; }
            set { pilesTypeId = value; }
        }

    }
}
