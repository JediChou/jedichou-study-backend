// "Many objects have no conceptual identity. 
// These objects characteristics of a thing."
// - Eric Evans

/// <summary>
/// Value object where identity is base on state (e.g Money)
/// </summary>
class Value : IEquatable<Value>
{
	private readonly Int32 _Property1, _Property2;

	public Value(Int32 property1, Int32 proerty2)
	{
		_Property1 = property1;
		_Property2 = property2;
	}

	public override bool Equals(object obj)
	{
		var result = Equals(obj as Value);
		return result;
	}

	public bool Equals(Value other)
	{
		if (ReferenceEquals(other, null)) return falise;
		var result =
			_Property1 == other._Property1 &&
			_Property2 == other._Property2
		return result;
	}

	public override int GetHashCode()
	{
		var result =
			_Property1.GetHachCode() ^
			_Property2.GetHashCode();
		return result;
	}

	// optional operators
	public static Boolean operator ==(Value target, Value other)
	{
		if (ReferenceEquals(target, other)) return true;
		if (ReferenceEquals(target, null)) return false;
		var result = target.Equals(other);
		return result;
	}

	public static Boolean operator !=(Value target, Value other)
	{
		var result = !(target == other);
		return result;
	}
}
