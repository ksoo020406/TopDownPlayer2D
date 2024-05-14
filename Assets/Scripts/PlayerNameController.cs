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

        GameObject nickName = PlayerNameController.Instantiate(PlayerName); // 복제품 생성
        nickName.GetComponent<RectTransform>().anchoredPosition = nickNameSpawnPosition.position; // 복제품의 위치는 nickNameSpawnPosition의 position이다.
    }
}
