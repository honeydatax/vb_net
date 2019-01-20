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
    

        text0.Location = New Point(3,53)
        text0.size = New size(610,240)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me

        button.Location = New Point(280,30)
        button.Text = "exec."
        button.Parent = Me

        text1.Location = New Point(5,0)
        text1.size = New size(630,30)
        text1.Text = "CREATE TABLE CLIENT(ID INT PRIMARY KEY NOT NULL,NAME TEXT NOT NULL,ADDRESS CHAR(50),PHONE CHAR(15));"
        text1.Parent = Me

        text2.Location = New Point(5,30)
        text2.Text = "client.db"
        text2.Parent = Me



        AddHandler button.Click, AddressOf Me.OnClick






     
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
		dim c as string
		try           	
			
			c= "-c 'timeout 39s sqlite "+trim(text2.Text)+" ' "
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
			mystreamWriter.writeline(".head on")
			mystreamWriter.writeline(trim(text1.text).tostring()+";")
			mystreamWriter.writeline(".quit")
			text0.text =text0.text+p.StandardOutput.ReadToEnd()
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






