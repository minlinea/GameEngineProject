using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalType
{
    SHEEP = 10,
    COW,
    CHICKEN
}

public enum Direction
{
    UP = 100,
    LEFT,
    RIGHT,
    DOWN
}


public class Animals : MonoBehaviour
{
    protected AnimalType type;   //동물 타입 (양, 소, 닭)
    public Direction dir;    //바라보는 방향(위, 좌, 우, 아래)
    protected Vector2Int loc; //맵 상에서 위치할 좌표(0,0 ~ 5,5 형태)

    // 상속할 함수 정의
    public virtual int Move()  //Animal에서 공통적으로 처리되는 부분 구현
    {
        GameBoard gameboard = GetComponent<GameBoard>();        //맵 정보가 저장되어 있는 gameboard에 접근
        int result = gameboard.CheckingMove(type, dir, loc);     //해당 방향으로 이동이 얼마나 가능한지 값 리턴
        return result;
    }

    protected virtual void Animation()
    {
        //동물 이동 시 애니메이션으로 진행

    }

    /*
     //생각해보니까 동물을 클릭하는게 아니라 타일을 클릭해야 함, 일단 제외
    private void OnMouseDown()      //해당 동물을 클릭했을 때 
    {
        Debug.Log(type);
        //Move();
    }
    */
    protected Direction ChangeDir()
    {
        if (dir == Direction.UP)
            return Direction.DOWN;
        else if (dir == Direction.DOWN)
            return Direction.UP;
        else if (dir == Direction.LEFT)
            return Direction.RIGHT;
        else
            return Direction.LEFT;
    }



    //상속할 함수 정의;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
