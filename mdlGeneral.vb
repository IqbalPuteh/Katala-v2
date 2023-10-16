Module mdlGeneral

    Public Function ValidateString(ByVal strString As String) As String
        Dim strTemp As String
        Dim I As Integer
        Dim strChar As String

        strTemp = ""
        For I = 1 To Len(strString)
            strChar = Mid(strString, I, 1)
            If strChar = "'" Then
                strTemp = strTemp & "''"
            Else
                strTemp = strTemp & strChar
            End If
        Next
        ValidateString = strTemp
    End Function

    Public Function ValidateEmpty(ByVal strString As String) As Double
        If Trim(strString) = "" Then
            ValidateEmpty = 0
        Else
            ValidateEmpty = strString
        End If
    End Function

    Public Function Replicate(ByVal strChar As String, ByVal intNumber As Integer) As String
        Dim strTemp As String
        Dim I As Integer

        strTemp = ""
        For I = 1 To intNumber
            strTemp = strTemp & strChar
        Next
        Return strTemp
    End Function

    Public Function IsDBNull(ByVal objData As Object) As Boolean
        If objData.GetType Is System.DBNull.Value.GetType Then
            IsDBNull = True
        Else
            IsDBNull = False
        End If
    End Function

    Public Function GetComboIndexValue(ByVal cboCombo As ComboBox, ByVal strValue As String) As Integer
        Dim I As Integer
        Dim intIndex As Integer

        intIndex = -1
        For I = 0 To cboCombo.Items.Count - 1
            If cboCombo.Items(I) = strValue Then
                intIndex = I
            End If
        Next
        Return intIndex
    End Function

    Public Function GetStrArrayIndexValue(ByVal arrTemp() As String, ByVal strValue As String) As Integer
        Dim I As Integer
        Dim intIndex As Integer

        intIndex = -1
        For I = arrTemp.GetLowerBound(0) To arrTemp.GetUpperBound(0)
            If arrTemp(I) = strValue Then
                intIndex = I
            End If
        Next
        Return intIndex
    End Function

    Public Function RemoveComma(ByVal strString As String) As String
        Dim I As Integer
        Dim Chr As Char
        Dim strTemp As String

        strTemp = ""
        For I = 1 To Len(strString)
            Chr = Mid(strString, I, 1)
            If Chr <> "," Then
                strTemp &= Chr
            End If
        Next
        Return strTemp
    End Function

    Public Sub PopulateComboBox(ByRef cboCombo As ComboBox, ByVal adoDT As DataTable)
        Dim lngRow As Integer
        Dim intDefaultValue As Integer

        intDefaultValue = -1
        For lngRow = 0 To adoDT.Rows.Count - 1
            cboCombo.Items.Add(adoDT.Rows(lngRow)("RESOURCE_CODE"))
            If adoDT.Rows(lngRow)("DEFAULT_VALUE") = "Y" Then
                intDefaultValue = lngRow
            End If
        Next
        cboCombo.SelectedIndex = intDefaultValue
    End Sub

    Public Sub PopulateComboBoxWithDescription(ByRef cboCombo As ComboBox, ByVal adoDT As DataTable)
        Dim lngRow As Integer
        Dim intDefaultValue As Integer
        Dim strTemp As String

        intDefaultValue = -1
        For lngRow = 0 To adoDT.Rows.Count - 1
            strTemp = (adoDT.Rows(lngRow)("RESOURCE_CODE")) & " - " & (adoDT.Rows(lngRow)("RESOURCE_DESC"))
            cboCombo.Items.Add(strTemp)
            If adoDT.Rows(lngRow)("DEFAULT_VALUE") = "Y" Then
                intDefaultValue = lngRow
            End If
        Next
        cboCombo.SelectedIndex = intDefaultValue
    End Sub

    Public Function NullToString(ByVal TempData As Object) As String
        If TempData.GetType Is System.DBNull.Value.GetType Then
            NullToString = ""
        Else
            NullToString = TempData
        End If
    End Function

    Public Function GetUserId() As String
        Dim RetVal As Integer
        Dim UserName As String
        Dim Buffer As String

        Try

            Buffer = New String(CChar(" "), 25)
            RetVal = GetUserName(Buffer, 25)
            UserName = Strings.Left(Buffer, InStr(Buffer, Chr(0)) - 1)
            GetUserId = UserName
        Catch ex As Exception
            GetUserId = ""
        End Try
    End Function

    Public Function ValidateEmptyField(ByVal txtField As Control) As Boolean
        If Trim(txtField.Text) = "" Then
            MessageBox.Show("Field must be filled !", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtField.Focus()
            ValidateEmptyField = True
        Else
            ValidateEmptyField = False
        End If
    End Function

    Public Sub ShowErrorMessage(ByVal strErrorDesc As String, ByVal strErrorSource As String)
        MessageBox.Show("Error has been occured." & Chr(13) & Chr(13) & strErrorDesc, _
                        APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function ReadConfiguration(ByVal key As String) As String
        Dim configReader As System.Configuration.ConfigurationSettings

        ReadConfiguration = configReader.AppSettings.Get(key)
        Return ReadConfiguration
    End Function

    Public Function RtL(ByVal strValue As String, ByVal intLenMinus As Int16) As String
        Dim lenght As Int16
        Dim strTemp As String

        strTemp = strValue
        If strTemp.Length > 32 Then
            strTemp = strTemp.Substring(0, 32)
        End If
        lenght = 33 - intLenMinus - strTemp.Length
        RtL = New String(".", lenght) & strTemp

    End Function

    Public Function ConvertMoneyToAlphabet(ByVal sngMoney As Single) As String
        Dim Rupiah, Cents, Temp As String
        Dim DecimalPlace, Count As Int16
        Dim Place(9) As String
        Dim myNumber As String

        Place(2) = " Ribu "
        Place(3) = " Juta "
        Place(4) = " Miliar "
        Place(5) = " Trillion "

        ' String representation of amount.
        myNumber = Trim(Str(sngMoney))

        ' Position of decimal place 0 if none.
        DecimalPlace = InStr(myNumber, ".")

        ' Convert cents and set MyNumber to Rupiah amount.
        If DecimalPlace > 0 Then
            Cents = GetPuluh(Left(Mid(myNumber, DecimalPlace + 1) & "00", 2))
            myNumber = Trim(Left(myNumber, DecimalPlace - 1))
        End If

        Count = 1
        Do While myNumber <> ""
            Temp = GetRatus(Right(myNumber, 3), Count)
            If Temp <> "" Then
                If myNumber = "1" And Count = 2 Then
                    Rupiah = "Seribu " & Rupiah
                Else
                    Rupiah = Temp & Place(Count) & Rupiah
                End If
            End If

            If Len(myNumber) > 3 Then
                myNumber = Left(myNumber, Len(myNumber) - 3)
            Else
                myNumber = ""
            End If
            Count = Count + 1
        Loop

        Select Case Rupiah
            Case ""
                Rupiah = "No Rupiah"
            Case "One"
                Rupiah = "One Rupiah"
            Case Else
                Rupiah = Rupiah & " Rupiah"
        End Select

        Select Case Cents
            Case ""
                Cents = " "
            Case "One"
                Cents = " "
            Case Else
                Cents = " and " & Cents & " Cents"
        End Select

        ConvertMoneyToAlphabet = Rupiah & Cents
    End Function

    ' Converts a number from 100-999 into text
    Private Function GetRatus(ByVal MyNumber01 As String, ByVal Flag As Int16) As String
        Dim Result As String
        Dim myNumber As String

        If Val(MyNumber01) = 0 Then Exit Function
        myNumber = Right("000" & MyNumber01, 3)

        ' Convert the Ratus place.
        If Mid(myNumber, 1, 1) <> "0" Then
            If Mid(myNumber, 1, 1) = "1" Then
                Result = "Seratus "
            Else
                Result = GetDigit(Mid(myNumber, 1, 1), Flag) & " Ratus "
            End If
        End If

        ' Convert the tens and ones place.
        If Mid(myNumber, 2, 1) <> "0" Then
            Result = Result & GetPuluh(Mid(myNumber, 2))
        Else
            Result = Result & GetDigit(Mid(myNumber, 3), 0)
        End If
        GetRatus = Result
    End Function

    ' Converts a number from 10 to 99 into text.
    Private Function GetPuluh(ByVal strPuluh As String) As String
        Dim Result As String

        Result = ""           ' Null out the temporary function value.
        If Val(Left(strPuluh, 1)) = 1 Then   ' If value between 10-19...
            Select Case Val(strPuluh)
                Case 10 : Result = "Sepuluh"
                Case 11 : Result = "Sebelas"
                Case 12 : Result = "Dua Belas"
                Case 13 : Result = "Tiga Belas"
                Case 14 : Result = "Empat Belas"
                Case 15 : Result = "Lima Belas"
                Case 16 : Result = "Enam Belas"
                Case 17 : Result = "Tujuh Belas"
                Case 18 : Result = "Delapan Belas"
                Case 19 : Result = "Sembilan Belas"
                Case Else
            End Select
        Else                                 ' If value between 20-99...
            Select Case Val(Left(strPuluh, 1))
                Case 2 : Result = "Dua Puluh "
                Case 3 : Result = "Tiga Puluh "
                Case 4 : Result = "Empat Puluh "
                Case 5 : Result = "Lima Puluh "
                Case 6 : Result = "Enam Puluh "
                Case 7 : Result = "Tujuh Puluh "
                Case 8 : Result = "Delapan Puluh "
                Case 9 : Result = "Sembilan Puluh "
                Case Else
            End Select
            Result = Result & GetDigit _
                (Right(strPuluh, 1), 0)  ' Retrieve ones place.
        End If
        GetPuluh = Result
    End Function

    ' Converts a number from 1 to 9 into text.
    Private Function GetDigit(ByVal Digit, ByVal Flag) As String
        Select Case Val(Digit)
            Case 1
                If (Flag = 2) Then
                    GetDigit = "Se"
                Else
                    GetDigit = "Satu"
                End If
            Case 2 : GetDigit = "Dua"
            Case 3 : GetDigit = "Tiga"
            Case 4 : GetDigit = "Empat"
            Case 5 : GetDigit = "Lima"
            Case 6 : GetDigit = "Enam"
            Case 7 : GetDigit = "Tujuh"
            Case 8 : GetDigit = "Delapan"
            Case 9 : GetDigit = "Sembilan"
            Case Else : GetDigit = ""
        End Select
        Return GetDigit
    End Function

    Public Function AddAccountingPeriod(ByVal strPeriod As String, ByVal intAddValue As Int16) As String
        Dim dtDate As Date
        Dim dtNewDate As String
        Dim strTemp As String

        dtDate = DateSerial(CInt(strPeriod.Substring(0, 4)), CInt(strPeriod.Substring(4)), 1)
        dtNewDate = dtDate.AddMonths(intAddValue)
        strTemp = Format(dtNewDate, "yyyyMM")
        Return strTemp
    End Function

    Public Sub ReleaseComObject(ByRef Reference As Object)
        Try
            Do Until _
             System.Runtime.InteropServices.Marshal.ReleaseComObject(Reference) <= 0
            Loop
        Catch
        Finally
            Reference = Nothing
        End Try
    End Sub
End Module
