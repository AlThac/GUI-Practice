Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"French", "Italian", "Spanish"})

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Function TranslateToFrench(englishWord As String) As String
        Select Case englishWord
            Case "Mother"
                Return "Mère"
            Case "Father"
                Return "Père"
            Case "Sister"
                Return "Soeur"
            Case "Brother"
                Return "Frère"
        End Select
    End Function

    Private Function TranslateToItalian(englishWord As String) As String
        Select Case englishWord
            Case "Mother"
                Return "Madre"
            Case "Father"
                Return "Padre"
            Case "Sister"
                Return "Sorella"
            Case "Brother"
                Return "Fratello"
        End Select
    End Function

    Private Function TranslateToSpanish(englishWord As String) As String
        Select Case englishWord
            Case "Mother"
                Return "Madre"
            Case "Father"
                Return "Padre"
            Case "Sister"
                Return "Hermana"
            Case "Brother"
                Return "Hermano"
        End Select
    End Function

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Dim selectedLanguage As String = ComboBox1.SelectedItem.ToString()

        Dim englishWord As String = ""

        If rdbtnMother.Checked Then
            englishWord = "Mother"
        ElseIf rdbtnFather.Checked Then
            englishWord = "Father"
        ElseIf rdbtnSister.Checked Then
            englishWord = "Sister"
        ElseIf rdbtnBrother.Checked Then
            englishWord = "Brother"
        End If

        Dim translatedWord As String = ""

        Select Case selectedLanguage
            Case "French"
                translatedWord = TranslateToFrench(englishWord)
            Case "Italian"
                translatedWord = TranslateToItalian(englishWord)
            Case "Spanish"
                translatedWord = TranslateToSpanish(englishWord)
        End Select

        lblTrans.Text = translatedWord
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Do you want to exit?",
                                  "Tanslator",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Exclamation)
        If result = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
