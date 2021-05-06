using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameBoard : MonoBehaviour
{
    //필요 함수 정의

    protected static bool InputLock = false;
    public bool active = true;
    public string TileName;
    
    //생각해보니까 동물을 클릭하는게 아니라 타일을 클릭해야 함, 일단 제외
    //protected void OnMouseDown()      //해당 동물을 클릭했을 때 
   // {
        //if (false == InputLock)
        //{
        //    InputLock = true;
        //    Debug.Log("InputLock");
        //}
        //Move();
    //}

    public void StageLoad()
    {

    }

    public int CheckingMove(AnimalType type, Direction dir, Vector2Int loc)
    {


        return 1;
    }

    //필요 함수 정의





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
