using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Basic")]
public class CardEntity : ScriptableObject
{
    public int cardId;
    public string cardName;
    public string description;
    public int type;
    public int actionType;
    public int contract;
    public int cost;
    public int gain;
    public int image;

    public CardEntity()
    {
        cardId = 0;
        cardName = "New Card";
        description = ".......";
        type = 0;
        actionType = 0;
        contract = 0;
        cost = 0;
        gain = 0;
        image = 0;
    }
}
