using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Intro_timer : MonoBehaviour
{
    private float timer;
    private int text_counter;
    public TextMeshPro oc;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        text_counter = 0;

        oc = GetComponent<TextMeshPro>();
        oc.text = "It started when the aliens planted the timed bomb, forcing us to migrate to space. Those who had money built space stations, us others? We had to live like slaves to come by.";

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ((text_counter == 0) && (timer >= 10))
        {
            oc.text = "Many accepted it, by I wanted more. I made a failsafe plan, assassinating a rich CEO and fleeing by giving up my body and fleeing to a clone using Wireless Mind Transplantation.";

            text_counter = 1;
            timer = 0;
        }

        if ((text_counter == 1) && (timer >= 10))
        {
            oc.text = "The plan executed flawlessly, until the WMT. The transmission got hijacked, and my mind was implanted in a pig by the CEOs accomplices. Then they left me in a cage, ready to be transported to the slaughterhouse.";

            text_counter = 2;
            timer = 0;
        }

        if ((text_counter == 2) && (timer >= 10))
        {
            oc.text = "But I managed to escape...";

            SceneManager.LoadScene(sceneName: "hydroponics");
        }
    }
}
