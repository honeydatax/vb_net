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
	    public scr1 as scr
	    public parent as form
	    public ww(8) as window
	    public top as integer
	    public order(8) as integer
	    public event anEvent(byref bbox as windows,index as integer)
	    public dc as bitmap
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
	    public value as integer
      public sub draw( ByVal e As PaintEventArgs,byval bbox as windows)

       	dim fg as graphics
        Dim g As Graphics = e.Graphics
	dim rect as rectangleF
	
	Dim b As pen
	Dim bb As pen


	Dim b2 As brush
	Dim bb2 As brush




	dim value as integer
	dim i as integer

        b2 = New solidbrush  (Color.white)


        bb2 = New solidbrush  (Color.Black)
	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)
	rect.x=bbox.x
	rect.y=bbox.y
	rect.height=bbox.scr1.yy-50
	rect.width=bbox.w
	g.drawimage(bbox.dc,0.00f,0.00f,rect,2)

	i=0
        g.fillrectangle(b2,bbox.ww(i).x,bbox.ww(i).y,bbox.ww(i).w,bbox.ww(i).h)
        g.drawrectangle(b,bbox.ww(i).x,bbox.ww(i).y,bbox.ww(i).w,bbox.ww(i).h)
        g.drawrectangle(bb,bbox.ww(i).x,bbox.ww(i).y+bbox.value,bbox.ww(i).w,bbox.ww(i).w)
	bb.Dispose
        b.Dispose

	bb2.Dispose
        b2.Dispose



exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub

      public sub onTop(byref bbox as windows)
		raiseevent anEvent(bbox,0)
       end sub


      public function moveNext(byref bbox as windows,x as integer,y as integer) as integer
	dim i as integer
	dim nw as integer
	dim mm as integer
	nw=-1
	
	i=0
		if x>bbox.ww(i).x and x<bbox.ww(i).x+bbox.ww(i).w and y>bbox.ww(i).y and y<bbox.ww(i).y+bbox.ww(i).h then
			bbox.value=y-bbox.ww(i).y
			if nw=-1 then nw=i
			i=-1
		end if


	return nw
       end function


    end class


Public Class WinVBApp

    inherits Form
    shared bx as integer
    shared by as integer
    shared b1 as windows
    shared T as System.Timers.timer
    shared tt as integer
   shared scr1 as new scr

    Public Sub New
       dim i as integer
	dim ff as font 
	Dim b As brush
	Dim bb2 As brush
	Dim b2 As brush
	Dim bb As pen
	dim ss as StringFormat
	ss=new stringformat()
	ff = new font("Arial",16)
       	dim fg as graphics
	randomize()

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  windows
        b = New SolidBrush  (Color.white)
        b2 = New SolidBrush  (Color.Black)
        bb2 = New SolidBrush  (Color.Black)
        bb = New pen  (Color.Black)

       b1.parent=me
       b1.x=0
       b1.y=0
       b1.w=scr.xx-100
       b1.h=20*14*8
       b1.dc=new bitmap(b1.w,b1.h)
	fg=graphics.fromimage(b1.dc)
        fg.fillrectangle(b,0,0,b1.w,b1.h)
        fg.drawrectangle(bb,0,0,b1.w-1,b1.h-1)
       for i= 0 to 200
		fg.fillellipse(b2,new rectangle(int(rnd()*b1.w),int(rnd()*b1.h),4,4))
       next i
        fg.Dispose


       i= 0 

	b1.ww(i)=new window
       b1.ww(i).x=scr.xx-25
       b1.ww(i).y=0
       b1.ww(i).w=25
       b1.ww(i).h=(scr.yy-50)
       b1.value=0


       bx=10
       by=10

	AddHandler b1.anevent AddressOf Me.On0
       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(1600)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=false	
	bb.Dispose
        b.Dispose

	bb2.Dispose
        b2.Dispose
        ss.dispose


	ff.Dispose





    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
	tt=0
       t.enabled=false
    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
	dim i as integer
    if e.button>0 and tt=0 then
	i=b1.moveNext(b1,e.x,e.y)
	if i>-1 then 
	tt=1
		b1.onTop(b1)
       t.enabled=true
	end if 
    application.doevents()
    b1.parent.refresh()     
    end if   
    End Sub

    Private Sub On0(byref bbox as windows,index as integer)
		bbox.y=(((((20*14)*8)*(bbox.value+1))\bbox.ww(0).h))

	end sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











