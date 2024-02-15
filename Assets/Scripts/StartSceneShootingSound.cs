using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneShootingSound : MonoBehaviour
{
    public AudioClip shooting;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource.PlayOneShot(shooting);
    }
}
