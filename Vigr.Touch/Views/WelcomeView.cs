using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace Vigr.Touch
{
	public partial class WelcomeView : MvxViewController
	{
		public WelcomeView () : base ("WelcomeView", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var navController = base.NavigationController;
			navController.NavigationBarHidden = true;
			var set = this.CreateBindingSet<WelcomeView, Core.ViewModels.WelcomeViewModel>();
			set.Bind(AppName).To(vm => vm.AppName);


			set.Apply();
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

