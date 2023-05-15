using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    
    public void OnPointerEnter(PointerEventData eventData){

        
    }

    public void OnDrop(PointerEventData eventData){
        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d!=null){
            d.parentToReturnTo = this.transform;
     
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
