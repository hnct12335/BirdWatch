using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstateBird : MonoBehaviour {
    public int InstantTime;
    public GameObject bird;
    private Text Scoretext;
	int score;
    int time;
    Vector2 postion;
	// Use this for initialization
	void Start () {
        time = 0;
		score = 0;
        Scoretext = GameObject.Find("Canvas/Score").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        time++;
        time %= InstantTime;
        if(time == 0)
        {
            postion = transform.position;
            postion.x += 2 * Random.Range(-1, 2);
            Instantiate(bird, postion, transform.rotation);
        }
	}

	public int getScore(){
		return score;
	}

	public void incScore(){
		score++;
		InstantTime = 80 - (int)((double)score * 0.1);
		Debug.Log (InstantTime);
		Scoretext.text = "Score" + score.ToString ();
	}
}
