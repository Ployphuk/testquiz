using System;
public class program{

    public static void Main(string[] args){
        PrintMenu();
        string ans = Choice();
        Result();
    }

    public static void PrintMenu(){
        Console.WriteLine("------Welcome------");
        Console.WriteLine("Choose Your choice ");
        Console.WriteLine("Input 1 : ShopInfomation");
        Console.WriteLine("Input 2 : Founde Infomation");
        Console.WriteLine("Input 3 : Staff Infomation");
        Console.WriteLine("Input 4 : Shop Income Infomation");
    }

    public static string Choice(){
        Console.Write(" Answer :");
        return Console.ReadLine();
    }

    public static string Result(Info info){
        swith (choice){
            case "1": Console.WriteLine(info.ShopInfo());
            break;
            case "2": Console.WriteLine(info.ShopFounder());
            break;
            case "3": Console.WriteLine(staff());
            break;
            case "4": Console.WriteLine(salary());
            break;
            default : Console.WriteLine(" Please Input Correct Answer");
            break;
        }
        Console.ReadLine();
    }





   
}