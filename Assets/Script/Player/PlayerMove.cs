using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public int PlayerHp;
    public Text textComponent;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerHp = 10;
        textComponent.text = "Player:" + PlayerHp;
    }

    // Update is called once per frame
    void Update(){
        Vector3 pos = transform.position;
        float speed;

        if (Input.GetKey(KeyCode.LeftShift)) speed = 0.1f;
        else speed = 0.2f;

        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
            if (pos.x > 28) pos.x = 28;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
            if (pos.x < -33) pos.x = -33;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            pos.z += speed;
            if (pos.z > 23.5f) pos.z = 23.5f;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            pos.z -= speed;
            if (pos.z < -24.5f) pos.z = -24.5f;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if (PlayerHp <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    public void Damage()
    {
        if (PlayerHp > 0)
        {
            PlayerHp = PlayerHp - 1;
            Debug.Log(PlayerHp);
            textComponent.text = "Player:" + PlayerHp;
            audioSource.Play();
        }
    }
}
