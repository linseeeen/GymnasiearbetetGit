using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneLoader : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator LoadSign()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Skylt");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadLight()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Ljus");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadSound()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Ljud");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.transform.tag == "ScenLaddareCoins")
        {
            StartCoroutine(LoadSign());
        }
        if (other.transform.tag == "ScenLaddareSkylt")
        {
            StartCoroutine(LoadLight());
        }
        if (other.transform.tag == "ScenLaddareLjus")
        {
            StartCoroutine(LoadSound());
        }
    }
}
