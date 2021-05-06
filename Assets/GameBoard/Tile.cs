using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : GameBoard
{
    public List<Tile> AroundTile;
    public List<Animals> Animal;

    private void OnMouseDown()      //�ش� ������ Ŭ������ �� 
    {

        if (true == active)
        {
            //base.OnMouseDown();
            if (false == InputLock)
            {
                InputLock = true;

                if (CheckRemaining() == true)        //���� �� �ִ� ���
                {
                    AnimalAnimation();      //�ִϸ��̼� ����
                }
                else
                {
                    InputLock = false;
                }
            }
        }
        //Debug.Log(TileName);
    }

    private bool CheckRemaining()       //�ش� Ÿ���� �ֺ� active Ÿ�ϰ� ������ �� ������ ���
    {
        int cnt = 0;
        for(int i=0; i< AroundTile.Count; ++i)
        {
            if (true == AroundTile[i].active)
                cnt += 1;
        }
        if (Animal.Count % cnt == 0)       // ���� �� �ִ� ���
        {   
            return true;
        }
        else
        {        
            return false;
        }
    }

    private void AnimalAnimation()      //�ڽ��� ������ �ִ� �����鿡 ���� �� �ִϸ��̼� ȣ��
    {
        for (int i = Animal.Count - 1; i >= 0; --i)
        {
            int targettile = i % AroundTile.Count;
            Vector3 offsetz = new Vector3( 0, 0, 1);

            //���� �ִϸ��̼����� ����
            //
            Animal[i].transform.position = AroundTile[targettile].transform.position;
            Animal[i].transform.position -= offsetz;


            AroundTile[targettile].Animal.Add(Animal[i]);
            Animal.RemoveAt(i);
        }

        //������ �̵�, �ִϸ��̼� ó�� ��
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
