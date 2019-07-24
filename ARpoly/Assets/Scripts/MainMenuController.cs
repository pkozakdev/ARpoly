using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    Animator anim;

    public string newGameSceneName;
   

    [Header("Options Panel")]
    public GameObject Main;
    public GameObject AllOptionsPanel;
    public GameObject StartGameOptionsPanel;
    

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

        Main.SetActive(true);
        AllOptionsPanel.SetActive(false);
        StartGameOptionsPanel.SetActive(false);

        
    }

    /**
     *
     * Totally breaks the animations, doesn't come back to main screen.
     *
     * private void Update()
    {
        if (Main.active)
        {
            AllOptionsPanel.SetActive(false);
            StartGameOptionsPanel.SetActive(false);
            
        }if (AllOptionsPanel.active)
        {
            Main.SetActive(false);
            StartGameOptionsPanel.SetActive(false);
            
        }if (StartGameOptionsPanel.active)
        {
            AllOptionsPanel.SetActive(false);
            Main.SetActive(false);
            
        }
        
    }
**/
    #region Open Different panels

    public void openOptions()
    {
        //enable respective panel
      
        AllOptionsPanel.SetActive(true);
        StartGameOptionsPanel.SetActive(false);
      
       

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();

        //enable BLUR
        //Camera.main.GetComponent<Animator>().Play("BlurOn");
       
    }

    public void openStartGameOptions()
    {
        //enable respective panel
        AllOptionsPanel.SetActive(false);
        StartGameOptionsPanel.SetActive(true);
      

        //play anim for opening main options panel
        anim.Play("buttonTweenAnims_on");

        //play click sfx
        playClickSound();

        //enable BLUR
        //Camera.main.GetComponent<Animator>().Play("BlurOn");
        
    }

    
    #endregion

    #region Back Buttons

    public void back_options()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("buttonTweenAnims_off");

        //disable BLUR
       // Camera.main.GetComponent<Animator>().Play("BlurOff");

        //play click sfx
        playClickSound();
    }

    public void back_options_panels()
    {
        //simply play anim for CLOSING main options panel
        anim.Play("OptTweenAnim_off");
        
        //play click sfx
        playClickSound();

    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region Sounds
    public void playHoverClip()
    {
       
    }

    void playClickSound() {

    }


    #endregion
}
