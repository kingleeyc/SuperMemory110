using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    public interface IFormPicChoice
    {
        void showRightPrompt();

        void showErrPrompt();

        void updateCountCorrect(int count);

        void updateCountErr(int count);

        void showReportDailog(SuperMemory.Entities.CPicChoiceMeaningReport cPicChoiceMeaningReport);
    }
}
