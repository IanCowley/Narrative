using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public class ThenAnd : Then
    {
        public ThenAnd(Fragment fragment)
            : base(fragment)
        {
        }

        public ThenAnd(Fragment fragment, StoryPart parentStoryPart)
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