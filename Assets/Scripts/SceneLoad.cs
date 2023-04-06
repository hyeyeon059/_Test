using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Test();
    }

    public void SceneLoading()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("0406");
    }

    void Test()
    {
        Debug.Log(1);
    }
}
