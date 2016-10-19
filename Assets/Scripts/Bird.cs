using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    GameObject Life;
    GameMain Gmain;
    private Vector2 Postion;
    float speed;
    bool Exist;
    public Coda coda;
    // Use this for initialization
    void Start () {
        speed = (float)0.1;
        Exist = true;
        coda = GameObject.Find("Coda").GetComponent<Coda>();
        Life = GameObject.Find("Canvas");
        Gmain = GameObject.Find("GameObjectMain").GetComponent<GameMain>();
        //Debug.Log(coda.getHitFlg.ToString());
    }
	
	// Update is called once per frame
	void Update () {
        if (!Gmain.DemoFlg())
        {
            Postion = transform.position;
            if (Postion.y < -4)
            {
                //Destroy (gameObject);
                if (Exist)
                {
                    Life.GetComponent<Lifes>().DeclLife();
                    Debug.Log("Bird is Died.");
                    Exist = false;
                }
            }
            else
            {
                Postion.y -= speed;
                transform.position = Postion;

            }
        }
            /*
             * 
             * 
             * 
             * 

            if (coda.getHitFlg())
            {
                Vector2 PlayerPos = coda.getPostion();
                Vector2 PlayerSize = coda.getSize();
                Vector2 BirdPos = this.transform.position;
                Vector2 BirdSize = this.GetComponent<SpriteRenderer>().bounds.size;

                if (PlayerPos.x < BirdPos.x + BirdSize.x
                    && PlayerPos.y > BirdPos.y + BirdSize.y
                    && BirdPos.x < PlayerPos.x + PlayerSize.x
                    && BirdPos.y > PlayerPos.y + PlayerSize.y)

                {
					Destroy(gameObject);
                    coda.Score++;
                    
                }
            }
*/
        
	}
}
