using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Enums;

namespace SuperMemory.Views.UserControls.Common
{
    public interface IRadioPileView
    {
        void setGroup(IRadioPileViewGroup group);
        int RadioId
        {
            set;
            get;
        }

        void unChoice();

        CPile PileData
        {
            set;
            get;
        }

        EnumPileDataFiled DataViewFiled
        {
            set;
            get;
        }

        void cleanData();

        void cleanMark();
    }
}
