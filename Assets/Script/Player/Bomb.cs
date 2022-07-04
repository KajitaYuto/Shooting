using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    public GameObject particle;
    public AudioSource audioSource;
    public Text textComponent;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Bomb:" + num;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)&&num>0)
        {
            audioSource.Play();
            GameObject[] enemyBulletObjects = GameObject.FindGameObjectsWithTag("EnemyBullet");

            for(int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }

            Instantiate(particle, Vector3.zero, Quaternion.identity);
            num--;
            textComponent.text = "Bomb:" + num;
        }
    }
}
