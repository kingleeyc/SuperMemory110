using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class UcChoiceGroup : UserControl, IChoicePilesGroupView
    {
        public UcChoiceGroup()
        {
            InitializeComponent();
        }

        #region IChoicePilesGroupView 成员

        void IChoicePilesGroupView.set1ChoisePile(int index, SuperMemory.Entities.CPile pile)
        {
            switch(index)
            {
            case 0:
                (this.ucChoiceOne1 as IChoicePileView).Pile = pile;
                break;
            case 1:
                (this.ucChoiceOne2 as IChoicePileView).Pile = pile;
                break;
            case 2:
                (this.ucChoiceOne3 as IChoicePileView).Pile = pile;
                break;
            case 3:
                (this.ucChoiceOne4 as IChoicePileView).Pile = pile;
                break;
            }
        }

        #endregion


        public int ChoiceType
        {
            set {

                (this.ucChoiceOne1 as IChoicePileView).ChoiceType = value;
                (this.ucChoiceOne2 as IChoicePileView).ChoiceType = value;
                (this.ucChoiceOne3 as IChoicePileView).ChoiceType = value;
                (this.ucChoiceOne4 as IChoicePileView).ChoiceType = value;
            
            }
        }
    }
}
