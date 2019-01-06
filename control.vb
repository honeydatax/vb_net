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
	    public event anEvent(byref bbox as windows,index as integer)
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

      public sub onTop(byref bbox as windows)
		raiseevent anEvent(bbox,bbox.order(7))
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

      public function moveNext(byref bbox as windows,x as integer,y as integer) as integer
	dim i as integer
	dim nw as integer
	dim mm as integer
	nw=-1
	
	for i=7 to 0 step -1
		if x>bbox.ww(bbox.order(i)).x and x<bbox.ww(bbox.order(i)).x+bbox.ww(bbox.order(i)).w and y>bbox.ww(bbox.order(i)).y and y<bbox.ww(bbox.order(i)).y+bbox.ww(bbox.order(i)).h then
			if nw=-1 then nw=i
			i=-1
		end if
	next i

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
       for i= 0 to 7
       	dim fg as graphics
	b1.ww(i)=new window
       b1.ww(i).x=10+i*(scr.xx\10)
       b1.ww(i).y=scr.yy\3
       b1.ww(i).w=scr.xx\11
       b1.ww(i).h=scr.yy\3
       b1.ww(i).dc=new bitmap(b1.ww(i).w,b1.ww(i).h)
	b1.order(i)=i
	fg=graphics.fromimage(b1.ww(i).dc)
        fg.fillrectangle(b,0,0,b1.ww(i).w,b1.ww(i).h)
        fg.drawrectangle(bb,0,0,b1.ww(i).w-1,b1.ww(i).h-1)
        fg.drawString(str(i),ff,b2,0,0)
        fg.Dispose
       next i
	randomize()
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
	i=b1.moveNext(b1,e.x,e.y)
	if i>-1 then 
	tt=1
		b1.moveToTop(b1,i) 
		b1.onTop(b1)
       t.enabled=true
	end if 
    application.doevents()
    b1.parent.refresh()     
    end if   
    End Sub

    Private Sub On0(byref bbox as windows,index as integer)
		if index=0 then bbox.parent.text="control 0 raised "

		if index=1 then bbox.parent.text="control 1 raised "

		if index=2 then bbox.parent.text="control 2 raised "

		if index=3 then bbox.parent.text="control 3 raised "

		if index=4 then bbox.parent.text="control 4 raised "

		if index=5 then bbox.parent.text="control 5 raised "

		if index=6 then bbox.parent.text="control 6 raised "

		if index=7 then bbox.parent.text="control 7 raised "
	end sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











