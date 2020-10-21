using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class SceneLoader : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        
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
        string sceneName = currentScene.name;
        if (sceneName == "Coins")
        {
            if (other.transform.tag == "ScenLaddareCoins")
            {
                StartCoroutine(LoadSign());
            }
        }
        else if (sceneName == "Skylt")
        {
            if (other.transform.tag == "ScenLaddareSkylt")
            {
                StartCoroutine(LoadLight());
            }
        }
        else if (sceneName == "Ljus")
        {
            if (other.transform.tag == "ScenLaddareLjus")
            {
                StartCoroutine(LoadSound());
            }
        }
    }
}
