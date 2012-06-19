using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Tocsoft.Umbraco.RazorComponents
{
    public class LazyHtmlString : IHtmlString
    {
        Lazy<string> _controlRenderer;

        public LazyHtmlString(Func<string> getString)
        {
            _controlRenderer = new Lazy<string>(getString);
        }

        public string Html
        {
            get
            {
                return _controlRenderer.Value;
            }
        }

        public override string ToString()
        {
            return Html;
        }

        public string ToHtmlString()
        {
            return Html;
        }
    }
}