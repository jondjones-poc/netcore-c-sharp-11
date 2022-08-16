namespace asp.net7
{
    public class Nullable
    {
        public required string MyProp { get; set; }

        public Nullable(string name)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);

        }
    }
}
