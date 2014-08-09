using System;
using System.ComponentModel;
using EventsProtocolsDelegates.CustomUIComponent;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Newtonsoft.Json;

namespace EventsProtocolsDelegates.TableCell
{
    [Register("PersonCell"), Browsable(true)]
    public class PersonCell : UITableViewCell
    {
        private UILabel lb_Name, lb_Location;
        private UIImageView im_Picture, im_State;
        private UIRatingBar rb_Rating;

        public PersonCell(NSString cellId)
            : base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Blue;

            ContentView.BackgroundColor = UIColor.Cyan;

            lb_Name = new UILabel();
            lb_Location = new UILabel();
            im_Picture = new UIImageView();
            im_State = new UIImageView();
            rb_Rating = new UIRatingBar(1.5);

            //ContentView.Add(lb_Name);
            //ContentView.Add(lb_Location);
            //ContentView.Add(im_Picture);
            //ContentView.Add(im_State);
            //ContentView.Add(rb_Rating);
        }

        public void UpdateCell(string name, string country, string picture, bool isOnline, double rating)
        {
            try
            {
                lb_Name.Text = name;
                lb_Location.Text = country;
                rb_Rating.setRatings(rating);
                im_Picture.Image = UIImage.FromFile(picture);
                im_State.Image = isOnline == true ? UIImage.FromFile("Images/offline.png") : UIImage.FromFile("Images/online.png");
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
                //lb_Name.Frame = new RectangleF();
                //lb_Location.Frame = new RectangleF();
                //im_Picture.Frame = new RectangleF(ContentView.Bounds.Width - 63, 5, 33, 33);
                //im_State.Frame = new RectangleF(5, 4, ContentView.Bounds.Width - 63, 25);
                //rb_Rating.Frame = new RectangleF(100, 18, 100, 20);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        internal void UpdateCell(UIView[] childrennViews)
        {
            int x = 0;
            try
            {
                Console.WriteLine("serializing....");
                Console.WriteLine(JsonConvert.SerializeObject(childrennViews));
                foreach (var childView in childrennViews)
                {
                    x++;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}