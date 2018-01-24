using UnityEngine;
using UnityEngine.Networking;

public class SyncScaleGenkidama : NetworkBehaviour
{
    [SyncVar]
    public int m_numberPlayers;

    public Transform m_gameObjectToScale;

    private void Start()
    {
        m_gameObjectToScale = GameObject.Find("Genkidama").transform;
    }

    public void ScalingGenkidama()
    {
        CmdGenkidama(SyncPlayersOnline.m_totalClickPlayers);
    }

    [Command]
    public void CmdGenkidama(int num)
    {
        Debug.Log("MORE POWER!");

        m_numberPlayers = 1 + num / 10;
        m_gameObjectToScale.localScale = new Vector3(m_numberPlayers, m_numberPlayers, m_numberPlayers);
    }
}
