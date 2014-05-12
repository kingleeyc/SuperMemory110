using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;
using SuperMemory.Enums;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcRadioPileViewGroupBase : UserControl, IRadioPileViewGroup
    {
        public UcRadioPileViewGroupBase()
        {
            InitializeComponent();
        }

        #region IRadioPileViewGroup ≥…‘±

        void IRadioPileViewGroup.onOneRadioChoice(int radioId, IPileView pileView)
        {
            foreach(IRadioPileView radioItem in piles)
            {
                if(radioItem.RadioId != radioId)
                {
                    radioItem.unChoice();
                }
            }

            this.curChosenPileView = pileView;

            this.on1PileChosen();
        }

        #endregion

        virtual protected void on1PileChosen()
        {
            
        }


        protected void addPile(IRadioPileView pile)
        {
            piles.Add(pile);
        }

        protected void cleanStateDo()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.cleanData();
            }
        }

        protected void pilesViewField2Word()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.DataViewFiled = EnumPileDataFiled.word;
            }
        }

        protected void pilesViewField2Num()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.DataViewFiled = EnumPileDataFiled.number;
            }
        }

        protected void pilesViewField2Pic()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.DataViewFiled = EnumPileDataFiled.pic;
            }
        }

        protected void pilesViewField2Role()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.DataViewFiled = EnumPileDataFiled.role;
            }
        }

        protected void pilesViewFieldAction()
        {
            foreach (IRadioPileView pile in this.piles)
            {
                pile.DataViewFiled = EnumPileDataFiled.action;
            }
        }

        public EnumTranscodingType TranscodingType
        {
            set
            {
                this.setTranscodingType(value);
            }
        }

        virtual protected void setTranscodingType(EnumTranscodingType transcodingType)
        {

        }

        protected CTranscodingBiz Biz
        {
            get { return CModelMgr.Inst.Biz.MemoryMethodIntroduction.Transcoding; }
        }

        protected List<IRadioPileView> piles = new List<IRadioPileView>();
        protected IPileView curChosenPileView;
        
    }
}
