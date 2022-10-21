 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string scene_name;

    public void SwitchScene()
    {
        SceneManager.LoadScene(scene_name);
    }
}
