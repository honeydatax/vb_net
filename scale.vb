Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

   public class scales
	    public parent as form
	    public x as integer
	    public y as integer
	    public h as integer
	    public w as integer
            public steps as integer
      public sub draw( ByVal e As PaintEventArgs,byval gscales as scales)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen
	dim value as integer
	dim c1 as integer
	dim c2 as integer
	dim i as integer
	if gscales.steps<2 then gscales.steps=2
	value=gscales.steps
	c1=0

        b = New pen (Color.white)


        bb = New pen (Color.Black)
	g.drawline(bb,gscales.x,gscales.y,gscales.x,gscales.y+gscales.h)
	for i=gscales.x to gscales.x+gscales.w step value
        g.drawline(bb,i,gscales.y,i,gscales.y+gscales.h\4)
	if c1=5 then 
		g.drawline(bb,i,gscales.y,i,gscales.y+gscales.h\2)
		c1=0
	end if
	if c2=10 then 
		g.drawline(bb,i,gscales.y,i,gscales.y+gscales.h)
		c2=0
	end if

	c1=c1+1
	c2=c2+1
	next i


exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub
    end class


Public Class WinVBApp

    inherits Form

    shared g1 as scales
    shared T as System.Timers.timer
   

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       g1 =new  scales

       g1.x=10
       g1.y=10
       g1.w=600
       g1.h=50
       g1.parent=me
       g1.steps=2
       AddHandler Me.Paint AddressOf Me.OnPaint
       
       Me.CenterToScreen
       t= new System.Timers.timer(300)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    g1.steps=g1.steps+1
    application.doevents()
    g1.parent.refresh()     
    if g1.steps > 64 then
		 t.stop()
		 t.dispose()
     end if

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    g1.draw(e,g1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class