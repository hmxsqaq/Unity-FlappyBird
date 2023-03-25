using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pipe_prefab;

    private void Start()
    {
        StartCoroutine(creat(1.5f));
    }

    public void Pipe_Creat()
    {
        float y = Random.Range(-5.5f, -1.0f);
        Instantiate(pipe_prefab, new Vector3(4, y, 0), Quaternion.identity);
    }

    IEnumerator creat(float seconds)
    {
        Pipe_Creat();
        yield return new WaitForSeconds(seconds);
        StartCoroutine(creat(1.5f));
    }
}
