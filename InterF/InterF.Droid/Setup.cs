using Android.Content;
using InterF.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace InterF.Droid
{
    public class Setup : MvxAppCompatSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }

        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        //Register your Interface with the class when the application is launching.
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
            Mvx.RegisterSingleton<ICal>(new Calculation());
        }
    }
}
