using System.Collections.Generic;
using System.Linq;
using System;

namespace TestLib
{
    public static class Replace
    {
        public static (List<int>, List<String>) ChangeListInt(List<Object> lst)
        {
            List<int> newLst = new List<int>();
            List<String> errorLst = new List<String>();
            for (int i = 0; i < lst.Count; i++)
            {
                int itemInt = new int();
                if (int.TryParse(lst[i],out itemInt))
                //try
                //{
                //    int itemInt = (int)lst[i];
                //    if (itemInt < 0 && itemInt % 2 == 0)
                //    {
                //        int res = itemInt * itemInt;
                //        newLst.Append(res);
                //    }
                //}
                //catch (Exception ex) {
                //{
                //    errorLst.Append(ex.Message);  
                //}
            }
            return (newLst, errorLst);
        }
    }
}
