Public Class Form4
    Dim b As String
    Dim a As String
    Dim k As Integer
    Dim key As String
    Dim r As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        TextBox2.Clear()

        b = TextBox1.Text
        a = Nothing
        For i = 0 To b.Length - 1
            a = (a + (Int(Asc(b(i))).ToString())) + " "
        Next
        TextBox2.Text = a


    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p, q As String
        p = TextBox1.Text
        key = 0
        q = 0
        For i As Integer = 0 To p.Length - 1
            q = q + Int(Asc(p(i))).ToString() + " "
            q = (q Mod p.Length) + 1
            key = key * 10 + q                                  '3442 
        Next
        Dim number As Integer
        Dim arr(TextBox1.Text.Length) As Integer
        Dim rarr(TextBox1.Text.Length / 2) As Integer
        Dim remainder As Integer
        Dim quotient As Integer
        Dim location As Integer
        Dim r, count As Integer
        r = TextBox1.Text.Length
        number = 2311
        quotient = number
        While r > 0
            remainder = quotient Mod 10
            arr(r) = remainder
            quotient = quotient / 10
            r = r - 1
        End While
        count = 0
        For j = 1 To TextBox1.Text.Length
            For k As Integer = k To TextBox1.Text.Length
                If k = j Then
                    Continue For
                ElseIf arr(j) = arr(k) Then
                    arr(k) = 0
                    count = count + 1
                    rarr(count) = k

                End If
            Next k
        Next j
        Dim n, z As Integer
        For i = 1 To count
            For j = 1 To TextBox1.Text.Length
                n = 1
                z = 1
                While n < TextBox1.Text.Length + 1
                    If arr(1) = j Then

                        n = TextBox1.Text.Length + 2
                        Continue For
                    Else
                        n = n + 1
                    End If
                    If n = TextBox1.Text.Length + 1 Then
                        z = z - 1

                    End If
                End While

                If z = 0 Then
                    arr(rarr(i)) = j
                    j = TextBox1.Text.Length + 1
                End If
            Next j

        Next
        ' number = arr(1) * 10000 + arr(2) * 1000 + arr(3) * 100 + arr(4) * 10 + arr(5)

        Dim w As Integer = TextBox1.Text.Length
        Dim m As Integer = 1
        number = 0
        While w > 0
            number = arr(w) * m + number
            m = m * 10
            w = w - 1
        End While
        TextBox3.Text = number


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim savefile As New SaveFileDialog
        savefile.FileName = "key"
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Clear()

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.Text = TextBox2.Text
    End Sub
End Class