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
	    public dc as bitmap
   end class


   public class windows
	    public parent as form
	    public ww(8) as window
	    public clocker as integer
	    public raised as integer
      public sub draw( ByVal e As PaintEventArgs,byref bbox as windows)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen

	dim value as integer
	dim i as integer
	bbox.raised=0
	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)

	for i= 0 to 7
	g.drawimage(bbox.ww(i).dc,bbox.ww(i).x,bbox.ww(i).y)
	next i

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub

      public sub ants(byref bbox as windows)
	if bbox.clocker > 7 then bbox.clocker=0
	bbox.ww(bbox.clocker).x=bbox.ww(bbox.clocker).x+20
	if bbox.ww(bbox.clocker).x > 600 then bbox.ww(bbox.clocker).x=0
	if bbox.clocker = 7 then bbox.raised=1
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
       for i= 0 to 7
       	dim fg as graphics
	b1.ww(i)=new window
       b1.ww(i).w=scr.xx\10
       b1.ww(i).h=scr.yy\10
       b1.ww(i).x=20*i
       b1.ww(i).y=b1.ww(i).h*i+20
       b1.ww(i).dc=new bitmap(b1.ww(i).w,b1.ww(i).h)

	fg=graphics.fromimage(b1.ww(i).dc)
        fg.fillellipse(b2,new rectangle(0,0,b1.ww(i).w\2,b1.ww(i).h\2))
        fg.Dispose
       next i
       bx=10
       by=10

       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(100)
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











