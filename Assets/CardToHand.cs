using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardToHand : MonoBehaviour
{

    public GameObject Hand;
    public GameObject HandCard;



    // Start is called before the first frame update
    void Start()
    {
        Hand = GameObject.Find("Hand");
        HandCard.transform.SetParent(Hand.transform);
    }


    // Update is called once per frame
    void Update()
    {
        HandCard.transform.localScale = Vector3.one;
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y,-48);
        HandCard.transform.eulerAngles = new Vector3(25,0,0);
        
    }
}
