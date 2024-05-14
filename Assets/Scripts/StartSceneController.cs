using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneController : MonoBehaviour
{
    // InputField UI �� �ؽ�Ʈ �Է��� �޾�...
    public InputField playerNameInput;
    public string playerName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartGame();
            Debug.Log("������ �Է����� �Ѿ��");
        }
    }

    // Join ��ư ���콺 Ŭ������ �Ѿ��
    public void StartGame()
    {
        playerName = playerNameInput.text;

        if (!string.IsNullOrEmpty(playerName)) // �̸� �Է��� ��ĭ�� �ƴϴ�
        {
            // �÷��̾� �̸� ����
            PlayerPrefs.SetString("playerName", playerName);
            // ���� ����, �� ��ȯ
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("�̸� �Է��� �����ϴ�.");
        }

    }
}
