namespace Prototype.Implementation;

/// <summary>
/// Шаблонная фабрика. Она клонирует любое животное, унаследованное от Animal.
/// </summary>
public class AnimalFactory
{
    /// <summary>
    /// Клонирование через дефолтный конструктор.
    /// </summary>
    /// <typeparam name="T">Тип объекта.</typeparam>
    /// <param name="clonableAnimal">Объект.</param>
    /// <returns>Клон.</returns>
    public T CloneByConstructor<T>(T clonableAnimal) where T : Animal, new()
    {
        var clone = new T
        {
            Name = $"{clonableAnimal.Name}_FactoryConstructorClone"
        };
        return clone;
    }

    /// <summary>
    /// Клонирование через интерфейс IMyClonable.
    /// </summary>
    /// <param name="clonableAnimal">Объект.</param>
    /// <returns>Клон.</returns>
    public Animal Clone(Animal clonableAnimal)
    {
        return clonableAnimal.MyClone();
    }
}
