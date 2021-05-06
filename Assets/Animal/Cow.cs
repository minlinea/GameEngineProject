using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animals
{
    // 상속할 함수 정의
    override public int Move() //개별 이동 방식 정의
    {
        //int result = CheckingMove(dir)     //해당 방향으로 이동이 얼마나 가능한지 값 리턴
        //Moving()      //animation

        return -1;
    }

    protected override void Animation()
    {
        //동물 이동 시 애니메이션으로 진행

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
