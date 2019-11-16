using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Level2_timer : MonoBehaviour
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
        oc.text = "I managed to escape from my capturers, and found myself in temporary safety. While I tried to acquaintance myself with my new body and tried to find a way back in my clone, a transmission was broadcasted on the whole space station.";

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if ((text_counter == 0) && (timer >= 15))
        {
            oc.text = "Apparently the CEOs accomplices had taken my wife hostage in another pigs body, and would slaughter her if I didn't turn myself in. I instantly knew that there was no time for finding a way back into my clone, I had to take action now!";

            text_counter = 1;
            timer = 0;
        }
        if ((text_counter == 1) && (timer >= 15))
        {
            oc.text = "Congratulations and thanks for playing! This is where the current Demo ends, please press any key to exit, and we hope you enjoyed this little story. :)";

            text_counter = 2;
            timer = 0;
        }

        if (text_counter == 2)
        {
            //SceneManager.LoadScene(sceneName: "hydroponics");
            if (Input.anyKey)
            {
                Application.Quit();
            }
        }

    }
}
