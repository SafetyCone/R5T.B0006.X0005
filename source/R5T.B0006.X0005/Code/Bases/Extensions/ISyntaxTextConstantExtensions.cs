using System;

using R5T.B0006;

using Instances = R5T.B0006.X0005.Instances;


namespace System
{
    public static class ISyntaxTextConstantExtensions
    {
        public static string UsingSystemNamespace(this ISyntaxTextConstant _)
        {
            var output = Instances.SyntaxTextValues.UsingSystemNamespace;
            return output;
        }
    }
}
