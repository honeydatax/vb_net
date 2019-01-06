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
	    public top as integer
	    public order(8) as integer
	    public scr1 as scr
      public sub draw( ByVal e As PaintEventArgs,byval bbox as windows)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen

	dim value as integer
	dim i as integer

	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)

	for i= 0 to 7
	g.drawimage(bbox.ww(bbox.order(i)).dc,bbox.ww(bbox.order(i)).x,bbox.ww(bbox.order(i)).y)

	next i

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub

      public sub moveToTop(byref bbox as windows,n as integer)
	dim i as integer
	dim nw as integer
	dim mm as integer
	mm=bbox.order(n)
	
	for i=7 to n step -1
		nw=bbox.order(i)
		bbox.order(i)=mm
		mm=nw
	next i
       end sub	

      public sub moveNext(byref bbox as windows)
		bbox.top=int(7*rnd())
       end sub	

      public sub center(byref bbox as windows,index as integer)
		bbox.ww(index).x=bbox.scr1.xx\2-bbox.ww(index).w\2
		bbox.ww(index).y=bbox.scr1.yy\2-bbox.ww(index).h\2
       end sub	


      public function rndsize(r as integer)as integer
	return int (rnd()*r)+50
	end function



      public sub creatHW(byref bbox as windows,index as integer)
       bbox.ww(index).dc=new bitmap(bbox.ww(index).w,bbox.ww(index).h)
	end sub

      public sub resiseHW(byref bbox as windows,index as integer,w as integer,h as integer)
       bbox.ww(index).dc.Dispose
	bbox.ww(index).w=w
	bbox.ww(index).h=h
       bbox.ww(index).dc=new bitmap(bbox.ww(index).w,bbox.ww(index).h)
	end sub

      public sub moveHW(byref bbox as windows,index as integer,x as integer,y as integer)
	bbox.ww(index).x=x
	bbox.ww(index).y=y
	end sub


      public sub cls(byref bbox as windows,index as integer)
       dim i as integer
	dim ff as font 
	Dim b As brush
	Dim b2 As brush
	Dim bb As pen
	dim ss as StringFormat
	dim a as integer
       	dim fg as graphics
	ss=new stringformat()
	ff = new font("Arial",16)
        b = New SolidBrush  (Color.white)
        b2 = New SolidBrush  (Color.Black)

        bb = New pen  (Color.Black)


	fg=graphics.fromimage(bbox.ww(index).dc)
        fg.fillrectangle(b,0,0,bbox.ww(index).w,bbox.ww(index).h)
        fg.drawrectangle(bb,0,0,bbox.ww(index).w-1,bbox.ww(index).h-1)
       fg.drawString(str(index),ff,b2,0,0)
        fg.Dispose
	bb.Dispose
        b.Dispose

	bb.Dispose
        b.Dispose
        ss.dispose


	ff.Dispose

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
	dim a as integer



       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  windows
	randomize()
       b1.parent=me
       for i= 0 to 7

	b1.ww(i)=new window
       b1.ww(i).w=b1.rndsize(300)
       b1.ww(i).h=b1.rndsize(150)
       b1.center(b1,i)
	b1.creatHW(b1,i)
	b1.order(i)=i
	b1.cls(b1,i)
       next i

       bx=10
       by=10

       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(1600)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	





    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
	    b1.moveNext(b1)
	    b1.moveToTop(b1,b1.top)
	    b1.resiseHW(b1,b1.order(7),b1.rndsize(300),b1.rndsize(150))
	    b1.center(b1,b1.order(7))
	    b1.cls(b1,b1.order(7))
'	    application.doevents()
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











