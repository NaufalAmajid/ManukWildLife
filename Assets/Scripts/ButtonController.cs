﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public Animator loader;

    public float loaderTime = 1f;

    public AudioSource clickAudio;

    public void MainMenu()
    {

        SceneManager.LoadScene(0);

        Time.timeScale = 1f;
        
    }

    public void NewGame(){

        PlayerPrefs.DeleteKey("p_x");
        PlayerPrefs.DeleteKey("p_y");
        PlayerPrefs.DeleteKey("p_z");

        PlayerPrefs.DeleteKey("TimeToLoad");
        PlayerPrefs.DeleteKey("Saved");
        StartCoroutine(FadeLoader(SceneManager.GetActiveScene().buildIndex + 1));

    }

    public void PlayGame(){

        StartCoroutine(FadeLoader(SceneManager.GetActiveScene().buildIndex + 2));

    }

    public void QuitGame(){

        Application.Quit();
        Debug.Log("Quit Game");

    }

    IEnumerator FadeLoader(int SceneIndex)
    {
        //loader.SetBool("Start", true);

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(SceneIndex);

    }

    public void Clicker(){

        clickAudio.Play();

    }


}
