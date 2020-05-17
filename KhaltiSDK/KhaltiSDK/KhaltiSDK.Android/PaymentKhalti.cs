using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Khalti.CheckOut.Helper;
using Com.Khalti.Utils;
using Java.Lang;
using KhaltiSDK.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(PaymentKhalti))]
namespace KhaltiSDK.Droid
{
    public class PaymentKhalti :  MakePaymentKhalti
    {
        Context currentContext = (MainActivity)Forms.Context;
        private Com.Khalti.CheckOut.Api.Config config;
        // Require Parameters
        System.String publicKey = Constant.Pub;
        Long amount = (Long)100L; // In Paisa    

        public void getDataKhalti(string amt, string productName, string uniqueId)
        {
            Long val = Long.ValueOf(amt);
            Long amount = val;
            config = new Com.Khalti.CheckOut.Api.Config(publicKey, uniqueId, productName, "", amount, new myKhalticlass());
            KhaltiCheckOut khaltiCheckOut2 = new KhaltiCheckOut(currentContext, config);
            khaltiCheckOut2.Show();
        }


    }
}