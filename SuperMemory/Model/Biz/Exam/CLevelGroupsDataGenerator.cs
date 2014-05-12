using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public class CLevelGroupsDataGenerator
    {
        public List<IExamLevel1GroupInfo> genDo(List<CPile> pilels,int oneGroupPilesNum)
        {
            this.oneGroupPilesNum = oneGroupPilesNum;
            this.genNew1GroupData();
            foreach (CPile pile in pilels)
            {
                this.genNewGroupData1Pile(pile);
            }

            return this.retGoups;
        }
        private void genNew1GroupData()
        {
            this.newGroupData = new CExamLevel1GroupInfoImpl();
            this.newGroupData.Piles = new List<CPile>();
            this.retGoups.Add(this.newGroupData);
        }

        private void genNewGroupData1Pile(CPile pile)
        {
            if (this.oneGroupPilesNum == this.newGroupData.Piles.Count)
            {
                this.genNew1GroupData();
            }
            this.newGroupData.Piles.Add(pile);
        }

        private int oneGroupPilesNum;
        private IExamLevel1GroupInfo newGroupData;
        private List<IExamLevel1GroupInfo> retGoups = new List<IExamLevel1GroupInfo>();
    }
}
