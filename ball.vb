Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 



   public class balls
	    public parent as form
	    public x as integer
	    public y as integer
            public size as integer
      public sub draw( ByVal e As PaintEventArgs,byval bballs as balls)

        Dim g As Graphics = e.Graphics

	Dim b As brush
	Dim bb As brush
	Dim bbb As brush
	dim value as integer
	dim i as integer

	

        b = New SolidBrush  (Color.white)


        bb = New SolidBrush  (Color.Black)


        g.fillellipse(bb,new rectangle(bballs.x-bballs.size\2,bballs.y-bballs.size\2,bballs.size,bballs.size))



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
    shared b1 as balls
    shared T as System.Timers.timer
   shared scr1 as new scr

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  balls

       b1.x=0
       b1.y=0
       b1.parent=me
       b1.size=50
	bx=10
	by=10
       AddHandler Me.Paint AddressOf Me.OnPaint
       
       Me.CenterToScreen
       t= new System.Timers.timer(300)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    if b1.x > scr1.xx-b1.size then bx=-10
    if b1.y > scr1.yy-b1.size then by=-10
    if b1.x < b1.size then bx=10
    if b1.y < b1.size then by=10
    b1.x=b1.x+bx
    b1.y=b1.y+by
    application.doevents()
    b1.parent.refresh()     
    if b1.x > 10000 then
		 t.stop()
		 t.dispose()
     end if

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











