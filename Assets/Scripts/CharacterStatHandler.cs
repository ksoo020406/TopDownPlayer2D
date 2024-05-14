using System.Collections.Generic;
using UnityEngine;

public class CharacterStatHandler : MonoBehaviour
{
    [SerializeField] private CharacterStat baseStats; // 캐릭터 기본 스텟 저장
    public CharacterStat CurrentStat { get; private set; } // 지금 능력치를 저장, 최종 스텟
    public List<CharacterStat> statsModifiers = new List<CharacterStat>(); // 어떤 추가 스텟이 있는지 리스트에 담기

    private void Awake()
    {
        UpdateCharacterStat(); // 업데이트를 먼저 시작해야 기본 능력치가 적용
    }

    private void UpdateCharacterStat()
    {
        // 베이스 스탯을 활용해서 AttackSO랑 CurrentStat 초기화?
        AttackSO attackSO = null;
        if (baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO); // 서로 달라질거라 Instantiate, Instantiate는 서로 다른 개체를 만든다
        }

        CurrentStat = new CharacterStat { attackSO = attackSO }; // 지금은 기본 능력치만 있기때문에 attackSO가 가지고 있는 걸 바로 넣는다.

        // 이 아래로 바뀌거나 추가 될 코드
        CurrentStat.speed = baseStats.speed; 
    }
}
