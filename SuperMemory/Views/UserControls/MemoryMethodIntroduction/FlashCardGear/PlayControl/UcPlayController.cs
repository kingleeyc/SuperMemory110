using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayControl
{
    public partial class UcPlayController : UserControl
    {
        public UcPlayController()
        {
            InitializeComponent();
        }

        public void setObserver(IPlayControlObserver ob)
        {
            this.ob = ob;
        }

        public void state2Pause()
        {
            this.btnPlayOrPause.Text = "开始";
        }

        public void state2Playing()
        {
            this.btnPlayOrPause.Text = "暂停";
            this.btnStop.Enabled = true;
        }

        private delegate void state2StopDele();
        public void state2Stop()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new state2StopDele(state2Stop));
                return;
            }

            this.btnPlayOrPause.Text = "开始";
            this.btnStop.Enabled = false;
        }

        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if(null == this.ob)
            {
                return;
            }

            this.ob.onPlayOrPauseClick();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (null == this.ob)
            {
                return;
            }

            this.ob.onStopClick();
        }

        private IPlayControlObserver ob;
        
    }
}
