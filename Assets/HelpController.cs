using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpController : MonoBehaviour
{
    public void voltar()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
