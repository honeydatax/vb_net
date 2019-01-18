Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary


Public Class WinVBApp
    Inherits Form
        Dim button As New Button
        Dim button2 As New Button
        Dim text1 As New textbox
        Dim text2 As New textbox
        Dim text3 As New textbox
        Dim label1 As New label
        Dim label2 As New label
        Dim label3 As New label
        Dim label5 As New label

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    

        button.Location = New Point(280,30)
        button.Text = "send"
        button.Parent = Me

        button2.Location = New Point(280,80)
        button2.Text = "reciver"
        button2.Parent = Me


        text1.Location = New Point(5,20)
        text1.Text = "hello world!!!!"
        text1.Parent = Me

        text2.Location = New Point(5,70)
        text2.Text = "ttyS0"
        text2.Parent = Me

        text3.Location = New Point(5,120)
        text3.Text = "30"
        text3.Parent = Me

        label1.Location = New Point(5,0)
        label1.Text = "mesage:"
        label1.Parent = Me

        label2.Location = New Point(5,50)
        label2.Text = " port: "
        label2.Parent = Me

        label3.Location = New Point(5,100)
        label3.Text = "timeout sec. "
        label3.Parent = Me

        label5.Location = New Point(5,200)
        label5.size = new size(640,320-200)
        label5.Text = "  "
        label5.Parent = Me


        AddHandler button.Click, AddressOf Me.OnClick
        AddHandler button2.Click, AddressOf Me.OnClick2
        
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)

		try     

			label5.Text = "wait>"
			application.doevents()      	
		if val(text3.Text) > 59 then text3.Text="59"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments = "-c 'timeout " +text3.Text + "s echo -ne "+text1.Text + " > /dev/"+text2.Text + "' "
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p = Process.Start(psi)
			label5.Text =p.StandardOutput.ReadToEnd()
			p.WaitForExit()
			p.Close()

			label5.Text =label5.Text+"finish"
                 catch ee as Exception 
			   label5.Text ="ERROR same data is not correct"
			   end try



    End Sub

    Private Sub OnClick2(ByVal sender As Object, ByVal e As EventArgs)

		try           	

			label5.Text = "wait>"
			application.doevents()      	
		if val(text3.Text) > 59 then text3.Text="59"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments = "-c 'timeout 30s cat -v < /dev/"+text2.Text + "' "
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p = Process.Start(psi)
			label5.Text =p.StandardOutput.ReadToEnd()
			p.WaitForExit()
			p.Close()
			label5.Text =label5.Text + " :finish"
                 catch ee as Exception 
			   label5.Text ="ERROR same data is not correct"
			   end try



    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






