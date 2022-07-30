using UnityEngine;

/// <summary>
/// Monster単一データ
/// </summary>
[CreateAssetMenu(fileName = "MonsterData", menuName = "SampleGame/MonsterData")]
public class MonsterData : ScriptableObject
{
    /// <summary>
    /// 名前
    /// </summary>
    public string monsterName;

    /// <summary>
    /// HP
    /// </summary>
    public int hp;

    /// <summary>
    /// 死亡しているか？
    /// </summary>
    public bool isDead;
}
