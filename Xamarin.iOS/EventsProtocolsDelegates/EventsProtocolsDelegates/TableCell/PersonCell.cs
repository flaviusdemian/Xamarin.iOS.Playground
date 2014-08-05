using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using EventsProtocolsDelegates.CustomUIComponent;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EventsProtocolsDelegates.TableCell
{
    public class PersonCell : UITableViewCell
    {
        private UILabel lb_Name, lb_Location;
        private UIImageView im_Picture, im_State;
        private UIRatingBar rb_Rating;

        public PersonCell()
        {

        }

        public void UpdateCell(string name, string location, string picture, bool isOnline, double rating)
        {
            try
            {
                lb_Name.Text = name;
                lb_Location.Text = location;
                rb_Rating.setRatings(rating);
                im_Picture.Image = UIImage.FromFile(picture);
                im_State.Image = isOnline == true ? UIImage.FromFile("") : UIImage.FromFile("");
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public override void LayoutSubviews()
        {
            try
            {
                base.LayoutSubviews();
                lb_Name.Frame = new RectangleF();
                lb_Location.Frame = new RectangleF();
                im_Picture.Frame = new RectangleF(ContentView.Bounds.Width - 63, 5, 33, 33);
                im_State.Frame = new RectangleF(5, 4, ContentView.Bounds.Width - 63, 25);
                rb_Rating.Frame = new RectangleF(100, 18, 100, 20);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}