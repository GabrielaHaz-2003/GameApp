using System;
using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interface{
    public class Potion : GameItem{//Potion inherits from GameItem

    private int HealAmount;//HealAmount property

    //constructor to accept the name and HealAmount 
    public Potion(string name, int HealAmount) :base (name) 
    {
        this.HealAmount = HealAmount;
    }

    public override void UseItem(){//using override keyword to implement UseItem()
    Console.WriteLine("You drank " + this.name + ". Restored " + this.HealAmount + "HP!");
    }
    }
}