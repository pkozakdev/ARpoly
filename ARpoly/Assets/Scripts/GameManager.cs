using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;
    
    public SoundManager audioPlayer;
    private float time = 120;
    private float totalTime = 600;
    public Text counter;
    public Text label;
    public int adjustedTimer;
    
    int[] SoundPlayed = new int[5]{0, 0, 0, 0, 0};
    int[] Countdown = new int[5]{0, 0, 0, 0, 0};

    
    
    
    public void skipModel()
    {
        if (totalTime > 485 && totalTime < 600)
        {
            time = 0;
            adjustedTimer = 0;
            totalTime = 481;
            
        }if (totalTime > 365 && totalTime < 480)
        {
            time = 0;
            adjustedTimer = 0;
            totalTime = 361;
            
        }if (totalTime > 245 && totalTime < 360)
        {
            time = 0;
            adjustedTimer = 0;
            totalTime = 241;
            
        }if (totalTime > 125 && totalTime < 240)
        {
            time = 0;
            adjustedTimer = 0;
            totalTime = 121;
            
        }if (totalTime > 5 && totalTime < 120)
        {
            time = 0;
            adjustedTimer = 0;
            totalTime = 1;
        }
        displayTime();
        manageAR();
    }

    public void displayTime()
    {
        
        adjustedTimer = Mathf.RoundToInt(time);
        counter.text = adjustedTimer.ToString();

    }

    public void manageAR()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (totalTime > 479 && totalTime < 481 && adjustedTimer == 0)
        {
            Object1.SetActive(false);
            Object2.SetActive(true);
            if (sceneName == "Batch1")
            {
                label.text = "Human Heart";
            }if (sceneName == "Batch2")
            {
                label.text = "Human Spine";
            }

            if (SoundPlayed[1] == 0)
            {
                audioPlayer.Play(3);
                SoundPlayed[1] = 1;
                
            }
            time = 120;
            for (int i = 0; i < Countdown.Length; i++)
            {
                Countdown[i] = 0;
            }
           
        }
        if (totalTime > 359 && totalTime < 361 && adjustedTimer == 0)
        {
            Object2.SetActive(false);
            Object3.SetActive(true);
            if (sceneName == "Batch1")
            {
                label.text = "Animal Cell";
            }if (sceneName == "Batch2")
            {
                label.text = "Chloroplast";
            }
            
            if (SoundPlayed[2] == 0)
            {
                audioPlayer.Play(3);
                SoundPlayed[2] = 1;
            }
            time = 120;
            for (int i = 0; i < Countdown.Length; i++)
            {
                Countdown[i] = 0;
            }
           
        }
        if (totalTime > 239 && totalTime < 241 && adjustedTimer == 0)
        {
            Object3.SetActive(false);
            Object4.SetActive(true);
            if (sceneName == "Batch1")
            {
                label.text = "Neuron";
            }if (sceneName == "Batch2")
            {
                label.text = "T4 Bacteriophage Virus";
            }
            if (SoundPlayed[3] == 0)
            {
                audioPlayer.Play(3);
                SoundPlayed[3] = 1;
            }
            time = 120;
            for (int i = 0; i < Countdown.Length; i++)
            {
                Countdown[i] = 0;
            }
           
        }
        if (totalTime > 119 && totalTime < 121 && adjustedTimer == 0)
        {
            Object4.SetActive(false);
            Object5.SetActive(true);
            if (sceneName == "Batch1")
            {
                label.text = "Cell Membrane";
            }if (sceneName == "Batch2")
            {
                label.text = "Human Brain";
            }
            if (SoundPlayed[4] == 0)
            {
                audioPlayer.Play(3);
                SoundPlayed[4] = 1;
            }
            time = 120;
            for (int i = 0; i < Countdown.Length; i++)
            {
                Countdown[i] = 0;
            }
           
        }
        if (totalTime > 0 && totalTime < 1)
        {
            Object5.SetActive(false);
            Application.LoadLevel("EndGame");

            

        }
        
        if (adjustedTimer == 5)
        {
            if (Countdown[4] == 0)
            {
                audioPlayer.Play(1);
                Countdown[4] = 1;
            }
        }if (adjustedTimer == 4)
        {
            if (Countdown[3] == 0)
            {
                audioPlayer.Play(1);
                Countdown[3] = 1;
            }
        }if (adjustedTimer == 3)
        {
            if (Countdown[2] == 0)
            {
                audioPlayer.Play(1);
                Countdown[2] = 1;
            }
        }if (adjustedTimer == 2)
        {
            if (Countdown[1] == 0)
            {
                audioPlayer.Play(1);
                Countdown[1] = 1;
            }
        }if (adjustedTimer == 1)
        {
            if (Countdown[0] == 0)
            {
                audioPlayer.Play(1);
                Countdown[0] = 1;
            }
        }
    }
  
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Countdown.Length; i++)
        {
            Countdown[i] = 0;
        }
        for (int i = 0; i < SoundPlayed.Length; i++)
        {
            SoundPlayed[i] = 0;
        }
        Object1.SetActive(true);
        Object2.SetActive(false);
        Object3.SetActive(false);
        Object4.SetActive(false);
        Object5.SetActive(false);
        
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        
        if (sceneName == "Batch1")
        {
            label.text = "DNA";
        }if (sceneName == "Batch2")
        {
            label.text = "Human Skin";
        }
        
        displayTime();

        if (SoundPlayed[0] == 0)
        {
            audioPlayer.Play(3);
            SoundPlayed[0] = 1;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        totalTime -= Time.deltaTime;
        time -= Time.deltaTime;

        displayTime();

        manageAR();
       
        

    }
}
