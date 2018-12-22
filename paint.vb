Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D


Public Class WinVBApp

    inherits Form
    shared f1 as form
    shared T as System.Timers.timer
    shared count as integer

    Public Sub New
       count=0
       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       f1 =me
       AddHandler Me.Paint AddressOf Me.OnPaint
       
       Me.CenterToScreen
       t= new System.Timers.timer(1000)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    count=count+1
    application.doevents()
    f1.refresh()     
    if count > 13 then
		 t.stop()
		 t.dispose()
     end if

    end sub 

    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    
        Dim g As Graphics = e.Graphics
	dim xx as integer =0
	dim x1 as integer =0
	dim y1 as integer =0
	dim x2 as integer =640
	dim y2 as integer =300
	dim adds as integer =0 
	Dim b As Brush

	for xx=0 to count 


		if adds=0 then
		        b = New SolidBrush (Color.Black)
		else
		        b = New SolidBrush (Color.White)
		end if			

	        g.FillRectangle(b, x1,y1, x2, y2)
		x1=x1+10
		x2=x2-20
		y1=y1+10
		y2=y2-20
		adds=adds+1
		if adds > 1 then adds=0 
	next xx

        g.Dispose
        b.Dispose

    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class