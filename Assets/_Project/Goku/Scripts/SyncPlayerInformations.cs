using UnityEngine;
using UnityEngine.Networking;

public class SyncPlayerInformations : NetworkBehaviour
{
    [SyncVar]
    public string m_name = "No_Name";
    [SyncVar]
    public int m_numberOfClick = 0;

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

    public void AddNumberOfClick()
    {
        int num = m_numberOfClick + 1;

        CmdNumberOfClick(num);
    }

    [Command]
    public void CmdNumberOfClick(int num)
    {
        m_numberOfClick = num;
    }
}
