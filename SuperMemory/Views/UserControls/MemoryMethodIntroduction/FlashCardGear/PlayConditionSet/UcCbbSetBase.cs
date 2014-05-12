using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SuperMemory.Views.UserControls.MemoryMethodIntroduction.FlashCardGear.PlayerConditionSet
{
    public partial class UcCbbSetBase : UserControl
    {
        private const string PROP_NAME_TITLE = "propName";
        private const string PROP_VALUE_TITLE = "propValue";

        public UcCbbSetBase()
        {
            InitializeComponent();
        }

        public void initLoad()
        {
            this.cbbData.DataSource = this.createData();
        }

        protected DataTable createData()
        {
            DataTable ret = new DataTable("mydata");
            ret.Columns.Add(this.createColPropName());
            ret.Columns.Add(this.createColPropValue());

            this.createValues(ret);

            return ret;
        }

        virtual protected void createValues(DataTable ret)
        {
            
        }

        protected DataRow createRow(DataTable dt, string name, int value)
        {
            DataRow ret = dt.NewRow();
            ret[PROP_NAME_TITLE] = name;
            ret[PROP_VALUE_TITLE] = value;
            return ret;
        }

        protected DataColumn createColPropValue()
        {
            return new DataColumn(PROP_VALUE_TITLE);
        }

        protected DataColumn createColPropName()
        {
            return new DataColumn(PROP_NAME_TITLE);
        }

        private void cbbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.onSelChanged();
        }

        protected int getSelValue()
        {
            if(null == this.cbbData.SelectedValue)
            {
                return -1;
            }

            return int.Parse(this.cbbData.SelectedValue.ToString());
        }

        virtual protected void onSelChanged()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
