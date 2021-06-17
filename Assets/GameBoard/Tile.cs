using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : GameBoard
{
    public List<Tile> AroundTile;
    public List<Animals> Animal;


    public void React()
    {
        if (true == active)
        {
            AnimalMoving();      //�ִϸ��̼� ����
        }
        InputLock = false;
    }

    public void DogReact()
    {
        if (true == active)
        {
            //base.OnMouseDown();
            if (false == InputLock)
            {
                InputLock = true;

                if (CheckRemaining() == true)        //���� �� �ִ� ���
                {
                    player.setDestination(this);
                }
            }
        }
    }

    private void OnMouseDown()      //�ش� ĭ�� Ŭ������ �� 
    {
        DogReact();
    }

    private bool CheckRemaining()       //�ش� Ÿ���� �ֺ� active Ÿ�ϰ� ������ �� ������ ���
    {
        int cnt = 0;
        for(int i=0; i< AroundTile.Count; ++i)
        {
            if (true == AroundTile[i].active)
            {
                cnt += 1;
            }
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

    private Tile FindDestination(Tile next, int dir, int type)
    {
        if (type == (int)AnimalType.SHEEP)
        {
            Tile dest = next.AroundTile[dir];
            if (true == dest.active)
            {
                return dest;
            }
        }
        else if (type == (int)AnimalType.CHICKEN)
        {
            Tile dest = next.AroundTile[dir];
            if (true == dest.active)
            {
                return FindDestination(dest, dir, type);
            }
            else
            {
                return next;
            }
        }
        return this;
    }

    private void AnimalReact()
    {
        for (int i = Animal.Count - 1; i >= 0; --i)
        {
            Animal[i].Animation(this, Behavior.REACT);
        }
    }

    private void AnimalMoving()      //�ڽ��� ������ �ִ� �����鿡 ���� �� �ִϸ��̼� ȣ��
    {

        for (int i = Animal.Count - 1; i >= 0; --i)
        {
            Tile des = FindDestination(this, (int)Animal[i].dir, (int)Animal[i].type);

            Animal[i].Animation(des, Behavior.MOVING);

            des.Animal.Add(Animal[i]);
            Animal.RemoveAt(i);
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        for (int i = Animal.Count - 1; i >= 0; --i)
        {
            Animal[i].belongtile = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
