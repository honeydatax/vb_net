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
	    public name(8) as string
	    public score(8) as long
	    public text as string
      public sub draw( ByVal e As PaintEventArgs,byval bbox as boxs)

        Dim g As Graphics = e.Graphics

	Dim b As brush
	Dim bb As pen
	Dim b1 As brush
	Dim bb1 As pen
	dim x as integer
	dim y as integer

	dim value as integer
	dim l as integer
	dim i as integer
	dim xn as single
	dim yn as single
	dim ff as font 
	dim ss as StringFormat
	ss=new stringformat()
'	ss.formatflags=StringformatFlags.directionhorizontal
	ff = new font("Arial",bbox.h-10)
	if len(bbox.text)*(bbox.h-10) > bbox.w then 
		i=bbox.w\bbox.h
		'bbox.text=right(bbox.text,i)
	end if
	xn=bbox.x
	yn=bbox.y
	

        b = New solidbrush  (Color.White)


        bb = New pen  (Color.White)




        b1 = New solidbrush  (Color.Black)


        bb1 = New pen  (Color.Black)
        g.drawrectangle(bb1,bbox.x+1,bbox.y+1,bbox.w,bbox.h)
        g.drawString(bbox.text,ff,b1,xn+5.0f,xn+5.0f)

	y=bbox.y+bbox.h
	for l = 0 to 7
	x=bbox.x
	xn=x
	yn=y
        g.drawrectangle(bb1,x,y,bbox.w,bbox.h)
        g.drawString(bbox.name(l),ff,b1,xn+5.0f,yn+5.0f)
	x=bbox.x+bbox.w
	xn=x
        g.drawrectangle(bb1,x,y,bbox.w,bbox.h)
        g.drawString(str(bbox.score(l)),ff,b1,xn+5.0f,yn+5.0f)
	yn=y
	y=y+bbox.h
	next l



exits:
       g.Dispose
	bb.Dispose
        b.Dispose
	bb1.Dispose
        b1.Dispose
	ff.Dispose

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
       b1.w=300
       b1.h=30
	b1.name(0)="a=a+1"
	b1.name(1)="b=b+2"
	b1.name(2)="c=c+3"
	b1.name(3)="d=d+4"
	b1.name(4)="e=e*2"
	b1.name(5)="f=f+f"
	b1.name(6)="f=f+5"
	b1.name(7)="f=f+8"
	b1.score(0)=0
	b1.score(1)=0
	b1.score(2)=0
	b1.score(3)=0
	b1.score(4)=1
	b1.score(5)=1
	b1.score(6)=0
	b1.score(7)=0

	bx=10
	by=10
	b1.text="debug:"
       AddHandler Me.Paint AddressOf Me.OnPaint
       AddHandler Me.KeyPress AddressOf Me.OnKeyPress
       
       Me.CenterToScreen
       t= new System.Timers.timer(300)
       AddHandler t.elapsed AddressOf ttimer
       t.autoreset=true
       t.enabled=true	
    End Sub
        
    Private Sub ttimer(ByVal sender As Object, ByVal e As ElapsedEventArgs)  
	application.doevents()
	b1.parent.refresh()     

	b1.score(0)=b1.score(0)+1
	b1.score(1)=b1.score(1)+2
	b1.score(2)=b1.score(2)+3
	b1.score(3)=b1.score(3)+4
	b1.score(6)=b1.score(6)+5
	b1.score(7)=b1.score(7)+8
	b1.score(4)=b1.score(4)*2
	b1.score(5)=b1.score(5)+b1.score(5)









    end sub 


    Private Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
    b1.draw(e,b1)
   
    End Sub

    Private Sub OnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

    End Sub




    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class











