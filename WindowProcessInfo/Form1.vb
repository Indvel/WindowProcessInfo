Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("user32.dll", EntryPoint:="GetWindowThreadProcessId")> _
    Private Shared Function GetWindowThreadProcessId(<InAttribute()> ByVal hWnd As IntPtr, ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function ScreenToClient(ByVal hWnd As IntPtr, ByRef lpPoint As Point) As Boolean
    End Function

    <DllImport("user32")> _
    Private Shared Function GetCursorPos(ByRef pt As Point) As Int32
    End Function

    <DllImport("user32")> _
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function GetWindowTextLength(ByVal hwnd As IntPtr) As Integer
    End Function

    Public Declare Auto Function GetWindowText Lib "user32" _
            (ByVal hWnd As System.IntPtr,
            ByVal lpString As System.Text.StringBuilder,
            ByVal cch As Integer) As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim hWnd As System.IntPtr
        hWnd = GetForegroundWindow()

        If hWnd <> IntPtr.Zero Then
            Dim length As Integer = GetWindowTextLength(hWnd)
            Dim title As New System.Text.StringBuilder("", length + 1)
            If length > 0 Then
                GetWindowText(hWnd, title, title.Capacity)
            End If

            Dim procID As Integer = Nothing
            GetWindowThreadProcessId(hWnd, procID)

            Dim proc As Process = Process.GetProcessById(procID)
            Dim fileName As String = ""
            Try
                fileName = proc.MainModule.FileName
            Catch ex As Exception
                fileName = ""
            End Try

            Dim pos As Point
            GetCursorPos(pos)
            ScreenToClient(hWnd, pos)

            WindowText.Text = title.ToString
            HandleLabel.Text = hWnd.ToString
            ProcessId.Text = procID.ToString
            ModuleFile.Text = fileName.ToString
            MousePos.Text = pos.X & ", " & pos.Y
        End If
    End Sub
End Class
