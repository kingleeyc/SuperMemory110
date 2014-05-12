using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding
{
    public partial class DlgTranscodingWord2Role : SuperMemory.Views.Forms.MemoryMethodIntroduction.Transcoding.DlgTranscodingBase
    {
        public DlgTranscodingWord2Role()
        {
            InitializeComponent();
        }

        private void DlgTranscodingWord2Role_Load(object sender, EventArgs e)
        {
            this.TranscodingType = SuperMemory.Enums.EnumTranscodingType.word2role;
        }
    }
}

