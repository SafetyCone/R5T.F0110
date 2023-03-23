using System;


namespace R5T.F0110.T001.Extensions
{
    public static class StringExtensions
    {
        public static RunSpecificDirectoryPath ToRunSpecificDirectoryPath(this string value)
        {
            return Instances.StringOperator.ToRunSpecificDirectoryPath(value);
        }
    }
}
