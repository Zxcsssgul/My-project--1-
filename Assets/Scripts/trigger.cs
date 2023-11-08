using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    //public int levelToLoad;
    //public GameObject frame;
    //public GameObject[] ofherFrames;
    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        frame.SetActive(true);
    //        foreach (GameObject frame in ofherFrames)
    //        {
    //            frame.SetActive(false);
    //        }
    //        SceneManager.LoadScene(levelToLoad);
    //    }
    //}
    //private void OnTriggerEnter2D(Collider2D other)
    //{


    //    Debug.Log("ZXC");
    //    SceneManager.LoadScene(1);

    //}
    public void LoadScene(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
