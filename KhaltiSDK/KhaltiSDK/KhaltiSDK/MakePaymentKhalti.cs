using System;
using System.Collections.Generic;
using System.Text;

namespace KhaltiSDK
{
    public interface MakePaymentKhalti
    {
        void getDataKhalti(string amt, string productName, string uniqueId);
    }
}
