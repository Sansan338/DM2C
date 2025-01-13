using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour
{
    private void Start()
    {
        
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
