using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerNameController : MonoBehaviour
{
    public Text playerNameText;

    public GameObject PlayerName;

    [SerializeField] private Transform nickNameSpawnPosition;

    private void Start()
    {
        string playerName = PlayerPrefs.GetString("playerName");
        playerNameText.text = playerName;

        GameObject nickName = PlayerNameController.Instantiate(PlayerName); // ����ǰ ����
        nickName.GetComponent<RectTransform>().anchoredPosition = nickNameSpawnPosition.position; // ����ǰ�� ��ġ�� nickNameSpawnPosition�� position�̴�.
    }
}
