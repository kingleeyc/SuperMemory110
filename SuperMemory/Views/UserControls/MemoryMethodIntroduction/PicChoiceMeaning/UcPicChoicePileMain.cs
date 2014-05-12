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
    public partial class UcPicChoicePileMain : UserControl
    {
        

        public UcPicChoicePileMain()
        {
            InitializeComponent();
        }

        internal void initLoad()
        {
            this.ucPicChoicePileChoicePart.initLoad();
            Biz.GroupCountDownView = this.ucGroupCountDownView;
        }

        private void btnStartTrainning_Click(object sender, EventArgs e)
        {
            Biz.beginTrainning();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            (this.Parent as Form).Close();
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
                this.ucPicChoicePileChoicePart.ChoiceType = value;
            }
        }
    }
}
