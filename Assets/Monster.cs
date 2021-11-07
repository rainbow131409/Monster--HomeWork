using UnityEngine;

public class Monster : MonoBehaviour
{
    #region 怪物基本設定

    // 移動速度 speed
    // 攻擊力 attackPW
    // 血量 redBlood
    // 追蹤範圍 trackScope
    // 追蹤位移 trackMove

    [Header("怪物的移動速度"),Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)]
    public int attackPW = 100;
    [Range(0, 5000)]
    public int redBlood = 350;
    [Range(0, 50)]
    public int trackScope = 30;
    public Vector3 trackMove;
    #endregion

    #region 怪物附加設定

    // 掉落道具 props
    // 掉落機率 proBabty

    [Header("怪物掉落的道具")]
    public bool props;
    [Range(0, 1)]
    public int proBabty = 1;

    // 道具掉落音效 propsMusic
    // 受傷音效 hurtMusuc
    // 攻擊音效 attackMusic

    [Header("道具掉落的音效")]
    public string propsMusic;
    public string hurtMusic;
    public string attackMusic;

    // 音效來源 (AudioSource)
    // 2D 剛體 (Rigidbody2D)
    // 動畫控制器 (Animator)

    private AudioSource music;
    private Rigidbody2D rdbody2D;
    private Animator moveCont;

    #endregion

}
