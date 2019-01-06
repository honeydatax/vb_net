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
	    public min as integer
            public steps as integer
      public sub draw( ByVal e As PaintEventArgs,byval gscales as scales)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen
	dim value as integer
	dim c1 as integer
	dim c2 as integer
	dim i as integer
	dim ii as integer

	
	value=gscales.steps

	ii=256

        b = New pen (Color.white)


        bb = New pen (Color.Black)

	for i=0 to 6
	dim bb1 as solidbrush 
	bb1=new solidbrush(Color.fromargb(i*12,i*12,i*12))
	dim points0 as new point(gscales.x+(((gscales.w\2)-(gscales.steps\2))+(gscales.steps\8)*i),gscales.y+(gscales.steps\2))
	dim points1 as new point(gscales.x+(((gscales.w\2)-(gscales.steps\2))+(gscales.steps\8)*(1+i)),gscales.y+(gscales.steps\2))
        dim points2 as new point(gscales.x+((gscales.w\8)*(1+i)),gscales.y+gscales.h)
	dim points3 as new point(gscales.x+((gscales.w\8)*(i)),gscales.y+gscales.h)
	dim points as point()={points0,points1,points2,points3}
	g.fillpolygon(bb1,points)
	bb1.Dispose
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

       g1.x=20
       g1.y=20
       g1.w=600
       g1.min=g1.w\24
       g1.h=280
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
       t.enabled=false	
           g1.steps=g1.steps+1
    g1.parent.refresh()     
    if g1.steps > 510 then
       g1.steps=2
     end if

       t.enabled=true
    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    g1.draw(e,g1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class