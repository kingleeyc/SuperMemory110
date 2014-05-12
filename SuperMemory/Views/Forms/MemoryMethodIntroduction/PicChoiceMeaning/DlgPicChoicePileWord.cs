using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class DlgPicChoicePileWord : DlgPicChoicePileBase
    {
        public DlgPicChoicePileWord()
        {
            InitializeComponent();
        }

        protected override int getChoiceType()
        {
            return CChoicesMgr.CHOICE_TYPE_WORD;
        }

    }
}

