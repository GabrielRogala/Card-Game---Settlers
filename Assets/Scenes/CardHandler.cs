using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CardHandler : MonoBehaviour
{

    public CardEntity m_card = new CardEntity();
    public Text m_id;
    public Text m_name;
    public Text m_description;
    public int m_actionType;
    public Image m_type;
    public Image m_contract;
    public Image m_cost;
    public Image m_gain;
    public Image m_image;

    public CardHandler(CardEntity card)
    {
        m_card = card;
    }

    void Start()
    {
        string path = Application.dataPath + "/Sprites/";

        m_id.text = "#" + m_card.cardId;
        m_name.text = m_card.cardName;
        m_description.text = m_card.description;
        m_actionType = m_card.actionType;
        m_type = null;
        m_contract = null;
        m_cost = null;
        m_gain = null;

        m_image.sprite = IMG2Sprite.instance.LoadNewSprite(path + m_card.image + ".png");
    }

}
