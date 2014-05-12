using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class UcPicChoicePileChoicePart : UserControl
    {
        public UcPicChoicePileChoicePart()
        {
            InitializeComponent();
        }

        public void initLoad()
        {
            Biz.CurPilePicView = this.ucPilePicView;
            Biz.CurChoicePilesGroupView = this.ucChoiceGroup;
            this.cleanView();
        }

        private void cleanView()
        {
            this.ucPilePicView.clean();
        }

        private CPicChoiceMeaningBiz Biz
        {
            get
            {
                return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
            }
        }


        public int ChoiceType
        {
            set { 
                this.ucChoiceGroup.ChoiceType = value;
            }
        }
    }
}
