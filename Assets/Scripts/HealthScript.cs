using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    /// Всего хитпоинтов
    public int hp = 1;

     /// Враг или игрок?
     public bool isEnemy = true;

     /// Наносим урон и проверяем должен ли объект быть уничтожен
     public void Damage(int damageCount)
     {
         hp -= damageCount;

         if (hp <= 0)
         {
             // Смерть!
             Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherCollider)
    {
         // Это выстрел?
            ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                // Избегайте дружественного огня
                if (shot.isEnemyShot != isEnemy)
                {
                    Damage(shot.damage);

                    // Уничтожить выстрел
                    Destroy(shot.gameObject); // Всегда цельтесь в игровой объект, иначе вы просто удалите скрипт.      }
                }
            }
        }
    }