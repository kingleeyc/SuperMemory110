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
    public partial class UcPileGroupThree : UserControl, IPilesGroupView
    {
        public UcPileGroupThree()
        {
            InitializeComponent();
        }

        #region IPilesGroupView 成员

        void IPilesGroupView.setPile(CPile pile, int index)
        {
            switch (index)
            {
                case 0:
                    this.ucPileView1.PileData = pile;
                    break;
                case 1:
                    this.ucPileView2.PileData = pile;
                    break;
                case 2:
                    this.ucPileView3.PileData = pile;
                    break;
            }
        }

        #endregion

        #region IPilesGroupView 成员


        void IPilesGroupView.switch2Step(int step)
        {
            this.ucPileView1.switch2Step(step);
            this.ucPileView2.switch2Step(step);
            this.ucPileView3.switch2Step(step);
        }

        #endregion
    }
}
