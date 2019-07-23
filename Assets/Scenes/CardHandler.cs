using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHandler : MonoBehaviour
{

    public CardEntity m_card = new CardEntity();
    public Text m_id;
    public Text m_name;

    public CardHandler(CardEntity card) {
        m_card = card;
    }

    void Start()
    {
        m_id.text = "#" + m_card.cardId;
        m_name.text = m_card.cardName;
    }

}
