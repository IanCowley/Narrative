using System;

using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class AsA : StoryPart
    {
        public AsA(Fragment fragment)
            : base(fragment)
        {
        }

        public AsA(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "As a";
            }
        }

        public Given Given(string storyPart, Action action)
        {
            return new Given(new Fragment(storyPart, action), this);
        }
    }
}