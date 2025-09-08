using System;
using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interface{
    public class Shield : GameItem{//Shield inherits from GameItem

    private int Defense;//Defense Property

    //constructor to accept name and defense value
    public Shield(string name, int Defense) :base(name){
        this.Defense = Defense;
    }

    public override void UseItem(){//using override keyword to implement UseItem()
    Console.WriteLine("You equipped " + this.name + ". Defense increased by " + this.Defense);
    }
    }
}