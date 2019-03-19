using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    enum Scenes { StartScene, MainScene, GameoverScene };


    void Start()
    {

    }


    void Update()
    {

    }
    public  void LoadStartScene()
    {
        SceneManager.LoadScene((int)Scenes.StartScene);
    }

    public static void LoadMainGameScene()
    {
        SceneManager.LoadScene((int)Scenes.MainScene);
    }

    public static void LoadGameOverScene()
    {
        SceneManager.LoadScene((int)Scenes.GameoverScene);
    }
}