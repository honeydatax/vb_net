Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 

   public class window
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
	    public colision as integer	    
	    public counter as integer
	    public dc as bitmap
   end class


   public class windows
	    public parent as form
	    public ww(2) as window
	    public clocker as integer
	    public raised as integer
	    public scr1 as scr
      public sub draw( ByVal e As PaintEventArgs,byref bbox as windows)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen

	dim value as integer
	dim i as integer
	bbox.raised=0
	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)

	for i= 0 to 1
	g.drawimage(bbox.ww(i).dc,bbox.ww(i).x,bbox.ww(i).y)
	next i

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub

      public sub ants(byref bbox as windows)
	dim x0h as integer
	dim x1h as integer
	dim x2h as integer
	dim x3h as integer
	x0h=bbox.ww(0).x + bbox.ww(0).w\2
	x1h=bbox.ww(1).x + bbox.ww(0).w\2
	if bbox.clocker > 1 then bbox.clocker=0
	if bbox.clocker=0 and bbox.ww(0).colision=0 then bbox.ww(bbox.clocker).x=bbox.ww(bbox.clocker).x+20
	if bbox.clocker=0 and bbox.ww(bbox.clocker).x > 600 then bbox.ww(bbox.clocker).x=0
	if bbox.clocker=1 and bbox.ww(0).colision=0 then bbox.ww(bbox.clocker).x=bbox.ww(bbox.clocker).x-20
	if bbox.clocker=1 and bbox.ww(bbox.clocker).x < bbox.ww(bbox.clocker).w then bbox.ww(bbox.clocker).x=bbox.scr1.xx-bbox.ww(1).w

	if bbox.ww(1).colision=0 and bbox.ww(0).colision=0  and bbox.ww(0).counter=0 and bbox.ww(1).counter=0 and x1h < x0h+50  and x1h > x0h then
	       bbox.parent.Text = "colision"
		bbox.ww(0).colision=1
		bbox.ww(1).colision=1
		bbox.ww(0).counter=10
		bbox.ww(1).counter=10
	end if
	bbox.ww(0).counter=bbox.ww(0).counter-1
	bbox.ww(1).counter=bbox.ww(1).counter-1
	if bbox.ww(0).counter < 0 then bbox.ww(0).counter = 0 
	if bbox.ww(1).counter < 0 then bbox.ww(1).counter = 0 
	
	if bbox.ww(0).colision=1 and bbox.ww(0).counter = 0 then bbox.ww(0).x=0
	if bbox.ww(1).colision=1 and bbox.ww(1).counter = 0 then bbox.ww(1).x=scr1.xx-bbox.ww(1).w
	if bbox.ww(0).counter = 0 and bbox.ww(0).colision=1 then 
		bbox.ww(0).colision=0
	       bbox.parent.Text = "linesky@sapo.pt"
	end if
	if bbox.ww(1).counter = 0 and bbox.ww(1).colision=1 then bbox.ww(1).colision=0
	if bbox.ww(0).counter = 0 then bbox.ww(0).colision=0
	if bbox.ww(1).counter = 0 then bbox.ww(1).colision=0
	if bbox.clocker = 1 then bbox.raised=1
	bbox.clocker=bbox.clocker+1

       end sub
    end class


Public Class WinVBApp

    inherits Form
    shared bx as integer
    shared by as integer
    shared b1 as windows
    shared T as System.Timers.timer
   shared scr1 as new scr

    Public Sub New
       dim i as integer
	dim ff as font 
	Dim b As brush
	Dim b2 As brush
	Dim bb As pen
	dim ss as StringFormat
	ss=new stringformat()
	ff = new font("Arial",16)



       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  windows
        b = New SolidBrush  (Color.white)
        b2 = New SolidBrush  (Color.Black)

        bb = New pen  (Color.Black)

       b1.parent=me
	b1.raised=0

       for i= 0 to 1
       	dim fg as graphics
	b1.ww(i)=new window
       b1.ww(i).w=scr.xx\10
       b1.ww(i).h=scr.yy\10
       b1.ww(i).x=0
       b1.ww(i).y=scr.yy\2
       b1.ww(i).dc=new bitmap(b1.ww(i).w,b1.ww(i).h)

	fg=graphics.fromimage(b1.ww(i).dc)
        if i = 0 then fg.fillellipse(b2,new rectangle(0,0,b1.ww(i).w\2,b1.ww(i).h\2))
        if i = 1 then fg.fillellipse(b,new rectangle(0,0,b1.ww(i).w\2,b1.ww(i).h\2))
        fg.Dispose
       next i
	b1.ww(1).x=b1.ww(1).x-b1.ww(1).w
       bx=10
       by=10

       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(400)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
	bb.Dispose
        b.Dispose

	bb.Dispose
        b.Dispose
        ss.dispose


	ff.Dispose





    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
	b1.ants(b1)
	if b1.raised=1 then
	    application.doevents()
	    b1.parent.refresh()   
	end if
    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
'    if e.button>0 and e.x>20 and e.y >20 then
'	b1.w=e.x-10
'	b1.h=e.y-10
'    application.doevents()
'    b1.parent.refresh()     
'    end if   
    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











