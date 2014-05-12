using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.DB.Common;
using SuperMemory.Entities;
using System.Data;

namespace SuperMemory.Model.DB.Exam
{
    public class CTableExam : CDbBase
    {
        public const string TABLE_NAME = "exam";

        public const string FIELD_EXAM_ID = "examid";
        public const string FIELD_EXAM_NAME = "examname";

        public List<CExam> loadAll()
        {
            string sql = this.getFullSel() + this.getFromTable() + "";

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            List<CExam> ret = new List<CExam>();

            for (int i = 0; i < dtRet.Rows.Count; i++)
            {
                ret.Add(this.create1EntByDtAndRowIndex(dtRet, i));
            }

            return ret;
        }

        private CExam create1EntByDtAndRowIndex(DataTable dtRet, int i)
        {
            CExam ret = new CExam();
            ret.ExamId = Int32.Parse(dtRet.Rows[i][FIELD_EXAM_ID].ToString());
            ret.ExamName = dtRet.Rows[i][FIELD_EXAM_NAME].ToString();
            return ret;
        }


        private string getFromTable()
        {
            return "select " + FIELD_EXAM_ID + "," + FIELD_EXAM_NAME + " ";
        }

        private string getFullSel()
        {
            return "from " + TABLE_NAME + " ";
        }

    }
}
