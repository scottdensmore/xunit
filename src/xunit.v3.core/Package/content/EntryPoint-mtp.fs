// <auto-generated> This file has been auto generated by xunit.v3.core. </auto-generated>

module internal XunitAutoGeneratedEntryPoint

[<EntryPoint>]
[<global.System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage>]
let main args =
    if Array.exists(fun arg -> arg = "-automated" || arg = "@@") args then
        global.Xunit.Runner.InProc.SystemConsole.ConsoleRunner.Run(args).GetAwaiter().GetResult()
    else
        global.Xunit.Runner.InProc.SystemConsole.TestingPlatform.TestPlatformTestFramework.RunAsync(args, System.Action<_,_>(fun b a -> global.Microsoft.TestingPlatform.Extensions.SelfRegisteredExtensions.AddSelfRegisteredExtensions(b,a))).GetAwaiter().GetResult()
