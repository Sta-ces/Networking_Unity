using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SyncPlayersOnline : MonoBehaviour {

    public SyncPlayerInformations[] players;
    public Text m_displayPlayers;
    public Transform m_gameObjectToScale;

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
            foreach(SyncPlayerInformations player in players)
            {

                playersName += player.m_name + "\n";
            }
        }
        else
        {
            playersName = "No Players";
        }

        m_displayPlayers.text = playersName;

        ScalingGenkidama(players.Length);
    }

    public void ScalingGenkidama(float numPlayers)
    {
        m_gameObjectToScale.localScale = Vector3.one * (numPlayers * .5f);
    }
}
