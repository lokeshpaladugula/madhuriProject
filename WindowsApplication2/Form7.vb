Public Class Form7

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub openkey_Click(sender As Object, e As EventArgs) Handles openkey.Click

    End Sub

    Private Sub openmatrix_Click(sender As Object, e As EventArgs) Handles openmatrix.Click
        Dim openfile As New OpenFileDialog
        Dim str As String
        Dim count As Integer = 0
        openfile.Filter = "text files(*.txt)|*.txt"
        openfile.Title = "open"
        openfile.ShowDialog()
        Try
            Dim read As New System.IO.StreamReader(openfile.FileName)
            str = read.ReadToEnd
            read.Close()

        Catch ex As Exception

        End Try

        For i = 0 To TextBox1.Text.Length - 1
            For j = 0 To TextBox1.Text.Length - 1
                TextBox2.Text = TextBox2.Text + str(count) + vbTab
                count = count + 2
            Next
            TextBox2.Text = TextBox2.Text + vbNewLine

        Next

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub cipher1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub shifitingcols_Click(sender As Object, e As EventArgs) Handles shifitingcols.Click
        Dim marr(8, 8) As String
        Dim k As Integer
        Dim count As Integer
        Dim str As String
        str = TextBox2.Text

        count = 0
        'creating matrix from file
        For i = 0 To TextBox1.Text.Length - 1
            For j = 0 To TextBox1.Text.Length - 1
                marr(i, j) = str(count)
                count = count + 2
            Next
            count = count + 2
        Next
       

        'converting key as an array
        Dim keystr As String
        Dim keyint As Integer
        keystr = TextBox1.Text
        keyint = Convert.ToInt32(keystr)

        Dim keyarr(keystr.Length) As Integer
        Dim remainder As Integer
        Dim quotient As Integer


        Dim m As Integer = keystr.Length - 1
        quotient = keyint
        While m > 0 Or m = 0
            remainder = quotient Mod 10
            quotient = quotient / 10
            keyarr(m) = remainder
            m = m - 1

        End While



        'shifting the array accorfding to key values
        Dim marr2(keystr.Length - 1, keystr.Length - 1) As String
        For i = 0 To keystr.Length - 1
            k = keyarr(i)
            For j = 0 To keystr.Length - 1
                marr2(j, i) = marr(j, k - 1)

            Next

        Next
        'print the shifted array in textbox
        For i = 0 To keystr.Length - 1
            For j = 0 To keystr.Length - 1
                TextBox3.Text = TextBox3.Text + marr2(i, j) + vbTab

            Next
            TextBox3.Text = TextBox3.Text + vbNewLine
        Next
        'printing the shifted array in single line in row wise
        For i = 0 To TextBox1.Text.Length - 1
            For j = 0 To TextBox1.Text.Length - 1
                TextBox4.Text = TextBox4.Text + marr2(j, i)

            Next

        Next

    End Sub

    Private Sub shiftingcols2_Click(sender As Object, e As EventArgs) Handles shiftingcols2.Click
        Dim marr(8, 8) As String
        Dim k As Integer
        Dim count As Integer
        Dim str As String
        Dim keystr As String
        Dim keyint As Integer
        keystr = TextBox1.Text
        keyint = Convert.ToInt32(keystr)

        Dim keyarr(keystr.Length) As Integer
        Dim remainder As Integer
        Dim quotient As Integer


        Dim m As Integer = keystr.Length - 1
        quotient = keyint
        While m > 0 Or m = 0
            remainder = quotient Mod 10
            quotient = quotient / 10
            keyarr(m) = remainder
            m = m - 1

        End While
        'creating matrix from single line string and printing in textbox
        count = 0
        str = TextBox4.Text
        For i = 0 To keystr.Length - 1
            For j = 0 To keystr.Length - 1
                marr(i, j) = str(count)
                count = count + 1
                TextBox5.Text = TextBox5.Text + marr(i, j) + vbTab
            Next
            TextBox5.Text = TextBox5.Text + vbNewLine
        Next
        'shifting the array according to key values
        Dim marr2(keystr.Length - 1, keystr.Length - 1) As String
        For i = 0 To keystr.Length - 1
            k = keyarr(i)
            For j = 0 To keystr.Length - 1
                marr2(j, i) = marr(j, k - 1)
            Next
        Next

        'print the shifted array in textbox
        For i = 0 To keystr.Length - 1
            For j = 0 To keystr.Length - 1
                TextBox6.Text = TextBox6.Text + marr2(i, j) + vbTab

            Next
            TextBox6.Text = TextBox6.Text + vbNewLine
        Next

        'printing the shifted array in single line in row wise
        For i = 0 To TextBox1.Text.Length - 1
            For j = 0 To TextBox1.Text.Length - 1
                TextBox7.Text = TextBox7.Text + marr2(j, i)
            Next
        Next


    End Sub
End Class