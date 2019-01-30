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
        button.Text = "parametres:"
        button.Parent = Me

        text2.Location = New Point(5,3)
        text2.size = New size(550,20)
        text2.Text = "par0,par1,par2,par3,par4,par5,par6,par7,par8,par9,end"
        text2.Parent = Me



        AddHandler button.Click, AddressOf Me.OnClick






     
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
		dim c as string
		dim iii as integer
		try           	
			c= text2.text
			dim s as string()=c.split(",")
			
			text0.text=""
			dim ss as string
			for each ss in s
				text0.text =ss+chr(13)+chr(10)+text0.text 				
				iii=iii+1
			next 			
			text0.text=str(iii)+chr(13)+chr(10)+text0.text
                 catch ee as Exception 
			   text0.text ="ERROR same data is not correct"
			   end try

     

        
    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






