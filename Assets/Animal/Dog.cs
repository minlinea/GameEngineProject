using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{


    // 상속할 함수 정의
    Animator animator;
    string animationsDir = "AnimationDirect";
    string animationsMov = "AnimationMove";
    string animationsBar = "AnimationBark";
    private Vector3 destination;

    public bool bark = false;
    bool react = false;
    bool state = false;
    float timer = 0.0f;
    public bool InputLock = false;

    override public void Animation(Tile des, Behavior beh)
    {
        //base.Animation(des, beh);
        //동물 이동 시 애니메이션으로 진행

    }

    // Start is called before the first frame update
    void Start()
    {
        this.InputLock = false;
        this.speed = 2;
        this.type = AnimalType.Dog;
        this.mov = false;
        this.animator = GetComponent<Animator>();
        this.dir = Direction.LEFT;
        this.animator.SetInteger(animationsDir, (int)Direction.LEFT);
    }

    // Update is called once per frame

    public void setDestination(Tile des)
    {
        if(InputLock == false)
        {
            InputLock = true;
            loc = des.transform.position;
            belongtile = des;


            this.mov = true;
            animator.SetBool(animationsMov, true);

        }
    }

    public bool isDestination()
    {
        Vector3 a = new Vector3(loc.x, loc.y,0);
        Vector3 b = new Vector3(this.transform.position.x, this.transform.position.y,0);
        Vector3 len = a - b;
        float flen = len.sqrMagnitude;

        if (flen < 0.1 * 0.1)
            return true;
        else
            return false;

    }
    public void DogMoving()
    {
        if (true == this.mov)
        {
            Vector3 pos = new Vector3(this.speed * Time.deltaTime, this.speed * Time.deltaTime, 0);
            int xdir = 0;
            int ydir = 0;
            float y = loc.y - this.transform.position.y;
            float x = loc.x - this.transform.position.x;

            if ( y > 0)
            {
                this.dir = Direction.UP;
                ydir = 1;
            }
            else
            {
                this.dir = Direction.DOWN;
                ydir = -1;
            }
            if(x > 0)
            {
                this.dir = Direction.RIGHT;
                xdir = 1;
            }
            else
            {
                this.dir = Direction.LEFT;
                xdir = -1;
            }

            pos.x *= xdir;
            pos.y *= ydir;

            this.transform.position += pos;

            if (state == false)
            {
                state = true;
                DogStateChange();

            }

            if (true == isDestination())
            {
                this.mov = false;
                animator.SetBool(animationsMov, false);
                state = false;
                this.bark = true;

                AnswerCheck t = GameObject.FindGameObjectWithTag("AnswerCheck").GetComponent<AnswerCheck>();
                t.checking = true;
            }

        }
    }

    void DogBark()
    {
        if(this.bark == true)
        {
            animator.SetBool(animationsBar, true);
            timer += Time.deltaTime;

            if (react == false)
            {
                belongtile.React();
                react = true;
            }
           
            if (timer > 1.0f)
            {
                react = false;
                timer = 0;
                this.bark = false;
                animator.SetBool(animationsBar, false);
                InputLock = false;
            }
        }
    }
    void DogStateChange()
    {
        if (true == this.mov)
        {
            float y = loc.y - this.transform.position.y;
            float x = loc.x - this.transform.position.x;

            if (Mathf.Abs(y) > Mathf.Abs(x))
            {
                if (y > 0)
                {
                    animator.SetInteger(animationsDir, (int)Direction.UP);
                }
                else
                {
                    animator.SetInteger(animationsDir, (int)Direction.DOWN);
                }
            }
            else
            {
                if (x > 0)
                {
                    animator.SetInteger(animationsDir, (int)Direction.RIGHT);
                    
                }
                else
                {
                    animator.SetInteger(animationsDir, (int)Direction.LEFT);
                }
            }
        }
    }
    void Update()
    {
        
        DogMoving();
        DogBark();
    }
}
