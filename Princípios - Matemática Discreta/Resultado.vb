Public Class Resultado

    Dim soma As Integer = 0
    Dim multi As Integer = 1
    Dim valor As Integer

    Public Function fatorial(ByVal n As Integer) As Integer
        If n = 0 Then
            Return 1
        Else
            Return n * fatorial(n - 1)
        End If
    End Function

    Private Sub Resultado_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Form1.Size = New Size(484, 222)
        Form1.GroupBox1.Enabled = True
        Form1.GroupBox2.Enabled = True
        Form1.GroupBox3.Enabled = True
        Form1.Button1.Enabled = True
        Form1.Button2.Enabled = True
        Form1.Button3.Enabled = True
        Form1.Button4.Enabled = True
        Form1.CheckBox1.Checked = False
        Form1.TextBox1.Clear()
        Form1.Label4.Text = "Valores = {  "
        Form1.vetor.Clear()
        Form1.flag2 = False
        Form1.cont = 0
    End Sub

    Private Sub Resultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        Label4.Text = ""
        If Form1.RadioButton2.Checked Then
            For Each valor As Integer In Form1.vetor
                multi *= valor
            Next

            If Not Form1.CheckBox1.Checked Then
                For i As Integer = 0 To Form1.cont - 1
                    If i = 0 Then
                        Label1.Text += "("
                    End If
                    If i = Form1.cont - 1 Then
                        Label1.Text += Form1.vetor(i).ToString + ") / "
                    Else
                        Label1.Text += Form1.vetor(i).ToString + " * "
                    End If
                Next
                Label1.Text += Form1.cont.ToString + "!"
                Label4.Text = (multi / fatorial(Form1.cont)).ToString
            Else
                For i As Integer = 0 To Form1.cont - 1
                    If i = Form1.cont - 1 Then
                        Label1.Text += Form1.vetor(i).ToString
                    Else
                        Label1.Text += Form1.vetor(i).ToString + " * "
                    End If
                Next
                Label4.Text = multi.ToString
            End If
            multi = 1

        ElseIf Form1.RadioButton1.Checked Then
            For Each valor As Integer In Form1.vetor
                soma += valor
            Next

            GroupBox1.Visible = False
            Me.Size = New Size(335, 167)
            GroupBox2.Location = New Point(12, 12)

            Label4.Text = soma.ToString
            soma = 0
        End If
    End Sub
End Class
