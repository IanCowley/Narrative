using Narrative.Fragments;
using Narrative.StoryParts;

namespace Narrative
{
    public class SoThat : StoryPart
    {
        public SoThat(Fragment fragment)
            : base(fragment)
        {
        }

        public SoThat(Fragment fragment, StoryPart parentStoryPart)
            : base(fragment, parentStoryPart)
        {
        }

        public void Start()
        {
            this.Execute();
        }

        protected override string StoryPartIdentifier
        {
            get
            {
                return "So that";
            }
        }
    }
}