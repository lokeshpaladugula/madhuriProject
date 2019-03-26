Public Class Form6
    Dim marr(ROW_COUNT(), COLUMN_COUNT()) As String
    Dim txt4Len As Integer


    'Private Property MArr(x As Long, y As Long) As Long
    '    Get
    '        Return _mArr
    '    End Get
    '    Set(value As Long)
    '        _mArr = value
    '    End Set
    'End Property

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = substitution(TextBox1.Text)
           
    End Sub
    Function substitution(ByVal input As String)
        Dim result As String = ""
        For Each x As Char In input
            If Char.IsLower(x) Then
                Dim diff As Integer = Asc(x) - Asc("a")
                result += Chr(Asc("z") - diff)

            ElseIf Char.IsUpper(x) Then
                Dim diff As Integer = Asc(x) - Asc("A")
                result += Chr(Asc("Z") - diff)
            Else
                Dim diff As Integer = Asc(x) - Asc("0")
                result += Chr(Asc("0") - diff)

            End If
        Next
        Return result
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim row_count As Integer = TextBox4.Text
        Dim column_count As Integer = TextBox4.Text



        Dim b As Integer = TextBox4.Text.Length
        b = b ^ 2
        Dim a As Integer = TextBox2.Text.Length
        Dim c As Integer

        If (a < b) Then
            c = b - a

            Dim arr(c) As String
            ' Dim x As String = 0
            For i = 0 To c - 1
                arr(i) = "@"
                TextBox2.Text = (TextBox2.Text + arr(i))
            Next
        End If
        Dim teststring As String = TextBox2.Text
        Dim chararray As String = teststring.ToCharArray()

        Dim x As Integer

        x = 0
        TextBox3.Text = Nothing
        txt4Len = TextBox4.Text.Length
        For i = 0 To TextBox4.Text.Length - 1
            For j = 0 To TextBox4.Text.Length - 1
                marr(row_count, column_count) = chararray(x)
                TextBox3.Text = TextBox3.Text + marr(row_count, column_count)
                TextBox3.Text = TextBox3.Text & vbTab
                x = x + 1

            Next j
            'TextBox3.Text += "" & ControlChars.NewLine & ""

        Next i




        TextBox6.Text = marr(2, 3)

    End Sub


    Function substitutionmatrix(ByVal input As String)
        Dim result As String = ""
        For Each x As Char In input
            If Char.IsLower(x) Then
                Dim diff As Integer = Asc(x) - Asc("a")
                result += Chr(Asc("z") - diff)

            ElseIf Char.IsUpper(x) Then
                Dim diff As Integer = Asc(x) - Asc("A")
                result += Chr(Asc("Z") - diff)
            Else
                Dim diff As Integer = Asc(x) - Asc("0")
                result += Chr(Asc("0") - diff)

            End If
        Next
        Return result
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "text files(*.txt)|*.txt"
        openfile.Title = "open"
        openfile.ShowDialog()
        Try
            Dim read As New System.IO.StreamReader(openfile.FileName)
            TextBox4.Text = read.ReadToEnd
            read.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Function ROW_COUNT() As Integer
        Throw New NotImplementedException
    End Function

    Private Function COLUMN_COUNT() As Integer
        Throw New NotImplementedException
    End Function

    ' Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    '    TextBox3.Text = TextBox4.Text.Length.ToString()
    'End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
       

       


    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim savefile As New SaveFileDialog
        savefile.FileName = "matrix"
        savefile.Filter = "text files(*.txt)|*.txt"
        savefile.Title = "save"
        savefile.ShowDialog()
        Try
            Dim write As New System.IO.StreamWriter(savefile.FileName)
            write.Write(TextBox3.Text)
            write.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class