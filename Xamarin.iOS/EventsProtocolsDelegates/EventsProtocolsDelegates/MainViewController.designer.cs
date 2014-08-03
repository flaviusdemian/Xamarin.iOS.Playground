// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace EventsProtocolsDelegates
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_GoBack { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_goForward { get; set; }

		[Action ("btn_GoBack_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_GoBack_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn_GoBack != null) {
				btn_GoBack.Dispose ();
				btn_GoBack = null;
			}
			if (btn_goForward != null) {
				btn_goForward.Dispose ();
				btn_goForward = null;
			}
		}
	}
}
