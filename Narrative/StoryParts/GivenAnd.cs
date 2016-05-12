using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class GivenAnd : Given
    {
        public GivenAnd(Fragment fragment)
            : base(fragment)
        {
        }

        public GivenAnd(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "And";
            }
        }
    }
}