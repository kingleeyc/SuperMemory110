using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;
using SuperMemory.Enums;

namespace SuperMemory.Views.UserControls.Common
{
    public interface IPileView
    {
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

        void markCorrect();

        void markError();

        void cleanMark();

        void cleanData();

        void unChoice();


    }
}
