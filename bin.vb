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
           dim rtxt() as byte
	   dim a as integer



		try           	
		sss=inputbox("file name to list hex","file","file.dat")


		text0.text="machine "
	rtxt=file.readallbytes(sss)
	for a=0 to rtxt.length
		text0.text=text0.text+" , "+str(rtxt(a))
	next	
                 catch ee as Exception
	end try


    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






