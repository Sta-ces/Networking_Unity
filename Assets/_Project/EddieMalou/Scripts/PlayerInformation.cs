using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerInformation : NetworkBehaviour {

    [SyncVar]
    public string m_name;

    public void SetName(string name)
    {
        CmdChangeName(name);
    }

    [Command]
    public void CmdChangeName(string name)
    {
        Debug.Log("Command Change Name : " + name);
        m_name = name;
        gameObject.name = m_name;
    }
}
