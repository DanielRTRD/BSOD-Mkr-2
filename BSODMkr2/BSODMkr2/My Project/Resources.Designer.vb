﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("BSODMkr2.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to A problem has been detected and windows has been shut down to prevent damage
        '''to your computer.
        '''
        '''The problem seems to be caused by the following file: BSODMKR.EXE
        '''
        '''BSODMKR_RUN_STATUS_FAILED
        '''
        '''If this is the first time you&apos;ve seen this Stop error screen,
        '''restart your computer. If this screen appears again, follow
        '''these steps:
        '''
        '''Check to make sure any new hardware or software is properly installed.
        '''If this is a new installation, ask your hardware or software manufacturer
        '''for any windows updates you  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property custombsod() As String
            Get
                Return ResourceManager.GetString("custombsod", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to *** STOP: 0x0000007E (0xF641F84C,0xC0000034,0x00000000,0x00000000)
        '''BSODMKR_RUN_STATUS_FAILED
        '''
        '''If this is the first time you&apos;ve seen this Stop error screen,
        '''restart your computer. If this screen appears again, follow
        '''these steps:
        '''
        '''Check for viruses on your computer. Remove any newly installed
        '''hard drives or hard drive controllers. Check your hard drive
        '''to make sure it is properly configured and terminated.
        '''Run CHKDSK /F to check for hard drivee corruption, and then
        '''restart your computer.
        '''
        '''Refer  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property custombsod_2000() As String
            Get
                Return ResourceManager.GetString("custombsod_2000", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
