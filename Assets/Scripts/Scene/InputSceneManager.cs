using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputSceneManager : MonoBehaviour
{
    /// <summary>
    /// UI
    /// </summary>
    [SerializeField] private InputField nameInputField;
    [SerializeField] private InputField hpInputField;
    [SerializeField] private Toggle isDeadToggle;
    [SerializeField] private Button nextButton;

    /// <summary>
    /// ScriptableObject
    /// </summary>
    [SerializeField] private MonsterSceneData monsterData;

    private void Awake()
    {
        // ScriptableObjectからデータを設定
        nameInputField.text = monsterData.MonsterName;
        hpInputField.text = monsterData.Hp.ToString();
        isDeadToggle.isOn = monsterData.IsDead;

        // ボタン押下処理
        nextButton.onClick.AddListener(() =>
        {
            // 入力データをScriptableObjectに設定
            monsterData.MonsterName = nameInputField.text;
            monsterData.Hp = int.Parse(hpInputField.text);
            monsterData.IsDead = isDeadToggle.isOn;

            // シーン遷移
            SceneManager.LoadScene("ShowScene");
        });
    }
}
