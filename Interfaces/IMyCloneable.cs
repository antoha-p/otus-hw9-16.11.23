namespace Prototype.Interfaces;

/// <summary>
/// Интерфейс клонирования возвращает так же клонируемый объект.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IMyCloneable<T> where T : IMyCloneable<T>
{
    T MyClone();
}
