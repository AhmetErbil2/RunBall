using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cikis : MonoBehaviour
{
    public GameObject ExitPanel;
    public bool durdumu=false;

    void Start()
    {
        

        ExitPanel.SetActive(false);
    }
    public void OyunDurdur()
    {
        if (durdumu==false)
        {
            Time.timeScale = 0f;
            durdumu = true;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    
    
    
   
    

    public void butons(int deger) 
    {
        if (deger==1)
        {
            ExitPanel.SetActive(true);
        }
        else if (deger==0)
        {
            ExitPanel.SetActive(false);
        }
        else if(deger==-1) 
        {
            Application.Quit();
        }
    }
    
}
