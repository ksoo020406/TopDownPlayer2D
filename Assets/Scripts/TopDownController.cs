using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action�� ������ void�� ��ȯ�ؾ� �ƴϸ� Func
    public event Action<Vector2> OnLookEvent;

    protected CharacterStatHandler stats {  get; private set; }

    protected virtual void Awake() // PlayerInputController�� Awake�� ����
    {
        stats = GetComponent<CharacterStatHandler>(); // ������ ���� �ޱ�
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ?. ������ ���� ������ ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
