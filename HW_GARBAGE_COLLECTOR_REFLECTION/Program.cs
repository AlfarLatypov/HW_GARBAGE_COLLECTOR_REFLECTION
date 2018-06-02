using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


/*Тема: Сборка мусора. Рефлексия.

1.	С помощью рефлексии получить список методов класса Console и вывести на экран.
2.	Описать класс с несколькими свойствами. Создать экземпляр класса и инициализировать его свойства. 
С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. Вывести полученные значения на экран
3.	С помощью рефлексии вызвать метод Substring класса String и извлечь из строки подстроку заданного размера.
4.	Получить список конструкторов класса List<T>
*/




namespace HW_GARBAGE_COLLECTOR_REFLECTION
{
    class Program
    {
        static void Main(string[] args)
        {

            /*	С помощью рефлексии получить список методов класса Console и вывести на экран.*/
            #region TASK1
            //Console.WriteLine("\n\tСписок методов класса Console:");

            //Type console = typeof(Console);

            //MethodInfo[] methods = console.GetMethods();

            //foreach (MethodInfo m in methods)
            //{
            //    Console.WriteLine("\t-->" + m.ReturnType.Name + " - " + m.Name);
            //    ParameterInfo[] p = m.GetParameters();
            //    for (int i = 0; i < p.Length; i++)
            //    {
            //        Console.WriteLine("   -------------------------\n   "+p[i].ParameterType.Name + " " + p[i].Name);
            //    }
            //}
            #endregion TASK1

            /* Описать класс с несколькими свойствами. 
     Создать экземпляр класса и инициализировать его свойства. 
     С помощью рефлексии получить свойства и их значения из созданного экземпляра класса. 
     Вывести полученные значения на экран*/
            #region TASK2

            //      MyClass myClass = new MyClass();
            //      myClass.SomeProperty1 = 777;
            //      myClass.SomeProperty2 = "Alfar";
            //      myClass.SomeProperty3 = "Latypov";

            //      Type type = typeof(MyClass);

            //      Console.WriteLine(" Type -> " + type.Name);

            //      PropertyInfo[] props = type.GetProperties();
            //      Console.WriteLine("     Properties --> " + props.Length);

            //      foreach (var prop in props)
            //if (prop.GetIndexParameters().Length == 0)
            //Console.WriteLine("          {0} ({1}): {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(myClass, null));

            #endregion TASK2

            /* С помощью рефлексии вызвать метод Substring класса String и
     извлечь из строки подстроку заданного размера.*/
            #region TASK3

            //Type t = typeof(String);
            //Type[] parameterTypes = { typeof(int) };
            //MethodInfo sub = t.GetMethod("Substring", parameterTypes);
            //Console.Write("Введите строку: ");
            //string str = Console.ReadLine();
            //Console.Write("Введите аргумент: ");
            //int arg = int.Parse(Console.ReadLine());
            //object[] arguments = { arg };
            //object returnValue = sub.Invoke(str, arguments);
            //Console.WriteLine(returnValue);

            #endregion TASK3

            /* Получить список конструкторов класса List<T>*/
            #region TASK4

            Type l = typeof(List<>);

            ConstructorInfo[] constructors = l.GetConstructors();

            foreach (var con in constructors)
            {
                Console.Write("----> {0}(", con.Name);
                ParameterInfo[] p = con.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    Console.Write("{0} {1}", p[i].ParameterType.Name, p[i].Name);
                    if (i + 1 < p.Length)
                        Console.Write(", ");
                }
                Console.WriteLine(") ");
            }

            #endregion TASK4
        }
    }

}
