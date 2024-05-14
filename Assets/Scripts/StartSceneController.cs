using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    public static StartSceneController instance;

    // InputField UI 로 텍스트 입력을 받아...
    public InputField playerNameInput;
    public string playerName;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 씬을 이동해도 지우지 말아요...
        }
        else
        {
            Destroy(gameObject); // 이미 있으면 지워요...
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
            Debug.Log("엔터의 입력으로 넘어가기");
        }
    }

    // Join 버튼 마우스 클릭으로 넘어가기
    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName)) // 이름 입력이 빈칸이 아니다
        {
            // 플레이어 이름 저장
            PlayerPrefs.SetString("playerName", playerName);
            // 게임 시작, 씬 전환
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("이름 입력이 없습니다.");
        }

    }
}
