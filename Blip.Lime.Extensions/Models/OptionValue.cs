using System;
using System.Collections.Generic;
using System.Text;

namespace Blip.Lime.Extensions.Models
{
    public abstract class OptionValue<T>
    {
    }

    public class StringOptionValue : OptionValue<string>
    {
        public StringOptionValue()
        {

        }
    }

    public class UriOptionValue : OptionValue<Uri>
    {

    }
}
