using System;

namespace JaapIsAwesome
{
    [JaapIsAwesome]
    public class JaapIsAwesomeAttribute : Attribute
    {
        [JaapIsAwesome]
        private JaapIsAwesome JaapIsAwesome()
        {
            return new JaapIsAwesome();
        }
    }
}