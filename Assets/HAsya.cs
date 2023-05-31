using UnityEngine;
using System.Collections;

public class HAsya : MonoBehaviour
{

    // ���x
    public Vector2 speed = new Vector2(0.05f, 0.05f);
    // �^�[�Q�b�g�ƂȂ�I�u�W�F�N�g
    public GameObject targetObject;
    // ���W�A���ϐ�
    private float rad;
    // ���݈ʒu��������ׂ̕ϐ�
    private Vector2 Position;
    // Use this for initialization
    void Start()
    {
        // ���W�A��
        // atan2(�ڕW������y���W - �����ʒu��y���W, �ڕW������x���W - �����ʒu��x���W)
        // ����Ń��W�A�����o��B
        // ���̃��W�A����Cos��Sin�Ɏg���A����̕����֐i�ނ��Ƃ��o����B
        rad = Mathf.Atan2(
            targetObject.transform.position.y - transform.position.y,
            targetObject.transform.position.x - transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        // ���݈ʒu��Position�ɑ��
        Position = transform.position;
        // x += SPEED * cos(���W�A��)
        // y += SPEED * sin(���W�A��)
        // ����œ���̕����֌������Đi��ł����B
        Position.x += speed.x * Mathf.Cos(rad);
        Position.y += speed.y * Mathf.Sin(rad);
        // ���݂̈ʒu�ɉ��Z���Z���s����Position��������
        transform.position = Position;
    }
}
