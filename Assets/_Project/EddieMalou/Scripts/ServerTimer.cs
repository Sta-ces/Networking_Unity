using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class ServerTimer : NetworkBehaviour {

    [SyncVar(hook = "UpdateView")]
    public float m_timeSinceStart;

    public Text m_displayTime;


    public void UpdateView(float time)
    {
        m_displayTime.text = string.Format( "{0:00}:{1:00}",(m_timeSinceStart/60),(m_timeSinceStart%60) );
    }

    public void Update()
    {
        if (!isServer)
            return;

        m_timeSinceStart += Time.deltaTime;
    }
}
