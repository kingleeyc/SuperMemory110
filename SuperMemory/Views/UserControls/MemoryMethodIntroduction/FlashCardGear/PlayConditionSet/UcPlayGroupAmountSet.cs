using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayGroupAmountSet : UcCbbSetBase
    {
        public const int VALUE_GROUP_AMOUNT_ONE = 1;
        private const string NAME_GROUP_AMOUNT_ONE = "一组记录";

        public const int VALUE_GROUP_AMOUNT_TWO = 2;
        private const string NAME_GROUP_AMOUNT_TWO = "二组记录";

        public const int VALUE_GROUP_AMOUNT_THREE = 3;
        private const string NAME_GROUP_AMOUNT_THREE = "三组记录";

        public UcPlayGroupAmountSet()
        {
            InitializeComponent();
        }

        public void setObserver(IPlayGroupAmountSetObserver ob)
        {
            this.ob = ob;
        }

        protected override void  createValues(DataTable ret)
        {
            ret.Rows.Add(this.createRow(ret, NAME_GROUP_AMOUNT_ONE, VALUE_GROUP_AMOUNT_ONE));
            ret.Rows.Add(this.createRow(ret, NAME_GROUP_AMOUNT_TWO, VALUE_GROUP_AMOUNT_TWO));
            ret.Rows.Add(this.createRow(ret, NAME_GROUP_AMOUNT_THREE, VALUE_GROUP_AMOUNT_THREE)); 
        }

        protected override void onSelChanged()
        {
            if(null == this.ob)
            {
                return;
            }

            this.ob.onPlayGroupAmountChanged(this.getSelValue());
        }

        private IPlayGroupAmountSetObserver ob;

    }
}
