imports System
imports System.IO
imports System.Collections.Generic
imports System.Runtime.Serialization.Formatters.Binary

friend notInheritable class Constants
public shared mz as integer  = 0
public shared lastbb as integer=2
public shared nblock as integer=4
public shared reloc as integer=6
public shared parag512 as integer=8
public shared add512 as integer =10
public shared AddMaxPar as integer =12
public shared ss as integer =14
public shared sp as integer =16
public shared WordChk as integer =18
public shared ip as integer =20
public shared cs as integer =22
public shared tableoff as integer =24
public shared over as integer =26


End Class

friend notInheritable class org

public shared function getInts(c0 as byte ,c1 as byte) as long
return c0+256*(c1)
end function

public shared function getLow(i as long) as byte
dim l as long
dim h as long = i\256
l=i-(h*256)
return l
end function

public shared function getHigh(i as long) as byte
dim l as long
dim h  as long = i\256
l=i-(h*256)
return h
end function

End Class



Public Class Application
	Public Shared Sub Main()
        dim buff(60000) as byte
        dim head(64) as byte
         dim bw as BinaryWriter 
           dim br as BinaryReader
           
        dim a as String 
        dim b as String 
		   Console.Write("enter a file exe to convert ")
           a = Console.ReadLine()
             Console.Write("enter a file com to output ")
          b = Console.ReadLine()
           Console.WriteLine(a)
           Console.WriteLine(b)
           
        dim f as FileInfo= new FileInfo(a)
        dim l as long  =f.Length

		try 
            br = new BinaryReader(new FileStream(a, FileMode.Open))

          catch e as IOException 
            Console.WriteLine(e.Message + "\n Cannot open file.")
            exit sub
         end try

         try 
            br.Read(buff,0,l)
           
            
      
         catch e as IOException 
            Console.WriteLine(e.Message + "\n Cannot read from file.")
            exit sub
         end try
         br.Close()

head(0)=&HB8

head(1)=&H24

head(2)=&H0

head(3)=&H8C

head(4)=&HCB

head(5)=&HF8

head(6)=&H1

head(7)=&HC3

head(8)=&H8E

head(9)=&HDB

head(10)=&H8E

head(11)=&HC3

head(12)=&HB8

head(13)= org.getLow(org.getInts(buff(Constants.ss),buff(Constants.ss+1))+&H10)
head(14)= org.getHigh(org.getInts(buff(Constants.ss),buff(Constants.ss+1))+&H10)

head(15)=&H1

 head(16)=&HD8

 head(17)=&H8E

 head(18)=&HD0

 head(19)=&HB8

head(20)= org.getLow(org.getInts(buff(Constants.sp),buff(Constants.sp+1))+&H0)
 head(21)= org.getHigh(org.getInts(buff(Constants.sp),buff(Constants.sp+1))+&H0)

 head(22)=&H89

 head(23)=&HC4

 head(24)=&HB8

 head(25)=&H0

 head(26)=&H0

 head(27)=&H1

 head(28)=&HC3


 head(29)=&HB8

head(30)= org.getLow(org.getInts(buff(Constants.cs),buff(Constants.cs+1))+&H10)
 head(31)= org.getHigh(org.getInts(buff(Constants.cs),buff(Constants.cs+1))+&H10)

 head(32)=&H1

 head(33)=&HD8

 head(34)=&HBB

 head(35)=&H80

 head(36)=&H0

 head(37)=&H2E

 head(38)=&H89

 head(39)=&H7

 head(40)=&H4B

 head(41)=&H4B

 head(42)=&HB8
head(43)= org.getLow(org.getInts(buff(Constants.ip),buff(Constants.ip+1))+&H0)
 head(44)= org.getHigh(org.getInts(buff(Constants.ip),buff(Constants.ip+1))+&H0)

 head(45)=&H2E

 head(46)=&H89

 head(47)=&H7

 head(48)=&HB8
head(49)= org.getLow(org.getInts(buff(Constants.AddMaxPar),buff(Constants.AddMaxPar+1))+&H0)
 head(50)= org.getHigh(org.getInts(buff(Constants.AddMaxPar),buff(Constants.AddMaxPar+1))+&H0)
 
 
 head(51)=&H2E

head(52)=&HFF

head(53)=&H2F



                    'create the file
         try 
            bw = new BinaryWriter(new FileStream(b, FileMode.Create))
            
         catch e as IOException 
            Console.WriteLine(e.Message + "\n Cannot create file.")
            exit sub
         end try

		'writing into the file
         try 
            bw.Write(head,0,64)
                       bw.Write(buff,0,l)
         catch e as IOException 
            Console.WriteLine(e.Message + "\n Cannot write to file.")
            exit sub 
         end try 
         bw.Close()
		

	End Sub
End Class


