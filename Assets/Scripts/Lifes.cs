using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要
using UnityEngine.SceneManagement;

public class Lifes : MonoBehaviour {
    private Text LifeText;
    private int LifeNum;
    GameMain Gmain;
	// Use this for initialization
	void Start () {
        Initalize();
        GamestartText();
    }

    public void Initalize()
    {
        LifeText = GameObject.Find("Canvas/Life").GetComponent<Text>(); ;
        this.LifeNum = 3;
        ShowLife();
        Gmain = GameObject.Find("GameObjectMain").GetComponent<GameMain>();
    }

    public void DeclLife()
    {
        Debug.Log("DeclLife");
        if (this.LifeNum > 0)
        {
            LifeNum--;
            ShowLife();
        }
        if(this.LifeNum <= 0)
        {
            SceneManager.LoadScene("main");
            //Gmain.GameEnd();
        }
    }

    public void GamestartText()
    {
        LifeText.text = "PLEASE PUSH SPACE KEY\n";
    }
	
    public bool IsGameOver()
    {
        if (this.LifeNum > 0) return false;
        else return true;
    }

    public void ShowLife()
    {
        Debug.Log("Life:"+LifeNum.ToString());
        LifeText.text = LifeNum.ToString() + "\n";
    }

    // Update is called once per frame
    public void Update () {
        if (Input.GetKey(KeyCode.L))
        {
            LifeNum++;
            ShowLife();
        }

    }
}
