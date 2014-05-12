using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamLevel1GroupInfoImpl : IExamLevel1GroupInfo
    {

        #region IExamLevel1GroupInfo ≥…‘±

        List<CPile> IExamLevel1GroupInfo.Piles
        {
            get
            {
                return this.piles;
            }
            set
            {
                this.piles = value;
            }
        }

        #endregion

        private List<CPile> piles;
    }
}
