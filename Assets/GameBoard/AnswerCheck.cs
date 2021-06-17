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
        bool isanswer = true;
        if(timer > 1.5f)
        {
            for (int i = 0; i < Animal.Count; ++i)
            {
                if (Animal[i].belongtile != AnswerTile[i])
                {
                    isanswer = false;
                    break;
                }
            }
            if (isanswer == true)
            {
                clear();
            }

            timer = 0.0f;
            checking = false;
        }
        
    }

    void clear()
    {
        Dog playerdog = GameObject.FindGameObjectWithTag("Dog").GetComponent<Dog>();
        playerdog.InputLock = true;

        Debug.Log("CLEAR");
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
