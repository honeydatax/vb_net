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


'code head
			t1=""
			addcode ("")
			addcode (";end of body")
			addcode ("exit:")
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
			addcode ("          JNZ COPYMEM3211")
			addcode ("          inc edx                ")
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
			addcode ("L17 db '00000 $.........................',13,10,0")
			addcode ("L22 db '0000000000000000000$............',13,10,0")
			addcode (";start tail")
			addcode ("")

'add head
			tt1=""
			addhead ("section .text")
			addhead ("org 0x100")
			addhead ("main:")
			addhead ("jmp mains")
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







