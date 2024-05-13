using UnityEngine;

public class TopDownAnimationController : AnimationController
{
    // 해쉬 만들기 작업, 해쉬? 문자열 계산 대신 숫자로 받아 읽을 수 있게 하는 처리
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    // 너무 조금 움직였을 때는 멈춘 상태로 처리하기 위한 변수
    private readonly float magnituteThreshold = 0.5f;

    // AnimationController 의 Awake override
    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    // 어떤 방향으로 움직이게 될지 백터가 들어오게 될것
    private void Move(Vector2 vector)
    {
        animator.SetBool(IsWalking, vector.magnitude > magnituteThreshold);
    }
}