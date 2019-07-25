using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class CardHandler : MonoBehaviour
{

    public Card m_card = new Card();
    public Text m_id;
    public Text m_name;
    public Text m_description;
    public int m_actionType;
    public Image m_cardType;
    public int m_fractionType;
    public Image m_contract;
    public Image m_cost_1;
    public Image m_cost_2;
    public Image m_cost_3;
    public Image m_cost_4;
    public Image m_gain_1;
    public Image m_gain_2;
    public Image m_gain_3;
    public Image m_gain_4;
    public Image m_image;

    public CardHandler(Card card)
    {
        m_card = card;
    }

    void Start()
    {
        string path = Application.dataPath;

        m_id.text = "#" + m_card.cardId;
        m_name.text = m_card.cardName;
        m_description.text = m_card.description;
        m_actionType = m_card.actionType;
        m_fractionType = m_card.fractionType;
        m_cardType.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Types/" + m_card.cardType + ".png");
        m_contract.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.contract + ".png");

        if (m_card.cost.Count > 0)
        {
            m_cost_1.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.cost[0] + ".png");
        }
        else
        {
            m_cost_1.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.cost.Count > 1)
        {
            m_cost_2.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.cost[1] + ".png");
        }
        else
        {
            m_cost_2.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.cost.Count > 2)
        {
            m_cost_3.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.cost[2] + ".png");
        }
        else
        {
            m_cost_3.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.cost.Count > 3)
        {
            m_cost_4.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.cost[3] + ".png");
        }
        else
        {
            m_cost_4.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }

        if (m_card.gain.Count > 0)
        {
            m_gain_1.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.gain[0] + ".png");
        }
        else
        {
            m_gain_1.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.gain.Count > 1)
        {
            m_gain_2.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.gain[1] + ".png");
        }
        else
        {
            m_gain_2.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.gain.Count > 2)
        {
            m_gain_3.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.gain[2] + ".png");
        }
        else
        {
            m_gain_3.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }
        if (m_card.gain.Count > 3)
        {
            m_gain_4.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + m_card.gain[3] + ".png");
        }
        else
        {
            m_gain_4.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Resources/" + 0 + ".png");
        }

        m_image.sprite = IMG2Sprite.instance.LoadNewSprite(path + "/Sprites/Screens/" + m_card.image + ".png");
    }

}
