using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numpad_Minigame_Codes : MonoBehaviour
{
    public TextMeshPro ic;
    public TextMeshPro oc;

    public static string input_code = "";
    private int code;

    // Start is called before the first frame update
    void Start()
    {
        code = Random.Range(0, 9999);
        ic = GetComponent<TextMeshPro>();
        ic.text = "";

        oc.text = "";
        oc.text = code.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (input_code == code.ToString())
        {
            // Win condition
        }
        else if (input_code.Length > 12)
        {
            input_code = "ERROR!";
        }
        ic.text = input_code;
    }
}
