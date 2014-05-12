using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamLevel1GroupImpl : IExamLevel1Group
    {
        public CExamLevel1GroupImpl(IExamLevel1GroupInfo groupData)
        {
            this.groupData = groupData;
        }

        #region IExamLevel1Group 成员

        bool IExamLevel1Group.isGroupFinish()
        {
            return this.passPileCount == this.groupData.Piles.Count;
        }
        int IExamLevel1Group.PassPileCount
        {
            get
            {
                return this.passPileCount;
            }
            set
            {
                this.passPileCount = value;
            }
        }
        #endregion

        private int passPileCount = 0;
        private IExamLevel1GroupInfo groupData;
          
    }
}
