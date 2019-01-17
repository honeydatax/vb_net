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
        Dim text1 As New textbox

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    

        text1.Location = New Point(3,3)
        text1.size = New size(610,290)
        text1.multiline = true
        text1.scrollbars = 2
        text1.Parent = Me


		try           	

			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments = "-c 'ps -ax"+ "' "
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p = Process.Start(psi)
			text1.text =p.StandardOutput.ReadToEnd()
			p.WaitForExit()
			p.Close()
                 catch ee as Exception 
			   text1.text ="ERROR same data is not correct"
			   end try

     
        Me.CenterToScreen
        
    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






