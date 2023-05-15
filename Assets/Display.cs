using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Display : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
   

    public int id;
    public string cardname;
    public int cost;
    public int power;
    public string description;
    public Sprite spriteImage;

    public Text nameText;
    public Text costText;
    public Text powerText;
    public Text DescriptionText;
    public Image art;


    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
