using System;

using R5T.T0132;
using R5T.T0175.Extensions;

using R5T.F0110.T001.Extensions;


namespace R5T.F0110
{
    [FunctionalityMarker]
    public partial interface IRunSpecificOperator : IFunctionalityMarker
    {
        public T000.RunSpecific.N001.RunSpecificContext Get_RunSpecificContext(
            DateTime startTimestamp)
        {
            var output = new T000.RunSpecific.N001.RunSpecificContext
            {
                Start = startTimestamp.ToTimestamp(),
            };

            return output;
        }

        public T000.RunSpecific.N002.RunSpecificContext Get_RunSpecificContext(
            DateTime startTimestamp,
            Func<string> getDirectoryPath)
        {
            var directoryPath = getDirectoryPath();

            var output = new T000.RunSpecific.N002.RunSpecificContext
            {
                DirectoryPath = directoryPath.ToRunSpecificDirectoryPath(),
                Start = startTimestamp.ToTimestamp(),
            };

            return output;
        }

        public void InRunSpecificContext_Synchronous(
            DateTime startTimestamp,
            Action<T000.RunSpecific.N001.IRunSpecificContext> action)
        {
            var context = this.Get_RunSpecificContext(startTimestamp);

            action(context);
        }

        public void InRunSpecificContext_Synchronous(
            DateTime startTimestamp,
            Func<string> getDirectoryPath,
            Action<T000.RunSpecific.N002.IRunSpecificContext> action)
        {
            var context = this.Get_RunSpecificContext(
                startTimestamp,
                getDirectoryPath);

            action(context);
        }
    }
}
