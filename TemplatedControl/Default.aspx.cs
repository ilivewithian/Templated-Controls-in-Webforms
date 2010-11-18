using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemplatedControl
{
    public partial class Default : System.Web.UI.Page
    {
        protected void SampleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            HiddenButton.Visible = SampleDropDown.SelectedIndex == 1;
        }
    }
}