using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Transform m_parentToReturn = null;

    GameObject m_placeholder = null;
    LayoutElement m_layout = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        m_placeholder = new GameObject();
        m_placeholder.transform.SetParent(this.transform.parent);

        if (m_layout == null) {
            m_layout = m_placeholder.AddComponent<LayoutElement>();
        }

        m_placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());

        m_parentToReturn = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;

        Transform placeholderParent = m_placeholder.transform.parent;

        int newSiblingIndex = placeholderParent.childCount;
        for(int i = 0; i< placeholderParent.childCount; i++)
        {
            if(this.transform.position.x < placeholderParent.GetChild(i).position.x)
            {
                newSiblingIndex = i;
                if(m_placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                {
                    newSiblingIndex--;
                }
                break;
            }
            
        }

        m_placeholder.transform.SetSiblingIndex(newSiblingIndex);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(m_parentToReturn);
        this.transform.SetSiblingIndex(m_placeholder.transform.GetSiblingIndex());
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        Destroy(m_placeholder);
    }
}
