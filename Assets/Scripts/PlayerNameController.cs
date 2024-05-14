using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerNameController : MonoBehaviour
{
    public Text playerNameText;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("playerName");
        playerNameText.text = playerName;
    }
}
