// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Vigr.Touch
{
	[Register ("WelcomeView")]
	partial class WelcomeView
	{
		[Outlet]
		UIKit.UILabel AppName { get; set; }

		[Outlet]
		UIKit.UIButton SignUpButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AppName != null) {
				AppName.Dispose ();
				AppName = null;
			}

			if (SignUpButton != null) {
				SignUpButton.Dispose ();
				SignUpButton = null;
			}
		}
	}
}
