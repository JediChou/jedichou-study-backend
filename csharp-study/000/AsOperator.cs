// http://www.c-sharpcorner.com/UploadFile/g_arora/discussing-is-and-as-operators-of-C-Sharp-language/
namespace Program { using System; class Speaker {}; class Author {};
class Program {	static void Main() {
	Console.WriteLine("Speaker is: {0}", GetAuthorName(new Speaker()));
	Console.WriteLine("Author is: {0}", GetAuthorName(new Author()));
} public static string GetAuthorName(object obj) {
	Author authorObj = obj as Author;
	return (authorObj != null) ? authorObj.ToString() : string.Empty;
}}}
