using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SuperMemory.Model;
using SuperMemory.Entities;

namespace SuperMemory.Views.UserControls.Common
{
    public partial class UcLeafPileTypesSelector : UserControl
    {
        public UcLeafPileTypesSelector()
        {
            InitializeComponent();
        }

        public void setSelChangedObserver(ILeafPileTypeSelectOberver ob)
        {
            this.ob = ob;
        }

        public void initLoad()
        {
            // 加载所有叶子桩类别
            this.cbbPileTypes.DataSource = CModelMgr.Inst.Db.PileType.loadAllLeafTypesDesc();
        }

        private void cbbPileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(null == this.ob)
            {
                return;
            }
            this.ob.onPileTypeSelectChanged(this.loadPileTypeById(getChosenTypeId()));
        }
        private string getChosenTypeId()
        {
            return this.cbbPileTypes.SelectedValue.ToString();
        }

        private CPileType loadPileTypeById(string chosenTypeId)
        {
            return CModelMgr.Inst.Db.PileType.loadEntById(chosenTypeId);
        }

        private ILeafPileTypeSelectOberver ob;
    }
}
