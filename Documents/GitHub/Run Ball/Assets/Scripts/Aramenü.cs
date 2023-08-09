using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aramenü : MonoBehaviour
{
    public void PauseBut()
    {
        SceneManager.LoadScene(2);
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();
        }
    }
}
