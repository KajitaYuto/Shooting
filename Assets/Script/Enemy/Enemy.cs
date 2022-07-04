using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int EnemyHp;
    public GameObject particle;
    public GManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHp = 1;
        GameObject managerObject = GameObject.Find("GManager");
        gameManager = managerObject.GetComponent<GManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHp <= 0)
        {
            gameManager.AddKillScore();
            Destroy(this.gameObject);
            Instantiate(particle, transform.position, Quaternion.identity);
        }
    }

    public void Damage()
    {
        EnemyHp = EnemyHp - 1;
        Debug.Log(EnemyHp);
    }
}
