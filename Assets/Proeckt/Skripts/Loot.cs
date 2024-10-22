using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            TNT.rid.Take();
            SoundPlayer.regit.Play(clip,1);
            Destroy(gameObject);
        }
    }
}
