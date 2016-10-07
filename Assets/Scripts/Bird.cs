using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

    private Vector2 Postion;
    float speed;
    bool Exist;
    public Coda coda;
    // Use this for initialization
    void Start () {
        speed = (float)0.1;
        Exist = true;
        coda = GameObject.Find("Coda").GetComponent<Coda>();
        //Debug.Log(coda.getHitFlg.ToString());
    }
	
	// Update is called once per frame
	void Update () {
        
            Postion = transform.position;
            if (Postion.y < -9)
            {
			//Destroy (gameObject);
            }
            else
            {
                Postion.y -= speed;
                transform.position = Postion;

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
