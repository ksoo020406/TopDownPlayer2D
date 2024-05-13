using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 5.0f;

    public GameObject player;

    private void LateUpdate()
    {
        Vector2 dir = player.transform.position - this.transform.position; // 플레이어와 카메라간의 거리를 구한다.
        Vector2 moveVector = new Vector2(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime);
        if(moveVector.magnitude > cameraSpeed * Time.deltaTime) // 어쩌다 보니 카메라가 뒤늦게 스륵 따라오게 되는 걸 막아주긴 했는데... 왜 됐는질 모르겠다;;
        {
            this.transform.Translate(moveVector);
        }
    }
}