using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.Biz.Common;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamMgrBiz : I2PilesMatchVerifyResultObserver
    {
        private static CExamMgrBiz inst = new CExamMgrBiz();
        private CExamMgrBiz()
        {
            this.pilesPairMatchVerifier.ResultObserver = this;
           
        }

        public static CExamMgrBiz Inst
        {
            get
            {
                return inst;
            }
        }

        public void loadCurExamData()
        {
            this.examDataLoader.loadById(this.curExamId);
            this.levelsMgr = new CExamLevelsMgrImpl(this.curExamData);
        }
        public void beginExam()
        {
            this.beginExamDo();
        }

        #region 考试答题接口
        public CPile CurChosenPileLeft
        {
            set { this.pilesPairMatchVerifier.PileLeft = value; }
        }

        public CPile CurChosenPileRight
        {
            set { this.pilesPairMatchVerifier.PileRight = value; }
        }
        #endregion

        public int CurExamId
        {
            set { curExamId = value; }
        }
        

        #region I2PilesMatchVerifyResultObserver 成员
        // 匹配正确
        void I2PilesMatchVerifyResultObserver.onMatchRight()
        {
            this.levelsMgr.CurLevel.CurGroup.PassPileCount++;
              // 当前关卡当前组是否结束？
            if(this.levelsMgr.CurLevel.CurGroup.isGroupFinish())
            {
                this.onCurLevelCurGroupFinish();
            }
        }
        // 当前关卡，当前组结束
        private void onCurLevelCurGroupFinish()
        {
            // 是否当前关卡结束?
            if(this.levelsMgr.CurLevel.isLevelFinish())
            {
                this.onCurLevelFinish();
            }else
            {
                // 当前关卡下一组
                this.levelsMgr.CurLevel.nextGroup();
            }
        }

        // 当前关卡结束
        private void onCurLevelFinish()
        {
            // 是否考试结束
            if(this.isExamFinish())
            {
                this.onExamFinish();
            }else
            {
                // 下一关卡
                this.levelsMgr.nextLevel();
            }
        }

        void I2PilesMatchVerifyResultObserver.onMatchFault()
        {
            //throw new Exception("The method or operation is not implemented.");
            // 当前关当前题（组）重置（重新随机排序）
            // 提示答错，当前关卡重置
            this.promptAnswerFaultRetryCurLevel();

            //回到第一组，重置随机生成所有组
            this.levelsMgr.CurLevel.reset();
            // 当前关卡重置：得分清零，重新随机关卡所有桩，开始第一组桩
        }

        #endregion
        /// <summary>
        /// 提示回答错误，本关卡重新开始
        /// </summary>
        private void promptAnswerFaultRetryCurLevel()
        {
            throw new Exception("The method or operation is not implemented.");
        }
        /// <summary>
        /// 考试结束
        /// </summary>
        private void onExamFinish()
        {
            throw new Exception("The method or operation is not implemented.");
        }
        /// <summary>
        /// 是否考试结束
        /// </summary>
        /// <returns></returns>
        private bool isExamFinish()
        {
            return this.levelsMgr.isExamFinish();
        }
        
        private void beginExamDo()
        {
            // 第一关
            this.levelsMgr.firstLevel();
        }


        /// <summary>
        /// ////////////////////////////////////////
        /// </summary>

        private I2PilesMatchVerifier pilesPairMatchVerifier = new C2PilesMatchVerifierImpl();

        private IExamLevelsMgr levelsMgr;
        private IExamInfo curExamData = null;
        private IExamDataLoader examDataLoader = new CExamDataLoaderImpl();
        private int curExamId;


    }
}
