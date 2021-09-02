using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] jellyGoldList;
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] numGoldList;
    public int[] clickGoldList;

    public Vector3[] PointList;

    public RuntimeAnimatorController[] LevelAC;

    public void ChangeAC(Animator anim, int level)
    {
        anim.runtimeAnimatorController = LevelAC[level - 1];
    }
}
