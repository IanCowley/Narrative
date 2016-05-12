using System;

using Narrative.Extensions;
using Narrative.Output;

namespace Narrative.Fragments
{
    public class Fragment
    {
        private readonly string storyPart;

        private readonly Action action;

        public Fragment(string storyPart) : this(storyPart, null)
        {
           
        }

        public Fragment(string storyPart, Action action)
        {
            this.storyPart = storyPart;
            this.action = action;
        }

        public void Execute(string storyPartIdentifier)
        {
            var storyPartDescription = "{0} {1}".FormatString(storyPartIdentifier, this.storyPart);
            StoryOutput.WriteLine(storyPartDescription);

            if (this.action != null)
            {
                this.action();
            }
        }
    }
}