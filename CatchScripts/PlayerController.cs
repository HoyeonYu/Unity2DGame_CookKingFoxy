using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 7.0f;
    float maxWalkSpeed = 7.0f;
    float jumpForce = 780.0f;
    bool isJumping = false;
    Animator animator;
    float time, startTime = 0;
    bool isCherry, isFrog, isEgg, isTrash, isEagle;
    GameObject infoText, questCherryText, questFrogText, questEggText;
    int cherryCount, frogCount, eggCount, maxCherryCount, maxFrogCount, maxEggCount;
    string greenColor, redColor, yellowColor;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();

        this.time = this.startTime = 0;

        this.infoText = GameObject.Find("InfoText");
        this.questCherryText = GameObject.Find("QuestCherryText");
        this.questFrogText = GameObject.Find("QuestFrogText");
        this.questEggText = GameObject.Find("QuestEggText");

        this.isCherry = this.isFrog = this.isEgg = this.isTrash = this.isEagle = false;
        this.cherryCount = this.frogCount = this.frogCount = 0;

        this.maxCherryCount = 1;
        this.maxFrogCount = 2;
        this.maxEggCount = 3;

        this.greenColor = "<color=#00C90D>";
        this.redColor = "<color=#FF0000>";
        this.yellowColor = "<color=#FFCC00>";
    }

    void Update()
    {
        int key = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1;
            animator.SetBool("isRun", true);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
            animator.SetBool("isRun", true);
        }

        else
        {
            animator.SetBool("isRun", false);
        }

        float speedX = Mathf.Abs(this.rigid2D.velocity.x);

        if (speedX < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key * Mathf.Abs(transform.localScale.x), transform.localScale.y, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && !this.isJumping)
        {
            this.isJumping = true;
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        this.time += Time.deltaTime;
        float remainTime = this.time - startTime;

        if (this.startTime != 0 && remainTime < 1)
        {
            if (this.isCherry)
            {
                this.infoText.GetComponent<Text>().text = this.yellowColor + "<b>[√º∏Æ]</b></color> ¿ª/∏¶ »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
                this.isCherry = false;
            }

            if (this.isFrog)
            {
                this.infoText.GetComponent<Text>().text = this.yellowColor + "<b>[∞≥±∏∏Æ]</b></color> ¿ª/∏¶ »πµÊ«œºÃΩ¿¥œ¥Ÿ.";
                this.isFrog = false;
            }

            if (this.isEgg)
            {
                this.infoText.GetComponent<Text>().text = this.yellowColor + "<b>[¥ﬁ∞ø]</b></color> ¿ª/∏¶ »πµÊ«œºÃΩ¿¥œ¥Ÿ."; 
                this.isEgg = false;
            }

            if (this.isTrash)
            {
                this.infoText.GetComponent<Text>().text = this.redColor + "<b>[æ≤∑π±‚]</b></color> ∏¶ ¥„æ∆ ¿Á∑·∞° ∏µŒ ªÛ«ﬂΩ¿¥œ¥Ÿ.";
                this.isTrash = false;
            }
        }

        else
        {
            this.infoText.GetComponent<Text>().text = "";
        }

        string cherryMessage = this.cherryCount.ToString() + " / " + this.maxCherryCount.ToString();
        string frogMessage = this.frogCount.ToString() + " / " + this.maxFrogCount.ToString();
        string eggMessage = this.eggCount.ToString() + " / " + this.maxEggCount.ToString();
        string color;

        color = ((this.cherryCount >= this.maxCherryCount) ? this.greenColor : this.redColor);
        cherryMessage = color + cherryMessage + "</color>";
        this.questCherryText.GetComponent<Text>().text = cherryMessage;

        color = ((this.frogCount >= this.maxFrogCount) ? this.greenColor : this.redColor);
        frogMessage = color + frogMessage + "</color>";
        this.questFrogText.GetComponent<Text>().text = frogMessage;

        color = ((this.eggCount >= this.maxEggCount) ? this.greenColor : this.redColor);
        eggMessage = color + eggMessage + "</color>";
        this.questEggText.GetComponent<Text>().text = eggMessage;

        if (transform.position.y < -12.0f || this.isEagle)
        {
            transform.position = new Vector3(0.5f, 2f, 0);
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<CatchGameDirector>().DecreaseHp();
            this.isEagle = false;

            GameObject camera = GameObject.Find("MainCamera");
            camera.GetComponent<CameraShake>().shakeDuration = 0.2f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            this.isJumping = false;
        }

        if (collision.transform.tag == "Cherry")
        {
            this.startTime = this.time;
            this.isCherry = true;
            Destroy(collision.gameObject);
            this.cherryCount++;
        }

        if (collision.transform.tag == "Frog")
        {
            this.startTime = this.time;
            this.isFrog = true;
            Destroy(collision.gameObject);
            this.frogCount++;
        }

        if (collision.transform.tag == "Egg")
        {
            this.startTime = this.time;
            this.isEgg = true;
            Destroy(collision.gameObject);
            this.eggCount++;
        }

        if (collision.transform.tag == "Trash")
        {
            this.startTime = this.time;
            this.isTrash = true;
            Destroy(collision.gameObject);
            this.cherryCount = this.frogCount = this.eggCount = 0;
        }

        if (collision.transform.tag == "Eagle")
        {
            this.startTime = this.time;
            this.isEagle = true;
            Destroy(collision.gameObject);
        }
    }
}
