using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo =null;
    public AudioSource Gahyeon;
    public AudioSource Yoohyeon;
    public AudioSource Siyeon;
    public AudioSource Jiu;
    public AudioSource Dami;
    public AudioSource Sua;
    public AudioSource Handong;
    public AudioSource Jisoo;
    public AudioSource Jennie;
    public AudioSource Song;
    public GameObject card = null;
    private DisplayCard displayCard;

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        
        displayCard = card.GetComponent<DisplayCard>();
        int cardId = displayCard.id;
        if(cardId==0){
            Song.time = 29;
            Song.Play();
        }
        if(cardId == 1){
            Yoohyeon.time = 34f;
            Yoohyeon.Play();
        }
        else if(cardId==2){
            Jiu.time = 108.5f;
            Jiu.Play();
        }
        else if (cardId==3){
            Dami.Play();
        }else if (cardId==4){
            Sua.time = 9;
            Sua.Play();
        }else if(cardId==5){
            Gahyeon.time = 100f;
            Gahyeon.Play();
        }
        
        else if(cardId==6){
            Siyeon.time = 40;
            Siyeon.Play();
        }
        
        else if (cardId==7){
            Handong.time = 122;
            Handong.Play();
        }
        else if (cardId==8){
            Jennie.time = 51;
            Jennie.Play();
        }
        else if (cardId==11){
            Jisoo.time = 62;
            Jisoo.Play();
        }
        parentToReturnTo =this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
      
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        displayCard = card.GetComponent<DisplayCard>();
        int cardCost = displayCard.cost;
        if(cardCost==1){
            Song.Play();
        }
        Yoohyeon.Stop();
        Dami.Stop();
        Gahyeon.Stop();
        Sua.Stop();
        Handong.Stop();
        Siyeon.Stop();
        Jiu.Stop();
        Jisoo.Stop();
        Jennie.Stop();
        Song.Stop();
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
   
    }
    // Start is called before the first frame update
void Start()
    {
    }
  
    // Update is called once per frame
    void Update()
    {
        if(Yoohyeon.time>=44){
            Yoohyeon.time = 34f;
        }
        if (Sua.time >= 18.5)
        {
            
            Sua.time = 9;
        }
        if(Handong.time >=131){
            Handong.time = 122;
        }
        if(Jiu.time>=119){
            Jiu.time = 108;
        }
        if(Siyeon.time>=52){
            Siyeon.time = 40;
        }
        if(Gahyeon.time>=109){
            Gahyeon.time = 100f;
        }
        if(Jisoo.time>=70){
            Jisoo.time = 62;
        }
         if(Jennie.time>=60){
            Jennie.time = 51;
        }
        if(Song.time>=50){
            Song.time = 29;
        }

    }
}
