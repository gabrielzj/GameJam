using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void iniciar()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadSceneAsync(1);
    }

    public void sair()
    {
        Application.Quit();
    }
}
