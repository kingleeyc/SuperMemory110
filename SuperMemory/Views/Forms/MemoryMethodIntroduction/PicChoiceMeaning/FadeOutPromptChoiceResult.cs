using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.Forms.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class FadeOutPromptChoiceResult : Form
    {
        private const string ERR = "答题错误";
        private const string RIGHT = "正确";
        private const float FADE_STEP = 0.08f;
        public FadeOutPromptChoiceResult()
        {
            InitializeComponent();
        }
        private delegate void promptErrDele();
        public void promptErr()
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new promptErrDele(this.promptErr));
                return;
            }

            this.label1.Text = ERR;
            this.label1.BackColor = Color.LightGray;
            this.label1.ForeColor = Color.Red;


            this.startFadeOut();
        }

        public void promptRight()
        {
            this.label1.Text = RIGHT;
            this.label1.BackColor = Color.DarkSalmon;
            this.label1.ForeColor = Color.Green;


            this.startFadeOut();
        }

        private void startFadeOut()
        {
            this.Opacity = 1.0f;
            this.timer1.Start();
        }

        private void stopFadeOut()
        {
            this.timer1.Stop();
        }



        private bool isShown = false;

        public bool IsShown
        {
            get { return isShown; }
            set { isShown = value; }
        }

        private void FlashPromptChoiceResult_Shown(object sender, EventArgs e)
        {
            this.isShown = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <= 0.0f)
            {
                this.stopFadeOut();
                return;
            }
            this.Opacity -= FADE_STEP;
        }


    }
}