using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text skoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        skoreText.text = score.ToString();
        
    }
}
