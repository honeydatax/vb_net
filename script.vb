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
        text0.Location = New Point(3,170)
        text0.size = New size(610,150)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me

        button.Location = New Point(560,3)
        button.Text = "scrip:"
        button.Parent = Me

        text2.Location = New Point(5,3)
        text2.size = New size(550,150)
        text2.multiline = true
        text2.scrollbars = 3
        text2.Parent = Me
	for ii=0 to 60
		        text2.Text = text2.Text+"line "+trim(str(ii))+chr(13)+chr(10)
	next ii


        AddHandler button.Click, AddressOf Me.OnClick






     
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)
		dim c as string
		dim t as string
		dim tt as string
		dim iii as integer
		try           	
			c= text2.text
			c=c.replace(chr(13),"")				 
			dim s as string()=c.split(chr(10))
			iii=10
			t=chr(13)+chr(10)+" ret"+chr(13)+chr(10)+chr(13)+chr(10)+"L0print:"+chr(13)+chr(10)+" mov ah,9"+chr(13)+chr(10)+" int 0x21"+chr(13)+chr(10)+" ret"+chr(13)+chr(10)
			t=t+chr(13)+chr(10)+" ret"+chr(13)+chr(10)+chr(13)+chr(10)+"L2keycheck:"+chr(13)+chr(10)+"	mov bx,L4"+chr(13)+chr(10)+"	mov al,[bx]"+chr(13)+chr(10)+"	inc al"+chr(13)+chr(10)+"	mov [bx],al"+chr(13)+chr(10)+"	cmp al,20"+chr(13)+chr(10)
			t=t+chr(13)+chr(10)+"	jnz L5"+chr(13)+chr(10)+chr(13)+chr(10)+"	xor al,al"+chr(13)+chr(10)+"	mov [bx],al"+chr(13)+chr(10)+chr(13)+chr(10)+"	mov si,dx"+chr(13)+chr(10)+"	mov ah,9"+chr(13)+chr(10)+"	mov dx,L6"+chr(13)+chr(10)+"	int 0x21"+chr(13)+chr(10)+"	mov dx,si"+chr(13)+chr(10)+"	mov ah,al"+chr(13)+chr(10)+"	int 0x16"+chr(13)+chr(10)+"	cmp al,27"+chr(13)+chr(10)+"	jz L7"+chr(13)+chr(10)
			t=t+chr(13)+chr(10)+"L5:"+chr(13)+chr(10)+chr(13)+chr(10)+"	call L0print"+chr(13)+chr(10)+"	ret"+chr(13)+chr(10)+chr(13)+chr(10)+chr(13)+chr(10)+"L7:"+chr(13)+chr(10)+chr(13)+chr(10)+chr(13)+chr(10)+"	xor ax,ax"+chr(13)+chr(10)+chr(13)+chr(10)+chr(13)+chr(10)+"	int 0x21"+chr(13)+chr(10)+chr(13)+chr(10)+chr(13)+chr(10)+"	ret"+chr(13)+chr(10)+chr(13)+chr(10)
			t=t+chr(13)+chr(10)+"	ret"+chr(13)+chr(10)+"section .data"+chr(13)+chr(10)+"L4 db 0,0,0,0,0"+chr(13)+chr(10)+chr(13)+chr(10)+"L6 db 'press a key to go on, esc key to exit scroll',13,10,'$'"+chr(13)+chr(10)
			tt="section .text"+chr(13)+chr(10)+"org 0x100"+chr(13)+chr(10)+"main:"+chr(13)+chr(10)+chr(13)+chr(10)
			dim ss as string
			for each ss in s
			
				ss=ss.replace("'",chr(34))				
				tt =tt+"	mov dx,L"+trim(str(iii))+chr(13)+chr(10)+"	call L2keycheck"+chr(13)+chr(10)
				t =t+"L"+trim(str(iii))+" db '"+ss+"',13,10,'$'"+chr(13)+chr(10)
				iii=iii+1
			next 			
			tt=tt+chr(13)+chr(10)+"	xor ax,ax"+chr(13)+chr(10)+"	int 0x21"+chr(13)+chr(10)
                 catch ee as Exception 
			   text0.text ="ERROR same data is not correct line :"+str(iii-9)
			   end try
			text0.text =tt + t
     

        
    End Sub



    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






