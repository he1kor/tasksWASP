using Tasks.Util;

namespace Tasks._1._3;

public class Program : BaseProgram
{
    public Program()
    {
        int x1 = Input.ReadInt("Write X of first point: ");
        int y1 = Input.ReadInt("Write Y of first point: ");
        int x2 = Input.ReadInt("Write X of second point");
        int y2 = Input.ReadInt("Write Y of second point");
        int x3 = Input.ReadInt("Write X of third point");
        int y3 = Input.ReadInt("Write Y of third point");
        
        int xMax = Math.Max(Math.Max(x1,x2),x3);
        int yMax = Math.Max(Math.Max(y1,y2),y3);
        for (int y = 0; y <= yMax; y++)
        {
            int spaceAmount = 0;
            for (int x = 0; x <= xMax; x++){
                
                //formulas from https://abakbot.ru/online-2/280-pointreug
                
                int formulaValue1 = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
                int formulaValue2 = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
                int formulaValue3 = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);
                if (formulaValue1 >= 0 == formulaValue2 >= 0 && formulaValue2 >= 0 == formulaValue3 >= 0
                    ||
                    formulaValue1 <= 0 == formulaValue2 <= 0 && formulaValue2 <= 0 == formulaValue3 <= 0)
                {
                    Console.Write("#");
                    continue;
                }
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}