using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Views;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamLevelsMgrImpl : IExamLevelsMgr
    {
        public CExamLevelsMgrImpl(IExamInfo examData)
        {
            this.examData = examData;
        }

        #region IExamLevelsMgr 成员

        void IExamLevelsMgr.firstLevel()
        {
            this.curLevelIndex = 0;
            this.updateCurLevel();
        }

        void IExamLevelsMgr.nextLevel()
        {
            this.curLevelIndex++;
            this.updateCurLevel();
        }

        bool IExamLevelsMgr.isExamFinish()
        {
            return this.curLevelIndex == this.examData.LevelsCount - 1;
        }

        IExamLevel IExamLevelsMgr.CurLevel
        {
            get { return this.curLevel; }
        }

        #endregion

        private void updateCurLevel()
        {
            IExamLevelInfo levelData = this.examData.getLevelByIndex(this.curLevelIndex);
            this.curLevel = new CExamLevelImpl(levelData);

            // 主要是更新关卡名称（第几关...）
            CViewsMgr.Inst.ExamView.updateLevelView(levelData);

            this.curLevel.firstGroup();
        }


        private int curLevelIndex;
        private IExamInfo examData;
        private IExamLevel curLevel;


    }
}
