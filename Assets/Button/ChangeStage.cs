using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeStage : MonoBehaviour
{
    public string stagename;
    public void SceneChange()
    {
        SceneManager.LoadScene(stagename);
    }
}
