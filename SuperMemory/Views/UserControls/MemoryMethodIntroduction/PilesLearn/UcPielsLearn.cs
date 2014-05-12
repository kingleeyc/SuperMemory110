using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PilesLearn;
using SuperMemory.Model;
using SuperMemory.Partten.Observer;
using SuperMemory.Entities;
using SuperMemory.Model.DB;
using SuperMemory.Global;
using SuperMemory.Utils;
using SuperMemory.Model.DB.TablePile;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PilesLearn
{
    public partial class UcPielsLearn : UcFormMainBase, IObserver, ILeafPileTypeSelectOberver
    {
        public UcPielsLearn()
        {
            InitializeComponent();
        }

        public override void initLoad()
        {
            biz().add(this);

            // 桩类别选择器
            ucLeafPileTypesSelector.setSelChangedObserver(this);
            ucLeafPileTypesSelector.initLoad();


        }

        #region IObserver 成员

        void IObserver.notified(int eventId)
        {
            switch (eventId)
            {
                case CPilesLearnBiz.EVENT_PILE_TYPE_CHANGED://当前桩类别已经改变
                    this.cleanViewData();
                    biz().nextPile();
                    break;
                case CPilesLearnBiz.EVENT_PILE_CHANGED://当前桩已经改变
                    updatePileDataView();
                    break;
                case CPilesLearnBiz.EVENT_PILE_EDIT_STATE_CHANGED:// 当前桩的编辑状态改变
                    updatePileDataView();
                    break;
            }
            
        }



        #endregion

        #region 更新当前桩显示
        private void updatePileDataView()
        {
            if (biz().CurPile == null)
            {
                this.cleanViewData();
                return;
            }
            this.picbPile.Image = this.getPicImgFromAddr(biz().CurPile.Pic);
            this.lbRole.Text = biz().CurPile.Role;
            this.lbAction.Text = biz().CurPile.Action;

            // 当前编辑是“桩号”还是“词”
            switch(biz().EditState)
            {
            case CPilesLearnBiz.EDIT_STATE_PILE_NUMBER_EDIT:
                this.editPileNumber();
                break;
            case CPilesLearnBiz.EDIT_STATE_PILE_WORD_EDIT:
                this.editPileWord();
                break;
            }


            
        }

        private void editPileWord()
        {
            this.tbxPileOrWord.Text = biz().CurPile.Word;
            this.lbPileOrWord.Text = biz().CurPile.PileNumber;
        }

        private void editPileNumber()
        {
            this.tbxPileOrWord.Text = biz().CurPile.PileNumber;
            this.lbPileOrWord.Text = biz().CurPile.Word;
        }

        private void cleanViewData()
        {
            this.picbPile.Image = null;
            this.tbxPileOrWord.Text = "";
            this.lbPileOrWord.Text = "";
            this.lbRole.Text = "";
            this.lbAction.Text = "";

        }

        private Image getPicImgFromAddr(string imgAddr)
        {
            return Image.FromFile(CGlobal.Inst.PilePicDir + imgAddr);
        }
        #endregion

        #region 当前桩改变动作（事件）
        private void btnGotoLast_Click(object sender, EventArgs e)
        {
            biz().lastPile();
        }
        
        private void btnGotoNext_Click(object sender, EventArgs e)
        {
            biz().nextPile();
        }
        #endregion

 
        #region ILeafPileTypeSelectOberver 成员

        void ILeafPileTypeSelectOberver.onPileTypeSelectChanged(CPileType curPileType)
        {
            biz().CurPileType = curPileType;
        }

        #endregion


        private CPilesLearnBiz biz()
        {
            return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PilesLearn;
        }

        /// <summary>
        /// 决定编辑词还是桩号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbPileNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbPileNumber.Checked)
            {
                biz().pileNumberEdit();
            }
            else
            {
                biz().pileWordEdit();
            }
        }

        #region 词或者桩号编辑
        /// <summary>
        /// 词或者桩号编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPileOrWord_TextChanged(object sender, EventArgs e)
        {
            switch(biz().EditState)
            {
            case CPilesLearnBiz.EDIT_STATE_PILE_NUMBER_EDIT:
                this.eidtPileNumberChanged();
                break;
            case CPilesLearnBiz.EDIT_STATE_PILE_WORD_EDIT:
                this.editPileWordChanged();
                break;
            }
        }
        /// <summary>
        /// 桩号编辑改变
        /// </summary>
        private void eidtPileNumberChanged()
        {
            if(!this.editPileNumberInputValid())
            {
                return;
            }

            CPile curPile = this.getTablePile().loadPileByTypeIdAndPileNumber(biz().CurPileType.PileTypeId,this.getEditInput());

            if (null == curPile)
            {
                return;
            }

            biz().CurPile = curPile;
            
        }

        private bool editPileNumberInputValid()
        {
            return CStringUtils.Inst.isNumber(this.getEditInput());
        }


        /// <summary>
        /// 词编辑改变
        /// </summary>
        private void editPileWordChanged()
        {
            if (!this.editPileWordInputValid())
            {
                return;
            }

            CPile curPile = this.getTablePile().loadPileByTypeIdAndPileWord(biz().CurPileType.PileTypeId, this.getEditInput());

            if (null == curPile)
            {
                return;
            }

            biz().CurPile = curPile;
        }

        private bool editPileWordInputValid()
        {
            return CStringUtils.Inst.isChineseWord(this.getEditInput());
        }

        #endregion

        private string getEditInput()
        {
            return tbxPileOrWord.Text;
        }

        private CTablePile getTablePile()
        {
            return CModelMgr.Inst.Db.Pile;
        }



    }
}
