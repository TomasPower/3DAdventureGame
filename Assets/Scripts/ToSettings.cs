using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSettings : MonoBehaviour
{

    public string scenename;

    public void PlayScene()
    {
        SceneManager.LoadScene(scenename);
    }
}