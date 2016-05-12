using System;

using Narrative.Fragments;
using Narrative.StoryParts;

namespace Narrative
{
    public class Story
    {
        public static AsA AsA(string storyPart, Action action)
        {
            return new AsA(new Fragment(storyPart, action));
        }

        public static Given Given(string storyPart, Action action)
        {
            return new Given(new Fragment(storyPart, action));
        }
    }
}
