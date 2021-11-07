using UnityEngine;

public class Monster : MonoBehaviour
{
    #region �Ǫ��򥻳]�w

    // ���ʳt�� speed
    // �����O attackPW
    // ��q redBlood
    // �l�ܽd�� trackScope
    // �l�ܦ첾 trackMove

    [Header("�Ǫ������ʳt��"),Range(0, 10)]
    public float speed = 3.5f;
    [Range(0, 500)]
    public int attackPW = 100;
    [Range(0, 5000)]
    public int redBlood = 350;
    [Range(0, 50)]
    public int trackScope = 30;
    public Vector3 trackMove;
    #endregion

    #region �Ǫ����[�]�w

    // �����D�� props
    // �������v proBabty

    [Header("�Ǫ��������D��")]
    public bool props;
    [Range(0, 1)]
    public int proBabty = 1;

    // �D�㱼������ propsMusic
    // ���˭��� hurtMusuc
    // �������� attackMusic

    [Header("�D�㱼��������")]
    public string propsMusic;
    public string hurtMusic;
    public string attackMusic;

    // ���Ĩӷ� (AudioSource)
    // 2D ���� (Rigidbody2D)
    // �ʵe��� (Animator)

    private AudioSource music;
    private Rigidbody2D rdbody2D;
    private Animator moveCont;

    #endregion

}
