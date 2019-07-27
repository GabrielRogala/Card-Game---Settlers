using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private int m_playerCount;
    public List<PlayerHandler> m_players = null;
    private int m_roundCounter = 0;

    private static GameHandler _instance;

    public static GameHandler instance
    {
        get
        {
            if (_instance == null)
                _instance = GameObject.FindObjectOfType<GameHandler>();
            return _instance;
        }
    }

    private GameHandler()
    {
        m_players = new List<PlayerHandler>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            EndRound();
            StartRound();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StartGame();
            StartRound();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            m_playerCount++;
            m_players[m_playerCount-1].SetPlayerInformation(m_playerCount, "Player #" + m_playerCount, m_playerCount);
        }
    }

    public void AddPlayer(PlayerHandler player)
    {
        m_players.Add(player);
    }

    public void StartGame()
    {
        foreach (PlayerHandler p in m_players)
        {
            switch (p.m_fractionId)
            {
                case 1: //EGYPTIANS
                    // CARD, POINT, WORKER, PILLAGE, GOLD, FOOD, WOOD, ROCK, FOUNDATION
                    p.UpdateDelta(0, 0, 3, 1, 1, 0, 0, 0, 0);
                    break;
                case 2: //ROMANS
                    p.UpdateDelta(0, 0, 2, 1, 0, 0, 1, 1, 0);
                    break;
                case 3: //JAPANESE
                    p.UpdateDelta(0, 0, 4, 1, 0, 0, 1, 0, 0);
                    break;
                case 4: //BARBARIANS
                    p.UpdateDelta(0, 0, 5, 1, 0, 0, 0, 0, 0);
                    break;
                default:
                    break;
            }
            Debug.Log(p.ToString());
        }
    }

    public void StartRound()
    {
        m_roundCounter++;
        Debug.Log("START round no " + m_roundCounter);
        // update resources
        foreach (PlayerHandler p in m_players)
        {
            p.UpdateResources();
            Debug.Log(p.ToString());
        }
    }

    public void EndRound()
    {
        Debug.Log("END round no " + m_roundCounter);
        // clear resources
        foreach (PlayerHandler p in m_players)
        {
            switch (p.m_fractionId)
            {
                case 1: //EGYPTIANS
                    // CARD, POINT, WORKER, PILLAGE, GOLD, FOOD, WOOD, ROCK, FOUNDATION
                    p.LeaveResources(false, true, false, false, true, false, false, false, true);
                    break;
                case 2: //ROMANS
                    p.LeaveResources(false, true, false, true, false, false, false, false, true);
                    break;
                case 3: //JAPANESE
                    p.LeaveResources(false, true, false, false, false, true, false, false, true);
                    break;
                case 4: //BARBARIANS
                    p.LeaveResources(false, true, true, false, false, false, false, false, true);
                    break;
                default:
                    break;
            }
            Debug.Log(p.ToString());
        }
    }
}



//public enum CardType { CARD, POINT, WORKER, PILLAGE, GOLD, FOOD, WOOD, ROCK }
//public enum ResourcesType { CARD, POINT, WORKER, PILLAGE, GOLD, FOOD, WOOD, ROCK, FOUNDATION }
//public enum FractionType { NONE, EGYPTIANS, ROMANS, JAPANESE, BARBARIANS }


