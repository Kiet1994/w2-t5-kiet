using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RevolvingWheel1 : MonoBehaviour
{
    public Transform Wheel;
    public float Speed;
    public float speedWheel;
    public float Stop;
    public bool a1;
    public bool a2;
    public bool a3;
    public bool a4;
    public bool a5;
    public bool a6;
    public bool a7;
    public bool a8;
    public bool a9;
    public bool click;
    public float xcount;
    public float round;
    public bool TurnOn;
    public GameObject[] items;
    //public GameObject Me;
    public AnimationCurve curve;

    public static RevolvingWheel1 destroy;

    [SerializeField] private AudioClip wheelRound;
    [SerializeField] private AudioSource audioSource;
    void Awake()
    {

        Wheel = GetComponent<Transform>();

        
    }
    private void Start()
    {

        if (destroy != null)
        {
            Destroy(this.gameObject);
            return;
        }

        destroy = this;
        GameObject.DontDestroyOnLoad(this.gameObject);
        curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 1));
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TurnOn = true;
            audioSource.PlayOneShot(wheelRound);
        }


        if (TurnOn)
        {
            xcount = Random.Range(1f, 3f);
            speedWheel += Speed * Time.deltaTime * curve.Evaluate(Time.time);

            if (click == true && Stop >= round) // Stop luon la int nen luon dung 1 cho
            {
                TurnOn = false;
                if (TurnOn == false)
                {
                    click = false;
                    round = 0;
                }

            }
            if (a1 == true && speedWheel > 20 && Stop >= round + 1)
            {
                TurnOn = false; // turn off luon dc update
                items[1].SetActive(false);
                a1 = false; // t?t ?i ?? không b? l?u to? ?? ? l?n b?m ti?m theo.// tr?ng thái luôn ???c update
                SceneManager.LoadScene("Lever 1", LoadSceneMode.Single);
                //SceneManager.MoveGameObjectToScene(Me, SceneManager.GetSceneByName("Lever 1")); khong di chuyen dc 
                
                //SceneManager.UnloadSceneAsync("Home");
            }

            if (a2 == true && speedWheel > 60 && Stop >= round + 1)
            {
                TurnOn = false;
                items[2].SetActive(false);
                a2 = false;
                SceneManager.LoadScene("Lever 2", LoadSceneMode.Single);
                
            }

            if (a3 == true && speedWheel > 100 && Stop >= round + 1)
            {

                TurnOn = false;
                items[3].SetActive(false);
                a3 = false;
                SceneManager.LoadScene("Lever 3", LoadSceneMode.Single);
            }
            if (a4 == true && speedWheel > 140 && Stop >= round + 1)
            {
                items[4].SetActive(false);
                a4 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 4", LoadSceneMode.Single);
            }
            if (a5 == true && speedWheel > 180 && Stop >= round + 1)
            {
                items[5].SetActive(false);
                a5 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 5", LoadSceneMode.Single);
            }
            if (a6 == true && speedWheel > 220 && Stop >= round + 1)
            {
                items[6].SetActive(false);
                a6 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 6", LoadSceneMode.Single);
            }
            if (a7 == true && speedWheel > 260 && Stop >= round + 1)
            {
                items[7].SetActive(false);
                a7 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 7", LoadSceneMode.Single);
            }
            if (a8 == true && speedWheel > 300 && Stop >= round + 1)
            {
                items[8].SetActive(false);
                a8 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 8", LoadSceneMode.Single);
            }
            if (a9 == true && speedWheel > 340 && Stop >= round + 1)
            {
                items[0].SetActive(false);
                a9 = false;
                TurnOn = false;
                SceneManager.LoadScene("Lever 9", LoadSceneMode.Single);
            }
     

        }
        if (Input.GetMouseButtonDown(1))
        {
            click = true;
            round = Stop + xcount + 0.1f * xcount;
            gameObject.SetActive(false);
            

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Home", LoadSceneMode.Single);

        }  
            
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            a1 = true;
            round = Stop;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            a2 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            a3 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            a4 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            a5 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            a6 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            a7 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            a8 = true;
            round = Stop;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            a9 = true;
            round = Stop;
        }
    

        if (speedWheel >= 360)
        {
            speedWheel = 0;
            Stop += 1;


        }
        Wheel.localRotation = Quaternion.Euler(0f, 0f,speedWheel);
    }

}
