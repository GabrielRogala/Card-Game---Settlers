using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHandler : MonoBehaviour
{

    public Card m_card;
    public Text m_id;
    public Text m_name;

    void Start()
    {
        m_id.text = "#" + m_card.cardId;
        m_name.text = m_card.cardName;
    }

}
