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
        Dim text1 As New textbox
        Dim text2 As New textbox
        Dim label1 As New label
        Dim label2 As New label
        Dim label5 As New label

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    

        button.Location = New Point(280,30)
        button.Text = "creat image file"
        button.Parent = Me

        text1.Location = New Point(5,20)
        text1.Text = "disk1.img"
        text1.Parent = Me

        text2.Location = New Point(5,70)
        text2.Text = "5"
        text2.Parent = Me

        label1.Location = New Point(5,0)
        label1.Text = " img file name: "
        label1.Parent = Me

        label2.Location = New Point(5,50)
        label2.Text = " imgage size:"
        label2.Parent = Me


        label5.Location = New Point(5,200)
        label5.size = new size(640,320-200)
        label5.Text = "  "
        label5.Parent = Me


        AddHandler button.Click, AddressOf Me.OnClick

        
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)

		try           	
			if val(text2.Text) < 400 and val(text2.Text) > 0 then
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments = "-c 'dd if=/dev/zero of="+text1.Text + " iflag=fullblock bs=1M count="+text2.Text + "' "
			psi.RedirectStandardOutput = true
			dim p as Process = Process.Start(psi)
			p = Process.Start(psi)
			label5.Text =p.StandardOutput.ReadToEnd()
			p.WaitForExit()
			p.Close()

			else
			label5.Text =label5.Text+"error drive to big "
			end if
			label5.Text =label5.Text+"finish"
                 catch ee as Exception 
			   label5.Text ="ERROR same data is not correct"
			   end try



    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






