﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOnline : MonoBehaviour {

    public PlayerInformation[] players;

    [Header("Debug")]
    public Text m_displayPlayers;

    public void Start()
    {
        InvokeRepeating("CheckForPlayer", 0, 1);
    }

    public void CheckForPlayer()
    {
        string playersName = "Players:";
        players = GameObject.FindObjectsOfType<PlayerInformation>();

        if (players.Length > 0)
        {
            for (int i = 0; i < players.Length; i++)
            {
                playersName += players[i].m_name+" ";
            }
        }
        else
        {
            playersName = "No Players";
        }

        m_displayPlayers.text = playersName;
    }
}
