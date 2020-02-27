﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// allows for scene loading functions

public class SplashSequence : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    private float counter = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        counter = 10.0f;// sets the counter to 10 seconds to act as a timer for the animations
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;// reduces the float in real time
        if (counter <= 0) // if the counter reaches or is below 0
        {
            StartCoroutine(LoadScene()); // start the animation co routine
        }
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");//Activates the animation trigger end to play a new part of the animation
        yield return new WaitForSeconds(1f);// delays by 1secodn once the end animation is played
        SceneManager.LoadScene(sceneName);//Loads the next scene specified in the inspector
    }
}
