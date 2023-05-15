using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAll : MonoBehaviour
{
    public Transform grid;
    public GameObject cardPref;
    public Carddatabase cardDatabase;

    private HashSet<int> instantiatedCardIds = new HashSet<int>();

    void Start()
    {
        
        foreach (Transform child in grid)
        {
            Destroy(child.gameObject);
        }

        
        List<Card> allCards = Carddatabase.database;
        for (int i = 0; i < allCards.Count; i++) 
        {
           
            if (instantiatedCardIds.Contains(allCards[i].id))
            {
                continue;
            }

            
            GameObject newCard = Instantiate(cardPref, grid);
            Display cardDisplay = newCard.GetComponent<Display>();
            cardDisplay.id = allCards[i].id;
            cardDisplay.cardname = allCards[i].cardname;
            cardDisplay.cost = allCards[i].cost;
            cardDisplay.power = allCards[i].power;
            cardDisplay.description = allCards[i].description;
            cardDisplay.spriteImage = allCards[i].spriteImage;

            
            cardDisplay.nameText.text = cardDisplay.cardname.ToString();
            cardDisplay.costText.text = cardDisplay.cost.ToString();
            cardDisplay.powerText.text = cardDisplay.power.ToString();
            cardDisplay.DescriptionText.text = cardDisplay.description.ToString();
            Image cardImage = cardDisplay.GetComponent<Image>();
            cardImage.sprite = allCards[i].spriteImage;

            
            instantiatedCardIds.Add(allCards[i].id);
        }
    }

    void Update()
    {
        
    }
}
