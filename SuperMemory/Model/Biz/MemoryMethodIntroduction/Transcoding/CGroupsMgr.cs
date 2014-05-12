using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Entities;
using SuperMemory.Model.Utils;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding
{
    class CGroupsMgr : IGroupsMgr
    {
        private const int GROUP_NUM = 4;

        #region IGroupsMgr 成员

        void IGroupsMgr.resetCurGroup()
        {
            this.nPileIdxInCurGroup = 1;

            List<CPile> tempPiles = new List<CPile>(this.curAskGroupPiles.ToArray());

            this.curAskGroupPiles = CUtilFunctions.Inst.genRandOrderPilesList(tempPiles);
            this.curAnswerGroupPiles = CUtilFunctions.Inst.genRandOrderPilesList(this.curAskGroupPiles);

            this.updateGroupPiles2View();
        }

        void IGroupsMgr.nextPileInCurGroup()
        {
            this.nPileIdxInCurGroup++;
        }

        bool IGroupsMgr.isCurGroupFinish()
        {
            if (this.nPileIdxInCurGroup <= this.getCurGroupRealPilesCount())
            {
                return false;
            }
            return true;
        }

        private int getCurGroupRealPilesCount()
        {
            int ret = 0;
            for (int i = 0; i < GROUP_NUM;i++ )
            {
                if(this.curAskGroupPiles[i] != null)
                {
                    ret++;
                }
            }
            return ret;
        }

        void IGroupsMgr.nextGroup()
        {
            this.nextGroupPiles();
            this.beginCurGroup();
        }

        ITranscodingPanel IGroupsMgr.TranscodingPanel
        {
            get
            {
                return trancodingPanel;
            }
            set
            {
                trancodingPanel = value;
            }
        }
        ITranscodingPanel trancodingPanel;

        IPileGroupView IGroupsMgr.AskPilesGroupView
        {
            get
            {
                return askPilesGroupView;
            }
            set
            {
                askPilesGroupView = value;
            }
        }
        private IPileGroupView askPilesGroupView;

        IPileGroupView IGroupsMgr.AnswerPilesGroupView
        {
            get
            {
                return answerPilesGroupView;
            }
            set
            {
                answerPilesGroupView = value;
            }
        }
        private IPileGroupView answerPilesGroupView;

        IPilesMgr IGroupsMgr.PilesMgr
        {
            set { pilesMgr = value; }
        }
        private IPilesMgr pilesMgr;
        #endregion



        private void updateGroupPiles2View()
        {
            for (int i = 0; i < GROUP_NUM; i++)
            {
                this.fill1Pile2AskGroupView(i);
                this.fill1Pile2AnswerGroupView(i);
            }
        }

        
        private void beginCurGroup()
        {
            this.nPileIdxInCurGroup = 1;
        }

        /// <summary>
        /// 下一组桩
        /// </summary>
        private void nextGroupPiles()
        {
            this.cleanGroupView();
            // 在洗牌后的集里，按顺序取一组
            this.curAskGroupPiles.Clear();
            this.curAnswerGroupPiles.Clear();

            for (int i = 0; i < GROUP_NUM; i++)
            {
                this.curGroupAddNextPile();
            }
            this.curAnswerGroupPiles = CUtilFunctions.Inst.genRandOrderPilesList(this.curAskGroupPiles);
            this.updateGroupPiles2View();
        }

        private void cleanGroupView()
        {
            this.askPilesGroupView.cleanState();
            this.answerPilesGroupView.cleanState();
        }

        private void curGroupAddNextPile()
        {
            this.curAskGroupPiles.Add(this.pilesMgr.nextPileInRandOrderPrimPiles());
        }

        private void fill1Pile2AnswerGroupView(int i)
        {
            this.answerPilesGroupView.fill1PileData(this.curAnswerGroupPiles.ToArray()[i], i);
        }

        private void fill1Pile2AskGroupView(int i)
        {
            this.askPilesGroupView.fill1PileData(this.curAskGroupPiles.ToArray()[i], i);
        }


 

        private List<CPile> curAskGroupPiles = new List<CPile>();
        private List<CPile> curAnswerGroupPiles = new List<CPile>();
        private int nPileIdxInCurGroup = 1;


    }
}
