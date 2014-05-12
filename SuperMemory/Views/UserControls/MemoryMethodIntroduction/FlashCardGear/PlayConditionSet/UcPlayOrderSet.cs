using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.FlashCardGear.PlayControl;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayOrderSet : UserControl
    {
        public UcPlayOrderSet()
        {
            InitializeComponent();
        }
        public void setObserver(IPlayOrderSetObserver ob)
        {
            this.ob = ob;
        }
        private void rbForward_CheckedChanged(object sender, EventArgs e)
        {
            if(null == this.ob)
            {
                return;
            }
            this.ob.onPlayOrderStateChanged(this.getCurOrderState());
        }

        private void rbReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (null == this.ob)
            {
                return;
            }
            this.ob.onPlayOrderStateChanged(this.getCurOrderState());
        }

        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (null == this.ob)
            {
                return;
            }
            this.ob.onPlayOrderStateChanged(this.getCurOrderState());
        }

        private int getCurOrderState()
        {
            if(this.rbForward.Checked)
            {
                return (int)EnumPlayPileOrderStates.Forward;
            }else if(this.rbReverse.Checked)
            {
                return (int)EnumPlayPileOrderStates.Reverse;
            }
            return (int)EnumPlayPileOrderStates.Rand;
        }


        IPlayOrderSetObserver ob;


    }
}
