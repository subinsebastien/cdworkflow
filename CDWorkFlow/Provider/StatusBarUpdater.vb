Public Class StatusBarUpdater
    Public Shared Function updateStatusBar(ByVal message As String, ByVal statusLabelIdentifire As Integer) As Integer
        If statusLabelIdentifire = 1 Then
            Home.StatusStrip.Visible = True
            Home.tssldefault.Visible = False
            Home.tsslerror.Visible = True
            Home.tsslwarning.Visible = False
            Home.tsslerror.Text = message
            My.Computer.Audio.Play(My.Resources.ErrorAudio, AudioPlayMode.Background)
        ElseIf statusLabelIdentifire = 2 Then
            Home.StatusStrip.Visible = True
            Home.tssldefault.Visible = False
            Home.tsslerror.Visible = False
            Home.tsslwarning.Visible = True
            Home.tsslwarning.Text = message
            My.Computer.Audio.Play(My.Resources.WarnigAudio, AudioPlayMode.Background)
        ElseIf statusLabelIdentifire = 3 Then
            Home.StatusStrip.Visible = True
            Home.tssldefault.Visible = True
            Home.tsslerror.Visible = False
            Home.tsslwarning.Visible = False
            Home.tssldefault.Text = message
            My.Computer.Audio.Play(My.Resources.SuccessAudio, AudioPlayMode.Background)
        ElseIf statusLabelIdentifire = 4 Then
            Home.StatusStrip.Visible = True
            Home.tssldefault.Visible = True
            Home.tsslerror.Visible = False
            Home.tsslwarning.Visible = False
        End If

        Return 0
    End Function
End Class
