Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

   public class halls
	    public parent as form
	    public x as integer
	    public y as integer
	    public h as integer
	    public w as integer
            public steps as integer
      public sub draw( ByVal e As PaintEventArgs,byval ghalls as halls)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen
	dim value as integer
	dim c1 as integer
	dim c2 as integer
	dim i as integer
	dim ii as integer
	if ghalls.steps<2 then ghalls.steps=2
	value=ghalls.steps
	c1=0

        b = New pen (Color.white)


        bb = New pen (Color.Black)
	for i=ghalls.y to ghalls.y+ghalls.h step value
        g.drawline(bb,ghalls.x,i,ghalls.x+ghalls.w,i)


	next i

	for ii=ghalls.y to ghalls.y+ghalls.h step value *2
	for i=ghalls.x to ghalls.x+ghalls.w step value*2
        g.drawline(bb,i,ii,i,ii+value)
	next i
	next ii

	for ii=ghalls.y to ghalls.y+ghalls.h step value * 2
	for i=ghalls.x to ghalls.x+ghalls.w step value*2
        g.drawline(bb,i+value,ii+value,i+value,ii+value*2)
	next i
	next ii


exits:
       g.Dispose
	bb.Dispose
        b.Dispose


       end sub
    end class


Public Class WinVBApp

    inherits Form

    shared g1 as halls
    shared T as System.Timers.timer
   

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       g1 =new  halls

       g1.x=10
       g1.y=10
       g1.w=600
       g1.h=300
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