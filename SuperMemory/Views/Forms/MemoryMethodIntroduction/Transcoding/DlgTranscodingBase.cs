using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.Forms.Common;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Transcoding;
using SuperMemory.Model;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.Common;
using SuperMemory.Enums;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding
{
    public partial class DlgTranscodingBase : DlgTrainningBase
    {
        public DlgTranscodingBase()
        {
            InitializeComponent();
        }

        private void DlgPic2Num_Load(object sender, EventArgs e)
        {
            this.ucTranscodingPanelBase.initLoad();
            Biz.TrainningTimingView = this;
        }


        protected CTranscodingBiz Biz
        {
            get { return CModelMgr.Inst.Biz.MemoryMethodIntroduction.Transcoding; }
        }

        protected EnumTranscodingType TranscodingType
        {
            set
            {
                this.ucTranscodingPanelBase.TranscodingType = value;
            }
        }
            

    }
}