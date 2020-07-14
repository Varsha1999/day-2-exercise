using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class MobileCatalog
    {
        List<Mobie> mobileList;

        internal MobileCatalog()
        {
            mobileList = new List<Mobie>();
        }

        internal void Add(Mobie mobile)
        {
            mobileList.Add(mobile);
            //mobileList.Add("My Mobile");
        }

        internal Mobie GetMobile(int mobileId)
        {
            foreach (Mobie mobile in mobileList)
            {
                if (mobile.GetProductId() == mobileId)
                {
                    return mobile;
                }
            }
            return null;
        }

        internal List<Mobie> GetMobiles()
        {
            return mobileList;
        }
    }
}
