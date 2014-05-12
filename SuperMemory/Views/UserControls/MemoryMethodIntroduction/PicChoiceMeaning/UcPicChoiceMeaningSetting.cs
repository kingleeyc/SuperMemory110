using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model;
using SuperMemory.Entities;
using SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class UcPicChoiceMeaningSetting : UcFormMainBase,
        ILeafPileTypeSelectOberver, IPileOrderAreaSetObserver
    {
        public UcPicChoiceMeaningSetting()
        {
            InitializeComponent();
        }

        public override void initLoad()
        {
            this.ucLeafPileTypesSelector.setSelChangedObserver(this);
            this.ucLeafPileTypesSelector.initLoad();           
            
        }

        #region ILeafPileTypeSelectOberver 成员

        void ILeafPileTypeSelectOberver.onPileTypeSelectChanged(SuperMemory.Entities.CPileType curPileType)
        {
            Biz.CurPileType = curPileType;
            if (Biz.hasPiles())
            {
                this.enableBtns();
            }
            else
            {
                this.unenableBtns();
            }
        }

        private void enableBtns()
        {
            this.btnPicChoicePileNumber.Enabled = true;
            this.btnPicChoicePileWord.Enabled = true;
            this.btnPicChoicePileRole.Enabled = true;
            this.btnPicChoicePileAction.Enabled = true;
            
        }

        private void unenableBtns()
        {
            this.btnPicChoicePileNumber.Enabled = false;
            this.btnPicChoicePileWord.Enabled = false;
            this.btnPicChoicePileRole.Enabled = false;
            this.btnPicChoicePileAction.Enabled = false;
        }

        #endregion

        #region IPileOrderAreaSetObserver 成员

        void IPileOrderAreaSetObserver.onOrderBeginChanged(int curOrderBegin)
        {
            Biz.TrainningSet.PilesOrderAreaSet.iBeginOrderSet = curOrderBegin;
        }

        void IPileOrderAreaSetObserver.onOrderEndChanged(int curOrderEnd)
        {
            Biz.TrainningSet.PilesOrderAreaSet.iEndOrderSet = curOrderEnd;
        }

        #endregion



        #region 字段和属性们
        private CPicChoiceMeaningBiz Biz
        {
            get
            {
                return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
            }
        }


        #endregion

        private void btnPicChoicePileNumber_Click(object sender, EventArgs e)
        {
            this.dlgPicChoicePileNumber.ShowDialog(this);
        }

        private DlgPicChoicePileNumber dlgPicChoicePileNumber = new DlgPicChoicePileNumber();

        private void btnPicChoicePileWord_Click(object sender, EventArgs e)
        {
            this.dlgPicChoicePileWord.ShowDialog(this);
        }

        private DlgPicChoicePileWord dlgPicChoicePileWord = new DlgPicChoicePileWord();

        private void btnPicChoicePileRole_Click(object sender, EventArgs e)
        {
            this.dlgPicChoiceRole.ShowDialog(this);
        }

        private DlgPicChoicePileRole dlgPicChoiceRole = new DlgPicChoicePileRole();

        private void btnPicChoicePileAction_Click(object sender, EventArgs e)
        {
            this.dlgPicChoiceAction.ShowDialog(this);
        }

        private DlgPicChoicePileAction dlgPicChoiceAction = new DlgPicChoicePileAction();
    }
}
