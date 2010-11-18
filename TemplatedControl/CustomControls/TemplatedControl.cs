using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemplatedControl.CustomControls
{
    public class TemplatedControl : WebControl
    {
        public TemplatedControl()
            : base(HtmlTextWriterTag.Div)
        {

        }

        private ITemplate _myTemplate;
        [TemplateInstance(TemplateInstance.Single)]
        public ITemplate MyTemplate
        {
            get
            {
                return this._myTemplate;
            }
            set
            {
                this._myTemplate = value;
                if (this._myTemplate != null)
                {
                    var container = new Control();
                    base.Controls.Add(container);
                    _myTemplate.InstantiateIn(container);
                }
            }
        }
    }
}