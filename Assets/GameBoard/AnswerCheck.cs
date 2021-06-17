using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCheck : MonoBehaviour
{
    public List<Animals> Animal;
    public List<Tile> AnswerTile;
    float timer = 0.0f;
    public bool checking = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void IsAnswer()
    {
        bool e = true;
        if(timer > 1.5f)
        {
            for (int i = 0; i < Animal.Count; ++i)
            {
                if (Animal[i].belongtile != AnswerTile[i])
                {
                   
                    Debug.Log("FAIL");
                    e = false;
                    break;
                }
            }
            if (e == true)
                Debug.Log("CLEAR");

            timer = 0.0f;
            checking = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checking == true)
        {
            timer += Time.deltaTime;
            IsAnswer();
        }
    }
}
