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
using InterF.Core;

namespace InterF.Droid
{
    //Calculation class. Note that the Interface naming (ICal)
    public class Calculation:ICal
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}