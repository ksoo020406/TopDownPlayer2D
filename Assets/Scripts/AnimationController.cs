using UnityEngine;

// 강의 자료 내용 갈취...
// 이녀석이 재활용 가능하도록 만들어 줄 거야!
public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected TopDownController controller;

    // TopDownAnimationController 에 Awake override있다!
    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownController>();
    }
}
