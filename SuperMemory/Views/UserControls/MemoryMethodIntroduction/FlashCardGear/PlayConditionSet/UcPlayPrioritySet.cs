using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayPrioritySet : UcCbbSetBase
    {


        #region 优先
        public const int VALUE_PILE_NUMBER_PRIO = 1;
        private const string NAME_PILE_NUMBER_PRIO = "桩号优先";

        public const int VALUE_PILE_PIC_PRIO = 2;
        private const string NAME_PILE_PIC_PRIO = "图像优先";

        public const int VALUE_PILE_WORD_PRIO = 3;
        private const string NAME_PILE_WORD_PRIO = "词优先";

        public const int VALUE_PILE_ROlE_PRIO = 4;
        private const string NAME_PILE_ROlE_PRIO = "角色优先";
        
        public const int VALUE_PILE_ACTION_PRIO = 5;
        private const string NAME_PILE_ACTION_PRIO = "动作优先";
        #endregion

        #region 仅
        public const int VALUE_PILE_NUMBER_ONLY = 6;
        private const string NAME_PILE_NUMBER_ONLY = "仅桩号";

        public const int VALUE_PILE_PIC_ONLY = 7;
        private const string NAME_PILE_PIC_ONLY = "仅图像";

        public const int VALUE_PILE_WORD_ONLY = 8;
        private const string NAME_PILE_WORD_ONLY = "仅词";

        public const int VALUE_PILE_ROLE_ONLY = 9;
        private const string NAME_PILE_ROLE_ONLY = "仅角色";

        public const int VALUE_PILE_ACTION_ONLY = 10;
        private const string NAME_PILE_ACTION_ONLY = "仅动作";
        #endregion


        public UcPlayPrioritySet()
        {
            InitializeComponent();
        }


        public void setObserver(IPlayPrioritySetObserver ob)
        {
            this.ob = ob;
        }

        protected override void createValues(DataTable ret)
        {
            ret.Rows.Add(this.createRow(ret, NAME_PILE_NUMBER_PRIO, VALUE_PILE_NUMBER_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_PIC_PRIO, VALUE_PILE_PIC_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_WORD_PRIO, VALUE_PILE_WORD_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ROlE_PRIO, VALUE_PILE_ROlE_PRIO));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ACTION_PRIO, VALUE_PILE_ACTION_PRIO));

            ret.Rows.Add(this.createRow(ret, NAME_PILE_NUMBER_ONLY, VALUE_PILE_NUMBER_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_PIC_ONLY, VALUE_PILE_PIC_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_WORD_ONLY, VALUE_PILE_WORD_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ROLE_ONLY, VALUE_PILE_ROLE_ONLY));
            ret.Rows.Add(this.createRow(ret, NAME_PILE_ACTION_ONLY, VALUE_PILE_ACTION_ONLY));
        }

        protected override void onSelChanged()
        {
            if (null == this.ob)
            {
                return;
            }

            this.ob.onPlayPriorityChanged(this.getSelValue());            
        }

         private IPlayPrioritySetObserver ob;
    }
}
