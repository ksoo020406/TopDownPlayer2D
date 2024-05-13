using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;

    private void Awake()
    {
        camera = Camera.main; // mainCamera태그 붙어있는 카메라를 가져온다
    }

    // 실제 움직이는 처리는 여기서 하는 게 아니라 PlayerMoveEvent에서 함
    // TopDownController의 OnMoveEvent를 포함한 CallMoveEvent
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; // normalized! 무조건 길이가 1로...

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            // 마우스에 움직임을 주지 않았을 때도 캐릭터가 마우스를 바라봤으면 좋겠는데 어떻게 해야할까?
            CallLookEvent(newAim);
        }
    }
}
