using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckHandler : MonoBehaviour
{
    public Transform m_dropZone;
    public GameObject m_cardPrefab;
    public List<Card> m_deck;

    void Start()
    {
        m_deck = new List<Card>();
        m_deck.AddRange(DataHandler.instance.GetCards());
    }

    public void DrawCard(int typeOfDeck)
    {
        Debug.Log("Draw card from " + typeOfDeck);
        if (m_deck.Count > 0)
        {
            int cardId = getRandomCardId();
            Card drawedCard = GetCardFromId(getRandomCardId());

            GameObject gameObject = Instantiate(m_cardPrefab, m_dropZone) as GameObject;
            gameObject.GetComponent<CardHandler>().m_card = drawedCard;
        }
    }

    public Card GetCardFromId(int id)
    {
        if (m_deck.Count > 0)
        {
            Card cadrToReturn = m_deck[id];
            m_deck.RemoveAt(id);
            return cadrToReturn;
        }
        return null;
    }

    public int getRandomCardId()
    {
        return Random.Range(0, m_deck.Count);
    }
}
