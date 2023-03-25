using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreupdate : MonoBehaviour
{
    public Sprite[] score_sprite;
    public GameObject[] Score;
    int score = 0;
    void Update()
    {
        score = DataOperate.Instance.Score;
        if (score < 10)
        {
            Score[0].GetComponent<Image>().sprite = score_sprite[score];

            Score[0].SetActive(true);
            Score[1].SetActive(false);
            Score[2].SetActive(false);
            Score[3].SetActive(false);
            Score[4].SetActive(false);
        }
        else if (score < 100)
        {
            int b = score / 10;
            int c = score % 10;

            Score[1].GetComponent<Image>().sprite = score_sprite[b];
            Score[2].GetComponent<Image>().sprite = score_sprite[c];

            Score[0].SetActive(false);
            Score[1].SetActive(true);
            Score[2].SetActive(true);
            Score[3].SetActive(false);
            Score[4].SetActive(false);
        }
        else if (score < 1000)
        {
            int a = score / 100;
            int b = (score - a * 100) / 10;
            int c = score - a * 100 - b * 10;

            Score[0].GetComponent<Image>().sprite = score_sprite[b];
            Score[3].GetComponent<Image>().sprite = score_sprite[a];
            Score[4].GetComponent<Image>().sprite = score_sprite[c];

            Score[0].SetActive(true);
            Score[1].SetActive(false);
            Score[2].SetActive(false);
            Score[3].SetActive(true);
            Score[4].SetActive(true);
        }
        else
        {
            Score[0].GetComponent<Image>().sprite = score_sprite[9];
            Score[3].GetComponent<Image>().sprite = score_sprite[9];
            Score[4].GetComponent<Image>().sprite = score_sprite[9];

            Score[0].SetActive(true);
            Score[1].SetActive(false);
            Score[2].SetActive(false);
            Score[3].SetActive(true);
            Score[4].SetActive(true);
        }
    }
}
