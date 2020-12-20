using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreManager mngr;
    CuteEnemey CutePrototype;
    UglyEnemey UglyPrototype;

    CuteEnemey[] cuties = new CuteEnemey[5];
    UglyEnemey[] uglies = new UglyEnemey[2];
    void Start()
    {
        mngr = ScoreManager.GetInstance();
        CutePrototype = new CuteEnemey(20, 20, 20, 20);
        UglyPrototype = new UglyEnemey(10, 10, 10, 10);

        for (int i = 0; i < 5; i++)
        {
            cuties[i] = CutePrototype.Clone() as CuteEnemey;
        }
        for (int i = 0; i < 2; i++)
        {
            uglies[i] = UglyPrototype.Clone() as UglyEnemey;
        }

        foreach(CuteEnemey currCutie in cuties) {
            currCutie.Meow();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown){
            mngr.UpdateScore(500);
            Debug.Log(mngr.GetScore());
        }
    }
}
