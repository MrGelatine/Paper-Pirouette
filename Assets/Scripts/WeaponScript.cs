using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    /// Launch projectile
    //--------------------------------
    // 1 � ���������� ���������
    //--------------------------------

    /// ������ ������� ��� ��������
    public Transform shotPrefab;

    /// ����� ����������� � ��������
    public float shootingRate = 0.25f;

    //--------------------------------
    // 2 - �����������
    //--------------------------------

    private float shootCooldown;

    void Start()
    {
        shootCooldown = 0f;
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            shootCooldown -= Time.deltaTime;
        }
    }

    //--------------------------------
    // 3 - �������� �� ������� �������
    //--------------------------------

    /// �������� ����� ������, ���� ��� ��������
    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;

            // �������� ����� �������
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // ���������� ���������
            shotTransform.position = transform.position;

            // �������� �����
            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                shot.isEnemyShot = isEnemy;
            }

            // �������� ���, ����� ������� ������ ��� ��������� �� ����
            MoveScript move = shotTransform.gameObject.GetComponent<MoveScript>();
            if (move != null)
            {
                move.direction = this.transform.right; // � ���������� ������������ ��� ����� ������ �� �������
            }
        }
    }

    /// ������ �� ������ ��������� ����� ������?
    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}