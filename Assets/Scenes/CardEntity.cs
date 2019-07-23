using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Basic")]
public class CardEntity : ScriptableObject
{
    public int cardId;
    public string cardName;

    public CardEntity() {
        cardId = 0;
        cardName = "New Card";
    }

    //public CardEntity(int cardId, string cardName)
    //{
    //    this.cardId = cardId;
    //    this.cardName = cardName;
    //}
}
