Public Class frmKaraoke

    Private decSong As Decimal = 2.99D
    Private decHourlyRate As Decimal = 8.99D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub

    Private Function ValidateInput() As Boolean

        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            intNumber = Convert.ToInt32(txtbAmount.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please Enter a number greater than 0", , "Error")
            End If

        Catch ex As FormatException
            MsgBox("Please enter a valid amount", , "Error")

        Catch ex As OverflowException
            MsgBox("Please enter a reasonable amount", , "Error")

        Catch Exception As SystemException
            MsgBox("Entry Invalid. Please enter a valid number representing the number in your party", , "Error")

        End Try

        txtbAmount.Focus()
        txtbAmount.Clear()
        Return blnValid
    End Function

    Private Function ComputeSongCost(ByVal txtbAmount As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = txtbAmount * decSong

        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal txtbAmount As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = txtbAmount * decHourlyRate

        Return decTicketCost

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        CmbSelection.SelectedIndex = -1
        lblInsert.Visible = False
        lblResult.Visible = False
        lblReturnHeader.Visible = False
        txtbAmount.Visible = False
        btnTotal.Visible = False
        btnClear.Visible = False
        txtbAmount.Clear()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            intValue = Convert.ToInt32(txtbAmount.Text)

            If CmbSelection.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            End If

            If CmbSelection.SelectedIndex = 1 Then
                decTotal = ComputeRoomCost(intValue)
            End If

            lblReturnHeader.Visible = True
            lblResult.Visible = True
            lblResult.Text = decTotal.ToString("C")
        End If

    End Sub

    Private Sub CmbSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSelection.SelectedIndexChanged
        If CmbSelection.SelectedIndex = 0 Then
            lblInsert.Text = "Number of Karaoke Songs"
            lblInsert.Visible = True
            lblHeader.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtbAmount.Visible = True

            txtbAmount.Focus()
        End If
        If CmbSelection.SelectedIndex = 1 Then
            lblInsert.Text = "How Many Hour for Room Rental:"
            lblInsert.Visible = True
            lblHeader.Visible = True
            btnClear.Visible = True
            btnTotal.Visible = True
            txtbAmount.Visible = True

            txtbAmount.Focus()
        End If
    End Sub
End Class
