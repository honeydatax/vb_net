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


									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	call waits")
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

									addtail("	mov bx,L50")
									addtail("	mov dx,bx")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov cl,[bx]")
									addtail("	mov bx,dx")
									addtail("	xor ch,ch")
									addtail("	mov [bx],cx")
									addtail("	mov ah,0xa")
									addtail("	int 0x21")
									addtail("	mov bx,L50")
									addtail("	inc bx")
									addtail("	mov si,bx")
									addtail("	mov ax,cs")
									addtail("	call MEM32")
									addtail("	mov esi,eax")
									addtail("	xor ecx,ecx")
									addtail("	mov cl,[bx]")
									addtail("	push ecx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov edi,[bx]")
									addtail("	inc esi")
									addtail("	mov edx,1")
									addtail("	call COPYMEM32")
									addtail("	pop ecx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov esi,[bx]")
									addtail("	mov bp,0")
									addtail("	mov ds,bp")
									addtail("	mov al,0")
									addtail("	add esi,ecx")
									addtail("	mov [esi],al")
									addtail("	mov ax,cs")
									addtail("	mov ds,ax")

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

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov edi,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov esi,[bx]")
									addtail("	add esi,edi")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov ecx,[bx]")
									addtail("	call COPYMEM32")
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


								if varstype(bbb)=1 and varstype(bbb1)=6 and varstype(bbb2)=6 then	 

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov esi,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov edi,[bx]")
									addtail("	add edi,esi")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov ecx,[bx]")
									addtail("	dec ecx")
									addtail("	add esi,ecx")
									addtail("	add edi,ecx")
									addtail("	inc ecx")
									addtail("	call MOVEMEM32")
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

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov edi,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov esi,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov ecx,[bx]")
									addtail("	add esi,ecx")
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

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov di,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov eax,[bx]")
									addtail("	mov [di],eax")
									errorssi=-1
									errorss=0

								else
																	if varstype(bbb)=6 and varstype(bbb1)=1  then	 
									if varstype(bbb)=6 and varstype(bbb1)=0  then	 
										addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
										addtail("	mov si,[bx]")
										addtail("	push si")
										addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
										addtail("	mov si,[bx]")
										addtail("	mov ax,cs")
										addtail("	call MEM32")
										addtail("	pop si")
										addtail("	mov [di],eax")
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

									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov edi,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov esi,[bx]")
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
									addtail("	mov di,[bx]")
									addtail("	mov di,[bx]")
									addtail("	mov ax,0")
									addtail("	mov ds,ax")
									addtail("	mov al,0")
									addtail("	mov [edi],al")
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov esi,[bx]")
									addtail("	call strcat")
									addtail("	mov ax,cs")
									addtail("	mov ds,ax")
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
	
								tt=tt+","+str(val(separete(bbb1)))

							next bbb1

							tt=tt+chr(13)+chr(10)
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


								if varstype(bbb)<1 and varstype(bbb1)<1 and varstype(bbb2)=6 then	 

									addtxtbody("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtxtbody("	mov edi,[bx]")
									addtxtbody("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtxtbody("	mov esi,[bx]")
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
									addtxtbody("	mov edx,1")
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
									addtxtbody("	mov al,[si]")
									addtxtbody("	mov ah,0")
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
		addkey ("timer.cicle",3)


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
			addcode ("	mov [bx],al")
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
			addcode ("section .data")
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







