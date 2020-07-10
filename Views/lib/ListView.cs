using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class ListView : System.Windows.Forms.ListView
    {

        public ListView()
        {
            this.FullRowSelect = true;
            this.GridLines = true;
            this.AllowColumnReorder = true;
            this.Sorting = SortOrder.None;
            this.MultiSelect = true;
        }
    }
}