using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Enums;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.Transcoding
{
    public partial class UcTranscodingPart : UserControl
    {
        public UcTranscodingPart()
        {
            InitializeComponent();
        }

        public EnumTranscodingType TranscodingType
        {
            set
            {
                this.ucBottomPilesGroup.TranscodingType = value;
                this.ucTopPilesGroup.TranscodingType = value;
            }
        }

        internal void cleanAllPilesMark()
        {
            this.ucTopPilesGroup.cleanAllPilesMark();

        }
    }
}
