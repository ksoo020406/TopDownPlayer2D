using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �� �ڵ尡 �Է� ���� ���� �����ؼ� �־��ִ� ���̴�...
public class PlayerNameController : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("playerName");
        playerNameText.text = playerName;
    }
}
