namespace asp.net7.Interfaces
{
    public interface IListPattern
    {
        bool Slice(int[] myNumbers);

        bool Contains(int[] myNumbers);

        string SliceAndDiscard(string[] urls);

        string Discard();
    }
}