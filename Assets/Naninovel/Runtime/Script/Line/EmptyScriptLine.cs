using System;

namespace Naninovel
{
    [Serializable]
    public class EmptyScriptLine : ScriptLine
    {
        public EmptyScriptLine (int lineIndex)
            : base(lineIndex, string.Empty) { }
    }
}
