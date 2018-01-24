using UnityEngine;
using UnityEngine.Networking;

public class SyncPlayerInformations : NetworkBehaviour
{

    [SyncVar]
    public string m_name = "No_Name";

    public void SetName(string name)
    {
        CmdChangeName(name);
    }

    [Command]
    public void CmdChangeName(string name)
    {
        m_name = name;
        gameObject.name = m_name;
    }
}
