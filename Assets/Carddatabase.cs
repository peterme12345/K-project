using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carddatabase : MonoBehaviour
{
  public static List<Card> database = new List<Card>();

  void Awake(){
    
    database.Add(new Card(0,"You and I",1,5,"+something",Resources.Load<Sprite>("background")));
    database.Add(new Card(1,"Yooheyon",3,2,"Dancer",Resources.Load<Sprite>("1")));
    database.Add(new Card(2,"Jiu",4,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(3,"Dami",6,10,"Rapper",Resources.Load<Sprite>("1")));
    database.Add(new Card(4,"Sua",2,9,"Dancer",Resources.Load<Sprite>("1")));
    database.Add(new Card(5,"Gahyeon",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(6,"Siyeon",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(7,"Handong",2,9,"Dancer",Resources.Load<Sprite>("1")));
    database.Add(new Card(8,"Jennie",2,9,"Rapper",Resources.Load<Sprite>("1")));
    database.Add(new Card(9,"Lisa",2,9,"Dancer",Resources.Load<Sprite>("1")));
    database.Add(new Card(10,"Rose",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(11,"Jisoo",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(12,"Chaewon",2,8,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(13,"Kazuha",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(14,"Sakura",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(15,"Yunjin",2,9,"Singer",Resources.Load<Sprite>("1")));
    database.Add(new Card(16,"Eunchae",2,9,"Singer",Resources.Load<Sprite>("1")));
  }
}
