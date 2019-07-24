using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip Ping;
    public AudioClip Jingle;
    public AudioClip InitialJingle;

    public AudioSource AudioSource;

    public void Play(int Select)
    {
        
        if (Select == 1)
            
        {
            AudioSource.clip = Ping;
            AudioSource.Play();
        }
        if (Select == 2)
        {
            AudioSource.clip = Jingle;
            AudioSource.Play();
        }
        if (Select == 3)
        {
            AudioSource.clip = InitialJingle;
            AudioSource.Play();
        }
        
    }

    public void buttonPressed()
    {
        AudioSource.clip = Ping;
        AudioSource.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
