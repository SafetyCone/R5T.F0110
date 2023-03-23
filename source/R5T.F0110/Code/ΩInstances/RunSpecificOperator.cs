using System;


namespace R5T.F0110
{
    public class RunSpecificOperator : IRunSpecificOperator
    {
        #region Infrastructure

        public static IRunSpecificOperator Instance { get; } = new RunSpecificOperator();


        private RunSpecificOperator()
        {
        }

        #endregion
    }
}
