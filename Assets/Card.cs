using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card  
{
    public int id;
    public string cardname; 
    public int cost; 
    public int power;
    public string description;
    public Sprite spriteImage;

    public Card()
    {
    }

    public Card(int Id,string Cardname, int Cost, int Power, string Description, Sprite SpriteImage){
        id = Id;
        cardname = Cardname;
        cost = Cost;
        power = Power;
        description = Description;
        spriteImage = SpriteImage;
    }
}
