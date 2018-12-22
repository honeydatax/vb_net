Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

   public class bitsm
	    public img as bitmap
	    public parent as form
	    public x as integer
	    public y as integer
	    public h as integer
	    public w as integer
            public steps as integer
      public sub draw( ByVal e As PaintEventArgs,byval gbitsm as bitsm)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen
	dim value as integer
	dim c1 as integer
	dim c2 as integer
	dim i as integer
	dim fg as graphics

	c1=0

        b = New pen (Color.white)
        img=new bitmap(64,64)
	fg=graphics.fromimage(img)

        bb = New pen (Color.Black)
        fg.drawline(bb,32,0,64,64)

        fg.drawline(bb,0,64,32,0)
        fg.drawline(bb,0,63,64,63)
	g.drawimage(img,gbitsm.x,gbitsm.y)


exits:
       g.Dispose
	bb.Dispose
        b.Dispose
        img.Dispose
        fg.Dispose

       end sub
    end class


Public Class WinVBApp

    inherits Form

    shared g1 as bitsm
    shared T as System.Timers.timer
   

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       g1 =new  bitsm

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
    g1.x=g1.x+10
    application.doevents()
    g1.parent.refresh()     
    if g1.x > 600 then
	g1.x=0
	g1.y=g1.y+10
     end if

    if g1.y > 300 then
	g1.x=0
	g1.y=0
     end if

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    g1.draw(e,g1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class