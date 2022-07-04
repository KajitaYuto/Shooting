using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GManager : MonoBehaviour
{
    private GameObject[] enemy;
    private GameObject[] player;
    public GameObject panelC;
    public GameObject panelO;
    private int Score;
    public Text textComponent;
    private float timeReset = 1;
    private float time = 0;
    private bool flag;

    // Start is called before the first frame update
    private void Start()
    {
        panelC.SetActive(false);
        panelO.SetActive(false);

        Screen.SetResolution(1920, 1080, false);
        Application.targetFrameRate = 60;
        time = 0;
        flag = false;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        player = GameObject.FindGameObjectsWithTag("Player");


        if (enemy.Length == 0)
        {
            panelC.SetActive(true);
            flag = true;
        }

        if (player.Length == 0)
        {
            panelO.SetActive(true);
            flag = true;
        }

        if (time > timeReset && !flag)
        {
            AddScore();
            time = 0;
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SceneReset();
        }
    }

    public void AddKillScore()
    {
        Score += 10;
        textComponent.text = "Score:" + Score;
    }

    public void AddScore()
    {
        Score++;
        textComponent.text = "Score:" + Score;
    }

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
}
