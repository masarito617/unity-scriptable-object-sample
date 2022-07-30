using System;
using UnityEngine;

/// <summary>
/// Scene遷移パラメータ
/// </summary>
[CreateAssetMenu(fileName = "MonsterSceneData", menuName = "SampleGame/MonsterSceneData")]
public class MonsterSceneData : ScriptableObject, ISerializationCallbackReceiver
{
    /// <summary>
    /// 名前
    /// </summary>
    [SerializeField] private string initMonsterName;
    [NonSerialized] public string MonsterName;

    /// <summary>
    /// HP
    /// </summary>
    [SerializeField] private int initHp;
    [NonSerialized] public int Hp;

    /// <summary>
    /// 死亡しているか？
    /// </summary>
    [SerializeField] private bool initIsDead;
    [NonSerialized] public bool IsDead;

    public void OnBeforeSerialize() { }
    public void OnAfterDeserialize()
    {
        // ランタイムでの書き込み用に値をコピーする
        MonsterName = initMonsterName;
        Hp = initHp;
        IsDead = initIsDead;
    }
}
