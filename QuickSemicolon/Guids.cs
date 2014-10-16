// Guids.cs
// MUST match guids.h
using System;

namespace cpiznet.QuickSemicolon
{
    static class GuidList
    {
        public const string guidQuickSemicolonPkgString = "d378e555-224f-46b3-98ab-0bd4713d754c";
        public const string guidQuickSemicolonCmdSetString = "a62273f5-0f74-4226-9b46-e8bcca1fbcc5";

        public static readonly Guid guidQuickSemicolonCmdSet = new Guid(guidQuickSemicolonCmdSetString);
    };
}