using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Enums;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding
{
    public partial class DlgTranscodingPic2Num : DlgTranscodingBase
    {
        public DlgTranscodingPic2Num()
        {
            InitializeComponent();
        }

        private void DlgTranscodingPic2Num_Load(object sender, EventArgs e)
        {
            this.TranscodingType = EnumTranscodingType.pic2num;
        }
    }
}

