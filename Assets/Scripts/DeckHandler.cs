using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckHandler : MonoBehaviour
{
    public Transform m_dropZone;
    public GameObject m_cardPrefab;
    public List<CardEntity> m_deck;

    void Start()
    {
        m_deck = GenerateDeck(10);
    }

    public void DrawCard(int typeOfDeck)
    {
        Debug.Log("Draw card from " + typeOfDeck);
        if (m_deck.Count > 0)
        {
            int cardId = getRandomCardId();
            CardEntity drawedCard = GetCardFromId(getRandomCardId());

            GameObject gameObject = Instantiate(m_cardPrefab, m_dropZone) as GameObject;
            gameObject.GetComponent<CardHandler>().m_card = drawedCard;
        }
    }

    public List<CardEntity> GenerateDeck(int size)
    {
        List<CardEntity> list = new List<CardEntity>();

        for (int i = 0; i < size; i++)
        {
            CardEntity newCard = ScriptableObject.CreateInstance<CardEntity>();
            newCard.cardId = i;
            newCard.cardName = "New Card #" + i;

            list.Add(newCard);
        }

        return list;
    }

    public CardEntity GetCardFromId(int id)
    {
        if (m_deck.Count > 0)
        {
            CardEntity cadrToReturn = m_deck[id];
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
