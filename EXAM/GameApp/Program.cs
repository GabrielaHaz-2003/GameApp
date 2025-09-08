using System;
using GameApp.Libraries.Interface;

namespace GameApp{
class Program{
        public static void Main (string [] args){
            Shield shield = new Shield("Iron Shield", 10);//Shield object
            shield.ShowInfo();
            shield.UseItem();

            Potion potion = new Potion("Restored Health", 100);//Potion object
            potion.ShowInfo();
            potion.UseItem();

            Console.WriteLine(".....................................");
}
    
        }
    }