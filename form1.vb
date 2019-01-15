Imports System.Windows.Forms
Imports System.Drawing


Public Class WinVBApp
    Inherits Form
        Dim button As New Button
        Dim text1 As New textbox
        Dim text2 As New textbox

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    

        button.Location = New Point(30, 280)
        button.Text = "hello"
        button.Parent = Me

        text1.Location = New Point(30, 20)
        text1.Text = "hello world"
        text1.Parent = Me

        text2.Location = New Point(30, 80)
        text2.Text = "#hi there!!!"
        text2.Parent = Me




        AddHandler button.Click, AddressOf Me.OnClick
        
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
       me.text=text1.Text + " " + text2.Text
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class