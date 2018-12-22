Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

   public class tbar
	    public parent as form
	    public x as integer
	    public y as integer
	    public h as integer
	    public w as integer
            public perc as double
      public sub draw( ByVal e As PaintEventArgs,byval tbars as tbar)

        Dim g As Graphics = e.Graphics

	Dim b As Brush
	Dim bb As Brush
	dim value as double
	dim i as integer
	if tbars.perc>100 then tbars.perc=100
	value=tbars.w/100*tbars.perc
	i=value

        b = New SolidBrush (Color.white)

        g.FillRectangle(b,tbars.x,tbars.y,tbars.w,tbars.h)

        bb = New SolidBrush (Color.Black)

        g.FillRectangle(bb,tbars.x,tbars.y,(i),tbars.h)




exits:
       g.Dispose
	bb.Dispose
        b.Dispose
        tbars.parent.text=str(tbars.perc) & "%"

       end sub
    end class


Public Class WinVBApp

    inherits Form

    shared t1 as tbar
    shared T as System.Timers.timer
   

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       t1 =new  tbar

       t1.x=10
       t1.y=10
       t1.w=110
       t1.h=40
       t1.parent=me
       t1.perc=0
       AddHandler Me.Paint AddressOf Me.OnPaint
       
       Me.CenterToScreen
       t= new System.Timers.timer(100)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    t1.perc=t1.perc+1
    application.doevents()
    t1.parent.refresh()     
    if t1.perc > 100 then
		 t.stop()
		 t.dispose()
     end if

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    t1.draw(e,t1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class