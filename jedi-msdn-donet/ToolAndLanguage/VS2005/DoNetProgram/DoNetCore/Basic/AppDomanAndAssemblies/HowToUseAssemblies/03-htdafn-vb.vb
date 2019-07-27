' code from: (msdn url)
'   http://msdn.microsoft.com/zh-cn/library/2exyydhb(v=vs.80).aspx

Imports System
Imports System.Reflection
Imports Microsoft.VisualBasic

' For a class not contained in mscorlib.dll, compile this code with
' the /r:<dllname> option; for example, compile the code below using:
'   vbc asmname.vb /r:System.Data.dll /r:System.dll /r:System.Xml.dll
' If the class is contained in mscorlib.dll, the /r:<dllname> compiler
' option is unnecessary.
'
' In fact complie command: 
'   vbc 03-htdafn.vb /r:System.Data.dll /r:System.dll /r:System.Xml.dll

Class asmname
	Public Shared Sub Main()
		Dim t as Type = GetType(System.Data.DataSet)
		Console.WriteLine("Full qualified assembly name [{0}]",	t.Assembly.FullName.ToString())
	End Sub
End Class
