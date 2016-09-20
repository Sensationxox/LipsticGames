using UnityEngine;
using System.Collections;

public class AIScript : MonoBehaviour {
    
    private Vector2 vector = new Vector2(0, 1);
    float speed = 100f;
    bool isDead = true;
    int myDMG = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SpawnMOB(int playerLvl)
    {
        isDead = false;
        //new mob?? prefab = new prefab??
        /////count & add to MOB class/////
        //mob lvl
        //who the fuck mob is: wiz, figt, roug
        //int, dex, str
        //roll the dice for fighting style
        //MOB.MoveABit(); //----> StartCoroutine(MoveForSeconds());
        //MOB.CountYourStats();
    }

    public void MoveMOB(int dmg, int full, int left)
    {
        //if (MOB.leftLife < 1)
        //{
        //  isDead = true;
        //  Destroy(MOB);
        //}
        //else
        //{
        //  ChangeEmotion(dmg, full, left);
        //  ChooseMove();
        //}
    }


}
