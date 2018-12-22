Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

   public class grids
	    public parent as form
	    public x as integer
	    public y as integer
	    public h as integer
	    public w as integer
            public steps as integer
      public sub draw( ByVal e As PaintEventArgs,byval ggrids as grids)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen
	dim value as integer
	dim i as integer
	if ggrids.steps<4 then ggrids.steps=4
	value=ggrids.steps
	

        b = New pen (Color.white)


        bb = New pen (Color.Black)
	for i=ggrids.x to ggrids.x+ggrids.w step value

        g.drawline(bb,i,ggrids.y,i,ggrids.y+ggrids.h)

	next i

	for i=ggrids.y to ggrids.y+ggrids.h step value

        g.drawline(bb,ggrids.x,i,ggrids.x+ggrids.w,i)

	next i

exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub
    end class


Public Class WinVBApp

    inherits Form

    shared g1 as grids
    shared T as System.Timers.timer
   

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       g1 =new  grids

       g1.x=10
       g1.y=10
       g1.w=600
       g1.h=300
       g1.parent=me
       g1.steps=0
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