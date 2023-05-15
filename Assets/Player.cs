using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public GameObject CardInStorage; 
    public static List<GameObject> cards = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        cards.Add(CardInStorage);
    }

    // Update is called once per frame
    void Update()
    {
        int numChildren = transform.childCount;
        for (int i = 0; i < numChildren; i++)
        {
            Transform child = transform.GetChild(i);
            cards.Add(child.gameObject);
        } 
        
    }


}
