using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.F0110.T001
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class RunSpecificDirectoryPath : TypedString, IStrongTypeMarker
    {
        public RunSpecificDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
