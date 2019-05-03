using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //時計の処理を使うための宣言

public class Clock : MonoBehaviour {

    [SerializeField] GameObject longHand; //長針
    [SerializeField] GameObject shortHand; //短針
    [SerializeField] GameObject shortShortHand; //秒針

    public int hour;    //時を保存する変数
    public int minute;  //分を保存する変数
    public int second;  //秒を保存する変数

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hour = DateTime.Now.Hour;       //現在の時を読み取る
        minute = DateTime.Now.Minute;   //現在の分を読み取る
        second = DateTime.Now.Second;   //現在の秒を読み取る

        shortShortHand.transform.rotation = Quaternion.Euler(0, 0, -360.0f / 60 * second);
        shortHand.transform.rotation = Quaternion.Euler(0, 0, -360.0f / 12 * hour);
        longHand.transform.rotation = Quaternion.Euler(0, 0, -360.0f / 60 * minute);
	}
}
