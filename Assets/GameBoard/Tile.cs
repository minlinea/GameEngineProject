using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : GameBoard
{
    public List<Tile> AroundTile;
    public List<Animals> Animal;

    private void OnMouseDown()      //해당 동물을 클릭했을 때 
    {

        if (true == active)
        {
            //base.OnMouseDown();
            if (false == InputLock)
            {
                InputLock = true;

                if (CheckRemaining() == true)        //나눌 수 있는 경우
                {
                    AnimalAnimation();      //애니메이션 진행
                }
                else
                {
                    InputLock = false;
                }
            }
        }
        //Debug.Log(TileName);
    }

    private bool CheckRemaining()       //해당 타일의 주변 active 타일과 동물의 수 나머지 계산
    {
        int cnt = 0;
        for(int i=0; i< AroundTile.Count; ++i)
        {
            if (true == AroundTile[i].active)
                cnt += 1;
        }
        if (Animal.Count % cnt == 0)       // 나눌 수 있는 경우
        {   
            return true;
        }
        else
        {        
            return false;
        }
    }

    private void AnimalAnimation()      //자신이 가지고 있던 동물들에 대해 각 애니메이션 호출
    {
        for (int i = Animal.Count - 1; i >= 0; --i)
        {
            int targettile = i % AroundTile.Count;
            Vector3 offsetz = new Vector3( 0, 0, 1);

            //차후 애니메이션으로 수정
            //
            Animal[i].transform.position = AroundTile[targettile].transform.position;
            Animal[i].transform.position -= offsetz;


            AroundTile[targettile].Animal.Add(Animal[i]);
            Animal.RemoveAt(i);
        }

        //동물들 이동, 애니메이션 처리 후
        InputLock = false;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
