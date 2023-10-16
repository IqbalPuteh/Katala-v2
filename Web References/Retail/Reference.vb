﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
'
Namespace Retail
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="svcRetailSoap", [Namespace]:="http://tempuri.org/KatalaWebServices/svcRetail")>  _
    Partial Public Class svcRetail
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private AddNewMemberOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UpdateMemberOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetMaxRetIdOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetMemberDataOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetHeaderOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://localhost/KatalaWebServices/svcRetail.asmx"
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event AddNewMemberCompleted As AddNewMemberCompletedEventHandler
        
        '''<remarks/>
        Public Event UpdateMemberCompleted As UpdateMemberCompletedEventHandler
        
        '''<remarks/>
        Public Event GetMaxRetIdCompleted As GetMaxRetIdCompletedEventHandler
        
        '''<remarks/>
        Public Event GetMemberDataCompleted As GetMemberDataCompletedEventHandler
        
        '''<remarks/>
        Public Event GetHeaderCompleted As GetHeaderCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KatalaWebServices/svcRetail/AddNewMember", RequestNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", ResponseNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function AddNewMember(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String) As String
            Dim results() As Object = Me.Invoke("AddNewMember", New Object() {adoDS, strAPP_ID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Function BeginAddNewMember(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AddNewMember", New Object() {adoDS, strAPP_ID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndAddNewMember(ByVal asyncResult As System.IAsyncResult) As String
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub AddNewMemberAsync(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String)
            Me.AddNewMemberAsync(adoDS, strAPP_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub AddNewMemberAsync(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String, ByVal userState As Object)
            If (Me.AddNewMemberOperationCompleted Is Nothing) Then
                Me.AddNewMemberOperationCompleted = AddressOf Me.OnAddNewMemberOperationCompleted
            End If
            Me.InvokeAsync("AddNewMember", New Object() {adoDS, strAPP_ID}, Me.AddNewMemberOperationCompleted, userState)
        End Sub
        
        Private Sub OnAddNewMemberOperationCompleted(ByVal arg As Object)
            If (Not (Me.AddNewMemberCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AddNewMemberCompleted(Me, New AddNewMemberCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KatalaWebServices/svcRetail/UpdateMember", RequestNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", ResponseNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub UpdateMember(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String)
            Me.Invoke("UpdateMember", New Object() {adoDS, strAPP_ID})
        End Sub
        
        '''<remarks/>
        Public Function BeginUpdateMember(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("UpdateMember", New Object() {adoDS, strAPP_ID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Sub EndUpdateMember(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateMemberAsync(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String)
            Me.UpdateMemberAsync(adoDS, strAPP_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UpdateMemberAsync(ByVal adoDS As System.Data.DataSet, ByVal strAPP_ID As String, ByVal userState As Object)
            If (Me.UpdateMemberOperationCompleted Is Nothing) Then
                Me.UpdateMemberOperationCompleted = AddressOf Me.OnUpdateMemberOperationCompleted
            End If
            Me.InvokeAsync("UpdateMember", New Object() {adoDS, strAPP_ID}, Me.UpdateMemberOperationCompleted, userState)
        End Sub
        
        Private Sub OnUpdateMemberOperationCompleted(ByVal arg As Object)
            If (Not (Me.UpdateMemberCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UpdateMemberCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KatalaWebServices/svcRetail/GetMaxRetId", RequestNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", ResponseNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMaxRetId(ByVal strAPP_ID As String) As Integer
            Dim results() As Object = Me.Invoke("GetMaxRetId", New Object() {strAPP_ID})
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Function BeginGetMaxRetId(ByVal strAPP_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetMaxRetId", New Object() {strAPP_ID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetMaxRetId(ByVal asyncResult As System.IAsyncResult) As Integer
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),Integer)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetMaxRetIdAsync(ByVal strAPP_ID As String)
            Me.GetMaxRetIdAsync(strAPP_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetMaxRetIdAsync(ByVal strAPP_ID As String, ByVal userState As Object)
            If (Me.GetMaxRetIdOperationCompleted Is Nothing) Then
                Me.GetMaxRetIdOperationCompleted = AddressOf Me.OnGetMaxRetIdOperationCompleted
            End If
            Me.InvokeAsync("GetMaxRetId", New Object() {strAPP_ID}, Me.GetMaxRetIdOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetMaxRetIdOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetMaxRetIdCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetMaxRetIdCompleted(Me, New GetMaxRetIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KatalaWebServices/svcRetail/GetMemberData", RequestNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", ResponseNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetMemberData(ByVal strMemberId As String, ByVal strMemberName As String, ByVal strAPP_ID As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetMemberData", New Object() {strMemberId, strMemberName, strAPP_ID})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetMemberData(ByVal strMemberId As String, ByVal strMemberName As String, ByVal strAPP_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetMemberData", New Object() {strMemberId, strMemberName, strAPP_ID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetMemberData(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetMemberDataAsync(ByVal strMemberId As String, ByVal strMemberName As String, ByVal strAPP_ID As String)
            Me.GetMemberDataAsync(strMemberId, strMemberName, strAPP_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetMemberDataAsync(ByVal strMemberId As String, ByVal strMemberName As String, ByVal strAPP_ID As String, ByVal userState As Object)
            If (Me.GetMemberDataOperationCompleted Is Nothing) Then
                Me.GetMemberDataOperationCompleted = AddressOf Me.OnGetMemberDataOperationCompleted
            End If
            Me.InvokeAsync("GetMemberData", New Object() {strMemberId, strMemberName, strAPP_ID}, Me.GetMemberDataOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetMemberDataOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetMemberDataCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetMemberDataCompleted(Me, New GetMemberDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/KatalaWebServices/svcRetail/GetHeader", RequestNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", ResponseNamespace:="http://tempuri.org/KatalaWebServices/svcRetail", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetHeader(ByVal strStart As String, ByVal strEnd As String, ByVal strMembershipNo As String, ByVal strVoucherNo As String, ByVal strAPP_ID As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("GetHeader", New Object() {strStart, strEnd, strMembershipNo, strVoucherNo, strAPP_ID})
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Function BeginGetHeader(ByVal strStart As String, ByVal strEnd As String, ByVal strMembershipNo As String, ByVal strVoucherNo As String, ByVal strAPP_ID As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("GetHeader", New Object() {strStart, strEnd, strMembershipNo, strVoucherNo, strAPP_ID}, callback, asyncState)
        End Function
        
        '''<remarks/>
        Public Function EndGetHeader(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0),System.Data.DataSet)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetHeaderAsync(ByVal strStart As String, ByVal strEnd As String, ByVal strMembershipNo As String, ByVal strVoucherNo As String, ByVal strAPP_ID As String)
            Me.GetHeaderAsync(strStart, strEnd, strMembershipNo, strVoucherNo, strAPP_ID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetHeaderAsync(ByVal strStart As String, ByVal strEnd As String, ByVal strMembershipNo As String, ByVal strVoucherNo As String, ByVal strAPP_ID As String, ByVal userState As Object)
            If (Me.GetHeaderOperationCompleted Is Nothing) Then
                Me.GetHeaderOperationCompleted = AddressOf Me.OnGetHeaderOperationCompleted
            End If
            Me.InvokeAsync("GetHeader", New Object() {strStart, strEnd, strMembershipNo, strVoucherNo, strAPP_ID}, Me.GetHeaderOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetHeaderOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetHeaderCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetHeaderCompleted(Me, New GetHeaderCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub AddNewMemberCompletedEventHandler(ByVal sender As Object, ByVal e As AddNewMemberCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class AddNewMemberCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub UpdateMemberCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub GetMaxRetIdCompletedEventHandler(ByVal sender As Object, ByVal e As GetMaxRetIdCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetMaxRetIdCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Integer
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Integer)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub GetMemberDataCompletedEventHandler(ByVal sender As Object, ByVal e As GetMemberDataCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetMemberDataCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")>  _
    Public Delegate Sub GetHeaderCompletedEventHandler(ByVal sender As Object, ByVal e As GetHeaderCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetHeaderCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),System.Data.DataSet)
            End Get
        End Property
    End Class
End Namespace
