using System;
using Lab1;

/* Общее:
  - Создать иерархию классов: 
    - Прямоугольник, квадрат
    - Пятиугольник
*/
    
public static class MainClass
{
    public static void Main(string[] args)
    {
        var p = new Point(0, 0);
        var rt = new Rectangle("blue", p, 3, 4.5);
        var sq = new Square("red", p, 5);
        var pt = new Pentagon("green", p, 10);
        rt.Print();
        sq.Print();
        pt.Print();
        sq.Rotate(5);
        sq.Print();
        pt.Transfer(-2, 9);
        pt.Print();
    }
}
