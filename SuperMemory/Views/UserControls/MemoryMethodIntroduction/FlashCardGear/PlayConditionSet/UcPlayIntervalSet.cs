using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcPlayIntervalSet : SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet.UcCbbSetBase
    {

        public const int VALUE_INTERVAL_TEN_SEC = 10000;
        private const string NAME_INTERVAL_TEN_SEC = "º‰∏Ù10√Î";

        public const int VALUE_INTERVAL_FIVE_SEC = 5000;
        private const string NAME_INTERVAL_FIVE_SEC = "º‰∏Ù5√Î";

        public const int VALUE_INTERVAL_THREE_SEC = 3000;
        private const string NAME_INTERVAL_THREE_SEC = "º‰∏Ù3√Î";

        public const int VALUE_INTERVAL_TWO_SEC = 2000;
        private const string NAME_INTERVAL_TWO_SEC = "º‰∏Ù2√Î";

        public const int VALUE_INTERVAL_ONE_SEC = 1000;
        private const string NAME_INTERVAL_ONE_SEC = "º‰∏Ù1√Î";

        public const int VALUE_INTERVAL_HALF_SEC = 500;
        private const string NAME_INTERVAL_HALF_SEC = "º‰∏Ù0.5√Î";

        public const int VALUE_INTERVAL_THIRTY_PERCENT_SEC = 300;
        private const string NAME_INTERVAL_THIRTY_PERCENT_SEC = "º‰∏Ù0.3√Î";

        public const int VALUE_INTERVAL_TEN_PERCENT_SEC = 100;
        private const string NAME_INTERVAL_TEN_PERCENT_SEC = "º‰∏Ù0.1√Î";

        public UcPlayIntervalSet()
        {
            InitializeComponent();
        }

        public void setObserver(IPlayIntervalSetObserver ob)
        {
            this.ob = ob;
        }

        protected override void createValues(DataTable ret)
        {
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_TEN_SEC, VALUE_INTERVAL_TEN_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_FIVE_SEC, VALUE_INTERVAL_FIVE_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_THREE_SEC, VALUE_INTERVAL_THREE_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_TWO_SEC, VALUE_INTERVAL_TWO_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_ONE_SEC, VALUE_INTERVAL_ONE_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_HALF_SEC, VALUE_INTERVAL_HALF_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_THIRTY_PERCENT_SEC, VALUE_INTERVAL_THIRTY_PERCENT_SEC));
            ret.Rows.Add(this.createRow(ret, NAME_INTERVAL_TEN_PERCENT_SEC, VALUE_INTERVAL_TEN_PERCENT_SEC));
        }

        protected override void onSelChanged()
        {
            if(null == this.ob)
            {
                return;
            }

            this.ob.onPlayIntervalChanged(this.getSelValue());
        }

        private IPlayIntervalSetObserver ob;
    }
}

