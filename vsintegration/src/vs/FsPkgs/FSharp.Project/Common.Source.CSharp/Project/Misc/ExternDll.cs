// Copyright (c) Microsoft Open Technologies, Inc.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Microsoft.VisualStudio.FSharp.ProjectSystem {
    internal static class ExternDll {

#if FEATURE_PAL

 #if !PLATFORM_UNIX
        /*internal, but public for FSharp.Project.dll*/ public const String DLLPREFIX = "";
        /*internal, but public for FSharp.Project.dll*/ public const String DLLSUFFIX = ".dll";
 #else // !PLATFORM_UNIX
  #if __APPLE__
        /*internal, but public for FSharp.Project.dll*/ public const String DLLPREFIX = "lib";
        /*internal, but public for FSharp.Project.dll*/ public const String DLLSUFFIX = ".dylib";
  #elif _AIX
        /*internal, but public for FSharp.Project.dll*/ public const String DLLPREFIX = "lib";
        /*internal, but public for FSharp.Project.dll*/ public const String DLLSUFFIX = ".a";
  #elif __hppa__ || IA64
        /*internal, but public for FSharp.Project.dll*/ public const String DLLPREFIX = "lib";
        /*internal, but public for FSharp.Project.dll*/ public const String DLLSUFFIX = ".sl";
  #else
        /*internal, but public for FSharp.Project.dll*/ public const String DLLPREFIX = "lib";
        /*internal, but public for FSharp.Project.dll*/ public const String DLLSUFFIX = ".so";
  #endif
 #endif // !PLATFORM_UNIX

        public const string Kernel32 = DLLPREFIX + "rotor_pal" + DLLSUFFIX;
        public const string User32 = DLLPREFIX + "rotor_pal" + DLLSUFFIX;
        public const string Mscoree  = DLLPREFIX + "sscoree" + DLLSUFFIX;
#else
        public const string Activeds = "activeds.dll";
        public const string Advapi32 = "advapi32.dll";
        public const string Comctl32 = "comctl32.dll";
        public const string Comdlg32 = "comdlg32.dll";
        public const string Gdi32    = "gdi32.dll";
        public const string Gdiplus  = "gdiplus.dll";
        public const string Hhctrl   = "hhctrl.ocx";
        public const string Imm32    = "imm32.dll";
        public const string Kernel32 = "kernel32.dll";
        public const string Loadperf = "Loadperf.dll";
        public const string Mscoree  = "mscoree.dll";
        public const string Mscorwks = "mscorwks.dll";
        public const string Msi      = "msi.dll";
        public const string Mqrt     = "mqrt.dll";
        public const string Ntdll    = "ntdll.dll";
        public const string Ole32    = "ole32.dll";
        public const string Oleacc   = "oleacc.dll";
        public const string Oleaut32 = "oleaut32.dll";
        public const string Olepro32 = "olepro32.dll";
        public const string PerfCounter = "perfcounter.dll";
        public const string Powrprof = "Powrprof.dll";
        public const string Psapi    = "psapi.dll";
        public const string Shell32  = "shell32.dll";
        public const string Shfolder = "shfolder.dll";
        public const string User32   = "user32.dll";
        public const string Uxtheme  = "uxtheme.dll";
        public const string WinMM    = "winmm.dll";
        public const string Winspool = "winspool.drv";
        public const string Wtsapi32 = "wtsapi32.dll";
        public const string Version  = "version.dll";
        public const string Vsassert = "vsassert.dll";
        public const string Shlwapi  = "shlwapi.dll";
        public const string Crypt32  = "crypt32.dll";

        // system.data specific
        /*internal, but public for FSharp.Project.dll*/ public const string Odbc32    = "odbc32.dll";
        /*internal, but public for FSharp.Project.dll*/ public const string SNI       = "System.Data.dll";

        // system.data.oracleclient specific
        /*internal, but public for FSharp.Project.dll*/ public const string OciDll    = "oci.dll";
        /*internal, but public for FSharp.Project.dll*/ public const string OraMtsDll = "oramts.dll";
#endif //!FEATURE_PAL
    }
}
