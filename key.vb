Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 



   public class boxs
	    public parent as form
	    public x as integer
	    public y as integer
	    public w as integer
	    public h as integer
	    public text as string
      public sub draw( ByVal e As PaintEventArgs,byval bbox as boxs)

        Dim g As Graphics = e.Graphics

	Dim b As brush
	Dim bb As pen

	dim value as integer
	dim i as integer
	dim xn as single
	dim yn as single
	dim ff as font 
	dim ss as StringFormat
	ss=new stringformat()
'	ss.formatflags=StringformatFlags.directionhorizontal
	ff = new font("Arial",bbox.h-10)
	if len(bbox.text)*bbox.h > bbox.w then 
		i=bbox.w\bbox.h
		bbox.text=right(bbox.text,i)
	end if
	xn=bbox.x
	yn=bbox.y
	

        b = New solidbrush  (Color.Black)


        bb = New pen  (Color.Black)


        g.drawrectangle(bb,bbox.x,bbox.y,bbox.w,bbox.h)
        g.drawString(bbox.text,ff,b,xn,xn)




exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub
    end class


Public Class WinVBApp

    inherits Form
    shared bx as integer
    shared by as integer
    shared b1 as boxs
    shared T as System.Timers.timer
   shared scr1 as new scr

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  boxs

       b1.x=10
       b1.y=10
       b1.parent=me
       b1.w=250
       b1.h=50
	bx=10
	by=10
       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.KeyPress AddressOf Me.OnKeyPress
       
       Me.CenterToScreen
       t= new System.Timers.timer(300)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub

    Private Sub OnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
    b1.text=b1.text+e.keychar
    application.doevents()
    b1.parent.refresh()     
 
    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











