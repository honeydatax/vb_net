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
	dim labeldefined(3000) as integer
	dim txtbody as string
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

       Me.Text = "index 32 bits - linesky@sapo.pt"
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


								if varstype(bbb)=0 then	 


									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	call len32")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	call PRINT32")
									errorssi=-1
									errorss=0

								
								else
									
									if varstype(bbb)=1 then	 


										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov esi,[bx]")
										addtxtbody("	call len32")
										addtxtbody("	mov ecx,eax")
										addtxtbody("	call PRINT32")
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


'key timer.sleep,varnumber
					if par1=keywords(50) then
						errorssi=50
						if par(50)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6  then	 
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov eax,[si]")
									addtxtbody("	call sleep")
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


'key timer.rnd,varnumber
					if par1=keywords(51) then
						errorssi=51
						if par(51)=separete.length then

							tc=ucase(trim(separete(1)))
							bbb=findvar(tc)
							if bbb<>-1 and tc<>""   then


								if varstype(bbb)=6  then	 

									addtxtbody("	mov si,L20")
									addtxtbody("	mov cx,[si]")
									addtxtbody("	mov ax,4")
									addtxtbody("	add cx,ax")
									addtxtbody("	mov [si],cx")
									addtxtbody("	mov ax,endf")
									addtxtbody("	cmp cx,ax")
									addtxtbody("	jl LJ"+(trim(str(iii+9000))))
									addtxtbody("	sub cx,ax")
									addtxtbody("	mov ax,257")
									addtxtbody("	add cx,ax")
									addtxtbody("	mov [si],cx")
									addtxtbody("LJ"+(trim(str(iii+9000)))+":")
									addtxtbody("	mov si,cx")
									addtxtbody("	xor ax,ax")
									addtxtbody("	mov eax,[si]")
									addtxtbody("	mov di,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [di],eax")
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
								
								addlabel(tc,0,iii,0)
								addtxtbody("	mov ax,LL"+trim(str(iii+8000)))
								addtxtbody("	push ax")

								errorssi=-1
								errorss=0
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
									addtxtbody("	mov ax, LL"+trim(str(labeladdress(bbb)+8000)))
									addtxtbody("	push ax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,bx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov dx,0")
									addtxtbody("	mov ds,dx")
									addtxtbody("	mov eax,[esi]")
									addtxtbody("	mov dx,cs")
									addtxtbody("	mov ds,dx")
									addtxtbody("	mov [di],eax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov al,[bx]")
									addtxtbody("	mov dx,0")
									addtxtbody("	mov ds,dx")
									addtxtbody("	mov [edi],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	and eax,ecx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],eax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	not eax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],eax")
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
										addtxtbody("	mov ax,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov cx,L"+(trim(line11(bbb3)+9000)))
										addtxtbody("	mov dx,L"+(trim(line11(bbb4)+9000)))
										addtxtbody("	call LL"+trim(str(labeladdress(bbb)+8000)))
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
										addlabel(tc,0,iii,0)
										addtxtbody("	mov ax,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov cx,L"+(trim(line11(bbb3)+9000)))
										addtxtbody("	mov dx,L"+(trim(line11(bbb4)+9000)))
									 	addtxtbody("	call LL"+trim(str(iii+8000)))
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





'key string.len,varnumber,vartext
					if par1=keywords(49) then
						errorssi=49
						if par(49)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>""  then


								if varstype(bbb)=6 and varstype(bbb1)=1  then	 

										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov esi,[bx]")
										addtxtbody("	call len32")
									addtxtbody("	mov di,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [di],eax")
									errorssi=-1
									errorss=0

								else
								if varstype(bbb)=6 and varstype(bbb1)=0  then	 

										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov si,bx")
										addtxtbody("	mov ax,cs")
										addtxtbody("	call MEM32")
										addtxtbody("	mov esi,eax")
										addtxtbody("	call len32")
									addtxtbody("	mov di,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [di],eax")
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




'key set ,constant,text
					if par1=keywords(1) then 
						errorssi=1

						if par(1)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,0,iii)							
								addbody("L"+trim(str(iii+9000))+" db '"+separete(2)+"',0")
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

									addtxtbody("	mov bx,x")
									addtxtbody("	mov si,L"+(trim(iii+9000)))
									addtxtbody("	call echo")
									addbody("L"+trim(str(iii+9000))+" db "+str(len(separete(1))+2)+" , '"+separete(1)+"',13,10,0")

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

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
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov eax,"+str(n))
									addtxtbody("	mov [bx],eax")
									errorssi=-1
									errorss=0

								else

									if varstype(bbb)=12 then	 
										fn=val(trim(separete(2)))
										fn=fn*100
										fi=fn
										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov eax,"+str(fi))
										addtxtbody("	mov [bx],eax")
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


'key wait,var to put key code
					if par1=keywords(4) then
						errorssi=4
						if par(4)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)=6 then


									addtxtbody("	call waits")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],ax")
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

'key inkey,var to put key code
					if par1=keywords(68) then
						errorssi=68
						if par(68)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" then


								if varstype(bbb)=6 then	 


									addtxtbody("	call inkey")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],ax")

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
								addbody("L"+trim(str(iii+9000))+" dd "+str(n))
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
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

'key exit
					if par1=keywords(9) then
						errorssi=9
						if par(9)=separete.length then
									addtxtbody("	jmp exit")
						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 

'key :,label id
					if par1=keywords(64) then 
						errorssi=64

						if par(64)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,1,iii,1)
								addtxtbody("LL"+trim(str(iii+8000))+":")
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) and labeldefined(bbb)=0 then 
									labeldefined(bbb)=1
									addtxtbody("LL"+trim(str(labeladdress(bbb)+8000))+":")
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





'key label,label id
					if par1=keywords(10) then 
						errorssi=10

						if par(10)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,1,iii,1)
								addtxtbody("LL"+trim(str(iii+8000))+":")
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) and labeldefined(bbb)=0 then 
									labeldefined(bbb)=1
									addtxtbody("LL"+trim(str(labeladdress(bbb)+8000))+":")
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
										addlabel(tc2,0,iii,0)

										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	cmp eax,ecx")
										addtxtbody("	jge LLZ"+trim(str(iii+7000)))
										addtxtbody("	jmp LL"+trim(str(iii+8000)))
										addtxtbody("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtxtbody("	mov ax,[bx]")
											addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtxtbody("	mov cx,[bx]")
											addtxtbody("	cmp ax,cx")
											addtxtbody("	jge LLZ"+trim(str(iii+7000)))
											addtxtbody("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtxtbody("LLZ"+trim(str(iii+7000))+":")
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
										addlabel(tc2,0,iii,0)

										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	cmp eax,ecx")
										addtxtbody("	jle LLZ"+trim(str(iii+7000)))
										addtxtbody("	jmp LL"+trim(str(iii+8000)))
										addtxtbody("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtxtbody("	mov ax,[bx]")
											addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtxtbody("	mov cx,[bx]")
											addtxtbody("	cmp ax,cx")
											addtxtbody("	jle LLZ"+trim(str(iii+7000)))
											addtxtbody("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtxtbody("LLZ"+trim(str(iii+7000))+":")
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
										addlabel(tc2,0,iii,0)

										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	cmp eax,ecx")
										addtxtbody("	jz LLZ"+trim(str(iii+7000)))
										addtxtbody("	jmp LL"+trim(str(iii+8000)))
										addtxtbody("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtxtbody("	mov eax,[bx]")
											addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtxtbody("	mov ecx,[bx]")
											addtxtbody("	cmp eax,ecx")
											addtxtbody("	jz LLZ"+trim(str(iii+7000)))
											addtxtbody("	jmp LL"+trim(str(labeladdress(bbb2)+8000))) 
											addtxtbody("LLZ"+trim(str(iii+7000))+":")
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
										addlabel(tc2,0,iii,0)

										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	cmp eax,ecx")
										addtxtbody("	jnz LLZ"+trim(str(iii+7000)))
										addtxtbody("	jmp LL"+trim(str(iii+8000)))
										addtxtbody("LLZ"+trim(str(iii+7000))+":")
										errorssi=-1
										errorss=0

									else
	
										if bbb2>-1 and tc2<>"" and (asc(tc2)>(asc("A")-1)) and (asc(tc2)<(asc("Z")+1)) then 
											addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtxtbody("	mov eax,[bx]")
											addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
											addtxtbody("	mov ecx,[bx]")
											addtxtbody("	cmp eax,ecx")
											addtxtbody("	jnz LLZ"+trim(str(iii+7000)))
											addtxtbody("	jmp LL"+trim(str(labeladdress(bbb2)+8000)))
											addtxtbody("LLZ"+trim(str(iii+7000))+":")
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





'key goto,label id
					if par1=keywords(11) then 
						errorssi=11

						if par(11)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addlabel(tc,0,iii,0)
								addtxtbody("	jmp LL"+trim(str(iii+8000)))
								errorssi=-1
								errorss=0
							errorssi=-1
							errorss=0

							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtxtbody("	jmp LL"+trim(str(labeladdress(bbb)+8000)))
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
									addtxtbody("	ret")
						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

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


								if varstype(bbb)=6 and varstype(bbb1)=1  then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,bx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	mov [di],eax")
									errorssi=-1
									errorss=0

								else
									if varstype(bbb)=6 and varstype(bbb1)=0  then	 

										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov di,bx")
										addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov ax,cs")
										addtxtbody("	call MEM32")
										addtxtbody("	mov [di],eax")
										errorssi=-1
										errorss=0

									else
										if varstype(bbb)=6 and varstype(bbb1)=6  then	 

											addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
											addtxtbody("	mov di,bx")
											addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
											addtxtbody("	mov ax,cs")
											addtxtbody("	call MEM32")
											addtxtbody("	mov [di],eax")
											errorssi=-1
											errorss=0
	
												else
											if varstype(bbb)=6 and varstype(bbb1)=12  then	 
		
												addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
												addtxtbody("	mov di,bx")
												addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
												addtxtbody("	mov ax,cs")
												addtxtbody("	call MEM32")
												addtxtbody("	mov [di],eax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	dec ecx")
									addtxtbody("	add edi,ecx")
									addtxtbody("	add esi,ecx")
									addtxtbody("	mov edx,1")
									addtxtbody("	inc ecx")
									addtxtbody("	call MOVEMEM32")
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


								if varstype(bbb)=1 and varstype(bbb1)=6  then	 

									addtxtbody("	mov bx,L50")
									addtxtbody("	mov dx,bx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov cl,[bx]")
									addtxtbody("	mov bx,dx")
									addtxtbody("	xor ch,ch")
									addtxtbody("	mov [bx],cx")
									addtxtbody("	mov ah,0xa")
									addtxtbody("	int 0x21")
									addtxtbody("	mov bx,L50")
									addtxtbody("	inc bx")
									addtxtbody("	mov si,bx")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	mov cl,[bx]")
									addtxtbody("	push ecx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	inc esi")
									addtxtbody("	mov edx,1")
									addtxtbody("	call COPYMEM32")
									addtxtbody("	pop ecx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")
									addtxtbody("	mov al,0")
									addtxtbody("	add esi,ecx")
									addtxtbody("	mov [esi],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")

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
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6   then	 

									addtxtbody("	mov bx,L50")
									addtxtbody("	mov dx,bx")
									addtxtbody("	mov cl,10")
									addtxtbody("	mov bx,dx")
									addtxtbody("	xor ch,ch")
									addtxtbody("	mov [bx],cx")
									addtxtbody("	mov ah,0xa")
									addtxtbody("	int 0x21")
									addtxtbody("	mov si,L50")
									addtxtbody("	inc si")
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov ah,0")
									addtxtbody("	add si,ax")
									addtxtbody("	inc si")
									addtxtbody("	mov al,0")
									addtxtbody("	mov [si],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov si,L50")
									addtxtbody("	inc si")
									addtxtbody("	inc si")
									addtxtbody("	call MEM32 ")
									addtxtbody("	mov esi,eax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,bx")
									addtxtbody("	call val")

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


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	add esi,edi")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	call COPYMEM32")
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


								if varstype(bbb)=1 and varstype(bbb1)=1 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")
									addtxtbody("	mov es,bp")
									addtxtbody("	call memford")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")
									addtxtbody("	call memford")
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


								if varstype(bbb)=1 and varstype(bbb1)=1 and varstype(bbb2)=6  then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	add esi,ecx")
									addtxtbody("	call strcat")
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

'key const ,value
					if par1=keywords(69) then 
						errorssi=69

						if par(69)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" then 
								addvar(tc,6,iii)
								n=val(trim(separete(1)))
								addbody("L"+trim(str(iii+9000))+" dd "+str(n))
							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")
									addtxtbody("	call memcopy")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")

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


								if varstype(bbb)=1 and varstype(bbb1)=6  then	 

									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov edi,[bx]")
										addtxtbody("	call STR32")

									errorssi=-1
									errorss=0

								else


									if varstype(bbb)=1 and varstype(bbb1)=12  then	 
	
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov edi,[bx]")
										addtxtbody("	call STR32")

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ecx,9")
									addtxtbody("	clc")
									addtxtbody("	add esi,ecx")
									addtxtbody("	mov ecx,10")
									addtxtbody("	clc")
									addtxtbody("	add edi,ecx")
									addtxtbody("	mov ecx,2")
									addtxtbody("	call MOVEMEM32")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ecx,8")
									addtxtbody("	clc")
									addtxtbody("	add esi,ecx")
									addtxtbody("	mov al,46")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")

									addtxtbody("	mov [esi],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ecx,11")
									addtxtbody("	clc")
									addtxtbody("	add esi,ecx")
									addtxtbody("	mov al,0")
									addtxtbody("	mov [esi],al")

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


								if varstype(bbb)=6 and varstype(bbb1)=1  then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,bx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	call val")
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



'key memory ,var,address
					if par1=keywords(82) then 
						errorssi=82

						if par(82)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,1,iii)
								n=val(trim(separete(2)))
								addbody("L"+trim(str(iii+9000))+ " dd "+str(n))

							else
									iii=1+iii
								goto errorhandler
							end if 
							errorssi=-1
							errorss=0
						end if
						goto allkey
					end if



'key string ,var,number size
					if par1=keywords(21) then 
						errorssi=21

						if par(21)=separete.length then
							tc=ucase(trim(separete(1)))
							if findvar(tc)=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								addvar(tc,1,iii)
								n=val(trim(separete(2)))
								addbody("L"+trim(str(iii+9000))+ " dd 0")
								addtail("	mov ecx,"+str(n+8))
								addtail("	call RESERVES")
								addtail("	mov si,L"+trim(str(iii+9000)))
								addtail("	mov [si],eax")

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


								if varstype(bbb)=1 and varstype(bbb1)=1  then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	call strcat")
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


								if varstype(bbb)=1 and varstype(bbb1)=1  then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov al,0")
									addtxtbody("	mov [edi],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	call strcat")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
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



'key gosub,label id
					if par1=keywords(18) then 
						errorssi=18

						if par(18)=separete.length then
							tc=ucase(trim(separete(1)))
							bbb=findlabel(tc)
							if bbb=-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
								addlabel(tc,0,iii,0)
								addtxtbody("	call LL"+trim(str(iii+8000)))

								errorssi=-1
								errorss=0
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
								
									addtxtbody("	call LL"+trim(str(labeladdress(bbb)+8000)))
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

									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[si]")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ebx,[si]")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	clc")
									addtxtbody("	div ebx")
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [si],eax")
									errorssi=-1
									errorss=0
 
								else

									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov eax,[si]")
										addtxtbody("	cmp eax,10")
										addtxtbody("	jl LE"+(trim(str(iii+9000))))
										addtxtbody("	cmp eax,100")
										addtxtbody("	jl LI"+(trim(str(iii+9000))))
										addtxtbody("	LE"+(trim(str(iii+9000)))+":")
										addtxtbody("	mov edi,eax")
										addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov eax,[si]")
										addtxtbody("	mov ebx,100")
										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	clc")
										addtxtbody("	imul ebx")
										addtxtbody("	mov ebx,edi")
										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	clc")
										addtxtbody("	idiv ebx")
										addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov [si],eax")

										addtxtbody("	jmp LO"+(trim(str(iii+9000))))
										addtxtbody("	LI"+(trim(str(iii+9000)))+":")
										addtxtbody("	mov edi,eax")
										addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov eax,[si]")
										addtxtbody("	mov ebx,100")
										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	clc")
										addtxtbody("	imul ebx")
										addtxtbody("	mov ebx,edi")
										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	clc")
										addtxtbody("	idiv ebx")
										addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov [si],eax")
										addtxtbody("	LO"+(trim(str(iii+9000)))+":")

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

									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[si]")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ebx,[si]")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	clc")
									addtxtbody("	imul ebx")
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [si],eax")
							errorssi=-1
							errorss=0


								else
	
									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then	 
	
										addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov eax,[si]")
										addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov ebx,[si]")

										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	clc")
										addtxtbody("	imul ebx")
										addtxtbody("	xor ecx,ecx")
										addtxtbody("	xor edx,edx")
										addtxtbody("	mov ebx,100")
										addtxtbody("	clc")
										addtxtbody("	idiv ebx")
										addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov [si],eax")
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





'key machine,value1,value2,...
					if par1=keywords(37) then 
						errorssi=37

						if par(37)<=separete.length then
							txtbody=txtbody+chr(13)+chr(10)+"LC"+trim(str(iii+3000))+" db 0x90"
							for bbb1=1 to separete.length-1
	
								txtbody=txtbody+","+str(val(separete(bbb1)))

							next bbb1

							txtbody=txtbody+chr(13)+chr(10)
							errorssi=-1
							errorss=0

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

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	sub eax,ecx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],eax")
								 	errorssi=-1
								errorss=0

								else


									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	clc")
										addtxtbody("	sub eax,ecx")
										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov [bx],eax")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	add eax,ecx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],eax")
							errorssi=-1
							errorss=0

								 
								else

									if varstype(bbb)=12 and varstype(bbb1)=12 and varstype(bbb2)=12 then

										addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtxtbody("	mov eax,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	clc")
										addtxtbody("	add eax,ecx")
										addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov [bx],eax")
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


								if varstype(bbb)=1 and varstype(bbb1)=1 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")
									addtxtbody("	mov es,bp")
									addtxtbody("	call memcopy")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")
									errorssi=-1
									errorss=0

								else
									if varstype(bbb)=1 and varstype(bbb1)=0 and varstype(bbb2)=6 then	 
	

									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtxtbody("	mov edi,[bx]")
										addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
										addtxtbody("	mov ecx,[bx]")
										addtxtbody("	mov edx,1")
										addtxtbody("	call COPYMEM32")
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


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov al,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")
									addtxtbody("	mov es,bp")
									addtxtbody("	call memfill")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")

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



'key fillstep,vartext,varchar,varsize,,varstep
					if par1=keywords(83) then
						errorssi=83
						if par(83)=separete.length then

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))
							tc2=ucase(trim(separete(3)))
							tc3=ucase(trim(separete(4)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							bbb2=findvar(tc2)
							bbb3=findvar(tc3)
							if bbb<>-1 and tc<>"" and bbb1<>-1 and tc1<>"" and bbb2<>-1 and tc2<>"" then


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 and varstype(bbb3)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov al,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov edx,[bx]")
									addtxtbody("	call FILL32")
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

									addtxtbody("	mov bx,x")
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov [bx],al")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	inc bx")
									addtxtbody("	mov [bx],al")

									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov dl,[si]")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov dh,[si]")
									addtxtbody("	mov ah,2")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov bh,[si]")
									addtxtbody("	int 0x10")



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


									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov eax,[si]")
									addtxtbody("	call scr")

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

'key color,n
					if par1=keywords(84) then
						errorssi=84
						if par(84)=separete.length then

							tc=ucase(trim(separete(1)))
							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6  then


									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,color")
									addtxtbody("	mov [si],al")

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
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov di,bx")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov si,bx")
									addtxtbody("	mov eax,[si]")
									addtxtbody("	mov [di],eax")
									addtxtbody("	LLLL"+trim(iii+5000)+":")
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


								

									addtxtbody("	mov bx,L"+(trim(str(forstep(forcount-1)))))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bx,L"+(trim(str(forinto(forcount-1)))))
									addtxtbody("	mov di,bx")
									addtxtbody("	mov bx,L"+(trim(str(forvar(forcount-1)))))
									addtxtbody("	mov si,bx")
									addtxtbody("	mov eax,[si]")
									addtxtbody("	add eax,ecx")
									addtxtbody("	mov [si],eax")
									addtxtbody("	mov ecx,[di]")
									addtxtbody("	cmp eax,ecx")
									addtxtbody("	jg LA"+trim(str(iii+4000)))
									addtxtbody("	jmp LLLL"+trim(str(foraddress(forcount-1))))
									addtxtbody("	LA"+trim(str(iii+4000))+":")
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
'key printnumber,varnumber
					if par1=keywords(36) then
						errorssi=36
						if par(36)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""   then


								if varstype(bbb)=6  then	 
									addtxtbody("	mov si,L17")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov edi,eax")
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	call STR32")
									addtxtbody("	mov si,L17")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	call len32")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	call PRINT32")

									errorssi=-1
									errorss=0

								else

									if varstype(bbb)=12  then
									addtxtbody("	mov si,L22")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov edi,eax")
									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	call STR32")

									addtxtbody("	mov si,L22")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	mov eax,9")
									addtxtbody("	clc")
									addtxtbody("	add esi,eax")
									addtxtbody("	mov edi,esi")
									addtxtbody("	inc edi")
									addtxtbody("	mov ecx,2")
									addtxtbody("	call MOVEMEM32")
									addtxtbody("	mov al,46")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov ds,bp")
									addtxtbody("	dec esi")
									addtxtbody("	mov [esi],al")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov si,L22")
									addtxtbody("	mov ax,cs")
									addtxtbody("	call MEM32")
									addtxtbody("	mov esi,eax")
									addtxtbody("	call len32")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	call PRINT32")





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

'key ;,ignored text
					if par1=keywords(66) then
						errorssi=66
						if par(66)<=separete.length then

									addtxtbody("; "+separete(1))
									addbody("; "+separete(1))

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

						goto allkey
					end if 

'key rem,ignored text
					if par1=keywords(17) then
						errorssi=17
						if par(17)<=separete.length then

									addtxtbody("; "+separete(1))
									addbody("; "+separete(1))

						else
							iii=1+iii
							goto errorhandler

						end if 
						errorssi=-1
						errorss=0

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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov al,[bx]")
									addtxtbody("	mov edi,140000h") 
									addtxtbody("	mov ecx,1ffffh") 
									addtxtbody("	push ds")
									addtxtbody("	push es")
									addtxtbody("	mov edx,0")
									addtxtbody("	mov ds,dx")
									addtxtbody("	mov es,dx")
									addtxtbody("	call memfilld")
									addtxtbody("	pop es")
									addtxtbody("	pop ds")



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




									addtxtbody("	call setvideo")



									errorssi=-1
									errorss=0
							else
									iii=1+iii
									goto errorhandler 

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

									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,hlinex")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,hliney")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,hlinex1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,hlinecolor")
									addtxtbody("	mov [si],al")
									addtxtbody("	call hlined32")


									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	xor eax,eax")
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	xor ebx,ebx")
									addtxtbody("	mov bx,[si]")
									addtxtbody("	sub ebx,eax")
									addtxtbody("	mov eax,ebx")
									addtxtbody("	push eax")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	mov ebx,4")
									addtxtbody("	div ebx")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	mul ebx")
									addtxtbody("	pop ebx")
									addtxtbody("	sub ebx,eax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	xor eax,eax")
									addtxtbody("	mov ax,[si]")
									addtxtbody("	sub eax,ebx")

									addtxtbody("	mov si,hlinex")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,hliney")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,hlinex1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,hlinecolor")
									addtxtbody("	mov [si],al")
									addtxtbody("	call hlined32")


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

									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxdx")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxdy")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxdx1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxdy1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb4)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,boxdcolor")
									addtxtbody("	mov [si],al")
									addtxtbody("	call boxd32")

									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	xor eax,eax")
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	xor ebx,ebx")
									addtxtbody("	mov bx,[si]")
									addtxtbody("	sub ebx,eax")
									addtxtbody("	mov eax,ebx")
									addtxtbody("	push eax")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	mov ebx,4")
									addtxtbody("	div ebx")
									addtxtbody("	xor ecx,ecx")
									addtxtbody("	xor edx,edx")
									addtxtbody("	mul ebx")
									addtxtbody("	pop ebx")
									addtxtbody("	sub ebx,eax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	xor eax,eax")
									addtxtbody("	mov ax,[si]")
									addtxtbody("	sub eax,ebx")

									addtxtbody("	mov si,boxx")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxy")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxx1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,boxy1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb4)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,boxcolor")
									addtxtbody("	mov [si],al")
									addtxtbody("	call box32")


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



'key vline,x,y,y2,color
					if par1=keywords(85) then
						errorssi=85
						if par(85)=separete.length then

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

									addtxtbody("	mov si,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,vlinex")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,vliney")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ax,[si]")
									addtxtbody("	mov si,vliney1")
									addtxtbody("	mov [si],ax")
									addtxtbody("	mov si,L"+(trim(line11(bbb3)+9000)))
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov si,vlinecolor")
									addtxtbody("	mov [si],al")
									addtxtbody("	call vline32")


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

'key nosound stop sound
					if par1=keywords(86) then
						errorssi=86
						if par(86)=separete.length then




									addtxtbody("	call nosound")



									errorssi=-1
									errorss=0
							else
									iii=1+iii
									goto errorhandler 

							end if 
						goto allkey
					end if 

'key sound,freq
					if par1=keywords(87) then
						errorssi=87
						if par(87)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>""  then


								if varstype(bbb)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	call sound")



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


'key beep 
					if par1=keywords(88) then
						errorssi=88
						if par(88)=separete.length then


									addtxtbody("	mov eax,750")
									addtxtbody("	call sound")
									addtxtbody("	mov eax,8")
									addtxtbody("	call sleep")
									addtxtbody("	call nosound")



									errorssi=-1
									errorss=0
							else
									iii=1+iii
									goto errorhandler 

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


								if varstype(bbb)=1 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memlen")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memlower")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")


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


								if varstype(bbb)=1 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memlen")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memhigth")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")

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


								if varstype(bbb)=6 and varstype(bbb1)=1 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memlen")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov al,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov es,bp")
									addtxtbody("	mov ds,bp")
									addtxtbody("	call findchr")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],ecx")
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


								if varstype(bbb)=6 and varstype(bbb1)=1 and varstype(bbb1)=1 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov ax,0")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	call memlen")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov es,bp")
									addtxtbody("	mov ds,bp")
									addtxtbody("	call comps")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],ecx")

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


								if varstype(bbb)=6 and varstype(bbb1)=1 and varstype(bbb2)=1 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bp,0")
									addtxtbody("	mov es,bp")
									addtxtbody("	mov ds,bp")
									addtxtbody("	call findstr")
									addtxtbody("	mov ecx,eax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov [bx],ecx")

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


'key file.creat,filename
					if par1=keywords(44) then
						errorssi=44
						if par(44)=separete.length then

									addtxtbody("	mov dx,L"+(trim(iii+9000)))
									addtxtbody("	mov ah,0x3c")
									addtxtbody("	mov cx,0")
									addtxtbody("	int 0x21")
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

									addtxtbody("	mov dx,L"+(trim(iii+9000)))
									addtxtbody("	mov ah,0x3d")
									addtxtbody("	mov al,2")
									addtxtbody("	int 0x21")
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	xor edx,edx")
									addtxtbody("	mov dx,ax")
									addtxtbody("	mov [bx],edx")
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

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	mov bx,ax")
									addtxtbody("	mov al,2")
									addtxtbody("	mov ah,0x3e")
									addtxtbody("	int 0x21")
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


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	mov di,ax")
									addtxtbody("	call WRITE32")
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


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov esi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtxtbody("	mov ecx,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	mov di,ax")
									addtxtbody("	call READ32")
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

'key file.chain,filename .com to chain control 
					if par1=keywords(79) then
						errorssi=79
						if par(79)=separete.length then


									addtxtbody("	mov ax,0xffff")
									addtxtbody("	mov sp,ax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ss,ax")
									addtxtbody("	mov ax,0")
									addtxtbody("	push ax")
									addtxtbody("	mov ax,0x100")
									addtxtbody("	push ax")
									addtxtbody("	mov ax,0x80")
									addtxtbody("	push ax")
									addtxtbody("	mov di,0x80")
									addtxtbody("	mov si,chain")
									addtxtbody("	mov cx,0x60")
									addtxtbody("	call memcopy")
									addtxtbody("	mov dx,L"+(trim(iii+9000)))
									addtxtbody("	mov ah,0x3d")
									addtxtbody("	mov al,2")
									addtxtbody("	int 0x21")
									addtxtbody("	jc LJMP"+trim(str(iii+9000)))
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")
									addtxtbody("	mov bx,65298")
									addtxtbody("	mov [bx],ax")
									addtxtbody("	ret")
									addtxtbody("LJMP"+trim(str(iii+9000))+":")
									addtxtbody("	pop ax")
									addtxtbody("	pop ax")
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


									addtxtbody("	mov ax,0xffff")
									addtxtbody("	mov sp,ax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ss,ax")
									addtxtbody("	mov ax,0")
									addtxtbody("	push ax")
									addtxtbody("	mov dx,L"+(trim(iii+9000)))
									addtxtbody("	mov ah,0x3d")
									addtxtbody("	mov al,2")
									addtxtbody("	int 0x21")
									addtxtbody("	jc LJMP"+trim(str(iii+9000)))
									addbody("L"+trim(str(iii+9000))+" db '"+separete(1)+"',0,0,0,'$'")
									addbody("LVAR"+trim(str(iii+9000))+" dw 0,0,0")
									addtxtbody("	mov bx,LVAR"+trim(str(iii+9000)))
									addtxtbody("	mov [bx],ax")
									addtxtbody("	mov si,ax")
									addtxtbody("	jmp LJMPS"+trim(str(iii+9000)))
									addtxtbody("LJMP"+trim(str(iii+9000))+":")
									addtxtbody("	xor ax,ax")
									addtxtbody("	int 0x21")
									addtxtbody("LJMPS"+trim(str(iii+9000))+":")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov bx,0x1000")
									addtxtbody("	add ax,bx")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov dx,0x0")
									addtxtbody("	mov cx,65530")
									addtxtbody("	mov bx,si")
									addtxtbody("	mov ah,0x3f")
									addtxtbody("	int 0x21")
									addtxtbody("	mov bx,si")
									addtxtbody("	mov al,2")
									addtxtbody("	mov ah,0x3e")
									addtxtbody("	int 0x21")
									addtxtbody("	mov ax,ds")
									addtxtbody("	mov dx,16")
									addtxtbody("	add dx,ax")
									addtxtbody("	mov bx,0x0e")
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	add ax,dx")
									addtxtbody("	add ax,bx")
									addtxtbody("	mov ss,ax")
									addtxtbody("	mov bx,0x10")
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	mov sp,ax")
									addtxtbody("	mov bx,0x16")
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	mov bx,16")
									addtxtbody("	add ax,dx")
									addtxtbody("	add ax,bx")
									addtxtbody("	push ax")
									addtxtbody("	mov bx,0x14")
									addtxtbody("	mov ax,[bx]")
									addtxtbody("	push ax")
									addtxtbody("	mov ax,ds")
									addtxtbody("	mov bx,16")
									addtxtbody("	add ax,bx")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov es,ax")
									addtxtbody("	mov ax,cs")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov cx,0x80")
									addtxtbody("	mov si,0")
									addtxtbody("	mov di,si")
									addtxtbody("	call memcopy")
									addtxtbody("	mov ax,es")
									addtxtbody("	mov ds,ax")
									addtxtbody("	mov cx,0xf000")
									addtxtbody("	retf")
									addtxtbody("	ret")
									errorssi=-1
									errorss=0

								
						else
									iii=1+iii
									goto errorhandler
						end if
												
						goto allkey
					end if 

'key cicle,cicles
					if par1=keywords(81) then
						errorssi=81
						if par(81)=separete.length then

							tc=ucase(trim(separete(1)))

							bbb=findvar(tc)
							if bbb<>-1 and tc<>"" and bbb1<>-1 then


								if varstype(bbb)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov eax,[bx]")
									addtxtbody("	call cicle")

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


'key memory.set ,var,number size
					if par1=keywords(89) then 
						errorssi=89

							tc=ucase(trim(separete(1)))
							tc1=ucase(trim(separete(2)))

							bbb=findvar(tc)
							bbb1=findvar(tc1)
							if bbb<>-1 and tc<>"" and bbb1<>-1 then


								if varstype(bbb)=1 and varstype(bbb1)=6 then	 

									addtxtbody("	mov di,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov si,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov eax,[si]")
									addtxtbody("	mov [di],eax")
									addtxtbody("	")

									errorssi=-1
									errorss=0
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
			vvv=tt + txtbody + t+chr(13)+chr(10)+"endf db 0 "+chr(13)+chr(10)
	
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



private sub addtxtbody(name as string)

		txtbody=txtbody+name+chr(13)+chr(10)

end sub



private sub addtail(name as string)

		tt=tt+name+chr(13)+chr(10)

end sub

private function addlabel(name as string,state as integer,address as integer,definer as integer)as integer
	labelss(labelindex)=name
	labeladdress(labelindex)=address
	labelstate(labelindex)=state
	labeldefined(labelindex)=definer
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

			txtbody=""
			addtxtbody("; txt body")				
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
		addkey ("timer.cicle",2)
		addkey ("memory",3)
		addkey ("fillstep",5)
		addkey ("color",2)
		addkey ("vline",5) 'key 85
		addkey ("nosound",1) 'key 86
		addkey ("sound",2) 'key 87
		addkey ("beep",1) 'key 88
		addkey ("memory.set",3) 'key 89


'code head
			t1=""
			addcode ("")
			addcode (";end of body")
			addcode ("exit:")
			addcode ("      mov si,rreservemem")
			addcode ("      mov eax,[si]")
			addcode ("	mov ax,0")
			addcode ("	mov ds,ax")
			addcode ("      mov ebx,180004h") 
			addcode ("      mov [ebx],eax")
			addcode ("	mov ax,cs")
			addcode ("	mov ds,ax")
			addcode ("	mov ax,0ffffh")
			addcode ("	mov sp,ax")
			addcode ("	mov ax,cs")
			addcode ("	mov ss,ax")
			addcode ("	xor ax,ax")
			addcode ("	push ax")
			addcode ("	xor ax,ax")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("ret")
			addcode ("len32:")
			addcode ("          push ebx                ")
			addcode ("          push ecx                ")
			addcode ("          push edx                ")
			addcode ("          push esi                ")
			addcode ("          push edi                ")
			addcode ("          push ebp                ")
			addcode ("          push ds                ")
			addcode ("          mov bp,0                ")
			addcode ("          mov ds,bp")
			addcode ("	    mov ecx,0")
			addcode ("len321:")
			addcode ("	    ds")
			addcode ("	    mov al,[esi]")
			addcode ("	    cmp al,0")
			addcode ("	    jz len323")
			addcode ("	    inc esi")
			addcode ("	    inc ecx")
			addcode ("	    jmp len321")
			addcode ("len323:")				
			addcode ("		mov eax,ecx")				
			addcode ("                    pop ds          ")      
			addcode ("                    pop ebp         ")       
			addcode ("                    pop edi         ")       
			addcode ("                    pop esi         ")       
			addcode ("                    pop edx         ")       
			addcode ("                    pop ecx         ")        
			addcode ("                    pop ebx         ")       
			addcode ("	ret")
			addcode ("ret")
			addcode ("strcat:")
			addcode ("	mov ax,0")
			addcode ("	mov ds,ax")
			addcode ("	mov ah,0")
			addcode ("strcat2:")
			addcode ("	mov al,[edi]")
			addcode ("	cmp al,ah")
			addcode ("	jz strcat3")
			addcode ("	inc edi")
			addcode ("	jmp strcat2")
			addcode ("strcat3:")
			addcode ("	mov al,[esi]")
			addcode ("	mov [edi],al")
			addcode ("	cmp al,ah")
			addcode ("	jz strcat4")
			addcode ("	inc esi")
			addcode ("	inc edi")
			addcode ("	jmp strcat3")
			addcode ("strcat4:")
			addcode ("	mov ax,cs")
			addcode ("	mov ds,ax")
			addcode ("	ret")
			addcode ("COPYMEM32:")
			addcode ("          push eax                ")
			addcode ("          push ebx                ")
			addcode ("          push ecx                ")
			addcode ("          push edx                ")
			addcode ("          push esi                ")
			addcode ("          push edi                ")
			addcode ("          push ebp                ")
			addcode ("          push ds                ")
			addcode ("          mov bp,0                ")
			addcode ("          mov ds,bp")
			addcode ("          cmp edx,0")
			addcode ("          JZ COPYMEM326")
			addcode ("          COPYMEM3211:")
			addcode ("          cmp ecx,0")
			addcode ("          JZ COPYMEM326")
			addcode ("          COPYMEM321:")
			addcode ("                    ds")
			addcode ("                    mov al,[esi]")
			addcode ("                    ds")
			addcode ("                    mov [edi],al")
			addcode ("                    clc             ")   
			addcode ("                    add edi,edx")
			addcode ("                    inc esi         ")       
			addcode ("                    dec ecx         ")       
			addcode ("                    jnz COPYMEM321")
			addcode ("                    COPYMEM326:")
			addcode ("                    pop ds          ")      
			addcode ("                    pop ebp         ")       
			addcode ("                    pop edi         ")       
			addcode ("                    pop esi         ")       
			addcode ("                    pop edx         ")       
			addcode ("                    pop ecx         ")        
			addcode ("                    pop ebx         ")       
			addcode ("                    pop eax         ")       
			addcode ("                    RET             ")   
			addcode ("MEM32:                ")
			addcode ("          push esi                ")
			addcode ("          and eax,0ffffh")
			addcode ("          clc                ")
			addcode ("          shl eax,4")
			addcode ("          and esi,0ffffh")
			addcode ("          clc                 ")
			addcode ("          add eax,esi")
			addcode ("          pop esi                ")
			addcode ("          RET                ")
			addcode ("MOVEMEM32:")
			addcode ("          push eax                ")
			addcode ("          push ebx                ")
			addcode ("          push ecx                ")
			addcode ("          push edx                ")
			addcode ("          push esi                ")
			addcode ("          push edi                ")
			addcode ("          push ebp                ")
			addcode ("          push ds                ")
			addcode ("          mov bp,0                ")
			addcode ("          mov ds,bp")
			addcode ("          MOVEMEM3211:")
			addcode ("          cmp ecx,0")
			addcode ("          JZ MOVEMEM326")
			addcode ("          MOVEMEM321:")
			addcode ("                    ds")
			addcode ("                    mov al,[esi]")
			addcode ("                    ds")
			addcode ("                    mov [edi],al")
			addcode ("                    dec edi")
			addcode ("                    dec esi         ")       
			addcode ("                    dec ecx         ")       
			addcode ("                    jnz MOVEMEM321")
			addcode ("                    MOVEMEM326:")
			addcode ("                    pop ds          ")      
			addcode ("                    pop ebp         ")       
			addcode ("                    pop edi         ")       
			addcode ("                    pop esi         ")       
			addcode ("                    pop edx         ")       
			addcode ("                    pop ecx         ")        
			addcode ("                    pop ebx         ")       
			addcode ("                    pop eax         ")       
			addcode ("                    RET             ")   
			addcode ("GOTOXY:                ")
			addcode ("          push ebx                ")
			addcode ("          push ecx                ")
			addcode ("          push edx                ")
			addcode ("          push esi                ")
			addcode ("          push edi                ")
			addcode ("          push ebp                ")
			addcode ("          mov si,ax")
			addcode ("          mov di,bx")
			addcode ("          and si,0fffh")
			addcode ("          and di,0fffh")
			addcode ("          xor cx,cx")
			addcode ("          xor dx,dx")
			addcode ("          mov ax,si")
			addcode ("          mov bx,2                ")
			addcode ("          clc                ")
			addcode ("          mul bx                ")
			addcode ("          mov si,ax")
			addcode ("          mov ax,di")
			addcode ("          mov bx,160")
			addcode ("          clc                ")
			addcode ("          mul bx                ")
			addcode ("          mov bx,si")
			addcode ("          clc                ")
			addcode ("          add ax,bx")
			addcode ("          and eax,0ffffh")
			addcode ("          mov ebx,0b8000h")
			addcode ("          clc                ")
			addcode ("          add eax,ebx")
			addcode ("          pop ebp                ")
			addcode ("          pop edi                ")
			addcode ("          pop esi                ")
			addcode ("          pop edx                ")
			addcode ("          pop ecx                 ")
			addcode ("          pop ebx                ")
			addcode ("          RET                ")
			addcode ("PRINT32:                ")
			addcode ("          push eax             ")   
			addcode ("          push ebx             ")   
			addcode ("          push ecx             ")   
			addcode ("          push edx             ")   
			addcode ("          push esi             ")   
			addcode ("          push edi             ")   
			addcode ("          push ebp             ")   
			addcode ("          cmp ecx,0")
			addcode ("          JZ PRINT3213")
			addcode ("          push esi             ")   
			addcode ("          mov si,x             ")   
			addcode ("          cs             ")   
			addcode ("          mov al,[si]             ")   
			addcode ("          cs             ")   
			addcode ("          mov bl,[si+1]             ")   
			addcode ("          pop esi             ")
   			addcode ("          and ax,0ffh")
			addcode ("          and bx,0ffh")
			addcode ("          call GOTOXY")
			addcode ("          mov edi,eax")
			addcode ("          cmp ecx,255")
			addcode ("          JB PRINT3212")
			addcode ("          mov ebx,255")
			addcode ("          PRINT3212:")
			addcode ("          mov edx,2")
			addcode ("          call COPYMEM32")
			addcode ("          push esi             ")   
			addcode ("          mov si,x             ")   
			addcode ("          cs             ")   				
			addcode ("          mov al,[si]          ")
			addcode ("          cs             ")   				   
			addcode ("          mov bl,[si+1]        ")   
			addcode ("          pop esi             ")   
			addcode ("          and ax,0ffh")
			addcode ("          and bx,0ffh")
			addcode ("          mov si,bx")
			addcode ("          clc                ")
			addcode ("			")
			addcode ("          add ax,cx")
			addcode ("          cmp ax,80")
			addcode ("          JB PRINT328")
			addcode ("          mov bx,80")
			addcode ("          sub ax,bx")
			addcode ("          xor dx,dx")
			addcode ("          xor cx,cx")
			addcode ("          mov bx,80")
			addcode ("          clc                ")
			addcode ("          div bx               ") 
			addcode ("          clc                ")
			addcode ("          add ax,si")
			addcode ("          cmp ax,24")
			addcode ("          JB PRINT328")
			addcode ("          mov ax,24")
			addcode ("          PRINT328:")
			addcode ("          push esi             ")   
			addcode ("          mov si,x             ")   
			addcode ("          cs             ")   				
			addcode ("          mov [si+1],al        ")   
			addcode ("          cs             ")   				
			addcode ("          mov [si],dl ")
			addcode ("          pop esi             ")   
			addcode ("          PRINT3213:")
			addcode ("          pop ebp              ")  
			addcode ("          pop edi              ")  
			addcode ("          pop esi              ")  
			addcode ("          pop edx              ")  
			addcode ("          pop ecx              ")   
			addcode ("          pop ebx              ")  
			addcode ("          pop eax              ")  
			addcode ("          RET                ")
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
	               	addcode ("echo:")
			addcode ("          push ax")
			addcode ("          push bx")              
			addcode ("          push cx")                
			addcode ("          push dx")                
			addcode ("          push di")                
			addcode ("          push si")                
			addcode ("          push bp")                
			addcode ("          push es")                
			addcode ("          mov ax,cs")
			addcode ("          mov es,ax")
			addcode ("          xchg si,bp") 
			addcode ("          mov bx,bp")
			addcode ("          cs")
			addcode ("          mov cl,[bx]")
			addcode ("          inc bp")                
			addcode ("          and cx,0ffh")
			addcode ("          mov bx,x")
			addcode ("          cs")
			addcode ("          mov dx,[bx]")
			addcode ("          mov bx,color")
			addcode ("          cs")
			addcode ("          mov al,[bx]")
			addcode ("          mov bl,al")
			addcode ("          mov bh,0")   
			addcode ("          mov al,0")                
			addcode ("          mov ah,13h")
			addcode ("          int 10h")                
			addcode ("          pop es")                
			addcode ("          pop bp")                
			addcode ("          pop si")                
			addcode ("          pop di")                
			addcode ("          pop dx")                
			addcode ("          pop cx")                
			addcode ("          pop bx")                
			addcode ("          pop ax")                
			addcode ("          RET")   
			addcode ("val:")
			addcode ("		mov ax,0")
			addcode ("		mov ds,ax")
			addcode ("		mov ecx,0")
			addcode ("		mov edx,0")
			addcode ("		mov ebx,1")
			addcode ("		mov eax,0")
			addcode ("val2:")
			addcode ("		mov al,[esi]")
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
			addcode ("		cmp cl,9")
			addcode ("		jz val55")
			addcode ("		inc cl")
			addcode ("		inc esi")
			addcode ("		jmp val2")
			addcode ("val55:")
			addcode ("		dec cl")
			addcode ("val5:")
			addcode ("		dec esi")
			addcode ("val6:")
			addcode ("		push ecx")
			addcode ("		push edx")
			addcode ("		xor eax,eax")
			addcode ("		mov al,[esi]")
			addcode ("		clc")
			addcode ("		sub al,48")
			addcode ("		xor ecx,ecx")
			addcode ("		xor edx,edx")
			addcode ("		push ebx")
			addcode ("		imul ebx")
			addcode ("		xor ecx,ecx")
			addcode ("		xor edx,edx")
			addcode ("		pop ebx")
			addcode ("		push eax")
			addcode ("		mov eax,10")
			addcode ("		imul ebx")
			addcode ("		mov ebx,eax")
			addcode ("		pop eax")
			addcode ("		pop edx")
			addcode ("		pop ecx")
			addcode ("		clc")
			addcode ("		add edx,eax")
			addcode ("		dec esi")
			addcode ("		dec cl")
			addcode ("		cmp cl,0")
			addcode ("		jz val40")
			addcode ("		jmp val6")
			addcode ("val40:")
			addcode ("		mov eax,edx")
			addcode ("		mov bp,cs")
			addcode ("		mov ds,bp")
			addcode ("		mov [di],eax")
			addcode ("ret")
			addcode ("STR32:     ")           
			addcode ("        push eax                ")
			addcode ("        push ebx                ")
			addcode ("        push ecx                ")
			addcode ("        push edx                ")
			addcode ("        push edi                ")
			addcode ("        push esi                ")
			addcode ("        push ebp                ")
			addcode ("        push ds                ")
			addcode ("        mov eax,[si]")
			addcode ("        mov ebp,0")			
			addcode ("        mov ds,bp                ")
			addcode ("        mov ebp,1000000000")
			addcode ("        STR321:                ")
			addcode ("                  xor edx,edx")
			addcode ("                  xor ecx,ecx")
			addcode ("                  mov ebx,ebp")
			addcode ("                  clc            ")     
			addcode ("                  div ebx        ")        
			addcode ("                  mov esi,edx")
			addcode ("                  mov ah,'0'")
			addcode ("                  clc            ")    
			addcode ("                  add al,ah")
			addcode ("                  mov [edi],al")
			addcode ("                  inc edi         ")       
			addcode ("                  mov eax,ebp")
			addcode ("                  xor edx,edx")
			addcode ("                  xor ecx,ecx")
			addcode ("                  mov ebx,10")
			addcode ("                  clc            ")    
			addcode ("                  div ebx        ")        
			addcode ("                  mov ebp,eax")
			addcode ("                  mov eax,esi")
			addcode ("                  cmp ebp,0")
			addcode ("                  JNZ STR321")
			addcode ("                          ")
			addcode ("          pop ds                ")
			addcode ("          pop ebp                ")
			addcode ("          pop esi                ")
			addcode ("          pop edi                ")
			addcode ("          pop edx                ")
			addcode ("          pop ecx                ")
			addcode ("          pop ebx                ")
			addcode ("          pop eax                ")
			addcode ("          RET          ")
			addcode ("start:")
			addcode ("		;start stack 64k")
			addcode ("	mov ax,cs")
			addcode ("	mov cx,0x1000")
			addcode ("	add ax,cx")
			addcode ("	mov ss,ax")
			addcode ("	mov ax,0xffff")
			addcode ("	mov sp,ax")
			addcode ("	xor ax,ax")
			addcode ("	push ax")
			addcode ("		;end stack 64k")
			addcode ("		;start alocate")
			addcode ("	mov bx,L18")
			addcode ("	mov ax,endf")
			addcode ("	mov cx,8")
			addcode ("	add ax,cx")
			addcode ("	mov [bx],ax")
			addcode ("		;end alocate")
			addcode ("		;start randomize")
			addcode ("	call timer")
			addcode ("	mov bx,L20")
			addcode ("	xor cx,cx")
			addcode ("	mov cl,al")
			addcode ("	mov ax,257")
			addcode ("	add ax,cx")
			addcode ("	mov [bx],ax")
			addcode ("		;end randomize")
			addcode ("      xor ax,ax")
			addcode ("      mov ds,ax")
			addcode ("      mov edx,1234567890")
			addcode ("      mov ebx,180000h") 
			addcode ("      mov eax,[ebx]")
			addcode ("      cmp eax,edx")
			addcode ("      jz reservemem")
			addcode ("      mov eax,4")
			addcode ("      clc")
			addcode ("      add ebx,eax")
			addcode ("      mov eax,100h")
			addcode ("      clc")                
			addcode ("      add eax,ebx")
			addcode ("      mov [ebx],eax")
			addcode ("      mov eax,1234567890")
			addcode ("      mov ebx,180000h") 
			addcode ("      mov [ebx],eax")
			addcode ("reservemem:")
			addcode ("      mov ebx,180004h") 
			addcode ("      mov eax,[ebx]")
			addcode ("      mov si,rreservemem")
			addcode ("      cs")
			addcode ("      mov [si],eax")
			addcode ("      mov ax,cs")
			addcode ("      mov ds,ax")
			addcode ("")
			addcode ("jmp mains")
			addcode ("RESERVES:")
			addcode ("          push ebx")
			addcode ("          push ecx")                
			addcode ("          push edx")                
			addcode ("          push edi")                
			addcode ("          push esi")                
			addcode ("          push ebp")                
			addcode ("          push ds ")               
			addcode ("          push es ")               
			addcode ("          JMP RESERVES2")
			addcode ("          RESERVES2:")
			addcode ("          xor ax,ax")
			addcode ("          mov ds,ax")
			addcode ("          mov ebx,180004h")
			addcode ("          mov eax,[ebx]")
			addcode ("")
			addcode ("          mov edx,eax")
			addcode ("          clc               ") 
			addcode ("          add edx,ecx")
			addcode ("          add edx,4")
			addcode ("          mov [ebx],edx")
			addcode ("          mov ebx,eax")
			addcode ("          mov esi,eax")
			addcode ("          mov [ebx],ecx")
			addcode ("          mov eax,esi")
			addcode ("          clc")
			addcode ("          add eax,4")
			addcode ("          clc")
			addcode ("          add eax,ecx")
			addcode ("          dec eax")
			addcode ("          mov ebx,eax")
			addcode ("          mov al,0")
			addcode ("          mov [ebx],al")
			addcode ("          mov eax,esi")
			addcode ("          clc")
			addcode ("          add eax,4")
			addcode ("          pop es")                
			addcode ("          pop ds")                
			addcode ("          pop ebp")                
			addcode ("          pop esi")                
			addcode ("          pop edi")                
			addcode ("          pop edx")                
			addcode ("          pop ecx")                
			addcode ("          pop ebx")                
			addcode ("                   ")       
			addcode ("          RET     ")           
			addcode ("FILL32:             ")   
			addcode ("          push eax  ")              
			addcode ("          push ebx  ")              
			addcode ("          push ecx  ")              
			addcode ("          push edx  ")              
			addcode ("          push esi  ")              
			addcode ("          push edi  ")              
			addcode ("          push ebp  ")              
			addcode ("          push ds   ")             
			addcode ("          mov bp,0  ")              
			addcode ("          mov ds,bp")
			addcode ("          cmp edx,0")
			addcode ("          JNZ FILL3211")
			addcode ("          inc edx       ")         
			addcode ("          FILL3211:")
			addcode ("          FILL321:      ")          
			addcode ("                    mov [edi],al")
			addcode ("                    clc ")               
			addcode ("                    add edi,edx")
			addcode ("                    dec ecx      ")          
			addcode ("                    JNZ FILL321")
			addcode ("          pop ds                ")
			addcode ("          pop ebp                ")
			addcode ("          pop edi                ")
			addcode ("          pop esi                ")
			addcode ("          pop edx                ")
			addcode ("          pop ecx                ") 
			addcode ("          pop ebx                ")
			addcode ("          pop eax                ")
			addcode ("          RET                ")
			addcode ("scr:")
			addcode ("	mov ebx,255")
			addcode ("	cmp eax,ebx")
			addcode ("	ja scr1")
			addcode ("	mov ah,0")
			addcode ("	int 10h")
			addcode ("	ret")
			addcode ("scr1:")
			addcode ("	mov bx,ax")
			addcode ("	mov ax,4f02h")
			addcode ("	int 10h")
			addcode ("	ret")
			addcode ("setvideo:")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov dx,0")
			addcode ("	mov esi,140000h")
			addcode ("	mov ds,dx")
			addcode ("	mov es,dx")
			addcode ("setvideo2:")
			addcode ("	mov ax,4f05h")
			addcode ("	mov bx,0")
			addcode ("	int 10h")
			addcode ("	inc dx")
			addcode ("setvideo3:")
			addcode ("	mov edi,0a0000h")
			addcode ("	mov ecx,4000h")
			addcode ("	call memcopyd")
			addcode ("	cmp dx,4")
			addcode ("	jb setvideo2")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("	ret")
			addcode ("hline32:")
			addcode ("	mov si,hlinex")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb hline32xxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hline32xxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hline32xxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hline32xxh:")
			addcode ("	mov si,hliney")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb hline32yyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hline32yyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hline32yyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hline32yyh:")
			addcode ("	mov si,hlinex1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb hline32xxxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hline32xxxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hline32xxxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hline32xxxh:")
			addcode ("	mov si,hlinex")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,hlinex1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja hline32end")
			addcode ("	jz hline32end")
			addcode ("	mov si,hliney")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	mov ebx,640")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mul ebx")
			addcode ("	mov ebx,140000h")
			addcode ("	add eax,ebx")
			addcode ("	mov si,hlinex")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	add eax,ebx")
			addcode ("	mov edi,eax")
			addcode ("	mov si,hlinex1")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	sub eax,ebx")
			addcode ("	mov ecx,eax")
			addcode ("	mov si,hlinecolor")
			addcode ("	mov al,[si]")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov bp,0")
			addcode ("	mov ds,bp")
			addcode ("	mov es,bp")
			addcode ("	call memfill")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("hline32end:")
			addcode ("	ret")
			addcode ("vline32:")
			addcode ("	mov si,vlinex")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb vline32xxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("vline32xxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg vline32xxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("vline32xxh:")
			addcode ("	mov si,vliney")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb vline32yyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("vline32yyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg vline32yyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("vline32yyh:")
			addcode ("	mov si,vliney1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb vline32xxxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("vline32xxxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg vline32xxxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("vline32xxxh:")
			addcode ("	mov si,vliney")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,vliney1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja vline32end")
			addcode ("	jz vline32end")
			addcode ("	mov si,vliney")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	mov ebx,640")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mul ebx")
			addcode ("	mov ebx,140000h")
			addcode ("	add eax,ebx")
			addcode ("	mov si,vlinex")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	add eax,ebx")
			addcode ("	mov edi,eax")
			addcode ("	mov si,vliney")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	mov si,vliney1")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	sub eax,ebx")
			addcode ("	mov ecx,eax")
			addcode ("	mov si,vlinecolor")
			addcode ("	mov al,[si]")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov bp,0")
			addcode ("	mov ds,bp")
			addcode ("	mov es,bp")
			addcode ("	mov dx,640")
			addcode ("	call FILL32")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("vline32end:")
			addcode ("	ret")
			addcode ("box32:")
			addcode ("	mov si,boxx")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb box32xxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("box32xxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg box32xxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("box32xxh:")
			addcode ("	mov si,boxy")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb box32yyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("box32yyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg box32yyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("box32yyh:")
			addcode ("	mov si,boxx1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb box32xxxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("box32xxxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg box32xxxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("box32xxxh:")
			addcode ("	mov si,boxy1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb box32yyyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("box32yyyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg box32yyyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("box32yyyh:")
			addcode ("	mov si,boxx")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxx1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja box32end")
			addcode ("	jz box32end")
			addcode ("	mov si,boxy")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxy1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja box32end")
			addcode ("	jz box32end")
			addcode ("	mov si,boxy")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxy1")
			addcode ("	mov bx,[si]")
			addcode ("	sub bx,ax")
			addcode ("	mov [si],bx")
			addcode ("	cmp bx,0")
			addcode ("	jz box32end")
			addcode ("	mov si,boxy")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	mov ebx,640")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mul ebx")
			addcode ("	mov ebx,140000h")
			addcode ("	add eax,ebx")
			addcode ("	mov si,boxx")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	add eax,ebx")
			addcode ("	mov edi,eax")
			addcode ("	mov si,boxx1")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	sub eax,ebx")
			addcode ("	mov ecx,eax")
			addcode ("	mov si,boxcolor")
			addcode ("	mov al,[si]")
			addcode ("	mov edx,1")
			addcode ("	mov si,boxy1")
			addcode ("	mov bx,[si]")
			addcode ("	mov si,bx")
			addcode ("	mov ebx,640")
			addcode ("	mov bp,0")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov ds,bp")
			addcode ("	mov es,bp")
			addcode ("box32loop:")
			addcode ("	push edi")
			addcode ("	push ecx")
			addcode ("	call memfill")
			addcode ("	pop ecx")
			addcode ("	pop edi")
			addcode ("	add edi,ebx")
			addcode ("	dec si")
			addcode ("	cmp si,0")
			addcode ("	jnz box32loop")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("box32end:")
			addcode ("	ret")
			addcode ("boxd32:")
			addcode ("	mov si,boxdx")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb boxd32xxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32xxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg boxd32xxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32xxh:")
			addcode ("	mov si,boxdy")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb boxd32yyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32yyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg boxd32yyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32yyh:")
			addcode ("	mov si,boxdx1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb boxd32xxxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32xxxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg boxd32xxxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32xxxh:")
			addcode ("	mov si,boxdy1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb boxd32yyyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32yyyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg boxd32yyyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("boxd32yyyh:")
			addcode ("	mov si,boxdx")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxdx1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja boxd32end")
			addcode ("	jz boxd32end")
			addcode ("	mov si,boxdy")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxdy1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja boxd32end")
			addcode ("	jz boxd32end")
			addcode ("	mov si,boxdy")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,boxdy1")
			addcode ("	mov bx,[si]")
			addcode ("	sub bx,ax")
			addcode ("	mov [si],bx")
			addcode ("	cmp bx,0")
			addcode ("	jz boxd32end")
			addcode ("	mov si,boxdy")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	mov ebx,640")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mul ebx")
			addcode ("	mov ebx,140000h")
			addcode ("	add eax,ebx")
			addcode ("	mov si,boxdx")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	add eax,ebx")
			addcode ("	mov edi,eax")
			addcode ("	mov si,boxdx1")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	sub eax,ebx")
			addcode ("	mov ecx,eax")
			addcode ("	mov si,boxdcolor")
			addcode ("	mov al,[si]")
			addcode ("	mov edx,1")
			addcode ("	mov si,boxdy1")
			addcode ("	mov bx,[si]")
			addcode ("	mov si,bx")
			addcode ("	mov ebx,640")
			addcode ("	push eax")
			addcode ("	push ebx")
			addcode ("	push edx")
			addcode ("	mov eax,ecx")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mov ebx,4")
			addcode ("	div ebx")
			addcode ("	mov ecx,eax")
			addcode ("	pop edx")
			addcode ("	pop ebx")
			addcode ("	pop eax")
			addcode ("	mov bp,0")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov ds,bp")
			addcode ("	mov es,bp")
			addcode ("boxd32loop:")
			addcode ("	push edi")
			addcode ("	push ecx")
			addcode ("	call memfilld")
			addcode ("	pop ecx")
			addcode ("	pop edi")
			addcode ("	add edi,ebx")
			addcode ("	dec si")
			addcode ("	cmp si,0")
			addcode ("	jnz boxd32loop")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("boxd32end:")
			addcode ("	ret")
			addcode ("byteEAX:")
			addcode ("push ebx")
			addcode ("mov ah,al")
			addcode ("mov bx,ax")
			addcode ("shl ebx,16")
			addcode ("or eax,ebx")
			addcode ("pop ebx")	
			addcode ("ret")
			addcode ("memcopyd:")
			addcode ("cmp ecx,0")
			addcode ("jnz memcopyd2")
			addcode ("ret")
			addcode ("memcopyd2:")
			addcode ("cld")
			addcode ("memcopyd10 db 66h,67h")
			addcode ("rep movsd")
			addcode ("ret")
			addcode ("memford:")
			addcode ("cmp ecx,0")
			addcode ("jnz memford2")
			addcode ("ret")
			addcode ("memford2:")
			addcode ("std")
			addcode ("memford10 db 66h,67h")
			addcode ("rep movsb")
			addcode ("cld")
			addcode ("ret")
			addcode ("memcopy:")
			addcode ("cmp ecx,0")
			addcode ("jnz memcopy2")
			addcode ("ret")
			addcode ("memcopy2:")
			addcode ("cld")
			addcode ("memcopy10 db 66h,67h")
			addcode ("rep movsb")
			addcode ("ret")
			addcode ("memfilld:")
			addcode ("	call byteEAX")
			addcode ("	cmp ecx,0")
			addcode ("	jz memfilld3")
			addcode ("memfilld2:")
			addcode ("cld")
			addcode ("memfilld10 db 66h,67h")
			addcode ("rep stosd")
			addcode ("memfilld3:")
			addcode ("ret")
			addcode ("memfill:")
			addcode ("	cmp ecx,0")
			addcode ("	jz memfill3")
			addcode ("memfill2:")
			addcode ("cld")
			addcode ("memfill10 db 66h,67h")
			addcode ("rep stosb")
			addcode ("memfill3:")
			addcode ("ret")
			addcode ("hlined32:")
			addcode ("	mov si,hlinex")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb hlined32xxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32xxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hlined32xxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32xxh:")
			addcode ("	mov si,hliney")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,400")
			addcode ("	cmp ax,bx")
			addcode ("	jb hlined32yyl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32yyl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hlined32yyh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32yyh:")
			addcode ("	mov si,hlinex1")
			addcode ("	mov ax,[si]")
			addcode ("	mov bx,640")
			addcode ("	cmp ax,bx")
			addcode ("	jb hlined32xxxl")
			addcode ("	dec bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32xxxl:")
			addcode ("	mov bx,-1")
			addcode ("	cmp ax,bx")
			addcode ("	jg hlined32xxxh")
			addcode ("	inc bx")
			addcode ("	mov [si],bx")
			addcode ("hlined32xxxh:")
			addcode ("	mov si,hlinex")
			addcode ("	mov ax,[si]")
			addcode ("	mov si,hlinex1")
			addcode ("	mov bx,[si]")
			addcode ("	cmp ax,bx")
			addcode ("	ja hlined32end")
			addcode ("	jz hlined32end")
			addcode ("	mov si,hliney")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	mov ebx,640")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mul ebx")
			addcode ("	mov ebx,140000h")
			addcode ("	add eax,ebx")
			addcode ("	mov si,hlinex")
			addcode ("	xor ebx,ebx")
			addcode ("	mov bx,[si]")
			addcode ("	add eax,ebx")
			addcode ("	mov edi,eax")
			addcode ("	mov si,hlinex1")
			addcode ("	xor eax,eax")
			addcode ("	mov ax,[si]")
			addcode ("	sub eax,ebx")
			addcode ("	mov ecx,eax")
			addcode ("	mov si,hlinecolor")
			addcode ("	mov al,[si]")
			addcode ("	push eax")
			addcode ("	push ebx")
			addcode ("	push edx")
			addcode ("	mov eax,ecx")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	mov ebx,4")
			addcode ("	div ebx")
			addcode ("	mov ecx,eax")
			addcode ("	pop edx")
			addcode ("	pop ebx")
			addcode ("	pop eax")
			addcode ("	push ds")
			addcode ("	push es")
			addcode ("	mov bp,0")
			addcode ("	mov ds,bp")
			addcode ("	mov es,bp")
			addcode ("	call memfilld")
			addcode ("	pop es")
			addcode ("	pop ds")
			addcode ("hlined32end:")
			addcode ("	ret")
			addcode ("nosound:")
			addcode ("	mov dh,0fch")
			addcode ("	in al,61h")
			addcode ("	and al,dh")
			addcode ("	out 61h,al")
			addcode ("	ret")
			addcode ("sound:")
			addcode ("	mov ebx,eax")
			addcode ("	mov eax,1193181")
			addcode ("	mov ecx,0")
			addcode ("	mov edx,0")
			addcode ("	div ebx")
			addcode ("	mov bx,ax")
			addcode ("	mov dh,3")
			addcode ("	in al,61h")
			addcode ("	or al,dh")
			addcode ("	out 61h,al")
			addcode ("	mov al,0b6h")
			addcode ("	out 43h,al")
			addcode ("	mov al,bl")
			addcode ("	out 42h,al")
			addcode ("	mov al,bh")
			addcode ("	out 42h,al")
			addcode ("	ret")
			addcode ("memlen:")
			addcode ("mov edi,esi")
			addcode ("mov al,[esi]")
			addcode ("cmp al,0")
			addcode ("jz memlen22")
			addcode ("mov ecx,100000h")
			addcode ("mov al,0")
			addcode ("cld")
			addcode ("memlen10 db 66h,67h")
			addcode ("repne scasb")
			addcode ("je memlen11")
			addcode ("memlen22:")
			addcode ("mov ecx,0")
			addcode ("ret")
			addcode ("memlen11:")
			addcode ("mov ecx,edi")
			addcode ("sub ecx,esi")
			addcode ("ret")
			addcode ("memlower:")
			addcode ("cmp ecx,0")
			addcode ("jz memlower22")
			addcode ("mov edi,esi")
			addcode ("memlower20:")
			addcode ("memlower30 db 66h,67h")
			addcode ("lodsb")
			addcode ("cmp al,65")
			addcode ("jb memlower90")
			addcode ("cmp al,90")
			addcode ("ja memlower90")
			addcode ("or al,20h")
			addcode ("memlower90:")
			addcode ("memlower40 db 66h,67h")
			addcode ("stosb")
			addcode ("loop memlower20")
			addcode ("cld")
			addcode ("memlower10 db 66h,67h")
			addcode ("rep movsb")
			addcode ("memlower22:")
			addcode ("ret")
			addcode ("memhigth:")
			addcode ("cmp ecx,0")
			addcode ("jz memhigth22")
			addcode ("mov edi,esi")
			addcode ("memhigth20:")
			addcode ("memhigth30 db 66h,67h")
			addcode ("lodsb")
			addcode ("cmp al,97")
			addcode ("jb memhigth90")
			addcode ("cmp al,122")
			addcode ("ja memhigth90")
			addcode ("and al,223")
			addcode ("memhigth90:")
			addcode ("memhigth40 db 66h,67h")
			addcode ("stosb")
			addcode ("loop memhigth20")
			addcode ("cld")
			addcode ("memhigth10 db 66h,67h")
			addcode ("rep movsb")
			addcode ("memhigth22:")
			addcode ("ret")
			addcode ("findchr:")
			addcode ("cmp ecx,0")
			addcode ("jz findchr22")
			addcode ("mov edi,esi")
			addcode ("findchr30 db 66h,67h")
			addcode ("cld")
			addcode ("findchr10 db 66h,67h")
			addcode ("repne scasb")
			addcode ("je findchr20")
			addcode ("findchr22:")
			addcode ("mov eax,-1")
			addcode ("ret")
			addcode ("findchr20:")
			addcode ("mov eax,edi")
			addcode ("sub eax,esi")
			addcode ("dec eax")
			addcode ("ret")
			addcode ("comps:")
			addcode ("cmp ecx,0")
			addcode ("jz comps20")
			addcode ("comps30 db 66h,67h")
			addcode ("cld")
			addcode ("comps10 db 66h,67h")
			addcode ("repe cmpsb")
			addcode ("jecxz comps20")
			addcode ("mov ecx,2")
			addcode ("dec esi")
			addcode ("dec edi")
			addcode ("mov ax,0")
			addcode ("mov bx,0")
			addcode ("mov al,[esi]")
			addcode ("mov bl,[edi]")
			addcode ("cmp ax,bx")
			addcode ("ja comps21")
			addcode ("mov ecx,1")
			addcode ("comps21:")
			addcode ("mov eax,ecx")
			addcode ("ret")
			addcode ("comps20:")
			addcode ("mov eax,0")
			addcode ("ret")
			addcode ("findstr:")
			addcode ("push esi")
			addcode ("findstrs:")
			addcode ("mov al,[edi]")
			addcode ("mov bp,ax")
			addcode ("push edi")
			addcode ("push esi")
			addcode ("call memlen")
			addcode ("pop esi")
			addcode ("cmp ecx,0")
			addcode ("jz findstr223")
			addcode ("mov ax,bp")
			addcode ("call findchr")
			addcode ("cmp eax,-1")
			addcode ("jz findstr223")
			addcode ("mov esi,edi")
			addcode ("pop edi")
			addcode ("push esi")
			addcode ("push edi")
			addcode ("mov esi,edi")
			addcode ("call memlen")
			addcode ("pop edi")
			addcode ("pop esi")
			addcode ("cmp ecx,0")
			addcode ("jz findstr22")
			addcode ("push esi")
			addcode ("push edi")
			addcode ("dec esi")
			addcode ("call comps")
			addcode ("pop edi")
			addcode ("pop esi")
			addcode ("cmp eax,0")
			addcode ("jz findstr20")
			addcode ("jmp findstrs")
			addcode ("findstr222:")
			addcode ("pop esi")
			addcode ("findstr223:")
			addcode ("pop esi")
			addcode ("findstr22:")
			addcode ("mov eax,-1")
			addcode ("pop esi")
			addcode ("ret")
			addcode ("findstr20:")
			addcode ("mov edi,esi")
			addcode ("pop esi")
			addcode ("mov eax,edi")
			addcode ("sub eax,esi")
			addcode ("dec eax")
			addcode ("ret")
			addcode ("WRITE16:           ")     
			addcode ("          push bx                ")
			addcode ("          push dx                ")
			addcode ("          mov dx,si")
			addcode ("          mov bx,di")
			addcode ("          mov ah,40h")
			addcode ("          int 21h                ")
			addcode ("          pop dx                 ")
			addcode ("          pop bx                ")
			addcode ("          RET                ")
			addcode ("READ16:                ")
			addcode ("          push bx                ")
			addcode ("          push dx                ")
			addcode ("          mov dx,si")
			addcode ("          mov bx,di")
			addcode ("          mov ah,3fh")
			addcode ("          int 21h                ")
			addcode ("          pop dx                 ")
			addcode ("          pop bx                ")
			addcode ("          RET      ")

			addcode ("WRITE32:             ")   
			addcode ("          push eax   ")             
			addcode ("          push ebx   ")             
			addcode ("          push ecx   ")             
			addcode ("          push edx   ")             
			addcode ("          push esi   ")             
			addcode ("          push edi   ")             
			addcode ("          push ebp   ")             
			addcode ("          push ds    ")            
			addcode ("          push es    ")            
			addcode ("          mov bp,0   ")             
			addcode ("          mov ds,bp")
			addcode ("          mov es,bp")
                         
			addcode ("          WRITE321:")
                          
			addcode ("          cs")
			addcode ("          mov [write32addrs1],esi")
			addcode ("          cs")
			addcode ("          mov [write32counter1],ecx")
			addcode ("          cs")
			addcode ("          mov [write32f1],di")
			addcode ("          mov ax,0                ")
			addcode ("          cs")
			addcode ("          mov [write32seg2],ax")
			addcode ("          mov eax,ecx")
			addcode ("          cmp eax,0")
			addcode ("          JZ WRITE325")
                          
			addcode ("          xor edx,edx")
			addcode ("          xor ecx,ecx")
			addcode ("          mov ebx,0ffffh")
			addcode ("          clc                ")
			addcode ("          div ebx                ")
			addcode ("          cs")
			addcode ("          mov [write32counter3],eax")
			addcode ("          cs")
			addcode ("          mov [write32output],edx")
			addcode ("          mov ax,cs")
			addcode ("          mov bx,2000h")
			addcode ("          clc                ")
			addcode ("          add ax,bx")
			addcode ("          cs")
			addcode ("          mov [write32seg1],ax")
			addcode ("          mov si,0                ")
			addcode ("call MEM32")
			addcode ("          cs")
			addcode ("          mov [write32addrs2],eax")
			addcode ("          mov eax,0")
			addcode ("          cs")
			addcode ("          mov [write32counter2],eax")
			addcode ("          mov eax,0ffffh")
			addcode ("          cs")
			addcode ("          mov [write32size],eax")
			addcode ("          cs")
			addcode ("          mov eax,[write32counter3]")
			addcode ("          cmp eax,0")
			addcode ("          JZ WRITE323")
			addcode ("          WRITE322:")
			addcode ("          cs")
			addcode ("                    mov ax,[write32seg2]")
			addcode ("                    mov ds,ax")
			addcode ("          cs")
			addcode ("                    mov ecx,[write32size]")
			addcode ("          cs")
			addcode ("                    mov esi,[write32addrs1]")
			addcode ("          cs")
			addcode ("                    mov edi,[write32addrs2]")
			addcode ("                    mov edx,1")
			addcode ("          push eax")
			addcode ("          push ebx")
			addcode ("          push ecx")
			addcode ("          push edx")
			addcode ("          push esi")
			addcode ("          push edi")
			addcode ("          push ebp")
			addcode ("          push ds")
			addcode ("                    call memcopy")
			addcode ("          pop ds")
			addcode ("          pop ebp")
			addcode ("          pop edi")
			addcode ("          pop esi")
			addcode ("          pop edx")
			addcode ("          pop ecx")
			addcode ("          pop ebx")
			addcode ("          pop eax")
			addcode ("          cs")
			addcode ("                    mov ax,[write32seg1]")
			addcode ("                    mov ds,ax")
			addcode ("                    mov si,0                ")
			addcode ("          cs")
			addcode ("                    mov di,[write32f1]")
			addcode ("                    mov cx,0ffffh")
			addcode ("                    call WRITE16")
			addcode ("          cs")
			addcode ("                    mov eax,[write32addrs1]")
			addcode ("          cs")
			addcode ("                    mov ebx,[write32size] ")
			addcode ("                    clc                ")
			addcode ("                    add eax,ebx")
			addcode ("          cs")
			addcode ("                    mov [write32addrs1],eax")
			addcode ("          cs")
			addcode ("                    mov eax,[write32counter3]")
			addcode ("                    dec eax                ")
			addcode ("          cs")
			addcode ("                    mov [write32counter3],eax")
			addcode ("                    cmp eax,0")
			addcode ("                    JNZ WRITE322")
			addcode ("          WRITE323:")
			addcode ("          cs")
			addcode ("          cmp DWORD [write32output],0")
			addcode ("          JZ WRITE325")
			addcode ("          cs")
			addcode ("          mov ax,[write32seg2]")
			addcode ("          mov ds,ax")
			addcode ("          cs")
			addcode ("          mov ecx,[write32output]")
			addcode ("          cs")
			addcode ("          mov esi,[write32addrs1]")
			addcode ("          cs")
			addcode ("          mov edi,[write32addrs2]")
			addcode ("          mov edx,1")
			addcode ("          push eax")
			addcode ("          push ebx")
			addcode ("          push ecx")
			addcode ("          push edx")
			addcode ("          push esi")
			addcode ("          push edi")
			addcode ("          push ebp")
			addcode ("          push ds")
			addcode ("          call memcopy")
			addcode ("          pop ds")
			addcode ("          pop ebp")
			addcode ("          pop edi")
			addcode ("          pop esi")
			addcode ("          pop edx")
			addcode ("          pop ecx")
			addcode ("          pop ebx")
			addcode ("          pop eax")
			addcode ("          cs")
			addcode ("          mov ax,[write32seg1]")
			addcode ("          mov ds,ax")
			addcode ("          mov si,0                ")
			addcode ("          cs")
			addcode ("          mov di,[write32f1]")
			addcode ("          cs")
			addcode ("          mov cx,[write32output]")
			addcode ("          call WRITE16")
                          
			addcode ("          WRITE324:")
			addcode ("WRITE325:")
			addcode ("                    pop es                ")
			addcode ("                    pop ds                ")
			addcode ("                    pop ebp                ")
			addcode ("                    pop edi                ")
			addcode ("                    pop esi                ")
			addcode ("                    pop edx                ")
			addcode ("                    pop ecx                 ")
			addcode ("                    pop ebx                ")
			addcode ("                    pop eax                ")
			addcode ("                    RET                ")
			addcode ("READ32:                ")
			addcode ("          push eax                ")
			addcode ("          push ebx                ")
			addcode ("          push ecx                ")
			addcode ("          push edx                ")
			addcode ("          push esi                ")
			addcode ("          push edi                ")
			addcode ("          push ebp                ")
			addcode ("          push ds                ")
			addcode ("          push es                ")
			addcode ("          mov bp,0                ")
			addcode ("          mov ds,bp")
			addcode ("          mov es,bp")
			addcode ("          READ321:                ")
			addcode ("          cs")
			addcode ("          mov [read32addrs1],esi")
			addcode ("          cs")
			addcode ("          mov [read32counter1],ecx")
			addcode ("          cs")
			addcode ("          mov [read32f1],di")
			addcode ("          cs")
			addcode ("          mov DWORD [read32seg2],0")
			addcode ("          mov eax,ecx")
			addcode ("          cmp eax,0")
			addcode ("          JZ READ325")
			addcode ("          xor edx,edx")
			addcode ("          xor ecx,ecx")
			addcode ("          mov ebx,0ffffh")
			addcode ("          clc                ")
			addcode ("          div ebx                ")
			addcode ("          cs")
			addcode ("          mov [read32counter3],eax")
			addcode ("          cs")
			addcode ("          mov [read32output],edx")
			addcode ("          mov ax,cs")
			addcode ("          mov bx,2000h")
			addcode ("          clc                ")
			addcode ("          add ax,bx")
			addcode ("          cs")
			addcode ("          mov [read32seg1],ax")
			addcode ("          mov si,0                ")
			addcode ("          call MEM32")
			addcode ("          cs")
			addcode ("          mov [read32addrs2],eax")
			addcode ("          mov eax,0")
			addcode ("          cs")
			addcode ("          mov [read32counter2],eax")
			addcode ("          mov eax,0ffffh")
			addcode ("          cs")
			addcode ("          mov [read32size],eax")
			addcode ("          cs")
			addcode ("          mov eax,[read32counter3]")
			addcode ("          cmp eax,0")
			addcode ("          JZ READ323")
			addcode ("          READ322:                ")
			addcode ("          cs")
			addcode ("	          mov ax,[read32seg1]")
			addcode ("                    mov ds,ax")
			addcode ("                    mov si,0             ")   
			addcode ("          cs")
			addcode ("                    mov di,[read32f1]")
			addcode ("                    mov cx,0ffffh")
			addcode ("                    call READ16")
			addcode ("          cs")
			addcode ("                    mov ax,[read32seg2]")
			addcode ("                    mov ds,ax")
			addcode ("          cs")
			addcode ("                    mov ecx,[read32size]")
			addcode ("          cs")
			addcode ("                    mov esi,[read32addrs2]")
			addcode ("          cs")
			addcode ("                    mov edi,[read32addrs1]")
			addcode ("                    mov edx,1")
			addcode ("          push eax")
			addcode ("          push ebx")
			addcode ("          push ecx")
			addcode ("          push edx")
			addcode ("          push esi")
			addcode ("          push edi")
			addcode ("          push ebp")
			addcode ("          push ds")
			addcode ("          call memcopy")
			addcode ("          pop ds")
			addcode ("          pop ebp")
			addcode ("          pop edi")
			addcode ("          pop esi")
			addcode ("          pop edx")
			addcode ("          pop ecx")
			addcode ("          pop ebx")
			addcode ("          pop eax")
			addcode ("          cs")
			addcode ("                    mov eax,[read32addrs1]")
			addcode ("          cs")
			addcode ("                    mov ebx,[read32size] ")
			addcode ("                    clc                ")
			addcode ("                    add eax,ebx")
			addcode ("          cs")
			addcode ("                    mov [read32addrs1],eax")
			addcode ("          cs")
			addcode ("                    mov eax,[read32counter3]")
			addcode ("                    dec eax                ")
			addcode ("          cs")
			addcode ("                    mov [read32counter3],eax")
			addcode ("                    cmp eax,0")
			addcode ("                    JNZ READ322")
			addcode ("          READ323:                ")
			addcode ("          cs")
			addcode ("          cmp DWORD [read32output],0")
			addcode ("          JZ READ325")
			addcode ("          cs")
			addcode ("          mov ax,[read32seg1]")
			addcode ("          mov ds,ax")
			addcode ("          mov si,0                ")
			addcode ("          cs")
			addcode ("          mov di,[read32f1]")
			addcode ("          cs")
			addcode ("          mov ecx,[read32output]")
			addcode ("          call READ16")
			addcode ("          cs")
			addcode ("          mov ax,[read32seg2]")
			addcode ("          mov ds,ax")
			addcode ("          cs")
			addcode ("          mov cx,[read32output]")
			addcode ("          cs")
			addcode ("          mov esi,[read32addrs2]")
			addcode ("          cs")
			addcode ("          mov edi,[read32addrs1]")
			addcode ("          mov edx,1")
			addcode ("          push eax")
			addcode ("          push ebx")
			addcode ("          push ecx")
			addcode ("          push edx")
			addcode ("          push esi")
			addcode ("          push edi")
			addcode ("          push ebp")
			addcode ("          push ds")
			addcode ("          call memcopy")
			addcode ("          pop ds")
			addcode ("          pop ebp")
			addcode ("          pop edi")
			addcode ("          pop esi")
			addcode ("          pop edx")
			addcode ("          pop ecx")
			addcode ("          pop ebx")
			addcode ("          pop eax")
			addcode ("          READ324:               ") 
			addcode ("                    READ325:     ")           
			addcode ("                    pop es       ")         
			addcode ("                    pop ds       ")         
			addcode ("                    pop ebp      ")          
			addcode ("                    pop edi      ")          
			addcode ("                    pop esi      ")          
			addcode ("                    pop edx      ")          
			addcode ("                    pop ecx      ")           
			addcode ("                    pop ebx      ")          
			addcode ("                    pop eax      ")          
			addcode ("                    RET         ")
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
			addcode ("cicle:")
			addcode ("	cmp eax,0")
			addcode ("	jz cicle2")
			addcode ("	mov ecx,eax")
			addcode ("	cicle1:")
			addcode ("		dec ecx")
			addcode ("		cmp ecx,0")
			addcode ("		jnz cicle1")
			addcode ("cicle2:")
			addcode ("ret")
			addcode ("")
			addcode ("section .data")
			addcode ("          read32addrs1 dd 0")
			addcode ("          read32addrs2 dd 0")
			addcode ("          read32counter1 dd 0")
			addcode ("          read32counter2 dd 0")
			addcode ("          read32counter3 dd 0")
			addcode ("          read32output     dd 0")
			addcode ("          read32f1             dw 0")
			addcode ("          read32seg1        dw 0")
			addcode ("          read32seg2        dw 0")
			addcode ("          read32size         dd 0")
			addcode ("          write32addrs1 dd 0")
			addcode ("          write32addrs2 dd 0")
			addcode ("          write32counter1 dd 0")
			addcode ("          write32counter2 dd 0")
			addcode ("          write32counter3 dd 0")
			addcode ("          write32output     dd 0")
			addcode ("          write32f1             dw 0")
			addcode ("          write32seg1        dw 0")
			addcode ("          write32seg2        dw 0")
			addcode ("          write32size         dd 0")
			addcode ("hlinex     dw 0")
			addcode ("hliney     dw 0")
			addcode ("hlinex1     dw 0")
			addcode ("hliney1     dw 0")
			addcode ("hlinecolor     db 0")
			addcode ("hlinedx     dw 0")
			addcode ("hlinedy     dw 0")
			addcode ("hlinedx1     dw 0")
			addcode ("hlinedy1     dw 0")
			addcode ("hlinedcolor     db 0")
			addcode ("vlinex     dw 0")
			addcode ("vliney     dw 0")
			addcode ("vlinex1     dw 0")
			addcode ("vliney1     dw 0")
			addcode ("vlinecolor     db 0")
			addcode ("boxdx     dw 0")
			addcode ("boxdy     dw 0")
			addcode ("boxdx1     dw 0")
			addcode ("boxdy1     dw 0")
			addcode ("boxdcolor     db 0")
			addcode ("boxx     dw 0")
			addcode ("boxy     dw 0")
			addcode ("boxx1     dw 0")
			addcode ("boxy1     dw 0")
			addcode ("boxcolor     db 0")
			addcode ("x     db 0")
			addcode ("y     db 0")
			addcode ("color dw 07h")
			addcode ("L4 db 0,0,0,0,0")
			addcode ("L18 dw 0,0")
			addcode ("L20 dw 0,0,0,0,0,0,0,0")
			addcode ("L21 dw 0,0,0,0")
			addcode ("L6 db 'press a key to go on, esc key to exit scroll',13,10,0")
			addcode ("L16 db '..........................................',13,10,0")
			addcode ("L17 db '0000000000 ',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0")
			addcode ("L22 db '00000000000 ',0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0")
			addcode ("L50 times 260 db 32")
			addcode ("L51 db 0")
			addcode ("rreservemem dd 0")
			addcode ("rreservemem2 dd 0")

			addcode (";start tail")
			addcode ("")

'add head
			tt1=""
			addhead ("section .text")
			addhead ("org 0x100")
			addhead ("main:")
			addhead ("jmp start")
			addhead ("db 'build in index32 developer tools.... '")
			addhead ("mains:")
			addhead ("")
			addhead (";body start")

'add txtbody
			txtbody=""
			addtxtbody("; txt body")				
end sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class







