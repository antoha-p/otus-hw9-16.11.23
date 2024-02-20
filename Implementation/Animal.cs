namespace Prototype.Implementation;

/// <summary>
/// Любое клонируемое животное с именем.
/// </summary>
public class Animal : ClonableCreature
{
    public Animal(string name)
        : base(name)
    {

    }

    public override Animal MyClone()
    {
        return new Animal($"{Name}_Clone");
    }

    public override object Clone()
    {
        return MyClone();
    }
}
