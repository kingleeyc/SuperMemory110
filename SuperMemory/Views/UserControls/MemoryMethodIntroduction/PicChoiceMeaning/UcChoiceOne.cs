using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
using SuperMemory.Entities;
using SuperMemory.Model;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.PicChoiceMeaning
{
    public partial class UcChoiceOne : UserControl, IChoicePileView
    {
        
        public UcChoiceOne()
        {
            InitializeComponent();
        }
        #region IChoicePileView 成员
        CPile IChoicePileView.Pile
        {
            set
            {
                this.pile = value;
                this.updateDataView();
            }
        }

        int IChoicePileView.ChoiceType
        {
            set {
                this.choiceType = value;
            }
        }
        #endregion

        private void updateDataView()
        {
            this.lbChoice.Text = this.getViewText();
        }

        private string getViewText()
        {
            switch (this.choiceType)
            {
                case CChoicesMgr.CHOICE_TYPE_NUMBER:
                    return this.getPileNumber();
                case CChoicesMgr.CHOICE_TYPE_WORD:
                    return this.getPileWord();
                case CChoicesMgr.CHOICE_TYPE_ROLE:
                    return this.getPileRole();
                case CChoicesMgr.CHOICE_TYPE_ACTION:
                    return this.getPileAction();
            }
            return "";
        }

        private string getPileAction()
        {
            if (null == this.pile)
            {
                return "";
            }

            return this.pile.Action;
        }

        private string getPileRole()
        {
            if (null == this.pile)
            {
                return "";
            }

            return this.pile.Role;
        }

        private string getPileWord()
        {
            if (null == this.pile)
            {
                return "";
            }

            return this.pile.Word;
        }

        private string getPileNumber()
        {
            if(null == this.pile)
            {
                return "";
            }

            return this.pile.PileNumber;
        }

        private void lbChoice_MouseEnter(object sender, EventArgs e)
        {
            this.lbChoice.BackColor = this.clrBkgMouseEnter;
        }

        private void lbChoice_MouseLeave(object sender, EventArgs e)
        {
            this.lbChoice.BackColor = this.clrBkgPrim;
        }

        private void lbChoice_Click(object sender, EventArgs e)
        {
            if(null == this.pile)
            {
                return;
            }
            Biz.choice(this.pile);
        }

        private void UcChoiceOne_Load(object sender, EventArgs e)
        {
            this.clrBkgPrim = this.BackColor;
        }

        private CPicChoiceMeaningBiz Biz
        {
            get
            {
                return CModelMgr.Inst.Biz.MemoryMethodIntroduction.PicChoiceMeaning;
            }
        }

        private CPile pile;
        private int choiceType;
        private Color clrBkgPrim;
        private Color clrBkgMouseEnter = Color.Gray;



 
    }
}
