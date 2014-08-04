using System;
using System.Drawing;
using EventsProtocolsDelegates.CustomUIComponent;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EventsProtocolsDelegates
{
    public partial class MainViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public MainViewController(IntPtr handle)
            : base(handle)
        {
            try
            {
                //SizeF ratingBarSize = new Size(100, 23);
                //PointF ratingBarLocation = new PointF(20, 50);
                //UIRatingBar ratingBar = new UIRatingBar(ratingBarSize, ratingBarLocation);
                //ratingBar.setRatings((int)RBRating.rb2_h);

                //SizeF containerBarSize = new Size(200, 50);
                //PointF containerBarLocation = new PointF(20, 50);

                //UIView containerView = new UIView(new RectangleF(containerBarLocation, containerBarSize));
                //containerView.AddSubview(ratingBar);

                //this.View.AddSubview(containerView);
                //UIButton button = new UIButton();
                //button.SetTitle("AAA", UIControlState.Normal);
                //button.BackgroundColor = UIColor.Red;
                //this.View.AddSubview(button);
                //this.View.Add(button);
                //rb_Rating.setRatings(2);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion


        partial void btn_GoBack_TouchUpInside(UIButton sender)
        {
            Console.WriteLine("Back to Main pressed");
            DismissViewController(true, null);
        }

        partial void btn_CheckRating_TouchUpInside(UIButton sender)
        {
            try
            {
                SizeF size = new Size(100, 23);
                PointF location = new PointF(20, 50);
                rb_Rating = new UIRatingBar(size, location);
                rb_Rating.setRatings(2);
                View.AddSubview(rb_Rating);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}