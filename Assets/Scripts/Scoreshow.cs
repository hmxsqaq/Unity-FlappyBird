using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreshow : MonoBehaviour
{
    public Sprite[] score_sprite;
    public Sprite[] medal;

    public GameObject[] Score;
    public GameObject[] BestScore;
    public GameObject Medal;
    private void Start()
    {
        int score = DataOperate.Instance.Score;
        int bestscore = DataOperate.Instance.Bestscore;

        if (score < 10)
        {
            Score[2].GetComponent<Image>().sprite = score_sprite[score];

            Score[0].SetActive(false);
            Score[1].SetActive(false);
            Score[2].SetActive(true);
            Score[3].SetActive(false);
        }
        else if (score < 100)
        {
            int c = score % 10;
            int b = score / 10;

            Score[1].GetComponent<Image>().sprite = score_sprite[b];
            Score[2].GetComponent<Image>().sprite = score_sprite[c];

            Score[0].SetActive(false);
            Score[1].SetActive(true);
            Score[2].SetActive(true);
            Score[3].SetActive(false);
        }
        else if (score < 1000)
        {
            int a = score / 100;
            int b = (score - a * 100) / 10;
            int c = score - a * 100 - b * 10;

            Score[0].GetComponent<Image>().sprite = score_sprite[a];
            Score[1].GetComponent<Image>().sprite = score_sprite[b];
            Score[2].GetComponent<Image>().sprite = score_sprite[c];

            Score[0].SetActive(true);
            Score[1].SetActive(true);
            Score[2].SetActive(true);
            Score[3].SetActive(false);
        }
        else
        {
            Score[0].GetComponent<Image>().sprite = score_sprite[9];
            Score[1].GetComponent<Image>().sprite = score_sprite[9];
            Score[2].GetComponent<Image>().sprite = score_sprite[9];

            Score[0].SetActive(true);
            Score[1].SetActive(true);
            Score[2].SetActive(true);
            Score[3].SetActive(true);
        }

        if (score < 10)
        {
            Medal.SetActive(false);
        }
        else if (score < 20)
        {
            Medal.GetComponent<Image>().sprite = medal[3];
            Medal.SetActive(true);
        }
        else if (score < 50)
        {
            Medal.GetComponent<Image>().sprite = medal[2];
            Medal.SetActive(true);
        }
        else if (score < 100)
        {
            Medal.GetComponent<Image>().sprite = medal[1];
            Medal.SetActive(true);
        }
        else
        {
            Medal.GetComponent<Image>().sprite = medal[0];
            Medal.SetActive(true);
        }

        if(bestscore < 10)
        {
            BestScore[2].GetComponent<Image>().sprite = score_sprite[bestscore];

            BestScore[0].SetActive(false);
            BestScore[1].SetActive(false);
            BestScore[2].SetActive(true);
            BestScore[3].SetActive(false);
        }
        else if (bestscore < 100)
        {
            int c = bestscore % 10;
            int b = bestscore / 10;

            BestScore[1].GetComponent<Image>().sprite = score_sprite[b];
            BestScore[2].GetComponent<Image>().sprite = score_sprite[c];

            BestScore[0].SetActive(false);
            BestScore[1].SetActive(true);
            BestScore[2].SetActive(true);
            BestScore[3].SetActive(false);
        }
        else if (bestscore < 1000)
        {
            int a = bestscore / 100;
            int b = (bestscore - a * 100) / 10;
            int c = bestscore - a * 100 - b * 10;

            BestScore[0].GetComponent<Image>().sprite = score_sprite[a];
            BestScore[1].GetComponent<Image>().sprite = score_sprite[b];
            BestScore[2].GetComponent<Image>().sprite = score_sprite[c];

            BestScore[0].SetActive(true);
            BestScore[1].SetActive(true);
            BestScore[2].SetActive(true);
            BestScore[3].SetActive(false);
        }
        else
        {
            BestScore[0].GetComponent<Image>().sprite = score_sprite[9];
            BestScore[1].GetComponent<Image>().sprite = score_sprite[9];
            BestScore[2].GetComponent<Image>().sprite = score_sprite[9];

            BestScore[0].SetActive(true);
            BestScore[1].SetActive(true);
            BestScore[2].SetActive(true);
            BestScore[3].SetActive(true);
        }
    }
}
