// listing 2.16 the totalmemory helper method declared as 
// an extension method
static Int64 TotalMemory(this IEnumerable<ProcessData> processes)
{
	Int64 result = 0;
	foreach(var process in processes)
		result += process.Memory;
	return result;
}
