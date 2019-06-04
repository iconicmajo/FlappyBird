using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolControl : MonoBehaviour
{
    private AudioSource source;
    public AudioClip backSound;
    private float volLowRange = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        source.volume = volLowRange;
    }

    public void setVolume(float vol)
    {
        volLowRange = vol; 
    }
}
