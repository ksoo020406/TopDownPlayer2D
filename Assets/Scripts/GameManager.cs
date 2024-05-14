using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            return;
        }
        Application.targetFrameRate = 60; // 프레임을 60으로 제한
        Time.timeScale = 1.0f;

        DontDestroyOnLoad(gameObject); // 프레임이 전환돼도 삭제되지 말아요...
    }
}
