using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform balllocation;
    Vector3 fark;
    void Start()
    {
        fark = transform.position-balllocation.position;
    }

    
    void Update()
    {
        if (BallMove.düstü_mü==false) 
        {

            transform.position = balllocation.position + fark;
        }
        
    }
}
