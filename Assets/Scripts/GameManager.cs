using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    StartSceneController startSceneController;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Application.targetFrameRate = 60; // �������� 60���� ����
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        //startSceneController = GetComponent<StartSceneController>();
    }
}
