using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards/Basic")]
public class Card : ScriptableObject
{
    public int cardId;
    public string cardName;
}
