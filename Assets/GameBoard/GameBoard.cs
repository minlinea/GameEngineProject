using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StageName
{
    Stage1,
    Stage2,
    Stage3,
    Stage4,
    Stage5,
    Stage6,
    Stage7,
    Stage8,
    Stage9
}


public class GameBoard : MonoBehaviour
{
    //필요 함수 정의

    protected static bool InputLock = false;
    public bool active = true;
    public string TileName;
    public Dog player;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Dog>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
