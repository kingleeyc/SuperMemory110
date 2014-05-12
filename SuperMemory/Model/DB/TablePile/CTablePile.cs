using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.DB.Common;
using System.Data;
using SuperMemory.Entities;

namespace SuperMemory.Model.DB.TablePile
{
    public class CTablePile : CDbBase
    {
        public const string TABLE_NAME = "pile";

        public const string FIELD_PILE_NUMBER = "pilenumber";
        public const string FIELD_PILE_PIC = "pilepic";
        public const string FIELD_PILE_WORD = "pileword";
        public const string FIELD_PILE_ROLE = "pilerole";
        public const string FIELD_PILE_ACTION = "pileaction";
        public const string FIELD_PRIM_ORDER = "primorder";
        public const string FIELD_PILE_TYPE_ID = "piletypeid";

        public const int ORDER_NUMBER_DOWN_LIMIT = 0;

        internal CPile loadPileByOrder(int order)
        {
            string sql = "select " + 
                this.fullFieldsSel() + 
                " from " + TABLE_NAME +
                " where " + FIELD_PRIM_ORDER + "=" + order;

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            return this.create1EntByDtAndRowIndex(dtRet, 0);

        }

        private string fullFieldsSel()
        {
            return  FIELD_PILE_NUMBER + "," + 
                FIELD_PILE_PIC + "," +
                FIELD_PILE_TYPE_ID + "," +
                FIELD_PILE_WORD + "," +
                FIELD_PILE_ROLE + "," +
                FIELD_PILE_ACTION + "," +
                FIELD_PRIM_ORDER ;
        }

        internal CPile loadPileByTypeIdAndOrder(string pileTypeId, int order)
        {
            string sql = "select " +
                this.fullFieldsSel() + 
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + pileTypeId + "' and " + 
                FIELD_PRIM_ORDER + "=" + order;

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            return this.create1EntByDtAndRowIndex(dtRet, 0);
        }

        internal CPile loadPileByTypeIdAndPileNumber(string pileTypeId, string pileNumber)
        {
            string sql = "select " +
                this.fullFieldsSel() + 
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + pileTypeId + "' and " +
                FIELD_PILE_NUMBER + "='" + pileNumber +"'";

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            return this.create1EntByDtAndRowIndex(dtRet, 0);
        }

        internal CPile loadPileByTypeIdAndPileWord(string pileTypeId, string pileWord)
        {
            string sql = "select " +
                this.fullFieldsSel() + 
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + pileTypeId + "' and " +
                FIELD_PILE_WORD + "='" + pileWord + "'";

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            if (dtRet.Rows.Count == 0)
            {
                return null;
            }

            return this.create1EntByDtAndRowIndex(dtRet, 0);
        }

        internal DataTable loadPilesByTypeId(string typeId)
        {
            string sql = "select " +
                this.fullFieldsSel() + 
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + typeId + "'" + 
                " order by " + FIELD_PRIM_ORDER;

            return this.loadEntsDtBySql(sql);
        }

        internal List<CPile> loadPilesEntByTypeId(string pileTypeId)
        {
            List<CPile> ret = new List<CPile>();
            DataTable dtRet = this.loadPilesByTypeId(pileTypeId);

            for (int i = 0; i < dtRet.Rows.Count;i++ )
            {
                ret.Add(this.create1EntByDtAndRowIndex(dtRet,i));
            }

            return ret;
        }

        private CPile create1EntByDtAndRowIndex(DataTable dtRet, int i)
        {
            CPile ret = new CPile();
            ret.PileNumber = dtRet.Rows[i][FIELD_PILE_NUMBER].ToString();
            ret.PileTypeId = dtRet.Rows[i][FIELD_PILE_TYPE_ID].ToString();
            ret.Pic = dtRet.Rows[i][FIELD_PILE_PIC].ToString();
            ret.Word = dtRet.Rows[i][FIELD_PILE_WORD].ToString();
            ret.Role = dtRet.Rows[i][FIELD_PILE_ROLE].ToString();
            ret.Action = dtRet.Rows[i][FIELD_PILE_ACTION].ToString();
            ret.PrimOrder = Int32.Parse(dtRet.Rows[i][FIELD_PRIM_ORDER].ToString());
            return ret;
        }

        internal int loadPilesLastOrderByTypeId(string pileTypeId)
        {
            int ret;
            string sql = "select max(" + FIELD_PRIM_ORDER + ") as " + FIELD_PRIM_ORDER +
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + pileTypeId + "'";
            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (null == dtRet)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (0 == dtRet.Rows.Count)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (dtRet.Rows[0][FIELD_PRIM_ORDER].ToString().Equals(""))
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else
            {
                ret = int.Parse(dtRet.Rows[0][FIELD_PRIM_ORDER].ToString());
            }

            return ret;
        }

        internal void saveNewEnt(CPile newEnt)
        {
            string sql = "insert into " + TABLE_NAME +
                " (" + 
                FIELD_PILE_NUMBER + "," + 
                FIELD_PILE_PIC + "," +
                FIELD_PILE_TYPE_ID + "," +
                FIELD_PILE_WORD + "," +
                FIELD_PILE_ROLE + "," +
                FIELD_PILE_ACTION + "," +
                FIELD_PRIM_ORDER +
                ") values(" +
                "'" + newEnt.PileNumber + "'," +
                "'" + newEnt.Pic + "'," +
                "'" + newEnt.PileTypeId + "'," +
                "'" + newEnt.Word + "'," +
                "'" + newEnt.Role + "'," +
                "'" + newEnt.Action + "'," + 
                newEnt.PrimOrder
                + 
                ")";

            this.exeNonQuerSql(sql);
        }

        internal void saveEntByPileNumberAndPileTypeId(CPile ent)
        {
            string sql = "update " + TABLE_NAME + " set " +
                FIELD_PILE_PIC + "='" + ent.Pic + "'," +
                FIELD_PILE_WORD + "='" + ent.Word + "'," +
                FIELD_PILE_ROLE + "='" + ent.Role + "'," + 
                FIELD_PILE_ACTION + "='" + ent.Action + "'," +
                FIELD_PRIM_ORDER + "=" + ent.PrimOrder + 
                " where " + FIELD_PILE_NUMBER + "='" + ent.PileNumber + "'" +
                " and " + FIELD_PILE_TYPE_ID + "='" + ent.PileTypeId + "'";
            this.exeNonQuerSql(sql);
        }






    }
}
