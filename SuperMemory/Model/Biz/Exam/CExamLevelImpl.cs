using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Views;
using SuperMemory.Model.Utils;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamLevelImpl : IExamLevel
    {
        public CExamLevelImpl(IExamLevelInfo levelData)
        {
            this.levelData = levelData;
        }
        #region IExamLevel 成员

        void IExamLevel.firstGroup()
        {
            this.curGroupIndex = 0;
            this.updateCurGroup();
        }


        void IExamLevel.nextGroup()
        {
            this.curGroupIndex++;
            this.updateCurGroup();
        }

        bool IExamLevel.isLevelFinish()
        {
            return this.curGroupIndex == this.levelData.Goups.Count - 1;
        }

        IExamLevel1Group IExamLevel.CurGroup
        {
            get { return this.curGroup; }
        }

        /// <summary>
        /// 重置本组
        /// </summary>
        void IExamLevel.reset()
        {
            this.resetDo();
        }

        #endregion


        private void resetDo()
        {
            // 重新排序本关卡各组桩的顺序
            this.newRandLevelPiles();
            this.genGroupsData();
        }

        private void genGroupsData()
        {
            this.levelData.Goups = new CLevelGroupsDataGenerator().genDo(this.levelData.RandOrderPiles,this.levelData.OneGoupPilesNum);

        }


        private void newRandLevelPiles()
        {
            this.levelData.RandOrderPiles = CUtilFunctions.Inst.genRandOrderPilesList(this.levelData.PrimPiles);
        }

        private void updateCurGroup()
        {
            IExamLevel1GroupInfo groupData = this.levelData.getGroupByIndex(this.curGroupIndex);
            this.curGroup = new CExamLevel1GroupImpl(groupData);
            CViewsMgr.Inst.ExamView.updateGroupView(groupData);
        }

        private int curGroupIndex;
        private IExamLevel1Group curGroup;
        private IExamLevelInfo levelData;

    }
}
