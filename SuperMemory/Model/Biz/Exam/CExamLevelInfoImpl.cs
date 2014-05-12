using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamLevelInfoImpl : IExamLevelInfo
    {
        #region IExamLevelInfo 成员

        IExamLevel1GroupInfo IExamLevelInfo.getGroupByIndex(int groupIndex)
        {
            return this.groups[groupIndex];
        }

        List<SuperMemory.Entities.CPile> IExamLevelInfo.PrimPiles
        {
            get
            {
                return this.primPiles;
            }
            set
            {
                this.primPiles = value;
            }
        }
        private List<SuperMemory.Entities.CPile> primPiles;

        List<SuperMemory.Entities.CPile> IExamLevelInfo.RandOrderPiles
        {
            get
            {
                return this.randOrderPiles;
            }
            set
            {
                this.randOrderPiles = value;
            }
        }
        private List<SuperMemory.Entities.CPile> randOrderPiles;

        int IExamLevelInfo.OneGoupPilesNum
        {
            get
            {
                return this.oneGroupPilesNum ;
            }
            set
            {
                this.oneGroupPilesNum = value;
            }
        }
        private int oneGroupPilesNum;
        List<IExamLevel1GroupInfo> IExamLevelInfo.Goups
        {
            get
            {
                return this.groups;
            }
            set
            {
                this.groups = value;
            }
        }
        private List<IExamLevel1GroupInfo> groups;
        #endregion

        #region IExamLevelInfo 成员
        int IExamLevelInfo.ExamId
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

        string IExamLevelInfo.LevelName
        {
            get
            {
                return this.levelName;
            }
            set
            {
                this.levelName = value;
            }
        }
        private string levelName;

        int IExamLevelInfo.LevelOrder
        {
            get
            {
                return this.levelOrder;
            }
            set
            {
                this.levelOrder = value;
            }
        }
        private int levelOrder;
 
        string IExamLevelInfo.PilesTypeId
        {
            get
            {
                return this.pilesTypeId;
            }
            set
            {
                this.pilesTypeId = value;
            }
        }
        private string pilesTypeId;
        #endregion
    }
}
