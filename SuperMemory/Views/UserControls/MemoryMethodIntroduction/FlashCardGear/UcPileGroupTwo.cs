using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear
{
    public partial class UcPileGroupTwo : UserControl, IPilesGroupView
    {
        public UcPileGroupTwo()
        {
            InitializeComponent();
        }

        #region IPilesGroupView 成员

        void IPilesGroupView.setPile(SuperMemory.Entities.CPile pile, int index)
        {
            switch(index)
            {
                case 0:
                    this.ucPileView1.PileData = pile;
                    break;
                case 1:
                    this.ucPileView2.PileData = pile;
                    break;
                //case 2:
                //    break;
            }
        }

        #endregion

        #region IPilesGroupView 成员


        void IPilesGroupView.switch2Step(int step)
        {
            this.ucPileView1.switch2Step(step);
            this.ucPileView2.switch2Step(step);
        }

        #endregion
    }
}
