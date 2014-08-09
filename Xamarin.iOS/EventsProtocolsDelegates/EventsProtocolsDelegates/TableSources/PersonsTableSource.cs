using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventsProtocolsDelegates.TableCell;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using EventsProtocolsDelegates.Models;

namespace EventsProtocolsDelegates.TableSources
{
    public class PersonsTableSource : UITableViewSource
    {
        NSString CellIdentifier = new NSString("TableCell");
        public List<Person> DataSource { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            PersonCell cell = tableView.DequeueReusableCell(CellIdentifier) as PersonCell;
            // if there are no cells to reuse, create a new one
            if (cell == null)
            {
                cell = new PersonCell(CellIdentifier);
            }
            if (DataSource != null)
            {
                try
                {
                    Person currentPerson = DataSource[indexPath.Row];
                    //cell.UpdateCell(currentPerson.Name, currentPerson.Country, currentPerson.Image, currentPerson.IsOnline, currentPerson.Rating);
                    cell.UpdateCell(cell.Subviews);
                }
                catch (Exception ex)
                {
                    ex.ToString();
                }
            }
            return cell;
        }

        public override int RowsInSection(UITableView tableview, int section)
        {
            if (DataSource == null)
            {
                return 0;
            }
            return DataSource.Count;
        }
    }
}