' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Runtime.InteropServices.Analyzers
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.Diagnostics

Namespace System.Runtime.InteropServices.VisualBasic.Analyzers
    ''' <summary>
    ''' CA1414: Mark boolean PInvoke arguments with MarshalAs
    ''' </summary>
    <DiagnosticAnalyzer(LanguageNames.VisualBasic)>
    Public NotInheritable Class BasicMarkBooleanPInvokeArgumentsWithMarshalAsAnalyzer
        Inherits MarkBooleanPInvokeArgumentsWithMarshalAsAnalyzer

    End Class
End Namespace