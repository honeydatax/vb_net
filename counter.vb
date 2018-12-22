Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 



   public class counters
	    public parent as form
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
	    public counter as integer
	    public text as string
      public sub draw( ByVal e As PaintEventArgs,byval bbox as counters)

        Dim g As Graphics = e.Graphics

	Dim b As brush
	Dim bb As pen
	Dim b1 As brush
	Dim bb1 As pen


	dim value as integer
	dim i as integer
	dim xn as single
	dim yn as single
	dim ff as font 
	dim ss as StringFormat
	ss=new stringformat()
	bbox.text=str(bbox.counter)
'	ss.formatflags=StringformatFlags.directionhorizontal
	ff = new font("Arial",bbox.h-10)
	if len(bbox.text)*(bbox.h-10) > bbox.w then 
		i=bbox.w\bbox.h
		bbox.text=right(bbox.text,i)
	end if
	xn=bbox.x
	yn=bbox.y
	

        b = New solidbrush  (Color.White)


        bb = New pen  (Color.White)




        b1 = New solidbrush  (Color.Black)


        bb1 = New pen  (Color.Black)



        g.drawrectangle(bb,bbox.x,bbox.y,bbox.w,bbox.h)
        g.drawString(bbox.text,ff,b,xn,xn)
        g.drawrectangle(bb1,bbox.x+1,bbox.y+1,bbox.w,bbox.h)
        g.drawString(bbox.text,ff,b1,xn+5.0f,xn+5.0f)




exits:
       g.Dispose
	bb.Dispose
        b.Dispose
	bb1.Dispose
        b1.Dispose
	ff.Dispose

       end sub
    end class


Public Class WinVBApp

    inherits Form
    shared bx as integer
    shared by as integer
    shared b1 as counters
    shared T as System.Timers.timer
   shared scr1 as new scr

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  counters

       b1.x=10
       b1.y=10
       b1.parent=me
       b1.w=250
       b1.h=50
	bx=10
	by=10
	b1.text="Planet Source Code"
       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.KeyPress AddressOf Me.OnKeyPress
       
       Me.CenterToScreen
       t= new System.Timers.timer(1000)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    b1.counter=b1.counter+1
    if b1.counter>60 then
	b1.counter=0
    end if	
    application.doevents()
    b1.parent.refresh()     

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub

    Private Sub OnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











