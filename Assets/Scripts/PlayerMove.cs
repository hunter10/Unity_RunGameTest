using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 1f;

    Transform player;

    Transform startMarker;
    Transform endMarker;
	private float startTime;
	private float journeyLength;

	void Start () {
        player = transform.Find("Cube").gameObject.transform;

        //startMarker = player.transform;
        //endMarker = player.transform;
		//startTime = Time.time;
        //journeyLength = Vector3.Distance(startMarker.position, endMarker.position);//시작과끝 위치 거리
	}
	
    // 속도, 방향만 있는 이동
	void Update () {
        float x = Time.deltaTime * speed;

        // 이동1
        player.transform.Translate(new Vector3(x, 0, 0));

        // 이동2
        //player.transform.position = player.transform.position + new Vector3(x, 0, 0);

        // 이동3
        //player.transform.position = Vector3.MoveTowards(player.transform.position,
                                                        //new Vector3(player.transform.position.x+x, 0, 0),
                                                        //speed);

		//두점 사이의 거리가 10일때
		//float distCovered = (Time.time - startTime) * speed; //속력 v = m/s 1초에 10움직임 한프레임당 1움직인다고하면
		//float fracJourney = distCovered / journeyLength;// 속력 / 길이 = m/s / m = 1/s 시간 fracJourney = 0.1f
		//transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney); //
	}

}
