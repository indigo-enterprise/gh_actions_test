namespace Indigo.Core.PackageTest
{
    public static class CustomConvert
    {
        //public static T ConvertTo<T>(this object value)
        //{
        //    if (value is T)
        //    {
        //        return (T)value;
        //    }
        //    else
        //    {
        //        return default(T);
        //    }
        //}

        public static string AsString(this object value)
        {
            return value.ToString();
        }
    }
}
