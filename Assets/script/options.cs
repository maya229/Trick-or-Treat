using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class options : MonoBehaviour
{
    public AudioClip vol;
    public AudioMixer audio;
    // Start is called before the first frame update
    void Start()
    {
        vol = GetComponent<AudioClip>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setVolume(float volume)
    {
        audio.SetFloat("volume", volume);
    }
}
