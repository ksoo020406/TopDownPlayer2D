using System;
using UnityEngine;

public enum StatsChageType
{
    Add, // 0 ex)공+5
    Multiple, // 1 ex)공+5%
    Override // 2 ex)공5 => 공10
}

[Serializable]
public class CharacterStat
{
    public StatsChageType statsChageType;

    [Range(1f, 20f)] public float speed;

    public AttackSO attackSO;
}
