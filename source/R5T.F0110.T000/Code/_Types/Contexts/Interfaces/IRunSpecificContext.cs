using System;

using R5T.T0137;
using R5T.T0175;

using R5T.F0110.T001;


namespace R5T.F0110.T000.RunSpecific
{
    namespace N001
    {
        [ContextTypeMarker]
        public interface IRunSpecificContext : IContextTypeMarker
        {
            public Timestamp Start { get; }
        }
    }


    namespace N002
    {
        [ContextTypeMarker]
        public interface IRunSpecificContext : IContextTypeMarker
        {
            public Timestamp Start { get; }
            public RunSpecificDirectoryPath DirectoryPath { get; }
        }
    }
}
