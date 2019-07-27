.assembly program {}
.class public auto ansi beforefieldinit Program extends [mscorlib]System.Object
{
  .method public hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    .maxstack  8
    nop
    ldstr "Something will be happen."
    call void [mscorlib]System.Console::Write(string)
	call void [mscorlib]System.Console::WriteLine()
    nop
    ret
  } 
}
