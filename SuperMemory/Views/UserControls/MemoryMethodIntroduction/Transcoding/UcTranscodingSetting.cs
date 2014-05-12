using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model.Biz;
using SuperMemory.Model;
using SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public partial class UcTranscodingSetting : UcFormMainBase,
        ILeafPileTypeSelectOberver, IPileOrderAreaSetObserver
    {
        public UcTranscodingSetting()
        {
            InitializeComponent();
        }
        public override void initLoad()
        {
            this.ucPileOrderAreaSet.setObserver(this);

            this.ucLeafPileTypesSelector.setSelChangedObserver(this);
            this.ucLeafPileTypesSelector.initLoad();            
        }
        #region ILeafPileTypeSelectOberver 成员

        void ILeafPileTypeSelectOberver.onPileTypeSelectChanged(SuperMemory.Entities.CPileType curPileType)
        {
            Biz.CurPileType = curPileType;
            if (Biz.hasPiles())
            {
                this.updateOrderAreaData();
                this.enableBtns();
            }
            else
            {
                this.unenableBtns();
            }
        }

        private void updateOrderAreaData()
        {
            this.ucPileOrderAreaSet.updateOrderAreaData(1,Biz.getPilesCount());
        }

        private void unenableBtns()
        {
            this.btnPilePic2PileAction.Enabled = false;
            this.btnPilePic2PileWord.Enabled = false;
            this.btnPilePic2PileRole.Enabled = false;
            this.btPilePic2PileNum.Enabled = false;
            this.btnPileNum2PileAction.Enabled = false;
            this.btnPileNum2PileWord.Enabled = false;
            this.btnPileNum2PileRole.Enabled = false;
            this.btnPileWord2PileRole.Enabled = false;
            this.btnPileWord2PileAction.Enabled = false;
            

        }

        private void enableBtns()
        {

            this.btnPilePic2PileAction.Enabled = true;
            this.btnPilePic2PileWord.Enabled = true;
            this.btnPilePic2PileRole.Enabled = true;
            this.btPilePic2PileNum.Enabled = true;
            this.btnPileNum2PileAction.Enabled = true;
            this.btnPileNum2PileWord.Enabled = true;
            this.btnPileNum2PileRole.Enabled = true;
            this.btnPileWord2PileRole.Enabled = true;
            this.btnPileWord2PileAction.Enabled = true;
            
        }

        #endregion

        #region IPileOrderAreaSetObserver 成员

        void IPileOrderAreaSetObserver.onOrderBeginChanged(int curOrderBegin)
        {
            (Biz as ITranscodingBiz).TrainningSet.PilesOrderAreaSet.iPilePrimOrderMin = curOrderBegin;
        }

        void IPileOrderAreaSetObserver.onOrderEndChanged(int curOrderEnd)
        {
            (Biz as ITranscodingBiz).TrainningSet.PilesOrderAreaSet.iPilePrimOrderMax = curOrderEnd;
        }

        #endregion

        private CTranscodingBiz Biz
        {
            get { return CModelMgr.Inst.Biz.MemoryMethodIntroduction.Transcoding; }
        }

        private void btPilePic2PileNum_Click(object sender, EventArgs e)
        {
            new DlgTranscodingPic2Num().ShowDialog(this);
        }

        private void btnPilePic2PileWord_Click(object sender, EventArgs e)
        {
            new DlgTranscodingPic2Word().ShowDialog(this);
        }

        private void btnPilePic2PileRole_Click(object sender, EventArgs e)
        {
            new DlgTranscodingPic2Role().ShowDialog(this);
        }

        private void btnPilePic2PileAction_Click(object sender, EventArgs e)
        {
            new DlgTranscodingPic2Action().ShowDialog(this);
        }

        private void btnPileNum2PileWord_Click(object sender, EventArgs e)
        {
            new DlgTranscodingNum2Word().ShowDialog(this);
        }

        private void btnPileNum2PileRole_Click(object sender, EventArgs e)
        {
            new DlgTranscodingNum2Role().ShowDialog(this);
        }

        private void btnPileNum2PileAction_Click(object sender, EventArgs e)
        {
            new DlgTranscodingNum2Action().ShowDialog(this);
        }

        private void btnPileWord2PileRole_Click(object sender, EventArgs e)
        {
            new DlgTranscodingWord2Role().ShowDialog(this);
        }

        private void btnPileWord2PileAction_Click(object sender, EventArgs e)
        {
            new DlgTranscodingWord2Action().ShowDialog(this);
        }
    }
}
