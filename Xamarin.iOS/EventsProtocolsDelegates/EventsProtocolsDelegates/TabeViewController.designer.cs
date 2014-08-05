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
	[Register ("TabeViewController")]
	partial class TabeViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tbv_Persons { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (tbv_Persons != null) {
				tbv_Persons.Dispose ();
				tbv_Persons = null;
			}
		}
	}
}
