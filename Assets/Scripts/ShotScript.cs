using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    // 1 � ���������� ���������
    /// ����������� ����
    public int damage = 1;

    /// ������ ������� ����������� ������ ��� ������?
    public bool isEnemyShot = false;

    void Start()
    {
        // ������������ ����� �����, ����� �������� ������
        Destroy(gameObject, 20); // 20 ������
    }
}