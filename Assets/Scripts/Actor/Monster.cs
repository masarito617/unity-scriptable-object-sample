using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private string deadMessage;
    [SerializeField] private string shockMessage;
    [SerializeField] private GameEvent deadEvent;

    private bool _isDead = false;

    /// <summary>
    /// 死亡する
    /// </summary>
    public void Dead()
    {
        if (_isDead) return;

        // 雄叫びをあげながら死亡
        _isDead = true;
        Debug.Log($"<color=red>{gameObject.name}: {deadMessage}</color>");

        // 死亡イベントを発行する
        deadEvent.Raise();
    }

    /// <summary>
    /// 仲間の死亡通知を受ける
    /// </summary>
    public void NotifyFriendDead()
    {
        if (_isDead) return;

        // ショックを受ける
        Debug.Log($"<color=cyan>{gameObject.name}: {shockMessage}</color>");
    }
}
