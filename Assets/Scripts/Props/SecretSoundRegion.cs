using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//秘密房间
public class SecretSoundRegion : MonoBehaviour
{
    bool isTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isTrigger && collision.gameObject.layer == LayerMask.NameToLayer("Hero Detector"))
        {
            isTrigger = true;
            GetComponent<AudioSource>().Play();
        }
    }
}
