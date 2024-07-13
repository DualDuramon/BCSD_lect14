using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player")) 
        {
            //SceneManager.LoadScene("NextScene");
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        var loadScene = SceneManager.LoadSceneAsync("NextScene");
        while (!loadScene.isDone)
        {
            yield return null;
        }
    }
}
