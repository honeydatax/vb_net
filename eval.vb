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
	dim ii as integer
	dim i as integer
        Dim button As New Button
        Dim text0 As New textbox
        Dim text1 As New textbox
        Dim text2 As New textbox

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    
	ii=0
        text0.Location = New Point(3,53)
        text0.size = New size(610,240)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me

        button.Location = New Point(560,3)
        button.Text = "math eval."
        button.Parent = Me

        text2.Location = New Point(5,3)
        text2.size = New size(550,20)
        text2.Text = "var1=10;var2=7;var3=var2*var1;var4=var1*var3;(var2*var4)"
        text2.Parent = Me



        AddHandler button.Click, AddressOf Me.OnClick






     
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
		dim c as string
		dim iii as integer
		try           	
			c= "-c 'timeout 10s bc ' "
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			dim mystreamWriter as streamWriter =p.StandardInput
			mystreamWriter.writeline(text2.text)
			mystreamWriter.writeline("quit")
			text0.text =text2.text+chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10)+text0.text 
			mystreamWriter.close()
			p.WaitForExit()
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"
                 catch ee as Exception 
			   text0.text ="ERROR same data is not correct"
			   end try

     

        
    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






