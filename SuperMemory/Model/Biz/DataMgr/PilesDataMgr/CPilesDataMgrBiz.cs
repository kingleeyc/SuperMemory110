using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Partten.Observer;
using SuperMemory.Entities;
using SuperMemory.Utils;
using System.IO;
using System.Windows.Forms;
using SuperMemory.Global;
using System.Data;
using SuperMemory.Model.DB.TablePile;
using System.Drawing;

namespace SuperMemory.Model.Biz.DataMgr.PilesDataMgr
{
    public class CPilesDataMgrBiz : CObeservableBase
    {
        public const int EVENT_NEW_PILE_TYPE_SAVED = 1;
        public const int EVENT_CUR_PILE_TYPE_DELETED = 2;

        public const int EVENT_CUR_PILE_TYPE_CHANGED = 3;

        public const int EVNE_CUR_PILE_STATE_CHANGED = 4;

        public const int EVENT_NEW_PILE_SAVED = 5;
        public const int EVENT_EDIT_PILE_SAVED = 6;


        public const int EVENT_CUR_PILE_CHAGED = 7;


        public const int CUR_PILE_STATE_NON = 0;
        public const int CUR_PILE_STATE_NEW = 1;
        public const int CUR_PILE_STATE_EDIT = 2;


        private object curPileType;

        public object CurPileType
        {
            get { return curPileType; }
            set { 
                curPileType = value;
                notifyAllObservers(EVENT_CUR_PILE_TYPE_CHANGED);
            }
        }

        private CPileTypeCreator newSubPileTypeCreator = new CPileTypeCreator();

        public CPileTypeCreator NewSubPileTypeCreator
        {
            get { return newSubPileTypeCreator; }
        }

        /// <summary>
        /// 新建当前类别子类别
        /// </summary>
        internal void newSubPileType()
        {
            this.newSubPileTypeCreator.create(this.curPileType);
        }
        /// <summary>
        /// 删除当前类别
        /// </summary>
        internal void deleteCurChosenPileType()
        {
            CModelMgr.Inst.Db.PileType.delEnt(this.curPileType as CPileType);
            notifyAllObservers(EVENT_CUR_PILE_TYPE_DELETED);

        }

        /// <summary>
        /// 当前新建类别保存到数据库
        /// </summary>
        internal void saveNewSubPileType()
        {
            this.newSubPileTypeCreator.save2DB();
            notifyAllObservers(EVENT_NEW_PILE_TYPE_SAVED);
        }

        internal void saveCurPile()
        {
            // 保存当前桩到桩数据库
            if (this.curPileState == CUR_PILE_STATE_NEW)
            {
                this.saveNewPile2DB();
            }
            else if (this.curPileState == CUR_PILE_STATE_EDIT)
            {
                this.saveEditPile2DB();
            }
            this.curPile = null;
            this.pileImagSrc = null;
            this.CurPileState = CUR_PILE_STATE_NON;
        }
        #region 保存当前修改桩到数据库
        private void saveEditPile2DB()
        {
            if(null != this.pileImagSrc)
            {
                this.genNewPileImage();
            }
            CModelMgr.Inst.Db.Pile.saveEntByPileNumberAndPileTypeId(this.curPile);
            notifyAllObservers(EVENT_EDIT_PILE_SAVED);
        }
        #endregion

        #region 加载当前类别桩列表
        internal DataTable loadCurPileTypePiles()
        {
            if(this.isChosenPileTypeNull())
            {
                return null;
            }
            if(this.isChosenPileTypeRoot())
            {
                return null;
            }
            if(this.isChosenPileTypeNotLeaf())
            {
                return null;
            }
            DataTable dtPrim = CModelMgr.Inst.Db.Pile.loadPilesByTypeId(getCurPileTypeId());
            for(int i=0;i<dtPrim.Rows.Count;i++)
            {
                load1PilePic2Dt(dtPrim,i);
            }
            return dtPrim;
        }

        private void load1PilePic2Dt(DataTable dtPrim, int i)
        {
            if ("".Equals(dtPrim.Rows[i][CTablePile.FIELD_PILE_PIC].ToString()))
            {
                return;
            }
            dtPrim.Rows[i][CTablePile.FIELD_PILE_PIC] = CGlobal.Inst.PilePicDir + dtPrim.Rows[i][CTablePile.FIELD_PILE_PIC].ToString();
        }
        #endregion

        #region 保存新建桩数据到数据库
        private void saveNewPile2DB()
        {
            this.curPile.PileTypeId = getCurPileTypeId();
            this.curPile.PrimOrder = this.getCurPileTypePilesLastOrder() + 1;
            this.genNewPileImage();

            CModelMgr.Inst.Db.Pile.saveNewEnt(this.curPile);
            notifyAllObservers(EVENT_NEW_PILE_SAVED);
        }

        private int getCurPileTypePilesLastOrder()
        {
            return CModelMgr.Inst.Db.Pile.loadPilesLastOrderByTypeId(getCurPileTypeId());
        }

        private void genNewPileImage()
        {
            if(null == this.pileImagSrc)
            {
                this.curPile.Pic = "";
                return;
            }
            if (this.pileImagSrc.Equals(""))
            {
                this.curPile.Pic = "";
                return;
            }

            this.curPile.Pic = genNewPileImagName() + Path.GetExtension(this.pileImagSrc);

            File.Copy(this.pileImagSrc, CGlobal.Inst.PilePicDir + this.curPile.Pic);// + this.curPile.Pic + Path.GetExtension(this.pileImagSrc));
        }

        private string genNewPileImagName()
        {
            return "pimg" + CIDGenerator.Inst.gen();
        }
        #endregion
        
        #region 新建桩
        internal void newPile()
        {
            this.createPile();
            this.CurPileState = CUR_PILE_STATE_NEW;
        }

        private void createPile()
        {
            this.curPile = new CPile();
            this.curPile.PileTypeId = getCurPileTypeId();
        }
        #endregion

        #region 编辑当前桩
        internal void editCurPile()
        {
            this.CurPileState = CUR_PILE_STATE_EDIT;
        }
        #endregion 


        #region 当前选中桩类别树中节点的各种情况判断
        internal bool isChosenPileTypeLeaf()
        {
            if (isChosenPileTypeNull())
            {
                return false;
            }
            if (isChosenPileTypeRoot())
            {
                return false;
            }

            if (isChosenPileTypeNotLeaf())
            {
                return false;

            }
            return true;
        }

        private bool isChosenPileTypeNull()
        {
            if (null == this.curPileType)
            {
                return true;
            }
            return false;
        }

        public bool isChosenPileTypeRoot()
        {
            if (this.curPileType is string)
            {
                return true;
            }
            return false;
        }

        public bool isChosenPileTypeNotLeaf()
        {
            return !((CPileType)this.curPileType).IsLeaf;
        }
        #endregion 


        #region 字段们
        /// <summary>
        /// 当前桩的状态（操作状态）
        /// </summary>
        private int curPileState = CUR_PILE_STATE_NON;

        public int CurPileState
        {
            get { return curPileState; }
            set {
                curPileState = value;
                notifyAllObservers(EVNE_CUR_PILE_STATE_CHANGED);
            }
        }
        /// <summary>
        /// 当前桩
        /// </summary>
        private CPile curPile;

        public CPile CurPile
        {
            get { return curPile; }
            set { 
                curPile = value;
                notifyAllObservers(EVENT_CUR_PILE_CHAGED);
            }
        }
        /// <summary>
        /// 当前桩图片源
        /// </summary>
        private string pileImagSrc;

        public string PileImagSrc
        {
            get { return pileImagSrc; }
            set { pileImagSrc = value; }
        }

        #endregion 


        private string getCurPileTypeId()
        {
            return ((CPileType)this.curPileType).PileTypeId; 
        }

        internal CPile loadCurPileTypePileByOrder(int order)
        {
            return CModelMgr.Inst.Db.Pile.loadPileByTypeIdAndOrder(getCurPileTypeId(), order);
        }

        internal string getCurPileTypeName()
        {
            return ((CPileType)this.curPileType).PileTypeName;
        }
    }
}
