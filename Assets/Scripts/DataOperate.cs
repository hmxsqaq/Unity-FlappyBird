using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataOperate
{
    private DataOperate()
    {

    }

    private static DataOperate _instance;
    public static DataOperate Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new DataOperate();
            }
            return _instance;
        }
    }
    public int Score { get; set; }
    public Vector2 Diepos { get; set; }
    public int Bestscore { get; set; }
}
