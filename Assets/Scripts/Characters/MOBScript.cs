using UnityEngine;
using System.Collections;
using Assets.Scripts.Characters;

public class MOBScript : MonoBehaviour
{
    //CharacterType1MOBType1 helper = new CharacterType1MOBType1();

    public int lvl = 0;
    public int intel = 0;
    public int str = 0;
    public int dex = 0;
    public int damage = 0;
    public int heal = 0;
    public int fullLife = 0;
    public int leftLife = 0;

    public int chanceAtt = 0;
    public int chanceDef = 0;
    public int chanceHeal = 0;
    public int proffesion = 0;

    public int head = 0;
    public int clothing = 0;
    public int eyes = 0;
    public int skin = 0;
    public int hair = 0;
         
	// Use this for initialization
	void Start () {
        StartCoroutine(MoveABit());
    }

    IEnumerator MoveABit()
    {
        float speed = 100f;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-1, 0).normalized * speed * Time.deltaTime;
        yield return new WaitForSeconds(1);
        speed = 0f;
    }

    public void CountYourStats()
    {
        //caounting heal, damage and fullLife.
        // probably this is good place to set appearance with sprites
    }

    public void Heal()
    {
        leftLife = leftLife + heal;
    }

    public void SetEmotion (int[] percents)
    {
        chanceAtt = percents[0];
        chanceDef = percents[1];
        chanceHeal = percents[2];
    }

    // Update is called once per frame
    void Update () {
	
	}
}
