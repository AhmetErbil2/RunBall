using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    Vector3 y�n;
    public float hiz;
    public GroudSpawner zeminspawnerscripti;
    public static bool d�st�_m�;
    public float eklenecekh�z;
    public static int SonScor;
    
   

    void Start()
    {
        y�n = Vector3.forward;

    }

    

    // Update is called once per frame
    void Update()
    {
        



        if (transform.position.y <= 0.7f)
        {
            d�st�_m� = true;
        } 
        if(d�st�_m�==true)
        {
            
            return;
        }
        if (Input.GetMouseButtonDown(0))
            {

            if (y�n.x == 0)
            {
                y�n = Vector3.left;
                hiz = hiz + eklenecekh�z * Time.deltaTime;
            }
            else
            {
                y�n = Vector3.forward;
            }
            hiz = hiz + eklenecekh�z * Time.deltaTime;
            }

    }
    private void FixedUpdate()
    {
        Vector3 hareket = y�n*Time.deltaTime*hiz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        
        if (collision.gameObject.tag == "Groud")
        {
            SonScor= Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspawnerscripti.ground_spawn();
            StartCoroutine(ZeminiSil(collision.gameObject));
        }
    }
    IEnumerator ZeminiSil(GameObject SilinecekZemin) 
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    
    }
}
