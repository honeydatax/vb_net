Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.text
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary


Public Class WinVBApp
    Inherits Form
	dim sss as string
	dim s as string
	dim ss as string
	dim n as integer
	dim c as string
	dim ii as integer
	dim i as integer
	dim keycount as  integer
	dim varscount as integer
	dim keywords(600) as string
	dim par(3000) as integer
	dim labelss(3000) as string
	dim labeladdress(3000) as integer
	dim labelstate(3000) as integer
	dim labelindex as integer
	dim vars(3000) as string
	dim errorss as integer
	dim errorssi as integer
	dim parcount as integer
	dim par1 as string
	dim vvv as string
	dim t1 as string
	dim tt1 as string
	dim t as string
	dim tt as string
	dim iii as integer
	dim aa as integer
	dim aaa as integer
	dim bb as integer
	dim bbb as integer
	dim bbb1 as integer
	dim bbb2 as integer
	dim bbb3 as integer
	dim bbb4 as integer
	dim bbb5 as integer
	dim bbb6 as integer
	dim tc as string
	dim tc1 as string
	dim tc2 as string
	dim tc3 as string
	dim tc4 as string
	dim tc5 as string
	dim tc6 as string
	dim forvar(1300) as integer
	dim forfrom(1300) as integer
	dim forinto(1300) as integer
	dim forstep(1300) as integer
	dim foraddress(1300) as integer
	dim forcount as integer
	dim varstype(3000) as integer
	dim line11(3000) as integer
	dim debug as string
	dim rtxt() as string
        Dim button11 As New Button
        Dim button10 As New Button
        Dim button9 As New Button
        Dim button8 As New Button
        Dim button7 As New Button
        Dim button6 As New Button
        Dim button5 As New Button
        Dim button4 As New Button
        Dim button3 As New Button
        Dim button2 As New Button
        Dim button As New Button
        Dim text0 As New textbox
        Dim text1 As New textbox
        Dim text2 As New textbox
	dim ts as integer
        Dim fi As long
        Dim fn As double


    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    
	ii=0
        text0.Location = New Point(3,38)
        text0.size = New size(550,290)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me

        button.Location = New Point(560,3)
        button.Text = "compile:"
        button.Parent = Me


        button2.Location = New Point(560,33)
        button2.Text = "run out.com:"
        button2.Parent = Me

        button3.Location = New Point(560,63)
        button3.Text = "asm source:"
        button3.Parent = Me

        button4.Location = New Point(560,93)
        button4.Text = "load code:"
        button4.Parent = Me


        button5.Location = New Point(560,123)
        button5.Text = "edit code:"
        button5.Parent = Me

        button6.Location = New Point(560,153)
        button6.Text = "load asm:"
        button6.Parent = Me

        button7.Location = New Point(560,183)
        button7.Text = "help:"
        button7.Parent = Me

        button8.Location = New Point(560,210)
        button8.Text = "debug:"
        button8.Parent = Me

        button9.Location = New Point(560,240)
        button9.Text = "hex:"
        button9.Parent = Me

        button10.Location = New Point(560,270)
        button10.Text = "bin:"
        button10.Parent = Me

        button11.Location = New Point(560,300)
        button11.Text = "modify:"
        button11.Parent = Me



        text2.Location = New Point(5,3)
        text2.size = New size(550,32)
        text2.scrollbars = 3

'sample code
	text2.text="index/hello.idx"

	startcode()

        AddHandler button11.Click, AddressOf Me.OnClick11
        AddHandler button10.Click, AddressOf Me.OnClick10
        AddHandler button9.Click, AddressOf Me.OnClick9
        AddHandler button8.Click, AddressOf Me.OnClick8
        AddHandler button7.Click, AddressOf Me.OnClick7
        AddHandler button6.Click, AddressOf Me.OnClick6
        AddHandler button5.Click, AddressOf Me.OnClick5
        AddHandler button4.Click, AddressOf Me.OnClick4
        AddHandler button3.Click, AddressOf Me.OnClick3
        AddHandler button2.Click, AddressOf Me.OnClick2
        AddHandler button.Click, AddressOf Me.OnClick



        text2.Parent = Me


     
        Me.CenterToScreen
        
    End Sub


    Private Sub OnClick2(ByVal sender As Object, ByVal e As EventArgs)
		try           	
			c= "-c 'dosbox out.com '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"if sucess the exe name will be out.com and asm name will be out.asm"
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try


    End Sub

    Private Sub OnClick3(ByVal sender As Object, ByVal e As EventArgs)
		try           	
			c= "-c 'mousepad out.asm '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"if sucess the exe name will be out.com and asm name will be out.asm"
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try




    End Sub

    Private Sub OnClick4(ByVal sender As Object, ByVal e As EventArgs)

		labelindex=0
		varscount=0
		forcount=0
		errorss=0


		t=t1
		tt=tt1


	try

	rtxt=file.readAlllines(text2.text)
	ss=""
	s=""
	for each s in rtxt
		ss=ss+s+chr(10)
	next
		text0.text=ss	
                 catch ee as Exception
	end try

    End Sub

    Private Sub OnClick5(ByVal sender As Object, ByVal e As EventArgs)
		try           	
			c= "-c 'mousepad "+text2.text+" '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"if sucess the exe name will be out.com and asm name will be out.asm"
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try




    End Sub



    Private Sub OnClick6(ByVal sender As Object, ByVal e As EventArgs)

		labelindex=0
		varscount=0
		forcount=0
		errorss=0


		t=t1
		tt=tt1


	try

	rtxt=file.readAlllines("out.asm")
	ss=""
	s=""
	for each s in rtxt
		ss=ss+s+chr(10)
	next
		text0.text=ss	
                 catch ee as Exception
	end try

    End Sub


    Private Sub OnClick7(ByVal sender As Object, ByVal e As EventArgs)

		labelindex=0
		varscount=0
		forcount=0
		errorss=0


		t=t1
		tt=tt1


	try

	rtxt=file.readAlllines("index/index.txt")
	ss=""
	s=""
	for each s in rtxt
		ss=ss+s+chr(10)
	next
		text0.text=ss	
                 catch ee as Exception
	end try

    End Sub


    Private Sub OnClick8(ByVal sender As Object, ByVal e As EventArgs)
		           	
		try           	
			c= "-c 'mousepad input.txt '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			p.Close()
			application.doevents
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try




		try           	

		vvv="debug.com > output.txt < input.txt " +chr(13)+chr(10)+"echo close me"
	If Not System.IO.File.Exists("out.bat") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("out.bat")
	    ffile.Close()
	End If

	file.WriteAllText("out.bat",vvv)



			c= "-c 'timeout 59s dosbox out.bat '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"open output "
			
                 catch ee as Exception 
			   text0.text =" ERROR same data is not correct"
			   end try



		try           	
			c= "-c 'mousepad OUTPUT.TXT '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			p.Close()
			application.doevents
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try



    End Sub


    Private Sub OnClick9(ByVal sender As Object, ByVal e As EventArgs)

dim psi as ProcessStartInfo 
dim p as Process


		try           	

			c= "-c 'rm out.out '"
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			p= Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"open output "


			c= "-c 'cp out.com out.out '"
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			p= Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"open output "



		sss=inputbox("file name to list hex","file","out.out")
		ss=inputbox("start hex address to list star at 0","hex value","0")
		s=inputbox("ending hex address to list ","hex value",100)


		vvv="debug.com > output.txt < input.txt " +chr(13)+chr(10)+"echo close me"
	If Not System.IO.File.Exists("out.bat") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("out.bat")
	    ffile.Close()
	End If

	file.WriteAllText("out.bat",vvv)


		vvv="n "+sss+chr(13)+chr(10)+"l 100"+chr(13)+chr(10)+"rcx"+chr(13)+chr(10)+"10"+chr(13)+chr(10)+"a 80"+chr(13)+chr(10)+"mov ax,ds"+chr(13)+chr(10)+"add ax,cx"+chr(13)+chr(10)+"mov ds,ax"+chr(13)+chr(10)+""+chr(13)+chr(10)+"rip"+chr(13)+chr(10)+"80"+chr(13)+chr(10)+"p 3"+chr(13)+chr(10)+chr(13)+chr(10)+"d "+ss+" "+s +chr(13)+chr(10)+""+chr(13)+chr(10)+"q"+chr(13)+chr(10)+"q"+chr(13)+chr(10)
	If Not System.IO.File.Exists("input.txt") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("input.txt")
	    ffile.Close()
	End If

	file.WriteAllText("input.txt",vvv)





			c= "-c 'timeout 100s dosbox out.bat '"
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			p= Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"open output "
			
                 catch ee as Exception 
			   text0.text =" ERROR same data is not correct"
			   end try



		try           	
			c= "-c 'mousepad OUTPUT.TXT '"
			psi= new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			p= Process.Start(psi)
			p.WaitForExit()
			p.Close()
			application.doevents
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try



    End Sub


    Private Sub OnClick10(ByVal sender As Object, ByVal e As EventArgs)
           dim brtxt() as byte
	   dim ba as integer



		try           	
		sss=inputbox("file name to list bin","file","file.dat")


		text0.text="machine "
	brtxt=file.readallbytes(sss)
	for ba=0 to brtxt.length
		text0.text=text0.text+" , "+str(brtxt(ba))
	next	
                 catch ee as Exception
	end try


    End Sub

    Private Sub OnClick11(ByVal sender As Object, ByVal e As EventArgs)
		try           	
			c= "-c 'nasm -o out.com out.asm '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"if sucess the exe name will be out.com and asm name will be out.asm"
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try




    End Sub





    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)


		clearbody()
		if ts=0 then
		try           	
			dim s as string()=c.split(chr(10))
			dim ss as string
			for each ss in s
				ss=ss.replace(chr(10),"")				
				ss=ss.replace("'",chr(34))				
				dim separete as string()=ss.split(",")
				errorss=1
				if separete.length>0 then 
					par1=lcase(trim(separete(0)))
'key print,var
					if par1=keywords(0) then
						errorssi=0
						if par(0)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)<10 then	 


									addtail("	mov dx,L"+(trim(line11(bbb)+9000)))
									addtail("	call print")
									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 
'key set ,constant,text
					if par1=keywords(1) then 
						errorssi=1

						if par(1)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,0,iii)							
								addbody("L"+trim(str(iii+9000))+" db '"+separete(2)+"',13,10,'$'")
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if
'key no line
					if par1=keywords(2) then 
						errorssi=2
						if par(2)=separete.length then
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if
'key echo,text
					if par1=keywords(3) then
						errorssi=3
						if par(3)=separete.length then

									addtail("	mov dx,L"+(trim(iii+9000)))
									addtail("	call print")
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',13,10,'$'")

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 
'key wait,var to put key code
					if par1=keywords(4) then
						errorssi=4
						if par(4)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)<10 then	 


									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	call waits")
							errorssi=-1
							errorss=0

								 
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key integer ,var,number value
					if par1=keywords(5) then 
						errorssi=5

						if par(5)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,6,iii)
								n=val(trim(separete(2)))
								addbody("L"+trim(str(iii+9000))+" dw "+str(n))
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if

'key let,var,value number
					if par1=keywords(6) then
						errorssi=6
						if par(6)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)=6 then	 

									n=val(trim(separete(2)))
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov ax,"+str(n))
									addtail("	mov [bx],ax")
									errorssi=-1
									errorss=0

								else

									if varstype(bbb)=12 then	 
										fn=val(trim(separete(2)))
										fn=fn*100
										fi=fn
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov eax,"+str(fi))
										addtail("	mov [bx],eax")
										errorssi=-1
										errorss=0

									else

										if varstype(bbb)<5 then
											addvar(tc,0,iii)
											addbody("L"+trim(str(iii+9000))+" db '"+separete(2)+"',13,10,'$'")
											addtail("	mov di,L"+(trim(line11(bbb)+9000)))
											addtail("	mov al,36")
											addtail("	mov [di],al")
											addtail("	mov si,L"+(trim(str(iii+9000))))
											addtail("	call strcat")
											errorssi=-1
											errorss=0
										else


											iii=1+iii
										
											goto errorhandler
										end if
									end if
								end if
							end if
						end if 
						goto allkey
					end if 

'key add,var3,var1,var2
					if par1=keywords(7) then
						errorssi=7
						if par(7)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	add ax,cx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
							errorssi=-1
							errorss=0

								 
								else

									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov ecx,[bx]")
										addtail("	clc")
										addtail("	add eax,ecx")
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [bx],eax")
										errorssi=-1
										errorss=0

								 
									else
										iii=1+iii
										goto errorhandler
									end if								
								end if
							end if
						end if 
						goto allkey
					end if 

'key sub,var3,var1,var2
					if par1=keywords(8) then
						errorssi=8
						if par(8)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	sub ax,cx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
								 	errorssi=-1
								errorss=0

								else


									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov ecx,[bx]")
										addtail("	clc")
										addtail("	sub eax,ecx")
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [bx],eax")
										errorssi=-1
										errorss=0

									else								 

									iii=1+iii
									goto errorhandler
									end if								
								end if
							end if
						end if 
						goto allkey
					end if 

'key exit
					if par1=keywords(9) then
						errorssi=9
						if par(9)=separete.length then
									addtail("	jmp exit")
						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 

'key label,label id
					if par1=keywords(10) then 
						errorssi=10

						if par(10)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,1,iii)
								addtail("LL"+trim(str(iii+8000))+":")
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtail("LL"+trim(str(labeladdress(bbb)+8000))+":")
									labelstate(bbb)=1
							errorssi=-1
							errorss=0

								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 
						end if
						goto allkey
					end if

'key goto,label id
					if par1=keywords(11) then 
						errorssi=11

						if par(11)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,0,iii)
								addtail("	jmp LL"+trim(str(iii+8000)))
								errorssi=-1
								errorss=0
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtail("	jmp LL"+trim(str(labeladdress(bbb)+8000)))
									errorssi=-1
									errorss=0
							errorssi=-1
							errorss=0


								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 
						end if
						goto allkey
					end if

'key return
					if par1=keywords(12) then
						errorssi=12
						if par(12)=separete.length then
									addtail("	ret")
						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 

'key like,var1,var2,goto label id
					if par1=keywords(13) then
						errorssi=13
						if par(13)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findlabel(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 



									if bbb2=-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
										addlabel(tc2,0,iii)

										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov ax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov cx,[bx]")
										addtail("	cmp ax,cx")
										addtail("	jnz LLZ"+trim(str(iii+7000)))
										addtail("	jmp LL"+trim(str(iii+8000)))
										addtail("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtail("	mov ax,[bx]")
											addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtail("	mov cx,[bx]")
											addtail("	cmp ax,cx")
											addtail("	jnz LLZ"+trim(str(iii+7000)))
											addtail("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtail("LLZ"+trim(str(iii+7000))+":")
											errorssi=-1
											errorss=0


										else

											iii=1+iii
											goto errorhandler
										end if
										

									end if
								else

									iii=1+iii
									goto errorhandler
								end if
							else

								iii=1+iii
								goto errorhandler

							end if
													end if 
						goto allkey
					end if 

'key diferent,var1,var2,goto label id
					if par1=keywords(14) then
						errorssi=14
						if par(14)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findlabel(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 



									if bbb2=-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
										addlabel(tc2,0,iii)

										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov ax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov cx,[bx]")
										addtail("	cmp ax,cx")
										addtail("	jz LLZ"+trim(str(iii+7000)))
										addtail("	jmp LL"+trim(str(iii+8000)))
										addtail("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtail("	mov ax,[bx]")
											addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtail("	mov cx,[bx]")
											addtail("	cmp ax,cx")
											addtail("	jz LLZ"+trim(str(iii+7000)))
											addtail("	jmp LL"+trim(str(labeladdress(bbb2)+8000))) 
											addtail("LLZ"+trim(str(iii+7000))+":")
											errorssi=-1
											errorss=0


										else

											iii=1+iii
											goto errorhandler
										end if
										

									end if
								else

									iii=1+iii
									goto errorhandler
								end if
							else

								iii=1+iii
								goto errorhandler

							end if
													end if 
						goto allkey
					end if 

'key big,var1,var2,goto label id
					if par1=keywords(15) then
						errorssi=15
						if par(15)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findlabel(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 



									if bbb2=-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
										addlabel(tc2,0,iii)

										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov ax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov cx,[bx]")
										addtail("	cmp ax,cx")
										addtail("	jle LLZ"+trim(str(iii+7000)))
										addtail("	jmp LL"+trim(str(iii+8000)))
										addtail("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtail("	mov ax,[bx]")
											addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtail("	mov cx,[bx]")
											addtail("	cmp ax,cx")
											addtail("	jle LLZ"+trim(str(iii+7000)))
											addtail("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtail("LLZ"+trim(str(iii+7000))+":")
											errorssi=-1
											errorss=0


										else

											iii=1+iii
											goto errorhandler
										end if
										

									end if
								else

									iii=1+iii
									goto errorhandler
								end if
							else

								iii=1+iii
								goto errorhandler

							end if
													end if 
						goto allkey
					end if 

'key less,var1,var2,goto label id
					if par1=keywords(16) then
						errorssi=16
						if par(16)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findlabel(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 



									if bbb2=-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
										addlabel(tc2,0,iii)

										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov ax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov cx,[bx]")
										addtail("	cmp ax,cx")
										addtail("	jge LLZ"+trim(str(iii+7000)))
										addtail("	jmp LL"+trim(str(iii+8000)))
										addtail("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtail("	mov ax,[bx]")
											addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtail("	mov cx,[bx]")
											addtail("	cmp ax,cx")
											addtail("	jge LLZ"+trim(str(iii+7000)))
											addtail("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtail("LLZ"+trim(str(iii+7000))+":")
											errorssi=-1
											errorss=0


										else

											iii=1+iii
											goto errorhandler
										end if
										

									end if
								else

									iii=1+iii
									goto errorhandler
								end if
							else

								iii=1+iii
								goto errorhandler

							end if
													end if 
						goto allkey
					end if 


'key rem,ignored text
					if par1=keywords(17) then
						errorssi=17
						if par(17)=separete.length then

									addtail("; "+separete(1))
									addbody("; "+separete(1))

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 
'key gosub,label id
					if par1=keywords(18) then 
						errorssi=18

						if par(18)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
								addlabel(tc,0,iii)
								addtail("	call LL"+trim(str(iii+8000)))

								errorssi=-1
								errorss=0
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
									addtail("	call LL"+trim(str(labeladdress(bbb)+8000)))
									errorssi=-1
									errorss=0
								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 

						end if
						goto allkey
					end if

'key memfill,vartext,varchar,varsize
					if par1=keywords(19) then
						errorssi=19
						if par(19)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov al,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call memfill")
									errorssi=-1
									errorss=0
								else
									iii=1+iii
									goto errorhandler 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key memcopy,varinto,varfrom,varsize
					if par1=keywords(20) then
						errorssi=20
						if par(20)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)<5 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call memcopy")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key string ,var,number size
					if par1=keywords(21) then 
						errorssi=21

						if par(21)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,0,iii)
								n=val(trim(separete(2)))
								addbody("L"+trim(str(iii+9000))+" times "+str(n+8) +" db '$'")
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if

'key strcat,varinto,varfrom
					if par1=keywords(22) then
						errorssi=22
						if par(22)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)<5 and varstype(bbb1)<5  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	call strcat")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key strcopy,varinto,varfrom
					if par1=keywords(23) then
						errorssi=23
						if par(23)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)<5 and varstype(bbb1)<5  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov al,36")
									addtail("	mov [di],al")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	call strcat")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 




'key memmove,varinto,varfrom,varsize
					if par1=keywords(24) then
						errorssi=24
						if par(24)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)<5 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	dec cx")
									addtail("	add di,cx")
									addtail("	add si,cx")
									addtail("	inc cx")
									addtail("	call memmove")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key input,varinto,varsize
					if par1=keywords(25) then
						errorssi=25
						if par(25)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)<5 and varstype(bbb1)=6  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov dx,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,dx")
									addtail("	mov [bx],cx")
									addtail("	mov ah,0xa")
									addtail("	int 0x21")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	inc bx")
									addtail("	xor cx,cx")
									addtail("	mov cl,[bx]")
									addtail("	push cx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,si")
									addtail("	inc si")
									addtail("	inc si")
									addtail("	call memcopy")
									addtail("	pop cx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov al,36")
									addtail("	add si,cx")
									addtail("	mov [si],al")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key memback,varinto,varbacksize,varsize
					if par1=keywords(26) then
						errorssi=26
						if par(26)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,[bx]")
									addtail("	add si,di")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call memcopy")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key memford,varinto,varbacksize,varsize
					if par1=keywords(27) then
						errorssi=27
						if par(27)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov si,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov di,[bx]")
									addtail("	add di,si")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	dec cx")
									addtail("	add si,cx")
									addtail("	add di,cx")
									addtail("	inc cx")
									addtail("	call memmove")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key strfrom,varinto,varfrom,varindexstart
					if par1=keywords(28) then
						errorssi=28
						if par(28)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>""  then


								if varstype(bbb)<5 and varstype(bbb1)<5 and varstype(bbb2)=6  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	add si,cx")
									addtail("	call strcat")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key for,var,varfrom,varinto,varstep
					if par1=keywords(29) then
						errorssi=29
						if par(29)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							tc3=ucase(trim(separete(4)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							bbb3=findvar(tc3)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" and bbb3<>-1 and tc3<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 and varstype(bbb3)=6 then	 
									addfor(iii+5000,val(trim(line11(bbb)+9000)),val(trim(line11(bbb1)+9000)),val(trim(line11(bbb2)+9000)),val(trim(line11(bbb3)+9000)))
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	mov ax,[si]")
									addtail("	mov [di],ax")
									addtail("	LLLL"+trim(iii+5000)+":")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key next
					if par1=keywords(30) then
						errorssi=30
						if par(30)=separete.length then

							if forcount>0  then


								

									addtail("	mov bx,L"+(trim(str(forstep(forcount-1)))))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,L"+(trim(str(forinto(forcount-1)))))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(str(forvar(forcount-1)))))
									addtail("	mov si,bx")
									addtail("	mov ax,[si]")
									addtail("	add ax,cx")
									addtail("	mov [si],ax")
									addtail("	mov cx,[di]")
									addtail("	cmp ax,cx")
									addtail("	jg LA"+trim(str(iii+4000)))
									addtail("	jmp LLLL"+trim(str(foraddress(forcount-1))))
									addtail("	LA"+trim(str(iii+4000))+":")
									forcount=forcount-1
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler
								end if
				
							else
								iii=1+iii
								goto errorhandler
							end if
						goto allkey
					end if 


'key pointer,varinto,vartopoint
					if par1=keywords(31) then
						errorssi=31
						if par(31)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)

							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)<7  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov [di],bx")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key copy,pointinto,pointfrom,varsize
					if par1=keywords(32) then
						errorssi=32
						if par(32)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call memcopy")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key str,vartext,varnumber
					if par1=keywords(33) then
						errorssi=33
						if par(33)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)<5 and varstype(bbb1)=6  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	call str")
									errorssi=-1
									errorss=0

								else


									if varstype(bbb)<5 and varstype(bbb1)=12  then	 
	
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov di,bx")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov si,bx")
										addtail("	call STR32")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov si,bx")
									addtail("	mov cx,9")
									addtail("	clc")
									addtail("	add si,cx")
									addtail("	mov cx,10")
									addtail("	clc")
									addtail("	add di,cx")
									addtail("	mov cx,2")
									addtail("	call memmove")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov cx,8")
									addtail("	clc")
									addtail("	add bx,cx")
									addtail("	mov al,46")
									addtail("	mov [bx],al")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov cx,11")
									addtail("	clc")
									addtail("	add bx,cx")
									addtail("	mov al,36")
									addtail("	mov [bx],al")

										errorssi=-1
										errorss=0

									else
										iii=1+iii
										goto errorhandler
									end if 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key val,varnumberinto,vartext
					if par1=keywords(34) then
						errorssi=34
						if par(34)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)<5  then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	call val")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 



'key getnumber,varinto
					if par1=keywords(35) then
						errorssi=35
						if par(35)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
			
							if bbb<>-1 and tc<>""   then


								if varstype(bbb)=6  then	 

									addtail("	mov bx,L16")
									addtail("	mov dx,bx")
									addtail("	mov cx,5")
									addtail("	mov bx,dx")
									addtail("	mov [bx],cx")
									addtail("	mov ah,0xa")
									addtail("	int 0x21")
									addtail("	mov bx,L16")
									addtail("	mov di,L"+(trim(line11(bbb)+9000)))
									addtail("	mov si,bx")
									addtail("	inc si")
									addtail("	inc si")
									addtail("	call val")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key printnumber,varnumber
					if par1=keywords(36) then
						errorssi=36
						if par(36)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""   then


								if varstype(bbb)=6  then	 
										addtail("	mov bx,L17")
										addtail("	mov di,bx")
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov si,bx")
										addtail("	call str")
										addtail("	mov dx,L17")
										addtail("	call print")


									errorssi=-1
									errorss=0

								else

									if varstype(bbb)=12  then
										addtail("	mov bx,L22")
										addtail("	mov di,bx")
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov si,bx")
										addtail("	call STR32")
										addtail("	mov bx,L22")
									addtail("	mov di,bx")
									addtail("	mov si,bx")
									addtail("	mov cx,9")
									addtail("	clc")
									addtail("	add si,cx")
									addtail("	mov cx,10")
									addtail("	clc")
									addtail("	add di,cx")
									addtail("	mov cx,2")
									addtail("	call memmove")
										addtail("	mov bx,L22")
									addtail("	mov cx,8")
									addtail("	clc")
									addtail("	add bx,cx")
									addtail("	mov al,46")
									addtail("	mov [bx],al")
										addtail("	mov bx,L22")
									addtail("	mov cx,11")
									addtail("	clc")
									addtail("	add bx,cx")
									addtail("	mov al,36")
									addtail("	mov [bx],al")
										addtail("	mov bx,L22")
										addtail("	mov dx,bx")
									addtail("	call print")





										errorssi=-1
										errorss=0
									else

										iii=1+iii
										goto errorhandler
									end if 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key machine,value1,value2,...
					if par1=keywords(37) then 
						errorssi=37

						if par(37)<=separete.length then
							tt=tt+chr(13)+chr(10)+"LC"+trim(str(iii+3000))+" db 0x90"
							for bbb1=1 to separete.length-1
	
								tt=tt+","+str(val(separete(bbb1)))

							next bbb1

							tt=tt+chr(13)+chr(10)
							errorssi=-1
							errorss=0

						end if
						goto allkey

					end if


'key reset,var
					if par1=keywords(38) then
						errorssi=38
						if par(38)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)<7 then	 
									if varstype(bbb)<5 then	 

										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov al,36")
										addtail("	mov [bx],al")
										errorssi=-1
										errorss=0
									else
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov ax,0")
										addtail("	mov [bx],ax")
										errorssi=-1
										errorss=0
									end if 
								else
									iii=1+iii
									goto errorhandler
								end if
							end if 
						end if 
						goto allkey
					end if 




'key mul,var3,var1,var2
					if par1=keywords(39) then
						errorssi=39
						if par(39)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov bx,[si]")
									addtail("	xor cx,cx")
									addtail("	xor dx,dx")
									addtail("	clc")
									addtail("	imul bx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],ax")
							errorssi=-1
							errorss=0


								else
	
									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then	 
	
										addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[si]")
										addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov ebx,[si]")

										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	clc")
										addtail("	imul ebx")
										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	mov ebx,100")
										addtail("	clc")
										addtail("	idiv ebx")
										addtail("	mov si,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [si],eax")
										errorssi=-1
										errorss=0
									else
						
										iii=1+iii
										goto errorhandler
									end if
								end if
							end if
						end if 
						goto allkey
					end if 


'key div,var3,var1,var2
					if par1=keywords(40) then
						errorssi=40
						if par(40)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov bx,[si]")
									addtail("	xor cx,cx")
									addtail("	xor dx,dx")
									addtail("	clc")
									addtail("	div bx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],ax")
									errorssi=-1
									errorss=0
 
								else

									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov eax,[si]")
										addtail("	cmp eax,10")
										addtail("	jl LE"+(trim(str(iii+9000))))
										addtail("	cmp eax,100")
										addtail("	jl LI"+(trim(str(iii+9000))))
										addtail("	LE"+(trim(str(iii+9000)))+":")
										addtail("	mov edi,eax")
										addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[si]")
										addtail("	mov ebx,100")
										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	clc")
										addtail("	imul ebx")
										addtail("	mov ebx,edi")
										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	clc")
										addtail("	idiv ebx")
										addtail("	mov si,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [si],eax")

										addtail("	jmp LO"+(trim(str(iii+9000))))
										addtail("	LI"+(trim(str(iii+9000)))+":")
										addtail("	mov edi,eax")
										addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[si]")
										addtail("	mov ebx,100")
										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	clc")
										addtail("	imul ebx")
										addtail("	mov ebx,edi")
										addtail("	xor ecx,ecx")
										addtail("	xor edx,edx")
										addtail("	clc")
										addtail("	idiv ebx")
										addtail("	mov si,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [si],eax")
										addtail("	LO"+(trim(str(iii+9000)))+":")

										errorssi=-1
										errorss=0
 									else

									iii=1+iii
									goto errorhandler
									end if
								end if
							end if

						end if 
						goto allkey
					end if 


'key move,varintinto,varintfrom
					if par1=keywords(41) then
						errorssi=41
						if par(41)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))


							bbb=findvar(tc)
							bbb1=findvar(tc1)

							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
									errorssi=-1
									errorss=0

								else
		
									if varstype(bbb)=12 and varstype(bbb1)=12 then	 

										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov eax,[bx]")
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov [bx],eax")
										errorssi=-1
										errorss=0

									else
										if varstype(bbb)<5 and varstype(bbb1)<5  then	 
	
											addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtail("	mov di,bx")
											addtail("	mov al,36")
											addtail("	mov [di],al")
											addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtail("	mov si,bx")
											addtail("	call strcat")
											errorssi=-1
											errorss=0

	

										else
											iii=1+iii
											goto errorhandler
										end if
									end if 
								end if 


							end if
						end if 
						goto allkey
					end if 

'key alocate,varpointer,varsize
					if par1=keywords(42) then
						errorssi=42
						if par(42)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))


							bbb=findvar(tc)
							bbb1=findvar(tc1)

							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,8")
									addtail("	mov si,L18")
									addtail("	mov dx,[si]")
									addtail("	add bx,dx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],bx")
									addtail("	add bx,cx")
									addtail("	mov si,L18")
									addtail("	mov [si],bx")


															errorssi=-1
							errorss=0
 
								else
									iii=1+iii
									goto errorhandler

								end if
							end if

						end if 
						goto allkey
					end if 



'key call,label1,var1ax,var2bx,var3cx,var4dx
					if par1=keywords(43) then
						errorssi=43
						if par(43)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							tc3=ucase(trim(separete(4)))
							tc4=ucase(trim(separete(5)))

							bbb=findlabel(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							bbb3=findvar(tc3)
							bbb4=findvar(tc4)
							if bbb<>-1 and tc<>"" then 
								if bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" and bbb3<>-1 and tc3<>"" and bbb4<>-1 and tc4<>"" then


									if varstype(bbb1)<7 and varstype(bbb2)<7 and varstype(bbb3)<7 and varstype(bbb4)<7 then	 
										addtail("	mov ax,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov cx,L"+(trim(line11(bbb3)+9000)))
										addtail("	mov dx,L"+(trim(line11(bbb4)+9000)))
										addtail("	call LL"+trim(str(labeladdress(bbb)+8000)))
										errorssi=-1
										errorss=0

									 
									else
										iii=1+iii
										goto errorhandler
									end if
								end if
							else

								if bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" and bbb3<>-1 and tc3<>"" and bbb4<>-1 and tc4<>"" then


									if varstype(bbb1)<7 and varstype(bbb2)<7 and varstype(bbb3)<7 and varstype(bbb4)<7 then	 
										addlabel(tc,0,iii)
										addtail("	mov ax,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtail("	mov cx,L"+(trim(line11(bbb3)+9000)))
										addtail("	mov dx,L"+(trim(line11(bbb4)+9000)))
									 	addtail("	call LL"+trim(str(iii+8000)))
										errorssi=-1
										errorss=0

									 
									else
										iii=1+iii
										goto errorhandler
									end if
								end if
							end if
						end if 
						goto allkey
					end if 

'key file.creat,filename
					if par1=keywords(44) then
						errorssi=44
						if par(44)=separete.length then

									addtail("	mov dx,L"+(trim(iii+9000)))
									addtail("	mov ah,0x3c")
									addtail("	mov cx,0")
									addtail("	int 0x21")
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 

'key file.open,filename,filenumber
					if par1=keywords(45) then
						errorssi=45
						if par(45)=separete.length then

							tc=ucase(trim(separete(2)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)=6 then	 

									addtail("	mov dx,L"+(trim(iii+9000)))
									addtail("	mov ah,0x3d")
									addtail("	mov al,2")
									addtail("	int 0x21")
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key file.close,filenumber
					if par1=keywords(46) then
						errorssi=46
						if par(46)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,ax")
									addtail("	mov al,2")
									addtail("	mov ah,0x3e")
									addtail("	int 0x21")
									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key file.read,vartext,filenumber,size
					if par1=keywords(47) then
						errorssi=47
						if par(47)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<10 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov dx,bx")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,ax")
									addtail("	mov ah,0x3f")
									addtail("	int 0x21")
									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key file.write,vartext,filenumber,size
					if par1=keywords(48) then
						errorssi=48
						if par(48)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<10 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov dx,bx")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,ax")
									addtail("	mov ah,0x40")
									addtail("	int 0x21")
									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key string.len,varnumber,vartext
					if par1=keywords(49) then
						errorssi=49
						if par(49)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)<5  then	 

									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	call len")
									addtail("	mov di,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [di],ax")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key timer.sleep,varnumber
					if par1=keywords(50) then
						errorssi=50
						if par(50)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6  then	 
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	xor eax,eax")
									addtail("	mov ax,[si]")
									addtail("	call sleep")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key timer.rnd,varnumber,varmax
					if par1=keywords(51) then
						errorssi=51
						if par(51)=separete.length then

							tc=ucase(trim(separete(1)))
							bbb=findvar(tc)
							if bbb<>-1 and tc<>""   then


								if varstype(bbb)=6  then	 

									addtail("	mov si,L20")
									addtail("	mov cx,[si]")
									addtail("	inc cx")
									addtail("	mov [si],cx")
									addtail("	mov ax,endf")
									addtail("	cmp cx,ax")
									addtail("	jl LJ"+(trim(str(iii+9000))))
									addtail("	sub cx,ax")
									addtail("	mov ax,257")
									addtail("	add cx,ax")
									addtail("	mov [si],cx")
									addtail("LJ"+(trim(str(iii+9000)))+":")
									addtail("	mov si,cx")
									addtail("	xor ax,ax")
									addtail("	mov al,[si]")
									addtail("	mov di,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [di],ax")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key stack.push,label id
					if par1=keywords(52) then 
						errorssi=52

						if par(52)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
								addlabel(tc,0,iii)
								addtail("	mov ax,LL"+trim(str(iii+8000)))
								addtail("	push ax")

								errorssi=-1
								errorss=0
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
									addtail("	mov ax, LL"+trim(str(labeladdress(bbb)+8000)))
									addtail("	push ax")
									errorssi=-1
									errorss=0
								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 

						end if
						goto allkey
					end if

'key mem.peek,varinto,pointfrom
					if par1=keywords(53) then
						errorssi=53
						if par(53)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	xor ax,ax")
									addtail("	mov si,[bx]")
									addtail("	mov al,[si]")
									addtail("	mov [di],ax")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key mem.poke,pointinto,varinteger
					if par1=keywords(54) then
						errorssi=54
						if par(54)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov al,[bx]")
									addtail("	mov [di],al")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 



'key bits.and,var3,var1,var2
					if par1=keywords(55) then
						errorssi=55
						if par(55)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	and ax,cx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
							errorssi=-1
							errorss=0

								 
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key bits.not,var2,var1
					if par1=keywords(56) then
						errorssi=56
						if par(56)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	not ax")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
							errorssi=-1
							errorss=0

								 
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key mem.reserve,varpointer,varsize
					if par1=keywords(57) then
						errorssi=57
						if par(57)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))


							bbb=findvar(tc)
							bbb1=findvar(tc1)

							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	mov bx,8")
									addtail("	mov si,L21")
									addtail("	mov dx,[si]")
									addtail("	add bx,dx")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],bx")
									addtail("	add bx,cx")
									addtail("	mov si,L21")
									addtail("	mov [si],bx")


															errorssi=-1
							errorss=0
 
								else
									iii=1+iii
									goto errorhandler

								end if
							end if

						end if 
						goto allkey
					end if 


'key far.into,pointinto,pointfrom,varsize
					if par1=keywords(58) then
						errorssi=58
						if par(58)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call farinto")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key far.from,pointinto,pointfrom,varsize
					if par1=keywords(59) then
						errorssi=59
						if par(59)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	call farfrom")
									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 

'key text ,var,number size
					if par1=keywords(60) then 
						errorssi=60

						if par(60)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,0,iii)
								n=val(trim(separete(2)))
								addbody("L"+trim(str(iii+9000))+" times "+str(n) +" db '$'")
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if


'key string.comp,varinto,string1,string2
					if par1=keywords(61) then
						errorssi=61
						if par(61)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>""then


								if varstype(bbb)=6 and varstype(bbb1)<5 and varstype(bbb1)<5 then	 

									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov di,L"+(trim(line11(bbb2)+9000)))
									addtail("	call stringcomp")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],ax")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key string.lower,var
					if par1=keywords(62) then
						errorssi=62
						if par(62)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" and bbb1<>-1 then


								if varstype(bbb)<5 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	call LOWERSTRING")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key string.high,var
					if par1=keywords(63) then
						errorssi=63
						if par(63)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" and bbb1<>-1 then


								if varstype(bbb)<5 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	call HIGHSTRING")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key :,label id
					if par1=keywords(64) then 
						errorssi=64

						if par(64)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,1,iii)
								addtail("LL"+trim(str(iii+8000))+":")
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtail("LL"+trim(str(labeladdress(bbb)+8000))+":")
									labelstate(bbb)=1
							errorssi=-1
							errorss=0

								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 
						end if
						goto allkey
					end if


'key string.findchr,intinto,string1,intchr
					if par1=keywords(65) then
						errorssi=65
						if par(65)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))


							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)<5 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov al,[si]")
									addtail("	call FINDCHAR")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],ax")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 



'key ;,ignored text
					if par1=keywords(66) then
						errorssi=66
						if par(66)=separete.length then

									addtail("; "+separete(1))
									addbody("; "+separete(1))

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 



'key string.findstr,intinto,string1,string2
					if par1=keywords(67) then
						errorssi=67
						if par(67)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))


							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)<5 and varstype(bbb2)<5 then	 

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov dx,L"+(trim(line11(bbb2)+9000)))
									addtail("	call findstr")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [si],ax")

									errorssi=-1
									errorss=0

								else
									iii=1+iii
									goto errorhandler

								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key inkey,var to put key code
					if par1=keywords(68) then
						errorssi=68
						if par(68)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)<10 then	 


									addtail("	call inkey")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")

							errorssi=-1
							errorss=0

								 
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key const ,value
					if par1=keywords(69) then 
						errorssi=69

						if par(69)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" then 
								addvar(tc,6,iii)
								n=val(trim(separete(1)))
								addbody("L"+trim(str(iii+9000))+" dw "+str(n))
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if




'key locate,x,y,page
					if par1=keywords(70) then
						errorssi=70
						if par(70)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 then


									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov dl,[si]")
									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov dh,[si]")
									addtail("	mov ah,2")
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov bh,[si]")
									addtail("	int 0x10")

									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key screen,n
					if par1=keywords(71) then
						errorssi=71
						if par(71)=separete.length then

							tc=ucase(trim(separete(1)))
							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6  then


									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov al,[si]")
									addtail("	mov ah,0")
									addtail("	int 0x10")

									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 


'key textout,text,screen,color
					if par1=keywords(72) then
						errorssi=72
						if par(72)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)<5 and varstype(bbb1)=6 and varstype(bbb2)=6 then


									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov bh,[di]")
									addtail("	mov di,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov bl,[di]")
									addtail("	call textout")

									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 


'key border,color
					if par1=keywords(73) then
						errorssi=73
						if par(73)=separete.length then

							tc=ucase(trim(separete(1)))
							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6  then


									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov bl,[si]")
									addtail("	mov bh,0")
									addtail("	mov ah,0xb")
									addtail("	int 0x10")

									errorssi=-1
									errorss=0

								
								else
									iii=1+iii
									goto errorhandler
								end if
							end if
						end if 
						goto allkey
					end if 

'key float ,var,number value
					if par1=keywords(74) then 
						errorssi=74

						if par(74)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,12,iii)
								fn=val(trim(separete(2)))
								fn=fn*100
								fi=fn
								addbody("L"+trim(str(iii+9000))+" dd "+str(fi))
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if



'key back,color
					if par1=keywords(75) then
						errorssi=75
						if par(75)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov cl,[bx]")
									addtail("	push es")
									addtail("	call setrefresh")
									addtail("	mov al,cl")
									addtail("	xor ecx,ecx")
									addtail("	mov cx,64001")
									addtail("	mov edi,0")
									addtail("	call memfill")
									addtail("	pop es")

									errorssi=-1
									errorss=0
								else
									iii=1+iii
									goto errorhandler 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key hline,x,y,x2,color
					if par1=keywords(76) then
						errorssi=76
						if par(76)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							tc3=ucase(trim(separete(4)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							bbb3=findvar(tc3)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" and bbb3<>-1 and tc3<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 and varstype(bbb3)=6 then	 

									addtail("	push bp")
									addtail("	mov bp,sp")
									addtail("	sub sp,7")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp+0],ax")
									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp-2],ax")
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp-4],ax")
									addtail("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtail("	mov al,[si]")
									addtail("	mov [bp-6],al")
									addtail("	call hline")
									addtail("	mov sp,bp")
									addtail("	pop bp")


									errorssi=-1
									errorss=0
								else
									iii=1+iii
									goto errorhandler 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 


'key doevents refresh screen graphics
					if par1=keywords(77) then
						errorssi=77
						if par(77)=separete.length then




									addtail("	call setvideo")



									errorssi=-1
									errorss=0
							else
									iii=1+iii
									goto errorhandler 

							end if 
						goto allkey
					end if 


'key box,x,y,x2,y2,color
					if par1=keywords(78) then
						errorssi=78
						if par(78)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							tc3=ucase(trim(separete(4)))
							tc4=ucase(trim(separete(5)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							bbb3=findvar(tc3)
							bbb4=findvar(tc4)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" and bbb3<>-1 and tc3<>"" and bbb4<>-1 and tc4<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 and varstype(bbb2)=6 and varstype(bbb3)=6 and varstype(bbb4)=6 then	 

									addtail("	push bp")
									addtail("	mov bp,sp")
									addtail("	sub sp,9")
									addtail("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp+0],ax")
									addtail("	mov si,L"+(trim(line11(bbb)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp-2],ax")
									addtail("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp-4],ax")
									addtail("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov ax,[si]")
									addtail("	mov [bp-6],ax")
									addtail("	mov si,L"+(trim(line11(bbb4)+9000)))
									addtail("	mov al,[si]")
									addtail("	mov [bp-8],al")
									addtail("	call box")
									addtail("	mov sp,bp")
									addtail("	pop bp")


									errorssi=-1
									errorss=0
								else
									iii=1+iii
									goto errorhandler 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 



'key file.chain,filename .com to chain control 
					if par1=keywords(79) then
						errorssi=79
						if par(79)=separete.length then


									addtail("	mov ax,0xffff")
									addtail("	mov sp,ax")
									addtail("	mov ax,cs")
									addtail("	mov ss,ax")
									addtail("	mov ax,0")
									addtail("	push ax")
									addtail("	mov ax,0x100")
									addtail("	push ax")
									addtail("	mov ax,0x80")
									addtail("	push ax")
									addtail("	mov di,0x80")
									addtail("	mov si,chain")
									addtail("	mov cx,0x60")
									addtail("	call memcopy")
									addtail("	mov dx,L"+(trim(iii+9000)))
									addtail("	mov ah,0x3d")
									addtail("	mov al,2")
									addtail("	int 0x21")
									addtail("	jc LJMP"+trim(str(iii+9000)))
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")
									addtail("	mov bx,65298")
									addtail("	mov [bx],ax")
									addtail("	ret")
									addtail("LJMP"+trim(str(iii+9000))+":")
									addtail("	pop ax")
									addtail("	pop ax")
									errorssi=-1
									errorss=0

								
						else
									iii=1+iii
									goto errorhandler
						end if
												
						goto allkey
					end if 

'key file.exec,filename .exe 16 bits to chain control 
					if par1=keywords(80) then
						errorssi=80
						if par(80)=separete.length then


									addtail("	mov ax,0xffff")
									addtail("	mov sp,ax")
									addtail("	mov ax,cs")
									addtail("	mov ss,ax")
									addtail("	mov ax,0")
									addtail("	push ax")
									addtail("	mov dx,L"+(trim(iii+9000)))
									addtail("	mov ah,0x3d")
									addtail("	mov al,2")
									addtail("	int 0x21")
									addtail("	jc LJMP"+trim(str(iii+9000)))
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")
									addbody("LVAR"+trim(str(iii+9000))+" dw 0,0,0")
									addtail("	mov bx,LVAR"+trim(str(iii+9000)))
									addtail("	mov [bx],ax")
									addtail("	mov si,ax")
									addtail("	jmp LJMPS"+trim(str(iii+9000)))
									addtail("LJMP"+trim(str(iii+9000))+":")
									addtail("	xor ax,ax")
									addtail("	int 0x21")
									addtail("LJMPS"+trim(str(iii+9000))+":")
									addtail("	mov ax,cs")
									addtail("	mov bx,0x1000")
									addtail("	add ax,bx")
									addtail("	mov ds,ax")
									addtail("	mov es,ax")
									addtail("	mov dx,0x0")
									addtail("	mov cx,65530")
									addtail("	mov bx,si")
									addtail("	mov ah,0x3f")
									addtail("	int 0x21")
									addtail("	mov bx,si")
									addtail("	mov al,2")
									addtail("	mov ah,0x3e")
									addtail("	int 0x21")
									addtail("	mov ax,ds")
									addtail("	mov dx,16")
									addtail("	add dx,ax")
									addtail("	mov bx,0x0e")
									addtail("	mov ax,[bx]")
									addtail("	add ax,dx")
									addtail("	add ax,bx")
									addtail("	mov ss,ax")
									addtail("	mov bx,0x10")
									addtail("	mov ax,[bx]")
									addtail("	mov sp,ax")
									addtail("	mov bx,0x16")
									addtail("	mov ax,[bx]")
									addtail("	mov bx,16")
									addtail("	add ax,dx")
									addtail("	add ax,bx")
									addtail("	push ax")
									addtail("	mov bx,0x14")
									addtail("	mov ax,[bx]")
									addtail("	push ax")
									addtail("	mov ax,ds")
									addtail("	mov bx,16")
									addtail("	add ax,bx")
									addtail("	mov ds,ax")
									addtail("	mov es,ax")
									addtail("	mov ax,cs")
									addtail("	mov ds,ax")
									addtail("	mov cx,0x80")
									addtail("	mov si,0")
									addtail("	mov di,si")
									addtail("	call memcopy")
									addtail("	mov ax,es")
									addtail("	mov ds,ax")
									addtail("	mov cx,0xf000")
									addtail("	retf")
									addtail("	ret")
									errorssi=-1
									errorss=0

								
						else
									iii=1+iii
									goto errorhandler
						end if
												
						goto allkey
					end if 



'key cicle,cicles,smecicles
					if par1=keywords(81) then
						errorssi=81
						if par(81)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(1)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" then


								if varstype(bbb)=6 and varstype(bbb1)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov dx,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	call cicle")

									errorssi=-1
									errorss=0
								else
									iii=1+iii
									goto errorhandler 
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
						end if 
						goto allkey
					end if 




'line count
					allkey:
					iii=iii+1


				end if
				if errorssi<>-1 then goto errorhandler
				if errorss<>0 then 
					errorssi=2	
					goto errorhandler
				end if					




			next 			

' next out of for
				if forcount<>0 then 
					errorssi=30	
					goto errorhandler
				end if					



'error on label
		bbb=findstate()
		if bbb<>-1 then 
			errorssi=11
			iii=labeladdress(bbb)
			goto errorhandler
		end if
'general error
                 catch ee as Exception 
			   text0.text ="ERROR same data is not correct line :"+str(iii+1)
			goto escapehandler
			   end try
			vvv=tt + t+chr(13)+chr(10)+"endf db '$'"+chr(13)+chr(10)
	
	try
	If Not System.IO.File.Exists("out.asm") = True Then
	    Dim ffile As System.IO.FileStream
	    ffile = System.IO.File.Create("out.asm")
	    ffile.Close()
	End If

	file.WriteAllText("out.asm",vvv)



                 catch ee as Exception
			msgbox("error on save out.asm")
					goto errorhandler
	end try

		try           	
			c= "-c 'timeout 59s nasm -o out.com out.asm '"
			dim psi as ProcessStartInfo = new ProcessStartInfo()
			psi = new ProcessStartInfo()
			psi.FileName = "/bin/bash" 
			psi.CreateNoWindow=true
			psi.UseShellExecute = false
			psi.Arguments =c
			psi.RedirectStandardInput = true
			psi.RedirectStandardOutput = true
			psi.RedirectStandardError = true
			dim p as Process = Process.Start(psi)
			p.WaitForExit()
			text0.text =chr(13)+chr(10)+p.StandardOutput.ReadToEnd()+chr(13)+chr(10) 
			text0.text =text0.text+chr(13)+chr(10)+p.Standarderror.ReadToEnd()+chr(13)+chr(10) 
			p.Close()
			application.doevents
			text0.text =text0.text+CHR(13)+CHR(10)+":FINISH"+CHR(13)+CHR(10)+"if sucess the exe name will be out.com and asm name will be out.asm"
			
                 catch ee as Exception 
			   text0.text ="open out.asm ERROR same data is not correct"
			   end try



		
			goto escapehandler
			errorhandler:
				text0.text ="error on line "+str(iii)+" keyword :"+keywords(errorssi)+debug
     			escapehandler:

		else
				text0.text ="error file "
		end if        
    End Sub

private sub addkey(name as string,ppar as integer)

		keywords(keycount)=name
		par(keycount)=ppar
		keycount=keycount+1

end sub

private function findvar(name as string)as integer
	aaa=-1
	if varscount>0 then 
		for aa=0 to varscount-1
			if vars(aa)=name then
				aaa=aa
				goto findvarexit
			end if
		next
	end if 
	findvarexit:
	return aaa
end function

private function addvar(name as string,types as integer,line1 as integer)as integer
	vars(varscount)=name
	varstype(varscount)=types
	line11(varscount)=line1
	varscount=varscount+1
	return varscount
end function




private sub addcode(name as string)

		t1=t1+name+chr(13)+chr(10)

end sub

private sub addhead(name as string)

		tt1=tt1+name+chr(13)+chr(10)

end sub


private sub addbody(name as string)

		t=t+name+chr(13)+chr(10)

end sub


private sub addtail(name as string)

		tt=tt+name+chr(13)+chr(10)

end sub

private function addlabel(name as string,state as integer,address as integer)as integer
	labelss(labelindex)=name
	labeladdress(labelindex)=address
	labelstate(labelindex)=state
	labelindex=labelindex+1
	return labelindex
end function

private function findlabel(name as string)as integer
	aaa=-1
	if labelindex>0 then 
		for aa=0 to labelindex-1
			if labelss(aa)=name then
				aaa=aa
				goto findlabelexit
			end if
		next
	end if 
	findlabelexit:
	return aaa
end function

private function findstate()as integer
	aaa=-1
	if labelindex>0 then 
		for aa=0 to labelindex-1
			if labelstate(aa)=0 then
				aaa=aa
				goto findstateexit
			end if
		next
	end if 
	findstateexit:
	return aaa
end function

private function addfor(addresss as integer,forvars as integer,forfroms as integer,forintos as integer,forsteps as integer)as integer
	forvar(forcount)=forvars
	foraddress(forcount)=addresss
	forfrom(forcount)=forfroms
	forinto(forcount)=forintos
	forstep(forcount)=forsteps
	forcount=forcount+1
	return forcount
end function



private sub clearbody()

		labelindex=0
		varscount=0
		forcount=0
		errorss=0


		t=t1
		tt=tt1

		ts=1
	try

	rtxt=file.readAlllines(text2.text)
	ss=""
	s=""

	for each s in rtxt
	ss=ss+s+chr(10)
	next


		c=ss
		c=c.replace("	","        ")				


			iii=0
		ts=0
                 catch ee as Exception
	end try

end sub



private sub startcode()




'keyword list 
		keycount=0
		addkey ("print",2)
		addkey ("set",3)
		addkey ("",1)
		addkey ("echo",2)
		addkey ("wait",2)
		addkey ("integer",3)
		addkey ("let",3)
		addkey ("add",4)
		addkey ("sub",4)
		addkey ("exit",1)
		addkey ("label",2)
		addkey ("goto",2)
		addkey ("return",1)
		addkey ("like",4)
		addkey ("diferent",4)
		addkey ("big",4)
		addkey ("less",4)
		addkey ("rem",2)
		addkey ("gosub",2)
		addkey ("memfill",4)
		addkey ("memcopy",4)
		addkey ("string",3)
		addkey ("strcat",3)
		addkey ("strcopy",3)
		addkey ("memmove",4)
		addkey ("input",3)
		addkey ("memback",4)
		addkey ("memford",4)
		addkey ("strfrom",4)
		addkey ("for",5)
		addkey ("next",1)
		addkey ("pointer",3)
		addkey ("copy",4)
		addkey ("str",3)
		addkey ("val",3)
		addkey ("getnumber",2)
		addkey ("printnumber",2)
		addkey ("machine",2)
		addkey ("reset",2)
		addkey ("mul",4)
		addkey ("div",4)
		addkey ("move",3)
		addkey ("alocate",3)
		addkey ("call",6)
		addkey ("file.creat",2)
		addkey ("file.open",3)
		addkey ("file.close",2)
		addkey ("file.read",4)
		addkey ("file.write",4)
		addkey ("string.len",3)
		addkey ("timer.sleep",2)
		addkey ("timer.rnd",2)
		addkey ("stack.push",2)
		addkey ("mem.peek",3)
		addkey ("mem.poke",3)
		addkey ("bits.and",4)
		addkey ("bits.not",3)
		addkey ("mem.reserve",3)
		addkey ("far.into",4)
		addkey ("far.from",4)
		addkey ("text",3)
		addkey ("string.comp",4)
		addkey ("string.lower",2)
		addkey ("string.high",2)
		addkey (":",2)
		addkey ("string.findchr",4)
		addkey (";",2)
		addkey ("string.findstr",4)
		addkey ("inkey",2)
		addkey ("const",2)
		addkey ("locate",4)
		addkey ("screen",2)
		addkey ("textout",4)
		addkey ("border",2)
		addkey ("float",3)
		addkey ("back",2)
		addkey ("hline",5)
		addkey ("doevents",1)
		addkey ("box",6)
		addkey ("file.chain",2)
		addkey ("file.exec",2)
		addkey ("timer.cicle",3)


'code head
			t1=""
			addcode ("")
			addcode (";end of body")
			addcode ("exit:")
			addcode ("	xor ax,ax")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("L0print:")
			addcode ("	mov ah,9")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("print:")
			addcode ("	mov ah,9")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("inkey:")
			addcode ("	mov ah,0x1")
			addcode ("	int 0x16")
			addcode ("	jnz waits")
			addcode ("nwaits:")
			addcode ("	xor ax,ax")
			addcode ("	ret")
			addcode ("waits:")
			addcode ("	xor ax,ax")
			addcode ("	int 0x16")
			addcode ("	xor cl,cl")
			addcode ("	mov ah,cl")
			addcode ("	ret")
			addcode ("memfill:")
			addcode ("	cmp cx,0")
			addcode ("	jz memfill3")
			addcode ("memfill2:")
			addcode ("cld")
			addcode ("rep stosb")
			addcode ("ret")
			addcode ("	mov [di],al")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz memfill2")
			addcode ("memfill3:")
			addcode ("	ret")
			addcode ("memcopy:")
			addcode ("cmp cx,0")
			addcode ("jnz memcopy2")
			addcode ("ret")
			addcode ("memcopy2:")
			addcode ("cld")
			addcode ("rep movsb")
			addcode ("ret")
			addcode ("	mov al,[si]")
			addcode ("	mov [di],al")
			addcode ("	inc si")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz memcopy2")
			addcode ("	ret")
			addcode ("strcat:")
			addcode ("	mov ah,36")
			addcode ("strcat2:")
			addcode ("	mov al,[di]")
			addcode ("	cmp al,ah")
			addcode ("	jz strcat3")
			addcode ("	inc di")
			addcode ("	jmp strcat2")
			addcode ("strcat3:")
			addcode ("	mov al,[si]")
			addcode ("	mov [di],al")
			addcode ("	cmp al,ah")
			addcode ("	jz strcat4")
			addcode ("	inc si")
			addcode ("	inc di")
			addcode ("	jmp strcat3")
			addcode ("strcat4:")
			addcode ("	ret")
			addcode ("memmove:")
			addcode ("cmp cx,0")
			addcode ("jnz memmove2")
			addcode ("ret")
			addcode ("memmove2:")
			addcode ("std")
			addcode ("rep movsb")
			addcode ("cld")
			addcode ("ret")
			addcode ("	mov al,[si]")
			addcode ("	mov [di],al")
			addcode ("	dec si")
			addcode ("	dec di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0xffff")
			addcode ("	jnz memmove2")
			addcode ("	ret")
			addcode ("str:")
			addcode ("	mov ax,[si]")
			addcode ("	mov bp,10000")
			addcode ("	str16:")
			addcode ("		xor dx,dx")
			addcode ("		xor cx,cx")
			addcode ("		mov bx,bp")
			addcode ("		clc")
			addcode ("		div bx")
			addcode ("		mov si,dx")
			addcode ("		mov ah,48")
			addcode ("		clc")
			addcode ("		add al,ah")
			addcode ("		mov [di],al")
			addcode ("		inc di")
			addcode ("		mov ax,bp")
			addcode ("		xor dx,dx")
			addcode ("		xor cx,cx")
			addcode ("		mov bx,10")
			addcode ("		clc")
			addcode ("		div bx")
			addcode ("		mov bp,ax")
			addcode ("		mov ax,si")
			addcode ("		cmp bp,0")
			addcode ("		jnz str16")
			addcode ("ret")
			addcode ("ret")
			addcode ("val:")
			addcode ("		mov cl,0")
			addcode ("		mov dx,0")
			addcode ("		mov bx,1")
			addcode ("val2:")
			addcode ("		mov al,[si]")
			addcode ("		cmp al,48")
			addcode ("		jb val3")
			addcode ("		cmp al,57")
			addcode ("		ja val3")
			addcode ("		jmp val4")
			addcode ("val3:")
			addcode ("		cmp cl,0")
			addcode ("		jz val40")
			addcode ("		jmp val5")
			addcode ("val4:")
			addcode ("		cmp cl,4")
			addcode ("		jz val55")
			addcode ("		inc cl")
			addcode ("		inc si")
			addcode ("		jmp val2")
			addcode ("val55:")
			addcode ("		dec cl")
			addcode ("val5:")
			addcode ("		dec si")
			addcode ("val6:")
			addcode ("		push cx")
			addcode ("		push dx")
			addcode ("		xor ax,ax")
			addcode ("		mov al,[si]")
			addcode ("		clc")
			addcode ("		sub al,48")
			addcode ("		xor cx,cx")
			addcode ("		xor dx,dx")
			addcode ("		push bx")
			addcode ("		imul bx")
			addcode ("		xor cx,cx")
			addcode ("		xor dx,dx")
			addcode ("		pop bx")
			addcode ("		push ax")
			addcode ("		mov ax,10")
			addcode ("		imul bx")
			addcode ("		mov bx,ax")
			addcode ("		pop ax")
			addcode ("		pop dx")
			addcode ("		pop cx")
			addcode ("		clc")
			addcode ("		add dx,ax")
			addcode ("		dec si")
			addcode ("		dec cl")
			addcode ("		cmp cl,0")
			addcode ("		jz val40")
			addcode ("		jmp val6")
			addcode ("val40:")
			addcode ("		mov ax,dx")
			addcode ("		mov [di],ax")
			addcode ("ret")
			addcode ("len:")
			addcode ("	push bx")
			addcode ("	push cx")
			addcode ("	push dx")
			addcode ("	push di")
			addcode ("	push si")
			addcode ("	mov ah,36")
			addcode ("	mov cx,0")
			addcode ("len2:")
			addcode ("	mov al,[si]")
			addcode ("	cmp al,ah")
			addcode ("	jz len3")
			addcode ("	inc si")
			addcode ("	inc cx")
			addcode ("	jmp len2")
			addcode ("len3:")
			addcode ("	mov ax,cx")
			addcode ("	pop si")
			addcode ("	pop di")
			addcode ("	pop dx")
			addcode ("	pop cx")
			addcode ("	pop bx")
			addcode ("ret")
			addcode ("timer:")
			addcode ("	push ebx")
			addcode ("	push ds")
			addcode ("	mov ax,0x40")
			addcode ("	mov ds,ax")
			addcode ("	mov bx,0x6c")
			addcode ("	mov eax,[bx]")
			addcode ("	pop ds")
			addcode ("	pop ebx")
			addcode ("ret")
			addcode ("sleep:")
			addcode ("	mov ecx,eax")
			addcode ("	xor eax,eax")
			addcode ("	cmp eax,ecx")
			addcode ("	jz sleep6")
			addcode ("	call timer")
			addcode ("	clc")
			addcode ("	add ecx,eax")
			addcode ("	jo sleep8")
			addcode ("	call timer")
			addcode ("	cmp eax,ecx")
			addcode ("	jz sleep6")
			addcode ("	sleep1:")
			addcode ("		call timer")
			addcode ("		cmp eax,ecx")
			addcode ("		jz sleep6")
			addcode ("		jb sleep1")
			addcode ("	jmp sleep6")
			addcode ("	sleep8:")
			addcode ("	sleep5:")
			addcode ("		call timer")
			addcode ("		cmp eax,ecx")
			addcode ("		jz sleep6")
			addcode ("		ja sleep5")
			addcode ("	jmp sleep1")
			addcode ("sleep6:")
			addcode ("ret")
			addcode ("farinto:")
			addcode ("cmp cx,0")
			addcode ("jnz farinto3")
			addcode ("ret")
			addcode ("farinto3:")
			addcode ("	mov ax,cs")
			addcode ("	mov bx,0x2000")
			addcode ("	add ax,bx")
			addcode ("	mov es,ax")
			addcode ("farinto1:")
			addcode ("	ds")
			addcode ("	mov al,[si]")
			addcode ("	es")
			addcode ("	mov [di],al")
			addcode ("	inc si")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz farinto1")
			addcode ("	mov ax,cs")
			addcode ("	mov es,ax")
			addcode ("	ret")
			addcode ("farfrom:")
			addcode ("cmp cx,0")
			addcode ("jnz farfrom3")
			addcode ("ret")
			addcode ("farfrom3:")
			addcode ("	mov ax,cs")
			addcode ("	mov bx,0x2000")
			addcode ("	add ax,bx")
			addcode ("	mov ds,ax")
			addcode ("farfrom1:")
			addcode ("	ds")
			addcode ("	mov al,[si]")
			addcode ("	es")
			addcode ("	mov [di],al")
			addcode ("	inc si")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz farfrom1")
			addcode ("	mov ax,cs")
			addcode ("	mov ds,ax")
			addcode ("	ret")
			addcode ("stringcomp:")
			addcode ("	mov cx,0")
			addcode ("COMPSTRING1:")
			addcode ("	mov al,[si]")
			addcode ("	mov ah,[di]")
			addcode ("	cmp al,36")
			addcode ("	jz COMPSTRING2")
			addcode ("	cmp ah,36")
			addcode ("	jz COMPSTRING2")
			addcode ("	cmp al,ah")
			addcode ("	jnz COMPSTRING2")
			addcode ("	inc di")
			addcode ("	inc si")
			addcode ("	inc cx")
			addcode ("	jnz COMPSTRING1")
			addcode ("COMPSTRING2:")
			addcode ("	cmp al,ah")
			addcode ("	jz COMPSTRING3")
			addcode ("	jb COMPSTRING4")
			addcode ("	mov ax,1")
			addcode ("	jmp COMPSTRING5")
			addcode ("COMPSTRING3:")
			addcode ("	mov ax,0")
			addcode ("	jmp COMPSTRING5")
			addcode ("COMPSTRING4:")
			addcode ("	mov ax,2")
			addcode ("COMPSTRING5:")
			addcode ("	ret")
			addcode ("LOWERSTRING:")
			addcode ("	mov cx,0")
			addcode ("LOWERSTRING1:")
			addcode ("	mov al,[bx]")
			addcode ("	cmp al,36")
			addcode ("	jz LOWERSTRING2")
			addcode ("	cmp al,65")
			addcode ("	jb LOWERSTRING3")
			addcode ("	cmp al,90")
			addcode ("	ja LOWERSTRING3")
			addcode ("	mov ah,32")
			addcode ("	add al,ah")
			addcode ("	mov [bx],al")
			addcode ("LOWERSTRING3:")
			addcode ("	inc bx")
			addcode ("	inc cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz LOWERSTRING1")
			addcode ("LOWERSTRING2:")
			addcode ("	ret")
			addcode ("HIGHSTRING:")
			addcode ("	mov cx,0")
			addcode ("HIGHSTRING1:")
			addcode ("	mov al,[bx]")
			addcode ("	cmp al,36")
			addcode ("	jz HIGHSTRING2")
			addcode ("	cmp al,97")
			addcode ("	jb HIGHSTRING3")
			addcode ("	cmp al,122")
			addcode ("	ja HIGHSTRING3")
			addcode ("	mov ah,32")
			addcode ("	sub al,ah")
			addcode ("	mov [bx],al")
			addcode ("HIGHSTRING3:")
			addcode ("	inc bx")
			addcode ("	inc cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz HIGHSTRING1")
			addcode ("HIGHSTRING2:")
			addcode ("	ret")
			addcode ("FINDCHAR:")
			addcode ("	push bx")
			addcode ("	push cx")
			addcode ("	push dx")
			addcode ("	mov cx,0")
			addcode ("	mov ah,al")
			addcode ("	FINDCHAR1:")
			addcode ("		mov al,[bx]")
			addcode ("		cmp al,36")
			addcode ("		jz FINDCHAR2")
			addcode ("		cmp al,ah")
			addcode ("		jz FINDCHAR3")
			addcode ("		inc bx")
			addcode ("		inc cx")
			addcode ("		cmp cx,0")
			addcode ("		jnz FINDCHAR1")
			addcode ("	FINDCHAR2:")
			addcode ("	mov cx,0xffff")
			addcode ("	FINDCHAR3:")
			addcode ("	mov ax,cx")
			addcode ("	pop dx")
			addcode ("	pop cx")
			addcode ("	pop bx")
			addcode ("	ret")
			addcode ("findstr:")
			addcode ("	mov bp,dx")
			addcode ("	mov si,dx")
			addcode ("	xor ax,ax")
			addcode ("          mov al,[si]")
			addcode ("          mov di,ax")
			addcode ("          mov si,bx")
			addcode ("          mov bx,dx")
			addcode ("          call len")
			addcode ("          cmp ax,0")
			addcode ("          JNZ FINDSTRING9")
			addcode ("          mov ax,0xffff")
			addcode ("          jmp  FINDSTRING8")
			addcode ("          FINDSTRING9:")
			addcode ("          mov bx,si")
			addcode ("          FINDSTRING1:")
			addcode ("                    mov ax,di")
			addcode ("                     call FINDCHAR")
			addcode ("                    cmp ax,0xffff")
			addcode ("                    JZ FINDSTRING8")
			addcode ("                    clc                 ")
			addcode ("                    add bx,ax")
			addcode ("                   mov dx,bp")
			addcode ("                    call compstr")
			addcode ("                    cmp al,0")
			addcode ("                    JZ FINDSTRING10")
			addcode ("                    inc bx         ")
			addcode ("                    jmp FINDSTRING1")
			addcode ("                    FINDSTRING10:")
			addcode ("                    mov ax,bx")
			addcode ("                    FINDSTRING8:")
			addcode ("	ret")
			addcode ("compstr:")
			addcode ("          push bx                ")
			addcode ("          push cx                ")
			addcode ("          push dx                ")
			addcode ("          push di                ")
			addcode ("          push si                ")
			addcode ("          mov cx,0                ")
			addcode ("          mov si,bx")
			addcode ("          mov di,dx")
			addcode ("          compstr1:")
			addcode ("                    mov al,[si]")
			addcode ("                    mov ah,[di]")
			addcode ("                    cmp al,36   ")
			addcode ("                    JZ compstr2")
			addcode ("                    cmp ah,36")
			addcode ("                    JZ compstr3")
			addcode ("                    cmp al,ah")
			addcode ("                    JNZ compstr2")
			addcode ("                    inc di")
			addcode ("                    inc si                ")
			addcode ("                    inc cx                ")
			addcode ("                    cmp cx,0              ")
			addcode ("                    JNZ compstr1")
			addcode ("          compstr2:")
			addcode ("          cmp al,ah")
			addcode ("          JZ compstr3")
			addcode ("          JB compstr4")
			addcode ("          mov al,1   ")
			addcode ("          jmp compstr5")
			addcode ("          compstr3:")
			addcode ("          mov al,0                ")
			addcode ("          jmp compstr5")
			addcode ("          compstr4:")
			addcode ("          mov al,2 ")
			addcode ("          compstr5:")
			addcode ("                    pop si                ")
			addcode ("                    pop di                ")
			addcode ("                    pop dx                ")
			addcode ("                    pop cx                ")
			addcode ("                    pop bx       ")
			addcode ("	ret")
			addcode ("textout:")
			addcode ("	mov di,bx")
			addcode ("	mov ah,3")
			addcode ("	int 0x10")
			addcode ("	call len")
			addcode ("	mov cx,ax")
			addcode ("	mov bx,di")
			addcode ("	mov bp,si")
			addcode ("	mov al,1")
			addcode ("	mov ah,0x13")
			addcode ("	int 0x10")
			addcode ("ret")
			addcode ("STR32:")
			addcode ("          push eax                ")
			addcode ("          push ebx")
			addcode ("          push ecx ")
			addcode ("          push edx")
			addcode ("          push edi")
			addcode ("          push esi")
			addcode ("          push ebp")
			addcode ("          mov eax,[si]")
			addcode ("          mov ebp,1000000000")
			addcode ("          STR321:           ")
			addcode ("                    xor edx,edx")
			addcode ("                    xor ecx,ecx")
			addcode ("                    mov ebx,ebp")
			addcode ("                    clc        ")
			addcode ("                    div ebx    ")
			addcode ("                    mov esi,edx")
			addcode ("                    mov ah,48")
			addcode ("                    clc")
			addcode ("                    add al,ah")
			addcode ("                    mov [di],al")
			addcode ("                    inc di     ")
			addcode ("                    mov eax,ebp")
			addcode ("                    xor edx,edx")
			addcode ("                    xor ecx,ecx")
			addcode ("                    mov ebx,10")
			addcode ("                    clc       ")
			addcode ("                    div ebx   ")
			addcode ("                    mov ebp,eax")
			addcode ("                    mov eax,esi")
			addcode ("                    cmp ebp,0")
			addcode ("                    JNZ STR321")
			addcode ("          pop ebp")
			addcode ("          pop esi")
			addcode ("          pop edi")
			addcode ("          pop edx")
			addcode ("          pop ecx")
			addcode ("          pop ebx")
			addcode ("          pop eax")
			addcode ("          RET   ")
			addcode ("hline:")
			addcode ("jmp hline64")
			addcode ("hlinebp dd 0")
			addcode ("hline64:")
			addcode ("	mov bx,hlinebp")
			addcode ("	mov [bx],bp")
			addcode ("	push bp")
			addcode ("	mov bp,sp")
			addcode ("	sub sp,16")
			addcode ("	mov ax,[bp+9]")
			addcode ("	cmp ax,200")
			addcode ("	jb hline11")
			addcode ("	mov ax,199")
			addcode ("	mov [bp+9],ax")
			addcode ("hline11:")
			addcode ("	cmp ax,0")
			addcode ("	jge hline1")
			addcode ("	mov ax,0")
			addcode ("	mov [bp+9],ax")
			addcode ("hline1:")
			addcode ("	mov bx,320")
			addcode ("	xor cx,cx")
			addcode ("	xor dx,dx")
			addcode ("	clc")
			addcode ("	imul bx")
			addcode ("	mov bx,[bp+11]")
			addcode ("	clc")
			addcode ("	add ax,bx")
			addcode ("	mov [bp+0],ax")
			addcode ("	mov ax,[bp+11]")
			addcode ("	mov bx,[bp+7]")
			addcode ("	cmp bx,ax")
			addcode ("	ja hline2")
			addcode ("	cmp ax,320")
			addcode ("	jb hline3")
			addcode ("	mov ax,319")
			addcode ("	mov [bp+11],ax")
			addcode ("hline3:")
			addcode ("	cmp ax,0")
			addcode ("	jge hline4")
			addcode ("	mov ax,0")
			addcode ("	mov [bp+11],ax")
			addcode ("hline4:")
			addcode ("	cmp bx,320")
			addcode ("	jb hline5")
			addcode ("	mov bx,319")
			addcode ("	mov [bp+11],bx")
			addcode ("hline5:")
			addcode ("	cmp bx,0")
			addcode ("	jge hline2")
			addcode ("	mov bx,0")
			addcode ("	mov [bp+11],bx")
			addcode ("hline2:")
			addcode ("	clc")
			addcode ("	sub bx,ax")
			addcode ("	mov cx,bx")
			addcode ("	push es")
			addcode ("	call setrefresh")
			addcode ("	mov ax,[bp+0]")
			addcode ("	mov di,ax")
			addcode ("	mov al,[bp+5]")
			addcode ("	call memfill")
			addcode ("	pop es")
			addcode ("hlineend:")
			addcode ("	mov sp,bp")
			addcode ("	pop bp")
			addcode ("	mov bx,hlinebp")
			addcode ("	mov bp,[bx]")
			addcode ("ret")
			addcode ("ret")
			addcode ("box:")
			addcode ("jmp box64")
			addcode ("boxbp dd 0")
			addcode ("box64:")
			addcode ("	mov bx,boxbp")
			addcode ("	mov [bx],bp")
			addcode ("	push bp")
			addcode ("	mov bp,sp")
			addcode ("	sub sp,16")
			addcode ("	mov ax,[bp+11]")
			addcode ("	mov bx,[bp+7]")
			addcode ("	add bx,ax")
			addcode ("	mov [bp+7],bx")
			addcode ("	mov ax,[bp+9]")
			addcode ("	mov bx,[bp+13]")
			addcode ("	add bx,ax")
			addcode ("	mov [bp+13],bx")
			addcode ("	mov ax,[bp+9]")
			addcode ("	cmp ax,200")
			addcode ("	jb box22")
			addcode ("	mov ax,199")
			addcode ("	mov [bp+9],ax")
			addcode ("box22:")
			addcode ("	cmp ax,0")
			addcode ("	jge box1")
			addcode ("	mov ax,0")
			addcode ("	mov [bp+9],ax")
			addcode ("box1:")
			addcode ("	mov bx,320")
			addcode ("	xor cx,cx")
			addcode ("	xor dx,dx")
			addcode ("	clc")
			addcode ("	imul bx")
			addcode ("	mov bx,[bp+11]")
			addcode ("	clc")
			addcode ("	add ax,bx")
			addcode ("	mov [bp+0],ax")
			addcode ("	mov ax,[bp+11]")
			addcode ("	mov bx,[bp+7]")
			addcode ("	cmp bx,ax")
			addcode ("	ja box10")
			addcode ("	jmp boxend")
			addcode ("box10:")
			addcode ("	cmp ax,320")
			addcode ("	jb box3")
			addcode ("	mov ax,319")
			addcode ("	mov [bp+11],ax")
			addcode ("box3:")
			addcode ("	cmp ax,0")
			addcode ("	jge box4")
			addcode ("	mov ax,0")
			addcode ("	mov [bp+11],ax")
			addcode ("box4:")
			addcode ("	cmp bx,320")
			addcode ("	jb box5")
			addcode ("	mov bx,319")
			addcode ("	mov [bp+7],bx")
			addcode ("box5:")
			addcode ("	cmp bx,0")
			addcode ("	jge box2")
			addcode ("	mov bx,319")
			addcode ("	mov [bp+7],bx")
			addcode ("box2:")
			addcode ("	clc")
			addcode ("	sub bx,ax")
			addcode ("	mov [bp-2],bx")
			addcode ("	mov ax,[bp+13]")
			addcode ("	mov bx,[bp+9]")
			addcode ("	cmp ax,200")
			addcode ("	jb box12")
			addcode ("	mov ax,199")
			addcode ("	mov [bp+13],ax")
			addcode ("box12:")
			addcode ("	cmp ax,0")
			addcode ("	jge box11")
			addcode ("	mov ax,0")
			addcode ("	mov [bp+13],ax")
			addcode ("box11:")
			addcode ("	sub ax,bx")
			addcode ("	mov [bp-4],ax")
			addcode ("	cmp ax,0")
			addcode ("	jnz box16")
			addcode ("	jmp boxend")
			addcode ("box16:")
			addcode ("	mov bx,320")
			addcode ("	mov ax,[bp-2]")
			addcode ("	sub bx,ax")
			addcode ("	mov [bp-6],bx")
			addcode ("	push es")
			addcode ("	call setrefresh")
			addcode ("	mov ax,[bp+0]")
			addcode ("	mov di,ax")
			addcode ("	mov si,[bp-4]")
			addcode ("box20:")
			addcode ("	mov cx,[bp-2]")
			addcode ("	mov al,[bp+5]")
			addcode ("	call memfill")
			addcode ("	mov ax,[bp-6]")
			addcode ("	add di,ax")
			addcode ("	dec si")
			addcode ("	cmp si,0")
			addcode ("	jnz box20")
			addcode ("	pop es")
			addcode ("boxend:")
			addcode ("	mov sp,bp")
			addcode ("	pop bp")
			addcode ("	mov bx,boxbp")
			addcode ("	mov bp,[bx]")
			addcode ("ret")
			addcode ("setrefresh:")
			addcode ("mov bx,cs")
			addcode ("mov ax,0x3000")
			addcode ("add ax,bx")
			addcode ("mov es,ax")
			addcode ("ret")
			addcode ("setvideo:")
			addcode ("push es")
			addcode ("push ds")
			addcode ("call setrefresh")
			addcode ("mov ax,es")
			addcode ("mov ds,ax")
			addcode ("mov ax,0xa000")
			addcode ("mov es,ax")
			addcode ("mov si,0")
			addcode ("mov di,0")
			addcode ("mov cx,65001")
			addcode ("call memcopy")
			addcode ("pop ds")
			addcode ("pop es")
			addcode ("ret")
			addcode ("chain:")
			addcode ("	mov bx,0x100")
			addcode ("	mov dx,bx")
			addcode ("	mov cx,65050")
			addcode ("	mov bx,65298")
			addcode ("	mov ax,[bx]")
			addcode ("	mov bx,ax")
			addcode ("	mov ah,0x3f")
			addcode ("	int 0x21")
			addcode ("	mov bx,65298")
			addcode ("	mov ax,[bx]")
			addcode ("	mov bx,ax")
			addcode ("	mov al,2")
			addcode ("	mov ah,0x3e")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("")
			addcode ("cicle:")
			addcode ("	cmp dx,0")
			addcode ("	jz cicle2")
			addcode ("	cmp ax,0")
			addcode ("	jz cicle2")
			addcode ("	mov cx,dx")
			addcode ("	cicle1:")
			addcode ("		dec cx")
			addcode ("		jnz cicle1")
			addcode ("	dec ax")
			addcode ("	jnz cicle")
			addcode ("cicle2:")
			addcode ("ret")
			addcode ("section .data")
			addcode ("L4 db 0,0,0,0,0")
			addcode ("L18 dw 0,0")
			addcode ("L20 dw 0,0,0,0,0,0,0,0")
			addcode ("L21 dw 0,0,0,0")
			addcode ("L6 db 'press a key to go on, esc key to exit scroll',13,10,'$'")
			addcode ("L16 db '..........................................',13,10,'$'")
			addcode ("L17 db '00000 $.........................',13,10,'$'")
			addcode ("L22 db '0000000000000000000$............',13,10,'$'")
			addcode (";start tail")
			addcode ("")

'add head
			tt1=""
			addhead ("section .text")
			addhead ("org 0x100")
			addhead ("main:")
			addhead ("jmp mains")
			addhead ("db 'build in index developer tools.... '")
			addhead ("mains:")
			addhead ("		;start stack 64k")
			addhead ("	mov ax,cs")
			addhead ("	mov cx,0x1000")
			addhead ("	add ax,cx")
			addhead ("	mov ss,ax")
			addhead ("	mov ax,0xffff")
			addhead ("	mov sp,ax")
			addhead ("	xor ax,ax")
			addhead ("	push ax")
			addhead ("		;end stack 64k")
			addhead ("		;start alocate")
			addhead ("	mov bx,L18")
			addhead ("	mov ax,endf")
			addhead ("	mov cx,8")
			addhead ("	add ax,cx")
			addhead ("	mov [bx],ax")
			addhead ("		;end alocate")
			addhead ("		;start randomize")
			addhead ("	call timer")
			addhead ("	mov bx,L20")
			addhead ("	xor cx,cx")
			addhead ("	mov cl,al")
			addhead ("	mov ax,257")
			addhead ("	add ax,cx")
			addhead ("	mov [bx],ax")
			addhead ("		;end randomize")
			addhead ("")
			addhead (";body start")

end sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class







