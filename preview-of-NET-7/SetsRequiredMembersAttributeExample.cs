using System.Diagnostics.CodeAnalysis;

namespace asp.net7
{
    public class SetsRequiredMembersAttributeExample : Base
    {
        public required string MySecondProp { get; set; }

        [SetsRequiredMembers]
        public SetsRequiredMembersAttributeExample(int unused)
            : base(unused)
        {
            MySecondProp = "";
        }
    }

    public class Base
    {
        public required string MyProp { get; set; }

        [SetsRequiredMembers]
        public Base(int unused)
        {
            MyProp = "";
        }
    }
}
