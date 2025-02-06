using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    public void StartEasy()
    {
        Invoke("StartEasyScene", 1);
    }

    public void StartNormal()
    {
        Invoke("StartNormalScene", 1);
    }

    public void StartHard()
    {
        Invoke("StartHardScene", 1);
    }

    public void StartTutorial()
    {
        Invoke("StartTutorialScene", 1);
    }

    public void StartTitle()
    {
        Invoke("ReturnTitleScene", 1);
    }


    public void StartEasyScene()
    {
        SceneManager.LoadScene("EasyGameScene");
    }

    public void StartNormalScene()
    {
        SceneManager.LoadScene("NormalGameScene");
    }

    public void StartHardScene()
    {
        SceneManager.LoadScene("HardGameScene");
    }

    public void StartTutorialScene()
    {
        SceneManager.LoadScene("TutorialScene");
    }

    public void ReturnTitleScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
