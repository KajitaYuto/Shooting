using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemyHp;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHp = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Damage()
    {
        EnemyHp = EnemyHp - 1;
        Debug.Log(EnemyHp);
    }
}
