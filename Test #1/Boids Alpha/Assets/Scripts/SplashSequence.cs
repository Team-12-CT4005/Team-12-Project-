using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    private float counter = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        counter = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}
