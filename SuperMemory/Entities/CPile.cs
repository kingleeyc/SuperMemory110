using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Entities
{
    /// <summary>
    /// 110 Êý×ÖÐ³Òô¼ÇÒä×®
    /// </summary>
    public class CPile
    {
        /// <summary>
        /// ×®Í¼
        /// </summary>
        private string pic;

        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        /// <summary>
        /// ×®ºÅ
        /// </summary>
        private string pileNumber;

        public string PileNumber
        {
            get { return pileNumber; }
            set { pileNumber = value; }
        }

        /// <summary>
        /// ×®´Ê(Ð³Òô´Ê)
        /// </summary>
        private string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        /// <summary>
        /// ½ÇÉ«
        /// </summary>
        private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        /// <summary>
        /// Öú¼Ç¶¯×÷
        /// </summary>
        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        /// <summary>
        /// Ô­Ê¼Ë³Ðò:Êý×Ö×ÔÈ»Ë³Ðò
        /// </summary>
        private int primOrder;

        public int PrimOrder
        {
            get { return primOrder; }
            set { primOrder = value; }
        }
        /// <summary>
        /// ×®Àà±ðid
        /// </summary>
        private string pileTypeId;

        public string PileTypeId
        {
            get { return pileTypeId; }
            set { pileTypeId = value; }
        }
    }
}
