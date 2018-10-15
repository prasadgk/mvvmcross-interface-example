using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace InterF.Core.ViewModels
{
    public class FirstViewModel: MvxViewModel
    {
        public int _numone = 0;
        public int _numtwo = 0;
        private ICal recevier = null;
        public int _result = 0;

        public FirstViewModel()
        {
            recevier = Mvx.Resolve<ICal>();
        }
        public int NumOne
        {
            get { return _numone; }
            set { SetProperty(ref _numone, value); }
        }
        public int NumTwo
        {
            get { return _numtwo; }
            set { SetProperty(ref _numtwo, value); }
        }
        public int Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }
        public IMvxCommand CalcEve
        {
            get { return new MvxCommand(Calculate); }
        }

        public void Calculate()
        {
            Result = recevier.Add(NumOne, NumTwo);
        }
    }
}
