using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShowSceneManager : MonoBehaviour
{
    /// <summary>
    /// UI
    /// </summary>
    [SerializeField] private Text nameText;
    [SerializeField] private Text hpText;
    [SerializeField] private Text isDeadText;
    [SerializeField] private Button backButton;

    /// <summary>
    /// ScriptableObject
    /// </summary>
    [SerializeField] private MonsterSceneData monsterData;

    private void Awake()
    {
        // ScriptableObjectからデータを設定
        nameText.text = monsterData.MonsterName;
        hpText.text = monsterData.Hp.ToString();
        isDeadText.text = monsterData.IsDead.ToString();

        // ボタン押下処理
        backButton.onClick.AddListener(() =>
        {
            // 元のシーンに戻る
            SceneManager.LoadScene("InputScene");
        });
    }
}
