using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>(){null};
    public int displayId;

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
    
    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int numberOfCardsInDeck;

    // Start is called before the first frame update
    void Start()
    {

        numberOfCardsInDeck = PlayerDeck.deckSize;

        displayCard[0] = Carddatabase.database[displayId];
        
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardname = displayCard[0].cardname;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        description = displayCard[0].description;
        spriteImage = displayCard[0].spriteImage;

        nameText.text = " " + cardname;
        costText.text = " " + cost;
        powerText.text = " " + power; 
        DescriptionText.text = " " + description;
        art.sprite = spriteImage;
    
        Hand = GameObject.Find("Hand");
        if(this.transform.parent==Hand.transform.parent){
            cardBack = false;
        }
        staticCardBack = cardBack;

        if(this.tag =="Clone"){
            displayCard[0] = PlayerDeck.staticDeck[numberOfCardsInDeck-1];
            numberOfCardsInDeck -=1;
            PlayerDeck.deckSize -=1;
            cardBack = false;
            this.tag = "Untagged";
        }
    }
}
