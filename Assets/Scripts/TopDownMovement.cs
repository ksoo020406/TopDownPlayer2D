using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // 주로 내 컴포넌트안에서 끝나는 걸 어웨이크에 쓴다.
        // 같은 게임오브젝트의 TopDownController, Rigidbody를 가져올 것
        // controller랑 TopDownMovement랑 같은 게임오브젝트 안에 있다는 가정
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // TopDownController.cs 에 OnMoveEvent 변수에 Move를 호출하라고 등록함
        // Awake에서 GetComponent<TopDownController> 해줬으니까 사용 가능!
        movementController.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정해두고 실제로 움직이지는 않음.
        // 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // FixedUpdate는 물리업데이트 관련
        // rigidbody의 값을 바꾸니까 FixedUpdate
        // 물리 업데이트에서 움직임 적용
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5; // 아직 캐릭터의 스탯이 구현되지 않았으므로 임의 스피드 5를 곱해준다.

        movementRigidbody.velocity = direction;
    }
}