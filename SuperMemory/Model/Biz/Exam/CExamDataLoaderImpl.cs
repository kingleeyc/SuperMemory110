using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Model.DB.Exam;
using SuperMemory.Model.Utils;
using SuperMemory.Model.DB.TablePile;

namespace SuperMemory.Model.Biz.Exam
{
    public class CExamDataLoaderImpl : IExamDataLoader
    {
        #region IExamDataLoader 成员

        IExamInfo IExamDataLoader.loadById(int examId)
        {
            IExamInfo ret = new CExamInfoImpl();

            ret.Levels = this.loadExamLevels(examId);

            return ret;
        }

        #endregion


        private List<IExamLevelInfo> loadExamLevels(int examId)
        {
            List<IExamLevelInfo> ret = new List<IExamLevelInfo>();

            List<CExamLevel> ents = this.loadLevelEnts(examId);
            foreach(CExamLevel lv in ents)
            {
                ret.Add(this.create1LvInfoByEnt(lv));
            }
            return ret;
        }

        private IExamLevelInfo create1LvInfoByEnt(CExamLevel lvEnt)
        {
            IExamLevelInfo ret = new CExamLevelInfoImpl();
            ret.ExamId = lvEnt.ExamId;
            ret.LevelName = lvEnt.LevelName;
            ret.LevelOrder = lvEnt.LevelOrder;
            ret.OneGoupPilesNum = lvEnt.GroupPilesNum;
            ret.PilesTypeId = lvEnt.PilesTypeId;
            ret.PrimPiles = this.loadPilesByeTypeId(lvEnt.PilesTypeId);
            ret.RandOrderPiles = CUtilFunctions.Inst.genRandOrderPilesList(ret.PrimPiles);
            ret.Goups = new CLevelGroupsDataGenerator().genDo(ret.RandOrderPiles,ret.OneGoupPilesNum);
            return ret;
        }

        private List<CPile> loadPilesByeTypeId(string typeId)
        {
            return new CTablePile().loadPilesEntByTypeId(typeId);
        }

        private List<CExamLevel> loadLevelEnts(int examId)
        {
            return new CTableExamLevel().loadByExamId(examId);
        }
    }
}
