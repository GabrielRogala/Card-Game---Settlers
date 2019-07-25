using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public int cardId;
    public string cardName;
    public string description;
    public int cardType;
    public int fractionType;
    public int actionType;
    public int contract;
    public List<int> cost;
    public List<int> gain;
    public int image;

    public Card()
    {
        cardId = 0;
        cardName = "New Card";
        description = ".......";
        cardType = 0;
        fractionType = 0;
        actionType = 0;
        contract = 0;
        cost = new List<int>();
        gain = new List<int>();
        image = 0;
    }

    public override string ToString()
    {
        string str = "#" + cardId + " " + cardName + " <" + description + "> " + cardType + " " + fractionType + " " + actionType + " " + contract + " ";
        str += "[ ";
        foreach (int c in cost)
        {
            str += c + " ";
        }
        str += "] [ ";
        foreach (int g in gain)
        {
            str += g + " ";
        }
        str += "] " + image;

        return str;
    }
}