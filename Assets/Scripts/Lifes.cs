using UnityEngine;
using System.Collections;
using UnityEngine.UI;//この宣言が必要

public class Lifes : MonoBehaviour {
    private Text LifeText;
    private int LifeNum;
	// Use this for initialization
	void Start () {
        LifeText = GetComponentInChildren<Life>();
        this.LifeNum = 3;
        ShowLife();
	}

    public void DeclLife()
    {
        if (this.LifeNum > 0) LifeNum--;
        ShowLife();
    }
	
    public bool IsGameOver()
    {
        if (this.LifeNum > 0) return false;
        else return true;
    }

    public void ShowLife()
    {
        Debug.Log("Life:"+LifeNum.ToString());
        LifeText.text = "life:" + LifeNum.ToString();
    }

    // Update is called once per frame
    public void Update () {
	
	}
}
