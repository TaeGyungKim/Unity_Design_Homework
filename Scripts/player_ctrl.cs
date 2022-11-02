using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_ctrl : MonoBehaviour
{
    private float power = 0;
    public float power_plus = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            power += power_plus * Time.deltaTime;

        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(power, power, 0));
            power = 0;
        }
        if (this.transform.position.y < -5.0f || Input.GetMouseButtonDown(1))
            SceneManager.LoadScene("main");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(40, Screen.height-20, 256, 32), "Jumping Power : " + power.ToString());
    }
}
