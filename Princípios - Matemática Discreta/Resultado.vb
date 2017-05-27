Public Class Resultado

    Dim soma = 0
    Dim multi = 1
    Dim valor As Integer

    Public Function fatorial(ByVal n As Integer) As Integer
        If n = 0 Then
            Return 1
        Else
            Return n * fatorial(n - 1)
        End If
    End Function

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.Size = New Size(484, 222)
        Form1.GroupBox1.Enabled = True
        Form1.GroupBox2.Enabled = True
        Form1.GroupBox3.Enabled = True
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
        Form1.Button3.Enabled = True
        Form1.Button4.Enabled = True
        Form1.Label4.Text = "Valores = {  "
        Form1.vetor.Clear()
        Form1.flag2 = False
        Form1.cont = 0
    End Sub

    Private Sub Resultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.RadioButton2.Checked Then
            For Each valor As Integer In Form1.vetor
                multi *= valor
            Next

            If Form1.CheckBox1.Checked Then
                Label1.Text = multi.ToString + " / " + fatorial(Form1.cont).ToString
            Else
                Label1.Text = multi.ToString
            End If
        ElseIf Form1.RadioButton1.Checked Then
            For Each valor As Integer In Form1.vetor
                soma += valor
            Next

            GroupBox1.Visible = False
            Me.Size = New Size(335, 167)
            GroupBox2.Location = New Point(12, 12)
        End If
    End Sub
End Class
