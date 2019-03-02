Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.text
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary


Public Class WinVBApp
    Inherits Form
	dim sss as string
	dim s as string
	dim ss as string
	dim n as integer
	dim c as string
	dim ii as integer
	dim i as integer
	dim vvv as string
        Dim button2 As New Button
        Dim text0 As New textbox



    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    
	ii=0
        text0.Location = New Point(3,38)
        text0.size = New size(550,290)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me


        button2.Location = New Point(560,33)
        button2.Text = "run hex:"
        button2.Parent = Me



        AddHandler button2.Click, AddressOf Me.OnClick2



  
        Me.CenterToScreen
        
    End Sub


    Private Sub OnClick2(ByVal sender As Object, ByVal e As EventArgs)




		try           	
		sss=inputbox("file name to list hex","file")
		ss=inputbox("start hex address to list star at 0","hex value")
		s=inputbox("ending hex address to list ","hex value")


		vvv="debug.com > output.txt < input.txt " +chr(13)+chr(10)+"echo close me"
	If Not System.IO.File.Exists("out.bat") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("out.bat")
	    ffile.Close()
	End If

	file.WriteAllText("out.bat",vvv)


		vvv="n "+sss+chr(13)+chr(10)+"l 100"+chr(13)+chr(10)+"rcx"+chr(13)+chr(10)+"10"+chr(13)+chr(10)+"a 80"+chr(13)+chr(10)+"mov ax,ds"+chr(13)+chr(10)+"add ax,cx"+chr(13)+chr(10)+"mov ds,ax"+chr(13)+chr(10)+""+chr(13)+chr(10)+"rip"+chr(13)+chr(10)+"80"+chr(13)+chr(10)+"p 3"+chr(13)+chr(10)+chr(13)+chr(10)+"d "+ss+" "+s +chr(13)+chr(10)+""+chr(13)+chr(10)+"q"+chr(13)+chr(10)+"q"+chr(13)+chr(10)
	If Not System.IO.File.Exists("input.txt") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("input.txt")
	    ffile.Close()
	End If

	file.WriteAllText("input.txt",vvv)





			c= "-c 'timeout 100s dosbox out.bat '"
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
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"open output "
			
                 catch ee as Exception 
			   text0.text =" ERROR same data is not correct"
			   end try



		try           	
			c= "-c 'mousepad OUTPUT.TXT '"
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
			p.WaitForExit()
			p.Close()
			application.doevents
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try



    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






