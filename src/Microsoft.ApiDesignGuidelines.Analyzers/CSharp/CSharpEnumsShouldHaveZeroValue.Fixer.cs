﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Composition;
using Microsoft.ApiDesignGuidelines.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeFixes;

namespace Microsoft.ApiDesignGuidelines.CSharp.Analyzers
{
    /// <summary>
    /// CA1008: Enums should have zero value
    /// </summary>
    [ExportCodeFixProvider(LanguageNames.CSharp), Shared]
    public class CSharpEnumsShouldHaveZeroValueFixer : EnumsShouldHaveZeroValueFixer
    {
    }
}
