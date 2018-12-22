Imports System.Windows.Forms
Imports System.Drawing
Imports System.Timers
Imports System.Drawing.Drawing2D

public class scr
	public const xx =640
	public const yy =350
end class 



   public class rects
	    public parent as form
	    public x as integer
	    public y as integer
            public w as integer
	    public h as integer
      public sub draw( ByVal e As PaintEventArgs,byref brects as rects)

        Dim g As Graphics = e.Graphics

	Dim b As brush
	Dim bb As brush
	Dim bbb As brush
	dim value as integer
	dim i as integer

	

        b = New SolidBrush  (Color.white)


        bb = New SolidBrush  (Color.Black)


        g.fillrectangle(bb,brects.x,brects.y,brects.w,brects.h)



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
    shared b1 as rects
    shared T as System.Timers.timer
   shared scr1 as new scr

    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(scr1.xx, scr1.yy)
       b1 =new  rects

       b1.x=0
       b1.y=0
       b1.parent=me

	bx=10
	by=10
       AddHandler Me.Paint AddressOf Me.OnPaint
       
       Me.CenterToScreen
       t= new System.Timers.timer(1000)
       AddHandler t.elapsed AddressOf ttimer
       randomize()
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
    b1.x = int(320*rnd())
    b1.y = int(240*rnd())
    b1.w =320+int(320*rnd())-b1.x  
    b1.h =240+int(240*rnd())-b1.y  
    application.doevents()
    b1.parent.refresh()     

    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











