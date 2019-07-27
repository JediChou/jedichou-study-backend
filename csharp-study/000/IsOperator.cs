// http://www.c-sharpcorner.com/UploadFile/g_arora/discussing-is-and-as-operators-of-C-Sharp-language/
namespace Program { using System; class Speaker {}; class Author {};
class Program {	static void Main() {
	// We are just checking the matching type.
	// Let's create a author. And check it again.
	Speaker speaker = new Speaker();
	Author author = new Author();
	Console.WriteLine("speaker is of Speaker type: {0}", speaker is Speaker);
	Console.WriteLine("author is of Speaker type: {0}", author is Author);
}}}
