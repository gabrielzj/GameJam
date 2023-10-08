using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptCont : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

