Imports System.Windows.Forms
Imports System.Drawing


Public Class WinVBApp
    Inherits Form
        Dim button As New Button
        Dim text1 As New textbox
        Dim text2 As New textbox
        Dim text3 As New textbox
        Dim text4 As New textbox
        Dim label1 As New label
        Dim label2 As New label
        Dim label3 As New label
        Dim label4 As New label
        Dim label5 As New label

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    

        button.Location = New Point(280,30)
        button.Text = "join string"
        button.Parent = Me

        text1.Location = New Point(5,20)
        text1.Text = " planet "
        text1.Parent = Me

        text2.Location = New Point(5,70)
        text2.Text = " source "
        text2.Parent = Me

        text3.Location = New Point(5,120)
        text3.Text = " code "
        text3.Parent = Me

        text4.Location = New Point(5,170)
        text4.Text = " # just codeit!!!"
        text4.Parent = Me

        label1.Location = New Point(5,0)
        label1.Text = " site: "
        label1.Parent = Me

        label2.Location = New Point(5,50)
        label2.Text = " on "
        label2.Parent = Me

        label3.Location = New Point(5,100)
        label3.Text = " doit "
        label3.Parent = Me

        label4.Location = New Point(5,150)
        label4.Text = " codeit "
        label4.Parent = Me

        label5.Location = New Point(5,200)
        label5.size = new size(640,320-200)
        label5.Text = "  "
        label5.Parent = Me


        AddHandler button.Click, AddressOf Me.OnClick
        
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
       label5.text=text1.Text + text2.Text + text3.Text + text4.Text
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class