using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{


    // ����� �Լ� ����
    override public int Move() //���� �̵� ��� ����
    {
        int movement = base.Move();

        base.ChangeDir();

        return -1;
        //int result = CheckingMove(dir)     //�ش� �������� �̵��� �󸶳� �������� �� ����
        //Moving()      //animation
    }

    protected override void Animation()
    {
        //���� �̵� �� �ִϸ��̼����� ����

    }

    // Start is called before the first frame update
    void Start()
    {
         type = AnimalType.CHICKEN;
        //type = 0;
        //dir = 0;
       //loc = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
