using Cirrious.MvvmCross.ViewModels;

namespace Vigr.Core.ViewModels
{
	public class WelcomeViewModel: MvxViewModel
	{
		public WelcomeViewModel ()
		{
		}

		private string _AppName = "FitOne";
		public string AppName
		{ 
			get { return _AppName; }
			set { _AppName = value; RaisePropertyChanged(() => AppName); }
		}
	}
}

