using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    // 1 – Переменная дизайнера
    /// Причиненный вред
    public int damage = 1;

    /// Снаряд наносит повреждения игроку или врагам?
    public bool isEnemyShot = false;

    void Start()
    {
        // Ограниченное время жизни, чтобы избежать утечек
        Destroy(gameObject, 20); // 20 секунд
    }
}