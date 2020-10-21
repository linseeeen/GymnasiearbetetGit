using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  



public class StartScreenLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "StartScreen")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadInstructions());
            }
        }
        if (sceneName == "Instruktioner")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadCoins());
            }
        }
        
    }
    IEnumerator LoadInstructions()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Instruktioner");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadCoins()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Coins");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}