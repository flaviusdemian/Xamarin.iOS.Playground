using System;
using System.ComponentModel;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace EventsProtocolsDelegates.CustomUIComponent
{
    [Register("UIRatingBar"), Browsable(true)]
    public class UIRatingBar : UIView
    {
        public SizeF imageSize;

        public UIRatingBar(IntPtr p)
            : base(p)
        {
        }

        public UIRatingBar(RectangleF rect)
            : base(rect)
        {
        }

        public UIRatingBar(SizeF size, PointF position)
            : base(new RectangleF(position.X, position.Y, size.Width, size.Height))
        {
            try
            {
                imageSize = new SizeF(size.Width / 5, size.Height);
                ratingPoint = RBRating.rb0;
                float x = 0;
                for (int i = 0; i < 5; i++)
                {
                    //[this addSubview:[self imageViewWithFrame:CGRectMake(x, 0, imageSize.width, imageSize.height) andTag:i+1]];
                    AddSubview(imageViewWithFrame(new RectangleF(x, 0, imageSize.Width, imageSize.Height), i + 1));
                    x += imageSize.Width;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public RBRating ratingPoint { get; set; }

        public void addRating()
        {
            try
            {
                RectangleF rect = Frame;
                imageSize = new SizeF(rect.Width / 5, rect.Height);
                ratingPoint = RBRating.rb0;
                float x = 0;
                for (int i = 0; i < 5; i++)
                {
                    //[this addSubview:[self imageViewWithFrame:CGRectMake(x, 0, imageSize.width, imageSize.height) andTag:i+1]];
                    AddSubview(imageViewWithFrame(new RectangleF(x, 0, imageSize.Width, imageSize.Height), i + 1));
                    x += imageSize.Width;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public UIImageView imageViewWithFrame(RectangleF rect, int itag)
        {
            UIImageView image = null;
            try
            {
                image = new UIImageView(rect);
                image.Image = UIImage.FromFile("Images/emptyStar.png");
                image.Tag = itag;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return image;
        }

        /*
         * -(UIImageView*)imageViewAtIndex:(int)index
{
   return  (UIImageView*)[self viewWithTag:index];
}
            */

        public UIImageView imageViewAtIndex(int index)
        {
            UIImageView image = null;
            try
            {
                image = (UIImageView)(ViewWithTag(index));
                if (image != null)
                {
                    int x = 0;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return image;
        }

        public void fillStartillPoint(PointF point)
        {
            try
            {
                Console.Write("\nPresssss");
                //if (point.X < imageSize.Width / 2 && point.X > 0)
                {
                    Console.Write("\nFirst");
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb1_h;
                }
                if (point.X < imageSize.Width * 2 && point.X >= imageSize.Width / 2)
                {
                    Console.Write("\nSirst");


                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb1;
                }
                if (point.X < imageSize.Width * 2 - imageSize.Width / 2 && point.X >= imageSize.Width)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb2_h;
                }
                //if (point.X<imageSize.Width*3 && point.X>=imageSize.Width*3-imageSize.Width/2) {
                if (point.X < imageSize.Width * 2 && point.X >= imageSize.Width * 2 - imageSize.Width / 2)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb2;
                }
                if (point.X < imageSize.Width * 3 - imageSize.Width / 2 && point.X >= imageSize.Width * 2)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb3_h;
                }
                if (point.X < imageSize.Width * 3 && point.X >= imageSize.Width * 3 - imageSize.Width / 2)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb3;
                }
                if (point.X < imageSize.Width * 4 - imageSize.Width / 2 && point.X >= imageSize.Width * 3)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb4_h;
                }
                if (point.X < imageSize.Width * 4 && point.X >= imageSize.Width * 4 - imageSize.Width / 2)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");


                    ratingPoint = RBRating.rb4;
                }
                if (point.X < imageSize.Width * 5 - imageSize.Width / 2 && point.X >= imageSize.Width * 4)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/fullStart.png");


                    ratingPoint = RBRating.rb5_h;
                }
                if (point.X < imageSize.Width * 5 && point.X >= imageSize.Width * 5 - imageSize.Width / 2)
                {
                    //[[self imageViewAtIndex:1] setImage:[UIImage imageNamed:@"hf.png"]];
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/fullStart.png");


                    ratingPoint = RBRating.rb5;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public int getcurrentRatings()
        {
            //AppDelegate.showAlert (""+(int)ratingPoint);
            return (int)ratingPoint;
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            var touch = (UITouch)touches.AnyObject;

            PointF pt = touch.LocationInView(this);

            if ((pt.X >= 0 && pt.X <= Frame.Size.Width) && (pt.Y > 0 && pt.Y <= Frame.Size.Height))
            {
                //[self fillStartillPoint:pt];
                fillStartillPoint(pt);
            }
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);

            var touch = (UITouch)touches.AnyObject;
            PointF pt = touch.LocationInView(this);

            if ((pt.X >= 0 && pt.X <= Frame.Size.Width) && (pt.Y > 0 && pt.Y <= Frame.Size.Height))
            {
                //[self fillStartillPoint:pt];
                fillStartillPoint(pt);
            }
        }

        public void setRatings(double rate1)
        {
            try
            {
                var rate = (RBRating)rate1;
                ratingPoint = rate;

                if (rate == RBRating.rb0)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb1_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/halfStar.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb1)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb2_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/halfStar.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb2)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb3_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/halfStar.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb3)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/emptyStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb4_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/halfStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb4_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/halfStar.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb4)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/emptyStar.png");
                }
                if (rate == RBRating.rb5_h)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/halfStar.png");
                }
                if (rate == RBRating.rb5)
                {
                    imageViewAtIndex(1).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(2).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(3).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(4).Image = UIImage.FromFile("Images/fullStart.png");
                    imageViewAtIndex(5).Image = UIImage.FromFile("Images/fullStart.png");
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}