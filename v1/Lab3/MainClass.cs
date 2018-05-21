using System;
using Lab3;

public class MainClass
{
    public static void Main(string[] args)
    {
        var p = new Point(0, 0);
        
        Event ev = new Event();
        Shape rectangle = new Rectangle("blue", p, 2, 0.5);
        Shape square = new Square("green", p, 1);
        Shape pentagon = new Pentagon("red", p, 1);
        Shape ellipse = new Ellipse("white", p, 1, 2);
        Shape circle = new Circle("yellow", p, 1);

        ev.OnR += rectangle.Zoom2x;
        ev.OnS += square.Zoom2x;
        ev.OnE += ellipse.Zoom2x;
        ev.OnC += circle.Zoom2x;
        ev.OnP += pentagon.Zoom2x;

        while (true)
        {
            Console.WriteLine("Enter command: ");
            var cmd = Console.ReadLine();
            if (cmd.Equals("exit"))
            {
                Console.WriteLine("Bye!");
                break;
            }
            ev.start(cmd);
        }
    }
}
