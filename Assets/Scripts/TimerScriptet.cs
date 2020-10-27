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
    bool nyckelCoins = false;
    bool nyckelSkylt = false;
    bool nyckelLjus = false;
    bool nyckelLjud = false;
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
        if(nyckelCoins == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadSign());
            }
        }
        if(nyckelSkylt == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadLight());
            }
        }
        if(nyckelLjus == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadSound());
            }
        }
        if(nyckelLjud == true)
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                StartCoroutine(LoadEnd());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        
        //Ändra tag till scenebytarens tag
       if (other.transform.tag == "ScenLaddareCoins")
        {
            timerStop = true;
            string visaTimerText = seconds.ToString();
            timerText.text = visaTimerText;
            nyckelCoins = true;
        }
        if (other.transform.tag == "ScenLaddareSkylt")
        {
            timerStop = true;
            string visaTimerText = seconds.ToString();
            timerText.text = visaTimerText;
            nyckelSkylt = true;
        }
        if (other.transform.tag == "ScenLaddareLjus")
        {
            timerStop = true;
            string visaTimerText = seconds.ToString();
            timerText.text = visaTimerText;
            nyckelLjus = true;
        }
        if (other.transform.tag == "ScenLaddareLjud")
        {
            timerStop = true;
            string visaTimerText = seconds.ToString();
            timerText.text = visaTimerText;
            nyckelLjud = true;
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
    IEnumerator LoadEnd()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Avslut");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
