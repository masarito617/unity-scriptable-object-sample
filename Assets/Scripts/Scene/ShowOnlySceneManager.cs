using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowOnlySceneManager : MonoBehaviour
{
    /// <summary>
    /// UI
    /// </summary>
    [SerializeField] private Text nameText1;
    [SerializeField] private Text hpText1;
    [SerializeField] private Text isDeadText1;
    [SerializeField] private Text nameText2;
    [SerializeField] private Text hpText2;
    [SerializeField] private Text isDeadText2;

    /// <summary>
    /// ScriptableObject
    /// </summary>
    [SerializeField] private MonstersData monstersData;

    private void Awake()
    {
        // ScriptableObjectからデータを設定
        nameText1.text = monstersData.dataList[0].monsterName;
        hpText1.text = monstersData.dataList[0].hp.ToString();
        isDeadText1.text = monstersData.dataList[0].isDead.ToString();
        nameText2.text = monstersData.dataList[1].monsterName;
        hpText2.text = monstersData.dataList[1].hp.ToString();
        isDeadText2.text = monstersData.dataList[1].isDead.ToString();
    }
}
