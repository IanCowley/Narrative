using System;

using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class Then : StoryPart
    {
        public Then(Fragment fragment)
            : base(fragment)
        {
        }

        public Then(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "Then";
            }
        }

        public ThenAnd And(string storyPart, Action action)
        {
            return new ThenAnd(new Fragment(storyPart, action), this);
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