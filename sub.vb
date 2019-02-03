Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Globalization
Imports System.Diagnostics
Imports System.IO
Imports System.Collections.Generic
Imports System.Runtime.Serialization.Formatters.Binary


Public Class WinVBApp
    Inherits Form
	dim n as integer
	dim c as string
	dim ii as integer
	dim i as integer
	dim keycount as  integer
	dim varscount as integer
	dim keywords(100) as string
	dim par(100) as integer
	dim vars(100) as string
	dim errorss as integer
	dim errorssi as integer
	dim parcount as integer
	dim par1 as string
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
	dim tc as string
	dim tc1 as string
	dim tc2 as string
	dim varstype(100) as integer
	dim line11(100) as integer
        Dim button As New Button
        Dim text0 As New textbox
        Dim text1 As New textbox
        Dim text2 As New textbox



    Public Sub New

       Me.Text = "linesky@sapo.pt"
       Me.Size = New Size(640, 350)
       
       Me.InitUI
       
       Me.CenterToScreen

    End Sub
    
    Private Sub InitUI
    
	ii=0
        text0.Location = New Point(3,170)
        text0.size = New size(610,150)
        text0.multiline = true
        text0.scrollbars = 3
        text0.Parent = Me

        button.Location = New Point(560,3)
        button.Text = "keywords:"
        button.Parent = Me

        text2.Location = New Point(5,3)
        text2.size = New size(550,150)
        text2.multiline = true
        text2.scrollbars = 3

'sample code
	addcode ("integer,a,0")
	addcode ("set,z,  ")
	addcode ("integer,b,1")
	addcode ("let,a,45")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("sub,a,a,b")
	addcode ("print,a")
	addcode ("")





        text2.Text =t1





	startcode()





        AddHandler button.Click, AddressOf Me.OnClick



        text2.Parent = Me


     
        Me.CenterToScreen
        
    End Sub

    Private Sub OnClick(ByVal sender As Object, ByVal e As EventArgs)


		clearbody()
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
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
							errorssi=-1
							errorss=0
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
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
							errorssi=-1
							errorss=0
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
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
							errorssi=-1
							errorss=0
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
								end if 
								else
									iii=1+iii
									goto errorhandler
							end if
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

									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov ax,[bx]")
									addtail("	mov bx,L"+(trim(line11(bbb2)+9000)))
									addtail("	mov cx,[bx]")
									addtail("	sub ax,cx")
									addtail("	mov bx,L"+(trim(line11(bbb)+9000)))
									addtail("	mov [bx],ax")
								end if 
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

'general error
                 catch ee as Exception 
			   text0.text ="ERROR same data is not correct line :"+str(iii+1)
			goto escapehandler
			   end try
			text0.text =tt + t+chr(13)+chr(10)+"endf db '$'"+chr(13)+chr(10)
		
			goto escapehandler
			errorhandler:
				text0.text ="error on line "+str(iii)+" keyword :"+keywords(errorssi)
     			escapehandler:

        
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



private sub clearbody()

		varscount=0
		errorss=0


		t=t1
		tt=tt1

		c= text2.text
		c=c.replace("	","        ")				
		c=c.replace(chr(13),"")

			iii=0


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
			addcode ("	mov bx,L4")
			addcode ("	mov al,[bx]")
			addcode ("	inc al")
			addcode ("	mov [bx],al")
			addcode ("	cmp al,20")
			addcode ("	jnz L5")
			addcode ("	xor al,al")
			addcode ("	mov [bx],al")
			addcode ("	mov si,dx")
			addcode ("	mov ah,9")
			addcode ("	mov dx,L6")
			addcode ("	int 0x21")
			addcode ("	mov dx,si")
			addcode ("	mov ah,al")
			addcode ("	int 0x16")
			addcode ("	cmp al,27")
			addcode ("	jz L7")
			addcode ("L5:")
			addcode ("	call L0print")
			addcode ("	ret")
			addcode ("L7:")
			addcode ("	xor ax,ax")
			addcode ("	int 0x21")
			addcode ("	ret")
			addcode ("waits:")
			addcode ("	xor ax,ax")
			addcode ("	int 0x16")
			addcode ("	mov [bx],al")
			addcode ("	ret")
			addcode ("section .data")
			addcode ("L4 db 0,0,0,0,0")
			addcode ("L6 db 'press a key to go on, esc key to exit scroll',13,10,'$'")
			addcode (";start tail")
			addcode ("")

'add head
			tt1=""
			addhead ("section .text")
			addhead ("org 0x100")
			addhead ("main:")
			addhead ("")
			addhead (";body start")

end sub


    Public Shared Sub Main
        Application.Run(New WinVBApp)
    End Sub
   
End Class






