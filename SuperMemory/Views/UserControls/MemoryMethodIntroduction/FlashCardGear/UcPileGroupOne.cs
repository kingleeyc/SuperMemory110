using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    public partial class UcPileGroupOne : UserControl, IPilesGroupView
    {
        public UcPileGroupOne()
        {
            InitializeComponent();
        }

        #region IPilesGroupView 成员

        void IPilesGroupView.setPile(CPile pile, int index)
        {
            this.ucPileView1.PileData = pile;
        }

        #endregion

        #region IPilesGroupView 成员


        void IPilesGroupView.switch2Step(int step)
        {
            this.ucPileView1.switch2Step(step);
        }

        #endregion
    }
}
