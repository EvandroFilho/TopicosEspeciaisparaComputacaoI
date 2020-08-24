using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameMaster : MonoBehaviour
{
    //public AudioSource gameOverSound;

    public GameObject restartPanel;

    public Text timerDisplay;

    public bool asLost;

    public float timer;

    public int dishQnt;

    public Transform dishGenerator;

    public GameObject[] platesPrefab;

    private void Start(){
        addDish();
    }

    private void Update()
    {

        if(asLost == false)
        {
            timerDisplay.text = "Time: " + timer.ToString("F0");
        }
        if(timer <= 0)
        {
            GameOver();
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    public void removeDish(){
        dishQnt -= 1;
        if (dishQnt == 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            addDish();
        }
    }

    public void addDish(){
        int RandonPlate = Random.Range(0, platesPrefab.Length);
        Instantiate(platesPrefab[RandonPlate], dishGenerator.position, Quaternion.identity);
    }


    public void GameOver()
    {
        asLost = true;
        Invoke("Delay", 0f);
    }

    void Delay()
    {
        restartPanel.SetActive(true);
        //gameOverSound.Play();

    }
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
