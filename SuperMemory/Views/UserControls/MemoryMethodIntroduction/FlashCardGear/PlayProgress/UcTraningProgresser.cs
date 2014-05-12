using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayProgress
{
    public partial class UcTraningProgresser : UcProgresserBase, IProgresser
    {
        public UcTraningProgresser()
        {
            InitializeComponent();
        }

        protected override string getLabel()
        {
            return "练习时间：";
        }

        
        #region ITraningProgresser 成员
        void IProgresser.updateProgress(int value)
        {
            this.updateProgressDo(value);
        }

        #endregion
    }
}
