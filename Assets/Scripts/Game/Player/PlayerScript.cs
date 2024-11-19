
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    //3 min SCORE & UI - How to make a Video Game in Unity (E07)

    public float RunSpeed;
    float score;
    public float health;
    public float healthDeath;
    public float JumpForce;
    BomberPassed bomberAlert;

    [SerializeField] GameObject DeathScreen;
    public GameObject bomber;
    //bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;
    public Text ScoreTxt;
    public Text HealthTxt;

    private void Start()
    {
        score = 0;
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        bomberAlert = bomber.GetComponent<BomberPassed>();
    }

        // Update is called once per frame
        void Update()
        {
           Debug.Log(bomberAlert.bomberAtBase);

            HealthTxt.text = health.ToString("F0");


            if(Input.GetKey(KeyCode.W))
            {

                RB.AddForce(Vector2.up * JumpForce);


            }

            if(Input.GetKey(KeyCode.S))
            {

                RB.AddForce(Vector2.down * JumpForce);


            }


            if(Input.GetKey(KeyCode.D))
            {
                RB.AddForce(Vector2.right * RunSpeed);
            }

            if(Input.GetKey(KeyCode.A))
            {
                RB.AddForce(Vector2.left * RunSpeed);
            }

            if(isAlive)
            {
                score += Time.deltaTime * 4;
                ScoreTxt.text = "SCORE " + score.ToString("F0");

            }
            if (bomberAlert.bomberAtBase >= 4)
            {
                isAlive = false;
            }

    }

        private void OnCollisionEnter2D(Collision2D collision)
        {

        if (collision.gameObject.CompareTag("Bomber"))
        {
            health = healthDeath;

        }

        if (collision.gameObject.CompareTag("spike"))
        {
            health = healthDeath;
        }
        if(collision.gameObject.CompareTag("AAABullet"))
        {
             health -= 1;

        }

        if (health <= 0)
        {
            isAlive = false;
    

        }
        if (isAlive == false)
        {
            
            DeathScreen.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Dead");


        }

    }


}

