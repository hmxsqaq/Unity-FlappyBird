using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistDie : MonoBehaviour
{
    public GameObject New;

    void Awake()
    {
        transform.position = DataOperate.Instance.Diepos;
        this.GetComponentInChildren<Animator>().SetInteger("states", 2);
        if(DataOperate.Instance.Score > DataOperate.Instance.Bestscore)
        {
            New.SetActive(true);
            DataOperate.Instance.Bestscore = DataOperate.Instance.Score;
        }
    }
    void Update()
    {
        if(transform.position.y > -2.89)
        {
            transform.Translate(Vector2.right * Time.deltaTime*3);
        }
    }

    public void ResetScore()
    {
        New.SetActive(false);
        DataOperate.Instance.Score = 0;
        DataOperate.Instance.Diepos = new Vector2(0, 0);
    }
}
