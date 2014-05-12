using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayerOrderSet : UserControl
    {
        public const int ORDER_STATE_FORWARD = 1;
        public const int ORDER_STATE_REVERSE = 2;
        public const int ORDER_STATE_RANDOM = 3;

        public UcPlayerOrderSet()
        {
            InitializeComponent();
        }
        public void setObserver(IPlayerOrderSetObserver ob)
        {
            this.ob = ob;
        }
        private void rbForward_CheckedChanged(object sender, EventArgs e)
        {
            if(null == this.ob)
            {
                return;
            }
            this.ob.onPlayerOrderStateChanged(this.getCurOrderState());
        }

        private int getCurOrderState()
        {
            if(this.rbForward.Checked)
            {
                return ORDER_STATE_FORWARD;
            }else if(this.rbReverse.Checked)
            {
                return ORDER_STATE_REVERSE;
            }
            return ORDER_STATE_RANDOM;
        }


        IPlayerOrderSetObserver ob;
    }
}
