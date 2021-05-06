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
    protected AnimalType type;   //���� Ÿ�� (��, ��, ��)
    public Direction dir;    //�ٶ󺸴� ����(��, ��, ��, �Ʒ�)
    protected Vector2Int loc; //�� �󿡼� ��ġ�� ��ǥ(0,0 ~ 5,5 ����)

    // ����� �Լ� ����
    public virtual int Move()  //Animal���� ���������� ó���Ǵ� �κ� ����
    {
        GameBoard gameboard = GetComponent<GameBoard>();        //�� ������ ����Ǿ� �ִ� gameboard�� ����
        int result = gameboard.CheckingMove(type, dir, loc);     //�ش� �������� �̵��� �󸶳� �������� �� ����
        return result;
    }

    protected virtual void Animation()
    {
        //���� �̵� �� �ִϸ��̼����� ����

    }

    /*
     //�����غ��ϱ� ������ Ŭ���ϴ°� �ƴ϶� Ÿ���� Ŭ���ؾ� ��, �ϴ� ����
    private void OnMouseDown()      //�ش� ������ Ŭ������ �� 
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



    //����� �Լ� ����;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
