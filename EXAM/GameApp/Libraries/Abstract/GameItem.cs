using System;

namespace GameApp.Libraries.Abstract{
    public abstract class GameItem{
        public string name;//name property

    public GameItem(string item){//constructor method that accepts the name
        this.name = item;
    }

    public void ShowInfo(){//method that prints name
    Console.WriteLine("Item: " + this.name);
    }

    public abstract void UseItem();//last method
    }
}