using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

	public Text txScore;
	public Text txHighScore;
	Text txSelamat;
	int highscore;

    // Start is called before the first frame update
    void Start()
    {
		highscore = PlayerPrefs.GetInt("HS", 0);
		if (Data.score > highscore){
			highscore = Data.score;
			PlayerPrefs.SetInt("HS", highscore);
		} else if (EnemyController.EnemyKilled == 3){
			SceneManager.LoadScene("Congratulation");
		}
		txHighScore.text = "Highscores : "+ highscore;
		txScore.text = "Scores : "+ Data.score;
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Replay(){
		Data.score = 0;
		EnemyController.EnemyKilled = 0;
		SceneManager.LoadScene("Gameplay");
	}
}
