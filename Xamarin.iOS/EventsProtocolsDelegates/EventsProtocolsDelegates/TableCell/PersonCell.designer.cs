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

namespace EventsProtocolsDelegates.TableCell
{
	[Register ("PersonCell")]
	partial class PersonCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView im_Picture { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lb_Location { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lb_Name { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		EventsProtocolsDelegates.CustomUIComponent.UIRatingBar rb_Rating { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView vw_content { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (im_Picture != null) {
				im_Picture.Dispose ();
				im_Picture = null;
			}
			if (lb_Location != null) {
				lb_Location.Dispose ();
				lb_Location = null;
			}
			if (lb_Name != null) {
				lb_Name.Dispose ();
				lb_Name = null;
			}
			if (rb_Rating != null) {
				rb_Rating.Dispose ();
				rb_Rating = null;
			}
			if (vw_content != null) {
				vw_content.Dispose ();
				vw_content = null;
			}
		}
	}
}
