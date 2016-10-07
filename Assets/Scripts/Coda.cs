using UnityEngine;
using System.Collections;

public class Coda : MonoBehaviour {
    int scale;
    bool HitFlg;
    int time;
    public int Score;
	GameObject objmain;
	// Use this for initialization
	void Start () {
        scale = 2;
        HitFlg = false;
        time = 0;
        Score = 0; ;
		objmain = GameObject.Find ("GameObjectMain");
		Debug.Log ("test");
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 Postion;
        Postion.x = 0;
        Postion.y = 0;
        bool Up = Input.GetKey(KeyCode.UpArrow);
        bool Down = Input.GetKey(KeyCode.DownArrow); ;
        bool Left = Input.GetKey(KeyCode.LeftArrow); ;
        bool Right = Input.GetKey(KeyCode.RightArrow); ;

        if (Up) Postion.y++;
        if (Down) Postion.y--;
        if (Left) Postion.x--;
        if (Right) Postion.x++;

        Postion.x *= scale;
        Postion.y *= scale;

        this.transform.position = Postion;
		/*
        if (Input.GetKey(KeyCode.Space))
        {
			Debug.Log ("hoge");
            HitFlg = true;
        }

        if (HitFlg)
        {
            time++;
            if(time > 30)
            {
                HitFlg = false;
            }
        }
        else
        {
            time = 0;
        }
*/


	}

	void OnTriggerStay2D(Collider2D coll){
		//Debug.Log ("test");
		if (Input.GetKey (KeyCode.Space)) {
			
			Destroy (coll.gameObject);
			Debug.Log ("de");
			InstateBird ib = objmain.GetComponent<InstateBird> ();
			ib.incScore ();
		}
	}
}
