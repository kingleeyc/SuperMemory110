using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress
{
    public partial class UcProgresserBase : UserControl
    {
        public UcProgresserBase()
        {
            InitializeComponent();
        }
        private delegate void updateProgressDoDeleg(int value);
        protected void updateProgressDo(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new updateProgressDoDeleg(updateProgressDo), new object[] { value });
                return;
            }
            if (value > 100)
            {
                value = 100;
            }
            this.proBarTranning.Value = value;
            this.proBarTranning.Text = value.ToString() + "%";
        }

        private void UcProgresserBase_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.getLabel();
        }

        virtual protected string getLabel()
        {
            return "";
        }
    }
}
