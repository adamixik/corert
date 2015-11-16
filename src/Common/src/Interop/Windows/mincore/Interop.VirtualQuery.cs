// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class mincore
    {
        [DllImport(Interop.Libraries.Memory)]
        internal extern static UIntPtr VirtualQuery(IntPtr lpAddress, out Interop._MEMORY_BASIC_INFORMATION lpBuffer, UIntPtr dwLength);
    }
}