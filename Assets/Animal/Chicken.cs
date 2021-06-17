using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{
    // ����� �Լ� ����
    Animator animator;
    string animationsDir = "AnimationDirection";
    string animationsMov = "AnimationMove";
    override public void Animation(Tile des, Behavior beh)
    {
        base.Animation(des, beh);
        //���� �̵� �� �ִϸ��̼����� ����

    }

    // Start is called before the first frame update
    void Start()
    {
        this.speed = 3;
        this.type = AnimalType.CHICKEN;
        this.mov = false;
        animator = GetComponent<Animator>();
        audioSoure = GetComponent<AudioSource>();
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
            if (this.sound == true)
            {
                audioSoure.Play();
                this.sound = false;
            }
        }
        else
        {
            animator.SetBool(animationsMov, false);
            this.sound = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        base.Moving();
        UpdateState();
    }
}
