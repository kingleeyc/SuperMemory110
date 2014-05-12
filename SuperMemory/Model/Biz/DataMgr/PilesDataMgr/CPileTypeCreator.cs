using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Utils;
using System.Windows.Forms;
using SuperMemory.Model.DB.TablePileType;
using SuperMemory.Partten.Observer;

namespace SuperMemory.Model.Biz.DataMgr.PilesDataMgr
{
    public class CPileTypeCreator
    {
        internal void create(object parentPileType)
        {
            this.parentPileType = parentPileType;

            pileType = new CPileType();
            pileType.PileTypeId = this.newPileTypeId();
            pileType.ParentTypeId = this.newTypeParentTypeId();
            pileType.TypeOrder = this.newTypeOrder();
            pileType.IsLeaf = this.newTypeIsLeaf();
        }

        internal void save2DB()
        {
            if(this.invalidInputName())
            {
                MessageBox.Show("请填写类别名称");
                return;
            }

            this.pileTypeDB().saveNewEnt(this.pileType);

        }

        private bool invalidInputName()
        {
            if (null == this.pileType.PileTypeName)
            {
                return false;
            }
            return this.pileType.PileTypeName.Equals("");
        }

        private bool newTypeIsLeaf()
        {
            // 如果类别树种选中的是root， return false
            // 否则 return ture

            if (this.isParentTypeRoot())
            {
                return false;
            }

            return true;
        }

        private int newTypeOrder()
        {
            // 同一层级，追加在序列最后
            // 根据树种选中的节点，从数据库中找这个节点下的子节点的最后一个顺序号

            // 返回找到的顺序号 + 1;

            return this.getCurTypeLevelLastOrder() + 1;
        }

        private int getCurTypeLevelLastOrder()
        {
            // 如果选中节点是 root 则从数据库选所有非叶子类别的最后一个顺序号
            if (this.isParentTypeRoot())
            {
                return CModelMgr.Inst.Db.PileType.getLastNotLeafTypeOrder();
            }
            // 否则选择当前类别子类别的最大顺序号
            return CModelMgr.Inst.Db.PileType.getLastLeafTypeOrderByParentId(this.getParentPileTypeId());
        }

        private string getParentPileTypeId()
        {
            if (this.isParentTypeRoot())
            {
                return "";
            }
            return ((CPileType)this.parentPileType).PileTypeId;
        }

        private bool isParentTypeRoot()
        {
            return this.parentPileType is string;
        }

        private string newTypeParentTypeId()
        {
            return getParentPileTypeId();
        }

        private string newPileTypeId()
        {
            return "pt" + CIDGenerator.Inst.gen();
        }

        private CTablePileType pileTypeDB()
        {
            return CModelMgr.Inst.Db.PileType;
        }

        
        private CPileType pileType;

        public CPileType PileType
        {
            get { return pileType; }
        }

        private object parentPileType;


    }
}
