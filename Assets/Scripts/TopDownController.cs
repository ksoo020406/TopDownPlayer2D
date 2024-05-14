using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action은 무조건 void만 반환해야 아니면 Func
    public event Action<Vector2> OnLookEvent;

    protected CharacterStatHandler stats {  get; private set; }

    protected virtual void Awake() // PlayerInputController에 Awake에 영향
    {
        stats = GetComponent<CharacterStatHandler>(); // 버츄얼로 스탯 받기
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ?. 없으면 말고 있으면 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
