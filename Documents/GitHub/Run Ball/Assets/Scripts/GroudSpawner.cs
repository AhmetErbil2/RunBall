using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroudSpawner : MonoBehaviour
{
    public GameObject son_zemin;
    
    

    
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            ground_spawn();
        }
    }
    public void ground_spawn()
    {
        Vector3 y�n;

        if (Random.Range(0,2)==0)
        {
            y�n = Vector3.left;
        }
        else 
        { 
            y�n= Vector3.forward;
        }

        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + y�n, son_zemin.transform.rotation);
    }
}
