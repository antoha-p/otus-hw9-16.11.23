using Prototype.Implementation;

namespace Prototype;

public class Program
{
    static void Main(string[] args)
    {
        //Придумать и создать 3-4 класса, которые как минимум дважды наследуются и написать краткое описание текстом.
        //Создать свой дженерик интерфейс IMyCloneable для реализации шаблона "Прототип".
        //Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских конструкторов.
        //Составить тесты или написать программу для демонстрации функции клонирования.
        //Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.
        //Написать вывод: какие преимущества и недостатки у каждого из интерфейсов: IMyCloneable и ICloneable.

        Console.WriteLine("Started");

        //Создаем овцу Долли.
        var sheep = new Sheep("Dolly");

        //Создаем фабрику животных.
        var animalFactory = new AnimalFactory();

        //Клонирем овцу через интерфейс IMyCloneable<Animal>.
        sheep = sheep.MyClone();
        Console.WriteLine($"Dolly clone name: {sheep.Name}");

        //Еще раз клонирем овцу через фабрику и конструктор.
        sheep = animalFactory.CloneByConstructor(sheep);
        Console.WriteLine($"Dolly clone clone name: {sheep.Name}");

        //Клонируем овцу через стандартный интерфейс IClonable.
        ICloneable clonableSheep = sheep;
        sheep = clonableSheep.Clone() as Sheep;
        Console.WriteLine($"Dolly clone clone clone name: {sheep?.Name}");

        //Создаем животное корова.
        var cow = new Animal("Cow");

        //Клонируем корову.
        cow = cow.MyClone();
        Console.WriteLine($"Cow clone name: {cow.Name}");

        //Еще раз клонирем корову через фабрику, как экземпляр Animal.
        cow = animalFactory.Clone(cow);
        Console.WriteLine($"Cow clone clone name: {cow.Name}");

        //Создаем ангела.
        var angel = new Angel("Gavriil");
        //angel.MyClone(); Клонирование не поддерживается.
        //var animal = animalFactory.Clone(angel); Клонирование не поддерживается.

        //ВЫВОД:
        //Преимущество IMyCloneable<> в том, что он может быть типизирован и возвращать объект нужного типа.
        //В моем примере на тип T наложено ограничение where T : IMyCloneable<T>, т.е. результат клонирования должен поддерживать дальнейшее клонирование.
        //При этом ICloneable возвращает всегда object, что более гибко, но результат всегда нужно явно приводить к конкретному типу.
    }
}
