using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FullSizeCardHandler : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click :" + eventData.ToString());
        CardViewer.instance.HideFullSizeCard(this.GetComponent<CardViewer>());
    }
}
