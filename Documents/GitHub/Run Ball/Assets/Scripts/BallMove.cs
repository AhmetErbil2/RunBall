using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMove : MonoBehaviour
{

    Vector3 yön;
    public float hiz;
    public GroudSpawner zeminspawnerscripti;
    public static bool düstü_mü;
    public float eklenecekhýz;
    public static int SonScor;
    
   

    void Start()
    {
        yön = Vector3.forward;

    }

    

    // Update is called once per frame
    void Update()
    {
        



        if (transform.position.y <= 0.7f)
        {
            düstü_mü = true;
        } 
        if(düstü_mü==true)
        {
            
            return;
        }
        if (Input.GetMouseButtonDown(0))
            {

            if (yön.x == 0)
            {
                yön = Vector3.left;
                hiz = hiz + eklenecekhýz * Time.deltaTime;
            }
            else
            {
                yön = Vector3.forward;
            }
            hiz = hiz + eklenecekhýz * Time.deltaTime;
            }

    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön*Time.deltaTime*hiz;
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
