using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DropStorage : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Text messageText;
    public float fadeDuration = .5f;

    private Coroutine fadeOutCoroutine;


    private IEnumerator FadeOutMessage()
    {
        float elapsedTime = 0f;
        Color startColor = messageText.color;

        // Fade out
        while (elapsedTime < fadeDuration)
        {
            messageText.color = Color.Lerp(startColor, Color.clear, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // After fading, deactivate the message text
        messageText.gameObject.SetActive(false);
    }
    public void OnPointerEnter(PointerEventData eventData){

        
    }

    public void OnDrop(PointerEventData eventData)
    {
        DragStorage d = eventData.pointerDrag.GetComponent<DragStorage>();
        if (d != null)
        {
            Transform parentTransform = this.transform;

            // Check if the number of children is less than 10 before allowing the drop
            if (parentTransform.childCount < 10)
            {
                d.parentToReturnTo = parentTransform;
            }
            else
            {
                messageText.text = "Limit reached - cannot drop more items.";
                messageText.gameObject.SetActive(true);
                fadeOutCoroutine = StartCoroutine(FadeOutMessage());
            }
        }
    }


    public void OnPointerExit(PointerEventData eventData){
        
    }


    // Start is called before the first frame update
    void Start()
    {
        messageText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
