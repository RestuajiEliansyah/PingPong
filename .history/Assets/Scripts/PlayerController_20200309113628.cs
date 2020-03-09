using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float batasAtas;
    public float batasBawah;
    public float kecepatan;
    public string axisVertical,axisHorizontal;
 
    // Use this for initialization
    void Start () {
 
    }
    
    // Update is called once per frame
    void Update () {
        float gerakVertical = Input.GetAxis (axisVertical) * kecepatan * Time.deltaTime;
        float gerakHorizontal = Input.GetAxis (axisHorizontal) * kecepatan * Time.deltaTime;
        // float nextPos = transform.position.y + gerakVertical;
        // if (nextPos > batasAtas) {
        //     gerakVertical = 0;
        // }
        // if (nextPos < batasBawah) {
        //     gerakVertical = 0;
        // }
        transform.Translate (0, gerakVertical, 0);
    }
}