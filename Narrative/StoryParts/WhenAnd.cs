using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class WhenAnd : When
    {
        public WhenAnd(Fragment testFragment)
            : base(testFragment)
        {
        }

        public WhenAnd(Fragment testFragment, StoryPart parentStoryPart)
            : base(testFragment, parentStoryPart)
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