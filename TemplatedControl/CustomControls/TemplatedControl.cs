using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemplatedControl.CustomControls
{
    [ParseChildren(true),
    PersistChildren(false)]
    public class TemplatedControl : WebControl
    {
        private ITemplate _contentTemplate;

        [PersistenceMode(PersistenceMode.InnerProperty),
        Browsable(false),
        TemplateInstance(TemplateInstance.Single)]
        public ITemplate MyTemplate
        {
            get
            {
                return this._contentTemplate;
            }
            set
            {
                this._contentTemplate = value;
                if (this._contentTemplate != null)
                {
                    var container = new Control();
                    this.Controls.Add(container);
                    this._contentTemplate.InstantiateIn(container);
                }
            }
        }
    }
}