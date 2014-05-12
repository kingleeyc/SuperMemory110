using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.UserControls.Common;
using SuperMemory.Entities;
using SuperMemory.Enums;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcRadioPileViewBase : UserControl, IRadioPileView
    {
        public UcRadioPileViewBase()
        {
            InitializeComponent();
        }

        #region IRadioPileView 成员

        void IRadioPileView.setGroup(IRadioPileViewGroup group)
        {
            this.group = group;
        }

        int IRadioPileView.RadioId
        {
            set
            {
                radioId = value;
            }
            get {                 
                return radioId; 
            }
        }

        CPile IRadioPileView.PileData
        {
            get 
            { 
                return (this.ucPileViewBase as IPileView).PileData;
            }
            set
            {
                (this.ucPileViewBase as IPileView).PileData = value;
            }
        }
        EnumPileDataFiled IRadioPileView.DataViewFiled
        {
            get
            {
                return (this.ucPileViewBase as IPileView).DataViewFiled;
            }
            set
            {
                (this.ucPileViewBase as IPileView).DataViewFiled = value;
            }
        }

        void IRadioPileView.unChoice()
        {
            (this.ucPileViewBase as IPileView).unChoice();
        }

        void IRadioPileView.cleanData()
        {
            (this.ucPileViewBase as IPileView).cleanData();
        }


        #endregion

        private void ucPileViewBase_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.group != null)
            {
                this.group.onOneRadioChoice(this.radioId, this.ucPileViewBase as IPileView);
            }
        }



        private IRadioPileViewGroup group;
        private int radioId;




        #region IRadioPileView 成员


        void IRadioPileView.cleanMark()
        {
            (this.ucPileViewBase as IPileView).cleanMark();
        }

        #endregion
    }
}
