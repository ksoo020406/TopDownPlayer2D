using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer; // 캐릭터 이미지도 뒤집혀야하구

    private TopDownController controller; // 이게 없으면 함수를 이벤트를 등록할 수 없다.

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        // Awake에서 GetComponent<TopDownController> 해줬으니까 사용 가능!
        controller.OnLookEvent += OnAim; // OnLookEvent에 OnAim 함수를 등록하다.
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 오일러에 넣을 값이기 때문에 디그리로 바꿔줘야한다?

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f; // rotZ값에 따른 캐릭터 이미지 뒤집기.
    }
}
