namespace asp.net7
{
    public static class RawStringExmaple
    {
        public static string GetRawStringMulitline()
        {
            return """ 
                Hello "quote"
                    another 'single quote'
                """;
        }

        public static string GetRawStringSingleline()
        {
            return """ Hello "quote" """;
        }

        public static string ImprovedStringInterpolation()
        {
            return $"Hello {
                        GetRawStringMulitline()
                    } dsdsdsdsdsdd {
                GetRawStringSingleline()} dsdsds {
                "ddd" }";
        }
    }
}