using Narrative.Fragments;

namespace Narrative.StoryParts
{
    public abstract class StoryPart
    {
        protected StoryPart(Fragment fragment) : this(fragment, null)
        {
        }

        protected StoryPart(Fragment fragment, StoryPart parentStoryPart)
        {
            this.fragment = fragment;
            this.parentStoryPart = parentStoryPart;
        }

        protected Fragment fragment;

        protected StoryPart parentStoryPart;

        protected abstract string StoryPartIdentifier { get; }

        public void Execute()
        {
            if (this.parentStoryPart != null)
            {
                this.parentStoryPart.Execute();
            }

            this.fragment.Execute(this.StoryPartIdentifier);
        }
    }
}