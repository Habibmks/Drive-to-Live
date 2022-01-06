using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BcMusicScript : MonoBehaviour
{
    public static BcMusicScript bcMusicScript;
    public GameObject muzik;
    public BcMusicScript()
    {
        GameObject muzik = this.muzik;
    }
    private void Awake()
    {
        if (bcMusicScript != null & bcMusicScript != this)
        {
            Destroy(this.gameObject);
            return;
        }
        bcMusicScript = this;
        DontDestroyOnLoad(this);
        
    }
}
