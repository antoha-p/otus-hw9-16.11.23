using Prototype.Interfaces;

namespace Prototype.Implementation;

/// <summary>
/// Абстрактное клонируемое существо. Оно может быть создано только через наследование и реализацию методов клонирования.
/// </summary>
public abstract class ClonableCreature : Creature, IMyCloneable<ClonableCreature>, ICloneable
{
    public ClonableCreature(string name)
        : base(name)
    {

    }

    public abstract ClonableCreature MyClone();

    public abstract object Clone();
}
