using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 이 코드가 입력 받은 문자 저장해서 넣어주는 것이다...
public class PlayerNameController : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("playerName");
        playerNameText.text = playerName;
    }
}
