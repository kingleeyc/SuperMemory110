using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.DB.Common;
using SuperMemory.Entities;
using System.Data;

namespace SuperMemory.Model.DB.Exam
{
    public class CTableExamLevel : CDbBase
    {
        public const string TABLE_NAME = "examlevel";

        public const string FIELD_EXAM_ID = "examid";
        public const string FIELD_LEVEL_NAME = "levelname";
        public const string FIELD_LEVEL_ORDER = "levelorder";
        public const string FIELD_GROUP_PILES_NUM = "grouppilesnum";
        public const string FIELD_PILES_TYPE_ID = "pilestype";

        public List<CExamLevel> loadByExamId(int examId)
        {
            string sql = this.getFullSel() + this.getFromTable() + " where " + FIELD_EXAM_ID + "=" + examId;

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            List<CExamLevel> ret = new List<CExamLevel>();

            for (int i = 0; i < dtRet.Rows.Count; i++)
            {
                ret.Add(this.create1EntByDtAndRowIndex(dtRet, i));
            }

            return ret;
        }

        private CExamLevel create1EntByDtAndRowIndex(DataTable dtRet, int i)
        {
            CExamLevel ret = new CExamLevel();
            ret.ExamId = Int32.Parse(dtRet.Rows[i][FIELD_EXAM_ID].ToString());
            ret.LevelName = dtRet.Rows[i][FIELD_LEVEL_NAME].ToString();
            ret.LevelOrder = Int32.Parse(dtRet.Rows[i][FIELD_LEVEL_ORDER].ToString());
            ret.GroupPilesNum = Int32.Parse(dtRet.Rows[i][FIELD_GROUP_PILES_NUM].ToString());
            ret.PilesTypeId = dtRet.Rows[i][FIELD_PILES_TYPE_ID].ToString();
            return ret;
        }

        private string getFromTable()
        {
            return " from " + TABLE_NAME;
        }

        private string getFullSel()
        {
            return "select " + FIELD_EXAM_ID + "," + FIELD_LEVEL_NAME + "," + FIELD_LEVEL_ORDER + "," + FIELD_GROUP_PILES_NUM;
        }

    }
}
