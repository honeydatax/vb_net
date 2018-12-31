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
	    public ww(2) as window
	    public top as integer
      public sub draw( ByVal e As PaintEventArgs,byval bbox as windows)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen

	dim value as integer
	dim i as integer

	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)

	if bbox.top=0 then g.drawimage(bbox.ww(0).dc,bbox.ww(0).x,bbox.ww(0).y)
	g.drawimage(bbox.ww(1).dc,bbox.ww(1).x,bbox.ww(1).y)
	if bbox.top<>0 then g.drawimage(bbox.ww(0).dc,bbox.ww(0).x,bbox.ww(0).y)

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub
      public sub moveToTop(byval bbox as windows)
	bbox.top=bbox.top+1
	if bbox.top>1 then bbox.top=0
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
	dim fontSize as integer
	fontSize=72
	dim ff as font 
	Dim b As brush
	Dim b2 As brush
	Dim bb As pen
	dim ss as StringFormat
	ss=new stringformat()
	ff = new font("Terminal",fontSize)



       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  windows
        b = New SolidBrush  (Color.white)
        b2 = New SolidBrush  (Color.Black)

        bb = New pen  (Color.Black)

       b1.parent=me
	for i=0 to 1
       	dim fg as graphics
	b1.ww(i)=new window
       b1.ww(i).x=10+i*40
       b1.ww(i).y=10+i*40
       b1.ww(i).w=scr.xx\2
       b1.ww(i).h=scr.yy\2
       b1.ww(i).dc=new bitmap(b1.ww(i).w,b1.ww(i).h)
	fg=graphics.fromimage(b1.ww(i).dc)
        fg.fillrectangle(b,0,0,b1.ww(i).w,b1.ww(i).h)
        fg.drawrectangle(bb,0,0,b1.ww(i).w-1,b1.ww(i).h-1)
        if i=0 then fg.drawString(str(i),ff,b2,0,0)
        if i=1 then fg.drawString(str(i),ff,b2,b1.ww(i).w-(fontSize*11\8),b1.ww(i).h-(fontSize*11\8))
        fg.Dispose
	next i
       bx=10
       by=10

       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(1500)
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
	b1.MoveToTop(b1)
	application.doevents()
	b1.parent.refresh()   

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











