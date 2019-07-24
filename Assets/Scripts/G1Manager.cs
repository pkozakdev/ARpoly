using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class G1Manager : MonoBehaviour
{
    public GameObject DNA;
    public GameObject Heart;
    public GameObject Cell;
    public GameObject Neuron;
    public GameObject Membrane;
    
    public SoundManager SoundsGood;
    private float time = 120;
    private float totalTime = 600;
    public Text counter;
    public Text label;
    public int adjustedTimer;
    
    int[] SoundPlayed = new int[5]{0, 0, 0, 0, 0};
    int[] Countdown = new int[5]{0, 0, 0, 0, 0};

    public void displayTime()
    {
        
        adjustedTimer = Mathf.RoundToInt(time);
        counter.text = adjustedTimer.ToString();

    }

    public void manageAR()
    {
        if (totalTime > 479 && totalTime < 481 && adjustedTimer == 0)
        {
            DNA.SetActive(false);
            Heart.SetActive(true);
            label.text = "Human Heart";
            if (SoundPlayed[1] == 0)
            {
                SoundsGood.Play(3);
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
            Heart.SetActive(false);
            Cell.SetActive(true);
            label.text = "Animal Cell";
            if (SoundPlayed[2] == 0)
            {
                SoundsGood.Play(3);
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
            Cell.SetActive(false);
            Neuron.SetActive(true);
            label.text = "Neuron";
            if (SoundPlayed[3] == 0)
            {
                SoundsGood.Play(3);
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
            Neuron.SetActive(false);
            Membrane.SetActive(true);
            label.text = "Cell Membrane";
            if (SoundPlayed[4] == 0)
            {
                SoundsGood.Play(3);
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
            Membrane.SetActive(false);
            Application.LoadLevel("EndGame");

            

        }
        
        if (adjustedTimer == 5)
        {
            if (Countdown[4] == 0)
            {
                SoundsGood.Play(1);
                Countdown[4] = 1;
            }
        }if (adjustedTimer == 4)
        {
            if (Countdown[3] == 0)
            {
                SoundsGood.Play(1);
                Countdown[3] = 1;
            }
        }if (adjustedTimer == 3)
        {
            if (Countdown[2] == 0)
            {
                SoundsGood.Play(1);
                Countdown[2] = 1;
            }
        }if (adjustedTimer == 2)
        {
            if (Countdown[1] == 0)
            {
                SoundsGood.Play(1);
                Countdown[1] = 1;
            }
        }if (adjustedTimer == 1)
        {
            if (Countdown[0] == 0)
            {
                SoundsGood.Play(1);
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
        DNA.SetActive(true);
        Heart.SetActive(false);
        Cell.SetActive(false);
        Neuron.SetActive(false);
        Membrane.SetActive(false);
        label.text = "DNA";
        displayTime();

        if (SoundPlayed[0] == 0)
        {
            SoundsGood.Play(3);
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
