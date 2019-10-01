using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float Speed;
    static int score = 0;

    // Update is called once per frame
    public static void updateScore()
    {
        score += 1;
    }

    public static int getScore()
    {
        return score;
    }
    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime);
    }
}
