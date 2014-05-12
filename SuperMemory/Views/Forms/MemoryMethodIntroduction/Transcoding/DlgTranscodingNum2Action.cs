using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding
{
    public partial class DlgTranscodingNum2Action : SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding.DlgTranscodingBase
    {
        public DlgTranscodingNum2Action()
        {
            InitializeComponent();
        }

        private void DlgTranscodingNum2Action_Load(object sender, EventArgs e)
        {
            this.TranscodingType = SuperMemory.Enums.EnumTranscodingType.num2action;
        }
    }
}

