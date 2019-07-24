using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndgameNavigator : MonoBehaviour
{

    public SoundManager Soundgoodizer;

    private int SoundPlayed = 0;

    // Start is called before the first frame update
   public void Start()
    
    {
        SoundPlayed = 0;
        if (SoundPlayed == 0)
        {
            Soundgoodizer.Play(2);
            SoundPlayed = 1;
        }
    }

    public void NavigateBack(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
   