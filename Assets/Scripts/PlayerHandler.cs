using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    public int m_id = 0;
    public string m_name = "Name";
    public int m_fractionId = 0;

    public int m_card = 0;
    public int m_point = 0;
    public int m_worker = 0;
    public int m_pillage = 0;
    public int m_gold = 0;
    public int m_food = 0;
    public int m_wood = 0;
    public int m_rock = 0;
    public int m_foundation = 0;

    public int m_deltaCard = 0;
    public int m_deltaPoint = 0;
    public int m_deltaWorker = 0;
    public int m_deltaPillage = 0;
    public int m_deltaGold = 0;
    public int m_deltaFood = 0;
    public int m_deltaWood = 0;
    public int m_deltaRock = 0;
    public int m_deltaFoundation = 0;

    // UI
    public Text m_playerText;
    public Text m_cardText;
    public Text m_pointLabelText;
    public Text m_workerLabelText;
    public Text m_pillageText;
    public Text m_goldText;
    public Text m_foodText;
    public Text m_woodText;
    public Text m_rockText;
    public Text m_foundationText;
    public Text m_deltaCardText;
    public Text m_deltaPointText;
    public Text m_deltaWorkerText;
    public Text m_deltaPillageText;
    public Text m_deltaGoldText;
    public Text m_deltaFoodText;
    public Text m_deltaWoodText;
    public Text m_deltaRockText;
    public Text m_deltaFoundationText;


    void Start()
    {
        GameHandler.instance.AddPlayer(this);
    }

    public void SetPlayerInformation(int m_id, string m_name, int m_fractionId)
    {
        this.m_id = m_id;
        this.m_name = m_name;
        this.m_fractionId = m_fractionId;
        m_playerText.text = "#" + m_id + " " + m_name;

        TextUpdate();
    }

    public void AddResources(int m_card, int m_point, int m_worker, int m_pillage, int m_gold, int m_food, int m_wood, int m_rock, int m_foundation)
    {
        this.m_card += m_card;
        this.m_point += m_point;
        this.m_worker += m_worker;
        this.m_pillage += m_pillage;
        this.m_gold += m_gold;
        this.m_food += m_food;
        this.m_wood += m_wood;
        this.m_rock += m_rock;
        this.m_foundation += m_foundation;
        TextUpdate();
    }

    public void UpdateDelta(int m_deltaCard, int m_deltaPoint, int m_deltaWorker, int m_deltaPillage, int m_deltaGold, int m_deltaFood, int m_deltaWood, int m_deltaRock, int m_deltaFoundation)
    {
        this.m_deltaCard += m_deltaCard;
        this.m_deltaPoint += m_deltaPoint;
        this.m_deltaWorker += m_deltaWorker;
        this.m_deltaPillage += m_deltaPillage;
        this.m_deltaGold += m_deltaGold;
        this.m_deltaFood += m_deltaFood;
        this.m_deltaWood += m_deltaWood;
        this.m_deltaRock += m_deltaRock;
        this.m_deltaFoundation += m_deltaFoundation;
        TextUpdate();
    }

    public void UpdateResources()
    {
        this.m_card += m_deltaCard;
        this.m_point += m_deltaPoint;
        this.m_worker += m_deltaWorker;
        this.m_pillage += m_deltaPillage;
        this.m_gold += m_deltaGold;
        this.m_food += m_deltaFood;
        this.m_wood += m_deltaWood;
        this.m_rock += m_deltaRock;
        this.m_foundation += m_deltaFoundation;
        TextUpdate();
    }

    // attr: true - leave, false - clear
    public void LeaveResources(bool m_card, bool m_point, bool m_worker, bool m_pillage, bool m_gold, bool m_food, bool m_wood, bool m_rock, bool m_foundation)
    {
        this.m_card *= Convert.ToInt32(m_card);
        this.m_point *= Convert.ToInt32(m_point);
        this.m_worker *= Convert.ToInt32(m_worker);
        this.m_pillage *= Convert.ToInt32(m_pillage);
        this.m_gold *= Convert.ToInt32(m_gold);
        this.m_food *= Convert.ToInt32(m_food);
        this.m_wood *= Convert.ToInt32(m_wood);
        this.m_rock *= Convert.ToInt32(m_rock);
        this.m_foundation *= Convert.ToInt32(m_foundation);
        TextUpdate();
    }

    public void TextUpdate()
    {

        m_cardText.text = m_card.ToString();
        m_pointLabelText.text = m_point.ToString();
        m_workerLabelText.text = m_worker.ToString();
        m_pillageText.text = m_pillage.ToString();
        m_goldText.text = m_gold.ToString();
        m_foodText.text = m_food.ToString();
        m_woodText.text = m_wood.ToString();
        m_rockText.text = m_rock.ToString();
        m_foundationText.text = m_foundation.ToString();
        m_deltaCardText.text = "+" + m_deltaCard;
        m_deltaPointText.text = "+" + m_deltaPoint;
        m_deltaWorkerText.text = "+" + m_deltaWorker;
        m_deltaPillageText.text = "+" + m_deltaPillage;
        m_deltaGoldText.text = "+" + m_deltaGold;
        m_deltaFoodText.text = "+" + m_deltaFood;
        m_deltaWoodText.text = "+" + m_deltaWood;
        m_deltaRockText.text = "+" + m_deltaRock;
        m_deltaFoundationText.text = "+" + m_deltaFoundation;
    }

    public override string ToString()
    {
        string str = "";

        str += m_name + " [ " + m_card + " +" + m_deltaCard + " | " +
        m_point + " +" + m_deltaPoint + " | " +
        m_worker + " +" + m_deltaWorker + " | " +
        m_pillage + " +" + m_deltaPillage + " | " +
        m_gold + " +" + m_deltaGold + " | " +
        m_food + " +" + m_deltaFood + " | " +
        m_wood + " +" + m_deltaWood + " | " +
        m_rock + " +" + m_deltaRock + " | " +
        m_foundation + "+" + m_deltaFoundation + " ]";

        return str;
    }

    public void ShowPlayerBoard()
    {
        Debug.Log("Show board "+this.m_name);
        Transform parentToReturn = this.transform.parent;
        this.transform.SetParent(parentToReturn.parent);
        this.transform.SetParent(parentToReturn);
    }

}
