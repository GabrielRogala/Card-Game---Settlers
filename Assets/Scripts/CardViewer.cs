using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardViewer : MonoBehaviour
{

    public GameObject m_cardFullSizePrefab;
    public Transform m_parent;
    private GameObject fullSizeCard;
    private bool isShowed = false;

    private static CardViewer _instance;

    public static CardViewer instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<CardViewer>();
            return _instance;
        }
    }

    public void ShowFullSizeCard(Card card)
    {
        if (isShowed)
        {
            fullSizeCard.GetComponent<CardHandler>().m_card = card;
        }
        else
        {
            fullSizeCard = Instantiate(m_cardFullSizePrefab, m_parent) as GameObject;
            fullSizeCard.GetComponent<CardHandler>().m_card = card;
            isShowed = true;
        }
    }

    public void HideFullSizeCard(CardViewer card)
    {
        if (isShowed)
        {
            Destroy(fullSizeCard);
            isShowed = false;
        }
        else
        {

        }
    }
}
