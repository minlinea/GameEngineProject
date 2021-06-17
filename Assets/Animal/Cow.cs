using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animals
{
    private AudioSource audioSoure;
    // ����� �Լ� ����

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
        this.speed = 0;
        this.type = AnimalType.COW;
        this.mov = false;
        this.sound = false;
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

        if (this.mov == true)
        {
            animator.SetBool(animationsMov, true);
        }
        else
        {
            animator.SetBool(animationsMov, false);
        }
        
        if (this.sound == true)
        {
            audioSoure.Play();
            this.sound = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        base.Moving();
        UpdateState();
    }
}
