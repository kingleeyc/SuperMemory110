using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMemory.Utils
{
    public class CStringUtils
    {
        private CStringUtils() { }
        private static CStringUtils inst = new CStringUtils();

        public static CStringUtils Inst
        {
            get { return CStringUtils.inst; }
        }
        /// <summary>
        /// 字符串是否都是数字
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public bool isNumber(string strIn)
        {
            try
            {
                int i = int.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判断字符串是否都是汉字
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public bool isChineseWord(string strIn)
        {
            bool ret = false;
            for (int i = 0; i < strIn.Length;i++ )
            {
                if((int)strIn[i] > 127)
                {
                    ret = true;
                }
            }
            return ret;
        }
    }
}
