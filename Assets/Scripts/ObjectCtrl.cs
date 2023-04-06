using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjectCtrl : MonoBehaviour
{
    [SerializeField] private GameObject gamePanel;
    [SerializeField] private TextMeshProUGUI text;
    // TextMeshPro 

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
