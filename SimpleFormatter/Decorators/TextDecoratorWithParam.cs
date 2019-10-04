using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormatter.Decorators
{
    /// <summary>
    /// Base TextDecoratorWithParam
    /// </summary>
    abstract class TextDecoratorWithParam<T> : RichTextBox where T : class
    {
        protected RichTextBox _richTextBox = null;
        protected T _value = default(T);

        public TextDecoratorWithParam(RichTextBox richTextBox, T value)
        {
            _richTextBox = richTextBox;
            _value = value;
        }

        public abstract void Format();
    }
}
