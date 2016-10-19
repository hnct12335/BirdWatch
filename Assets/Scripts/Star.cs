using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {
    double vx, vy;
	// Use this for initialization
	void Start () {
        vx = Random.Range(-10, 10);
        vy = Random.Range(-10, 10);
        if (vx + vy == 0) vx = 1;
        vx = vx / (double)100;
        vy = vy / (double)100;
        Destroy(gameObject, 10);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 tempPos;
        tempPos = this.transform.position;
        tempPos.x += (float)vx;
        tempPos.y += (float)vy;
        this.transform.position = tempPos;
	}
}
