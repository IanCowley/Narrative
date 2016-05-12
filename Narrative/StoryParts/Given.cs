using System;

using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class Given : StoryPart
    {
        public Given(Fragment fragment)
            : base(fragment)
        {
        }

        public Given(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "Given";
            }
        }

        public GivenAnd And(string storyPart, Action action)
        {
            return new GivenAnd(new Fragment(storyPart, action), this);
        }

        public When When(string storyPart, Action action)
        {
            return new When(new Fragment(storyPart, action), this);
        }

        public Then Then(string storyPart, Action action)
        {
            return new Then(new Fragment(storyPart, action), this);
        }
    }
}