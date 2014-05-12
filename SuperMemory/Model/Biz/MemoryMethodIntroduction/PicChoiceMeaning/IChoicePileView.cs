using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    public interface IChoicePileView
    {
        CPile Pile
        {
            set;
        }

        int ChoiceType
        {
            set;
        }
    }
}
