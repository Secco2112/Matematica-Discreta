Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Or RadioButton2.Checked Then
            GroupBox2.Show()
            GroupBox1.Enabled = False
            Button1.Enabled = False
            Button3.Visible = True
            Me.Size = New Size(484, 432)
        Else
            MsgBox("Selecione um princípio.")
        End If
    End Sub

    Private Function apenasNumeros(ByVal x As TextBox) As Boolean
        For i = 0 To x.Text.Length - 1
            If Not Char.IsDigit(x.Text.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Dim flag As Integer
    Dim textoValida = {"Digite um valor no campo.", "Digite apenas valores numéricos.", "Insira um valor válido."}

    Public Function validaCampo(ByVal x As TextBox) As Boolean
        If x.Text = "" Then
            flag = 0
            Return False
        ElseIf apenasNumeros(x) Then
            flag = 1
            Return True
        Else
            flag = 2
            Return False
        End If
    End Function

    Public flag2 = False
    Public cont As Integer = 0
    Public vetor As New List(Of Integer)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If validaCampo(TextBox1) Then
            If Not flag2 Then
                Label4.Text += TextBox1.Text
                flag2 = True
                cont += 1
            Else
                Label4.Text += ", " + TextBox1.Text
                cont += 1
            End If
            vetor.Add(Convert.ToInt32(TextBox1.Text))
        Else
            MsgBox(textoValida(flag))
        End If
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then
            GroupBox3.Enabled = False
        End If

        If cont > 0 Then
            GroupBox3.Visible = True
            Button4.Visible = True
            Label4.Text += " }"
            GroupBox2.Enabled = False
            Button3.Enabled = False
            Me.Size = New Size(484, 602)
        Else
            MsgBox("Você precisa digitar pelo menos um valor.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox3.Enabled = False
        Button4.Enabled = False
        Resultado.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(484, 222)
    End Sub
End Class
