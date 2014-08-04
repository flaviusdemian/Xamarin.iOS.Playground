using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using EventsProtocolsDelegates.Models;

namespace EventsProtocolsDelegates.TableSources
{
    public class PersonsTableSource : UITableViewSource
    {
        string CellIdentifier = "TableCell";
        public List<Person> DataSource { get; set; }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            // if there are no cells to reuse, create a new one
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }
            cell.TextLabel.Text = DataSource[indexPath.Row].Name;
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