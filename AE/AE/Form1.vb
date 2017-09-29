Public Class Form1
    Public path As String
    Public pathPS As String

    Private Sub filePickerBS_Click(sender As Object, e As EventArgs) Handles filePickerBS.Click
        'Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        ' Test result.
        If result = DialogResult.OK Then
            'Get the file name.
            path = OpenFileDialog1.FileName

        End If
    End Sub
    Private Sub executor_Click(sender As Object, e As EventArgs) Handles executor.Click
        Dim thisDate As String, myFile As String, toPath As String, FSO As Object, fFormat As String, otherPath As String
        'Defining Variables'
        myFile = nameInput.Text
        thisDate = Format(Now(), "yyyyMMdd")
        toPath = "\\CPRC-BACKWINDOW\Users\Public\Documents\Aquatic Therapy\Billing-Sent to David\2017 Aquatic Billing sent to David\"
        otherPath = "\\192.168.103.5\Dbrtserver\drop box\CPRC BILLING - AUTH PATIENT INFO (Accountability)\"
        fFormat = myFile & "AQDOS" & thisDate & ".pdf"
        'Copying Files'
        If nameInput.Text = "" Then
            MessageBox.Show("Please enter a patient name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf path = "" Then
            MessageBox.Show("Please pick a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                FSO = CreateObject("scripting.filesystemobject")
                FSO.MoveFile(Source:=path, Destination:=toPath & fFormat)
                MessageBox.Show("The executions have been performed, my master.", "Execution Status",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
                Process.Start(toPath)
            End If


    End Sub
    Private Sub filePickerPS_Click(sender As Object, e As EventArgs) Handles filePickerPS.Click
        'Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog4.ShowDialog()
        ' Test result.
        If result = DialogResult.OK Then
            ' Get the file name.
            pathPS = OpenFileDialog4.FileName
        End If
    End Sub
    Private Sub executorPS_Click(sender As Object, e As EventArgs) Handles executorPS.Click
        Dim thisDate1 As String, myFile1 As String, toPathPDS As String, FSO2 As Object, fFormatPDS As String, toPathAL As String, fFormatAL As String
        Dim toPathPTA As String, fFormatPTA As String
        'Defining Variables'
        myFile1 = psInput.Text
        thisDate1 = Format(Now(), "MM.dd.yy")
        'Provider Day Sheet Variables'
        toPathPDS = "\\CPRC-BACKWINDOW\Users\Public\Documents\Aquatic Therapy\Daily Tracking Sheet\Scanned Provider Daysheet\2017\" & myFile1 & "\"
        fFormatPDS = "Provider Day Sheet" & " " & myFile1 & " " & thisDate1 & ".pdf"
        'Appointment List Variables'
        toPathAL = "G:\My Drive\Appointment Lists\"
        fFormatAL = "Appointment List" & " " & myFile1 & " " & thisDate1 & ".pdf"
        'PT Accountability Variables'
        toPathPTA = "\\CPRC-BACKWINDOW\Users\Public\Documents\Aquatic Therapy\PT Accountability\"
        fFormatPTA = "PT Accountability" & " " & myFile1 & " " & thisDate1 & ".pdf"

        If selectBox.Text = "Provider Day Sheet" Then
            FSO2 = CreateObject("scripting.filesystemobject")
            FSO2.MoveFile(Source:=pathPS, Destination:=toPathPDS & fFormatPDS)
            MessageBox.Show("The executions have been performed, my master.", "Execution Status",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Process.Start(toPathPDS)

        ElseIf selectBox.Text = "Appointment List" Then
            FSO2 = CreateObject("scripting.filesystemobject")
            FSO2.MoveFile(Source:=pathPS, Destination:=toPathAL & fFormatAL)
            MessageBox.Show("The executions have been performed, my master.", "Execution Status",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Process.Start(toPathAL)

        ElseIf selectBox.Text = "PT Accountability" Then
            FSO2 = CreateObject("scripting.filesystemobject")
            FSO2.MoveFile(Source:=pathPS, Destination:=toPathPTA & fFormatPTA)
            MessageBox.Show("The executions have been performed, my master.", "Execution Status",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            Process.Start(toPathPTA)

        ElseIf selectBox.Text = "" Then
            MessageBox.Show("Please select a type from the list!", "Error!",
           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

End Class
