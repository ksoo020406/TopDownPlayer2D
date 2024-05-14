using UnityEngine;

public class CameraController : MonoBehaviour
{
    private CharacterStatHandler characterStatHandler;

    public float cameraSpeed = 5.0f;

    [SerializeField] GameObject[] players;

    int nowPlayerIndex = -1;
    //private GameObject nowPlayer;


    private void Start()
    {
        if(players.Length < 1)
        {
            Debug.Log("Player Not Set");
            return;
        }

        nowPlayerIndex = 0;

        characterStatHandler = players[nowPlayerIndex].GetComponent<CharacterStatHandler>();
        if(characterStatHandler == null )
        {
            Debug.Log("Character Stat Handler is not found!!!");
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            nowPlayerIndex++;
            if(nowPlayerIndex >= players.Length) // 참조할 수 있는 범위를 넘어가면 0으로 되돌리기
            {
                nowPlayerIndex = 0;
            }

            characterStatHandler = players[nowPlayerIndex].GetComponent<CharacterStatHandler>();
        }
    }

    private void LateUpdate()
    {
        if(characterStatHandler != null)
        {
            cameraSpeed = characterStatHandler.CurrentStat.speed;
        }
        else
        {
            cameraSpeed = 5.0f;
        }

        Vector2 dir = players[nowPlayerIndex].transform.position - this.transform.position; // 플레이어와 카메라간의 거리를 구한다.
        Vector2 moveVector = new Vector2(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime);
        if(moveVector.magnitude > cameraSpeed * Time.deltaTime) // 어쩌다 보니 카메라가 뒤늦게 스륵 따라오게 되는 걸 막아주긴 했는데... 왜 됐는질 모르겠다;;
        {
            this.transform.Translate(moveVector);
        }
    }
}
