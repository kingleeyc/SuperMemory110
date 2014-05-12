using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Model.DB.Common;
using SuperMemory.Entities;
using System.Data;

namespace SuperMemory.Model.DB.TablePileType
{
    public class CTablePileType : CDbBase
    {
        public const string TABLE_NAME = "piletype";

        public const string FIELD_PILE_TYPE_ID = "piletypeid";
        public const string FIELD_PILE_TYPE_NAME = "piletypename";
        public const string FIELD_PARENT_TYPE_ID = "parenttypeid";
        public const string FIELD_IS_LEAF = "isleaf";
        public const string FIELD_TYPE_ORDER = "typeorder";

        public const int ORDER_NUMBER_DOWN_LIMIT = 0;

        internal CPileType loadEntById(string id)
        {
            string sql = "select " + FIELD_PILE_TYPE_ID + "," +
                FIELD_PILE_TYPE_NAME + "," +
                FIELD_PARENT_TYPE_ID + "," +
                FIELD_IS_LEAF + "," +
                FIELD_TYPE_ORDER + 
                " from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + id + "'";

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
        /// <summary>
        /// 加载所有叶子类别信息描述： id, name
        /// </summary>
        /// <returns></returns>
        internal DataTable loadAllLeafTypesDesc()
        {
            string sql = "select " + FIELD_PILE_TYPE_ID + "," +
               FIELD_PILE_TYPE_NAME +
               " from " + TABLE_NAME +
               " where " + FIELD_PARENT_TYPE_ID +
               " in (select " +
               FIELD_PILE_TYPE_ID +
               " from " + TABLE_NAME +
               " where not " + FIELD_IS_LEAF + 
               " order by " + FIELD_TYPE_ORDER +
               ") and " + FIELD_IS_LEAF + 
               " order by " + FIELD_TYPE_ORDER;

            return this.loadEntsDtBySql(sql);

        }
        /// <summary>
        /// 所有非叶子类别信息描述：id,name
        /// </summary>
        /// <returns></returns>
        internal DataTable loadAllParentTypesDesc()
        {
            string sql = "select " + FIELD_PILE_TYPE_ID + "," +
               FIELD_PILE_TYPE_NAME +
               " from " + TABLE_NAME +
               " where not " + FIELD_IS_LEAF + 
               " order by " + FIELD_TYPE_ORDER;

            return this.loadEntsDtBySql(sql);
        }
        /// <summary>
        /// 所有非叶子类别实体们
        /// </summary>
        /// <returns></returns>
        internal List<CPileType> laodAllParentTypeEnts()
        {
            string sql = "select " + FIELD_PILE_TYPE_ID + "," +
                FIELD_PILE_TYPE_NAME + "," +
                FIELD_PARENT_TYPE_ID + "," +
                FIELD_IS_LEAF + "," +
                FIELD_TYPE_ORDER + 
                " from " + TABLE_NAME +
                " where not " + FIELD_IS_LEAF +
                " order by " + FIELD_TYPE_ORDER;

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            //if (dtRet.Rows.Count == 0)
            //{
            //    return null;
            //}

            List<CPileType> ret = new List<CPileType>();
            for (int i = 0; i < dtRet.Rows.Count;i++ )
            {
                ret.Add(this.create1EntByDtAndRowIndex(dtRet, i));
            }
            return ret;

        }
        /// <summary>
        /// 某个非叶类别的子类别实体们
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        internal List<CPileType> load1ParentAllChildrenEnts(string parentId)
        {
            string sql = "select " + FIELD_PILE_TYPE_ID + "," +
                FIELD_PILE_TYPE_NAME + "," +
                FIELD_PARENT_TYPE_ID + "," +
                FIELD_IS_LEAF + "," +
                FIELD_TYPE_ORDER +
                " from " + TABLE_NAME +
                " where " + FIELD_PARENT_TYPE_ID + "='" + parentId + "'" + 
                " order by " + FIELD_TYPE_ORDER;

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (dtRet == null)
            {
                return null;
            }

            //if (dtRet.Rows.Count == 0)
            //{
            //    return null;
            //}

            List<CPileType> ret = new List<CPileType>();
            for (int i = 0; i < dtRet.Rows.Count; i++)
            {
                ret.Add(this.create1EntByDtAndRowIndex(dtRet, i));
            }
            return ret;
        }

        internal void saveNewEnt(CPileType newEnt)
        {
            string sql = "insert into " + TABLE_NAME + "(" + FIELD_PILE_TYPE_ID +
              "," + FIELD_PARENT_TYPE_ID +
              "," + FIELD_PILE_TYPE_NAME +
              "," + FIELD_TYPE_ORDER +
              "," + FIELD_IS_LEAF + ") values('" + newEnt.PileTypeId + "'" +
              ",'" + newEnt.ParentTypeId + "'" +
              ",'" + newEnt.PileTypeName + "'" +
              "," + newEnt.TypeOrder +
              ",'" + this.bool2intStr(newEnt.IsLeaf) + "')";

            this.exeNonQuerSql(sql);
        }


        /// <summary>
        /// 非叶子类别，最大顺序号
        /// </summary>
        /// <returns></returns>
        internal int getLastNotLeafTypeOrder()
        {
            int ret;
            string sql = "select max(" + FIELD_TYPE_ORDER + ") as " + FIELD_TYPE_ORDER +
                " from " + TABLE_NAME + 
                " where not " + FIELD_IS_LEAF;
            DataTable dtRet = this.loadEntsDtBySql(sql);

            if(null == dtRet)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (0 == dtRet.Rows.Count)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (dtRet.Rows[0][FIELD_TYPE_ORDER].ToString().Equals(""))
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else
            {
                ret = int.Parse(dtRet.Rows[0][FIELD_TYPE_ORDER].ToString());
            }

            return ret;
        }
        /// <summary>
        /// 某个父类别的子类别最大顺序号
        /// </summary>
        /// <param name="parentTypeId"></param>
        /// <returns></returns>
        internal int getLastLeafTypeOrderByParentId(string parentTypeId)
        {
            int ret;
            string sql = "select max(" + FIELD_TYPE_ORDER + ") as " + FIELD_TYPE_ORDER +
                " from " + TABLE_NAME + 
                " where " + FIELD_IS_LEAF + " and " +
                FIELD_PARENT_TYPE_ID + "='" + parentTypeId + "'";

            DataTable dtRet = this.loadEntsDtBySql(sql);

            if (null == dtRet)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (0 == dtRet.Rows.Count)
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else if (dtRet.Rows[0][FIELD_TYPE_ORDER].ToString().Equals(""))
            {
                ret = ORDER_NUMBER_DOWN_LIMIT;
            }
            else
            {
                ret = int.Parse(dtRet.Rows[0][FIELD_TYPE_ORDER].ToString());
            }
            return ret;
        }

        internal void delEnt(CPileType ent)
        {
            if(!ent.IsLeaf)
            {
                delAllChildren(ent);
            }

            delEntOnly(ent);
        }

        private void delAllChildren(CPileType ent)
        {
            string sql = "delete from " + TABLE_NAME + 
                " where " + FIELD_PARENT_TYPE_ID + "='" + ent.PileTypeId + "'";
            this.exeNonQuerSql(sql);
        }

        private void delEntOnly(CPileType ent)
        {
            string sql = "delete from " + TABLE_NAME +
                " where " + FIELD_PILE_TYPE_ID + "='" + ent.PileTypeId + "'";
            this.exeNonQuerSql(sql);
        }

        private CPileType create1EntByDtAndRowIndex(DataTable dtRet, int i)
        {
            CPileType ret = new CPileType();
            ret.PileTypeId = dtRet.Rows[i][FIELD_PILE_TYPE_ID].ToString();
            ret.PileTypeName = dtRet.Rows[i][FIELD_PILE_TYPE_NAME].ToString();
            ret.ParentTypeId = dtRet.Rows[i][FIELD_PARENT_TYPE_ID].ToString();
            ret.IsLeaf = bool.Parse(dtRet.Rows[i][FIELD_IS_LEAF].ToString());
            ret.TypeOrder = int.Parse(dtRet.Rows[i][FIELD_TYPE_ORDER].ToString());
            return ret;
        }





    }
}
