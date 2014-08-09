using System;
using System.Collections.Generic;
using System.Drawing;
using EventsProtocolsDelegates.Models;
using EventsProtocolsDelegates.TableSources;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Threading.Tasks;

namespace EventsProtocolsDelegates
{
    public partial class TabeViewController : UITableViewController
    {
        private PersonsTableSource PersonsTableSource = new PersonsTableSource();
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public TabeViewController(IntPtr handle)
            : base(handle)
        {
            try
            {
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        //private async Task PopulateWithPersons()
        private void PopulateWithPersons()
        {
            try
            {
                List<Person> persons = new List<Person>();
                Person p1 = new Person()
                {
                    Name = "Flavius Demian",
                    Country = "Arad, Romania",
                    IsOnline = true,
                    Rating = 3.5,
                    Image = "Images/me.png"
                };
                persons.Add(p1);
                Person p2 = new Person()
                {
                    Name = "Constantin Georgiu",
                    Country = "Timisoara, Romania",
                    IsOnline = false,
                    Rating = 2.5,
                    Image = "Images/me.png"
                };
                persons.Add(p2);
                Person p3 = new Person()
                {
                    Name = "Mariana Demian",
                    Country = "Resita, Romania",
                    IsOnline = true,
                    Rating = 4.5,
                    Image = "Images/me.png"
                };
                persons.Add(p3);
                PersonsTableSource.DataSource = persons;

                //await Task.Delay(TimeSpan.FromMilliseconds(1));

                if (tbv_Persons != null)
                {
                    tbv_Persons.Source = PersonsTableSource;
                }
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
            PopulateWithPersons();
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
    }
}