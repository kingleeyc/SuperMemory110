using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class DlgPicChoicePileNumber : DlgPicChoicePileBase
    {
        public DlgPicChoicePileNumber()
        {
            InitializeComponent();
        }

        protected override int getChoiceType()
        {
            return CChoicesMgr.CHOICE_TYPE_NUMBER;
        }

    }
}

