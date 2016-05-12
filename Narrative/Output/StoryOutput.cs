using System;

using Narrative.Extensions;

namespace Narrative.Output
{
    public class StoryOutput
    {
        public static string Trace { get; set; }

        public static void WriteLine(string content, params object[] args)
        {
            Console.WriteLine(content, args);
            Trace += content.FormatString(content, args);
        }
    }
}
