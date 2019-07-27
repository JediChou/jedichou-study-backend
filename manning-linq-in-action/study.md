ch01 introducing linq
---------------------
* covers
	* linq origins
	* linq design goals
	* first steps with linq to objects, linqi to xml, and linqi to sql
* 1.1 what is linq?
	* 1.1.1 overview
		linq means language-INtegrated Query
	* 1.1.2 linq as a toolset
		* linq to objects, linq to sql, linq to xml
		* a set of building blocks including:
			query operators, query expressions, expresion trees
		* figure 1.1 linq building blocks, linq providers, and
			data sources that can be queried using linq
	* 1.1.3 linq as language extensions
		* linq is not only a syntactic sugar.
		* list 1.1 sample that use linq to query a data and
			create an xml document.
		* figure 1.2 linq as language extendsions and as a 
			gateway to several data sources.
* 1.2 why do we need linq?
	* 1.2.1 common problems
		* plumbing code waste your time.
		* code list 1-2 typcial .net data-access code
			* several steps and verbose code
			* queries are expressed as quoted strings
			* The same applies for the parameters and for the
				results sets
			* only for sql server
		* code list 1.3 simple query expression
	* 1.2.2 addressing a paradigm mismatch
		* skill: to be able to work with any of these 
			technologies or language individually
		* skill: to mix and match them to build a rich and
			coherent solution
		* what is this impedance mismatch everybodys talking about?
		* object-relational mapping
		* figure 1.3 how sample objects can be mapped to a
			database model. the mapping is not trivial due to the
			differences between the object-oriented and the
			relational paradigms
		* limitations:
			1. a good knowledge of the tools is required before
				beging able to use them efficiently and avoid
				performance issues.
			2. optimal use still requires knowledge of how to
				work with a relational database.
			3. mapping tools are not always as efficient as
				handwritten data-access code.
			4. not all the tools come with support for commile-time
				validation.
		* listing 1.4 NHibernate mapping file used to map a Cat
			class to CATS table in a relational database
		* object-xml mapping
		* to solve this problem, we must resolve the following
			issue between .net and data source element:
			* fundammentally different technologies
			* different skill sets
			* different staff and ownership for each of the technologies
			* different modeling and design priciples
	* 1.2.3 linq to the rescure
		* listing 1.5 working with relational data and xml in the same query
* 1.3 Design goals and origin of linq
	1.3.1 the goals of the linq project
		* integrate object, relation data, and xml
		* sql and xquery-like pow in c# and vb
		* extensibility model for languages
		* extensibility model for multiple data sources
		* try safety
		* extensive intellisense support
		* debugger support
		* build on the foundations laid in c# 1.0 and
			2.0, vb.net 7.0 and 8.0
		* run on the .net 2.0 clr
		* remain 100% backward compatible
		* [linq is that it is strongly typed.]
	1.3.2 a bit of history
		* c-omega, objectspaces, xquery
* 1.4 first steps with linq to objects:
		query collections in memory
	* 1.4.1 what you need to get started
		*compiler and .net framework support and required software
		*language considerations
	* 1.4.2 hello linq to objects
		*listing 1.6 hello linq in c#
		*listing 1.7 hello linq in vb.net
		*listing 1.8 old-school version of hello linq
		*listing 1.9 hello linq in c# improve with grouping and sorting
		*listing 1.10 hello linq in vb improved with grouping and sorting
* 1.5 first steps with linq to xml:
		query xml documents
	* 1.5.1 why we need linq to xml
		* element-centric
		* declarative model
		* linq to xml code presents a layout close to
			the hierarchical structure of an xml document
		* language-integrated queries
		* creating elements and attributes can be done
			in one instruction; text nodes are just strings
		* simplified xml namespace support
		* fast and smaller
		* streaming capabilities
		* symmetry in element and attribute apis
	* 1.5.2 hello linq to xml
		* listing 1.11 hello linq to xml in c#
		* listing 1.12 hello linq to xml in vb.net
		* listing 1.13 old-school version of hello linq to xml
		* listing 1.14 hello linq to xml vb.net using xml literals
* 1.6 first steps with linq to sql:
	querying relational database
	* 1.6.1 overview of linq to sqls feature
	* 1.6.2 hello linq to sql
		* entity classes
		* the datacontext
		* listing 1.15 hello linq to sql complete source code
		* lets sum up what has been done automatically for us
			by linq to sql:
			1. openning a connection to the database
			2. generating the sql query
			3. executing the sql query against the database
			4. creating and filling our objects out of the tabular results
		* You will notice the following things in the old-school code
			when comparing it whith linq to sql code:
			1. queries explicitly written sql in quotes
			2. no compile-time checks
			3. loosely bound parameters
			4. loosely typed result sets
			5. more code required
			6. more knowledge required
* 1.7 summary

ch2 c# and vb.net language enhancements
---------------------------------------
	*goals:
		*key c# 3.0 and vb.net 9.0 languages features for linq
		*implicitly typed local variables
		*object initializers
		*lambda expressions
		*extension methods
		*anonymous types
	*2.1 discovering the new language enhancements
		*2.1.1 generating a list of running processes
			* listing 2.1 sample .net 2.0 code for listing processes
			* [author dont give some info for ObjectDumper object]
			* [ObjectDumper is a helper class]
			* [ObjectDumper project: http://objectdumper.codeplex.com/]
		*2.1.2 grouping results into a class
			* listing 2.2 improved .net 2.0 code for listing processes
	*2.2 implicitly typed local variables
		*2.2.1 syntax - var
		*2.2.2 improving our example using implicitly typed local variables
			*listing 2.3 Our DisplayProcesses method using var keyword
			*[jedi, no problem]
	*2.3 object and collection initializers
		*2.3.1 the need for object initializers
		*2.3.2 collection initializers
		*2.3.3 improving our example using object initializer
			*listing 2.4 displayprocess method using a contructor
			*listing 2.5 displayprocess method using an object initilialier
			*[good]we can initialize an object within just one instruction.
			*[good]we dont need to provide a constructor to be able to
				initialize simple objects.
			*[good]we dont need serval constructors to initialize different
				properties of objects.
	*2.4 lambda expessions
		*2.4.1 a refresher on delegates
			*listing 2.6 displayprocesses method with a hard-coded filtering condition
			*listing 2.7 displayprocesses method that use a delegate for filtering
			*listing 2.8 calling the displayprocesses method using a standard delegate
		*2.4.2 anonymous methods
			*listing 2.9 calling the displayprocess method using an anonymous method
		*2.4.3 introducting lambda expressions
			*lambda can infer parameter types
			*lambda can use both statement blocks and expression as bodies, allowing
				for a terster syntax than anonymous methods, whose boides can only be
				statement blocks.
			*lambda expression can participate in type argument interface and method
				overload resolution when passed in as arguments.
			*[input parameters][=>][expression or statment block]
			*listing 2.11 sample lambda expressions in c#
				x=>x+1   				// implicitly typed, expression body
				x=>{resurn x+1;}		// implicitly typed, statement body
				(int x)=>x+1			// implicitly typed, statement body
				(int x)=>{return x+1;}	// 
				(x, y)=>(x*y)
				()=>1
				()=>Console.WriteLine()
				customer=>customer.Name
				person=>person.City="Paris"
				(person, minAge)=>person.Age >= minAge
			*listing 2.12 sample lambda expression in vb.net
				Function(x) x+1	 // implicitly type
				Function(x As Integer) x+1  // implicitly typed
				Function(x, y) x*y  // multiple parameters
				Function() 1  // no parameters
				Function(customer) customer.Name
				Function(person) person.City = "Paris"
				Function(person, minAge) person.Age >= minAge
			*generic delegate types were introduced by .net 2.0
				delegate void Action<T>(T obj);
				delegate TOuput Converter<TInput,TOuput>(TInput input);
				delegate Boolean Predicate<T>(T obj);
				delegate void MethodInvoker(); // very special
			*other delegate types in the System.Core.dll by .net 3.5
				delegate void Action<T1, T2>(T1 arg1, T2 arg2);
				delegate void Action<T1, T2, T3>(T1 arg1, T2 arg2);
				delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T1 arg3, T2 arg4);
				delegate TResult Func<TResult>();
				delegate TResult Func<T, TResult>(T arg);
				delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
				delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
				delegate TResult Func<T1, T2, T3, T4, TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);
			*condition
				*the lambda must contain the same number of parameters as the delegate type.
				*each input parameter in the lambda must be implicitly convertible to its
					conrresponding delegate parameter.
				*the return value of the lambda(if any) must be implicitly converible to the
					delegates return type.
			*listing 2.13 sample lambda expressions declared as delegate in c#
			*listing 2.14 sample lambda expressions declared as delegate in vb.net
	*2.5 extension methods
		*2.5.1 creating a sample extension method
			*listing 2.15 the totalmemory helper method coded as standard static method
			*listing 2.16 the totalmemory helper method declared as an extension method
			*if use extension methods, you will
				processes
					.FilterOutSomeProcesses()
					.TotalMemory()
					.BytesToMegaBytes();
				// it is good than other
				BytesToMegaBytes(TotalMemory(FilterOutSomeProcesses(processes)));
			*listing 2.17 sample extension method in vb.net
		*2.5.2 more examples using linqs standard query
			*OrderByDescending -> °´½µÐòÅÅÁÐ
			*example: processes.OrderByDescending(process=>process.Memory));
			
		*2.5.3 extension methos in action in our example
		*2.5.4 warnings
	*2.6 anonymous types
		* var contact = new {Name="Bob", Age=8}
		*2.6.1 using anonymous types to group data into object
		*2.6.2 types without names, but types nonetheless
		*2.6.3 improving our example using anonymous types
		*2.6.4 limitations
	*2.7 summary


