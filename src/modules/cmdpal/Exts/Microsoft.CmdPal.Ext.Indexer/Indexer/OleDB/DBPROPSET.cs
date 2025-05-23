﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.CmdPal.Ext.Indexer.Indexer.OleDB;

[StructLayout(LayoutKind.Sequential)]
public struct DBPROPSET
{
#pragma warning disable SA1307 // Accessible fields should begin with upper-case letter
    public IntPtr rgProperties;    // Pointer to an array of DBPROP
    public uint cProperties;       // Number of properties in the array
    public Guid guidPropertySet;   // GUID of the property set
#pragma warning restore SA1307 // Accessible fields should begin with upper-case letter
}
