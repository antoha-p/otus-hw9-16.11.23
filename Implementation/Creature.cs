namespace Prototype.Implementation;

/// <summary>
/// Базовый класс для всех существ.
/// Существо/создание не обязательно должно быть клонируемо.
/// </summary>
public class Creature
{
    /// <summary>
    /// Имя существа.
    /// </summary>
    public string Name { get; set; }

    public Creature(string name)
    {
        Name = name;
    }
}

