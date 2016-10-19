using UnityEngine;
using System.Collections;

public class GameMain : MonoBehaviour
{
    bool Demo;
    // Use this for initialization
    void Start()
    {
        Demo = true;
    }

    public bool DemoFlg()
    {
        return Demo;
    }

    public void GameStart()
    {
        Demo = false;
    }

    public void GameEnd()
    {
        Demo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (DemoFlg())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameStart();
                Debug.Log("START!");
                GameObject.Find("Canvas").GetComponent<Lifes>().Initalize();
                GameObject.Find("GameObjectMain").GetComponent<InstateBird>().Initialize();
            }
        }
    }
}
