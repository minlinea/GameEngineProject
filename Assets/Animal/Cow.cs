using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animals
{
    // ����� �Լ� ����
    override public int Move() //���� �̵� ��� ����
    {
        //int result = CheckingMove(dir)     //�ش� �������� �̵��� �󸶳� �������� �� ����
        //Moving()      //animation

        return -1;
    }

    protected override void Animation()
    {
        //���� �̵� �� �ִϸ��̼����� ����

    }

    // Start is called before the first frame update
    void Start()
    {
        type = AnimalType.COW;
        //type = 0;
        //dir = 0;
        //loc = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
