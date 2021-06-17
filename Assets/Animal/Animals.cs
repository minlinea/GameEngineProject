using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimalType
{
    SHEEP = 10,
    COW,
    CHICKEN,
    Dog
}

public enum Direction
{
    UP = 0,
    LEFT,
    RIGHT,
    DOWN
}

public enum Behavior
{
    SLEEP = 50,
    MOVING,
    REACT
}

public class Animals : MonoBehaviour
{
    public AnimalType type;   //동물 타입 (양, 소, 닭)
    public Direction dir;    //바라보는 방향(위, 좌, 우, 아래)
    public bool mov;
    public int speed;
    protected Vector3 loc;
    public Tile belongtile;

    // 상속할 함수 정의
    private void OnMouseDown()      //해당 칸을 클릭했을 때 
    {
        belongtile.DogReact();
    }

    private void ChangeDirection()
    {
        if (this.dir == Direction.UP)
            this.dir = Direction.DOWN;
        else if (this.dir == Direction.DOWN)
            this.dir = Direction.UP;
        else if (this.dir == Direction.LEFT)
            this.dir = Direction.RIGHT;
        else if (this.dir == Direction.RIGHT)
            this.dir = Direction.LEFT;
    }

    private Vector3 Destination(Vector3 vtile)
    {
        float offset = 1.0f;
        int rangemin = 5;
        int rangemax = 25;

        float randmain = Random.Range(rangemin, rangemax) * (float)0.01;
        float randanother = Random.Range(-1, 2) * (float)0.1;
        vtile.z -= offset;

        if (this.dir == Direction.UP)
        {
            vtile.y -= randmain;
            vtile.x += randanother;
        }
        else if (this.dir == Direction.DOWN)
        {
            vtile.y += randmain;
            vtile.x += randanother;
        }
        else if (this.dir == Direction.LEFT)
        {
            vtile.x += randmain;
            vtile.y += randanother;
        }
        else if (this.dir == Direction.RIGHT)
        {
            vtile.x -= randmain;
            vtile.y += randanother;
        }
        
        return vtile;
    }

    public bool IsArrived()
    {
        if (this.dir == Direction.UP)
        {
            if (this.transform.position.y >= this.loc.y)
                return true;
        }
        else if (this.dir == Direction.DOWN)
        {
            if (this.transform.position.y <= loc.y)
                return true;
        }
        else if (this.dir == Direction.LEFT)
        {
            if (this.transform.position.x <= loc.x)
                return true;
        }
        else if (this.dir == Direction.RIGHT)
        {
            if (this.transform.position.x >= loc.x)
                return true;
        }
        return false;
    }


    public void Moving()
    {
        if (this.mov == true)
        {
            if (this.dir == Direction.UP)
            {
                Vector3 pos = new Vector3(0, this.speed * Time.deltaTime, 0);
                this.transform.position += pos;
            }
            else if (this.dir == Direction.DOWN)
            {
                Vector3 pos = new Vector3(0, this.speed * Time.deltaTime, 0);
                this.transform.position -= pos;
            }
            else if (this.dir == Direction.LEFT)
            {
                Vector3 pos = new Vector3(this.speed * Time.deltaTime, 0, 0);
                this.transform.position -= pos;
            }
            else if (this.dir == Direction.RIGHT)
            {
                Vector3 pos = new Vector3(this.speed * Time.deltaTime, 0, 0);
                this.transform.position += pos;
            }

            if (IsArrived() == true)
            {
                ChangeDirection();
                this.mov = false;
            }
        }
    }

    public virtual void Animation(Tile des, Behavior beh)
    {
        if (beh == Behavior.MOVING)
        {
            this.loc = Destination(des.transform.position);
            belongtile = des;
            this.mov = true;
        }

        else if (beh == Behavior.REACT)
        {

        }

        else if (beh == Behavior.SLEEP)
        {

        }
    }

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
        loc = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
