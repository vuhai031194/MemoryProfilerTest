using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmptySceneManager : MonoBehaviour
{
    public void LoadTestScene()
    {
        SceneManager.LoadSceneAsync("TestScene");
    }
}
