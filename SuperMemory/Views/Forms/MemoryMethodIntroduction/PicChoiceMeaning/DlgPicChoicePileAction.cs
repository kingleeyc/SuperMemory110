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
    public partial class DlgPicChoicePileAction : DlgPicChoicePileBase
    {
        public DlgPicChoicePileAction()
        {
            InitializeComponent();
        }

        protected override int getChoiceType()
        {
            return CChoicesMgr.CHOICE_TYPE_ACTION;
        } 


    }
}

