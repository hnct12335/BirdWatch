using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstateBird : MonoBehaviour {
    public int InstantTime;
    public GameObject bird;
    public GameObject star;
    GameMain Gmain;
    private Text Scoretext;
	int score;
    int time;
    Vector2 postion;
	// Use this for initialization
	void Start () {
        Initialize();
        }
	
    public void Initialize()
    {
        time = 0;
        score = 0;
        Scoretext = GameObject.Find("Canvas/Score").GetComponent<Text>();
        Gmain = GameObject.Find("GameObjectMain").GetComponent<GameMain>();
        ShowScore();
    }

    // Update is called once per frame
    void Update () {
        if (!Gmain.DemoFlg())
        {
            time++;
            time %= InstantTime;
            if (time == 0)
            {
                postion = transform.position;
                postion.x += 2 * Random.Range(-1, 2);
                Instantiate(bird, postion, transform.rotation);
            }
            if(time%5 == 0)
            {
                Instantiate(star, star.transform.position, transform.rotation);
                
            }

            if (Input.GetKey(KeyCode.S))
            {
                incScore();
            }
        }


    }

	public int getScore(){
		return score;
	}

    void ShowScore()
    {
        Scoretext.text = score.ToString().PadLeft(6, '0') + "\n";
    }

	public void incScore(){
		score++;
		InstantTime = 80 - (int)((double)score * 0.5);
		Debug.Log (InstantTime);
        ShowScore();
    }
}
