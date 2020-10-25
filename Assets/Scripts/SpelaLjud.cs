using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpelaLjud : MonoBehaviour
{
    
    public AudioSource ljud;

    // Start is called before the first frame update
    void Start()
    {
        ljud = GetComponent<AudioSource> ();
    }


    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.transform.tag == "Player")
        {
            Debug.Log("SÄGÄGAS");
            ljud.Play();
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
       if (other.transform.tag == "Player")
        {
            Debug.Log("SÄGÄGAS");
            ljud.Stop();
        } 
    }
}
