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
      public sub draw( ByVal e As PaintEventArgs,byval bbox as boxs)

        Dim g As Graphics = e.Graphics

	Dim b As pen
	Dim bb As pen

	dim value as integer
	dim i as integer

	

        b = New pen  (Color.white)


        bb = New pen  (Color.Black)


        g.drawrectangle(bb,bbox.x,bbox.y,bbox.w,bbox.h)
        g.drawline(bb,bbox.x,bbox.y,bbox.w+bbox.x,bbox.h+bbox.y)
        g.drawline(bb,bbox.w+bbox.x,bbox.y,bbox.x,bbox.h+bbox.y)



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
       b1.w=scr.xx-50
       b1.h=scr.yy-50
	bx=10
	by=10
       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.MouseDown AddressOf Me.OnMouseDown
       
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

    Private Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
    if e.button>0 and e.x>20 and e.y >20 then
	b1.w=e.x-10
	b1.h=e.y-10
    application.doevents()
    b1.parent.refresh()     
    end if   
    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











