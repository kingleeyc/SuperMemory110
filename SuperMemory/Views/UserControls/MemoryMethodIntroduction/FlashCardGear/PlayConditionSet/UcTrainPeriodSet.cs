using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcTrainPeriodSet : UcCbbSetBase
    {

        public const int VALUE_PEROID_TEN = 10;
        private const string NAME_PEROID_TEN = "练习10分钟";

        public const int VALUE_PEROID_FIVE = 5;
        private const string NAME_PEROID_FIVE = "练习5分钟";

        public const int VALUE_PEROID_TWO = 2;
        private const string NAME_PEROID_TWO = "练习2分钟";

        public const int VALUE_PEROID_ONE = 1;
        private const string NAME_PEROID_ONE = "练习1分钟";

        public UcTrainPeriodSet()
        {
            InitializeComponent();
        }

        public void setObserver(ITrainPeriodSetObserver ob)
        {
            this.ob = ob;
        }

        protected override void onSelChanged()
        {
            if(null == this.ob)
            {
                return;
            }

            this.ob.onTrainPeroidChanged(this.getSelValue());
        }

        protected override void createValues(DataTable ret)
        {
            ret.Rows.Add(this.createRow(ret, NAME_PEROID_TEN, VALUE_PEROID_TEN));
            ret.Rows.Add(this.createRow(ret, NAME_PEROID_FIVE, VALUE_PEROID_FIVE));
            ret.Rows.Add(this.createRow(ret, NAME_PEROID_TWO, VALUE_PEROID_TWO));
            ret.Rows.Add(this.createRow(ret, NAME_PEROID_ONE, VALUE_PEROID_ONE));
        }

        private ITrainPeriodSetObserver ob;
    }
}
