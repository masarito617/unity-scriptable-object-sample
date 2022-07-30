using UnityEngine;
using UnityEngine.UI;

public class EventSceneManager : MonoBehaviour
{
    [SerializeField] private Button deadMonster1Button;
    [SerializeField] private Button deadMonster2Button;
    [SerializeField] private Button deadMonster3Button;
    [SerializeField] private Monster monster1;
    [SerializeField] private Monster monster2;
    [SerializeField] private Monster monster3;

    private void Awake()
    {
        // ボタンに応じたモンスターを死亡させる
        deadMonster1Button.onClick.AddListener(() => monster1.Dead());
        deadMonster2Button.onClick.AddListener(() => monster2.Dead());
        deadMonster3Button.onClick.AddListener(() => monster3.Dead());
    }
}
