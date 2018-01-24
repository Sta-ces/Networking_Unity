using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyncPlayersOnline : MonoBehaviour {

    public SyncPlayerInformations[] players;
    public Text m_displayPlayers;
    public static int m_totalClickPlayers = 0;

    public void Start()
    {
        InvokeRepeating("CheckForPlayer", 0, 1);
    }

    public void CheckForPlayer()
    {
        string playersName = "Players:\n";
        players = GameObject.FindObjectsOfType<SyncPlayerInformations>();

        if (players.Length > 0)
        {
            m_totalClickPlayers = 0;
            foreach (SyncPlayerInformations player in players)
            {
                playersName += player.m_name + "\n";
                m_totalClickPlayers += player.m_numberOfClick;
            }
        }
        else
        {
            playersName = "No Players";
        }

        m_displayPlayers.text = playersName;
    }

    /*public int GetTotalClickPlayers()
    {
        int totalClickPlayers = 0;
        foreach (SyncPlayerInformations player in players)
        {
            totalClickPlayers += player.m_numberOfClick;
            Debug.Log(totalClickPlayers);
        }
        return totalClickPlayers;
    }*/
}
