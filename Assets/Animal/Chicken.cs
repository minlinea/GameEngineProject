using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{


    // 상속할 함수 정의
    Animator animator;
    string animationsDir = "AnimationDirection";
    string animationsMov = "AnimationMove";
    override public void Animation(Tile des, Behavior beh)
    {
        base.Animation(des, beh);
        //동물 이동 시 애니메이션으로 진행

    }

    // Start is called before the first frame update
    void Start()
    {
        this.speed = 2;
        this.type = AnimalType.CHICKEN;
        this.mov = false;
        animator = GetComponent<Animator>();
    }

    void UpdateState()
    {
        if (this.dir == Direction.UP)
            animator.SetInteger(animationsDir, (int)Direction.UP);
        else if (this.dir == Direction.DOWN)
            animator.SetInteger(animationsDir, (int)Direction.DOWN);
        else if (this.dir == Direction.LEFT)
            animator.SetInteger(animationsDir, (int)Direction.LEFT);
        else if (this.dir == Direction.RIGHT)
            animator.SetInteger(animationsDir, (int)Direction.RIGHT);

        if(this.mov == true)
        {
            animator.SetBool(animationsMov, true);
        }
        else
        {
            animator.SetBool(animationsMov, false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        base.Moving();
        UpdateState();
    }
}
