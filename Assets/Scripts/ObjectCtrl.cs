using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCtrl : MonoBehaviour
{
    [SerializeField] private GameObject gamePanel;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gamePanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gamePanel.SetActive(false);
        }


    }
}
