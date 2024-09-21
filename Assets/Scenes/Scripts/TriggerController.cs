using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) //�浹����
    {
        if (collision.CompareTag("Player")) //�浹�� ������Ʈ�� �±װ� Player ���
        {
            Debug.Log("�浹");
            ItemGain(); //�浹 ���� ������Ʈ���� itemGain ����
        }
    }

    protected virtual void ItemGain() { } //���� �Լ�
}
