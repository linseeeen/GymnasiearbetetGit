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
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "StartScreen")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                // Use a coroutine to load the Scene in the background
                StartCoroutine(LoadCoins());
            }
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
