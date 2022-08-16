namespace asp.net7
{
    public class GenericAttributeExample<T1> : Attribute
    {
    }

    public class ClassicAttribute : Attribute
    {
        public ClassicAttribute(object type)
        {

        }
    }
}