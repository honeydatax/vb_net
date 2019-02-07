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
	dim labelss(100) as string
	dim labeladdress(100) as integer
	dim labelstate(100) as integer
	dim labelindex as integer
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
	dim bbb3 as integer
	dim bbb4 as integer
	dim tc as string
	dim tc1 as string
	dim tc2 as string
	dim tc3 as string
	dim tc4 as string
	dim forvar(100) as integer
	dim forfrom(100) as integer
	dim forinto(100) as integer
	dim forstep(100) as integer
	dim foraddress(100) as integer
	dim forcount as integer
	dim varstype(100) as integer
	dim line11(100) as integer
	dim debug as string
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
	addcode ("                rem,define vars")
	addcode ("        integer,var1,0")
	addcode ("        integer,from,0")
	addcode ("        integer,into,5")
	addcode ("        integer,step,1")
	addcode ("        rem,for")
	addcode ("        for,var1,from,into,step")
	addcode ("        rem,echo")
	addcode ("                echo,----HELLO WORLD.............")
	addcode ("        rem,next")
	addcode ("        next")
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
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtail("LL"+trim(str(labeladdress(bbb)+8000))+":")
									labelstate(bbb)=1
								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 
							errorssi=-1
							errorss=0
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
							else

								if bbb>-1 and tc<>"" and (asc(tc)>(asc("A")-1)) and (asc(tc)<(asc("Z")+1)) then 
									addtail("	jmp LL"+trim(str(labeladdress(bbb)+8000)))
									errorssi=-1
									errorss=0

								else						
									iii=1+iii
									goto errorhandler
								end if
							end if 
							errorssi=-1
							errorss=0
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
											addtail("	jmp LL"+trim(str(iii+8000)))
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
											addtail("	jmp LL"+trim(str(iii+8000)))
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
											addtail("	jmp LL"+trim(str(iii+8000)))
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
											addtail("	jmp LL"+trim(str(iii+8000)))
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
									addtail("	mov bx,L"+(trim(line11(bbb1)+9000)))
									addtail("	mov si,bx")
									addtail("	call strcat3")
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
									addtail("	add di,cx")
									addtail("	add si,cx")
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
									addtail("	add si,cx")
									addtail("	add di,cx")
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
			text0.text =tt + t+chr(13)+chr(10)+"endf db '$'"+chr(13)+chr(10)
		
			goto escapehandler
			errorhandler:
				text0.text ="error on line "+str(iii)+" keyword :"+keywords(errorssi)+debug
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
			addcode ("memfill:")
			addcode ("	mov [di],al")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz memfill")
			addcode ("	ret")
			addcode ("memcopy:")
			addcode ("	mov al,[si]")
			addcode ("	mov [di],al")
			addcode ("	inc si")
			addcode ("	inc di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0")
			addcode ("	jnz memcopy")
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
			addcode ("	mov al,[si]")
			addcode ("	mov [di],al")
			addcode ("	dec si")
			addcode ("	dec di")
			addcode ("	dec cx")
			addcode ("	cmp cx,0xffff")
			addcode ("	jnz memmove")
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






