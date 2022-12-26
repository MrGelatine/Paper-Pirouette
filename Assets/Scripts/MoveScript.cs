using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */

    // 1 - ����������
    /// �������� �������
    public Vector2 speed = new Vector2(10, 10);

    /// ����������� ��������
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    void Update()
    {
        // 2 - �����������
        movement = new Vector2(
          speed.x * direction.x,
          speed.y * direction.y);
    }

    void FixedUpdate()
    {
        // ��������� �������� � Rigidbody
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
