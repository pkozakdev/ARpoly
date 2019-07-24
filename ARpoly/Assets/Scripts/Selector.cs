using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{

    public Button m_YourFirstButton, m_YourSecondButton;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(RunGroup1);
        m_YourSecondButton.onClick.AddListener(RunGroup2);
    }

    void RunGroup1()
    {
        Application.LoadLevel("Batch1");
    }
    void RunGroup2()
    {
        Application.LoadLevel("Batch2");
    }
}
