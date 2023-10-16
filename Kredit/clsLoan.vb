
Public Class FlatInterestClass
    Private _intMain As Int64
    Private _intTerm As Short
    Private _intInterest As Single

    Sub New(ByVal intMain As Integer, ByVal intTerm As Short, ByVal IntInterest As Short)

        _intMain = intMain
        _intTerm = intTerm
        _intInterest = IntInterest / 100
    End Sub

    Public Function GetMontlyDeduction() As Double

        If _intMain = 0 Then
            Return 0
            Exit Function
        End If
        Return (_intMain * (1 / _intTerm + _intInterest / 12))
    End Function

    Public Function GetTotalOwed() As Double

        If _intMain = 0 Then
            Return 0
            Exit Function
        End If
        Return _intMain + _GetSummaryOfMontlyInterestPayment()
    End Function

    Private Function _GetSummaryOfMontlyInterestPayment() As Double

        If _intMain = 0 Then
            Return 0
            Exit Function
        End If
        Return _intMain * _intTerm * _intInterest / 12
    End Function

    Public Function GetMontlyBasicDeduction() As Double

        If _intMain = 0 Then
            Return 0
            Exit Function
        End If
        Return _intMain / _intTerm
    End Function

    Public Function GetMontlyInterestDeduction() As Double

        If _intMain = 0 Then
            Return 0
            Exit Function
        End If
        Return GetMontlyDeduction() - GetMontlyBasicDeduction()
    End Function
End Class


