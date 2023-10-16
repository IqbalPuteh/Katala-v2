Module mdlConstants
    Public Const APP_ID = "36FB1870-87CA-4956-98FC-4DA9E76B8CF9"
    Public Const APP_NAME = "Koperasi Information Management System"

    Declare Function WNetGetUser Lib "mpr.dll" Alias "WNetGetUserA" (ByVal lpName As String, ByVal lpUserName As String, ByVal lpnLength As Long) As Long
    Declare Function GetUserName Lib "advapi32.dll" Alias "GetUserNameA" (ByVal lpBuffer As String, ByRef nSize As Integer) As Integer
End Module
