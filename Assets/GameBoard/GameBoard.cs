using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameBoard : MonoBehaviour
{
    //�ʿ� �Լ� ����

    protected static bool InputLock = false;
    public bool active = true;
    public string TileName;
    
    //�����غ��ϱ� ������ Ŭ���ϴ°� �ƴ϶� Ÿ���� Ŭ���ؾ� ��, �ϴ� ����
    //protected void OnMouseDown()      //�ش� ������ Ŭ������ �� 
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

    //�ʿ� �Լ� ����





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
