Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 

   public class controls
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
   end class


   public class window
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
	    public title as integer
	    public dc as bitmap
	    public bar as bitmap
	    public closed as integer
	    public controlss as controls
   end class


   public class windows
	    public parent as form
	    public ww(8) as window
	    public top as integer
	    public order(8) as integer
	    public front as integer	
      public sub draw( ByVal e As PaintEventArgs,byval bbox as windows)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As brush

	dim value as integer
	dim i as integer

	

        b = New pen  (Color.white)


        bb = New SolidBrush  (Color.Black)

	for i= 0 to 7


	if bbox.ww(bbox.order(i)).closed=0 then
		g.drawimage(bbox.ww(bbox.order(i)).bar,bbox.ww(bbox.order(i)).x,bbox.ww(bbox.order(i)).y)
        	g.drawrectangle(b,bbox.ww(bbox.order(i)).x,bbox.ww(bbox.order(i)).y,bbox.ww(bbox.order(i)).w,bbox.ww(bbox.order(i)).title)
		g.drawimage(bbox.ww(bbox.order(i)).dc,bbox.ww(bbox.order(i)).x,bbox.ww(bbox.order(i)).y+bbox.ww(bbox.order(i)).title)
	end if
	next i

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub


      public sub moveback(byref bbox as windows,n as integer)
	dim i as integer
	dim nw as integer
	dim mm as integer
	mm=bbox.order(n)

	for i=0 to n step 1
		nw=bbox.order(i)
		bbox.order(i)=mm
		mm=nw
	next i
       end sub	


      public function findclose(byref bbox as windows)as integer
	dim i as integer
	dim nw as integer
	dim mm as integer
	mm=-1
	for i=0 to 7
		if bbox.ww(bbox.order(i)).closed=1 then
			bbox.ww(bbox.order(i)).closed=0
		mm=i
		i=8
	         end if
	next i
	if mm>7 then mm=-1
	return mm
       end function	




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

      public function moveNext(byref bbox as windows,x as integer,y as integer) as integer
	dim i as integer
	dim nw as integer
	dim mm as integer
	nw=-1
	
	for i=7 to 0 step -1
           if bbox.ww(bbox.order(i)).closed=0 then		
		if x>bbox.ww(bbox.order(i)).x and x<bbox.ww(bbox.order(i)).x+bbox.ww(bbox.order(i)).w and y>bbox.ww(bbox.order(i)).y and y<bbox.ww(bbox.order(i)).y+bbox.ww(bbox.order(i)).h then
			if nw=-1 then nw=i
			i=-1
	   	end if
	    end if
	next i

	return nw
       end function

      public function controlevents(byref bbox as windows,x as integer,y as integer) as integer
	dim i as integer
	dim nw as integer
	dim mm as integer
	nw=-1
	

           if bbox.ww(bbox.order(7)).closed=0 then		
		if x>bbox.ww(bbox.order(7)).x and x<bbox.ww(bbox.order(7)).x+bbox.ww(bbox.order(7)).w and y>bbox.ww(bbox.order(7)).y and y<bbox.ww(bbox.order(7)).y+bbox.ww(bbox.order(7)).h then
		    if x>bbox.ww(bbox.order(7)).x+bbox.ww(bbox.order(7)).controlss.x and x<bbox.ww(bbox.order(7)).x+bbox.ww(bbox.order(7)).controlss.x+bbox.ww(bbox.order(7)).controlss.w and y>bbox.ww(bbox.order(7)).y+bbox.ww(bbox.order(7)).controlss.y and y<bbox.ww(bbox.order(7)).y+bbox.ww(bbox.order(7)).controlss.y+bbox.ww(bbox.order(7)).controlss.h then		    		
			if nw=-1 then nw=0
			i=-1
	   	     end if
	   	end if
	    end if


	return nw
       end function

      public sub controlclose(byref bbox as windows,index as integer)
		bbox.ww(index).closed=1
       end sub	



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
	Dim b2 As brush
	Dim bb As pen
	Dim bb2 As pen
	dim ss as StringFormat
	ss=new stringformat()
	ff = new font("Arial",16)



       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  windows
        b = New SolidBrush  (Color.white)
        b2 = New SolidBrush  (Color.Black)

        bb = New pen  (Color.Black)
        bb2 = New pen  (Color.white)

       b1.parent=me
       for i= 0 to 7
       	dim fg as graphics
	b1.ww(i)=new window
	b1.ww(i).controlss=new controls
       b1.ww(i).title=20
       b1.ww(i).x=10+i*30
       b1.ww(i).y=10+i*30
       b1.ww(i).w=scr.xx\4
       b1.ww(i).h=scr.yy\4
       b1.ww(i).controlss.x=b1.ww(i).w-20
       b1.ww(i).controlss.y=0
       b1.ww(i).controlss.w=20
       b1.ww(i).controlss.h=b1.ww(i).title
       b1.ww(i).dc=new bitmap(b1.ww(i).w,b1.ww(i).h-b1.ww(i).title)
       b1.ww(i).bar=new bitmap(b1.ww(i).w,b1.ww(i).title)
	b1.order(i)=i
	fg=graphics.fromimage(b1.ww(i).dc)
        fg.fillrectangle(b,0,0,b1.ww(i).w,b1.ww(i).h-b1.ww(i).title)
        fg.drawrectangle(bb,0,0,b1.ww(i).w-1,b1.ww(i).h-b1.ww(i).title-1)
        fg.drawString(str(i),ff,b2,0,0)
        fg.Dispose
	fg=graphics.fromimage(b1.ww(i).bar)
        fg.fillrectangle(b2,0,0,b1.ww(i).w,b1.ww(i).title)
        fg.drawrectangle(bb2,0,0,b1.ww(i).w-1,b1.ww(i).title-1)
        fg.drawString(" window "+str(i),ff,b,0,0)
        fg.fillrectangle(b,b1.ww(i).w-20,0,20,b1.ww(i).title)
        fg.drawrectangle(bb,b1.ww(i).w-18,3,14,b1.ww(i).title-8)
        fg.Dispose
       next i
	randomize()
       bx=10
       by=10

       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
       Me.CenterToScreen
       t= new System.Timers.timer(1600)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=false	
	bb.Dispose
        b.Dispose

	bb.Dispose
        b.Dispose
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
      if b1.controlevents(b1,e.x,e.y)=-1 then 
	i=b1.moveNext(b1,e.x,e.y)
	if i>-1 then 
	tt=1
		b1.moveToTop(b1,i) 
       t.enabled=true
	else
	i=b1.findclose(b1)

	if i>-1 then 
	b1.parent.Text="reopen windows "+str(b1.order(i))
	b1.moveToTop(b1,i)  
	end if 
	end if 
      else
	b1.controlclose(b1,b1.order(7))	
	b1.moveback(b1,7)
	end if 
    application.doevents()
    b1.parent.refresh()     
    end if   
    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











