string line, caseID, method;
string[] tokens, tempInput;
string expected;

while ((line = sr.ReadLine()) != null)
{
	tokens = line.Split(':');
	caseID = tokens[0];
	method = tokens[1];
	tempInput = tokens[2].Split(' ');
	expected = tokens[3]
	// etc
}