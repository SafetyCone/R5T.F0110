using System;

using R5T.T0132;


namespace R5T.F0110.T001
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public RunSpecificDirectoryPath ToRunSpecificDirectoryPath(string value)
        {
            var output = new RunSpecificDirectoryPath(value);
            return output;
        }
    }
}
