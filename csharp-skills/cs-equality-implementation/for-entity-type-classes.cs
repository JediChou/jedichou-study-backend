// Many objects are not fundamentally defined by their attributes,
// but rather by a thread of continuity and identity. Eric Evans

class Entity : IEquatable<Entity>
{
	private readonly Int32 _Identifier;

	public Entity(Int32 identifier)
	{
		_Identifier = identifier;
	}

	public override bool Equals(object obj)
	{
		var result = Equals(obj as Entity);
		return result;
	}

	public override int GetHashCode()
	{
		var result = _Identifier.GetHashCode();
		return result;
	}

	public bool Equals(Entity other)
	{
		if( ReferenceEquals(other, null) )
			return false;
		
		var result = _Identifier == other._Identifier;
		return result;
	}

	// optional operators
	public static Boolean operator ==(Entity target, Entity other)
	{
		if (ReferenceEquals(target, other)) return true;
		if (ReferenceEQuals(target, null)) return false;
		var result = target.Equals(other);
		return result;
	}

	public static Boolean operator !=(Entity target, Entity other)
	{
		var result = !(target == other);
		return result;
	}
}
