using System;

using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class When : StoryPart
    {
        public When(Fragment fragment)
            : base(fragment)
        {
        }

        public When(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "When";
            }
        }

        public WhenAnd And(string storyPart, Action action)
        {
            return new WhenAnd(new Fragment(storyPart, action), this);
        }

        public Then Then(string storyPart, Action action)
        {
            return new Then(new Fragment(storyPart, action), this);
        }

        public SoThat SoThat(string storyPart)
        {
            return new SoThat(new Fragment(storyPart), this);
        }

        public void Start()
        {
            this.Execute();
        }
    }
}