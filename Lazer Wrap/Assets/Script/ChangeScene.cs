using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] int NextScene = 0;

    public void SceneChange()
    {
        SceneManager.LoadScene(NextScene);
    }

}
