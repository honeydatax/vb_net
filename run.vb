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

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(220, 60)
       
       Me.InitUI
       

    End Sub
    
    Private Sub InitUI
    

        button.Location = New Point(5,5)
        button.Text = " run "
        button.Parent = Me

        text1.Location = New Point(100,5)
        text1.Text = "cal.pdf"
        text1.Parent = Me


        AddHandler button.Click, AddressOf Me.OnClick

        
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)

		try           	

			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments = "-c 'xdg-open "+text1.Text + "' "
			psi.RedirectStandardOutput = true
			dim p as Process 
			p = Process.Start(psi)
			me.Text =p.StandardOutput.ReadToEnd()
			p.WaitForExit()
			p.Close()

                 catch ee as Exception 
			   me.Text ="ERROR same data is not correct"
			   end try



    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






