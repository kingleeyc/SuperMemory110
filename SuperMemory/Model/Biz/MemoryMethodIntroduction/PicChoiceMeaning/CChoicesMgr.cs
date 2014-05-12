using System;
using System.Collections.Generic;
using System.Text;
using SuperMemory.Entities;

namespace SuperMemory.Model.Biz.MemoryMethodIntroduction.PicChoiceMeaning
{
    class CChoicesMgr
    {
        public const int CHOICE_TYPE_NUMBER = 1;
        public const int CHOICE_TYPE_WORD = 2;
        public const int CHOICE_TYPE_ROLE = 3;
        public const int CHOICE_TYPE_ACTION = 4;

        private const int CHOICES_COUNT = 4;

        public CChoicesMgr(CPicChoiceMeaningBiz ownerBiz)
        {
            this.ownerBiz = ownerBiz;
        }       

        internal void nextChoices()
        {
            this.choices.Clear();
            this.choices.Add(this.ownerBiz.CurPicPile);
            this.getRand3OtherChoices();

            this.randChoicesOrder();
            this.updateChoicePiles2View();
        }

        internal void clean()
        {
            this.choices.Clear();

            if (null == this.curChoicePilesGroupView)
            {
                return;
            }

            for (int i = 0; i < CHOICES_COUNT; i++)
            {
                this.curChoicePilesGroupView.set1ChoisePile(i, null);
            }
        }

        private void updateChoicePiles2View()
        {
            for (int i = 0; i < CHOICES_COUNT; i++)
            {
                this.curChoicePilesGroupView.set1ChoisePile(i, this.choices[i]);
            }


        }

        private void randChoicesOrder()
        {
            Random rand = new Random();

            new CPilesCopyUtil().copyPiles(this.choices, this.tempPiles);
            this.choices.Clear();

            CPile nextChoicePile;
            for (int i = 0; i < CHOICES_COUNT; i++)
            {
                nextChoicePile = this.tempPiles[rand.Next(this.tempPiles.Count)];
                this.choices.Add(nextChoicePile);
                this.tempPiles.Remove(nextChoicePile);
            }

        }


        private void getRand3OtherChoices()
        {
            new CPilesCopyUtil().copyPiles(this.ownerBiz.AllCurTypePiles, this.tempPiles);
            this.tempPilesRemoveCurPicPile();

            Random rand = new Random();
            for (int i = 1; i < CHOICES_COUNT; i++)
            {
                this.choices.Add(this.getRandOtherNextChoicePile(rand));
            }
        }


        private void tempPilesRemoveCurPicPile()
        {
            foreach (CPile pile in this.tempPiles)
            {
                if (pile.PrimOrder == this.ownerBiz.CurPicPile.PrimOrder)
                {
                    this.tempPiles.Remove(pile);
                    return;
                }
            }
        }

        

        private CPile getRandOtherNextChoicePile(Random rand)
        {
            CPile ret = this.tempPiles[rand.Next(this.tempPiles.Count)];
            this.tempPiles.Remove(ret);// 保证不重复
            return ret;

        }

        private IChoicePilesGroupView curChoicePilesGroupView;

        public IChoicePilesGroupView CurChoicePilesGroupView
        {
            get { return curChoicePilesGroupView; }
            set { curChoicePilesGroupView = value; }
        }

        private List<CPile> tempPiles = new List<CPile>();
        private List<CPile> choices = new List<CPile>();

        private CPicChoiceMeaningBiz ownerBiz;


    }
}
