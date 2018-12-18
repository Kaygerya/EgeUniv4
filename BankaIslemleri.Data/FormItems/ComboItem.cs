using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Data.FormItems
{
    public class ComboItem
    {
        public ComboItem()
        {

        }
        public ComboItem(string text, object value)
        {
            this.Text = text;
            this.Value = value;
        }

        public string Text { get; set; }
        public object Value { get; set; }
    }
}
