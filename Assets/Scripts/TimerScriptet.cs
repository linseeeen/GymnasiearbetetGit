using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  

public class TimerScriptet : MonoBehaviour
{
    public Text timerText;

    float timer = 0.0f;
    bool timerStop = false;
    int seconds;

    void Update()
    {
        if(timerStop == false)
        {
            timer += Time.deltaTime;
            // raderna under ändrar timern till sekunder, oklart om vi behöver det?
            seconds = (int) timer;
            Debug.Log(seconds);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        //Ändra tag till scenebytarens tag
       if (other.transform.tag == "ScenLaddareCoins")
        {
            timerStop = true;
            string visaTimerText = seconds.ToString();
            timerText.text = visaTimerText;
        } 
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

}
